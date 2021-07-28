using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusteriTakip.DAL;
using MusteriTakip.SERVICE;
using MusteriTakip.DOMAIN;

namespace MusteriTakip.DOMAIN
{
   public class gecmisDOMAIN
    {
          public gecmisDOMAIN(int gGecmisId, string gMusteriAd, string gMusteriSoyad, string gUrunAciklama, double gUrunBorcTutari, string gUrunTarih)
        {
            this.Id=gGecmisId;
            this.Ad = gMusteriAd;
            this.Soyad = gMusteriSoyad;
            this.Aciklama = gUrunAciklama;
            this.BorcTutari = gUrunBorcTutari;
            this.Tarih = gUrunTarih;
        }

        string ad;

        public string Ad
        {
            get { return ad; }
            set { ad = value; }
        }

        string soyad;

        public string Soyad
        {
            get { return soyad; }
            set { soyad = value; }
        }
        string aciklama;

        public string Aciklama
        {
            get { return aciklama; }
            set { aciklama = value; }
        }
       
        double borcTutari;

        public double BorcTutari
        {
            get { return borcTutari; }
            set { borcTutari = value; }
        }
       
        string tarih;

        public string Tarih
        {
            get { return tarih; }
            set { tarih = value; }
        }
      
        int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public override string ToString()
        {
            return this.Ad + " " + this.Soyad + "----Açıklama=" + this.Aciklama + "----Alacak Tutarı(TL)=" + this.BorcTutari;
        }

    }
}
