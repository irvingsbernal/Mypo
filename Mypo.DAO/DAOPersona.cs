using Mypo.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mypo.DAO
{
    public class DAOPersona
    {
        public DataTable Listar()
        {
            SqlDataReader result;
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection();

            try
            {
                conn = ConexionSQL.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("persona_listar", conn);
                cmd.CommandType = CommandType.StoredProcedure;
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

        public DataTable ListarProveedores()
        {
            SqlDataReader result;
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection();

            try
            {
                conn = ConexionSQL.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("persona_listar_proveedores", conn);
                cmd.CommandType = CommandType.StoredProcedure;
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

        public DataTable ListarClientes()
        {
            SqlDataReader result;
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection();

            try
            {
                conn = ConexionSQL.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("persona_listar_clientes", conn);
                cmd.CommandType = CommandType.StoredProcedure;
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

        public DataTable Buscar(string valor)
        {
            SqlDataReader result;
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection();
            try
            {
                conn = ConexionSQL.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("persona_buscar", conn);
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

        public DataTable BuscarProveedores(string valor)
        {
            SqlDataReader result;
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection();
            try
            {
                conn = ConexionSQL.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("persona_buscar_proveedor", conn);
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

        public DataTable BuscarClientes(string valor)
        {
            SqlDataReader result;
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection();
            try
            {
                conn = ConexionSQL.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("persona_buscar_cliente", conn);
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

        public string Existe(string nombre, string primerApe, string segundoApe)
        {
            string response = null;
            SqlConnection conn = new SqlConnection();

            try
            {
                conn = ConexionSQL.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("persona_existe", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = nombre;
                cmd.Parameters.Add("@primer_apellido", SqlDbType.VarChar).Value = primerApe;
                cmd.Parameters.Add("@segundo_apellido", SqlDbType.VarChar).Value = segundoApe;
                SqlParameter parametroExiste = new SqlParameter();
                parametroExiste.ParameterName = "@existe";
                parametroExiste.SqlDbType = SqlDbType.Int;
                parametroExiste.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(parametroExiste);
                conn.Open();
                cmd.ExecuteNonQuery();
                response = Convert.ToString(parametroExiste.Value);
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

        public string Insertar(Persona p)
        {
            string response = null;
            SqlConnection conn = new SqlConnection();
            try
            {
                conn = ConexionSQL.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("persona_insertar", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@tipo_persona", SqlDbType.VarChar).Value = p.Tipo_Persona;
                cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = p.Nombre;
                cmd.Parameters.Add("@primer_apellido", SqlDbType.VarChar).Value = p.Primer_Apellido;
                cmd.Parameters.Add("@segundo_apellido", SqlDbType.VarChar).Value = p.Segundo_Apellido;
                cmd.Parameters.Add("@curp", SqlDbType.VarChar).Value = p.CURP;
                cmd.Parameters.Add("@rfc", SqlDbType.VarChar).Value = p.RFC;
                cmd.Parameters.Add("@direccion", SqlDbType.VarChar).Value = p.Direccion;
                cmd.Parameters.Add("@telefono", SqlDbType.VarChar).Value = p.Telefono;
                cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = p.Email;


                conn.Open();
                response = cmd.ExecuteNonQuery() == 1 ? "Ok" : "No se pudo guardar el registro";
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

        public string Actualizar(Persona p)
        {

            string response = null;
            SqlConnection conn = new SqlConnection();
            try
            {
                conn = ConexionSQL.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("persona_actualizar", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@idpersona", SqlDbType.Int).Value = p.Id;
                cmd.Parameters.Add("@tipo_persona", SqlDbType.VarChar).Value = p.Tipo_Persona;
                cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = p.Nombre;
                cmd.Parameters.Add("@primer_apellido", SqlDbType.VarChar).Value = p.Primer_Apellido;
                cmd.Parameters.Add("@segundo_apellido", SqlDbType.VarChar).Value = p.Segundo_Apellido;
                cmd.Parameters.Add("@curp", SqlDbType.VarChar).Value = p.CURP;
                cmd.Parameters.Add("@rfc", SqlDbType.VarChar).Value = p.RFC;
                cmd.Parameters.Add("@direccion", SqlDbType.VarChar).Value = p.Direccion;
                cmd.Parameters.Add("@telefono", SqlDbType.VarChar).Value = p.Telefono;
                cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = p.Email;

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

        public string Eliminar(int id)
        {
            string response = null;
            SqlConnection conn = new SqlConnection();

            try
            {
                conn = ConexionSQL.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("persona_eliminar", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@idpersona", SqlDbType.Int).Value = id;
                conn.Open();
                response = cmd.ExecuteNonQuery() == 1 ? "Ok" : "No se pudo eliminar el registro";
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
    }
}