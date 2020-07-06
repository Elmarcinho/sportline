using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.Datos;

namespace Proyecto.Negocio.RNLista
{
    public class RNUsuario:Contexto
    {
        dbGimnasioSportLineEntities Esquema;


        public RNUsuario()
        {
            Esquema = this.TraerContexto();
        }
        public List<VUsuario> TraerUsuario()
        {
            return (from c in Esquema.VUsuario select c).ToList();
        }
        public List<VUsuarioActivo> TraerUsuarioActivo()
        {
            return (from c in Esquema.VUsuarioActivo select c).ToList();
        }
        public List<VUsuarioRolPermisos> TraerUsuarioRol()
        {
            return (from c in Esquema.VUsuarioRolPermisos select c).ToList();
        }
    }
}
