using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Datos
{
    public class Contexto
    {
        public dbGimnasioSportLineEntities TraerContexto()
        {
            dbGimnasioSportLineEntities con = new dbGimnasioSportLineEntities();
            return con;      
        }
    }
}
