using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MusteriTakip.DAL;
using MusteriTakip.SERVICE;
using MusteriTakip.DOMAIN;
using System.Collections;

namespace MusteriTakip.DAL
{
    class musteriDAO
    {
   
        public void musteriEkle(musteriDOMAIN gMusteri)
        {
          (new MySqlCommand("INSERT INTO musteri (ad,soyad,telefon,adres,aciklama,borc,tarih) VALUES ('" + gMusteri.Ad + "','" + gMusteri.Soyad + "','" + gMusteri.Telefon + "','" + gMusteri.Adres + "','" + gMusteri.Aciklama + "','" + gMusteri.BorcTutari + "','" + gMusteri.Tarih + "')", (new dbBaglanti().baglantiGetir()))).ExecuteNonQuery();
          (new MySqlCommand("INSERT INTO gecmis (ad,soyad,aciklama,borc,tarih) VALUES ('" + gMusteri.Ad + "','" + gMusteri.Soyad + "','" + gMusteri.Aciklama + "','" + gMusteri.BorcTutari + "','" + gMusteri.Tarih + "')", (new dbBaglanti().baglantiGetir()))).ExecuteNonQuery(); 
          
        }

        internal System.Collections.ArrayList gecmisOku()
        {
            ArrayList okunanGecmis = new ArrayList();
            MySqlDataReader okunan = (new MySqlCommand("select * from musteri", (new dbBaglanti()).baglantiGetir())).ExecuteReader();
            while (okunan.Read())
            {
                okunanGecmis.Add(new musteriDOMAIN(Convert.ToInt32(okunan[0]), okunan[1].ToString(), okunan[2].ToString(), okunan[3].ToString(),okunan[4].ToString(),okunan[5].ToString(), Convert.ToDouble(okunan[6]), okunan[7].ToString()));
            }
            return okunanGecmis;
        }

        public void musteriGuncelle(musteriDOMAIN gMusteri)
        {
            (new MySqlCommand("UPDATE musteri SET ad='" + gMusteri.Ad + "', soyad='" + gMusteri.Soyad + "', telefon='" + gMusteri.Telefon + "', adres='" + gMusteri.Adres + "', aciklama='" + gMusteri.Aciklama + "', borc='" + gMusteri.BorcTutari + "', tarih='" + gMusteri.Tarih
               + "' WHERE musteriId= " + gMusteri.Id, (new dbBaglanti()).baglantiGetir())).ExecuteNonQuery();

            (new MySqlCommand("INSERT INTO gecmis (ad,soyad,aciklama,borc,tarih) VALUES ('" + gMusteri.Ad + "','" + gMusteri.Soyad + "','" + gMusteri.Aciklama + "','" + gMusteri.BorcTutari + "','" + gMusteri.Tarih + "')", (new dbBaglanti().baglantiGetir()))).ExecuteNonQuery(); 
          
        }

        internal void musteriSil(int gId)
        {
            (new MySqlCommand("delete from musteri where musteriId=" + gId, (new dbBaglanti()).baglantiGetir())).ExecuteNonQuery();
        }
    }
}
