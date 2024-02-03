using Capa_Entidad;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Reporte
    {
        public List<ReporteCompra> Compra(string fechaInicio, string fechaFin, int idProveedor)
        {
            List<ReporteCompra> listaRC = new List<ReporteCompra>();

            using (SqlConnection sqlconn = new SqlConnection(Conexion.cadena)) {
                try
                {
                    SqlCommand sqlcmd = new SqlCommand("P_ReporteCompras", sqlconn);

                    sqlcmd.Parameters.AddWithValue("fechainicio", fechaInicio);
                    sqlcmd.Parameters.AddWithValue("fechafin", fechaFin);
                    sqlcmd.Parameters.AddWithValue("idproveedor", idProveedor);

                    sqlcmd.CommandType = System.Data.CommandType.StoredProcedure;

                    sqlconn.Open();

                    using (SqlDataReader dr = sqlcmd.ExecuteReader())
                    {
                        while(dr.Read())
                        {
                            listaRC.Add(new ReporteCompra()
                            {
                                FechaRegistro = dr["FechaRegistro"].ToString(),
                                TipoDocumento = dr["TipoDocumento"].ToString(),
                                NumeroDocumento = dr["NumeroDocumento"].ToString(),
                                MontoTotal = dr["MontoTotal"].ToString(),
                                UsuarioRegistro = dr["NombreUsuario"].ToString(),
                                DocumentoProveedor = dr["DocumentoProveedor"].ToString(),
                                RazonSocial = dr["RazonSocial"].ToString(),
                                CodigoProducto = dr["CodigoProducto"].ToString(),
                                NombreProducto = dr["NombreProducto"].ToString(),
                                Categoria = dr["Categoria"].ToString(),
                                PrecioCompra = dr["PrecioCompra"].ToString(),
                                PrecioVenta = dr["PrecioVenta"].ToString(),
                                Cantidad = dr["Cantidad"].ToString(),
                                SubTotal = dr["SubTotal"].ToString(),
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    return new List<ReporteCompra>();
                }
            }
            return listaRC;
        }

        public List<ReporteVenta> Venta(string fechainicio, string fechafin)
        {
            List<ReporteVenta> lista = new List<ReporteVenta>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    //StringBuilder query = new StringBuilder();
                    SqlCommand cmd = new SqlCommand("P_ReporteVentas", oconexion);
                    cmd.Parameters.AddWithValue("fechainicio", fechainicio);
                    cmd.Parameters.AddWithValue("fechafin", fechafin);
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new ReporteVenta()
                            {
                                FechaRegistro = dr["FechaRegistro"].ToString(),
                                TipoDocumento = dr["TipoDocumento"].ToString(),
                                NumeroDocumento = dr["NumeroDocumento"].ToString(),
                                MontoTotal = dr["MontoTotal"].ToString(),
                                UsuarioRegistro = dr["NombreCompleto"].ToString(),
                                DocumentoCliente = dr["DocumentoCliente"].ToString(),
                                NombreCliente = dr["NombreCliente"].ToString(),
                                CodigoProducto = dr["CodigoProducto"].ToString(),
                                NombreProducto = dr["NombreProducto"].ToString(),
                                Categoria = dr["Categoria"].ToString(),
                                PrecioVenta = dr["PrecioVenta"].ToString(),
                                Cantidad = dr["Cantidad"].ToString(),
                                SubTotal = dr["MontoTotal"].ToString(),
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<ReporteVenta>();
                }
            }

            return lista;

        }
    }
}
