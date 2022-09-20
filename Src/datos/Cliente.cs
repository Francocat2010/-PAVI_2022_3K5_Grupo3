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
        public string Nom_Cliente { get; set; }
        public string Ape_Cliente { get; set; }
        public string Calle { get; set; }
        public int Nro_calle { get; set; }
        public int Barrio { get; set; }
        public bool Activo { get; set; }





        public Cliente()
        {

        }





        public Cliente(int Doc, string Nombre, string Apellido, int Numero_calle, string Calle, int Barrio, bool Activo)
        {
            Nro_Doc = Doc;
            Nom_Cliente = Nombre;
            Ape_Cliente = Apellido;
            this.Nro_calle = Numero_calle;
            this.Calle = Calle;
            this.Barrio = Barrio;
            this.Activo = Activo;


        }
    }

}
