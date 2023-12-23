using Core.Utilities.Var;
using DataAccessLayer.Concrate.Baglanti;
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
    public partial class GirisYap : Form
    {
        public GirisYap()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {

                //connectionString = "Data Source = "+textBox5.Text+"; User Id=" + textBox1.Text + "; Password =" + textBox2.Text + "";
                // conn = new SqlConnection(connectionString);
                //conn.Open();
                //   Connection.connection1.Close();

                Connection.connection1.Open();
                MessageBox.Show("Basariyla Giris Yapildi");
                   


                Form1 form1 = new Form1();
                this.Hide();
                form1.Show();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            Connection.connection1.Close();

            // conn.Close();
            // conn.Dispose();
        }

        private void GirisYap_Load(object sender, EventArgs e)
        {
            btnConnect.Enabled = false;
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            Var.UserId = textBox1.Text;
            Var.Password = textBox2.Text;

            btnConnect.Enabled = true;
        }
    }
}
