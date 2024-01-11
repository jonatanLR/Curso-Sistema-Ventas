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
    public class CD_Categoria
    {
        public List<Categoria> Listar()
        {
            List<Categoria> listaCategorias = new List<Categoria>();

            using (SqlConnection conn = new SqlConnection(Conexion.cadena))
            {
                try
                {
                   
                    StringBuilder sbquery = new StringBuilder();
                    sbquery.AppendLine("select id, descripcion, estado from categoria");

                    SqlCommand scmd = new SqlCommand(sbquery.ToString(), conn);

                    scmd.CommandType = CommandType.Text;

                    conn.Open();

                    using (SqlDataReader dr = scmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            listaCategorias.Add(new Categoria()
                            {
                                Id = Convert.ToInt32(dr["id"]),
                                descripcion = dr["descripcion"].ToString(),                                
                                estado = Convert.ToBoolean(dr["estado"])                                
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    //Console.WriteLine(ex.Message);
                    listaCategorias = new List<Categoria>();
                }

                return listaCategorias;
            }
        }


        public int Registrar(Categoria objCategoria, out string Mensaje)
        {
            int idCategoriaGenerado = 0;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection conn = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand sqlCmd = new SqlCommand("P_REGISTRAR_CATEGORIA", conn);
                    sqlCmd.Parameters.AddWithValue("descripcion", objCategoria.descripcion);                    
                    sqlCmd.Parameters.AddWithValue("estado", objCategoria.estado);
                    sqlCmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    sqlCmd.Parameters.Add("mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    sqlCmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    sqlCmd.ExecuteNonQuery();

                    idCategoriaGenerado = Convert.ToInt32(sqlCmd.Parameters["Resultado"].Value);
                    Mensaje = sqlCmd.Parameters["mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                idCategoriaGenerado = 0;
                Mensaje = ex.Message;
            }

            return idCategoriaGenerado;
        }


        public bool Editar(Categoria objCategoria, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection conn = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand sqlCmd = new SqlCommand("P_EDITAR_CATEGORIA", conn);
                    sqlCmd.Parameters.AddWithValue("id", objCategoria.Id);
                    sqlCmd.Parameters.AddWithValue("descripcion", objCategoria.descripcion);
                    sqlCmd.Parameters.AddWithValue("estado", objCategoria.estado);
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


        public bool Eliminar(Categoria objCategoria, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection conn = new SqlConnection(Conexion.cadena))
                {


                    SqlCommand sqlCmd = new SqlCommand("P_ELIMINAR_CATEGORIA", conn);
                    sqlCmd.Parameters.AddWithValue("Id", objCategoria.Id);

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
    }
}
