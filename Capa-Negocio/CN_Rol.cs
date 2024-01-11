using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class CN_Rol
    {
        private CD_Rol obj_cdRol = new CD_Rol();

        public List<Rol> Listar()
        {
            return obj_cdRol.Listar();
        }
    }
}
