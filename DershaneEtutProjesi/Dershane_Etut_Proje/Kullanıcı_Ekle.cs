using DataAccessLayer.Concrate.Baglanti;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dershane_Etut_Proje
{
    public partial class Kullanıcı_Ekle : Form
    {
        public Kullanıcı_Ekle()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private SqlCommand command;

        string sql = "";

        private void button1_Click(object sender, EventArgs e)
        {
           

                try
                {
                
                    Connection.connection1.Open();
                    sql = "EXEC sp_addlogin '" + textBox1.Text + "','" + textBox2.Text + "'";
                    command = new SqlCommand(sql, Connection.connection1);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Login Eklendi");
                    Connection.connection1.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }


               
        }

        private void Kullanıcı_Ekle_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="")
            {
                MessageBox.Show("Resmi Adı giriniz!");
            }
            else
            {
                try
                {

                    string gorev;

                    if (comboBox1.Text == "Öğretmen")
                    {
                        gorev = "db_datawriter";
                        Connection.connection1.Open();
                        sql = "EXEC sp_adduser '" + textBox1.Text + "','" + textBox3.Text + "'," + gorev;
                        sql += "ALTER ROLE [db_datareader] ADD MEMBER " + textBox3.Text;
                        command = new SqlCommand(sql, Connection.connection1);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Kullanici ekleme islemi basariyla tamamlandi");
                        Connection.connection1.Close();
                    }
                    else
                    {
                        gorev = "db_datareader";
                        Connection.connection1.Open();
                        sql = "EXEC sp_adduser '" + textBox1.Text + "','" + textBox3.Text + "'," + gorev;
                        command = new SqlCommand(sql, Connection.connection1);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Kullanici ekleme islemi basariyla tamamlandi");
                        Connection.connection1.Close();
                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
          
        }
    }
}
