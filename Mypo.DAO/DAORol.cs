﻿using Mypo.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mypo.DAO
{
    public class DAORol
    {

        public DataTable Listar()
        {

            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = ConexionSQL.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("rol_listar", SqlCon);
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

        public DataTable Buscar(string valor)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = ConexionSQL.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("rol_buscar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.AddWithValue("@valor", valor);
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
                SqlCommand Comando = new SqlCommand("rol_existe", SqlCon);
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

        public string Insertar(Rol r)
        {
            string Respuesta = null;
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = ConexionSQL.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("rol_insertar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = r.Nombre;
                Comando.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = r.Descripcion;
                SqlCon.Open();
                Respuesta = Comando.ExecuteNonQuery() == 1 ? "Ok" : "No se pudo guardar el registro";
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

        public string Actualizar(Rol r)
        {

            string Respuesta = null;
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = ConexionSQL.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("rol_actualizar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@idrol", SqlDbType.Int).Value = r.Id;
                Comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = r.Nombre;
                Comando.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = r.Descripcion;
                SqlCon.Open();
                Respuesta = Comando.ExecuteNonQuery() == 1 ? "Ok" : "No se pudo actualizar el registro";
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
                SqlCommand Comando = new SqlCommand("rol_eliminar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@idrol", SqlDbType.Int).Value = id;
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
                SqlCommand Comando = new SqlCommand("rol_activar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@idrol", SqlDbType.Int).Value = id;
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
                SqlCommand Comando = new SqlCommand("rol_desactivar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@idrol", SqlDbType.Int).Value = id;
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
