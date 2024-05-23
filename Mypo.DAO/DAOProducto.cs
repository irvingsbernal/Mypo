using Mypo.Model;
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

namespace Mypo.DAO
{
    public class DAOProducto
    {

        public DataTable Listar()
        {
            SqlDataReader result;
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection();

            try
            {
                conn = ConexionSQL.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("producto_listar", conn);
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


        public DataTable VerDetalle(int id)
        {
            SqlDataReader result;
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection();

            try
            {
                conn = ConexionSQL.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("producto_verDetalle", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
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

        public List<Producto> ProductosEnPreventa()
        {
            SqlDataReader result;
            SqlConnection conn = null;
            List<Producto> productos = new List<Producto>();
            try
            {
                conn = ConexionSQL.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("listarProductosPreventa", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();
                result = cmd.ExecuteReader();

                while (result.Read())
                {
                    Producto p = new Producto();
                    
                    p.Id = Convert.ToInt32(result["ID"]);
                    p.Nombre = result["Nombre"].ToString();
                    p.Descripcion = result["Descripcion"].ToString();
                    p.PrecioVenta= Convert.ToDecimal(result["Costo"]);
                    p.Stock = Convert.ToInt32(result["Disponibilidad"]);

                    MemoryStream ms = new MemoryStream((byte[])result["Foto"]);

                    p.Imagen = Image.FromStream(ms);

                    productos.Add(p);
                }

                return productos;
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
                SqlCommand cmd = new SqlCommand("producto_buscar", conn);
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
                SqlCommand cmd = new SqlCommand("producto_listarCategorias", conn);
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
                SqlCommand cmd = new SqlCommand("producto_existe", conn);
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

        public string Insertar(Producto p)
        {
            string response = null;
            SqlConnection conn = new SqlConnection();
            try
            {
                conn = ConexionSQL.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("producto_insertar", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@idcategoria", SqlDbType.Int).Value = p.IdCategoria;
                cmd.Parameters.Add("@codigo", SqlDbType.VarChar).Value = p.Codigo;
                cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = p.Nombre;
                cmd.Parameters.Add("@precio_venta", SqlDbType.Decimal).Value = p.PrecioVenta;
                cmd.Parameters.Add("@stock", SqlDbType.Int).Value = p.Stock;
                cmd.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = p.Descripcion;
                cmd.Parameters.Add("@imagen", SqlDbType.Image);
                cmd.Parameters.Add("@detalle",SqlDbType.Structured).Value = p.Detalle;

                MemoryStream ms = new MemoryStream();

                p.Imagen.Save(ms, ImageFormat.Png);

                cmd.Parameters["@imagen"].Value = ms.GetBuffer();

                conn.Open();
                response = cmd.ExecuteNonQuery() == 1 ? "Ok" : "Se ha realizado el registro";
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

        public string Actualizar(Producto p)
        {

            string response = null;
            SqlConnection conn = new SqlConnection();
            try
            {
                conn = ConexionSQL.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("producto_actualizar", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@idproducto", SqlDbType.Int).Value = p.Id;
                cmd.Parameters.Add("@idcategoria", SqlDbType.Int).Value = p.IdCategoria;
                cmd.Parameters.Add("@codigo", SqlDbType.VarChar).Value = p.Codigo;
                cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = p.Nombre;
                cmd.Parameters.Add("@precio_venta", SqlDbType.Decimal).Value = p.PrecioVenta;
                cmd.Parameters.Add("@stock", SqlDbType.Int).Value = p.Stock;
                cmd.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = p.Descripcion;
                cmd.Parameters.Add("@imagen", SqlDbType.Image);

                MemoryStream ms = new MemoryStream();

                p.Imagen.Save(ms,ImageFormat.Png);

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
                SqlCommand cmd = new SqlCommand("producto_eliminar", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@idproducto", SqlDbType.Int).Value = id;
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
                SqlCommand cmd = new SqlCommand("producto_activar", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@idproducto", SqlDbType.Int).Value = id;
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
                SqlCommand cmd = new SqlCommand("producto_desactivar", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@idproducto", SqlDbType.Int).Value = id;
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