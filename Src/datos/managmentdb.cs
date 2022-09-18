using System.Data;
using System.Data.SqlClient;

namespace ProyectoTPI_3k5.datos
{
    class Managmentdb
    {
        private SqlConnection cnn;

        public Managmentdb()
        {
            cnn = new SqlConnection(Properties.Resources.cnnCadena);
        }

        public DataTable ConsultaSQL(string strSql, List<Usuario> lst)
        {
            SqlCommand cmd = new SqlCommand();
            DataTable tabla = new DataTable();

            cnn.Open();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = strSql;

            //if (lst != null && lst.Count > 0)
            foreach (Usuario p in lst)
            {
                cmd.Parameters.AddWithValue(p.NombreUsu, p.Pass);
            }

            tabla.Load(cmd.ExecuteReader());
            cnn.Close();

            return tabla;
        }
    }
}
