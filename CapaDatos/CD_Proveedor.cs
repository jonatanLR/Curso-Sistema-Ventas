using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Proveedor
    {
        public List<Proveedor> Listar()
        {
            List<Proveedor> listaProveedores = new List<Proveedor>();

            using (SqlConnection conn = new SqlConnection(Conexion.cadena))
            {
                try
                {                   
                    StringBuilder sbquery = new StringBuilder();
                    sbquery.AppendLine("P_LISTAR_PROVEEDOR");

                    SqlCommand scmd = new SqlCommand(sbquery.ToString(), conn);

                    scmd.CommandType = CommandType.Text;

                    conn.Open();

                    using (SqlDataReader dr = scmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            listaProveedores.Add(new Proveedor()
                            {
                                Id = Convert.ToInt32(dr["Id"]),
                                Documento = dr["Documento"].ToString(),
                                RazonSocial = dr["RazonSocial"].ToString(),
                                Correo = dr["Correo"].ToString(),
                                Telefono = dr["Telefono"].ToString(),
                                Estado = Convert.ToBoolean(dr["Estado"])                                
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    //Console.WriteLine(ex.Message);
                    listaProveedores = new List<Proveedor>();
                }

                return listaProveedores;
            }
        }


        public int Registrar(Proveedor objProveedor, out string Mensaje)
        {
            // variable para guardar el ID del Proveedor generado
            int idProveedorGenerado = 0;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection conn = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand sqlCmd = new SqlCommand("P_REGISTRAR_PROVEEDOR", conn);
                    sqlCmd.Parameters.AddWithValue("Documento", objProveedor.Documento);
                    sqlCmd.Parameters.AddWithValue("RazonSocial", objProveedor.RazonSocial);
                    sqlCmd.Parameters.AddWithValue("Correo", objProveedor.Correo);
                    sqlCmd.Parameters.AddWithValue("Telefono", objProveedor.Telefono);
                    sqlCmd.Parameters.AddWithValue("Estado", objProveedor.Estado);
                    sqlCmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    sqlCmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    sqlCmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    sqlCmd.ExecuteNonQuery();

                    idProveedorGenerado = Convert.ToInt32(sqlCmd.Parameters["Resultado"].Value);
                    Mensaje = sqlCmd.Parameters["Mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                idProveedorGenerado = 0;
                Mensaje = ex.Message;
            }

            return idProveedorGenerado;
        }


        public bool Editar(Proveedor objProveedor, out string Mensaje)
        {
            // "respuesta" para guardar el resultado (1) si se realizo o (0) si fallo
            bool respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection conn = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand sqlCmd = new SqlCommand("P_EDITAR_PROVEEDOR", conn);
                    sqlCmd.Parameters.AddWithValue("Id", objProveedor.Id);
                    sqlCmd.Parameters.AddWithValue("Documento", objProveedor.Documento);
                    sqlCmd.Parameters.AddWithValue("RazonSocial", objProveedor.RazonSocial);
                    sqlCmd.Parameters.AddWithValue("Correo", objProveedor.Correo);
                    sqlCmd.Parameters.AddWithValue("Telefono", objProveedor.Telefono);
                    sqlCmd.Parameters.AddWithValue("Estado", objProveedor.Estado);
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


        public bool Eliminar(Proveedor objProveedor, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection conn = new SqlConnection(Conexion.cadena))
                {


                    SqlCommand sqlCmd = new SqlCommand("P_ELIMINAR_PROVEEDOR", conn);
                    sqlCmd.Parameters.AddWithValue("Id", objProveedor.Id);

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
