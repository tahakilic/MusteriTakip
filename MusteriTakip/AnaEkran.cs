using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MusteriTakip.SERVICE;
using MusteriTakip.DAL;
using MusteriTakip.DOMAIN;
using MySql.Data.MySqlClient;
namespace MusteriTakip
{
    public partial class AnaEkran : Form
    {
        public AnaEkran()
        {
            InitializeComponent();
            gecmisOku();
            kisileriOku();
            bilgiMesaji("Müşteri Oluştur Butonu","Yeni Müşteri Yaratır.",musteriEkle);
            bilgiMesaji("Müşteri Görüntüle Butonu", "Kişi tablosunda seçili olan müşterinin detaylı bilgilerini gösterir.", guncelleBtn);
            bilgiMesaji("Alacak Rapor Butonu", "Alacaklı olduğumuz müşterilerin raporunu oluşturur.", alacakRaporBtn);
            bilgiMesaji("Geçmiş Rapor Butonu", "Yaptığımız işlemlerin (müşteri ekleme,müşteri güncelleme) gibi işlemlerin raporunu oluşturur.", gecmisRaporBtn);
            bilgiMesaji("Tabloları Güncelle Butonu", "Ana ekranda olan tabloları günceller (bir nevi sayfayı yenile işlevini görür.).", tabloGuncelle);
            bilgiMesaji("Program Hakkında Bilgi Butonu", "Program çalışma mantığı hakkında bilgi verir.", bilgiBtn);
            bilgiMesaji("Müşteri Sil Butonu", "Kayıtlı müşterileri siler.", musteriSil);
            bilgiMesaji("Müşteri Sil Butonu", "Kayıtlı geçmişin tümünü temizler.", gecmisTemizleBtn);
            bilgiMesaji("Seçili İşlemi Sil Butonu", "Kayıtlı geçmişten seçili olanı siler.",seciliGecmisBtn );
           
     
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new MusteriEkle().Show();
        }

        public void grafikOku()
        {
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }

            MySqlConnection baglanti = new MySqlConnection("server=localhost;user id=melihengin;password=12345;database=ybsdb;persistsecurityinfo=True");
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("select ad,soyad,borc from musteri", baglanti);
            MySqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                chart1.Series["Alacak Tutarı"].Points.AddXY(oku[0].ToString() + " " + oku[1].ToString(), oku[2]);
            }
        }
        private void AnaEkran_Load(object sender, EventArgs e)
        {

            grafikOku();
           
        }
        public void gecmisOku()
        {
            listBoxGecmis.Items.Clear();
            foreach (gecmisDOMAIN okunan in (new gecmisSERVICE()).gecmisOku())
            {
                listBoxGecmis.Items.Add(okunan);
                
            }
        }
        public void kisileriOku()
        {
            listBoxKisiler.Items.Clear();
            foreach (musteriDOMAIN okunan in (new musteriSERVICE()).gecmisOku())
            {
                listBoxKisiler.Items.Add(okunan);

            }
        }
      

        private void listBoxKisiler_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guncelleBtn_Click(object sender, EventArgs e)
        {
            try
            {
                (new MusteriGuncelle((musteriDOMAIN)listBoxKisiler.SelectedItem)).Show();
            }
            catch
            {
                MessageBox.Show("Listeden Seçim Yapınız!", "UYARI!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.ToUpper();
            textBox1.SelectionStart = textBox1.Text.Length;
            for (int i = 0; i < listBoxKisiler.Items.Count; i++)
            {
                if (listBoxKisiler.Items[i].ToString().Contains(textBox1.Text))
                {
                    listBoxKisiler.SetSelected(i,true);
                    if (textBox1.Text == "")
                    {
                        listBoxKisiler.SetSelected(i, false);
                    }

                }
                else
                {
                    listBoxKisiler.SetSelected(i, false);
                }
            }
        }

        private void listBoxGecmis_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void tabloGuncelle_Click(object sender, EventArgs e)
        {
            kisileriOku();
            gecmisOku();
            grafikOku();
        }

        ToolTip bilgiMesaji(string baslik, string aciklama, Control nesne)
        {
           
            ToolTip bilgi = new ToolTip(); 
            bilgi.Active = true; // görünürlüğü 
            bilgi.ToolTipTitle = baslik; //mesaj başlığı 
            bilgi.ToolTipIcon = ToolTipIcon.Info; //ikon 
            bilgi.UseFading = true; //silik olarak kaybolup yüklenme 
            bilgi.UseAnimation = true; 
            bilgi. IsBalloon = true; 
            bilgi.ShowAlways = true; //her zaman göster 
            bilgi.AutoPopDelay = 2500; //mesajın açık kalma süresi 
            bilgi. ReshowDelay = 2000; //mouse çekildikten kaç ms sonra kaybolacağı 
            bilgi. InitialDelay = 700; //mesajın açılma süresi 
            bilgi.BackColor = Color.White; 
            bilgi.ForeColor = Color.DarkBlue; 
            bilgi.SetToolTip(nesne, aciklama); //hangi kontrolde görüneceği

            return bilgi;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult secenek = MessageBox.Show("Kaydı silmek istiyor musunuz?", "Bilgilendirme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (secenek == DialogResult.Yes)
                {

                    (new musteriSERVICE()).musteriSil(((musteriDOMAIN)listBoxKisiler.SelectedItem).Id);
                    kisileriOku();
                    grafikOku();
                }
                else if (secenek == DialogResult.No)
                {
                    kisileriOku();
                }
            }        
            catch
            {
                MessageBox.Show("Listeden Seçim Yapınız!", "UYARI!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
           
        }

        private void button5_Click(object sender, EventArgs e)
        {

            DialogResult secenek = MessageBox.Show("İşlem Geçmişini Temizlemek İstiyor Musunuz?", "Bilgilendirme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (secenek == DialogResult.Yes)
            {
                MySqlConnection baglanti = new MySqlConnection("server=localhost;user id=melihengin;password=12345;database=ybsdb;persistsecurityinfo=True");
                baglanti.Open();
                MySqlCommand komut = new MySqlCommand("delete from gecmis", baglanti);
                komut.ExecuteReader();
                gecmisOku();
            }
            else if (secenek == DialogResult.No)
            {
                gecmisOku();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
                DialogResult secenek = MessageBox.Show("Seçili Geçmiş İşlemi Silmek İstiyor Musunuz?", "Bilgilendirme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (secenek == DialogResult.Yes)
                {
                     try
                      {
                        (new gecmisSERVICE()).gecmisSil(((gecmisDOMAIN)listBoxGecmis.SelectedItem).Id);
                        gecmisOku();
                      }
                     catch
                     {
                         MessageBox.Show("Listeden Seçim Yapınız!", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                     }
                }
                else if (secenek == DialogResult.No)
                {
                    gecmisOku();
                }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new KisiRapor().Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            new GecmisRapor().Show();
        }

        private void bilgiBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Küçük İşletmeler için oluşturulmuş basit bir hesap tutma uygulamasıdır. Programda müşteri yaratıp müşteriden alacak eklenebilir. Daha sonra dilerseniz bu alacaktan bir kısmını silip veya ekleme yapabilirsiniz. Borcu biten müşteriyi silerek kayıttan çıkarabilirsiniz. Programda butonların üzerine gelerek butonlar hakkında ek bilgi alabilirsiniz."
            , "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
       
    }
}
