using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.Datos;
using System.Transactions;

namespace Proyecto.Negocio
{
    public class CtrlAsistencia:Contexto
    {
        dbGimnasioSportLineEntities Esquema;

        public CtrlAsistencia()
        {
            Esquema = TraerContexto();
        }
        public Int64 GenerarID()
        {
            try
            {
                return (from e in Esquema.Asistencia select e.IdAsistencia).Max() + 1;
            }
            catch (Exception)
            {
                return 1;
            }
        }
        public Boolean InsertarAsistencia(Asistencia objAsistencia)
        {
            using (TransactionScope Transaccion = new TransactionScope())
            {
                try
                {
                    Esquema.Asistencia.Add(objAsistencia);
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
        public Boolean ModificarAsistencia(Asistencia objAsistencia)
        {
            try
            {
                Asistencia ObjAuxAsistencia = Esquema.Asistencia.FirstOrDefault(a => a.IdAsistencia == objAsistencia.IdAsistencia);
                ObjAuxAsistencia.IdAsistencia = objAsistencia.IdAsistencia;
                ObjAuxAsistencia.FechaAsistencia = objAsistencia.FechaAsistencia;
                ObjAuxAsistencia.FechaRenovacion = objAsistencia.FechaRenovacion;
                ObjAuxAsistencia.Valor = objAsistencia.Valor;
                Esquema.Entry(ObjAuxAsistencia).State = System.Data.EntityState.Modified;

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
