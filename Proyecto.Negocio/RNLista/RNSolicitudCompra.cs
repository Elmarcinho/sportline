using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.Datos;

namespace Proyecto.Negocio.RNLista
{
    public class RNSolicitudCompra:Contexto
    {
        dbGimnasioSportLineEntities Esquema;
        public RNSolicitudCompra()
        {
            Esquema = TraerContexto();
        }
        public long IdSolicitudCompra { set; get; }
        public DateTime FechaCompra { set; get; }
        public long IdUsuario { set; get; }
       
    }
}
