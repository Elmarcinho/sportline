using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.Datos;
using System.Transactions;

namespace Proyecto.Negocio
{
    public class CtrlCredito:Contexto
    {
        dbGimnasioSportLineEntities Esquema;

        public CtrlCredito()
        {
            Esquema = TraerContexto();
        }
        public Int64 GenerarID()
        {
            try
            {
                return (from e in Esquema.Credito select e.IdCredito).Max() + 1;
            }
            catch (Exception)
            {
                return 1;
            }
        }
        public Boolean InsertarCredito(Credito objCredito)
        {
            using (TransactionScope Transaccion = new TransactionScope())
            {
                try
                {
                    Esquema.Credito.Add(objCredito);

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
                catch (Exception)
                {
                    return false;
                }
            }
        }
    }
}
