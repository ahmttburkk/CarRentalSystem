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
    public partial class FormSözleşme : Form
    {
        public FormSözleşme()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        Arac_Kiralama arac = new Arac_Kiralama();
        private void FormSözleşme_Load(object sender, EventArgs e) // Sözleşme ekranında Araçlar Combobox.
        {
            Unavailable_Cars();
            Yenile();
        }

        private void Unavailable_Cars()
        {
            string sentence = "select * from tblArac where durumu = 'BOŞ'";
            arac.Available_Cars(comboAraclar, sentence);
        }

        private void Yenile()
        {
            string sentence2 = "select * from tblSozlesme";
            SqlDataAdapter adptr2 = new SqlDataAdapter();
            dataGridView1.DataSource = arac.listele(adptr2, sentence2);

        }

        private void txtTc_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comboAraclar_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sentence = "select * from tblArac where plaka like '" + comboAraclar.SelectedItem+ "' ";
            arac.GetComboCars(comboAraclar, txtMarka, txtSeri, txtModel, txtRenk, sentence);
        }

        private void comboKirasekli_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sentence = "select * from tblArac where plaka like '" + comboAraclar.SelectedItem + "' ";
            arac.Calculate_Payment(comboKirasekli, txtKiraucreti, sentence);
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            TimeSpan gun = DateTime.Parse(dateDonus.Text) - DateTime.Parse(dateCikis.Text);
            int reelgun = gun.Days;
            txtGun.Text = reelgun.ToString();
            txtTutar.Text = (reelgun * int.Parse(txtKiraucreti.Text)).ToString();
        }

        private void btnSıfırla_Click(object sender, EventArgs e)
        {
            Sifirla();
        }

        private void Sifirla()
        {
            dateCikis.Text = DateTime.Now.ToShortDateString();
            dateDonus.Text = DateTime.Now.ToShortDateString();
            comboKirasekli.Text = "";
            txtKiraucreti.Text = "";
            txtGun.Text = "";
            txtTutar.Text = "";
        }

        private void btnSozEkle_Click(object sender, EventArgs e)
        {
            string sentence2 = "insert into tblSozlesme(tc, adsoyad, telefon, ehliyetno, e_tarih, e_yer, plaka, marka, seri, yıl, renk, kirasekli, kiraucreti, gun, tutar, cikistarih, donustarihi) values(@tc, @adsoyad, @telefon, @ehliyetno, @e_tarih, @e_yer, @plaka, @marka, @seri, @yıl, @renk, @kirasekli, @kiraucreti, @gun, @tutar, @cikistarih, @donustarihi)";
            SqlCommand command2 = new SqlCommand();
            command2.Parameters.AddWithValue("@tc", txtTc.Text);
            command2.Parameters.AddWithValue("@adsoyad", txtAdsoyad.Text);
            command2.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            command2.Parameters.AddWithValue("@ehliyetno", txtEhliyetno.Text);
            command2.Parameters.AddWithValue("@e_tarih", txtEhliyettarihi.Text);
            command2.Parameters.AddWithValue("@e_yer", txtEhliyetyeri.Text);
            command2.Parameters.AddWithValue("@plaka", comboAraclar.Text);
            command2.Parameters.AddWithValue("@marka", txtMarka.Text);
            command2.Parameters.AddWithValue("@seri", txtSeri.Text);
            command2.Parameters.AddWithValue("@yıl", txtModel.Text);
            command2.Parameters.AddWithValue("@renk", txtRenk.Text);
            command2.Parameters.AddWithValue("@kirasekli", comboKirasekli.Text);
            command2.Parameters.AddWithValue("@kiraucreti", int.Parse(txtKiraucreti.Text));
            command2.Parameters.AddWithValue("@gun", int.Parse(txtGun.Text));
            command2.Parameters.AddWithValue("@tutar", int.Parse(txtTutar.Text)); 
            command2.Parameters.AddWithValue("@cikistarih", dateCikis.Text);
            command2.Parameters.AddWithValue("@donustarihi", dateDonus.Text);
            arac.add_delete_update(command2, sentence2);

            string sentence3 = "update tblArac set durumu ='DOLU' where plaka = '"+comboAraclar.Text+"' ";
            SqlCommand command3 = new SqlCommand();
            arac.add_delete_update(command3, sentence3);
            comboAraclar.Items.Clear();
            Unavailable_Cars();
            Yenile();

            foreach (Control i in groupBox1.Controls) if (i is TextBox) i.Text = "";
            foreach (Control i in groupBox2.Controls) if (i is TextBox) i.Text = "";
            comboAraclar.Text = "";
            Sifirla();
            MessageBox.Show("Sözleşme Başarıyla Eklendi.");
        }

        private void txtTcAra_TextChanged(object sender, EventArgs e)
        {
            if (txtTcAra.Text == "") foreach (Control i in groupBox1.Controls) if (i is TextBox) i.Text = "";
            string sentence = "select * from tblMusteri where tc like '" + txtTcAra.Text + "' ";
            arac.Search_Tc(txtTcAra, txtTc, txtAdsoyad, txtTelefon, sentence);
        }

        private void btnSozGuncelle_Click(object sender, EventArgs e)
        {
            string sentence2 = "update tblSozlesme set tc = @tc, adsoyad = @adsoyad, telefon = @telefon, ehliyetno = @ehliyetno, e_tarih = @e_tarih, e_yer = @e_yer, marka = @marka, seri = @seri, yıl = @yıl, renk = @renk, kirasekli = @kirasekli, kiraucreti = @kiraucreti, gun = @gun, tutar = @tutar, cikistarih = @cikistarih, donustarihi = @donustarihi where plaka = @plaka";
            SqlCommand command2 = new SqlCommand();
            command2.Parameters.AddWithValue("@tc", txtTc.Text);
            command2.Parameters.AddWithValue("@adsoyad", txtAdsoyad.Text);
            command2.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            command2.Parameters.AddWithValue("@ehliyetno", txtEhliyetno.Text);
            command2.Parameters.AddWithValue("@e_tarih", txtEhliyettarihi.Text);
            command2.Parameters.AddWithValue("@e_yer", txtEhliyetyeri.Text);
            command2.Parameters.AddWithValue("@plaka", comboAraclar.Text);
            command2.Parameters.AddWithValue("@marka", txtMarka.Text);
            command2.Parameters.AddWithValue("@seri", txtSeri.Text);
            command2.Parameters.AddWithValue("@yıl", txtModel.Text);
            command2.Parameters.AddWithValue("@renk", txtRenk.Text);
            command2.Parameters.AddWithValue("@kirasekli", comboKirasekli.Text);
            command2.Parameters.AddWithValue("@kiraucreti", int.Parse(txtKiraucreti.Text));
            command2.Parameters.AddWithValue("@gun", int.Parse(txtGun.Text));
            command2.Parameters.AddWithValue("@tutar", int.Parse(txtTutar.Text));
            command2.Parameters.AddWithValue("@cikistarih", dateCikis.Text);
            command2.Parameters.AddWithValue("@donustarihi", dateDonus.Text);
            arac.add_delete_update(command2, sentence2);
            comboAraclar.Items.Clear();
            Unavailable_Cars();
            Yenile();
            foreach (Control i in groupBox1.Controls) if (i is TextBox) i.Text = "";
            foreach (Control i in groupBox2.Controls) if (i is TextBox) i.Text = "";
            comboAraclar.Text = "";
            Sifirla();
            MessageBox.Show("Sözleşme Başarıyla Güncellendi.");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow line = dataGridView1.CurrentRow;
            txtTc.Text = line.Cells[0].Value.ToString();
            txtAdsoyad.Text = line.Cells[1].Value.ToString();
            txtTelefon.Text = line.Cells[2].Value.ToString();
            txtEhliyetno.Text = line.Cells[3].Value.ToString();
            txtEhliyettarihi.Text = line.Cells[4].Value.ToString();
            txtEhliyetyeri.Text = line.Cells[5].Value.ToString();
            comboAraclar.Text = line.Cells[6].Value.ToString();
            txtMarka.Text = line.Cells[7].Value.ToString();
            txtSeri.Text = line.Cells[8].Value.ToString();
            txtModel.Text = line.Cells[9].Value.ToString();
            txtRenk.Text = line.Cells[10].Value.ToString();
            comboKirasekli.Text = line.Cells[11].Value.ToString();
            txtKiraucreti.Text = line.Cells[12].Value.ToString();
            txtGun.Text = line.Cells[13].Value.ToString();
            txtTutar.Text = line.Cells[14].Value.ToString();
            dateCikis.Text = line.Cells[15].Value.ToString();
            dateDonus.Text = line.Cells[16].Value.ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            // Gün farkını hesaplama:
            DateTime bugun = DateTime.Parse(DateTime.Now.ToShortDateString());
            DateTime donus = DateTime.Parse(DateTime.Now.ToShortDateString());
            int ucret = int.Parse(row.Cells["kiraucreti"].Value.ToString());
            TimeSpan gunfarki = bugun - donus;
            int _gunfarki = gunfarki.Days;
            int ucretfarki;
            // Ücret farkını hesaplama:
            ucretfarki = _gunfarki * ucret;
            txtEkstra.Text = ucretfarki.ToString();
            //Toplam tutar hesaplama

        }

        private void btnAracTeslim_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtEkstra.Text) >= 0 || int.Parse(txtEkstra.Text) < 0)
            {
                DataGridViewRow line = dataGridView1.CurrentRow;
                DateTime bugun = DateTime.Parse(DateTime.Now.ToShortDateString());
                int ucret = int.Parse(line.Cells["kiraucreti"].Value.ToString());
                int tutar = int.Parse(line.Cells["tutar"].Value.ToString());
                DateTime cikis = DateTime.Parse(line.Cells["cikistarih"].Value.ToString());
                TimeSpan gun = bugun - cikis;
                int _gun = gun.Days;
                int toplamtutar = _gun * ucret;
                // toplamtutar, _gun, ucret satış tablosuna aktarılacak.
                
                string query1 = "delete from tblSozlesme where plaka = '" + line.Cells["plaka"].Value.ToString() + "' ";
                SqlCommand command1 = new SqlCommand();
                arac.add_delete_update(command1, query1);
                
                string query2 = "update tblArac set durumu = 'BOŞ' where plaka = '" + line.Cells["plaka"].Value.ToString() +"' ";
                SqlCommand command2 = new SqlCommand();
                arac.add_delete_update(command2, query2);

                string sentence3 = "insert into tblSatis(tc, adsoyad, plaka, marka, seri, yıl, renk, gun, fiyat, tutar, tarih1, tarih2) values(@tc, @adsoyad, @plaka, @marka, @seri, @yıl, @renk, @gun, @fiyat, @tutar, @tarih1, @tarih2)";
                SqlCommand command3 = new SqlCommand();
                command3.Parameters.AddWithValue("@tc", line.Cells["tc"].Value.ToString());
                command3.Parameters.AddWithValue("@adsoyad", line.Cells["adsoyad"].Value.ToString());
                command3.Parameters.AddWithValue("@plaka", line.Cells["plaka"].Value.ToString());
                command3.Parameters.AddWithValue("@marka", line.Cells["marka"].Value.ToString());
                command3.Parameters.AddWithValue("@seri", line.Cells["seri"].Value.ToString());
                command3.Parameters.AddWithValue("@yıl", line.Cells["yıl"].Value.ToString());
                command3.Parameters.AddWithValue("@renk", line.Cells["renk"].Value.ToString());
               
                command3.Parameters.AddWithValue("@gun", _gun);
                command3.Parameters.AddWithValue("@fiyat", ucret);
                command3.Parameters.AddWithValue("@tutar", toplamtutar);
                command3.Parameters.AddWithValue("@tarih1", line.Cells["cikistarih"].Value.ToString());
                command3.Parameters.AddWithValue("@tarih2", DateTime.Now.ToShortDateString()); // bugünün tarihi.
                arac.add_delete_update(command3, sentence3);

                MessageBox.Show("Araç teslim edildi.");
                comboAraclar.Text = "";
                comboAraclar.Items.Clear();
                Unavailable_Cars();
                Yenile();
                foreach (Control i in groupBox1.Controls) if (i is TextBox) i.Text = "";
                foreach (Control i in groupBox2.Controls) if (i is TextBox) i.Text = "";
                comboAraclar.Text = "";
                Sifirla();

                txtEkstra.Text = "";
            }
            else
            {
                MessageBox.Show("Lütfen seçim yapınız", "Uyarı");
            }
        }

        private void dateCikis_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
