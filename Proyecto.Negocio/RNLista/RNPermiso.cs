using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.Datos;

namespace Proyecto.Negocio.RNLista
{
    public class RNPermiso:Contexto
    {
        dbGimnasioSportLineEntities Esquema = new dbGimnasioSportLineEntities();
        public RNPermiso()
        {
            Esquema = TraerContexto();
        }
        public List<VPermiso> TraerListaPermiso(Int64 idPermiso)
        {
            if (idPermiso == 0)
            {
                return (from c in Esquema.VPermiso select c).ToList();
            }
            else
            {
                return (from c in Esquema.VPermiso where c.IdPermiso==idPermiso select c).ToList();
            }
        }
        public List<VRolPermiso> TraerListaRolPermiso(Int64 idRol)
        {
            if (idRol == 0)
            {
                return (from e in Esquema.VRolPermiso select e).ToList();
            }
            else
            {
                return (from e in Esquema.VRolPermiso where e.IdRol == idRol select e).ToList();
            }
        }
    }
}
