
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace CapaDatos
{
    public class CD_Usuario
    {
        public List<Usuario> Listar()
        {
            List<Usuario> listaUsuarios = new List<Usuario>();

            using (SqlConnection conn = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    //string query = "select u.id, u.documento, u.nombre_completo, u.correo, u.clave, u.estado, r.id as rolId, r.descripcion as rolDescripcion from usuario u inner join rol r on r.id = u.rol_id;";
                    StringBuilder sbquery = new StringBuilder();
                    sbquery.AppendLine("select u.id, u.documento, u.nombre_completo, u.correo, u.clave, u.estado,");
                    sbquery.AppendLine("r.id as rolId, r.descripcion as rolDescripcion");
                    sbquery.AppendLine("from usuario u inner join rol r on r.id = u.rol_id;");

                    SqlCommand scmd = new SqlCommand(sbquery.ToString(), conn);

                    scmd.CommandType = CommandType.Text;

                    conn.Open();

                    using (SqlDataReader dr = scmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            listaUsuarios.Add(new Usuario()
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
                    listaUsuarios = new List<Usuario>();
                }

                return listaUsuarios;
            }
        }


        public int Registrar(Usuario objUser, out string Mensaje)
        {
            int idUsuarioGenerado = 0;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection conn = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand sqlCmd = new SqlCommand("P_REGISTRARUSUARIO", conn);
                    sqlCmd.Parameters.AddWithValue("documento", objUser.documento);
                    sqlCmd.Parameters.AddWithValue("nombreCompleto", objUser.nombreCompleto);
                    sqlCmd.Parameters.AddWithValue("correo", objUser.correo);
                    sqlCmd.Parameters.AddWithValue("clave", objUser.clave);
                    sqlCmd.Parameters.AddWithValue("rolId", objUser.oRol.id);
                    sqlCmd.Parameters.AddWithValue("estado", objUser.estado);
                    sqlCmd.Parameters.Add("idUsuarioResultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    sqlCmd.Parameters.Add("mensaje", SqlDbType.VarChar,500).Direction = ParameterDirection.Output;
                    sqlCmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    sqlCmd.ExecuteNonQuery();

                    idUsuarioGenerado = Convert.ToInt32(sqlCmd.Parameters["idUsuarioResultado"].Value);
                    Mensaje = sqlCmd.Parameters["mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                idUsuarioGenerado = 0;
                Mensaje = ex.Message;
            }

            return idUsuarioGenerado;
        }


        public bool Editar(Usuario objUser, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection conn = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand sqlCmd = new SqlCommand("P_EDITARUSUARIO", conn);
                    sqlCmd.Parameters.AddWithValue("id", objUser.Id);
                    sqlCmd.Parameters.AddWithValue("documento", objUser.documento);
                    sqlCmd.Parameters.AddWithValue("nombreCompleto", objUser.nombreCompleto);
                    sqlCmd.Parameters.AddWithValue("correo", objUser.correo);
                    sqlCmd.Parameters.AddWithValue("clave", objUser.clave);
                    sqlCmd.Parameters.AddWithValue("rolId", objUser.oRol.id);
                    sqlCmd.Parameters.AddWithValue("estado", objUser.estado);
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


        public bool Eliminar(Usuario objUser, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection conn = new SqlConnection(Conexion.cadena))
                {


                SqlCommand sqlCmd = new SqlCommand("P_ELIMINAR_USUARIO", conn);
                    sqlCmd.Parameters.AddWithValue("Id", objUser.Id);

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
