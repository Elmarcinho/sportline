using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.Datos;

namespace Proyecto.Negocio.RNLista
{
    public class RNPrecio:Contexto
    {
        dbGimnasioSportLineEntities Esquema = new dbGimnasioSportLineEntities();
        public RNPrecio()
        {
            Esquema = TraerContexto();
        }
        public List<Precio> TraerPrecio(Int64 idServicio)
        {
            return (from e in Esquema.Precio where e.IdServicio == idServicio && e.EstadoPrecio==1 select e).ToList();
        }
    }
}
