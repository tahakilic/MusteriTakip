using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusteriTakip.DAL;
using MusteriTakip.SERVICE;
using MusteriTakip.DOMAIN;

namespace MusteriTakip.SERVICE
{
    class musteriSERVICE
    {
        internal void musteriEkle(string gMusteriAd, string gMusteriSoyad, string gMusteriAdres, string gMusteriTelefon,string gUrunAciklama,string gUrunBorcTutari,string gUrunTarih)
        {
            (new musteriDAO()).musteriEkle(new musteriDOMAIN(gMusteriAd, gMusteriSoyad, gMusteriAdres, gMusteriTelefon,gUrunAciklama,Convert.ToDouble(gUrunBorcTutari),gUrunTarih));
        }

        internal System.Collections.ArrayList gecmisOku()
        {
            return (new musteriDAO()).gecmisOku();
        }

        internal void musteriGuncelle(string gId, string gMusteriAd, string gMusteriSoyad, string gMusteriTelefon, string gMusteriAdres, string gUrunAciklama, string gUrunBorcTutari, string gUrunTarih)
        {
            (new musteriDAO()).musteriGuncelle(new musteriDOMAIN(Convert.ToInt32(gId), gMusteriAd, gMusteriSoyad, gMusteriTelefon, gMusteriAdres, gUrunAciklama, Convert.ToDouble(gUrunBorcTutari), gUrunTarih));
       
        }
        internal void musteriSil(int gId)
        {
            (new musteriDAO()).musteriSil(gId);

        }
    }
}
