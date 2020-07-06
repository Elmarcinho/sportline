using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.Datos;


namespace Proyecto.Negocio.RNLista
{
    public class RNServicio:Contexto
    {
        dbGimnasioSportLineEntities Esquema = new dbGimnasioSportLineEntities();
        public RNServicio()
        {
            Esquema = TraerContexto();
        }
        public List<VServicioActivo> TraerListaServicio(Int64 idServicio)
        {

            if (idServicio == 0)
            {
                return (from e in Esquema.VServicioActivo select e).ToList();
            }
            else
            {
                return (from e in Esquema.VServicioActivo where e.IdServicio == (idServicio) select e).ToList();
            }

        }
        public List<Servicio> TraerServicioPorNombreExacto(string Nombre)
        {
            return (from c in Esquema.Servicio where c.NombreServicio.Equals(Nombre) select c).ToList();
        }
        public List<VClienteSolicitudServicioPlanes> TraerClientePagoPorCedula(Int64 Cedula)
        {
            return (from c in Esquema.VClienteSolicitudServicioPlanes where c.CédulaIdentidad == (Cedula) select c).ToList();
        }
        public List<VClienteServicio> TraerClienteServicio(Int64 idSolicitud)
        {
            return (from c in Esquema.VClienteServicio where c.IdSolicitud==(idSolicitud) select c).ToList();
        }
        public List<VClienteServicio> TraerClienteServicioPorCedula(Int64 Cedula, Int64 idServicio, Int64 idPlazo)
        {
            return (from c in Esquema.VClienteServicio where c.IdPlazo==idPlazo && c.CédulaIdentidad == (Cedula) && c.IdServicio==idServicio select c).ToList();
        }
    }
}
