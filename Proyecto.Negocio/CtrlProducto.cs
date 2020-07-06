using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.Datos;
using System.Transactions;

namespace Proyecto.Negocio
{
    public class CtrlProducto:Contexto
    {
        dbGimnasioSportLineEntities Esquema;

        public CtrlProducto()
        {
            Esquema = TraerContexto();
        }
        public Int64 GenerarID()
        {
            try
            {
                return (from e in Esquema.Producto select e.IdProducto).Max() + 1;
            }
            catch (Exception)
            {
                return 1;
            }
        }
        public Boolean InsertarProducto(Producto objProducto, Precio objPrecio)
        {
            using (TransactionScope Transaccion = new TransactionScope())
            {
                try
                {
                    Esquema.Producto.Add(objProducto);
                    Esquema.Precio.Add(objPrecio);
                    if (Esquema.SaveChanges() == 2)
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
        public Boolean ModificarProducto(Producto objProducto,Precio objPrecio)
        {
            using (TransactionScope Transaccion = new TransactionScope())
            {
                try
                {
                    Producto ObjAuxProducto = Esquema.Producto.FirstOrDefault(a => a.IdProducto == objProducto.IdProducto);
                    ObjAuxProducto.IdProducto = objProducto.IdProducto;
                    ObjAuxProducto.NombreProducto = objProducto.NombreProducto;
                    ObjAuxProducto.DescripcionProducto = objProducto.DescripcionProducto;
                    ObjAuxProducto.Stock = objProducto.Stock;
                    ObjAuxProducto.IdCategoria = objProducto.IdCategoria;
                    ObjAuxProducto.EstadoProducto = objProducto.EstadoProducto;
                    Esquema.Entry(ObjAuxProducto).State = System.Data.EntityState.Modified;

                    Precio ObjAuxPrecio = Esquema.Precio.FirstOrDefault(b => b.IdPrecio == objPrecio.IdPrecio);
                    ObjAuxPrecio.IdPrecio = objPrecio.IdPrecio;
                    ObjAuxPrecio.FechaFinal = objPrecio.FechaFinal;
                    ObjAuxPrecio.EstadoPrecio = objPrecio.EstadoPrecio;
                    Esquema.Entry(ObjAuxPrecio).State = System.Data.EntityState.Modified;
                 
                    if (Esquema.SaveChanges() == 2)
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

        public Boolean EliminarProducto(Producto objProducto)//Solo Actualizamos el estado
        {
            try
            {
                Producto ObjAuxProducto = Esquema.Producto.FirstOrDefault(a => a.IdProducto == objProducto.IdProducto);
                ObjAuxProducto.IdProducto = objProducto.IdProducto;
                ObjAuxProducto.EstadoProducto = objProducto.EstadoProducto;
                Esquema.Entry(ObjAuxProducto).State = System.Data.EntityState.Modified;
                return Esquema.SaveChanges() == 1;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Validar(string Nombre, string PrecioCompra, string PrecioVenta, string Stock)
        {
            if ((Nombre == string.Empty || Nombre == "")&& (PrecioCompra == string.Empty || PrecioCompra == "") && (PrecioVenta == string.Empty || PrecioVenta == "") && (Stock == string.Empty || Stock == ""))
            { throw new Exception("Favor llenar los campos obligatorios:\n -Nombre Producto\n -Precio Compra\n -Precio Venta\n -Stock"); }

            if ((PrecioCompra == string.Empty || PrecioCompra == "") && (PrecioVenta == string.Empty || PrecioVenta == "")&& (Stock == string.Empty || Stock == ""))
            { throw new Exception("Favor llenar los campos obligatorios:\n -Precio Compra\n -Precio Venta\n -Stock"); }
            if ((Nombre == string.Empty || Nombre == "") && (PrecioCompra == string.Empty || PrecioCompra == "") && (PrecioVenta == string.Empty || PrecioVenta == ""))
            { throw new Exception("Favor llenar los campos obligatorios:\n -Nombre Producto\n -Precio Compra\n -Precio Venta"); }

            if ((PrecioCompra == string.Empty || PrecioCompra == "") && (PrecioVenta == string.Empty || PrecioVenta == ""))
            { throw new Exception("Favor llenar los campos obligatorios:\n -Precio Compra\n -Precio Venta"); }
            if ((PrecioVenta == string.Empty || PrecioVenta == "")&& (Stock == string.Empty || Stock == ""))
            { throw new Exception("Favor llenar los campos obligatorios:\n -Precio Venta\n -Stock"); }
            if ((Nombre == string.Empty || Nombre == "") && (PrecioCompra == string.Empty || PrecioCompra == ""))
            { throw new Exception("Favor llenar los campos obligatorios:\n -Nombre Producto\n -Precio Compra"); }
            if ((Nombre == string.Empty || Nombre == "") && (Stock == string.Empty || Stock == ""))
            { throw new Exception("Favor llenar los campos obligatorios:\n -Nombre Producto\n -Stock"); }

            if ((Nombre == string.Empty || Nombre == ""))
            { throw new Exception("Favor llenar los campos obligatorios:\n -Nombre Producto\n"); }
            if ((PrecioCompra == string.Empty || PrecioCompra == ""))
            { throw new Exception("Favor llenar los campos obligatorios:\n -Precio Compra"); }
            if ((PrecioVenta == string.Empty || PrecioCompra == ""))
            { throw new Exception("Favor llenar los campos obligatorios:\n -Precio Venta"); }
            if ((Stock == string.Empty || Stock == ""))
            { throw new Exception("Favor llenar los campos obligatorios:\n -Stock"); }

            return true;
        }
    }
}
