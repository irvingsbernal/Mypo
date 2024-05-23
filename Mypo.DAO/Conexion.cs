using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mypo.DAO
{
    public class Conexion
    {
        private string Bd;
        private string Servidor;
        private string User;
        private string Password;
        private bool Seguridad;
        private static Conexion Con = null;

        private Conexion()
        {
            this.Bd = "mypo";
            this.Servidor = "DESKTOP-AC6G37A\\LOCALDB#DC794AAC";
            this.User = "DESKTOP-AC6G37A\\Lenovo";
            this.Password = "";
            this.Seguridad = true;
        }

        public SqlConnection CrearConexion()
        {
            SqlConnection Cadena = new SqlConnection();

            try
            {
                Cadena.ConnectionString = "Server=" + this.Servidor + "; Database=" + this.Bd + ";";
                if (this.Seguridad)
                {
                    Cadena.ConnectionString = Cadena.ConnectionString + "Integrated Security = SSPI";
                }
                else
                {
                    Cadena.ConnectionString = Cadena.ConnectionString + "User Id =" + this.User + "; Password =" + this.Password;
                }
            }
            catch (Exception ex)
            {
                Cadena = null;
                throw ex;
            }

            return Cadena;

        }

        public static Conexion getInstancia()
        {
            if(Con == null)
            {
                Con = new Conexion();
            }
            return Con;
        }
    }
}
