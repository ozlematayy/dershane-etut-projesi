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
    public partial class Ders_Islemleri : Form
    {
        public Ders_Islemleri()
        {
            InitializeComponent();
        }

        private void DenemeEkle_Click(object sender, EventArgs e)
        {
            DenemeManager denemeManager = new DenemeManager(new DenemeDAL());
            try
            {
                denemeManager.Add(textBox1.Text);
                MessageBox.Show("Deneme adı başarıyla eklendi");
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        
        }

        private void DersEkle_Click(object sender, EventArgs e)
        {
            DersManager dersManager = new DersManager(new DersDAL());
            try
            {
                dersManager.Add(textBox1.Text);
                MessageBox.Show("Ders başarıyla kaydedilmiştir.");
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void SubeEkle_Click(object sender, EventArgs e)
        {
            SubeManager sube = new SubeManager(new SubeDAL());

            try
            {
                sube.Add(textBox1.Text);
                MessageBox.Show("Yeni Sube Eklendi");
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            
        }

        private void SinifEkle_Click(object sender, EventArgs e)
        {
            SinifManager sinif = new SinifManager(new SinifDAL());
            try
            {
                sinif.Add(textBox1.Text);
                MessageBox.Show("Yeni Sinif Eklendi");
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void Ders_Islemleri_Load(object sender, EventArgs e)
        {
            if (Form1.a == "Deneme")
            {
                label1.Text = "Eklenecek Deneme Adını Giriniz: ";
                DenemeEkle.Visible = true;
            }
            else if (Form1.a == "Ders")
            {

                label1.Text = "Eklenecek Ders Adını Giriniz: ";
                DersEkle.Visible = true;
            }
            else if (Form1.a == "Sube")
            {
                label1.Text = "Eklenecek Sube'yi Giriniz";
                SubeEkle.Visible = true;
            }
            else if (Form1.a == "Sınıf")
            {
                label1.Text = "Eklenecek Sınıf'ı Giriniz";
                SinifEkle.Visible = true;
            }
        }
    }
}
