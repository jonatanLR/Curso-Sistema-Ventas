using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace Capa_Negocio
{
    public class CN_Permiso
    {
        private CD_Permiso obj_cdPermiso = new CD_Permiso();

        public List<Permiso> Listar(int idUsuario)
        {
            return obj_cdPermiso.Listar(idUsuario);
        }
    }
}
