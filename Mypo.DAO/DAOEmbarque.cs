using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using Mypo.Model;


namespace Mypo.DAO
{
    public class DAOEmbarque
    {

        public DataTable Listar()
        {
            SqlDataReader result;
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection();

            try
            {
                conn = ConexionSQL.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("embarque_listar", conn);
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
                SqlCommand cmd = new SqlCommand("embarque_buscar", conn);
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

        public DataTable ListarCategorias()
        {
            SqlDataReader result;
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection();

            try
            {
                conn = ConexionSQL.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("embarque_listarCategorias", conn);
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
        public string Existe(string valor)
        {
            string response = null;
            SqlConnection conn = new SqlConnection();

            try
            {
                conn = ConexionSQL.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("embarque_existe", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@valor", SqlDbType.VarChar).Value = valor;
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

        public string Insertar(Embarque e)
        {
            string response = null;
            SqlConnection conn = new SqlConnection();
            try
            {
                conn = ConexionSQL.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("embarque_insertar", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@idcategoria", SqlDbType.Int).Value = e.IdCategoria;
                cmd.Parameters.Add("@codigo", SqlDbType.VarChar).Value = e.Codigo;
                cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = e.Nombre;
                cmd.Parameters.Add("@costo", SqlDbType.Decimal).Value = e.Costo;
                cmd.Parameters.Add("@stock", SqlDbType.Int).Value = e.Stock;
                cmd.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = e.Descripcion;
                cmd.Parameters.Add("@imagen", SqlDbType.Image);

                MemoryStream ms = new MemoryStream();
                e.Imagen.Save(ms, ImageFormat.Png);

                cmd.Parameters["@imagen"].Value = ms.GetBuffer();

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

        public string Actualizar(Embarque e)
        {

            string response = null;
            SqlConnection conn = new SqlConnection();
            try
            {
                conn = ConexionSQL.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("embarque_actualizar", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@idembarque", SqlDbType.Int).Value = e.Id;
                cmd.Parameters.Add("@idcategoria", SqlDbType.Int).Value = e.IdCategoria;
                cmd.Parameters.Add("@codigo", SqlDbType.VarChar).Value = e.Codigo;
                cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = e.Nombre;
                cmd.Parameters.Add("@costo", SqlDbType.Decimal).Value = e.Costo;
                cmd.Parameters.Add("@stock", SqlDbType.Int).Value = e.Stock;
                cmd.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = e.Descripcion;
                cmd.Parameters.Add("@imagen", SqlDbType.Image);

                MemoryStream ms = new MemoryStream();
                e.Imagen.Save(ms, ImageFormat.Png);

                cmd.Parameters["@imagen"].Value = ms.GetBuffer();

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
                SqlCommand cmd = new SqlCommand("embarque_eliminar", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@idembarque", SqlDbType.Int).Value = id;
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
        public string Activar(int id)
        {
            string response = null;
            SqlConnection conn = new SqlConnection();

            try
            {
                conn = ConexionSQL.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("embarque_activar", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@idembarque", SqlDbType.Int).Value = id;
                conn.Open();
                response = cmd.ExecuteNonQuery() == 1 ? "Ok" : "No se pudo activar este ítem.";
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
        public string Desactivar(int id)
        {
            string response = null;
            SqlConnection conn = new SqlConnection();

            try
            {
                conn = ConexionSQL.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("embarque_desactivar", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@idembarque", SqlDbType.Int).Value = id;
                conn.Open();
                response = cmd.ExecuteNonQuery() == 1 ? "Ok" : "No se pudo desactivar este ítem.";
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