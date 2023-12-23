using BussinessLayer.Conrate;
using DataAccessLayer.Concrate.DbOp;
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
    public partial class SubeGuncelle : Form
    {
        public SubeGuncelle()
        {
            InitializeComponent();
        }
        SubeManager subeManager = new SubeManager(new SubeDAL());
       
        private void SinifEkle_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var item in subeManager.AdGet(Convert.ToChar(textBox1.Text)))
                {
                    subeManager.Update(item.SubeID1, Convert.ToChar(textBox3.Text));

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void SubeGuncelle_Load(object sender, EventArgs e)
        {

        }

        private void DersEkle_Click(object sender, EventArgs e)
        {

        }
    }
}
