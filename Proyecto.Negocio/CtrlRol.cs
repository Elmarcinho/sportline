using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.Datos;
using System.Transactions;

namespace Proyecto.Negocio
{
    public class CtrlRol:Contexto
    {
        dbGimnasioSportLineEntities Esquema;

        public CtrlRol()
        {
            Esquema = TraerContexto();
        }
        public Int64 GenerarID()
        {
            try
            {
                return (from e in Esquema.Rol select e.IdRol).Max() + 1;
            }
            catch (Exception)
            {
                return 1;
            }
        }
        public Boolean InsertarRol(Rol objRol)
        {
            using (TransactionScope Transaccion = new TransactionScope())
            {
                try
                {
                    Esquema.Rol.Add(objRol);
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
                catch (Exception )
                {
                    return false;
                }
            }
        }
        public Boolean ModificarRol(Rol objRol)
        {
            try
            {
                Rol ObjAuxRol = Esquema.Rol.FirstOrDefault(a => a.IdRol == objRol.IdRol);
                ObjAuxRol.IdRol = objRol.IdRol;
                ObjAuxRol.NombreRol = objRol.NombreRol;
                ObjAuxRol.Descripcion = objRol.Descripcion;
                ObjAuxRol.EstadoRol = objRol.EstadoRol;
                Esquema.Entry(ObjAuxRol).State = System.Data.EntityState.Modified;

                if (Esquema.SaveChanges() == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
                
            }
            catch (Exception )
            {
                return false;
            }
        }
        public Boolean EliminarRol(Rol objRol)//Solo Actualizamos el estado
        {
            try
            {
                Rol ObjAuxRol = Esquema.Rol.FirstOrDefault(a => a.IdRol == objRol.IdRol);
                ObjAuxRol.IdRol = objRol.IdRol;
                ObjAuxRol.EstadoRol = objRol.EstadoRol;
                return Esquema.SaveChanges() >= 1;
            }
            catch (Exception )
            {
                return false;
            }
        }
    }
}
