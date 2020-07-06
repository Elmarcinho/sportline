using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.Datos;
using System.Transactions;

namespace Proyecto.Negocio
{
    public class CtrlFactura:Contexto
    {
        dbGimnasioSportLineEntities Esquema;
        public CtrlFactura()
        {
            Esquema = TraerContexto();
        }
        public Int64 GenerarID(Int64 x, Int64 y)
        {
            try
            {
                if (((from e in Esquema.Factura select e.IdFactura).Max() > 0) && (from e in Esquema.Factura select e.IdFactura).Max() <= y)
                {
                    return (from e in Esquema.Factura select e.IdFactura).Max() + 1;
                }
                else 
                {
                    return 0; 
                }
               
            }
            catch (Exception)
            {
                return x;
            }
        }
        public Boolean InsertarFactura(Factura objFactura)
        {
            using (TransactionScope Transaccion = new TransactionScope())
            {
                try
                {
                    Esquema.Factura.Add(objFactura);
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
