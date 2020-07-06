using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.Datos;

namespace Proyecto.Negocio.RNLista
{
    public class RNDescuento:Contexto
    {
        dbGimnasioSportLineEntities Esquema;

        public RNDescuento()
        {
            Esquema = this.TraerContexto();
        }
        public List<Descuento> TraerDescuento(Int64 idDescuento)
        {
            if (idDescuento == 0)
            {
                return (from e in Esquema.Descuento where e.EstadoDescuento==1 select e).ToList();
            }
            else
            {
                return (from e in Esquema.Descuento where e.IdDescuento==(idDescuento) select e).ToList();
            }
        }
        public List<VDescuento> TraerListaDescuento()
        {
            return (from e in Esquema.VDescuento where e.IdDescuento > 0 select e).ToList();
        }
    }
}
