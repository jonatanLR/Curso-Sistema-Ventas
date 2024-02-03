using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace CapaDatos
{
    public class CD_Venta
    {
        public int ObtenerCorrelativo()
        {
            int idCorrelativo = 0;

            using (SqlConnection conn = new SqlConnection(Conexion.cadena))
            {
                try
                {

                    StringBuilder sbquery = new StringBuilder();
                    sbquery.AppendLine("select COUNT(*) + 1 from VENTA");

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

        /// <summary>
        /// Actualizar (restar o disminuir) el stock al agreagar una venta de un producto al DGV
        /// </summary>
        /// <param name="idproducto"></param>
        /// <param name="cantidad"></param>
        /// <returns>Bool true si ejecuto la consila o false sino se registro la consulta</returns>
        public bool RestarStock(int idproducto, int cantidad)
        {
            bool respuesta = true;

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("update producto set stock = stock - @cantidad where id = @idproducto");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.Parameters.AddWithValue("@cantidad", cantidad);
                    cmd.Parameters.AddWithValue("@idproducto", idproducto);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();

                    respuesta = cmd.ExecuteNonQuery() > 0 ? true : false;
                }
                catch (Exception ex)
                {
                    respuesta = false;
                }
            }
            return respuesta;

        }

        /// <summary>
        /// Actualizar(sumar o agragar) el stock al agreagar una venta de un producto al DGV
        /// </summary>
        /// <param name="idproducto"></param>
        /// <param name="cantidad"></param>
        /// <returns>Bool true si ejecuto la consila o false sino se registro la consulta</returns>
        public bool SumarStock(int idproducto, int cantidad)
        {
            bool respuesta = true;

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("update producto set stock = stock + @cantidad where id = @idproducto");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.Parameters.AddWithValue("@cantidad", cantidad);
                    cmd.Parameters.AddWithValue("@idproducto", idproducto);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();

                    respuesta = cmd.ExecuteNonQuery() > 0 ? true : false;
                }
                catch (Exception ex)
                {
                    respuesta = false;
                }
            }
            return respuesta;

        }

        public bool Registrar(Venta obj, DataTable DetalleVenta, out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje = string.Empty;
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("P_RegistrarVenta", oconexion);
                    cmd.Parameters.AddWithValue("IdUsuario", obj.oUsuario.Id);
                    cmd.Parameters.AddWithValue("TipoDocumento", obj.tipoDocumento);
                    cmd.Parameters.AddWithValue("NumeroDocumento", obj.numeroDocumento);
                    cmd.Parameters.AddWithValue("IdCliente", obj.oCliente.Id);
                    //cmd.Parameters.AddWithValue("NombreCliente", obj.NombreCliente);
                    cmd.Parameters.AddWithValue("MontoPago", obj.montoPago);
                    cmd.Parameters.AddWithValue("MontoCambio", obj.montoCambio);
                    cmd.Parameters.AddWithValue("MontoTotal", obj.montoTotal);
                    cmd.Parameters.AddWithValue("DetalleVenta", DetalleVenta);
                    cmd.Parameters.Add("Resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();
                    cmd.ExecuteNonQuery();

                    Respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }

            }
            catch (Exception ex)
            {
                Respuesta = false;
                Mensaje = ex.Message;
            }

            return Respuesta;
        }


        public Venta ObtenerVenta(string numero)
        {
            
            Venta objVenta = new Venta();

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                string Mensaje = string.Empty;
                try
                {
                    conexion.Open();
                    //StringBuilder query = new StringBuilder();

                    //query.AppendLine("P_OBTENER_VENTA");

                    SqlCommand cmd = new SqlCommand("P_OBTENER_VENTA", conexion);
                    cmd.Parameters.AddWithValue("numero", numero);
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 200).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {

                        while (dr.Read())
                        {
                            objVenta = new Venta()
                            {
                                Id = int.Parse(dr["IdVenta"].ToString()),
                                oUsuario = new Usuario() { nombreCompleto = dr["NombreCompleto"].ToString() },
                                oCliente = new Cliente() { Documento = dr["DocumentoCliente"].ToString(), NombreCompleto = dr["NombreCliente"].ToString() },
                                //NombreCliente = dr["NombreCliente"].ToString(),
                                tipoDocumento = dr["TipoDocumento"].ToString(),
                                numeroDocumento = dr["NumeroDocumento"].ToString(),
                                montoPago = Convert.ToDecimal(dr["MontoPago"].ToString()),
                                montoCambio = Convert.ToDecimal(dr["MontoCambio"].ToString()),
                                montoTotal = Convert.ToDecimal(dr["MontoTotal"].ToString()),
                                fechaRegistro = dr["FechaRegistro"].ToString()
                            };
                        }

                        //Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                    }
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();

                }
                catch(Exception ex) 
                {
                    objVenta = new Venta();
                    Mensaje = ex.Message;
                }

            }
            return objVenta;

        }


        public List<Detalle_Venta> ObtenerDetalleVenta(int idVenta)
        {
            
            List<Detalle_Venta> oLista = new List<Detalle_Venta>();

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                string Mensaje = string.Empty;
                try
                {
                    conexion.Open();
                    //String query = "P_OBTENER_DETALLE_VENTA";

                    SqlCommand cmd = new SqlCommand("P_OBTENER_DETALLE_VENTA", conexion);
                    cmd.Parameters.AddWithValue("idventa", idVenta);
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 200).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;


                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            oLista.Add(new Detalle_Venta()
                            {
                                oProducto = new Producto() { nombre = dr["Nombre"].ToString() },
                                precioVenta = Convert.ToDecimal(dr["PrecioVenta"].ToString()),
                                Cantidad = Convert.ToInt32(dr["Cantidad"].ToString()),
                                subTotal = Convert.ToDecimal(dr["SubTotal"].ToString()),
                            });
                        }                        
                    }
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
                catch(Exception ex)
                {
                    oLista = new List<Detalle_Venta>();
                    Mensaje = ex.Message;
                }
            }
            return oLista;
        }

    }
}
