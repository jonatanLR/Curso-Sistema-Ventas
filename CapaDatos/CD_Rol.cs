using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Rol
    {
        public List<Rol> Listar()
        {
            List<Rol> listaPermisos = new List<Rol>();

            using (SqlConnection conn = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "select id, descripcion from rol;";

                    SqlCommand scmd = new SqlCommand(query, conn);
                    scmd.CommandType = CommandType.Text;

                    conn.Open();

                    using (SqlDataReader dr = scmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            listaPermisos.Add(new Rol()
                            {
                                id = Convert.ToInt32(dr["id"]),
                                descripcion = dr["descripcion"].ToString(),
                                                               
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    listaPermisos = new List<Rol>();
                }

                return listaPermisos;
            }
        }
    }
}
