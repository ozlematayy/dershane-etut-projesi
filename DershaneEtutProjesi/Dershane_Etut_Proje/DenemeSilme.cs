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
    public partial class DenemeSilme : Form
    {
        public DenemeSilme()
        {
            InitializeComponent();
        }

        private void DenemeSilme_Load(object sender, EventArgs e)
        {
            DenemeManager dnm = new DenemeManager(new DenemeDAL());

            foreach (var item in dnm.DenemeleriGetirme())
            {
                comboBox1.Items.Add( item.Ad1);
                
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DenemeManager dnmsilme = new DenemeManager(new DenemeDAL());
            dnmsilme.DenemeSilme(Convert.ToString(this.comboBox1.Text));
            MessageBox.Show("Deneme Silindi");
            this.Close();


        }
    }
}
