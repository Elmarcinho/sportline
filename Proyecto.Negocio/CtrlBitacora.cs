using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.Datos;
using System.Transactions;

namespace Proyecto.Negocio
{
    public class CtrlBitacora:Contexto
    {
        dbGimnasioSportLineEntities Esquema;

        public CtrlBitacora()
        {
            Esquema = TraerContexto();
        }
        public Int64 GenerarID()
        {
            try
            {
                return (from e in Esquema.BitacoraLogin select e.IdBitLogin).Max() + 1;
            }
            catch (Exception)
            {
                return 1;
            }
        }
        public Boolean InsertarBitacoraLogin(BitacoraLogin objBitacoraLogin)
        {
            using (TransactionScope Transaccion = new TransactionScope())
            {
                try
                {
                    Esquema.BitacoraLogin.Add(objBitacoraLogin);
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
        public Boolean ModificarBitacoraLogin(BitacoraLogin objBitacoraLogin)
        {
            try
            {
                BitacoraLogin ObjAuxBitacoraLogin = Esquema.BitacoraLogin.FirstOrDefault(a => a.IdBitLogin == objBitacoraLogin.IdBitLogin);
                ObjAuxBitacoraLogin.IdBitLogin = objBitacoraLogin.IdBitLogin;
                ObjAuxBitacoraLogin.HoraSalida = objBitacoraLogin.HoraSalida;
                return Esquema.SaveChanges() >= 1;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public Boolean InsertarBitacoraSolicitud(BitacoraSolicitudVenta objBitacoraSolicitud)
        {
            using (TransactionScope Transaccion = new TransactionScope())
            {
                try
                {
                    Esquema.BitacoraSolicitudVenta.Add(objBitacoraSolicitud);
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
                catch (Exception e)
                {
                    return false;
                }
            }
        }
    }
}
