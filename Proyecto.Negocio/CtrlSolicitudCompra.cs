using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.Datos;
using System.Transactions;

namespace Proyecto.Negocio.RNLista
{
    public class CtrlSolicitudCompra:Contexto
    {
        dbGimnasioSportLineEntities Esquema;

        private List<DetalleSolicitudCompra> ListaDetalleProducto = new List<DetalleSolicitudCompra>();
        public CtrlSolicitudCompra()
        {
            Esquema = TraerContexto();
        }
        public long GenerarID()
        {
            try
            {
                return (from e in Esquema.SolicitudCompra select e.IdSolicitudCompra).Max() + 1;
            }
            catch (Exception)
            {
                return 1;
            }
        }
        public Boolean InsertarSolicitudCompra(RNSolicitudCompra ObjSolicitud)
        {
            using (TransactionScope Transaccion = new TransactionScope())
            {
                try
                {
                    SolicitudCompra ObjSolicitudCompra = new SolicitudCompra();
                    ObjSolicitudCompra.IdSolicitudCompra = ObjSolicitud.IdSolicitudCompra;
                    ObjSolicitudCompra.FechaCompra = ObjSolicitud.FechaCompra;
                    ObjSolicitudCompra.IdUsuario = ObjSolicitud.IdUsuario;

                    Esquema.SolicitudCompra.Add(ObjSolicitudCompra);

                    foreach (DetalleSolicitudCompra objDetalleCompra in ListaDetalleProducto)
                    {
                        Esquema.DetalleSolicitudCompra.Add(objDetalleCompra);
                    }

                    if (Esquema.SaveChanges() == (ListaDetalleProducto.Count + 1))
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
        public void InsertarListaDetallePro(DetalleSolicitudCompra objdetalle)
        {
            ListaDetalleProducto.Add(objdetalle);
        }
        public void LimpiarListaDetallePro(DetalleSolicitudCompra objdetalle)
        {
            ListaDetalleProducto.Clear();
        }
    }
}
