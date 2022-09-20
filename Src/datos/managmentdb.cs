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

        public DataTable ConsultaSQL(string strSql, Dictionary<string, object> prs = null)
        {
            SqlCommand cmd = new SqlCommand();
            DataTable tabla = new DataTable();

            cnn.Open();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = strSql;

            
            if (prs != null)
            {
                foreach (var item in prs)
                {
                    cmd.Parameters.AddWithValue(item.Key, item.Value);
                }
            }
            tabla.Load(cmd.ExecuteReader());
            cnn.Close();

            return tabla;
        }
        public int EjecutarSQL(string strSql, Dictionary<string, object> prs = null)
        {
            
            SqlCommand cmd = new SqlCommand();

            int rtdo = 0;

           
            cnn.Open();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = strSql;

            if (prs != null)
            {
                foreach (var item in prs)
                {
                    cmd.Parameters.AddWithValue(item.Key, item.Value);
                }
            }

               
            rtdo = cmd.ExecuteNonQuery();
            return rtdo;
        }

    }
}
