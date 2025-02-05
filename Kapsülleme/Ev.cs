using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kapsülleme
{
    internal class Ev
    {
        private int fiyat;
        private string tur;

        public int FİYAT
        {
            get { return fiyat; }
            set { fiyat = value; }
        }
        public string TUR
        {
            get { return tur; }
            set { tur = value; }
        }
    }
}
