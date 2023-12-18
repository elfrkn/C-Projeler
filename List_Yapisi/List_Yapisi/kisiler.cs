using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace List_Yapisi
{
    class kisiler
    {
        string ad, soyad, meslek;

        public string ADI
        {
            get { return ad; }
            set { ad = value; }
        }
        public string SOYADI
        {
            get { return soyad; }
            set { soyad = value; }
        }

        public string MESLEK
        {
            get { return meslek; }
            set { meslek = value; }
        }
    }
}
