namespace barkod
{
    partial class Form1
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
            this.Kaydet = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_ürünmarka = new System.Windows.Forms.TextBox();
            this.textBox_ürünadı = new System.Windows.Forms.TextBox();
            this.textBox_ürünözel = new System.Windows.Forms.TextBox();
            this.textBox_fiyat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_stok = new System.Windows.Forms.TextBox();
            this.Ürünler = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox_barkodno = new System.Windows.Forms.MaskedTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.silme = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.maskedTextBox_ÜAra = new System.Windows.Forms.MaskedTextBox();
            this.güncelle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.barkodnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunmarkasiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunozellikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fiyatiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kalanstokDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.barkod_OkuyucuDataSet = new barkod.Barkod_OkuyucuDataSet();
            this.urunlerTableAdapter = new barkod.Barkod_OkuyucuDataSetTableAdapters.UrunlerTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ürünlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faturaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.raporToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.Ürünler.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barkod_OkuyucuDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Kaydet
            // 
            this.Kaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Kaydet.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Kaydet.Image = global::barkod.Properties.Resources._3floppy_unmount1;
            this.Kaydet.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Kaydet.Location = new System.Drawing.Point(242, 336);
            this.Kaydet.Name = "Kaydet";
            this.Kaydet.Size = new System.Drawing.Size(100, 38);
            this.Kaydet.TabIndex = 0;
            this.Kaydet.Text = "Kaydet";
            this.Kaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Kaydet.UseVisualStyleBackColor = true;
            this.Kaydet.Click += new System.EventHandler(this.Kaydet_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Label1.Location = new System.Drawing.Point(154, 67);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(119, 16);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "Barkod Numarası :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(154, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ürünün Markası :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(153, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ürünün Adı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(153, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ürünün Özellikleri :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(153, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Fiyatı :";
            // 
            // textBox_ürünmarka
            // 
            this.textBox_ürünmarka.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBox_ürünmarka.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_ürünmarka.Location = new System.Drawing.Point(333, 103);
            this.textBox_ürünmarka.Name = "textBox_ürünmarka";
            this.textBox_ürünmarka.Size = new System.Drawing.Size(106, 22);
            this.textBox_ürünmarka.TabIndex = 7;
            // 
            // textBox_ürünadı
            // 
            this.textBox_ürünadı.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBox_ürünadı.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_ürünadı.Location = new System.Drawing.Point(333, 143);
            this.textBox_ürünadı.Name = "textBox_ürünadı";
            this.textBox_ürünadı.Size = new System.Drawing.Size(106, 22);
            this.textBox_ürünadı.TabIndex = 8;
            // 
            // textBox_ürünözel
            // 
            this.textBox_ürünözel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBox_ürünözel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_ürünözel.Location = new System.Drawing.Point(333, 184);
            this.textBox_ürünözel.Name = "textBox_ürünözel";
            this.textBox_ürünözel.Size = new System.Drawing.Size(106, 22);
            this.textBox_ürünözel.TabIndex = 9;
            // 
            // textBox_fiyat
            // 
            this.textBox_fiyat.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBox_fiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_fiyat.Location = new System.Drawing.Point(333, 224);
            this.textBox_fiyat.Name = "textBox_fiyat";
            this.textBox_fiyat.Size = new System.Drawing.Size(106, 22);
            this.textBox_fiyat.TabIndex = 10;
            this.textBox_fiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_fiyat_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(153, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Stok :";
            // 
            // textBox_stok
            // 
            this.textBox_stok.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBox_stok.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_stok.Location = new System.Drawing.Point(333, 263);
            this.textBox_stok.Name = "textBox_stok";
            this.textBox_stok.Size = new System.Drawing.Size(106, 22);
            this.textBox_stok.TabIndex = 12;
            this.textBox_stok.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_fiyat_KeyPress);
            // 
            // Ürünler
            // 
            this.Ürünler.Controls.Add(this.tabPage1);
            this.Ürünler.Controls.Add(this.tabPage2);
            this.Ürünler.Location = new System.Drawing.Point(12, 50);
            this.Ürünler.Name = "Ürünler";
            this.Ürünler.SelectedIndex = 0;
            this.Ürünler.Size = new System.Drawing.Size(660, 495);
            this.Ürünler.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tabPage1.Controls.Add(this.textBox_barkodno);
            this.tabPage1.Controls.Add(this.textBox_fiyat);
            this.tabPage1.Controls.Add(this.textBox_stok);
            this.tabPage1.Controls.Add(this.Kaydet);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.Label1);
            this.tabPage1.Controls.Add(this.textBox_ürünözel);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.textBox_ürünadı);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.textBox_ürünmarka);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(652, 469);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Kayıt Yap";
            // 
            // textBox_barkodno
            // 
            this.textBox_barkodno.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBox_barkodno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_barkodno.Location = new System.Drawing.Point(333, 62);
            this.textBox_barkodno.Mask = "0000000000000";
            this.textBox_barkodno.Name = "textBox_barkodno";
            this.textBox_barkodno.Size = new System.Drawing.Size(106, 22);
            this.textBox_barkodno.TabIndex = 13;
            this.textBox_barkodno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tabPage2.Controls.Add(this.silme);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.maskedTextBox_ÜAra);
            this.tabPage2.Controls.Add(this.güncelle);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(652, 469);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Kayıtlar";
            // 
            // silme
            // 
            this.silme.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.silme.Image = global::barkod.Properties.Resources.Dark_Shine_Icon_07;
            this.silme.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.silme.Location = new System.Drawing.Point(145, 120);
            this.silme.Name = "silme";
            this.silme.Size = new System.Drawing.Size(66, 44);
            this.silme.TabIndex = 7;
            this.silme.Text = "Sil";
            this.silme.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.silme.UseVisualStyleBackColor = true;
            this.silme.Click += new System.EventHandler(this.silme_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Location = new System.Drawing.Point(217, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(426, 180);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Güncelle";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Image = global::barkod.Properties.Resources.edit_add;
            this.button2.Location = new System.Drawing.Point(323, 130);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(44, 43);
            this.button2.TabIndex = 28;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Image = global::barkod.Properties.Resources.edit_remove;
            this.button1.Location = new System.Drawing.Point(373, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 43);
            this.button1.TabIndex = 27;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBox6.Location = new System.Drawing.Point(217, 142);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 26;
            this.textBox6.Text = "Stok Ekle-Çıkar";
            this.textBox6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox6_MouseClick);
            this.textBox6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox6_KeyPress);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.maskedTextBox1.Enabled = false;
            this.maskedTextBox1.Location = new System.Drawing.Point(111, 19);
            this.maskedTextBox1.Mask = "0000000000000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 25;
            this.maskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBox1.Location = new System.Drawing.Point(111, 119);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 22;
            this.textBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseClick);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(111, 142);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 24;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Stok :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Enabled = false;
            this.label9.Location = new System.Drawing.Point(13, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Barkod Numarası :";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBox3.Location = new System.Drawing.Point(111, 94);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Ürünün Markası :";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBox4.Location = new System.Drawing.Point(111, 71);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Ürünün Adı :";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBox5.Location = new System.Drawing.Point(111, 45);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 97);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Ürünün Özellikleri :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 122);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "Fiyatı :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Barkod No Ara :";
            // 
            // maskedTextBox_ÜAra
            // 
            this.maskedTextBox_ÜAra.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.maskedTextBox_ÜAra.Location = new System.Drawing.Point(96, 21);
            this.maskedTextBox_ÜAra.Mask = "0000000000000";
            this.maskedTextBox_ÜAra.Name = "maskedTextBox_ÜAra";
            this.maskedTextBox_ÜAra.Size = new System.Drawing.Size(115, 20);
            this.maskedTextBox_ÜAra.TabIndex = 3;
            this.maskedTextBox_ÜAra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBox_ÜAra.TextChanged += new System.EventHandler(this.maskedTextBox_ÜAra_TextChanged);
            // 
            // güncelle
            // 
            this.güncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.güncelle.Image = global::barkod.Properties.Resources.Dark_Shine_Icon_27;
            this.güncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.güncelle.Location = new System.Drawing.Point(10, 120);
            this.güncelle.Name = "güncelle";
            this.güncelle.Size = new System.Drawing.Size(129, 44);
            this.güncelle.TabIndex = 2;
            this.güncelle.Text = "Değişiklikleri Kaydet";
            this.güncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.güncelle.UseVisualStyleBackColor = true;
            this.güncelle.Click += new System.EventHandler(this.güncelle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.barkodnoDataGridViewTextBoxColumn,
            this.urunmarkasiDataGridViewTextBoxColumn,
            this.urunadiDataGridViewTextBoxColumn,
            this.urunozellikDataGridViewTextBoxColumn,
            this.fiyatiDataGridViewTextBoxColumn,
            this.kalanstokDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.urunlerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(4, 192);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(644, 271);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // barkodnoDataGridViewTextBoxColumn
            // 
            this.barkodnoDataGridViewTextBoxColumn.DataPropertyName = "Barkod_no";
            this.barkodnoDataGridViewTextBoxColumn.HeaderText = "Barkod_no";
            this.barkodnoDataGridViewTextBoxColumn.Name = "barkodnoDataGridViewTextBoxColumn";
            this.barkodnoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // urunmarkasiDataGridViewTextBoxColumn
            // 
            this.urunmarkasiDataGridViewTextBoxColumn.DataPropertyName = "urun_markasi";
            this.urunmarkasiDataGridViewTextBoxColumn.HeaderText = "urun_markasi";
            this.urunmarkasiDataGridViewTextBoxColumn.Name = "urunmarkasiDataGridViewTextBoxColumn";
            this.urunmarkasiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // urunadiDataGridViewTextBoxColumn
            // 
            this.urunadiDataGridViewTextBoxColumn.DataPropertyName = "urun_adi";
            this.urunadiDataGridViewTextBoxColumn.HeaderText = "urun_adi";
            this.urunadiDataGridViewTextBoxColumn.Name = "urunadiDataGridViewTextBoxColumn";
            this.urunadiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // urunozellikDataGridViewTextBoxColumn
            // 
            this.urunozellikDataGridViewTextBoxColumn.DataPropertyName = "urun_ozellik";
            this.urunozellikDataGridViewTextBoxColumn.HeaderText = "urun_ozellik";
            this.urunozellikDataGridViewTextBoxColumn.Name = "urunozellikDataGridViewTextBoxColumn";
            this.urunozellikDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fiyatiDataGridViewTextBoxColumn
            // 
            this.fiyatiDataGridViewTextBoxColumn.DataPropertyName = "fiyati";
            this.fiyatiDataGridViewTextBoxColumn.HeaderText = "fiyati";
            this.fiyatiDataGridViewTextBoxColumn.Name = "fiyatiDataGridViewTextBoxColumn";
            this.fiyatiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kalanstokDataGridViewTextBoxColumn
            // 
            this.kalanstokDataGridViewTextBoxColumn.DataPropertyName = "kalan_stok";
            this.kalanstokDataGridViewTextBoxColumn.HeaderText = "kalan_stok";
            this.kalanstokDataGridViewTextBoxColumn.Name = "kalanstokDataGridViewTextBoxColumn";
            this.kalanstokDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // urunlerBindingSource
            // 
            this.urunlerBindingSource.DataMember = "Urunler";
            this.urunlerBindingSource.DataSource = this.barkod_OkuyucuDataSet;
            // 
            // barkod_OkuyucuDataSet
            // 
            this.barkod_OkuyucuDataSet.DataSetName = "Barkod_OkuyucuDataSet";
            this.barkod_OkuyucuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // urunlerTableAdapter
            // 
            this.urunlerTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ürünlerToolStripMenuItem,
            this.faturaToolStripMenuItem,
            this.faturaToolStripMenuItem1,
            this.toolStripMenuItem1,
            this.raporToolStripMenuItem,
            this.hakkındaToolStripMenuItem,
            this.toolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(680, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ürünlerToolStripMenuItem
            // 
            this.ürünlerToolStripMenuItem.Enabled = false;
            this.ürünlerToolStripMenuItem.Name = "ürünlerToolStripMenuItem";
            this.ürünlerToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.ürünlerToolStripMenuItem.Text = "Ürünler";
            // 
            // faturaToolStripMenuItem
            // 
            this.faturaToolStripMenuItem.Name = "faturaToolStripMenuItem";
            this.faturaToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.faturaToolStripMenuItem.Text = "Satış Yap";
            this.faturaToolStripMenuItem.Click += new System.EventHandler(this.faturaToolStripMenuItem_Click);
            // 
            // faturaToolStripMenuItem1
            // 
            this.faturaToolStripMenuItem1.Name = "faturaToolStripMenuItem1";
            this.faturaToolStripMenuItem1.Size = new System.Drawing.Size(64, 20);
            this.faturaToolStripMenuItem1.Text = "Fatura";
            this.faturaToolStripMenuItem1.Click += new System.EventHandler(this.faturaToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // raporToolStripMenuItem
            // 
            this.raporToolStripMenuItem.Name = "raporToolStripMenuItem";
            this.raporToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.raporToolStripMenuItem.Text = "Rapor";
            this.raporToolStripMenuItem.Click += new System.EventHandler(this.raporToolStripMenuItem_Click);
            // 
            // hakkındaToolStripMenuItem
            // 
            this.hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            this.hakkındaToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.hakkındaToolStripMenuItem.Text = "Hakkında";
            this.hakkındaToolStripMenuItem.Click += new System.EventHandler(this.hakkındaToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(54, 20);
            this.toolStripMenuItem2.Text = "Çıkış";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(680, 551);
            this.ControlBox = false;
            this.Controls.Add(this.Ürünler);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ÜRÜNLER";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Ürünler.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barkod_OkuyucuDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Kaydet;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_ürünmarka;
        private System.Windows.Forms.TextBox textBox_ürünadı;
        private System.Windows.Forms.TextBox textBox_ürünözel;
        private System.Windows.Forms.TextBox textBox_fiyat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_stok;
        private System.Windows.Forms.TabControl Ürünler;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button güncelle;
        private System.Windows.Forms.MaskedTextBox textBox_barkodno;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_ÜAra;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridViewTextBoxColumn barkodnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunmarkasiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunozellikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiyatiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kalanstokDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button silme;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ürünlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faturaToolStripMenuItem1;
        public System.Windows.Forms.DataGridView dataGridView1;
        public Barkod_OkuyucuDataSet barkod_OkuyucuDataSet;
        public System.Windows.Forms.BindingSource urunlerBindingSource;
        public Barkod_OkuyucuDataSetTableAdapters.UrunlerTableAdapter urunlerTableAdapter;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem raporToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;

        public System.Windows.Forms.MaskInputRejectedEventHandler maskedTextBox_ÜAra_MaskInputRejected { get; set; }
    }
}

