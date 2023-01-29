using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystem
{
    internal class Arac_Kiralama
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-06IBDOO\SQLEXPRESS;Initial Catalog=Arac_Kiralama;Integrated Security=True");
        DataTable table;
        public void add_delete_update(SqlCommand command, string query) // sınıf kullanıyorum çünkü karışıklığı önlemek istiyorum, ayrıca daha kolaylaştıracak.
        {
            conn.Open();
            command.Connection = conn;
            command.CommandText = query; // CommandText -> çalıştırılacak queriyi belirtir.
            command.ExecuteNonQuery(); //işlemi onaylama. Affect edilen rowları return eder.
            conn.Close();
        }
        public DataTable listele(SqlDataAdapter adptr, string query) // bunu çağırdığımız zaman "güncelle" yapıldıktan sonra kayıtlar yeni halleriyle gelecek.
        {
            table = new DataTable();
            adptr = new SqlDataAdapter(query, conn);
            adptr.Fill(table);
            conn.Close ();
            return table;
        }
        public void Available_Cars(ComboBox combo, string query)
        {
            conn.Open();
            SqlCommand command = new SqlCommand(query, conn);
            SqlDataReader read = command.ExecuteReader(); // ExecuteReader -> birden fazla satır sonucu döndüren sorgular için kullanılır.
            while (read.Read())
            {
                combo.Items.Add(read["plaka"].ToString());
            }
            conn.Close();
        }
        public void Search_Tc(TextBox tcAra, TextBox tc, TextBox adsoyad, TextBox telefon, string query)
        {
            conn.Open();
            SqlCommand command = new SqlCommand(query, conn);
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                tc.Text = read["tc"].ToString();
                adsoyad.Text = read["adsoyad"].ToString();
                telefon.Text = read["telefon"].ToString();
            }
            conn.Close();
        }
        public void GetComboCars(ComboBox araclar, TextBox marka, TextBox seri, TextBox model, TextBox renk, string query)
        {
            conn.Open();
            SqlCommand command = new SqlCommand(query, conn);
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                marka.Text = read["marka"].ToString();
                seri.Text = read["seri"].ToString();
                model.Text = read["yıl"].ToString();
                renk.Text = read["renk"].ToString();
            }
            conn.Close();
        }
        public void Calculate_Payment(ComboBox comboKirasekli, TextBox ucret, string query) // Araç kira fiyatı ile günlük bazda sayıyı çarpar.
        {
            conn.Open();
            SqlCommand command = new SqlCommand(query, conn);
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                if (comboKirasekli.SelectedIndex == 0) ucret.Text = (int.Parse(read["kiraucreti"].ToString()) * 1).ToString();
                if (comboKirasekli.SelectedIndex == 1) ucret.Text = (int.Parse(read["kiraucreti"].ToString()) * 7).ToString();
                if (comboKirasekli.SelectedIndex == 2) ucret.Text = (int.Parse(read["kiraucreti"].ToString()) * 30).ToString();
            }
            conn.Close();
        }
        public void SatisHesaplama(Label lbl)
        {
            conn.Open();
            SqlCommand komut = new SqlCommand("select sum(tutar) from tblSatis", conn);
            lbl.Text = "Toplam tutar = " + komut.ExecuteScalar() + "TL"; // ExecuteScalar metodu sayesinde istenilen veriyi label içine çekiyorum.
            conn.Close();
        }
    }
}
