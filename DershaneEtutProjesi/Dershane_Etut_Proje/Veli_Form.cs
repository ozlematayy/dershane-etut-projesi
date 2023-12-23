using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer.Concrate;
using BussinessLayer.Conrate;
using Entity.Concrate;

namespace Dershane_Etut_Proje
{
    public partial class Veli_Form : Form
    {
        public Veli_Form()
        {
            InitializeComponent();
        }
        public static int veliid;
        OgrenciManager ogrenciManager = new OgrenciManager(new OgrenciDAL());
        VeliManager veliManager = new VeliManager(new VeliDAL());
        private void Veli_Form_Load(object sender, EventArgs e)
        {

        }
        static int VeliId;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var item in ogrenciManager.TCGet(textBox1.Text))
                {
                    VeliId = item.VeliID1;
                }
                foreach (var item in veliManager.Get(VeliId))
                {
                    textBox2.Text = item.Ad1;
                    textBox3.Text = item.Soyad1;
                    textBox4.Text = item.Telefon1;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                veliManager.Update(VeliId, textBox2.Text, textBox3.Text, textBox4.Text);
                MessageBox.Show("Basariyla Guncellendi.");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        Ogrenci ogrenci = new Ogrenci();
        
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                veliManager.VeliAdd(textBox2.Text, textBox3.Text, textBox4.Text);
                foreach (var item in veliManager.VeliBul(textBox2.Text, textBox3.Text))
                {
                    veliid = item.VeliID1;
                }

                ogrenciManager.OgrenciAdd(AnaSayfa.TC1,
                                            AnaSayfa.Sinif,
                                            veliid,
                                            AnaSayfa.AD,
                                            AnaSayfa.Soyad,
                                            AnaSayfa.Cinsiyet,
                                            AnaSayfa.telefon,
                                            AnaSayfa.dgrtime,
                                            AnaSayfa.adres,
                                            AnaSayfa.subeId
                    );

                MessageBox.Show("Ogrenci Başarıyla Eklendi :)");
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
