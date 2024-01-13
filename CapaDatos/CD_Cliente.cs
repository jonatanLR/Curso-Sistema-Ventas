using CapaEntidad;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using System;

namespace CapaDatos
{
    public class CD_Cliente
    {
        public List<Cliente> Listar()
        {
            List<Cliente> listaClientes = new List<Cliente>();

            using (SqlConnection conn = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    //string query = "select u.id, u.documento, u.nombre_completo, u.correo, u.clave, u.estado, r.id as rolId, r.descripcion as rolDescripcion from Cliente u inner join rol r on r.id = u.rol_id;";
                    StringBuilder sbquery = new StringBuilder();
                    sbquery.AppendLine("select u.id, u.documento, u.nombre_completo, u.correo, u.clave, u.estado,");
                    sbquery.AppendLine("r.id as rolId, r.descripcion as rolDescripcion");
                    sbquery.AppendLine("from Cliente u inner join rol r on r.id = u.rol_id;");

                    SqlCommand scmd = new SqlCommand(sbquery.ToString(), conn);

                    scmd.CommandType = CommandType.Text;

                    conn.Open();

                    using (SqlDataReader dr = scmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            listaClientes.Add(new Cliente()
                            {
                                Id = Convert.ToInt32(dr["ID"]),
                                documento = dr["documento"].ToString(),
                                nombreCompleto = dr["nombre_completo"].ToString(),
                                correo = dr["correo"].ToString(),
                                clave = dr["clave"].ToString(),
                                estado = Convert.ToBoolean(dr["estado"]),
                                oRol = new Rol() { id = Convert.ToInt32(dr["rolId"]), descripcion = dr["rolDescripcion"].ToString() }
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    //Console.WriteLine(ex.Message);
                    listaClientes = new List<Cliente>();
                }

                return listaClientes;
            }
        }


        public int Registrar(Cliente objCliente, out string Mensaje)
        {
            int idClienteGenerado = 0;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection conn = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand sqlCmd = new SqlCommand("P_REGISTRARCliente", conn);
                    sqlCmd.Parameters.AddWithValue("documento", objCliente.documento);
                    sqlCmd.Parameters.AddWithValue("nombreCompleto", objCliente.nombreCompleto);
                    sqlCmd.Parameters.AddWithValue("correo", objCliente.correo);
                    sqlCmd.Parameters.AddWithValue("clave", objCliente.clave);
                    sqlCmd.Parameters.AddWithValue("rolId", objCliente.oRol.id);
                    sqlCmd.Parameters.AddWithValue("estado", objCliente.estado);
                    sqlCmd.Parameters.Add("idClienteResultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    sqlCmd.Parameters.Add("mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    sqlCmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    sqlCmd.ExecuteNonQuery();

                    idClienteGenerado = Convert.ToInt32(sqlCmd.Parameters["idClienteResultado"].Value);
                    Mensaje = sqlCmd.Parameters["mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                idClienteGenerado = 0;
                Mensaje = ex.Message;
            }

            return idClienteGenerado;
        }


        public bool Editar(Cliente objCliente, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection conn = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand sqlCmd = new SqlCommand("P_EDITARCliente", conn);
                    sqlCmd.Parameters.AddWithValue("id", objCliente.Id);
                    sqlCmd.Parameters.AddWithValue("documento", objCliente.documento);
                    sqlCmd.Parameters.AddWithValue("nombreCompleto", objCliente.nombreCompleto);
                    sqlCmd.Parameters.AddWithValue("correo", objCliente.correo);
                    sqlCmd.Parameters.AddWithValue("clave", objCliente.clave);
                    sqlCmd.Parameters.AddWithValue("rolId", objCliente.oRol.id);
                    sqlCmd.Parameters.AddWithValue("estado", objCliente.estado);
                    sqlCmd.Parameters.Add("Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    sqlCmd.Parameters.Add("mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    sqlCmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    sqlCmd.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(sqlCmd.Parameters["Respuesta"].Value);
                    Mensaje = sqlCmd.Parameters["Mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                respuesta = false;
                Mensaje = ex.Message;
            }

            return respuesta;
        }


        public bool Eliminar(Cliente objCliente, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection conn = new SqlConnection(Conexion.cadena))
                {


                    SqlCommand sqlCmd = new SqlCommand("P_ELIMINAR_Cliente", conn);
                    sqlCmd.Parameters.AddWithValue("Id", objCliente.Id);

                    sqlCmd.Parameters.Add("Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    sqlCmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    sqlCmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    sqlCmd.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(sqlCmd.Parameters["Respuesta"].Value);
                    Mensaje = sqlCmd.Parameters["Mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                respuesta = false;
                Mensaje = ex.Message;
            }

            return respuesta;
        }
    }
}
