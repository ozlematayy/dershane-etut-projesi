using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinessLayer.Conrate;
using DataAccessLayer.Concrate;
using System.IO;


namespace Dershane_Etut_Proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OgrenciManager ogrenciManager = new OgrenciManager(new OgrenciDAL());
        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Odeme_Ekle(), sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //AnaSayfa ogrısleri = new AnaSayfa();
           OpenChildForm(new AnaSayfa(),sender);

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
            this.panelDesktop.Controls.Add(childFrom);
            this.panelDesktop.Tag = childFrom;
            childFrom.BringToFront();
            childFrom.Show();
           // label1.Text = childFrom.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Veli_Form(), sender); 
        }
        public static string a;

        private void denemeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OpenChildForm(new DenemeSilme(), sender);
        }

        private void dersToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            a = "Ders";
            OpenChildForm(new Ders_Islemleri(), sender);
        }

        private void dersAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void sınıfToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            a = "Sınıf";
            OpenChildForm(new Ders_Islemleri(), sender);
        }

        private void dersAlmaKaydıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            OpenChildForm(new DersAlma_Kayıt(), sender);
        }

        private void sinifSubeGuncellemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void subeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            a = "Sube";
            OpenChildForm(new Ders_Islemleri(), sender);
        }

        private void şubeGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SubeGuncelle(), sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {

                

            }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Yonetici_Islemleri(), sender);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void dersİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripMenuItem17_Click(object sender, EventArgs e)
        {
            a = "Deneme";
            OpenChildForm(new Ders_Islemleri(), sender);
        }
    }
    
}
