using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.Datos;

namespace Proyecto.Negocio.RNLista
{
    public class RNZona : Contexto
    {
        dbGimnasioSportLineEntities Esquema;

        public RNZona()
        {
            Esquema = this.TraerContexto();
        }
        public List<Zona> TraerZona(Int64 idZona)
        {
            if (idZona == 0)
            {
                return (from e in Esquema.Zona select e).ToList();
            }
            else
            {
                return (from e in Esquema.Zona where e.IdZona.Equals(idZona) select e).ToList();
            }
        }
        public List<Zona> TraerZonaPorCiudad(Int64 idCiudad)
        {
            
            return (from e in Esquema.Zona where e.IdCiudad==(idCiudad) select e).ToList();
            
        }
    }
}