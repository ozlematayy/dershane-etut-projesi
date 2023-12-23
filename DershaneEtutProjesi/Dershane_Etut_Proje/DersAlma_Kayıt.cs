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
    public partial class DersAlma_Kayıt : Form
    {
        public DersAlma_Kayıt()
        {
            InitializeComponent();
        }
        public static int sinifid;

        private void button1_Click(object sender, EventArgs e)
        {

            DersAlirManager dersAlirManager = new DersAlirManager(new DersAlirDAL());
            DersManager ders = new DersManager(new DersDAL());
            SinifManager sinif = new SinifManager(new SinifDAL());

            try
            {
                foreach (var item in sinif.SinifGet(textBox2.Text))
                {
                    sinifid = item.SinifID1;
                }
                dersAlirManager.Add(ders.AdGet(textBox1.Text), sinifid, Convert.ToDateTime(textBox3.Text));
                MessageBox.Show("Kaydedildi");
                this.Close();

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void DersAlma_Kayıt_Load(object sender, EventArgs e)
        {

        }
    }
}
