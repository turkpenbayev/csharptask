using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System.IO;

namespace task
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        OracleConnection con = new OracleConnection("User id=newuser;Password=password;Data Source=XE;Pooling=false;");
        OracleCommandBuilder cmdbl;
        OracleDataAdapter oda;
        DataTable dt;
        private void ToCsV(DataGridView dGV, string filename)
        {
            string stOutput = "";
            // Export titles:
            string sHeaders = "";

            for (int j = 0; j < dGV.Columns.Count; j++)
                sHeaders = sHeaders.ToString() + Convert.ToString(dGV.Columns[j].HeaderText) + "\t";
            stOutput += sHeaders + "\r\n";
            // Export data.
            for (int i = 0; i < dGV.RowCount - 1; i++)
            {
                string stLine = "";
                for (int j = 0; j < dGV.Rows[i].Cells.Count; j++)
                    stLine = stLine.ToString() + Convert.ToString(dGV.Rows[i].Cells[j].Value) + "\t";
                stOutput += stLine + "\r\n";
            }
            Encoding utf16 = Encoding.GetEncoding(1254);
            byte[] output = utf16.GetBytes(stOutput);
            FileStream fs = new FileStream(filename, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(output, 0, output.Length); //write the encoded file
            bw.Flush();
            bw.Close();
            fs.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            con.Open();
            oda = new OracleDataAdapter("select * from client order by id", con);
            dt = new DataTable();
            oda.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();
        }

        private void button_download_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Documents (*.xls)|*.xls";
            sfd.FileName = "export.xls";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                //ToCsV(dataGridView1, @"c:\export.xls");
                ToCsV(dataGridView1, sfd.FileName); // Here dataGridview1 is your grid view name
                MessageBox.Show("Downloaded", "Succesfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            oda = new OracleDataAdapter("select * from credit order by id", con);
            dt = new DataTable();
            oda.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            string client_id = textBox1.Text;
            string query = "select client.name as client_name, client.salary as salary, credit.id as credit_id, credit_no,credit.amount from credit, client where credit.clinet_id="+client_id+ " and client.id=" + client_id + "order by client.id";
            oda = new OracleDataAdapter(query, con);
            dt = new DataTable();
            oda.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            try
            {
                cmdbl = new OracleCommandBuilder(oda);
                oda.Update(dt);
                MessageBox.Show("updated", "Succesfullu saved!",MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error\n", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
