using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.Datos;

namespace Proyecto.Negocio.RNLista
{
    public class RNPago:Contexto
    {
        dbGimnasioSportLineEntities Esquema;

        public RNPago()
        {
            Esquema = this.TraerContexto();
        }
        public List<VClientePagoServicio> TraerClientePago(Int64 IdSolicitud)
        {
            return (from c in Esquema.VClientePagoServicio where c.IdSolicitud == (IdSolicitud) select c).ToList();
        }
    }
}
