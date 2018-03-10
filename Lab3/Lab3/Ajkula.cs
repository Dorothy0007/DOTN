using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Ajkula : Riba
    {
        private DateTime _datumUlova { get => _datumUlova; set => _datumUlova = DateTime.Now; }
        enum VrstaAjkule { Veliki_Bijeli, Tigar, Modrulj};

        public int ProsloOdUlova()
        {
            return (DateTime.Now - _datumUlova).Days;
        }
    }
}
