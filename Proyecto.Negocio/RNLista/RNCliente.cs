using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.Datos;

namespace Proyecto.Negocio.RNLista
{
    public class RNCliente:Contexto
    {
        dbGimnasioSportLineEntities Esquema;

        public RNCliente()
        {
            Esquema = this.TraerContexto();
        }
        public List<VClientes> TraerCliente()
        {
            return (from c in Esquema.VClientes select c).ToList();
        }
        public List<VClienteGeneral> TraerClienteGeneral()
        {
            return (from c in Esquema.VClienteGeneral select c).ToList();
        }
        public List<VClienteGeneral> TraerClienteGeneralPorCedula(Int64 Cedula)
        {
            return (from c in Esquema.VClienteGeneral where c.CédulaIdentidad==(Cedula) select c).ToList();
        }
        public List<VClienteGeneral> TraerClienteGeneralPorNombre(string Nombre)
        {
            return (from c in Esquema.VClienteGeneral where c.NombreCliente.Contains(Nombre) select c).ToList();
        }
        public List<VClientes> TraerClienteActivoPorCedula(Int64 Cedula)
        {
            return (from c in Esquema.VClientes where c.CédulaIdentidad == (Cedula) select c).ToList();
        }
        public List<VClientes> TraerClienteActivoPorNombre(string Nombre)
        {
            return (from c in Esquema.VClientes where c.NombreCliente.Contains(Nombre) select c).ToList();
        }
    }
}
