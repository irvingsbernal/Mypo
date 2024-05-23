using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mypo.DAO
{
    class ConexionSQL
    {
        private static ConexionSQL Con = null;

        private ConexionSQL()
        {
            
        }

        public SqlConnection CrearConexion()
        {
            SqlConnection connection = new SqlConnection();

            try
            {
                connection.ConnectionString = "Server=localhost;persist security info=True;Integrated Security=True;Database=mypo";

            }
            catch(Exception ex)
            {
                connection = null;
                throw ex;
            }

            return connection;

        }

        public static ConexionSQL getInstancia()
        {
            if (Con == null)
            {
                Con = new ConexionSQL();
            }
            return Con;
        }
    }
}
