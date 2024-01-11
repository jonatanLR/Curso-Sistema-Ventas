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
    public class CD_Producto
    {
        public List<Producto> Listar()
        {
            List<Producto> listaProductos = new List<Producto>();

            using (SqlConnection conn = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    //string query = "select u.id, u.documento, u.nombre_completo, u.correo, u.clave, u.estado, r.id as rolId, r.descripcion as rolDescripcion from Producto u inner join rol r on r.id = u.rol_id;";
                    StringBuilder sbquery = new StringBuilder();
                    sbquery.AppendLine("select p.id, p.codigo, p.nombre, p.descripcion, c.id[categoria_id],");
                    sbquery.AppendLine("c.descripcion[descrip_cat], p.stock, p.precio_compra, p.precio_venta, p.estado as 'estado_producto'");
                    sbquery.AppendLine("from PRODUCTO p inner join CATEGORIA c on p.CATEGORIA_id = c.id;");

                    SqlCommand scmd = new SqlCommand(sbquery.ToString(), conn);

                    scmd.CommandType = CommandType.Text;

                    conn.Open();

                    using (SqlDataReader dr = scmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            listaProductos.Add(new Producto()
                            {
                                Id = Convert.ToInt32(dr["id"]),
                                codigo = dr["codigo"].ToString(),
                                nombre = dr["nombre"].ToString(),
                                descripcion = dr["descripcion"].ToString(),
                                oCategoria= new Categoria() { Id = Convert.ToInt32(dr["categoria_id"]), descripcion = dr["descrip_cat"].ToString() },
                                stock = Convert.ToInt32(dr["stock"]),
                                precioCompra = Convert.ToDecimal(dr["precio_compra"]),
                                precioVenta = Convert.ToDecimal(dr["precio_venta"]),
                                estado = Convert.ToBoolean(dr["estado_producto"]),                                
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    //Console.WriteLine(ex.Message);
                    listaProductos = new List<Producto>();
                }

                return listaProductos;
            }
        }


        public int Registrar(Producto objProducto, out string Mensaje)
        {
            int idProductoGenerado = 0;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection conn = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand sqlCmd = new SqlCommand("P_REGISTRAR_Producto", conn);
                    sqlCmd.Parameters.AddWithValue("codigo", objProducto.codigo);
                    sqlCmd.Parameters.AddWithValue("nombre", objProducto.nombre);
                    sqlCmd.Parameters.AddWithValue("descripcion", objProducto.descripcion);
                    //sqlCmd.Parameters.AddWithValue("stock", objProducto.stock);
                    //sqlCmd.Parameters.AddWithValue("precio_compra", objProducto.precioCompra);
                    //sqlCmd.Parameters.AddWithValue("precio_venta", objProducto.precioVenta);
                    sqlCmd.Parameters.AddWithValue("estado", objProducto.estado);
                    sqlCmd.Parameters.AddWithValue("CategoriaId", objProducto.oCategoria.Id);
                    
                    sqlCmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    sqlCmd.Parameters.Add("mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    sqlCmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    sqlCmd.ExecuteNonQuery();

                    idProductoGenerado = Convert.ToInt32(sqlCmd.Parameters["Resultado"].Value);
                    Mensaje = sqlCmd.Parameters["mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                idProductoGenerado = 0;
                Mensaje = ex.Message;
            }

            return idProductoGenerado;
        }


        public bool Editar(Producto objProducto, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection conn = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand sqlCmd = new SqlCommand("P_MODIFICAR_PRODUCTO", conn);
                    sqlCmd.Parameters.AddWithValue("Id", objProducto.Id);
                    sqlCmd.Parameters.AddWithValue("Codigo", objProducto.codigo);
                    sqlCmd.Parameters.AddWithValue("Nombre", objProducto.nombre);
                    sqlCmd.Parameters.AddWithValue("Descripcion", objProducto.descripcion);
                    sqlCmd.Parameters.AddWithValue("CategoriaId", objProducto.oCategoria.Id);
                    sqlCmd.Parameters.AddWithValue("Estado", objProducto.estado);
                    sqlCmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    sqlCmd.Parameters.Add("mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
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


        public bool Eliminar(Producto objProducto, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection conn = new SqlConnection(Conexion.cadena))
                {


                    SqlCommand sqlCmd = new SqlCommand("P_ELIMINAR_PRODUCTO", conn);
                    sqlCmd.Parameters.AddWithValue("Id", objProducto.Id);

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
