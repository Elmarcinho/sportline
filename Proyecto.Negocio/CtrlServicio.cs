using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.Datos;
using System.Transactions;

namespace Proyecto.Negocio
{
    public class CtrlServicio:Contexto
    {
        dbGimnasioSportLineEntities Esquema;

        public CtrlServicio()
        {
            Esquema = TraerContexto();
        }
        public Int64 GenerarID()
        {
            try
            {
                return (from e in Esquema.Servicio select e.IdServicio).Max() + 1;
            }
            catch (Exception)
            {
                return 1;
            }
        }
        public Boolean InsertarServicio(Servicio objServicio, Precio objPrecio)
        {
            using (TransactionScope Transaccion = new TransactionScope())
            {
                try
                {
                    Esquema.Servicio.Add(objServicio);
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
        public Boolean ModificarServicio(Servicio objServicio, Precio objPrecio)
        {
            using (TransactionScope Transaccion = new TransactionScope())
            {
                try
                {
                    Servicio ObjAuxServicio = Esquema.Servicio.FirstOrDefault(a => a.IdServicio == objServicio.IdServicio);
                    ObjAuxServicio.IdServicio = objServicio.IdServicio;
                    ObjAuxServicio.NombreServicio = objServicio.NombreServicio;
                    ObjAuxServicio.Descripcion = objServicio.Descripcion;
                    ObjAuxServicio.HoraInicio = objServicio.HoraInicio;
                    ObjAuxServicio.HoraFin = objServicio.HoraFin;
                    ObjAuxServicio.RangoDia = objServicio.RangoDia;
                    ObjAuxServicio.EstadoServicio = objServicio.EstadoServicio;
                    Esquema.Entry(ObjAuxServicio).State = System.Data.EntityState.Modified;

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
        public bool Validar(string Nombre, string PrecioDiario, string PrecioQuincenal, string PrecioMensual)
        {
            if ((Nombre == string.Empty || Nombre == "")&&(PrecioDiario == string.Empty || PrecioDiario == "") && (PrecioQuincenal == string.Empty || PrecioQuincenal == "") && (PrecioMensual == string.Empty || PrecioMensual == ""))
            { throw new Exception("Favor llenar los campos obligatorios:\n -Nombre Disciplina\n -Precio Diario\n -Precio Quincenal\n -Precio Mensual"); }

            if ((Nombre == string.Empty || Nombre == "") && (PrecioDiario == string.Empty || PrecioDiario == "") && (PrecioQuincenal == string.Empty || PrecioQuincenal == ""))
            { throw new Exception("Favor llenar los campos obligatorios:\n -Nombre Disciplina\n -Precio Diario\n -Precio Quincenal"); }
            if ((Nombre == string.Empty || Nombre == "") && (PrecioDiario == string.Empty || PrecioDiario == "") && (PrecioMensual == string.Empty || PrecioMensual == ""))
            { throw new Exception("Favor llenar los campos obligatorios:\n -Nombre Disciplina\n -Precio Diario\n -Precio Mensual"); }
            if ((PrecioDiario == string.Empty || PrecioDiario == "") && (PrecioQuincenal == string.Empty || PrecioQuincenal == "") && (PrecioMensual == string.Empty || PrecioMensual == ""))
            { throw new Exception("Favor llenar los campos obligatorios:\n -Precio Diario\n -Precio Quincenal\n -Precio Mensual"); }

            if ((Nombre == string.Empty || Nombre == "") && (PrecioDiario == string.Empty || PrecioDiario == ""))
            { throw new Exception("Favor llenar los campos obligatorios:\n -Nombre Disciplina\n -Precio Diario"); }
            if ((Nombre == string.Empty || Nombre == "") && (PrecioQuincenal == string.Empty || PrecioQuincenal == ""))
            { throw new Exception("Favor llenar los campos obligatorios:\n -Nombre Disciplina\n -Precio Quincenal"); }
            if ((Nombre == string.Empty || Nombre == "") && (PrecioMensual == string.Empty || PrecioMensual == ""))
            { throw new Exception("Favor llenar los campos obligatorios:\n -Nombre Disciplina\n -Precio Mensual"); }
            if ((PrecioDiario == string.Empty || PrecioDiario == "") && (PrecioQuincenal == string.Empty || PrecioQuincenal == ""))
            { throw new Exception("Favor llenar los campos obligatorios:\n -Precio Diario\n -Precio Quincenal"); }
            if ((PrecioDiario == string.Empty || PrecioDiario == "") && (PrecioMensual == string.Empty || PrecioMensual == ""))
            { throw new Exception("Favor llenar los campos obligatorios:\n -Precio Diario\n -Precio Mensual"); }
            if ((PrecioQuincenal == string.Empty || PrecioQuincenal == "") && (PrecioMensual == string.Empty || PrecioMensual == ""))
            { throw new Exception("Favor llenar los campos obligatorios:\n -Precio Quincenal\n -Precio Mensual"); }

            if ((Nombre == string.Empty || Nombre == ""))
            { throw new Exception("Favor llenar los campos obligatorios:\n -Nombre Disciplina\n"); }
            if ((PrecioDiario == string.Empty || PrecioDiario == ""))
            { throw new Exception("Favor llenar los campos obligatorios:\n -Precio Diario"); }
            if ((PrecioQuincenal == string.Empty || PrecioQuincenal == ""))
            { throw new Exception("Favor llenar los campos obligatorios:\n -Precio Quincenal"); }
            if ((PrecioMensual == string.Empty || PrecioMensual == ""))
            { throw new Exception("Favor llenar los campos obligatorios:\n -Precio Mensual"); }

            return true;
        }
    }
}
