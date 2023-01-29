namespace CarRentalSystem
{
    partial class FormAracListele
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboAraclar = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.txtKm = new System.Windows.Forms.TextBox();
            this.comboYakit = new System.Windows.Forms.ComboBox();
            this.comboSeri = new System.Windows.Forms.ComboBox();
            this.comboMarka = new System.Windows.Forms.ComboBox();
            this.txtRenk = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtKira = new System.Windows.Forms.TextBox();
            this.txtPlaka = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.Location = new System.Drawing.Point(648, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(762, 398);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // comboAraclar
            // 
            this.comboAraclar.FormattingEnabled = true;
            this.comboAraclar.Items.AddRange(new object[] {
            "Tüm Araçlar",
            "Boştaki Araçlar",
            "Dolu Araçlar"});
            this.comboAraclar.Location = new System.Drawing.Point(1259, 39);
            this.comboAraclar.Name = "comboAraclar";
            this.comboAraclar.Size = new System.Drawing.Size(151, 28);
            this.comboAraclar.TabIndex = 1;
            this.comboAraclar.SelectedIndexChanged += new System.EventHandler(this.comboAraclar_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(446, 289);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 37);
            this.button3.TabIndex = 38;
            this.button3.Text = "Resim Değiştir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(245, 438);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(93, 51);
            this.btnIptal.TabIndex = 37;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(126, 438);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(89, 51);
            this.btnGuncelle.TabIndex = 36;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // txtKm
            // 
            this.txtKm.Location = new System.Drawing.Point(126, 303);
            this.txtKm.Name = "txtKm";
            this.txtKm.Size = new System.Drawing.Size(212, 27);
            this.txtKm.TabIndex = 35;
            // 
            // comboYakit
            // 
            this.comboYakit.FormattingEnabled = true;
            this.comboYakit.Items.AddRange(new object[] {
            "Dizel",
            "Benzin",
            "Dizel + LPG"});
            this.comboYakit.Location = new System.Drawing.Point(126, 344);
            this.comboYakit.Name = "comboYakit";
            this.comboYakit.Size = new System.Drawing.Size(212, 28);
            this.comboYakit.TabIndex = 34;
            // 
            // comboSeri
            // 
            this.comboSeri.FormattingEnabled = true;
            this.comboSeri.Location = new System.Drawing.Point(126, 165);
            this.comboSeri.Name = "comboSeri";
            this.comboSeri.Size = new System.Drawing.Size(212, 28);
            this.comboSeri.TabIndex = 33;
            // 
            // comboMarka
            // 
            this.comboMarka.FormattingEnabled = true;
            this.comboMarka.Items.AddRange(new object[] {
            "Opel",
            "Renault",
            "Fiat",
            "Ford"});
            this.comboMarka.Location = new System.Drawing.Point(126, 119);
            this.comboMarka.Name = "comboMarka";
            this.comboMarka.Size = new System.Drawing.Size(212, 28);
            this.comboMarka.TabIndex = 32;
            this.comboMarka.SelectedIndexChanged += new System.EventHandler(this.comboMarka_SelectedIndexChanged);
            // 
            // txtRenk
            // 
            this.txtRenk.Location = new System.Drawing.Point(126, 257);
            this.txtRenk.Name = "txtRenk";
            this.txtRenk.Size = new System.Drawing.Size(212, 27);
            this.txtRenk.TabIndex = 31;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(126, 207);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(212, 27);
            this.txtModel.TabIndex = 30;
            // 
            // txtKira
            // 
            this.txtKira.Location = new System.Drawing.Point(126, 391);
            this.txtKira.Name = "txtKira";
            this.txtKira.Size = new System.Drawing.Size(212, 27);
            this.txtKira.TabIndex = 29;
            // 
            // txtPlaka
            // 
            this.txtPlaka.Location = new System.Drawing.Point(126, 73);
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.Size = new System.Drawing.Size(212, 27);
            this.txtPlaka.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(29, 395);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 23);
            this.label8.TabIndex = 27;
            this.label8.Text = "Kira Ücreti";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(67, 349);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 23);
            this.label7.TabIndex = 26;
            this.label7.Text = "Yakıt";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(76, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 23);
            this.label6.TabIndex = 25;
            this.label6.Text = "Km";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(66, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 23);
            this.label5.TabIndex = 24;
            this.label5.Text = "Renk";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(25, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 23);
            this.label4.TabIndex = 23;
            this.label4.Text = "Model (Yıl)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(73, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 23);
            this.label3.TabIndex = 22;
            this.label3.Text = "Seri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(57, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 23);
            this.label2.TabIndex = 21;
            this.label2.Text = "Marka";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(63, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 23);
            this.label1.TabIndex = 20;
            this.label1.Text = "Plaka";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FloralWhite;
            this.pictureBox2.Location = new System.Drawing.Point(378, 73);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(250, 194);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 40;
            this.pictureBox2.TabStop = false;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(648, 477);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(82, 53);
            this.btnSil.TabIndex = 41;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormAracListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(1449, 632);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.txtKm);
            this.Controls.Add(this.comboYakit);
            this.Controls.Add(this.comboSeri);
            this.Controls.Add(this.comboMarka);
            this.Controls.Add(this.txtRenk);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtKira);
            this.Controls.Add(this.txtPlaka);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboAraclar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormAracListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Araç Listeleme Sayfası";
            this.Load += new System.EventHandler(this.FormAracListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private ComboBox comboAraclar;
        private Button button3;
        private Button btnIptal;
        private Button btnGuncelle;
        private TextBox txtKm;
        private ComboBox comboYakit;
        private ComboBox comboSeri;
        private ComboBox comboMarka;
        private TextBox txtRenk;
        private TextBox txtModel;
        private TextBox txtKira;
        private TextBox txtPlaka;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox2;
        private Button btnSil;
        private OpenFileDialog openFileDialog1;
    }
}