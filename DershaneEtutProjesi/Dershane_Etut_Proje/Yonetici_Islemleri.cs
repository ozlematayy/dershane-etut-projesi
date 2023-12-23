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
    public partial class Yonetici_Islemleri : Form
    {
        public Yonetici_Islemleri()
        {
            InitializeComponent();
        }

        private Form activeForm;

        public void OpenChildForm(Form childFrom, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childFrom;
            childFrom.TopLevel = false;
            childFrom.FormBorderStyle = FormBorderStyle.None;
            childFrom.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(childFrom);
            this.panel1.Tag = childFrom;
            childFrom.BringToFront();
            childFrom.Show();
            // label1.Text = childFrom.Text;
        }
        private void Yonetici_Islemleri_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Backup_Restore(), sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Kullanıcı_Ekle(), sender);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ImportIslemi(), sender);
        }
    }
}
