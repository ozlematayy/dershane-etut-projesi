using BussinessLayer.Conrate;
using DataAccessLayer.Concrate;
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
    public partial class KayıtSil : Form
    {
        public KayıtSil()
        {
            InitializeComponent();
        }

        private void KayıtSil_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("TC No İle");
            comboBox1.Items.Add("Öğrenci Numarası İle");
            label2.Visible = false;
            label3.Visible = false;
            textBox1.Visible = false;
            button2.Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if(comboBox1.SelectedItem.ToString() == "TC No İle")
            {
                
                KayitManager kayit = new KayitManager(new KayitDAL());
                kayit.OgrTcDelete(Convert.ToString(this.textBox1.Text));
                MessageBox.Show("Kayıt Silindi");
                this.Close();
            }
            else if(comboBox1.SelectedItem.ToString() == "Öğrenci Numarası İle")
            {
                
                KayitManager kayit = new KayitManager(new KayitDAL());
                kayit.OgrIdDelete(Convert.ToInt32(this.textBox1.Text));
                MessageBox.Show("Kayıt Silindi");
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "TC No İle")
            {

                label2.Visible = true;
                label3.Visible = false;
                textBox1.Visible = true;
                button2.Visible = true;
            }
            else if (comboBox1.SelectedItem.ToString() == "Öğrenci Numarası İle")
            {

                label2.Visible = false;
                label3.Visible = true;
                textBox1.Visible = true;
                button2.Visible = true;
            }
        }
    }
}
