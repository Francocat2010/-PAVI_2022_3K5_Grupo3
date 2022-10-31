using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_TPI.Entidades
{
    public class Localidades
    {
        private int Cod_postal;
        private string Nombre;

        public Localidades() { }

        public Localidades(int codigo_postal, String nombre)
        {
            Cod_postal = codigo_postal;
            String Nombre_localidad = nombre;
        }
        public int Codigo_postal
        {
            get => Codigo_postal;
            set => Codigo_postal = value;
        }
        public string Nombre_localidad { get; set; }
        //public string Nombre_servicio
        /*{
            get => Nombre_servicio;
            set => Nombre_servicio = value;
        }*/

    }
}
