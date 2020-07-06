using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.Datos;

namespace Proyecto.Negocio.RNLista
{
    public class RNCategoria:Contexto
    {
        dbGimnasioSportLineEntities Esquema = new dbGimnasioSportLineEntities();
        public RNCategoria()
        {
            Esquema = TraerContexto();
        }
        public List<Categoria> TraerCategoria(Int64 idCategoria)
        {
            if (idCategoria == 0)
            {
                return (from e in Esquema.Categoria where e.EstadoCategoria==1 select e).ToList();
            }
            else
            {
                return (from e in Esquema.Categoria where e.IdCategoria==(idCategoria) select e).ToList();
            }
        }
        public List<VCategoria> TraerListaCategoria()
        {
            return (from e in Esquema.VCategoria where e.IdCategoria>0 select e).ToList();
        }
    }
}
