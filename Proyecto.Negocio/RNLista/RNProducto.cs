using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.Datos;

namespace Proyecto.Negocio.RNLista
{
    public class RNProducto:Contexto
    {
        dbGimnasioSportLineEntities Esquema = new dbGimnasioSportLineEntities();
        public RNProducto()
        {
            Esquema = TraerContexto();
        }
        public List<VProducto>TraerListaProducto(Int64 idProducto)
        {

            if (idProducto == 0)
            {
                return (from e in Esquema.VProducto where e.Estado.Equals("Activo") select e).ToList();
            }
            else
            {
                return (from e in Esquema.VProducto where e.IdProducto == (idProducto) select e).ToList();
            }

        }
        public List<VProducto> TraerProductoPorNombre(string Nombre)
        {
            return (from c in Esquema.VProducto where c.NombreProducto.Contains(Nombre) select c).ToList();
        }
        public List<Producto> TraerProductoPorNombreExacto(string Nombre)
        {
            return (from c in Esquema.Producto where c.NombreProducto.Equals(Nombre) select c).ToList();
        }
    }
}
