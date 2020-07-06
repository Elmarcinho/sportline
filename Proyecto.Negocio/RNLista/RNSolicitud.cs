using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.Datos;

namespace Proyecto.Negocio.RNLista
{
    public class RNSolicitud:Contexto
    {
        dbGimnasioSportLineEntities Esquema;
        public RNSolicitud()
        {
            Esquema = TraerContexto();
        }
        public long IdSolicitud { set; get; }
        public DateTime FechaSolicitud { set; get; }
        public Nullable< DateTime> FechaIngreso { set; get; }
        public Nullable<DateTime> FechaCulminacion { set; get; }
        public int EstadoSolicitud { set; get; }
        public int IdTipoPago { set; get; }
        public long IdCliente { set; get; }
        public Nullable<long> IdEmpleado { set; get; }
        public long IdTipoSolicitud { set; get; }
        public Nullable<long> IdPlazo { set; get; }
        public Nullable<long> IdDescuento { get; set; }
        public long IdUsuario { set; get; }

        public List<VClienteSolicitudGeneral> TraerSolicitudCliente()
        {
            return (from c in Esquema.VClienteSolicitudGeneral /*orderby c.CodVenta descending*/ select c).ToList();
        }
        public List<VClienteSolicitudGeneral> TraerSolicitudClientePorCedula(Int64 Cedula)
        {
            return (from c in Esquema.VClienteSolicitudGeneral where c.CédulaIdentidad == Cedula orderby c.CodVenta descending select c).ToList();
        }
        public List<VClienteSolicitudGeneral> TraerSolicitudClientePorFecha(DateTime FechaSolicitud)
        {
            return (from c in Esquema.VClienteSolicitudGeneral where  c.FechaSolicitud == FechaSolicitud orderby c.CodVenta descending select c).ToList();
        }
        public List<VDetalleSolicitudProducto> TraerDetalleSolicitudCliente(Int64 idSolicitud)
        {
            if(idSolicitud == 0)
            {
                return (from e in Esquema.VDetalleSolicitudProducto select e).ToList();
            }
            else
            {
                return (from e in Esquema.VDetalleSolicitudProducto where e.IdSolicitud==idSolicitud select e).ToList();
            }
        }
        public List<VSolicitudGeneralAño> TraerAñoVenta(Int64 idAño)
        {
            if (idAño == 0)
            {
                return (from e in Esquema.VSolicitudGeneralAño select e).ToList();
            }
            else
            {
                return (from e in Esquema.VSolicitudGeneralAño select e).ToList();
            }
        }
        public List<VSolicitudGeneralMes> TraerMesVenta(Int64 idAño)
        {
            if (idAño == 0)
            {
                return (from e in Esquema.VSolicitudGeneralMes select e).ToList();
            }
            else
            {
                return (from e in Esquema.VSolicitudGeneralMes where e.AñoSolicitud==idAño select e).ToList();
            }
        }
    }
}
