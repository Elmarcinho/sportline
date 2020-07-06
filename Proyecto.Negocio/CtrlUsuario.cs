using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.Datos;
using System.Transactions;




namespace Proyecto.Negocio
{
    public class CtrlUsuario : Contexto
    {
        dbGimnasioSportLineEntities Esquema;
        public CtrlUsuario()
        {
            Esquema = TraerContexto();
        }
        public Int64 GenerarID()
        {
            try
            {
                return (from e in Esquema.Usuario select e.IdUsuario).Max() + 1;
            }
            catch (Exception)
            {
                return 1;
            }
        }
        public bool InsertarUsuario(Usuario ObjUsuario)
        {
            using (TransactionScope Transaccion = new TransactionScope())
            {
                try
                {
                    Esquema.Usuario.Add(ObjUsuario);
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
        public Boolean ModificarUsuario(Usuario objUsuario)
        {
            try
            {
                Usuario ObjAuxUsuario = Esquema.Usuario.FirstOrDefault(a => a.IdUsuario == objUsuario.IdUsuario);
                ObjAuxUsuario.IdUsuario = objUsuario.IdUsuario;
                ObjAuxUsuario.NombreUsuario = objUsuario.NombreUsuario;
                ObjAuxUsuario.Contraseña = objUsuario.Contraseña;
                ObjAuxUsuario.IdRol = objUsuario.IdRol;
                ObjAuxUsuario.EstadoUsuario = objUsuario.EstadoUsuario;
                Esquema.Entry(ObjAuxUsuario).State = System.Data.EntityState.Modified;

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
        public Boolean EliminarUsuario(Usuario objUsuario)//Solo Actualizamos el estado
        {
            try
            {
                Usuario ObjAuxUsuario = Esquema.Usuario.FirstOrDefault(a => a.IdUsuario == objUsuario.IdUsuario);
                ObjAuxUsuario.IdUsuario = objUsuario.IdUsuario;
                ObjAuxUsuario.EstadoUsuario = objUsuario.EstadoUsuario;
                Esquema.Entry(ObjAuxUsuario).State = System.Data.EntityState.Modified;

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
        public Boolean EliminarUsuario2(Usuario objUsuario)
        {
            try
            {
                Usuario ObjAuxUsuario = Esquema.Usuario.FirstOrDefault(a => a.IdUsuario == objUsuario.IdUsuario);
                Esquema.Usuario.Remove(ObjAuxUsuario);

                return Esquema.SaveChanges() > 0;
            }
            catch (Exception )
            {
                return false;
            }
        }
        public Boolean ValidarUsuario(Usuario objUsuario)
        {
            try
            {
                var l = (from e in Esquema.VUsuarioRolPermisos where e.NombreUsuario == (objUsuario.NombreUsuario) && e.Contraseña == (objUsuario.Contraseña) && (e.EstadoRolPermiso == 1) select e).Count();
                if (l != 0)
                {
                    var lista = (from e in Esquema.VUsuarioRolPermisos where e.NombreUsuario == (objUsuario.NombreUsuario) && e.Contraseña == (objUsuario.Contraseña) && (e.EstadoRolPermiso==1) select e).ToList();
                    Utilitarios.Utilitarios.IdPermiso = new int[lista.LongCount(), 2];
                    int a = 0;
                    foreach (var item in lista)
                    {
                        Utilitarios.Utilitarios.Sucursal = item.NombreSucursal;
                        Utilitarios.Utilitarios.IdUsuario = item.IdUsuario;
                        Utilitarios.Utilitarios.NombreUsuarioSession = item.NombreUsuario;
                        Utilitarios.Utilitarios.NombreEmpleadoSession = item.NombreEmpleado;
                        Utilitarios.Utilitarios.IdRol = item.IdRol;
                        Utilitarios.Utilitarios.Rol = item.NombreRol;
                        Utilitarios.Utilitarios.Imagen = item.Foto;
                      
                        foreach (var auxitem in lista)
                        {
                            Utilitarios.Utilitarios.IdPermiso[a, 0] = Convert.ToInt32(auxitem.IdPermiso);
                            Utilitarios.Utilitarios.IdPermiso[a, 1] = Convert.ToInt32(auxitem.EstadoRolPermiso);
                          
                            a++;
                        }
                        break;
                    }
                    return true;
                }
                else { return false; }

            }
            catch (Exception e)
            { return false; }

        }
    }
}
