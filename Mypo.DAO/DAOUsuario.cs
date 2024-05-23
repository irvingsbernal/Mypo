using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using Mypo.Model;
using System.Drawing.Imaging;

namespace Mypo.DAO
{
    public class DAOUsuario
    {

        public DataTable Listar()
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = ConexionSQL.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("usuario_listar", SqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlCon.Open();
                Resultado = cmd.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }

        public DataTable Buscar (string valor)
        {
            SqlDataReader result;
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection();
            try
            {
                conn = ConexionSQL.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("usuario_buscar", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@valor", SqlDbType.VarChar).Value = valor;
                conn.Open();
                result = cmd.ExecuteReader();
                dt.Load(result);
                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        }

        public string Insertar(Usuario u)
        {
            string Respuesta = null;
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = ConexionSQL.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("usuario_insertar", SqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@idrol", SqlDbType.Int).Value = u.IdRol;
                cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = u.Nombre;
                cmd.Parameters.Add("@primer_apellido", SqlDbType.VarChar).Value = u.Primer_Apellido;
                cmd.Parameters.Add("@segundo_apellido", SqlDbType.VarChar).Value = u.Segundo_Apellido;
                cmd.Parameters.Add("@nss", SqlDbType.VarChar).Value = u.NSS;
                cmd.Parameters.Add("@rfc", SqlDbType.VarChar).Value = u.RFC;
                cmd.Parameters.Add("@direccion", SqlDbType.VarChar).Value = u.Direccion;
                cmd.Parameters.Add("@telefono", SqlDbType.VarChar).Value = u.Telefono;
                cmd.Parameters.Add("@foto", SqlDbType.Image);
                cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = u.Email;
                cmd.Parameters.Add("@contrasenia", SqlDbType.VarChar).Value = u.Contrasenia;

                MemoryStream ms = new MemoryStream();

                u.foto.Save(ms, ImageFormat.Jpeg);

                cmd.Parameters["@foto"].Value = ms.GetBuffer();
                SqlCon.Open();
                Respuesta = cmd.ExecuteNonQuery() == 1 ? "Ok" : "No se pudo guardar el registro";
            }
            catch (Exception ex)
            {
                Respuesta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Respuesta;
        }

        public string Actualizar(Usuario u)
        {
            string response = null;
            SqlConnection conn = new SqlConnection();
            try
            {
                conn = ConexionSQL.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("usuario_actualizar", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@idusuario", SqlDbType.Int).Value = u.Id;
                cmd.Parameters.Add("@idrol", SqlDbType.Int).Value = u.IdRol;
                cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = u.Nombre;
                cmd.Parameters.Add("@primer_apellido", SqlDbType.VarChar).Value = u.Primer_Apellido;
                cmd.Parameters.Add("@segundo_apellido", SqlDbType.VarChar).Value = u.Segundo_Apellido;
                cmd.Parameters.Add("@nss", SqlDbType.VarChar).Value = u.NSS;
                cmd.Parameters.Add("@rfc", SqlDbType.VarChar).Value = u.RFC;
                cmd.Parameters.Add("@direccion", SqlDbType.VarChar).Value = u.Direccion;
                cmd.Parameters.Add("@telefono", SqlDbType.VarChar).Value = u.Telefono;
                cmd.Parameters.Add("@foto", SqlDbType.Image);
                cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = u.Email;
                cmd.Parameters.Add("@contrasenia", SqlDbType.VarChar).Value = u.Contrasenia;

                MemoryStream ms = new MemoryStream();

                u.foto.Save(ms, ImageFormat.Jpeg);

                cmd.Parameters["@foto"].Value = ms.GetBuffer();

                conn.Open();
                response = cmd.ExecuteNonQuery() == 1 ? "Ok" : "No se pudo actualizar el registro";
            }
            catch (Exception ex)
            {
                response = ex.Message;
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
            return response;
        }

        public DataTable ListarRoles()
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = ConexionSQL.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("usuario_listarRoles", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }

        public string Existe(string valor)
        {
            string Respuesta = null;
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = ConexionSQL.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("usuario_existe", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = valor;
                SqlParameter parametroExiste = new SqlParameter();
                parametroExiste.ParameterName = "@existe";
                parametroExiste.SqlDbType = SqlDbType.Int;
                parametroExiste.Direction = ParameterDirection.Output;
                Comando.Parameters.Add(parametroExiste);
                SqlCon.Open();
                Comando.ExecuteNonQuery();
                Respuesta = Convert.ToString(parametroExiste.Value);
            }
            catch (Exception ex)
            {
                Respuesta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Respuesta;
        }

        public string Eliminar(int id)
        {
            string Respuesta = null;
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon = ConexionSQL.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("usuario_eliminar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@idusuario", SqlDbType.Int).Value = id;
                SqlCon.Open();
                Respuesta = Comando.ExecuteNonQuery() == 1 ? "Ok" : "No se pudo eliminar el registro";
            }
            catch (Exception ex)
            {
                Respuesta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Respuesta;
        }
        public string Activar(int id)
        {
            string Respuesta = null;
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon = ConexionSQL.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("usuario_activar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@idusuario", SqlDbType.Int).Value = id;
                SqlCon.Open();
                Respuesta = Comando.ExecuteNonQuery() == 1 ? "Ok" : "No se pudo activar este ítem";
            }
            catch (Exception ex)
            {
                Respuesta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Respuesta;
        }

        public string Desactivar(int id)
        {
            string Respuesta = null;
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon = ConexionSQL.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("usuario_desactivar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@idusuario", SqlDbType.Int).Value = id;
                SqlCon.Open();
                Respuesta = Comando.ExecuteNonQuery() == 1 ? "Ok" : "No se pudo desactivar este ítem";
            }
            catch (Exception ex)
            {
                Respuesta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Respuesta;

        }
    }
}
