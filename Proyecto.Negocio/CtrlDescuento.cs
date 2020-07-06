using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.Datos;
using System.Transactions;

namespace Proyecto.Negocio
{
    public class CtrlDescuento:Contexto
    {
        dbGimnasioSportLineEntities Esquema;

        public CtrlDescuento()
        {
            Esquema = TraerContexto();
        }
        public Int64 GenerarID()
        {
            try
            {
                return (from e in Esquema.Descuento select e.IdDescuento).Max() + 1;
            }
            catch (Exception)
            {
                return 1;
            }
        }
        public Boolean InsertarDescuento(Descuento objDescuento)
        {
            using (TransactionScope Transaccion = new TransactionScope())
            {
                try
                {
                    Esquema.Descuento.Add(objDescuento);
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
        public Boolean ModificarDescuento(Descuento objDescuento)
        {
            try
            {
                Descuento ObjAuxDescuento = Esquema.Descuento.FirstOrDefault(a => a.IdDescuento == objDescuento.IdDescuento);
                ObjAuxDescuento.IdDescuento = objDescuento.IdDescuento;
                ObjAuxDescuento.NombreDescuento = objDescuento.NombreDescuento;
                ObjAuxDescuento.Monto = objDescuento.Monto;
                Esquema.Entry(ObjAuxDescuento).State = System.Data.EntityState.Modified;

                if (Esquema.SaveChanges() == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        public Boolean AltaBajaDescuento(Descuento objDescuento)//Solo Actualizamos el estado
        {
            try
            {
                Descuento ObjAuxDescuento = Esquema.Descuento.FirstOrDefault(a => a.IdDescuento == objDescuento.IdDescuento);
                ObjAuxDescuento.IdDescuento = objDescuento.IdDescuento;
                ObjAuxDescuento.EstadoDescuento = objDescuento.EstadoDescuento;
                Esquema.Entry(ObjAuxDescuento).State = System.Data.EntityState.Modified;

                if (Esquema.SaveChanges() == 1)
                {
                    return true;
                }
                else
                {
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
