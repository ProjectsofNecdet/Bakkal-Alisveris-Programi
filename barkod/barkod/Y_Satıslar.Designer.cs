namespace barkod
{
    partial class Y_Satıslar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.RaporBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Barkod_OkuyucuDataSet3 = new barkod.Barkod_OkuyucuDataSet3();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.barkodnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faturanoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satısBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.barkod_OkuyucuDataSet4 = new barkod.Barkod_OkuyucuDataSet4();
            this.satısBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.barkod_OkuyucuDataSet2 = new barkod.Barkod_OkuyucuDataSet2();
            this.satısTableAdapter = new barkod.Barkod_OkuyucuDataSet2TableAdapters.SatısTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.RaporTableAdapter = new barkod.Barkod_OkuyucuDataSet3TableAdapters.RaporTableAdapter();
            this.maskedTextBox_ÜAra = new System.Windows.Forms.MaskedTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.satısTableAdapter1 = new barkod.Barkod_OkuyucuDataSet4TableAdapters.SatısTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RaporBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Barkod_OkuyucuDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.satısBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barkod_OkuyucuDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.satısBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barkod_OkuyucuDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // RaporBindingSource
            // 
            this.RaporBindingSource.DataMember = "Rapor";
            this.RaporBindingSource.DataSource = this.Barkod_OkuyucuDataSet3;
            // 
            // Barkod_OkuyucuDataSet3
            // 
            this.Barkod_OkuyucuDataSet3.DataSetName = "Barkod_OkuyucuDataSet3";
            this.Barkod_OkuyucuDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.barkodnoDataGridViewTextBoxColumn,
            this.faturanoDataGridViewTextBoxColumn,
            this.adetDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.satısBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(8, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(343, 288);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // barkodnoDataGridViewTextBoxColumn
            // 
            this.barkodnoDataGridViewTextBoxColumn.DataPropertyName = "Barkod_no";
            this.barkodnoDataGridViewTextBoxColumn.HeaderText = "Barkod_no";
            this.barkodnoDataGridViewTextBoxColumn.Name = "barkodnoDataGridViewTextBoxColumn";
            // 
            // faturanoDataGridViewTextBoxColumn
            // 
            this.faturanoDataGridViewTextBoxColumn.DataPropertyName = "fatura_no";
            this.faturanoDataGridViewTextBoxColumn.HeaderText = "fatura_no";
            this.faturanoDataGridViewTextBoxColumn.Name = "faturanoDataGridViewTextBoxColumn";
            // 
            // adetDataGridViewTextBoxColumn
            // 
            this.adetDataGridViewTextBoxColumn.DataPropertyName = "adet";
            this.adetDataGridViewTextBoxColumn.HeaderText = "adet";
            this.adetDataGridViewTextBoxColumn.Name = "adetDataGridViewTextBoxColumn";
            // 
            // satısBindingSource1
            // 
            this.satısBindingSource1.DataMember = "Satıs";
            this.satısBindingSource1.DataSource = this.barkod_OkuyucuDataSet4;
            // 
            // barkod_OkuyucuDataSet4
            // 
            this.barkod_OkuyucuDataSet4.DataSetName = "Barkod_OkuyucuDataSet4";
            this.barkod_OkuyucuDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // satısBindingSource
            // 
            this.satısBindingSource.DataMember = "Satıs";
            this.satısBindingSource.DataSource = this.barkod_OkuyucuDataSet2;
            // 
            // barkod_OkuyucuDataSet2
            // 
            this.barkod_OkuyucuDataSet2.DataSetName = "Barkod_OkuyucuDataSet2";
            this.barkod_OkuyucuDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // satısTableAdapter
            // 
            this.satısTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(5, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Silinecek Ürün :";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(283, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 22);
            this.button1.TabIndex = 27;
            this.button1.Text = "SİL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RaporTableAdapter
            // 
            this.RaporTableAdapter.ClearBeforeFill = true;
            // 
            // maskedTextBox_ÜAra
            // 
            this.maskedTextBox_ÜAra.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.maskedTextBox_ÜAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedTextBox_ÜAra.Location = new System.Drawing.Point(138, 49);
            this.maskedTextBox_ÜAra.Mask = "0000000000000";
            this.maskedTextBox_ÜAra.Name = "maskedTextBox_ÜAra";
            this.maskedTextBox_ÜAra.Size = new System.Drawing.Size(139, 22);
            this.maskedTextBox_ÜAra.TabIndex = 29;
            this.maskedTextBox_ÜAra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBox_ÜAra.TextChanged += new System.EventHandler(this.maskedTextBox_ÜAra_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(138, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(139, 22);
            this.textBox1.TabIndex = 30;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress_1);
            // 
            // satısTableAdapter1
            // 
            this.satısTableAdapter1.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(5, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 16);
            this.label2.TabIndex = 31;
            this.label2.Text = "Fatura Numarası :";
            // 
            // Y_Satıslar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(359, 381);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.maskedTextBox_ÜAra);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Y_Satıslar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YAPILAN SATIŞLAR";
            this.Load += new System.EventHandler(this.Y_Satıslar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RaporBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Barkod_OkuyucuDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.satısBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barkod_OkuyucuDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.satısBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barkod_OkuyucuDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Barkod_OkuyucuDataSet2 barkod_OkuyucuDataSet2;
        private System.Windows.Forms.BindingSource satısBindingSource;
        private Barkod_OkuyucuDataSet2TableAdapters.SatısTableAdapter satısTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn barkodnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faturanoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adetDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource RaporBindingSource;
        private Barkod_OkuyucuDataSet3 Barkod_OkuyucuDataSet3;
        private Barkod_OkuyucuDataSet3TableAdapters.RaporTableAdapter RaporTableAdapter;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_ÜAra;
        private System.Windows.Forms.TextBox textBox1;
        private Barkod_OkuyucuDataSet4 barkod_OkuyucuDataSet4;
        private System.Windows.Forms.BindingSource satısBindingSource1;
        private Barkod_OkuyucuDataSet4TableAdapters.SatısTableAdapter satısTableAdapter1;
        private System.Windows.Forms.Label label2;
    }
}