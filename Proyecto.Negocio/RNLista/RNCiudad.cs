using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.Datos;

namespace Proyecto.Negocio.RNLista
{
    public class RNCiudad : Contexto
    {
        dbGimnasioSportLineEntities Esquema;

        public RNCiudad()
        {
            Esquema = this.TraerContexto();
        }
        public List<Ciudad> TraerCiudad(Int64 idCiudad)
        {
            if (idCiudad == 0)
            {
                return (from e in Esquema.Ciudad select e).ToList();
            }
            else
            {
                return (from e in Esquema.Ciudad where e.IdCiudad.Equals(idCiudad) select e).ToList();
            }
        }
    }
}