using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace MusteriTakip.DAL
{
    class dbBaglanti
    {
        public MySqlConnection baglantiGetir()
        {
            MySqlConnection baglanti = new MySqlConnection("Server=localhost; Database=ybsdb; Uid=melihengin; Pwd=12345");
            baglanti.Open();
            return baglanti;
        }
    }
}
