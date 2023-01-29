namespace CarRentalSystem
{
    partial class FormAnaSayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAnaSayfa));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Turquoise;
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(-1, 303);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1028, 232);
            this.panel1.TabIndex = 0;
            // 
            // button7
            // 
            this.button7.ImageIndex = 5;
            this.button7.ImageList = this.imageList1;
            this.button7.Location = new System.Drawing.Point(924, 54);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(88, 125);
            this.button7.TabIndex = 6;
            this.button7.Text = "Çıkış";
            this.button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Musteri-removebg-preview.png");
            this.imageList1.Images.SetKeyName(1, "listMusteri-removebg-preview.png");
            this.imageList1.Images.SetKeyName(2, "car-removebg-preview.png");
            this.imageList1.Images.SetKeyName(3, "Sozlesme-removebg-preview.png");
            this.imageList1.Images.SetKeyName(4, "Sales-removebg-preview.png");
            this.imageList1.Images.SetKeyName(5, "exit.png");
            // 
            // button6
            // 
            this.button6.ImageIndex = 4;
            this.button6.ImageList = this.imageList1;
            this.button6.Location = new System.Drawing.Point(758, 37);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(145, 158);
            this.button6.TabIndex = 5;
            this.button6.Text = "Satışlar";
            this.button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.ImageIndex = 3;
            this.button5.ImageList = this.imageList1;
            this.button5.Location = new System.Drawing.Point(607, 37);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(145, 158);
            this.button5.TabIndex = 4;
            this.button5.Text = "Sözleşme";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.ImageIndex = 1;
            this.button4.ImageList = this.imageList1;
            this.button4.Location = new System.Drawing.Point(456, 37);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(145, 158);
            this.button4.TabIndex = 3;
            this.button4.Text = "Araç Listeleme";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.ImageIndex = 2;
            this.button3.ImageList = this.imageList1;
            this.button3.Location = new System.Drawing.Point(305, 37);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(145, 158);
            this.button3.TabIndex = 2;
            this.button3.Text = "Araç Ekleme";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.ImageIndex = 1;
            this.button2.ImageList = this.imageList1;
            this.button2.Location = new System.Drawing.Point(154, 37);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 158);
            this.button2.TabIndex = 1;
            this.button2.Text = "Müşterş Listele";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.ImageIndex = 0;
            this.button1.ImageList = this.imageList1;
            this.button1.Location = new System.Drawing.Point(3, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 158);
            this.button1.TabIndex = 0;
            this.button1.Text = "Müşteri Ekleme";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CarRentalSystem.Properties.Resources.car_rental_image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1023, 532);
            this.Controls.Add(this.panel1);
            this.Name = "FormAnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAnaSayfa";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private ImageList imageList1;
    }
}