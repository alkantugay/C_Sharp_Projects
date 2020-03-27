using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Secim_Istatistik_Grafik
{
    public partial class FormOyGiris : Form
    {
        public FormOyGiris()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-6R64793\SQLEXPRESS;Initial Catalog=dbSecimProje;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("insert into TBLILCE (ILCE_AD,APARTI,BPARTI,CPARTI,DPARTI,EPARTI) values(@p1,@p2,@p3,@p4,@p5,@p6)",baglanti);
            cmd.Parameters.AddWithValue("@p1", textBox1.Text);
            cmd.Parameters.AddWithValue("@p2", textBox2.Text);
            cmd.Parameters.AddWithValue("@p3", textBox3.Text);
            cmd.Parameters.AddWithValue("@p4", textBox4.Text);
            cmd.Parameters.AddWithValue("@p5", textBox5.Text);
            cmd.Parameters.AddWithValue("@p6", textBox6.Text);

            cmd.ExecuteNonQuery();

            baglanti.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormGrafikler frm = new FormGrafikler();
            frm.Show();
        }
    }
}
