using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.Datos;
using System.Transactions;

namespace Proyecto.Negocio
{
    public class CtrlCliente:Contexto
    {
        dbGimnasioSportLineEntities Esquema;

        public CtrlCliente()
        {
            Esquema = TraerContexto();
        }
        public Int64 GenerarID()
        {
            try
            {
                return (from e in Esquema.Persona select e.IdPersona).Max() + 1;
            }
            catch (Exception)
            {
                return 1;
            }
        }

        public Boolean VerificarClienteExistente(int cedula)
        {
  
            return Esquema.sp_VerificarPersonaExiste(cedula).FirstOrDefault() == 1 ? true : false;
       
        }

        public Boolean InsertarCliente(Persona objPersona, Cliente objCliente)
        {
            using (TransactionScope Transaccion = new TransactionScope())
            {
                try
                {
                    Esquema.Persona.Add(objPersona);
                    Esquema.Cliente.Add(objCliente);
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
        public Boolean ModificarCliente(Persona objPersona, Cliente objCliente)
        {
            using (TransactionScope Transaccion = new TransactionScope())
            {
                try
                {
                    Persona ObjAuxPersona = Esquema.Persona.FirstOrDefault(a => a.IdPersona == objPersona.IdPersona);
                    ObjAuxPersona.IdPersona = objPersona.IdPersona;
                    ObjAuxPersona.NombrePersona = objPersona.NombrePersona;
                    ObjAuxPersona.ApellidoPaterno = objPersona.ApellidoPaterno;
                    ObjAuxPersona.ApellidoMaterno = objPersona.ApellidoMaterno;
                    ObjAuxPersona.DocumentoIdentidad = objPersona.DocumentoIdentidad;
                    ObjAuxPersona.CorreoElectronico = objPersona.CorreoElectronico;
                    ObjAuxPersona.FechaNacimiento = objPersona.FechaNacimiento;
                    ObjAuxPersona.Sexo = objPersona.Sexo;
                    ObjAuxPersona.Telefono = objPersona.Telefono;
                    ObjAuxPersona.Direccion = objPersona.Direccion;
                    ObjAuxPersona.IdZona = objPersona.IdZona;
                    ObjAuxPersona.IdSucursal = objPersona.IdSucursal;
                    ObjAuxPersona.Foto = objPersona.Foto;
                    Esquema.Entry(ObjAuxPersona).State = System.Data.EntityState.Modified;

                    Cliente ObjAuxCliente = Esquema.Cliente.FirstOrDefault(b => b.IdPersona == objCliente.IdPersona);
                    ObjAuxCliente.IdPersona = objCliente.IdPersona;
                    ObjAuxCliente.Peso = objCliente.Peso;
                    ObjAuxCliente.Estatura = objCliente.Estatura;
                    Esquema.Entry(ObjAuxCliente).State = System.Data.EntityState.Modified;

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

        public bool Validar(string Nombre, string ApellidoPaterno, string CI,bool M,bool F)
        {

            if ((Nombre == string.Empty || Nombre == " ") && (ApellidoPaterno == string.Empty || ApellidoPaterno == " ") && (CI == string.Empty || CI == " ") && M==false && F==false)
            { throw new Exception("Favor llenar los campos obligatorios:\n < Nombre Cliente >\n < Apellido Paterno >\n < CI / NIT >\n < Sexo >"); }
            if ((Nombre == string.Empty || Nombre == " ")&&(ApellidoPaterno == string.Empty || ApellidoPaterno == " ") && (CI == string.Empty || CI == " "))
            { throw new Exception("Favor llenar los campos obligatorios:\n < Nombre Cliente >\n < Apellido Paterno >\n < CI / NIT >"); }
            if ((ApellidoPaterno == string.Empty || ApellidoPaterno == " ") && (CI == string.Empty || CI == " ") && M==false && F==false)
            { throw new Exception("Favor llenar los campos obligatorios:\n < Apellido Paterno >\n < CI / NIT >\n < Sexo >"); }
            if ((Nombre == string.Empty || Nombre == " ") && (CI == string.Empty || CI == " ") && M == false && F == false)
            { throw new Exception("Favor llenar los campos obligatorios:\n < Nombre Cliente >\n < Cédula Identidad >\n < Sexo >"); }
            if ((Nombre == string.Empty || Nombre == " ") && (ApellidoPaterno == string.Empty || ApellidoPaterno == " "))
            { throw new Exception("Favor llenar los campos obligatorios:\n < Nombre Cliente >\n < ApellidoPaterno >"); }
            if ((ApellidoPaterno == string.Empty || ApellidoPaterno == " ") && (CI == string.Empty || CI == " "))
            { throw new Exception("Favor llenar los campos obligatorios:\n < Apellido Paterno >\n < CI / NIT >"); }
            if ((CI == string.Empty || CI == " ") && M==false && F==false )
            { throw new Exception("Favor llenar los campos obligatorios:\n < Cédula Identidad >\n < Sexo >"); }
            if ((Nombre == string.Empty || Nombre == " ")&&(CI == string.Empty || CI == " "))
            { throw new Exception("Favor llenar los campos obligatorios:\n < Nombre Cliente >\n < CI / NIT >"); }
            if (Nombre == string.Empty || Nombre == " ")
            { throw new Exception("Favor llenar el campo obligatorio:\n < Nombre Cliente >"); }
            if (ApellidoPaterno == string.Empty || ApellidoPaterno == " ")
            { throw new Exception("Favor llenar el campo obligatorio:\n < Apellido Paterno >"); }
            if (CI == string.Empty || CI == " ")
            { throw new Exception("Favor llenar el campo obligatorio:\n < CI / NIT >"); }
            if (M == false && F == false)
            { throw new Exception("Favor llenar el campo obligatorio:\n < Sexo >"); }

            return true;
        }
    }
}
