using Capa_Entidad;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace CapaDatos
{
    public class CD_Negocio
    {
        /// <summary>
        /// Return a object type Negocio with all data
        /// </summary>
        /// <returns>Negocio object</returns>
        public Negocio ObtenerDatos()
        {
            Negocio objNegocio = new Negocio();

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    conexion.Open();

                    string query = "select id as Id, nombre as Nombre, ruc as Ruc, direccion as Direccion from negocio where id = 1";
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.CommandType = CommandType.Text;

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read()) {
                            objNegocio = new Negocio()
                            {
                                Id = Convert.ToInt32(dr["Id"].ToString()),
                                Nombre = dr["Nombre"].ToString(),
                                RUC = dr["Ruc"].ToString(),
                                Direccion = dr["Direccion"].ToString()

                            };
                        }
                    }
                }
                catch 
                {
                    objNegocio = new Negocio();
                }

                return objNegocio;
            }
        }

        public bool GuardarDatos(Negocio objNegocio, out string mensaje)
        {
            mensaje = string.Empty;
            bool respuesta = true;

            using (SqlConnection conn = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    conn.Open();

                    StringBuilder sbquery = new StringBuilder();
                    sbquery.AppendLine("Update negocio set nombre = @nombre,");
                    sbquery.AppendLine("ruc = @ruc,");
                    sbquery.AppendLine("direccion = @direccion");
                    sbquery.AppendLine("where id = 1");

                    SqlCommand cmd = new SqlCommand(sbquery.ToString(), conn);
                    cmd.Parameters.AddWithValue("@nombre", objNegocio.Nombre);
                    cmd.Parameters.AddWithValue("@ruc", objNegocio.RUC);
                    cmd.Parameters.AddWithValue("@direccion", objNegocio.Direccion);
                    cmd.CommandType = CommandType.Text;

                    if (cmd.ExecuteNonQuery() < 1)
                    {
                        mensaje = "No se pudo guardar los datos";
                        respuesta = false;
                    }
                }
                catch(Exception e) 
                {
                    mensaje = e.Message;
                    respuesta = false;
                }
            }

            return respuesta;
        }


        /// <summary>
        /// metodo para obtener el logo del negocio
        /// </summary>
        /// <param name="obtenido">validar si se obtuvo el logo</param>
        /// <returns>byte[]</returns>
        public byte[] ObtenerLogo(out bool obtenido)
        {
            obtenido = true;
            byte[] LogoByte = new byte[0];

            using (SqlConnection conn = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    conn.Open();
                    string query = "select logo as Logo from negocio where id = 1";

                    SqlCommand cmd = new SqlCommand(@query, conn);
                    cmd.CommandType= CommandType.Text;

                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            LogoByte = (byte[])reader["Logo"];
                            //objNegocio = new Negocio()
                            //{

                            //}
                        }
                    }
                }
                catch (Exception e)
                {
                    obtenido =false;
                    LogoByte = new byte[0];
                }
            }

            return LogoByte;
        }

        public bool ActualizarLogo(byte[] image, out string mensaje)
        {
            mensaje = string.Empty;
            bool respuesta = true;

            using (SqlConnection conn = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    conn.Open();
                    StringBuilder sbquery = new StringBuilder();
                    sbquery.AppendLine("update negocio set logo = @image");
                    sbquery.AppendLine("where id = 1");

                    SqlCommand cmd = new SqlCommand(@sbquery.ToString(), conn);
                    cmd.Parameters.AddWithValue("@image", image);
                    cmd.CommandType= CommandType.Text;

                    if (cmd.ExecuteNonQuery() < 1)
                    {
                        mensaje = "No se puedo actualizar el logo";
                        respuesta = false;
                    }
                }
                catch (Exception e)
                {
                    mensaje = e.Message;
                    respuesta = false;
                }
            }

            return respuesta;
        }
    }
}
