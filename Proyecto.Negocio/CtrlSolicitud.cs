using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.Datos;
using System.Transactions;

namespace Proyecto.Negocio.RNLista
{
    public class CtrlSolicitud:Contexto
    {
        dbGimnasioSportLineEntities Esquema;

        public List<DetalleSolicitud> ListaDetallePro = new List<DetalleSolicitud>();
        public CtrlSolicitud()
        {
            Esquema = TraerContexto();
        }
        public long GenerarID()
        {
            try
            {
                return (from e in Esquema.Solicitud select e.IdSolicitud).Max() + 1;
            }
            catch (Exception)
            {
                return 1;
            }
        }
      
        public Boolean InsertarSolicitudCliente(RNSolicitud ObjSolicitud)
        {
            using (TransactionScope Transaccion = new TransactionScope())
            {
                try
                {
                    Solicitud ObjSolicitudCliente = new Solicitud();
                    ObjSolicitudCliente.IdSolicitud = ObjSolicitud.IdSolicitud;
                    //ObjSolicitudCliente.FechaSolicitud = ObjSolicitud.FechaSolicitud;
                    ObjSolicitudCliente.FechaSolicitud = Esquema.Database.SqlQuery<DateTime>("SELECT GETDATE() Fecha").SingleOrDefault().Date;
                    ObjSolicitudCliente.FechaIngreso = ObjSolicitud.FechaIngreso;
                    ObjSolicitudCliente.FechaCulminacion = ObjSolicitud.FechaCulminacion;
                    ObjSolicitudCliente.EstadoSolicitud = ObjSolicitud.EstadoSolicitud;
                    ObjSolicitudCliente.TipoPago = ObjSolicitud.IdTipoPago;
                    ObjSolicitudCliente.IdCliente = ObjSolicitud.IdCliente;
                    ObjSolicitudCliente.IdTipoSolicitud = ObjSolicitud.IdTipoSolicitud;
                    ObjSolicitudCliente.IdPlazo = ObjSolicitud.IdPlazo;
                    ObjSolicitudCliente.IdDescuento = ObjSolicitud.IdDescuento;
                    ObjSolicitudCliente.IdUsuario = ObjSolicitud.IdUsuario;

                    Esquema.Solicitud.Add(ObjSolicitudCliente);

                    foreach (DetalleSolicitud objdetalle in ListaDetallePro)
                    {
                        Esquema.DetalleSolicitud.Add(objdetalle);
                    }
             
                    if (Esquema.SaveChanges() == (ListaDetallePro.Count + 1))
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
        public Boolean ModificarSolicitudCliente(RNSolicitud ObjSolicitud)
        {
            using (TransactionScope Transaccion = new TransactionScope())
            {
                try
                {
                    Solicitud ObjSolicitudCliente = Esquema.Solicitud.FirstOrDefault(a => a.IdSolicitud == ObjSolicitud.IdSolicitud);
                    ObjSolicitudCliente.IdUsuario = ObjSolicitud.IdUsuario;
                    Esquema.Entry(ObjSolicitudCliente).State = System.Data.EntityState.Modified;

                    foreach (DetalleSolicitud objdetalle in ListaDetallePro)
                    {
                        Esquema.DetalleSolicitud.Add(objdetalle);
                    }
        
                    if (Esquema.SaveChanges() == (ListaDetallePro.Count + 1))
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
        public Boolean EliminarDetalleSolicitud(Int64 IdSolicitud)
        {
            try
            {
                var ObjAuxDetalle = Esquema.DetalleSolicitud.Where(a => a.IdSolicitud == IdSolicitud).ToList();
                foreach (var item in ObjAuxDetalle)
                {
                    Esquema.DetalleSolicitud.Remove(item);
                }
               
                return Esquema.SaveChanges() > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public Boolean CancelarSolicitud(Solicitud objSolicitud)
        {
            try
            {
                Solicitud ObjAuxSolicitud = Esquema.Solicitud.FirstOrDefault(a => a.IdSolicitud == objSolicitud.IdSolicitud);
                ObjAuxSolicitud.EstadoSolicitud = objSolicitud.EstadoSolicitud;
                Esquema.Entry(ObjAuxSolicitud).State = System.Data.EntityState.Modified;

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
        public void InsertarListaDetalle(DetalleSolicitud objdetalle)
        {
            ListaDetallePro.Add(objdetalle);
        }
        public void LimpiarListaDetalle(DetalleSolicitud objdetalle)
        {
            ListaDetallePro.Clear();
        }
    }
}
