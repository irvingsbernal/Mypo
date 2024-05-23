using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Drawing;
using Mypo.Model;
using System.IO;
using System.Data;

namespace Mypo.DAO
{
    public class DAOLogIn
    {
        public bool Login(string valor, string contrasenia)
        {
            SqlConnection connection = ConexionSQL.getInstancia().CrearConexion();

            try
            {

                SqlDataReader reader = null;

                SqlCommand cmd = new SqlCommand("iniciarSesion", connection);

                connection.Open();

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@valor",valor);

                cmd.Parameters.AddWithValue("@contrasenia", contrasenia);

                reader = cmd.ExecuteReader();

                if (reader.Read())
                {

                    Cache.Id = Convert.ToInt32(reader["idusuario"]);
                    Cache.IdRol = Convert.ToInt32(reader["idrol"]);
                    Cache.Nombre = reader["nombre"].ToString();
                    Cache.Primer_Apellido= reader["primer_apellido"].ToString();
                    Cache.Segundo_Apellido = reader["segundo_apellido"].ToString();
                    Cache.NSS = reader["nss"].ToString();
                    Cache.RFC = reader["rfc"].ToString();
                    Cache.Direccion = reader["direccion"].ToString();
                    Cache.Telefono = reader["telefono"].ToString();
                    Cache.Email = reader["email"].ToString();
                    Cache.Estado = Convert.ToInt32(reader["estado"]);

                    if(reader["foto"] == DBNull.Value)
                    {
                        Cache.Foto = null;
                    }
                    else
                    {
                        Cache.Foto = Image.FromStream(new MemoryStream((byte[])reader["foto"]));
                    }
                    
                    return true;
                }

                return false;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                if (connection.State == ConnectionState.Open) connection.Close();
            }
        }
    }
}
