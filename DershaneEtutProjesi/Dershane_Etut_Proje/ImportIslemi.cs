using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelDataReader;
using System.IO;
using DataAccessLayer.Concrate.Baglanti;
using System.Data.SqlClient;

namespace Dershane_Etut_Proje
{
    public partial class ImportIslemi : Form
    {
        private DataTableCollection tableCollection;

        public ImportIslemi()
        {
            InitializeComponent();
        }
        SqlDataAdapter da;
        SqlConnection abc = Connection.connection1;
       

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Ders Tablosu")
            {
                Connection.connection1.Open();

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    SqlCommand cmd = new SqlCommand("Insert into Ders(Ad) values ('" + dataGridView1.Rows[i].Cells[0].Value + "')", Connection.connection1);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Import Başarılı");
                dataGridView1.Columns.Clear();
                abc.Close();
                abc.Open();
                da = new SqlDataAdapter("Select * From Ders", abc);
                DataTable tablo = new DataTable();
                da.Fill(tablo);
                dataGridView1.DataSource = tablo;
                abc.Close();
                Connection.connection1.Close();
            }
            else if(comboBox1.SelectedItem.ToString() == "Deneme Tablosu")
            {
                Connection.connection1.Open();

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    SqlCommand cmd = new SqlCommand("Insert into Deneme(Ad) values ('" + dataGridView1.Rows[i].Cells[0].Value + "')", Connection.connection1);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Import Başarılı");
                dataGridView1.Columns.Clear();
                abc.Close();
                abc.Open();
                da = new SqlDataAdapter("Select * From Deneme", abc);
                DataTable tablo = new DataTable();
                da.Fill(tablo);
                dataGridView1.DataSource = tablo;
                abc.Close();
                Connection.connection1.Close();
            }
            else if (comboBox1.SelectedItem.ToString() == "DersAlir Tablosu")
            {
                try
                {
                    Connection.connection1.Open();
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        SqlCommand cmd = new SqlCommand("Insert into DersAlir(DersId,SinifId,Tarih) values (@DersId,@SinifId,@Tarih)", Connection.connection1);
                        cmd.Parameters.AddWithValue("@DersId", dataGridView1.Rows[i].Cells[0].Value);
                        cmd.Parameters.AddWithValue("@SinifId", dataGridView1.Rows[i].Cells[1].Value);
                        cmd.Parameters.AddWithValue("@Tarih", dataGridView1.Rows[i].Cells[2].Value);
                        cmd.ExecuteNonQuery();


                    }
                    MessageBox.Show("Import Başarılı");
                    dataGridView1.Columns.Clear();
                    abc.Close();
                    abc.Open();
                    da = new SqlDataAdapter("Select * From DersAlir", abc);
                    DataTable tablo = new DataTable();
                    da.Fill(tablo);
                    dataGridView1.DataSource = tablo;
                    abc.Close();
                    Connection.connection1.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            else if (comboBox1.SelectedItem.ToString() == "Ogrenci Tablosu")
            {
                try
                {
                    Connection.connection1.Open();
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        SqlCommand cmd = new SqlCommand("Insert into Ogrenci(TC,SinifId,VeliId,Ad,Soyad,Cinsiyet,Telefon,DogumTarih,Adres,SubeId) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)", Connection.connection1);
                        cmd.Parameters.AddWithValue("@p1", dataGridView1.Rows[i].Cells[0].Value);
                        cmd.Parameters.AddWithValue("@p2", dataGridView1.Rows[i].Cells[1].Value);
                        cmd.Parameters.AddWithValue("@p3", dataGridView1.Rows[i].Cells[2].Value);
                        cmd.Parameters.AddWithValue("@p4", dataGridView1.Rows[i].Cells[3].Value);
                        cmd.Parameters.AddWithValue("@p5", dataGridView1.Rows[i].Cells[4].Value);
                        cmd.Parameters.AddWithValue("@p6", dataGridView1.Rows[i].Cells[5].Value);
                        cmd.Parameters.AddWithValue("@p7", dataGridView1.Rows[i].Cells[6].Value);
                        cmd.Parameters.AddWithValue("@p8", dataGridView1.Rows[i].Cells[7].Value);
                        cmd.Parameters.AddWithValue("@p9", dataGridView1.Rows[i].Cells[8].Value);
                        cmd.Parameters.AddWithValue("@p10", dataGridView1.Rows[i].Cells[9].Value);
                        cmd.ExecuteNonQuery();


                    }
                    MessageBox.Show("Import Başarılı");

                    dataGridView1.Columns.Clear();
                    abc.Close();
                    abc.Open();
                    da = new SqlDataAdapter("Select * From Ogrenci", abc);
                    DataTable tablo = new DataTable();
                    da.Fill(tablo);
                    dataGridView1.DataSource = tablo;
                    abc.Close();
                    Connection.connection1.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            else if (comboBox1.SelectedItem.ToString() == "Kayit Tablosu")
            {
                try
                {
                    Connection.connection1.Open();
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        SqlCommand cmd = new SqlCommand("Insert into Kayit(OgrId,BaslangicTarih) values (@p1,@p2)", Connection.connection1);
                        cmd.Parameters.AddWithValue("@p1", dataGridView1.Rows[i].Cells[0].Value);
                        cmd.Parameters.AddWithValue("@p2", dataGridView1.Rows[i].Cells[1].Value);
                        cmd.ExecuteNonQuery();

                    }
                    MessageBox.Show("Import Başarılı");

                    dataGridView1.Columns.Clear();
                    abc.Close();
                    abc.Open();
                    da = new SqlDataAdapter("Select * From Kayit", abc);
                    DataTable tablo = new DataTable();
                    da.Fill(tablo);
                    dataGridView1.DataSource = tablo;
                    abc.Close();
                    Connection.connection1.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            else if (comboBox1.SelectedItem.ToString() == "Veli Tablosu")
            {
                try
                {
                    Connection.connection1.Open();
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        SqlCommand cmd = new SqlCommand("Insert into Veli(Ad,Soyad,Telefon) values (@p1,@p2,@p3)", Connection.connection1);
                        cmd.Parameters.AddWithValue("@p1", dataGridView1.Rows[i].Cells[0].Value);
                        cmd.Parameters.AddWithValue("@p2", dataGridView1.Rows[i].Cells[1].Value);
                        cmd.Parameters.AddWithValue("@p3", dataGridView1.Rows[i].Cells[2].Value);
                        cmd.ExecuteNonQuery();

                    }
                    MessageBox.Show("Import Başarılı");

                    dataGridView1.Columns.Clear();
                    abc.Close();
                    abc.Open();
                    da = new SqlDataAdapter("Select * From Veli", abc);
                    DataTable tablo = new DataTable();
                    da.Fill(tablo);
                    dataGridView1.DataSource = tablo;
                    abc.Close();
                    Connection.connection1.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            else if (comboBox1.SelectedItem.ToString() == "Odeme Tablosu")
            {
                try
                {
                    Connection.connection1.Open();
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        SqlCommand cmd = new SqlCommand("Insert into Odeme(VeliId,OdemeTarih,Tutar,OdemeBilgisi) values (@p1,@p2,@p3,@p4)", Connection.connection1);
                        cmd.Parameters.AddWithValue("@p1", dataGridView1.Rows[i].Cells[0].Value);
                        cmd.Parameters.AddWithValue("@p2", dataGridView1.Rows[i].Cells[1].Value);
                        cmd.Parameters.AddWithValue("@p3", dataGridView1.Rows[i].Cells[2].Value);
                        cmd.Parameters.AddWithValue("@p4", dataGridView1.Rows[i].Cells[3].Value);
                        cmd.ExecuteNonQuery();

                    }
                    MessageBox.Show("Import Başarılı");

                    dataGridView1.Columns.Clear();
                    abc.Close();
                    abc.Open();
                    da = new SqlDataAdapter("Select * From Odeme", abc);
                    DataTable tablo = new DataTable();
                    da.Fill(tablo);
                    dataGridView1.DataSource = tablo;
                    abc.Close();
                    Connection.connection1.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            else if (comboBox1.SelectedItem.ToString() == "Devamsizlik Tablosu")
            {
                try
                {
                    Connection.connection1.Open();
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        SqlCommand cmd = new SqlCommand("Insert into Devamsizlik(OgrId,Tarih,Sure,KalanHak) values (@p1,@p2,@p3,@p4)", Connection.connection1);
                        cmd.Parameters.AddWithValue("@p1", dataGridView1.Rows[i].Cells[0].Value);
                        cmd.Parameters.AddWithValue("@p2", dataGridView1.Rows[i].Cells[1].Value);
                        cmd.Parameters.AddWithValue("@p3", dataGridView1.Rows[i].Cells[2].Value);
                        cmd.Parameters.AddWithValue("@p4", dataGridView1.Rows[i].Cells[3].Value);
                        cmd.ExecuteNonQuery();

                    }
                    MessageBox.Show("Import Başarılı");

                    dataGridView1.Columns.Clear();
                    abc.Close();
                    abc.Open();
                    da = new SqlDataAdapter("Select * From Devamsizlik", abc);
                    DataTable tablo = new DataTable();
                    da.Fill(tablo);
                    dataGridView1.DataSource = tablo;
                    abc.Close();
                    Connection.connection1.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            else if (comboBox1.SelectedItem.ToString() == "DenemeCozer Tablosu")
            {
                try
                {
                    Connection.connection1.Open();
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        SqlCommand cmd = new SqlCommand("Insert into DenemeCozer(OgrId,DenemeId,BasariDurum,Tarih) values (@p1,@p2,@p3,@p4)", Connection.connection1);
                        cmd.Parameters.AddWithValue("@p1", dataGridView1.Rows[i].Cells[0].Value);
                        cmd.Parameters.AddWithValue("@p2", dataGridView1.Rows[i].Cells[1].Value);
                        cmd.Parameters.AddWithValue("@p3", dataGridView1.Rows[i].Cells[2].Value);
                        cmd.Parameters.AddWithValue("@p4", dataGridView1.Rows[i].Cells[3].Value);
                        cmd.ExecuteNonQuery();

                    }
                    MessageBox.Show("Import Başarılı");

                    dataGridView1.Columns.Clear();
                    abc.Close();
                    abc.Open();
                    da = new SqlDataAdapter("Select * From DenemeCozer", abc);
                    DataTable tablo = new DataTable();
                    da.Fill(tablo);
                    dataGridView1.DataSource = tablo;
                    abc.Close();
                    Connection.connection1.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            else if (comboBox1.SelectedItem.ToString() == "BasariDurumu Tablosu")
            {
                try
                {
                    Connection.connection1.Open();
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        SqlCommand cmd = new SqlCommand("Insert into BasariDurumu(OgrId,BasariOrt) values (@p1,@p2)", Connection.connection1);
                        cmd.Parameters.AddWithValue("@p1", dataGridView1.Rows[i].Cells[0].Value);
                        cmd.Parameters.AddWithValue("@p2", dataGridView1.Rows[i].Cells[1].Value);
                        
                        cmd.ExecuteNonQuery();

                    }
                    MessageBox.Show("Import Başarılı");

                    dataGridView1.Columns.Clear();
                    abc.Close();
                    abc.Open();
                    da = new SqlDataAdapter("Select * From BasariDurumu", abc);
                    DataTable tablo = new DataTable();
                    da.Fill(tablo);
                    dataGridView1.DataSource = tablo;
                    abc.Close();
                    Connection.connection1.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel Workbook|*.xlsx|Excel 97-2003 Workbook|*.xls" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = ofd.FileName;
                    using (var stream = File.Open(ofd.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                                {
                                    UseHeaderRow = true
                                }
                            });
                            tableCollection = result.Tables;
                            comboBox1.Items.Clear();
                            foreach (DataTable table in tableCollection)
                                comboBox1.Items.Add(table.TableName); 
                        }
                    }
                }
            }
        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Ders Tablosu")
            {
                DataTable dt = tableCollection[comboBox1.SelectedItem.ToString()];
                dataGridView1.DataSource = dt;
                if (dt != null)
                {
                    List<Entity.Concrate.Ders> list1 = new List<Entity.Concrate.Ders>();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Entity.Concrate.Ders obj = new Entity.Concrate.Ders();
                        obj.Ad1 = dt.Rows[i]["Ad"].ToString();

                        list1.Add(obj);
                    }
                    Entity.Concrate.DersBindingSource.DataSource = list1;

                }
            }
            else if (comboBox1.SelectedItem.ToString() == "Deneme Tablosu")
            {
                DataTable dt = tableCollection[comboBox1.SelectedItem.ToString()];
                dataGridView1.DataSource = dt;
                if (dt != null)
                {
                    List<Entity.Concrate.Deneme> list2 = new List<Entity.Concrate.Deneme>();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Entity.Concrate.Deneme obj = new Entity.Concrate.Deneme();
                        obj.Ad1 = dt.Rows[i]["Adi"].ToString();

                        list2.Add(obj);
                    }
                    Entity.Concrate.DenemeBindingSource.DataSource = list2;

                }
            }
            else if (comboBox1.SelectedItem.ToString() == "DersAlir Tablosu")
            {
                DataTable dt = tableCollection[comboBox1.SelectedItem.ToString()];
                dataGridView1.DataSource = dt;
                if (dt != null)
                {
                    List<Entity.Concrate.DersAlir> list3 = new List<Entity.Concrate.DersAlir>();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Entity.Concrate.DersAlir obj = new Entity.Concrate.DersAlir();
                        obj.DersID1 = Convert.ToInt32(dt.Rows[i]["DersId"]);
                        obj.SinifID1 = Convert.ToInt32(dt.Rows[i]["SinifId"]);
                        obj.Tarih1 = Convert.ToDateTime(dt.Rows[i]["Tarih"]);

                        list3.Add(obj);
                    }
                    Entity.Concrate.DersAlirBindingSource.DataSource = list3;

                }
            }
            else if (comboBox1.SelectedItem.ToString() == "Ogrenci Tablosu")
            {
                DataTable dt = tableCollection[comboBox1.SelectedItem.ToString()];
                dataGridView1.DataSource = dt;
                if (dt != null)
                {
                    List<Entity.Concrate.Ogrenci> list4 = new List<Entity.Concrate.Ogrenci>();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Entity.Concrate.Ogrenci obj = new Entity.Concrate.Ogrenci();
                        obj.TC1 = Convert.ToString(dt.Rows[i]["TC"]);
                        obj.SinifID1 = Convert.ToInt32(dt.Rows[i]["SinifId"]);
                        obj.VeliID1 = Convert.ToInt32(dt.Rows[i]["VeliId"]);
                        obj.Ad1 = Convert.ToString(dt.Rows[i]["Ad"]);
                        obj.Soyad1 = Convert.ToString(dt.Rows[i]["Soyad"]);
                        obj.Cinsiyet1 = Convert.ToChar(dt.Rows[i]["Cinsiyet"]);
                        obj.Telefon1 = Convert.ToString(dt.Rows[i]["Telefon"]);
                        obj.DogumTarih1 = Convert.ToDateTime(dt.Rows[i]["DogumTarih"]);
                        obj.Adres1 = Convert.ToString(dt.Rows[i]["Adres"]);
                        obj.SubeID1 = Convert.ToInt32(dt.Rows[i]["SubeId"]);

                        list4.Add(obj);
                    }
                    Entity.Concrate.OgrenciBindingSource.DataSource = list4;

                }
            }
            else if (comboBox1.SelectedItem.ToString() == "Kayit Tablosu")
            {
                DataTable dt = tableCollection[comboBox1.SelectedItem.ToString()];
                dataGridView1.DataSource = dt;
                if (dt != null)
                {
                    List<Entity.Concrate.Kayit> list4 = new List<Entity.Concrate.Kayit>();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Entity.Concrate.Kayit obj = new Entity.Concrate.Kayit();
                        obj.OgrId1 = Convert.ToInt32(dt.Rows[i]["OgrId"]);
                        obj.BaslangicTarih1 = Convert.ToDateTime(dt.Rows[i]["BaslangicTarih"]);

                        list4.Add(obj);
                    }
                    Entity.Concrate.KayitBindingSource.DataSource = list4;

                }
            }
            else if (comboBox1.SelectedItem.ToString() == "Veli Tablosu")
            {
                DataTable dt = tableCollection[comboBox1.SelectedItem.ToString()];
                dataGridView1.DataSource = dt;
                if (dt != null)
                {
                    List<Entity.Concrate.Veli> list5 = new List<Entity.Concrate.Veli>();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Entity.Concrate.Veli obj = new Entity.Concrate.Veli();
                        obj.Ad1 = Convert.ToString(dt.Rows[i]["Ad"]);
                        obj.Soyad1 = Convert.ToString(dt.Rows[i]["Soyad"]);
                        obj.Telefon1 = Convert.ToString(dt.Rows[i]["Telefon"]);

                        list5.Add(obj);
                    }
                    Entity.Concrate.VeliBindingSource.DataSource = list5;

                }
            }
            else if (comboBox1.SelectedItem.ToString() == "Odeme Tablosu")
            {
                DataTable dt = tableCollection[comboBox1.SelectedItem.ToString()];
                dataGridView1.DataSource = dt;
                if (dt != null)
                {
                    List<Entity.Concrate.Odeme> list5 = new List<Entity.Concrate.Odeme>();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Entity.Concrate.Odeme obj = new Entity.Concrate.Odeme();
                        obj.VeliID1 = Convert.ToInt32(dt.Rows[i]["VeliID"]);
                        obj.OdemeTarih1 = Convert.ToDateTime(dt.Rows[i]["OdemeTarih"]);
                        obj.Tutar1 = Convert.ToInt32(dt.Rows[i]["Tutar"]);
                        obj.OdemeBilgisi1 = Convert.ToString(dt.Rows[i]["OdemeBilgisi"]);


                        list5.Add(obj);
                    }
                    Entity.Concrate.OdemeBindingSource.DataSource = list5;

                }
            }
            else if (comboBox1.SelectedItem.ToString() == "Devamsizlik Tablosu")
            {
                DataTable dt = tableCollection[comboBox1.SelectedItem.ToString()];
                dataGridView1.DataSource = dt;
                if (dt != null)
                {
                    List<Entity.Concrate.Devamsizlik> list5 = new List<Entity.Concrate.Devamsizlik>();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Entity.Concrate.Devamsizlik obj = new Entity.Concrate.Devamsizlik();
                        obj.OgrID1 = Convert.ToInt32(dt.Rows[i]["OgrID"]);
                        obj.Tarih1 = Convert.ToDateTime(dt.Rows[i]["Tarih"]);
                        obj.Sure1 = Convert.ToInt32(dt.Rows[i]["Sure"]);
                        obj.KalanHak1 = Convert.ToInt32(dt.Rows[i]["KalanHak"]);


                        list5.Add(obj);
                    }
                    Entity.Concrate.DevamsizlikBindingSource.DataSource = list5;

                }
            }
            else if (comboBox1.SelectedItem.ToString() == "DenemeCozer Tablosu")
            {
                DataTable dt = tableCollection[comboBox1.SelectedItem.ToString()];
                dataGridView1.DataSource = dt;
                if (dt != null)
                {
                    List<Entity.Concrate.DenemeCozer> list5 = new List<Entity.Concrate.DenemeCozer>();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Entity.Concrate.DenemeCozer obj = new Entity.Concrate.DenemeCozer();
                        obj.OgrID1 = Convert.ToInt32(dt.Rows[i]["OgrID"]);
                        obj.DenemeID1 = Convert.ToInt32(dt.Rows[i]["DenemeID"]);
                        obj.BasariDurum1 = Convert.ToInt32(dt.Rows[i]["BasariDurum"]);
                        obj.Tarih1 = Convert.ToDateTime(dt.Rows[i]["Tarih"]);


                        list5.Add(obj);
                    }
                    Entity.Concrate.DenemeCozerBindingSource.DataSource = list5;

                }
            }
            else if (comboBox1.SelectedItem.ToString() == "BasariDurumu Tablosu")
            {
                DataTable dt = tableCollection[comboBox1.SelectedItem.ToString()];
                dataGridView1.DataSource = dt;
                if (dt != null)
                {
                    List<Entity.Concrate.BasariDurumu> list5 = new List<Entity.Concrate.BasariDurumu>();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Entity.Concrate.BasariDurumu obj = new Entity.Concrate.BasariDurumu();
                        obj.OgrId1 = Convert.ToInt32(dt.Rows[i]["OgrId"]);
                        obj.BasariOrt1 = Convert.ToInt32(dt.Rows[i]["BasariOrt"]);
                       


                        list5.Add(obj);
                    }
                    Entity.Concrate.BasariDurumuBindingSource.DataSource = list5;

                }
            }



        }

        private void ImportIslemi_Load(object sender, EventArgs e)
        {

        }
    }
}
