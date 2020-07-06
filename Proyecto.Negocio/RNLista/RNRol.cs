using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.Datos;

namespace Proyecto.Negocio.RNLista
{
    public class RNRol:Contexto
    {
        dbGimnasioSportLineEntities Esquema = new dbGimnasioSportLineEntities();
        public RNRol()
        {
            Esquema = TraerContexto();
        }
        public List<Rol> TraerRol(Int64 idRol)
        {
            if (idRol == 0)
            {
                return (from e in Esquema.Rol select e).ToList();
            }
            else
            {
                return (from e in Esquema.Rol where e.IdRol==idRol select e).ToList();
            }
        }
        public List<VRol> TraerListaRol()
        {
            return (from c in Esquema.VRol select c).ToList();
        }
        public List<VUsuarioRolPermisos> TraerRolPermiso(Int64 idUsuario,string nombreRol)
        {
            
            return (from e in Esquema.VUsuarioRolPermisos where e.IdUsuario==(idUsuario) && e.NombreRol == (nombreRol) select e).ToList();
          
        }

    }
}
