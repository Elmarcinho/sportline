using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.Datos;

namespace Proyecto.Negocio.RNLista
{
    public class RNAsistencia:Contexto
    {
        dbGimnasioSportLineEntities Esquema = new dbGimnasioSportLineEntities();
        public RNAsistencia()
        {
            Esquema = TraerContexto();
        }
       
        public List<VClienteAsistencia> TraerClienteAsistenciaPorCedula(Int64 Cedula)
        {
            return (from c in Esquema.VClienteAsistencia where c.CédulaIdentidad == Cedula && c.Valor==0 select c).ToList();
        }
        public List<VClienteAsistencia> TraerClienteAsistenciaPorCedulaVencido(Int64 Cedula)
        {
            return (from c in Esquema.VClienteAsistencia where c.CédulaIdentidad == Cedula && c.Valor == 1 orderby c.FechaAsistencia descending select c).ToList();
        }
        public List<VClienteAsistencia> TraerClienteAsistenciaPorNombre(string Nombre,DateTime Inicio,DateTime Fin)
        {
            return (from c in Esquema.VClienteAsistencia where c.NombreCliente.Contains(Nombre) && c.Valor == 1 && (((c.FechaAsistencia > Inicio) && c.FechaAsistencia < Fin)) orderby c.FechaAsistencia descending select c).ToList();
        }
        public List<VClienteAsistencia> TraerClienteAsistenciaRangoFecha(DateTime Inicio,DateTime Fin)
        {
            return (from c in Esquema.VClienteAsistencia where c.Valor==1 && ((c.FechaAsistencia > Inicio) && (c.FechaAsistencia < Fin)) orderby c.FechaAsistencia descending select c).ToList();
        }
    }
}
