using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalSystem
{
    public partial class FormAnaSayfa : Form
    {
        public FormAnaSayfa()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formMusteriEkle ekle = new formMusteriEkle();
            ekle.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormMusteriListele musteriListele = new FormMusteriListele();
            musteriListele.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormAracKayit registration = new FormAracKayit();
            registration.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormAracListele aracListele = new FormAracListele();
            aracListele.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormSözleşme sozlesme = new FormSözleşme();
            sozlesme.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormSatis satis = new FormSatis();
            satis.ShowDialog();
        }
    }
}
