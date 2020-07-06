using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.Datos;

namespace Proyecto.Negocio.RNLista
{
    public class RNSucursal:Contexto
    {
        dbGimnasioSportLineEntities Esquema = new dbGimnasioSportLineEntities();
        public RNSucursal()
        {
            Esquema = TraerContexto();
        }
        public List<Sucursal> TraerSucursal(Int64 idSucursal)
        {
            if (idSucursal == 0)
            {
                return (from e in Esquema.Sucursal select e).ToList();
            }
            else
            {
                return (from e in Esquema.Sucursal where e.IdSucursal.Equals(idSucursal) select e).ToList();
            }
        }

    }
}
