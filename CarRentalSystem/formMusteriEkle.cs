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
    public partial class formMusteriEkle : Form
    {
        Arac_Kiralama arac_kiralama = new Arac_Kiralama();
        public formMusteriEkle()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sentence = "insert into tblMusteri(tc, adsoyad, telefon, adres, email) values (@tc, @adsoyad, @telefon, @adres, @email)";
            SqlCommand command2 = new SqlCommand();
            command2.Parameters.AddWithValue("@tc", txtTc.Text);
            command2.Parameters.AddWithValue("@adsoyad",txtAdsoyad.Text);
            command2.Parameters.AddWithValue("@telefon",txtTelefon.Text);
            command2.Parameters.AddWithValue("@adres", txtAdres.Text);
            command2.Parameters.AddWithValue("@email", txtEmail.Text);
            arac_kiralama.add_delete_update(command2, sentence);
            foreach (Control i in Controls) if (i is TextBox) i.Text = "";
        }
    }
}
