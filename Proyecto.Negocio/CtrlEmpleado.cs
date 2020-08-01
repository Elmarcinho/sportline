using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.Datos;
using System.Transactions;

namespace Proyecto.Negocio
{
    public class CtrlEmpleado:Contexto
    {
        dbGimnasioSportLineEntities Esquema;

        public CtrlEmpleado()
        {
            Esquema = TraerContexto();
        }
        public Int64 GenerarID()
        {
            try
            {
                return (from e in Esquema.Persona select e.IdPersona).Max() + 1;
            }
            catch (Exception )
            {
                return 1;
            }
        }
        public Boolean InsertarEmpleado(Persona objPersona, Empleado objEmpleado)
        {
            using (TransactionScope Transaccion = new TransactionScope())
            {
                try
                {
                    Esquema.Persona.Add(objPersona);
                    Esquema.Empleado.Add(objEmpleado);
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
                catch (Exception )
                {
                    return false;
                }
            }
        }
        public Boolean ActualizarEmpleado(Persona objPersona, Empleado objEmpleado)
        {
            using (TransactionScope Transaccion = new TransactionScope())
            {

                try
                {
                    Persona ObjAuxPersona = Esquema.Persona.FirstOrDefault(a => a.IdPersona == objPersona.IdPersona);
                    ObjAuxPersona.IdPersona         = objPersona.IdPersona;
                    ObjAuxPersona.NombrePersona     = objPersona.NombrePersona;
                    ObjAuxPersona.ApellidoPaterno   = objPersona.ApellidoPaterno;
                    ObjAuxPersona.ApellidoMaterno   = objPersona.ApellidoMaterno;
                    ObjAuxPersona.DocumentoIdentidad = objPersona.DocumentoIdentidad;
                    ObjAuxPersona.CorreoElectronico = objPersona.CorreoElectronico;
                    ObjAuxPersona.FechaNacimiento   = objPersona.FechaNacimiento;
                    ObjAuxPersona.Sexo              = objPersona.Sexo;
                    ObjAuxPersona.Telefono          = objPersona.Telefono;
                    ObjAuxPersona.Direccion         = objPersona.Direccion;
                    ObjAuxPersona.IdZona            = objPersona.IdZona;
                    ObjAuxPersona.IdSucursal        = objPersona.IdSucursal;
                    ObjAuxPersona.Foto              = objPersona.Foto;
                    Esquema.Entry(ObjAuxPersona).State = System.Data.EntityState.Modified;

                    Empleado ObjAuxEmpleado = Esquema.Empleado.FirstOrDefault(a => a.IdPersona == objEmpleado.IdPersona);
                    ObjAuxEmpleado.IdPersona    = objEmpleado.IdPersona;
                    ObjAuxEmpleado.FechaIngreso = objEmpleado.FechaIngreso;
                    Esquema.Entry(ObjAuxEmpleado).State = System.Data.EntityState.Modified;

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
        public Boolean EliminarEmpleado(Empleado objEmpleado)//Solo Actualizamos el estado
        {
            try
            {
                Empleado ObjAuxEmpleado = Esquema.Empleado.FirstOrDefault(a => a.IdPersona == objEmpleado.IdPersona);
                ObjAuxEmpleado.IdPersona = objEmpleado.IdPersona;
                ObjAuxEmpleado.EstadoEmpleado = objEmpleado.EstadoEmpleado;
                return Esquema.SaveChanges() >= 1;
            }
            catch (Exception )
            {
                return false;
            }
        }
        public bool Validar(string Nombre, string Apellido, string CI)
        {
            if ((Nombre == string.Empty || Nombre == " ") && (Apellido == string.Empty || Apellido == " ") && CI == string.Empty || CI == " ")
            { throw new Exception("Favor llenar los campos obligatorios:\n -Nombre Empleado\n -Apellido Paterno\n -CI"); }
            if ((Nombre == string.Empty || Nombre == " ") && (Apellido == string.Empty || Apellido == " "))
            { throw new Exception("Favor llenar los campos obligatorios:\n -Nombre Empleado\n -Apellido Paterno"); }
            if ((Nombre == string.Empty || Nombre == " ") && (CI == string.Empty || CI == " "))
            { throw new Exception("Favor llenar los campos obligatorios:\n -Nombre Empleado\n -CI/NIT"); }
            if ((Apellido == string.Empty || Apellido == " ") && (CI == string.Empty || CI == " "))
            { throw new Exception("Favor llenar los campos obligatorios:\n -Apellido Paterno\n -CI/NIT"); }
            if (Nombre == string.Empty || Nombre == " ")
            { throw new Exception("Favor llenar el campo obligatorio:\n -Nombre Empleado"); }
            if (Apellido == string.Empty || Apellido == " ")
            { throw new Exception("Favor llenar el campo obligatorio:\n -Apellido Paterno"); }
            if (CI == string.Empty || CI == " ")
            { throw new Exception("Favor llenar el campo obligatorio:\n -CI/NIT"); }

            return true;
        }
    }
}
