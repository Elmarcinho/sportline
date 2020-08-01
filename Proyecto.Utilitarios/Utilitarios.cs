using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Utilitarios
{
    public class Utilitarios
    {
        public static Int64 Evento;
        public static Int64 EventoVer;
        public static Int64 EventoClic = 0;
        public static string EstadoPlan;
        public static Int64 EventoInfo;

        public static Int64 IdSucursal=1;

        public static Int64 EstadoEmpleado = 1;
        public static Int64 IdEmpleado;
        public static string NombreEmpleado;

        public static Int64 IdCliente;
        public static Int64 CedulaIdendidad;

        public static Int64 IdCredito;
        public static double SaldoActualCredito;

        public static Int64 EstadoSolicitud = 3;
        public static Int64 TipoSolicitud;

        public static Int64 IdProSer;
        public static string NombreProSer;
        public static string DescripcionProser;
        public static double Stock;

        public static Int64 IdProducto;
        public static Int64 EstadoProducto = 1;

        public static Int64 IdServicio;
        public static Int64 EstadoServicio = 1;

        public static Int64 IdPago;
        public static Int64 EstadoPago = 1;

        public static Int64 IdPrecio;
        public static double PrecioServicio;
        public static double PrecioVenta;
        public static double PrecioCompra;
        public static double PrecioDiario;
        public static double PrecioQuincenal;
        public static double PrecioMensual;
        public static Int64 EstadoPrecio = 1;

        public static Int64 IdDescuento;
        public static Int64 EstadoDescuento = 1;

        public static Int64 IdCategoria;
        public static Int64 EstadoCategoria = 1;

        public static Int64 IdUsuario;
        public static Int64 EstadoUsuario = 1;

        public static Int64 IdRol;
        public static string Rol;
        public static Int64 EstadoRol = 1;

        public static Int64 IdBitacoraLogin;
        public static string NombreEmpleadoSession;
        public static string NombreUsuarioSession;
        public static Int64 IdRolSession;
        public static byte[] Imagen;
   
        public static string Sucursal;

        public static int[,] IdPermiso;
        
        public static string PasswordTemp = "E8965r#B";
        public static string Pass;

        public static Int64 Año;
        public static Int64 Mes;

        public static string Nit = "1056467643";
        public static Int64 IdFactura;
        public static Int64 RangoInicial=100;
        public static Int64 RangoFinal=500;
        public static DateTime FechaLimiteEmision=Convert.ToDateTime("08/12/2020");
        public static string CodigoAutorizacion ="263401900065787";
        public static string LlaveDosificacion = "zZ7Z]xssKqkEf_6K9uH(EcV+%x+u[Cca9T%+_$kiLjT8(zr3T9b5Fx2xG-D+_EBS";

        public static DateTime FechaActual = Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy"));
        public static DateTime FechaInicio;
        public static DateTime FechaFinal;

        public static Int64 nroReporte = 0;
        public static Int64 IdSolicitud = 0;
        public static string RutaReporte = @"C:\Users\Elmarcinho\Desktop\MODALIDAD UPDS\SportLine\Gimnasio.Presentacion\Proyecto.Presentacion\Formulario\RptFactura\";
    }
}
