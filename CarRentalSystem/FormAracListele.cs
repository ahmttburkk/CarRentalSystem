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
    public partial class FormAracListele : Form
    {
        Arac_Kiralama arac_Kiralama = new Arac_Kiralama();
        public FormAracListele()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow  row = dataGridView1.CurrentRow;
            txtPlaka.Text = row.Cells["plaka"].Value.ToString();
            comboMarka.Text = row.Cells["marka"].Value.ToString();
            comboSeri.Text = row.Cells["seri"].Value.ToString();
            txtModel.Text = row.Cells["yıl"].Value.ToString();
            txtRenk.Text = row.Cells["renk"].Value.ToString();
            txtKm.Text = row.Cells["km"].Value.ToString();
            comboYakit.Text = row.Cells["yakit"].Value.ToString();
            txtKira.Text = row.Cells["kiraucreti"].Value.ToString();
            pictureBox2.ImageLocation= row.Cells["resim"].Value.ToString();
        }

        private void FormAracListele_Load(object sender, EventArgs e)
        {
            YenileAraclarListesi();
            comboAraclar.SelectedIndex = 0;
        }

        private void YenileAraclarListesi()
        {
            string sentence = "select * from tblArac";
            SqlDataAdapter adptr2 = new SqlDataAdapter();
            dataGridView1.DataSource = arac_Kiralama.listele(adptr2, sentence);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox2.ImageLocation = openFileDialog1.FileName;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string sentence = "update tblArac set marka = @marka, seri = @seri, yıl = @yıl, renk = @renk, km = @renk, yakit = @yakit, kiraucreti = @kiraucreti, resim = @resim, tarih = @tarih where plaka = @plaka";
            SqlCommand command2 = new SqlCommand();
            command2.Parameters.AddWithValue("@plaka", txtPlaka.Text);
            command2.Parameters.AddWithValue("@marka", comboMarka.Text);
            command2.Parameters.AddWithValue("@seri", comboSeri.Text);
            command2.Parameters.AddWithValue("@yıl", txtModel.Text);
            command2.Parameters.AddWithValue("@renk", txtRenk.Text);
            command2.Parameters.AddWithValue("@km", txtKm.Text);
            command2.Parameters.AddWithValue("@yakit", comboYakit.Text);
            command2.Parameters.AddWithValue("@kiraucreti", int.Parse(txtKira.Text));
            command2.Parameters.AddWithValue("@resim", pictureBox2.ImageLocation);
            command2.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
            arac_Kiralama.add_delete_update(command2, sentence);
            comboSeri.Items.Clear();
            foreach (Control i in Controls) if (i is TextBox) i.Text = "";
            foreach (Control i in Controls) if (i is ComboBox) i.Text = "";
            pictureBox2.ImageLocation = "";
            YenileAraclarListesi();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            string sentence = "delete from tblArac where plaka = '"+ row.Cells["plaka"].Value.ToString() +"' ";
            SqlCommand command2 = new SqlCommand();
            arac_Kiralama.add_delete_update(command2, sentence);
            YenileAraclarListesi();
            pictureBox2.ImageLocation = "";
            foreach (Control i in Controls) if (i is TextBox) i.Text = "";
            foreach (Control i in Controls) if (i is ComboBox) i.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboMarka_SelectedIndexChanged(object sender, EventArgs e)
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
                else if (comboMarka.SelectedItem.ToString() == "Renault")
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

        private void comboAraclar_SelectedIndexChanged(object sender, EventArgs e) //Tüm araçlar, boştakiler ve dolular için.
        {
            try
            {
                if(comboAraclar.SelectedIndex == 0)
                {
                    YenileAraclarListesi();
                }
                if (comboAraclar.SelectedIndex == 1)
                {
                    string sentence = "select * from tblArac where durumu = 'BOŞ' ";
                    SqlDataAdapter adptr2 = new SqlDataAdapter();
                    dataGridView1.DataSource = arac_Kiralama.listele(adptr2, sentence);
                }
                if (comboAraclar.SelectedIndex == 2)
                {
                    string sentence = "select * from tblArac where durumu = 'DOLU' ";
                    SqlDataAdapter adptr2 = new SqlDataAdapter();
                    dataGridView1.DataSource = arac_Kiralama.listele(adptr2, sentence);
                }

            }
            catch
            {

            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
