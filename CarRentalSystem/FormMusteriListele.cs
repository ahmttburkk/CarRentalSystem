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
    public partial class FormMusteriListele : Form
    {
        Arac_Kiralama arac_Kiralama = new Arac_Kiralama();
        public FormMusteriListele()
        {
            InitializeComponent();
        }

        private void FormMusteriListele_Load(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void RefreshList()
        {
            string sentence = "select * from tblMusteri";
            SqlDataAdapter adptr2 = new SqlDataAdapter(); // SqlDataAdapter - select sorugu sonrası verileri dataset veya datatable a doldurur.
            dataGridView1.DataSource = arac_Kiralama.listele(adptr2, sentence);
            
            // MusteriListele ekranındaki datagrid kısmında en üste uygun başlıklar ekliyorum.
            dataGridView1.Columns[0].HeaderText = "TC";
            dataGridView1.Columns[1].HeaderText = "AD SOYAD";
            dataGridView1.Columns[2].HeaderText = "TELEFON";
            dataGridView1.Columns[3].HeaderText = "ADRES";
            dataGridView1.Columns[4].HeaderText = "E-MAIL";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string sentence = "select * from tblMusteri where tc like '%"+textBox1.Text+"%'"; // arama yaparken bizim tc ye göre yaptığımız aramayı getirecek.
            SqlDataAdapter adptr2 = new SqlDataAdapter();
            dataGridView1.DataSource = arac_Kiralama.listele(adptr2, sentence);
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e) //Data Grid ekranında dataya çift tıklanınca ilgili veriyi sol taraftaki textboxlara atar.
        {
            DataGridViewRow line = dataGridView1.CurrentRow;
            txtTc.Text = line.Cells[0].Value.ToString();
            txtAdsoyad.Text = line.Cells[1].Value.ToString();
            txtTelefon.Text = line.Cells[2].Value.ToString();
            txtAdres.Text = line.Cells[3].Value.ToString();
            txtEmail.Text = line.Cells[4].Value.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string sentence = "update tblMusteri set adsoyad = @adsoyad, telefon = @telefon, adres = @adres, email = @email where tc=@tc";
            SqlCommand command2 = new SqlCommand();
            command2.Parameters.AddWithValue("@tc", txtTc.Text);
            command2.Parameters.AddWithValue("@adsoyad", txtAdsoyad.Text);
            command2.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            command2.Parameters.AddWithValue("@adres", txtAdres.Text);
            command2.Parameters.AddWithValue("@email", txtEmail.Text);
            arac_Kiralama.add_delete_update(command2, sentence);
            foreach (Control i in Controls) if (i is TextBox) i.Text = ""; // yapılan güncelleme sonrası ekrandaki verileri temizleme.
            RefreshList(); // yenile-listele
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow line = dataGridView1.CurrentRow;
            string sentence = "delete from tblMusteri where tc = '" + line.Cells["tc"].Value.ToString() + "' ";
            SqlCommand command2 = new SqlCommand();
            arac_Kiralama.add_delete_update(command2, sentence);
            RefreshList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
