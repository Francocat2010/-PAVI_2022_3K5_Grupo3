using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTPI_3k5.Entidades
{
    public class Usuario
    {
        private string NombreUsu;
        private string Pass;

        public Usuario(string NombreUsu, string password)
        {
            //NombreUsu = nombreUsu; Si el parametro es igual atributo agrego el this
            this.NombreUsu = NombreUsu;

            Pass = password;
            
        }

        //Propiedades que sean capaces de obtener o setear valores
        public string NombreDeUsuario
        {
            get => NombreUsu;
            set => NombreUsu = value;
        }

        public string Password
        {
            get => Pass;
            set => Pass = value;
        }
    }
}
