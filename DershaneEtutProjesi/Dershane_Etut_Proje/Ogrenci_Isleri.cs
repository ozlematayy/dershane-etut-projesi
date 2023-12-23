using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinessLayer.Conrate;
using Core.Utilities.Results;
using DataAccessLayer.Concrate;
using DataAccessLayer.Concrate.DbOp;
using Entity.Concrate;


namespace Dershane_Etut_Proje
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        OgrenciManager ogrenciManager = new OgrenciManager(new OgrenciDAL());
        VeliManager veliManager = new VeliManager(new VeliDAL());
        Ogrenci ogrenci = new Ogrenci();
        Veli_Form veli_Form = new Veli_Form();
        SinifManager sinifManager = new SinifManager(new SinifDAL());
        public static string TC1;
        public static string AD;
        public static string Soyad;
        public static char Cinsiyet;
        public static int SinifId;
        public static string telefon;
        public static DateTime dgrtime;
        public static string adres;
        public static int subeId;

        public static int Sinif;

        void Islemler()
        {
     
            try
            {
                foreach (var item in sinifManager.SinifGet(textBox4.Text))
                {
                    SinifId = item.SinifID1;
                }
                char sube = Convert.ToChar(textBox12.Text);
                foreach (var item1 in subeManager.AdGet(sube))
                {
                    subeId = item1.SubeID1;
                }
                TC1 = textBox3.Text;
                AD = textBox6.Text;
                Soyad = textBox7.Text;
                Cinsiyet = Convert.ToChar(textBox8.Text);
                Sinif = Convert.ToInt32(textBox4.Text);
                // SinifId = Convert.ToInt32(textBox4.Text);
                telefon = textBox9.Text;
                dgrtime = Convert.ToDateTime(textBox10.Text);
                adres = textBox11.Text;
                //subeId = ogrenciManager.GetSube(textBox12.Text);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
        
        }

        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
        
        
            Listele listele = new Listele();
            listele.Show();
            //dataGridView1.DataSource = OgrList;
        }

       
        
        private void button1_Click(object sender, EventArgs e)
        {

            // ogrenci.OgrID1 = Convert.ToInt32( textBox15.Text);


            Islemler();
            MessageBox.Show("Veli Bilgilerini Giriniz.");
            veli_Form.Show();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }
        Result result = new Result(false);
        static int veliID;

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Islemler();
              
                ogrenciManager.Update(Convert.ToInt32(textBox15.Text),
                                textBox3.Text,
                                SinifId,
                                veliID,
                                textBox6.Text,
                                textBox7.Text,
                                Convert.ToChar(textBox8.Text),
                                textBox9.Text,
                                Convert.ToDateTime(textBox10.Text),
                                textBox11.Text,
                                subeId) ;
                MessageBox.Show("Basariyla Guncellendi");
            }
            catch when(result.Success==false)
            {
                MessageBox.Show("Lutfen TCKN giriniz.");

            }





        } 


        private void button4_Click_1(object sender, EventArgs e)
        {
            DenemeBilgi_Ekle denemeBilgi = new DenemeBilgi_Ekle();
            denemeBilgi.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Devamsızlık_Ekle devamsızlık = new Devamsızlık_Ekle();
            devamsızlık.Show();
        }
        static string TC;
        SubeManager subeManager = new SubeManager(new SubeDAL());

        private void button6_Click(object sender, EventArgs e)
        {

            try
            {
                foreach (var item in ogrenciManager.Get(Convert.ToInt32(textBox15.Text)))
                {
                    TC = item.TC1;
                    textBox3.Text = item.TC1;
                    //textBox4.Text = sinifManager.Get(item.SinifID1).ToString();
                    textBox6.Text = item.Ad1;
                    textBox7.Text = item.Soyad1;
                    textBox8.Text = item.Cinsiyet1.ToString();
                    textBox9.Text = item.Telefon1;
                    textBox10.Text = item.DogumTarih1.ToString();
                    textBox11.Text = item.Adres1;
                    //textBox12.Text = subeManager.Get(item.SubeID1).ToString();

                    foreach (var item1 in sinifManager.Get(item.SinifID1))
                    {
                        textBox4.Text = item1.Sinif1;
                    }
                    foreach (var item2 in subeManager.Get(item.SubeID1))
                    {
                        textBox12.Text = item2.Sube1;
                    }
                }
                foreach (var item in ogrenciManager.TCGet(TC))
                {
                    veliID = item.VeliID1;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        public static int denemeid;
        public static string hangi;
        private void button8_Click(object sender, EventArgs e)
        {

            DenemeManager deneme = new DenemeManager(new DenemeDAL());
            try
            {
                foreach (var item in deneme.DenemeAdGet(textBox1.Text))
                {
                    denemeid = item.DenemeID1;
                }
                hangi = "Deneme Ad";
                Listele listele = new Listele();
                listele.Show();
                //DenemeManager deneme = new DenemeManager(new DenemeDAL());
                //foreach (var item in deneme.DenemeAdGet(textBox1.Text))
                //{
                //    denemeid = item.DenemeID1;
                //}
                //OgrenciManager ogrenci = new OgrenciManager(new OgrenciDAL());
                //List<Ogrenci> ogr = ogrenci.BasariSiralama(denemeid);
                //dataGridView1.DataSource = ogr;
                //button9.Visible = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public static string sube;
        private void button7_Click(object sender, EventArgs e)
        {
            hangi = "Sube";
            sube = textBox16.Text;
            Listele listele = new Listele();
            listele.Show();
          
        }

        private void button9_Click(object sender, EventArgs e)
        {
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

        private void button9_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Kayit_Yenileme(), sender);


      
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            KayıtSil fr = new KayıtSil();

            this.Hide();
            fr.Show();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Kayit_Yenileme fr = new Kayit_Yenileme();

            this.Hide();
            fr.Show();
            
        }

        private void button9_Click_2(object sender, EventArgs e)
        {
            Devamsızlık_Ekle devamsızlık = new Devamsızlık_Ekle();
            devamsızlık.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DenemeBilgi_Ekle denemeBilgi = new DenemeBilgi_Ekle();
            denemeBilgi.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {

            hangi = "Yıl Kayıtları";
            Listele liste = new Listele();
            liste.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox5.Text == "")
                {
                    MessageBox.Show("Lütfen Deneme Adını Giriniz!");
                }
                else
                {
                    hangi = "Deneme Çözer";
                    DenemeManager deneme = new DenemeManager(new DenemeDAL());
                    foreach (var item in deneme.DenemeAdGet(textBox5.Text))
                    {
                        denemeid = item.DenemeID1;
                    }
                    Listele liste = new Listele();
                    liste.Show();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            DenemeManager deneme = new DenemeManager(new DenemeDAL());
            try
            {
                foreach (var item in deneme.DenemeAdGet(textBox5.Text))
                {
                    denemeid = item.DenemeID1;
                }
                hangi = "Deneme Ad";
                Listele listele = new Listele();
                listele.Show();
                //DenemeManager deneme = new DenemeManager(new DenemeDAL());
                //foreach (var item in deneme.DenemeAdGet(textBox1.Text))
                //{
                //    denemeid = item.DenemeID1;
                //}
                //OgrenciManager ogrenci = new OgrenciManager(new OgrenciDAL());
                //List<Ogrenci> ogr = ogrenci.BasariSiralama(denemeid);
                //dataGridView1.DataSource = ogr;
                //button9.Visible = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            hangi = "Sube";
            sube = textBox2.Text;
            Listele listele = new Listele();
            listele.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
