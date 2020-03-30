/*
 Proje ilk yazılmaya başlandığında Yapılması gereken işlemler:

Project -> Add Reference -> Com -> Microsoft Excel 16.0 Library   
Project -> Properties -> Build -> Platform Target -> x64

Kullanım:

Önce comboboxtan isim seç sonra dosya bul (Bu kısım değişecek)
 */


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Drawing.Imaging;
using excel = Microsoft.Office.Interop.Excel;

namespace DrawGraphicsFromExcel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        
        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\tugay.alkan\Desktop\deneme.xls
                                                             ;Extended Properties='Excel 8.0; HDR=YES'");

        private void Form1_Load(object sender, EventArgs e)
        {
            /*  örnek basit kullanım
            chart1.Series["Series1"].Points.AddXY("deneme", 7.4);  //Points, location dediğimiz konum değişkenleri için kullanılır. X yada y eksenini değiştirceksek vs ya da araç konumunu değiştireceksek gibi.
            chart1.Series["Series1"].Points.AddXY("deneme2",5);  
            */
            button2.Visible = false;
        }


        //Dosya Seç
        private void button2_Click(object sender, EventArgs e)
        {
           

            OpenFileDialog opnDlg = new OpenFileDialog();
            opnDlg.InitialDirectory = @"C:\\";
            opnDlg.ShowDialog();

            string path = opnDlg.FileName;

            OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + 
                                                             ";Extended Properties='Excel 8.0; HDR=YES'");

            baglanti.Open();

            if (comboBox1.SelectedItem.ToString() == "K1") {

                OleDbCommand cmd = new OleDbCommand("select Xekseni,Yekseni from [Sayfa1$]", baglanti);   // excelden hangi sütundan veri çekeceğimizi belirliyoruz
                OleDbDataReader oku = cmd.ExecuteReader();

                while (oku.Read())
                {
                    chart1.Series["Series1"].Points.AddXY(oku[0].ToString(), oku[1].ToString());
                  
                }

                baglanti.Close();
            }

            if (comboBox1.SelectedItem.ToString() == "K2")
            {

                OleDbCommand cmd = new OleDbCommand("select X,Y from [Sayfa1$]", baglanti);
                OleDbDataReader oku = cmd.ExecuteReader();

                while (oku.Read())
                {
                    chart1.Series["Series2"].Points.AddXY(oku[0].ToString(), oku[1].ToString());
                    
                }

                baglanti.Close();
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            baglanti.Open();

            if (comboBox1.SelectedItem.ToString() == "K1")
            {

                OleDbCommand cmd = new OleDbCommand("select Xekseni,Yekseni from [Sayfa1$]", baglanti);   // excelden hangi sütundan veri çekeceğimizi belirliyoruz
                OleDbDataReader oku = cmd.ExecuteReader();

                while (oku.Read())
                {
                    chart1.Series["Series1"].Points.AddXY(oku[0].ToString(), oku[1].ToString());

                }
                baglanti.Close();
            }

            if (comboBox1.SelectedItem.ToString() == "K2")
            {

                OleDbCommand cmd = new OleDbCommand("select X,Y from [Sayfa1$]", baglanti);
                OleDbDataReader oku = cmd.ExecuteReader();

                while (oku.Read())
                {
                    chart1.Series["Series2"].Points.AddXY(oku[0].ToString(), oku[1].ToString());

                }

                baglanti.Close();
            }
        }
    }
}
