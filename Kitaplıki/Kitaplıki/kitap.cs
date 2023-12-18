using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitaplık
{
    class kitap
    {
        int id;
        string ad, yazar;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string ADI
        {
            get { return ad; }
            set { ad = value; }
        }

        public string YAZARI
        {
            get { return yazar; }
            set { yazar = value; }
        }
       
    }
}
