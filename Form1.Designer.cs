namespace task
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.dataSet1 = new task.DataSet1();
            this.eMPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eMPTableAdapter = new task.DataSet1TableAdapters.EMPTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_download = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(660, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 24);
            this.button1.TabIndex = 1;
            this.button1.Text = "клиенты";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eMPBindingSource
            // 
            this.eMPBindingSource.DataMember = "EMP";
            this.eMPBindingSource.DataSource = this.dataSet1;
            // 
            // eMPTableAdapter
            // 
            this.eMPTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(35, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(581, 376);
            this.dataGridView1.TabIndex = 2;
            // 
            // button_download
            // 
            this.button_download.Location = new System.Drawing.Point(660, 312);
            this.button_download.Name = "button_download";
            this.button_download.Size = new System.Drawing.Size(132, 27);
            this.button_download.TabIndex = 3;
            this.button_download.Text = "download";
            this.button_download.UseVisualStyleBackColor = true;
            this.button_download.Click += new System.EventHandler(this.button_download_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(663, 121);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 26);
            this.button2.TabIndex = 4;
            this.button2.Text = "credit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(722, 173);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(70, 28);
            this.button3.TabIndex = 5;
            this.button3.Text = "info";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(663, 258);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(128, 33);
            this.button_update.TabIndex = 6;
            this.button_update.Text = "update data";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(667, 178);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(45, 20);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 471);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button_download);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource eMPBindingSource;
        private DataSet1TableAdapters.EMPTableAdapter eMPTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_download;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.TextBox textBox1;
    }
}

