using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTPI_3k5.datos
{
    public class Cliente
    {
        public int Nro_Doc { get; set; }
        /* public int ro_Doc { get; set; }
         public string Ape_Cliente { get; set; }
         public string Calle { get; set; }
         public int Nro_calle { get; set; }*/







        public Cliente(int Doc)
        {
            this.Nro_Doc = Doc;


        }
    }

}
