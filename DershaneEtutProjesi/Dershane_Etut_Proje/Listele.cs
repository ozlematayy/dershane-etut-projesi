using BussinessLayer.Conrate;
using DataAccessLayer.Concrate;
using Entity.Concrate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel; //excel için eklendi

namespace Dershane_Etut_Proje
{
    public partial class Listele : Form
    {
        public Listele()
        {
            InitializeComponent();
        }
        OgrenciManager ogrenci = new OgrenciManager(new OgrenciDAL());

        private void Listele_Load(object sender, EventArgs e)
        {
            if (AnaSayfa.hangi == "Deneme Ad")
            {

                OgrenciManager ogrenci = new OgrenciManager(new OgrenciDAL());
                try
                {
                    List<Ogrenci> ogr = ogrenci.BasariSiralama(AnaSayfa.denemeid);
                    dataGridView1.DataSource = ogr;
                    button9.Visible = true;
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

            }
            else if (AnaSayfa.hangi == "Deneme Çözer")
            {
                try
                {
                    //OgrenciManager ogrenci = new OgrenciManager(new OgrenciDAL());
                    List<Ogrenci> ogr = ogrenci.DenemeCozerGet(AnaSayfa.denemeid);
                    dataGridView1.DataSource = ogr;
                    button9.Visible = true;
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

            }
            else if (AnaSayfa.hangi == "Sube")
            {
                OgrenciManager ogr = new OgrenciManager(new OgrenciDAL());
               
                try
                {
                    List<Ogrenci> liste = ogr.SinifListesi(AnaSayfa.sube);
                    dataGridView1.DataSource = liste;
                    button9.Visible = true;
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            else if (AnaSayfa.hangi == "Yıl Kayıtları")
            {
                try
                {
                    List<Ogrenci> ogr = ogrenci.YilKayitlari();
                    dataGridView1.DataSource = ogr;
                    button9.Visible = true;
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            else if(AnaSayfa.hangi == "KayitYenileme")
            {
                KayitManager kayitManager = new KayitManager(new KayitDAL());
                try
                {
                    List<Ogrenci> kayits = kayitManager.YeniKayit_Listele();
                    dataGridView1.DataSource = kayits;
                    button9.Visible = true;
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
              
            }
            else
            {
                OgrenciManager ogrenciManager = new OgrenciManager(new OgrenciDAL());
                try
                {
                    List<Ogrenci> OgrList = ogrenciManager.BlGetAll();

                    dataGridView1.DataSource = OgrList;
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
               
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {


            Excel.Application exceldosya = new Excel.Application(); //excel dosyası oluşturuldu
            exceldosya.Visible = true; //excel aktif
            object Missing = Type.Missing;

            Workbook calişmakitabi = exceldosya.Workbooks.Add(Missing); //excel çalışma kitabı üzerine kuruludur. Çalışma kitabı oluşturuldu
            Worksheet sheet1 = (Worksheet)calişmakitabi.Sheets[1]; //çalışma alanı ile kitap ilişkilendirildi
            //alanın 1. indeksine ekle
            //satır ve sütunlar için değişken oluşturulup çağrılır
            int sutun = 1;
            int satir = 1;

            for (int i = 0; i < dataGridView1.Columns.Count - 1; i++)
            {
                //Başlıkların gözükmesi gerekir
                //sütun sayısına kadar i artar
                if (i >= 5)
                {
                    Range myrange = (Range)sheet1.Cells[satir, sutun + i];
                    myrange.Value2 = dataGridView1.Columns[i + 1].HeaderText;

                }
                else
                {

                    Range myrange = (Range)sheet1.Cells[satir, sutun + i];
                    myrange.Value2 = dataGridView1.Columns[i].HeaderText;
                }
                //sütunları yazdırdık
            }
            satir++;
            //veriler satın sütun olarak gözükür:
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count - 1; j++)
                {
                    Range myrange = (Range)sheet1.Cells[satir + i, sutun + j];
                    //6.sutun
                    if (j >= 5)
                    {
                        myrange.Value2 = dataGridView1[j + 1, i].Value == null ? "" : dataGridView1[j + 1, i].Value;
                        myrange.Select();
                    }
                    else
                    {
                        myrange.Value2 = dataGridView1[j, i].Value == null ? "" : dataGridView1[j, i].Value;
                        myrange.Select();
                    }
                }
            }
        }
    }

}
