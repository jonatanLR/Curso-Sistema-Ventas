using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace CapaDatos
{
    public class CD_Compra
    {
        public int ObtenerCorrelativo()
        {
            int idCorrelativo = 0;

            using (SqlConnection conn = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    
                    StringBuilder sbquery = new StringBuilder();
                    sbquery.AppendLine("select COUNT(*) + 1 from COMPRA");

                    SqlCommand scmd = new SqlCommand(sbquery.ToString(), conn);

                    scmd.CommandType = CommandType.Text;

                    conn.Open();

                    idCorrelativo = Convert.ToInt32(scmd.ExecuteScalar());
                    
                }
                catch (Exception ex)
                {
                    //Console.WriteLine(ex.Message);
                    idCorrelativo = 0;
                }                
            }

            return idCorrelativo;
        }

        // url: https://youtu.be/tAlfEMuU9Ek?list=PLx2nia7-PgoDk8pZ1YG8wtw5A8LH2kz96&t=444
        public bool Registrar(Compra objCompra, DataTable dtDetalleCompra, out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje = string.Empty;

            using (SqlConnection conn = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand scmd = new SqlCommand("P_RegistrarCompra", conn);
                    scmd.Parameters.AddWithValue("IdUsuario",objCompra.oUsuario.Id);
                    scmd.Parameters.AddWithValue("IdProveedor",objCompra.oProveedor.Id);
                    scmd.Parameters.AddWithValue("TipoDocumento",objCompra.tipoDocumento);
                    scmd.Parameters.AddWithValue("NumeroDocumento",objCompra.numeroDocumento);
                    scmd.Parameters.AddWithValue("MontoTotal",objCompra.montoTotal);
                    scmd.Parameters.AddWithValue("DetalleCompra",dtDetalleCompra);
                    scmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    scmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    scmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();

                    scmd.ExecuteNonQuery();

                    Respuesta = Convert.ToBoolean(scmd.Parameters["Resultado"].Value);
                    Mensaje = scmd.Parameters["Mensaje"].Value.ToString();

                }
                catch (Exception ex)
                {
                    Respuesta = false;
                    Mensaje = ex.Message;
                }                
            }

            return Respuesta;
        }

        public Compra ObtenerCompra(string numero)
        {
            Compra objCompra = new Compra();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {

                    //StringBuilder query = new StringBuilder();
                    //query.AppendLine("OBTENER_COMPRA");
                    SqlCommand cmd = new SqlCommand("P_OBTENER_COMPRA", oconexion);
                    //SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.Parameters.AddWithValue("numero", numero);
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 200).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            objCompra = new Compra()
                            {
                                Id = Convert.ToInt32(dr["IdCompra"]),
                                oUsuario = new Usuario() { nombreCompleto = dr["NombreCompleto"].ToString() },
                                oProveedor = new Proveedor() { Documento = dr["Documento"].ToString(), 
                                                               RazonSocial = dr["RazonSocial"].ToString() 
                                                             },
                                tipoDocumento = dr["TipoDocumento"].ToString(),
                                numeroDocumento = dr["NumeroDocumento"].ToString(),
                                montoTotal = Convert.ToDecimal(dr["MontoTotal"].ToString()),
                                fechaRegistro = dr["FechaRegistro"].ToString()
                            };
                        }

                    }


                }
                catch (Exception ex)
                {
                    objCompra = new Compra();
                }
            }
            return objCompra;
        }


        public List<Detalle_Compra> ObtenerDetalleCompra(int idcompra)
        {
            List<Detalle_Compra> oLista = new List<Detalle_Compra>();
            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    conexion.Open();
                    //StringBuilder query = new StringBuilder();

                    //query.AppendLine("OBTENER_DETALLE_COMPRA");
                    
                    SqlCommand cmd = new SqlCommand("P_OBTENER_DETALLE_COMPRA", conexion);
                    cmd.Parameters.AddWithValue("IdCompra", idcompra);
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 200).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            oLista.Add(new Detalle_Compra()
                            {
                                oProducto = new Producto() { nombre = dr["Nombre"].ToString() },
                                precioCompra = Convert.ToDecimal(dr["PrecioCompra"].ToString()),
                                Cantidad = Convert.ToInt32(dr["Cantidad"].ToString()),
                                montoTotal = Convert.ToDecimal(dr["MontoTotal"].ToString()),
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                oLista = new List<Detalle_Compra>();
            }
            return oLista;
        }
    }
}
