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
    public partial class DenemeBilgi_Ekle : Form
    {
        public DenemeBilgi_Ekle()
        {
            InitializeComponent();
        }
        static int ogrid;

        private void button1_Click(object sender, EventArgs e)
        {
            DenemeCozerManager deneme = new DenemeCozerManager(new DenemeCozerDAL());
            OgrenciManager ogr = new OgrenciManager(new OgrenciDAL());
            DenemeManager dnm = new DenemeManager(new DenemeDAL());

            try
            {
                foreach (var item in ogr.TCGet(textBox1.Text))
                {
                    ogrid = item.OgrID1;
                }
                deneme.DenemeBilgiAdd(ogrid, dnm.AdGet(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToDateTime(textBox4.Text));
                MessageBox.Show("Deneme bilgileri başarıyla eklendi");
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }

        private void DenemeBilgi_Ekle_Load(object sender, EventArgs e)
        {

        }
    }
}
