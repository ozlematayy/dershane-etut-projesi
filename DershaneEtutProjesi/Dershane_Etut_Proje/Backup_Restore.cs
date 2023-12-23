using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DataAccessLayer.Concrate.Baglanti;
using System.Data.Sql;
using Core.Utilities.Var;

namespace Dershane_Etut_Proje
{
    public partial class Backup_Restore : Form
    {
        public Backup_Restore()
        {
            InitializeComponent();
        }


        private SqlCommand command;

        string sql = "";



        private void Backup_Restore_Load(object sender, EventArgs e)
        {
       
            btnBackup.Enabled = false;
            btnRestore.Enabled = false;
           


        }
      
        private void btnConnect_Click(object sender, EventArgs e)
        {
           
         
        }

        private void button1_Click(object sender, EventArgs e)
        {

          
        }
        string database = "Dershane_Etut_Projesi";
        private void btnBackup_Click(object sender, EventArgs e)
        {
            try
            {


                //conn = new SqlConnection(connectionString);
                // conn.Open();
                Connection.connection1.Open();
                sql = "BACKUP DATABASE " + database + " TO DISK = '" + textBox3.Text + "\\" + database + "-" + DateTime.Now.Ticks.ToString() + ".bak'";// + "WITH NOFORMAT, NOINIT,  NAME = N'Dershane_Etut_Projesi-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10";
                command = new SqlCommand(sql, Connection.connection1);
                command.ExecuteNonQuery();
                MessageBox.Show("Backup islemi basariyla tamamlandi");
                Connection.connection1.Close();
                // conn.Close();
                //conn.Dispose();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnBrowse1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog()==DialogResult.OK)
            {
                textBox3.Text = dlg.SelectedPath;
            }
            btnBackup.Enabled = true;
        }

        private void btnBrowse2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Backup Files(*.bak)|*.bak|All Files(*.*)|*.*";
            dlg.FilterIndex = 0;
            if (dlg.ShowDialog()==DialogResult.OK)
            {
                textBox4.Text = dlg.FileName;
            }
            btnRestore.Enabled = true;
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            try
            {
                //conn = new SqlConnection(connectionString);
                //conn.Open();
                Connection.connection1.Open();
                sql = "USE MASTER ";
                sql += "ALTER DATABASE " + database + " Set MULTI_USER WITH ROLLBACK IMMEDIATE;";
                sql += "RESTORE DATABASE " + database + " FROM DISK= '" + textBox4.Text + "' WITH REPLACE;";
                command = new SqlCommand(sql, Connection.connection1);
                command.ExecuteNonQuery();
                Connection.connection1.Close();
                //conn.Close();
                //conn.Dispose();
                MessageBox.Show("Restore Islemi Basarili");
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
       
        }
    }
}
