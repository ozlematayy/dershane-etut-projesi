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
    public partial class Devamsızlık_Ekle : Form
    {
        public Devamsızlık_Ekle()
        {
            InitializeComponent();
        }
        static int ogr;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DevamsizlikManager devamsizlik = new DevamsizlikManager(new DevamsizlikDAL());
                OgrenciManager ogrenci = new OgrenciManager(new OgrenciDAL());
                foreach (var item in ogrenci.TCGet(textBox1.Text))
                {
                    ogr = item.OgrID1;
                }
                devamsizlik.DevamsizlikAdd(ogr, Convert.ToDateTime(textBox2.Text), Convert.ToDouble(textBox3.Text), 15 - Convert.ToDouble(textBox3.Text));
                MessageBox.Show("Kaydedildi");
                this.Close();
            }
             catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Devamsızlık_Ekle_Load(object sender, EventArgs e)
        {

        }
    }
}
