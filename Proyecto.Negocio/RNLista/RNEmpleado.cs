using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.Datos;

namespace Proyecto.Negocio.RNLista
{
    public class RNEmpleado:Contexto
    {
        dbGimnasioSportLineEntities Esquema;

        public RNEmpleado()
        {
            Esquema = this.TraerContexto();
        }
        public List<VEmpleados> TraerEmpleado(Int64 id)
        {
           
            if (id == 0)
            {
                return (from c in Esquema.VEmpleados select c).ToList();
            }
            else
            {
                return (from e in Esquema.VEmpleados where e.CédulaIdentidad==(id) select e).ToList();
            }
        }
        public List<VEmpleadosActivoSinUser> TraerEmpleadoSinUser()
        {
            return (from c in Esquema.VEmpleadosActivoSinUser select c).ToList();
        }
        public List<VEmpleados> TraerEmpleadoActivoPorCedula(Int64 Cedula)
        {
            return (from c in Esquema.VEmpleados where c.CédulaIdentidad == (Cedula) select c).ToList();
        }
        public List<VEmpleados> TraerEmpleadoActivoPorNombre(string Nombre)
        {
            return (from c in Esquema.VEmpleados where c.NombreEmpleado.Contains(Nombre) select c).ToList();
        }
    }
}
