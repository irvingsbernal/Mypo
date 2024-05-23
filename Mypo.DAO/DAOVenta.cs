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
    public class DAOVenta
    {
        public DataTable Listar()
        {
            SqlDataReader result;
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection();

            try
            {
                conn = ConexionSQL.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("venta_listar", conn);
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

        public DataTable ListarDetalle(int id)
        {
            SqlDataReader result;
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection();
            try
            {
                conn = ConexionSQL.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("venta_mostrarDetalle", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                conn.Open();
                result = cmd.ExecuteReader();
                dt.Load(result);
                return dt;

            }
            catch (Exception ex)
            {
                return null;
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
                SqlCommand cmd = new SqlCommand("venta_buscar", conn);
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

        public DataTable BuscarProducto(string valor)
        {
            SqlDataReader result;
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection();
            try
            {
                conn = ConexionSQL.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("producto_buscarVenta", conn);
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

        public string Insertar(Venta v)
        {
            string response = null;
            SqlConnection conn = new SqlConnection();
            try
            {
                conn = ConexionSQL.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("venta_insertar", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@idusuario", SqlDbType.Int).Value = v.IdUsuario;
                cmd.Parameters.Add("@idcliente", SqlDbType.Int).Value = v.IdCliente;
                cmd.Parameters.Add("@num_ticket", SqlDbType.VarChar).Value = v.NumTicket;
                cmd.Parameters.Add("@tipo_comprobante", SqlDbType.VarChar).Value = v.TipoComprobante;
                cmd.Parameters.Add("@folio_comprobante", SqlDbType.VarChar).Value = v.FolioComprobante;
                cmd.Parameters.Add("@impuesto", SqlDbType.Decimal).Value = v.Impuesto;
                cmd.Parameters.Add("@total", SqlDbType.Decimal).Value = v.Total;
                cmd.Parameters.Add("@detalle", SqlDbType.Structured).Value = v.Detalles;
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
                SqlCommand cmd = new SqlCommand("venta_cancelar", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@idventa", SqlDbType.Int).Value = id;
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
                SqlCommand cmd = new SqlCommand("buscar_CodigoProducto", conn);
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

        public DataTable ListarVentasEntreFechas(DateTime fechaInicio, DateTime fechaFin)
        {
            SqlDataReader result;
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection();
            try
            {
                conn = ConexionSQL.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("venta_listarVentasEntreFechas", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@fechaInicio", SqlDbType.DateTime).Value = fechaInicio;
                cmd.Parameters.Add("@fechaFin", SqlDbType.DateTime).Value = fechaFin;
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
