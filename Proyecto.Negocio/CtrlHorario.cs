using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.Datos;
using System.Transactions;

namespace Proyecto.Negocio
{
    public class CtrlHorario:Contexto
    {
        dbGimnasioSportLineEntities Esquema;
        public CtrlHorario()
        {
            Esquema = TraerContexto();
        }
        public long GenerarID()
        {
            try
            {
                return (from e in Esquema.Horario select e.IdHorario).Max() + 1;
            }
            catch (Exception)
            {
                return 1;
            }
        }
        public Boolean InsertarHorario(Horario objHorario)
        {
            using (TransactionScope Transaccion = new TransactionScope())
            {
                try
                {
                    Esquema.Horario.Add(objHorario);
                    if (Esquema.SaveChanges() == 1)
                    {
                        Transaccion.Complete();
                        return true;
                    }
                    else
                    {
                        Transaccion.Dispose();
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }
    }
}
