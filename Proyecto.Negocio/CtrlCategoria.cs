using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.Datos;
using System.Transactions;

namespace Proyecto.Negocio
{
    public class CtrlCategoria:Contexto
    {
        dbGimnasioSportLineEntities Esquema;

        public CtrlCategoria()
        {
            Esquema = TraerContexto();
        }
        public Int64 GenerarID()
        {
            try
            {
                return (from e in Esquema.Categoria select e.IdCategoria).Max() + 1;
            }
            catch (Exception)
            {
                return 1;
            }
        }
        public Boolean InsertarCategoria(Categoria objCategoria)
        {
            using (TransactionScope Transaccion = new TransactionScope())
            {
                try
                {
                    Esquema.Categoria.Add(objCategoria);
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
        public Boolean ModificarCategoria(Categoria objCategoria)
        {
            try
            {
                Categoria ObjAuxCategoria = Esquema.Categoria.FirstOrDefault(a => a.IdCategoria == objCategoria.IdCategoria);
                ObjAuxCategoria.IdCategoria = objCategoria.IdCategoria;
                ObjAuxCategoria.NombreCategoria = objCategoria.NombreCategoria;
                ObjAuxCategoria.EstadoCategoria = objCategoria.EstadoCategoria;
                Esquema.Entry(ObjAuxCategoria).State = System.Data.EntityState.Modified;

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
        public Boolean EliminarCategoria(Categoria objCategoria)//Solo Actualizamos el estado
        {
            try
            {
                Categoria ObjAuxCategoria = Esquema.Categoria.FirstOrDefault(a => a.IdCategoria == objCategoria.IdCategoria);
                ObjAuxCategoria.IdCategoria = objCategoria.IdCategoria;
                ObjAuxCategoria.EstadoCategoria = objCategoria.EstadoCategoria;
                Esquema.Entry(ObjAuxCategoria).State = System.Data.EntityState.Modified;

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
