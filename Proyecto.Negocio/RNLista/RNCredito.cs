using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.Datos;

namespace Proyecto.Negocio.RNLista
{
    public class RNCredito:Contexto
    {
        dbGimnasioSportLineEntities Esquema;
        public RNCredito()
        {
            Esquema = this.TraerContexto();
        }
        public List<VClienteCreditoGeneral> TraerClienteCreditoPorCedula(Int64 Cedula)
        {
            return (from c in Esquema.VClienteCreditoGeneral where c.CédulaIdentidad == (Cedula) select c).ToList();
        }
        public List<VClienteCreditoGeneral> TraerClienteCreditoPorNombre(string Nombre)
        {
            return (from c in Esquema.VClienteCreditoGeneral where c.NombreCliente.Contains(Nombre) select c).ToList();
        }
        public List<VClienteCreditoGeneral> TraerClienteCreditoPorSolicitud(Int64 idSolicitud)
        {
            return (from c in Esquema.VClienteCreditoGeneral where c.CodVenta == (idSolicitud) select c).ToList();
        }
    }
}
