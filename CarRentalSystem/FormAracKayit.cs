using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalSystem
{
    public partial class FormAracKayit : Form
    {
        Arac_Kiralama arac_Kiralama = new Arac_Kiralama();
        public FormAracKayit()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                comboSeri.Items.Clear();
                if (comboMarka.SelectedItem.ToString() == "Opel")
                {
                    comboSeri.Items.Add("Astra");
                    comboSeri.Items.Add("Vectra");
                    comboSeri.Items.Add("Corsa");
                }
                else if(comboMarka.SelectedItem.ToString() == "Renault")
                {
                    comboSeri.Items.Add("Megane");
                    comboSeri.Items.Add("Clio");
                    comboSeri.Items.Add("Symbol");
                }
                else if (comboMarka.SelectedItem.ToString() == "Fiat")
                {
                    comboSeri.Items.Add("Linea");
                    comboSeri.Items.Add("Egea");
                    comboSeri.Items.Add("Fiorino");
                }
                else if (comboMarka.SelectedItem.ToString() == "Ford")
                {
                    comboSeri.Items.Add("Fiesta");
                    comboSeri.Items.Add("Focus");
                    comboSeri.Items.Add("Ranger");
                }
            }
            catch (Exception)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sentence = "insert into tblArac(plaka, marka, seri, yıl, renk, km, yakit, kiraucreti, resim, tarih, durumu) values (@plaka, @marka, @seri, @yıl, @renk, @km, @yakit, @kiraucreti, @resim, @tarih, @durumu)";
            SqlCommand command2 = new SqlCommand();
            command2.Parameters.AddWithValue("@plaka", txtPlaka.Text);
            command2.Parameters.AddWithValue("@marka", comboMarka.Text);
            command2.Parameters.AddWithValue("@seri", comboSeri.Text);
            command2.Parameters.AddWithValue("@yıl", txtModel.Text);
            command2.Parameters.AddWithValue("@renk", txtRenk.Text);
            command2.Parameters.AddWithValue("@km", txtKm.Text);
            command2.Parameters.AddWithValue("@yakit", comboYakit.Text);
            command2.Parameters.AddWithValue("@kiraucreti", int.Parse(txtKira.Text));
            command2.Parameters.AddWithValue("@resim", pictureBox1.ImageLocation);
            
            command2.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
            command2.Parameters.AddWithValue("@durumu", "BOŞ");
            
            arac_Kiralama.add_delete_update(command2, sentence);
            comboSeri.Items.Clear();
            foreach (Control i in Controls) if (i is TextBox) i.Text = "";
            foreach (Control i in Controls) if (i is ComboBox) i.Text = "";
            pictureBox1.ImageLocation = "";
        }

        private void FormAracKayit_Load(object sender, EventArgs e)
        {

        }
    }
}
