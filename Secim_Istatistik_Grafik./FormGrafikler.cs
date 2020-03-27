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
    public partial class FormGrafikler : Form
    {
        public FormGrafikler()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-6R64793\SQLEXPRESS;Initial Catalog=dbSecimProje;Integrated Security=True");

        private void FormGrafikler_Load(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand cmd = new SqlCommand("Select ILCE_AD from TBLILCE", baglanti);   
            SqlDataReader dr = cmd.ExecuteReader();  // sql den data okutmak için kullanılan komut

            while(dr.Read())  // okumaya devam ettikçe
            {
                comboBox1.Items.Add(dr[0]);    // sqlden çektiğimiz ilçe adlarını combobox a yazdırıyoruz
            }

            baglanti.Close();

            // Grafiğe Toplam Sonuçları Getirme

            baglanti.Open();
            
            //Bu komutla partinin aldığı tüm ilçelerdeki oyları toplarız.
            SqlCommand komut = new SqlCommand("Select SUM(APARTI),SUM(BPARTI),SUM(CPARTI),SUM(DPARTI),SUM(EPARTI) from TBLILCE", baglanti);
            SqlDataReader dr2 = komut.ExecuteReader();
            while(dr2.Read())
            {
                chart1.Series["Partiler"].Points.AddXY("A PARTİ",dr2[0]);   //X alt kısımda ne yazacağını, Y de gelen değeri yazar
                //dr2[0] demek 0. indeks.  Yaani yukarıdaki komutla ilk olarak A partisini topladığımız için, ilk indeks 0. indeks A partisi oluyor.

                chart1.Series["Partiler"].Points.AddXY("B PARTİ", dr2[1]);  //1. indeks B partinin toplamını gösteriyor
                chart1.Series["Partiler"].Points.AddXY("C PARTİ", dr2[2]);  //2. indeks c partinin toplamını gösteriyor
                chart1.Series["Partiler"].Points.AddXY("D PARTİ", dr2[3]);  //3. indeks D partinin toplamını gösteriyor
                chart1.Series["Partiler"].Points.AddXY("E PARTİ", dr2[4]);  //4. indeks E partinin toplamını gösteriyor

            }
            baglanti.Close();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand cmd = new SqlCommand("Select * from TBLILCE where ILCE_AD = @p1",baglanti);
            cmd.Parameters.AddWithValue("@p1",comboBox1.Text);
            SqlDataReader dr = cmd.ExecuteReader();

            while(dr.Read())
            {
                progressBar1.Value = int.Parse(dr[2].ToString());
                progressBar2.Value = int.Parse(dr[3].ToString());
                progressBar3.Value = int.Parse(dr[4].ToString());
                progressBar4.Value = int.Parse(dr[5].ToString());
                progressBar5.Value = int.Parse(dr[6].ToString());

                lblA.Text = dr[2].ToString();
                lblB.Text = dr[3].ToString();
                lblC.Text = dr[4].ToString();
                lblD.Text = dr[5].ToString();
                lblE.Text = dr[6].ToString();
            }

            baglanti.Close();
        }
    }
}
