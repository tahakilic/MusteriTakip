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

namespace MusteriTakip
{
    public partial class MusteriEkle : Form
    {
        public MusteriEkle()
        {
            InitializeComponent();
        }

        private void musteriEkleBtn_Click(object sender, EventArgs e)
        {
            try
            {
                (new musteriSERVICE()).musteriEkle(musteriAdTxt.Text, musteriSoyadTxt.Text, musteriAdresTxt.Text, musteriTelefonTxt.Text, urunAciklamaTxt.Text, urunBorcTutari.Text, urunTarih.Text);
                MessageBox.Show("Müşteri Oluşturuldu.", "Bilgi", MessageBoxButtons.OK ,MessageBoxIcon.Information);

                
            }
            catch
            {
                MessageBox.Show("Müşteri Oluşturulurken Sorun Oluştu!!!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            
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
