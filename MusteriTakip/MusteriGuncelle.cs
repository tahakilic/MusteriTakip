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

namespace MusteriTakip
{
    public partial class MusteriGuncelle : Form
    {
        public MusteriGuncelle(musteriDOMAIN gKisi)
        {
            InitializeComponent();
            idLabel.Text = gKisi.Id.ToString();
            musteriAdTxt.Text = gKisi.Ad;
            musteriSoyadTxt.Text = gKisi.Soyad;
            musteriTelefonTxt.Text = gKisi.Telefon;
            musteriAdresTxt.Text = gKisi.Adres;
            urunAciklamaTxt.Text = gKisi.Aciklama;
            urunToplamBorc.Text = gKisi.BorcTutari.ToString();
            

        }

        private void MusteriGuncelle_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                (new musteriSERVICE()).musteriGuncelle(idLabel.Text, musteriAdTxt.Text, musteriSoyadTxt.Text, musteriTelefonTxt.Text, musteriAdresTxt.Text, urunAciklamaTxt.Text, urunToplamBorc.Text, urunTarih.Text);
                MessageBox.Show("Müşteri Bilgileri Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Değişiklilik Kaydedilirken Sorun Oluştu!!!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(urunToplamBorc.Text);
            double b=Convert.ToDouble(urunBorcTutari.Text);
            urunToplamBorc.Text = (a + b).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(urunToplamBorc.Text);
            double b = Convert.ToDouble(urunBorcTutari.Text);
            urunToplamBorc.Text = (a - b).ToString();
        }

        private void musteriAdTxt_TextChanged(object sender, EventArgs e)
        {
            musteriAdTxt.Text = musteriAdTxt.Text.ToUpper();
            musteriAdTxt.SelectionStart = musteriAdTxt.Text.Length;
        }

        private void musteriSoyadTxt_TextChanged(object sender, EventArgs e)
        {
            musteriSoyadTxt.Text = musteriSoyadTxt.Text.ToUpper();
            musteriSoyadTxt.SelectionStart = musteriSoyadTxt.Text.Length;
        }
    }
}
