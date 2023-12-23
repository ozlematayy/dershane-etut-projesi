using BussinessLayer.Conrate;
using DataAccessLayer.Concrate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dershane_Etut_Proje
{
    public partial class Kayit_Yenileme : Form
    {
        public Kayit_Yenileme()
        {
            InitializeComponent();
        }
        
        OgrenciManager ogrenciManager = new OgrenciManager(new OgrenciDAL());
        KayitManager kayitManager = new KayitManager(new KayitDAL());

        public int ogr;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //var date = new DateTime(2021, 7, 1);
                foreach (var item in ogrenciManager.TCGet(textBox1.Text))
                {
                    kayitManager.KayitAdd(item.OgrID1, DateTime.Now);
                    ogr = item.OgrID1;

                }
                kayitManager.Kayit_Al(ogr, DateTime.Now);
                MessageBox.Show("Ogrencinin Kaydi ve Sinif Bilgileri Basariyla Guncellendi.");

                button2.Enabled = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        
           

        }

        private void Kayit_Yenileme_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AnaSayfa.hangi = "KayitYenileme";
            Listele listele = new Listele();
            listele.Show();
        }
    }
}
