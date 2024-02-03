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
                    sbquery.AppendLine("P_LISTAR_CLIENTE");                    

                    SqlCommand scmd = new SqlCommand(sbquery.ToString(), conn);

                    scmd.CommandType = CommandType.Text;

                    conn.Open();

                    using (SqlDataReader dr = scmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            listaClientes.Add(new Cliente()
                            {
                                Id = Convert.ToInt32(dr["Id"]),
                                Documento = dr["Documento"].ToString(),
                                NombreCompleto = dr["Nombre"].ToString(),
                                Correo = dr["Correo"].ToString(),
                                Telefono = dr["Telefono"].ToString(),
                                Estado = Convert.ToBoolean(dr["Estado"]),
                                //oRol = new Rol() { id = Convert.ToInt32(dr["rolId"]), descripcion = dr["rolDescripcion"].ToString() }
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
            // variable para guardar el ID del cliente generado
            int idClienteGenerado = 0;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection conn = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand sqlCmd = new SqlCommand("P_REGISTRAR_CLIENTE", conn);
                    sqlCmd.Parameters.AddWithValue("Documento", objCliente.Documento);
                    sqlCmd.Parameters.AddWithValue("NombreC", objCliente.NombreCompleto);
                    sqlCmd.Parameters.AddWithValue("Correo", objCliente.Correo);
                    sqlCmd.Parameters.AddWithValue("Telefono", objCliente.Telefono);
                    sqlCmd.Parameters.AddWithValue("Estado", objCliente.Estado);
                    sqlCmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    sqlCmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    sqlCmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    sqlCmd.ExecuteNonQuery();

                    idClienteGenerado = Convert.ToInt32(sqlCmd.Parameters["Resultado"].Value);
                    Mensaje = sqlCmd.Parameters["Mensaje"].Value.ToString();
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
            // "respuesta" para guardar el resultado (1) si se realizo o (0) si fallo
            bool respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection conn = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand sqlCmd = new SqlCommand("P_EDITAR_CLIENTE", conn);
                    sqlCmd.Parameters.AddWithValue("Id", objCliente.Id);
                    sqlCmd.Parameters.AddWithValue("Documento", objCliente.Documento);
                    sqlCmd.Parameters.AddWithValue("NombreCompleto", objCliente.NombreCompleto);
                    sqlCmd.Parameters.AddWithValue("Correo", objCliente.Correo);
                    sqlCmd.Parameters.AddWithValue("Telefono", objCliente.Telefono);
                    //sqlCmd.Parameters.AddWithValue("rolId", objCliente.oRol.id);
                    sqlCmd.Parameters.AddWithValue("Estado", objCliente.Estado);
                    sqlCmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    sqlCmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    sqlCmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    sqlCmd.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(sqlCmd.Parameters["Resultado"].Value);
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


                    SqlCommand sqlCmd = new SqlCommand("P_ELIMINAR_CLIENTE", conn);
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
