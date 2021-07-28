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
    class gecmisSERVICE
    {
        internal System.Collections.ArrayList gecmisOku()
        {
            return (new gecmisDAO()).gecmisOku();
        }

        internal void gecmisSil(int gId)
        {
            (new gecmisDAO()).gecmisSil(gId);

        }
    }
}
