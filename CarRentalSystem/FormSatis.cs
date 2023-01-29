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
    public partial class FormSatis : Form
    {
        public FormSatis()
        {
            InitializeComponent();
        }

        Arac_Kiralama arac = new Arac_Kiralama();
        private void FormSatis_Load(object sender, EventArgs e)
        {
            string sorgu = "select * from tblSatis";
            SqlDataAdapter adptr = new SqlDataAdapter();
            dataGridView1.DataSource = arac.listele(adptr, sorgu);
            arac.SatisHesaplama(label1);
        }
    }
}
