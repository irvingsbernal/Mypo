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
    public class DAOIngreso
    {

        public DataTable Listar()
        {
            SqlDataReader result;
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection();

            try
            {
                conn = ConexionSQL.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("ingreso_listar", conn);
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
                SqlCommand cmd = new SqlCommand("ingreso_buscar", conn);
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

        public string Insertar(Ingreso i)
        {
            string response = null;
            SqlConnection conn = new SqlConnection();
            try
            {
                conn = ConexionSQL.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("ingreso_insertar", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@idproveedor", SqlDbType.Int).Value = i.IdProveedor;
                cmd.Parameters.Add("@idusuario", SqlDbType.Int).Value = i.IdUsuario;
                cmd.Parameters.Add("@tipo_comprobante", SqlDbType.VarChar).Value = i.TipoComprobante;
                cmd.Parameters.Add("@folio", SqlDbType.VarChar).Value = i.Folio;
                cmd.Parameters.Add("@num_licencia", SqlDbType.VarChar).Value = i.NumLicencia;
                cmd.Parameters.Add("@impuesto", SqlDbType.VarChar).Value = i.Impuesto;
                cmd.Parameters.Add("@total", SqlDbType.VarChar).Value = i.Total;
                cmd.Parameters.Add("@detalle", SqlDbType.Structured).Value = i.Detalles;
                conn.Open();
                cmd.ExecuteNonQuery();
                response = "Ok";
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

        public string Cancelar(int id)
        {
            string response = null;
            SqlConnection conn = new SqlConnection();

            try
            {
                conn = ConexionSQL.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("ingreso_anular", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@idingreso", SqlDbType.Int).Value = id;
                conn.Open();
                response = cmd.ExecuteNonQuery() == 1 ? "Ok" : "No se pudo cancelar este ítem";
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

        public DataTable BuscarCodigo(string valor)
        {
            SqlDataReader result;
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection();
            try
            {
                conn = ConexionSQL.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("embarque_buscar_codigo", conn);
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

        public DataTable ListarDetalle(int id)
        {
            SqlDataReader result;
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection();
            try
            {
                conn = ConexionSQL.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("ingreso_mostrarDetalle", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@idingreso", SqlDbType.Int).Value = id;
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
    }
}
