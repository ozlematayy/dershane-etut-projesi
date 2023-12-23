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

namespace Dershane_Etut_Proje
{
    public partial class Odeme_Ekle : Form
    {
        public Odeme_Ekle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OdemeManager odemeManager = new OdemeManager(new OdemeDAL());
            VeliManager veliManager = new VeliManager(new VeliDAL());
            try
            {


                //Odeme odeme = new Odeme();
                //odeme.VeliID1 = Convert.ToInt32( textBox1.Text);
                //odeme.VeliID1 = veliManager.VeliBul(textBox1.Text, textBox5.Text);
                //odeme.OdemeTarih1 = Convert.ToDateTime( textBox2.Text);
                //odeme.Tutar1 =Convert.ToInt32(textBox3.Text);
                //odeme.OdemeBilgisi1 = textBox4.Text;
                int veliid = 0;
                foreach (var item in veliManager.VeliBul(textBox1.Text, textBox5.Text))
                {
                    veliid = item.VeliID1;
                }
                odemeManager.OdemeAdd(veliid, Convert.ToDateTime(textBox2.Text), Convert.ToInt32(textBox3.Text), textBox4.Text); ;
                MessageBox.Show("Ödemeniz tamamlanmıştır :)");
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Odeme_Ekle_Load(object sender, EventArgs e)
        {

        }
    }
}
