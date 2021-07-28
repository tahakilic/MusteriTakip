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
    class gecmisDAO
    {
        internal System.Collections.ArrayList gecmisOku()
        {
            ArrayList okunanGecmis = new ArrayList();
            MySqlDataReader okunan = (new MySqlCommand("select * from gecmis", (new dbBaglanti()).baglantiGetir())).ExecuteReader();
            while (okunan.Read())
            {
                okunanGecmis.Add(new gecmisDOMAIN(Convert.ToInt32(okunan[0]), okunan[1].ToString(), okunan[2].ToString(), okunan[3].ToString(), Convert.ToDouble(okunan[4]), okunan[5].ToString()));
            }
            return okunanGecmis;
        }

        internal void gecmisSil(int gId)
        {
            (new MySqlCommand("delete from gecmis where gecmisId=" + gId, (new dbBaglanti()).baglantiGetir())).ExecuteNonQuery();
        }
    }
}
