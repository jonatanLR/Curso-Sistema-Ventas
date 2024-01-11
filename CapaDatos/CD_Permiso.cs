using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;

namespace CapaDatos
{
    public class CD_Permiso
    {
        public List<Permiso> Listar(int idUsuario)
        {
            List<Permiso> listaPermisos = new List<Permiso>();

            using (SqlConnection conn = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select p.nombre_menu, p.ROL_id from PERMISO p");
                    query.AppendLine("inner join ROL r on p.ROL_id = r.id");
                    query.AppendLine("inner join USUARIO u on r.id = u.ROL_id");
                    query.AppendLine("where u.id=@id");
                    SqlCommand scmd = new SqlCommand(query.ToString(), conn);

                    //string query = "select p.nombre_menu, p.ROL_id from PERMISO p inner join ROL r on p.ROL_id = r.id inner join USUARIO u on r.id = u.ROL_id where u.id=@id;";
                    //SqlCommand scmd = new SqlCommand(query, conn);

                    scmd.Parameters.AddWithValue("id", idUsuario);
                    scmd.CommandType = CommandType.Text;

                    conn.Open();

                    using (SqlDataReader dr = scmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            listaPermisos.Add(new Permiso()
                            {
                                nombreMenu = dr["nombre_menu"].ToString(),
                                oRol = new Rol() { id = Convert.ToInt32(dr["Rol_id"]) }
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    listaPermisos = new List<Permiso>();
                }

                return listaPermisos;
            }
        }
    }
}
