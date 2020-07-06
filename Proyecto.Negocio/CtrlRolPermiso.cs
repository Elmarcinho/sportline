using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.Datos;
using System.Transactions;

namespace Proyecto.Negocio
{
    public class CtrlRolPermiso:Contexto
    {
        dbGimnasioSportLineEntities Esquema;

        public CtrlRolPermiso()
        {
            Esquema = TraerContexto();
        }
        public Boolean InsertarRolPermiso(RolPermiso objRolPermiso)
        {
            using (TransactionScope Transaccion = new TransactionScope())
            {
                try
                {
                    Esquema.RolPermiso.Add(objRolPermiso);
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
        public Boolean ModificarRolPermiso(RolPermiso objRolPermiso)
        {
            try
            {
                RolPermiso ObjAuxRol = Esquema.RolPermiso.FirstOrDefault(a => a.IdRol == objRolPermiso.IdRol && a.IdPermiso == objRolPermiso.IdPermiso);
                ObjAuxRol.EstadoRolPermiso = objRolPermiso.EstadoRolPermiso;
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
            catch (Exception)
            {
                return false;
            }
        }
    }
}
