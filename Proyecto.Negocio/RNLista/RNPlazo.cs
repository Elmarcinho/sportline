using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.Datos;

namespace Proyecto.Negocio.RNLista
{
    public class RNPlazo:Contexto
    {
        dbGimnasioSportLineEntities Esquema;

        public RNPlazo()
        {
            Esquema = this.TraerContexto();
        }
        public List<Plazo> TraerPlazo(Int64 idPlazo)
        {
            if (idPlazo == 0)
            {
                return (from e in Esquema.Plazo select e).ToList();
            }
            else
            {
                return (from e in Esquema.Plazo where e.IdPlazo==(idPlazo) select e).ToList();
            }
        }
    }
}
