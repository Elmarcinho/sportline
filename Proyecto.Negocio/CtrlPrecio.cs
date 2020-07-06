using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.Datos;
using System.Transactions;


namespace Proyecto.Negocio
{
    public class CtrlPrecio:Contexto
    {
        dbGimnasioSportLineEntities Esquema;
        public CtrlPrecio()
        {
            Esquema = TraerContexto();
        }
        public Int64 GenerarID()
        {
            try
            {
                return (from e in Esquema.Precio select e.IdPrecio).Max() + 1;
            }
            catch (Exception)
            {
                return 1;
            }
        }
        public Boolean InsertarPrecio(Precio objPrecio)
        {
            using (TransactionScope Transaccion = new TransactionScope())
            {
                try
                {
                    Esquema.Precio.Add(objPrecio);
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
        public Boolean EliminarPrecio(Precio objPrecio)//Solo Actualizamos el estado
        {
            try
            {
                Precio ObjAuxPrecio = Esquema.Precio.FirstOrDefault(a => a.IdPrecio == objPrecio.IdPrecio);
                ObjAuxPrecio.IdPrecio = objPrecio.IdPrecio;
                ObjAuxPrecio.FechaFinal = objPrecio.FechaFinal;
                ObjAuxPrecio.EstadoPrecio = objPrecio.EstadoPrecio;
                return Esquema.SaveChanges() >= 1;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
