using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Proyecto.Datos;
using Proyecto.Negocio;


namespace Proyecto.Presentacion.Formulario
{
    public partial class FrmMenu : Form
    {
        CtrlBitacora objCtrlBitacora = new CtrlBitacora();
        RNValidar objRNValidar = new RNValidar();
        int x = 0;
        int y = 0;
        int Lx, Ly, Sw, Sh;
        public FrmMenu()
        {
            InitializeComponent();

            btnCompras.Location = new Point(0, 252);
            btnAsistencia.Location = new Point(0, 283);
            btnPagos.Location = new Point(0, 314);
            btnServicios.Location = new Point(0, 345);
            btnReportes.Location = new Point(0, 376);
            btnConfiguracion.Location = new Point(0, 407);
            pnSubMenuConfig.Location = new Point(71, 439); 

        }
        private void FrmMenu_Load_1(object sender, EventArgs e)
        {
            
            this.PermisoMenu();
            this.CargarUsuarioSession();

        }
        //METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO  TIEMPO DE EJECUCION --------------------------
        private int tolerance = 15;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));

            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);

            region.Exclude(sizeGripRectangle);
            this.pnContenedor.Region = region;
            this.Invalidate();
        }
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {

            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(55, 61, 69));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);

            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }
        //Para mover pantalla con click sostenido
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void pnBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //METODO PARA ABRIR FORMULARIOS DENTRO DEL PANEL
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = pnFormulario.Controls.OfType<MiForm>().FirstOrDefault();//Busca en la colecion el formulario
            //si el formulario/instancia no existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                pnFormulario.Controls.Add(formulario);
                pnFormulario.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                formulario.FormClosed += new FormClosedEventHandler(CloseForms);
            }
            //si el formulario/instancia existe
            else
            {
                formulario.BringToFront();
            }
        }
        public void PermisoMenu()
        {

                if (Utilitarios.Utilitarios.IdRol > 0)
                {

                    for (int x = 0; x < Utilitarios.Utilitarios.IdPermiso.Length/2; x++)
                    {

                        if ((Utilitarios.Utilitarios.IdPermiso[x, 0] == 1
                            && Utilitarios.Utilitarios.IdPermiso[x, 1] == 1)|| 
                            (Utilitarios.Utilitarios.IdPermiso[x, 0] == 2
                            && Utilitarios.Utilitarios.IdPermiso[x, 1] == 1))
                        {
                            btnCliente.Enabled = true;
                        }
                        if ((Utilitarios.Utilitarios.IdPermiso[x, 0] == 3
                            && Utilitarios.Utilitarios.IdPermiso[x, 1] == 1) ||
                            (Utilitarios.Utilitarios.IdPermiso[x, 0] == 4
                            && Utilitarios.Utilitarios.IdPermiso[x, 1] == 1))
                        {
                            btnEmpleado.Enabled = true;
                        }
                        if ((Utilitarios.Utilitarios.IdPermiso[x, 0] == 5
                            && Utilitarios.Utilitarios.IdPermiso[x, 1] == 1) ||
                            (Utilitarios.Utilitarios.IdPermiso[x, 0] == 6
                            && Utilitarios.Utilitarios.IdPermiso[x, 1] == 1))
                        {
                            btnVentas.Enabled = true;
                        }
                        if ((Utilitarios.Utilitarios.IdPermiso[x, 0] == 7
                            && Utilitarios.Utilitarios.IdPermiso[x, 1] == 1) ||
                            (Utilitarios.Utilitarios.IdPermiso[x, 0] == 8
                            && Utilitarios.Utilitarios.IdPermiso[x, 1] == 1) ||
                            (Utilitarios.Utilitarios.IdPermiso[x, 0] == 9
                            && Utilitarios.Utilitarios.IdPermiso[x, 1] == 1))
                        {
                            btnProductos.Enabled = true;
                        }
                        if ((Utilitarios.Utilitarios.IdPermiso[x, 0] == 10
                            && Utilitarios.Utilitarios.IdPermiso[x, 1] == 1) ||
                            (Utilitarios.Utilitarios.IdPermiso[x, 0] == 11
                            && Utilitarios.Utilitarios.IdPermiso[x, 1] == 1) ||
                            (Utilitarios.Utilitarios.IdPermiso[x, 0] == 12
                            && Utilitarios.Utilitarios.IdPermiso[x, 1] == 1))
                        {
                            btnCategoria.Enabled = true;
                        }
                        if ((Utilitarios.Utilitarios.IdPermiso[x, 0] == 13
                           && Utilitarios.Utilitarios.IdPermiso[x, 1] == 1) ||
                           (Utilitarios.Utilitarios.IdPermiso[x, 0] == 14
                           && Utilitarios.Utilitarios.IdPermiso[x, 1] == 1) ||
                           (Utilitarios.Utilitarios.IdPermiso[x, 0] == 15
                           && Utilitarios.Utilitarios.IdPermiso[x, 1] == 1))
                        {
                            btnCompras.Enabled = true;
                        }
                        if ((Utilitarios.Utilitarios.IdPermiso[x, 0] == 16
                           && Utilitarios.Utilitarios.IdPermiso[x, 1] == 1) ||
                           (Utilitarios.Utilitarios.IdPermiso[x, 0] == 17
                           && Utilitarios.Utilitarios.IdPermiso[x, 1] == 1))
                        {
                            btnServicios.Enabled = true;
                        }
                        if ((Utilitarios.Utilitarios.IdPermiso[x, 0] == 18
                           && Utilitarios.Utilitarios.IdPermiso[x, 1] == 1) ||
                           (Utilitarios.Utilitarios.IdPermiso[x, 0] == 19
                           && Utilitarios.Utilitarios.IdPermiso[x, 1] == 1))
                        {
                            btnUsuarios.Enabled = true;
                        }
                        if ((Utilitarios.Utilitarios.IdPermiso[x, 0] == 20
                           && Utilitarios.Utilitarios.IdPermiso[x, 1] == 1) ||
                           (Utilitarios.Utilitarios.IdPermiso[x, 0] == 21
                           && Utilitarios.Utilitarios.IdPermiso[x, 1] == 1) ||
                           (Utilitarios.Utilitarios.IdPermiso[x, 0] == 22
                           && Utilitarios.Utilitarios.IdPermiso[x, 1] == 1))
                        {
                            btnRolPermisos.Enabled = true;
                        }
                        if ((Utilitarios.Utilitarios.IdPermiso[x, 0] == 23
                            && Utilitarios.Utilitarios.IdPermiso[x, 1] == 1))
                        {
                            btnPagos.Enabled = true;
                        }
                        if ((Utilitarios.Utilitarios.IdPermiso[x, 0] == 24
                          && Utilitarios.Utilitarios.IdPermiso[x, 1] == 1))
                        {
                            btnAsistencia.Enabled = true;
                        }
                        if ((Utilitarios.Utilitarios.IdPermiso[x, 0] == 25
                            && Utilitarios.Utilitarios.IdPermiso[x, 1] == 1) ||
                           (Utilitarios.Utilitarios.IdPermiso[x, 0] == 26
                           && Utilitarios.Utilitarios.IdPermiso[x, 1] == 1))
                        {
                            btnReportes.Enabled = true;
                        }
                        if ((Utilitarios.Utilitarios.IdPermiso[x, 0] == 27
                             && Utilitarios.Utilitarios.IdPermiso[x, 1] == 1))
                        {
                            btnEmpresa.Enabled = true;
                        }
                    }
                }
        }
        public void CargarUsuarioSession()
        {
            lbSursal.Text = Utilitarios.Utilitarios.Sucursal;
            lblUsuario.Text = Utilitarios.Utilitarios.NombreEmpleadoSession;
            lblRol.Text = Text = Utilitarios.Utilitarios.Rol;
            if (Utilitarios.Utilitarios.Imagen != null)
            {
                pbcUsuario.Image = objRNValidar.ConvertirImagen(Utilitarios.Utilitarios.Imagen);
            }
        }
        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmListaUsuarioRol>();
            btnUsuarios.BackColor = Color.FromArgb(12, 61, 92);

            if (Application.OpenForms["FrmGestionCliente"] != null)
            {
                if(Application.OpenForms["FrmCliente"]==null)
                { Application.OpenForms["FrmGestionCliente"].Close();}
            }
            if (Application.OpenForms["FrmGestionEmpleado"] != null)
            {
                if (Application.OpenForms["FrmEmpleado"] == null)
                { Application.OpenForms["FrmGestionEmpleado"].Close();}
            }
            if (Application.OpenForms["FrmGestionVenta"] != null)
            {
                if (Application.OpenForms["FrmVentaProducto"] == null)
                { Application.OpenForms["FrmGestionVenta"].Close();}
            }
            if (Application.OpenForms["FrmGestionProducto"] != null)
            {
                if (Application.OpenForms["FrmProducto"] == null)
                { Application.OpenForms["FrmGestionProducto"].Close();}
            }
            if (Application.OpenForms["FrmGestionCategoria"] != null)
            {
                if (Application.OpenForms["FrmCategoria"] == null)
                { Application.OpenForms["FrmGestionCategoria"].Close(); }
            }
            if (Application.OpenForms["FrmGestionCompra"] != null)
            {
                if (Application.OpenForms["FrmCompraProducto"] == null)
                { Application.OpenForms["FrmGestionCompra"].Close(); }
            }
            if (Application.OpenForms["FrmGestionAsistencia"] != null)
            {
                //if (Application.OpenForms["FrmCompraProducto"] == null)
                Application.OpenForms["FrmGestionAsistencia"].Close();
            }
            if (Application.OpenForms["FrmGestionPago"] != null)
            {
                if (Application.OpenForms["FrmPagoCredito"] == null)
                { Application.OpenForms["FrmGestionPago"].Close(); }
            }
            if (Application.OpenForms["FrmGestionServicio"] != null)
            {
                if (Application.OpenForms["FrmServicio"] == null)
                { Application.OpenForms["FrmGestionServicio"].Close(); }
            }
            if (Application.OpenForms["FrmGestionReporte"] != null)
            {
                if (Application.OpenForms["FrmReporte"] == null)
                { Application.OpenForms["FrmGestionReporte"].Close(); }
            }
            if (Application.OpenForms["FrmGestionRolPermiso"] != null)
            {
                if (Application.OpenForms["FrmRol"] == null)
                { Application.OpenForms["FrmGestionRolPermiso"].Close(); }
            }
            if (Application.OpenForms["FrmGestionEmpresa"] != null)
            {
                if (Application.OpenForms["FrmDescuento"] == null)
                { Application.OpenForms["FrmGestionEmpresa"].Close(); }
            }
        }
        private void btnRol_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmGestionRolPermiso>();
            btnRolPermisos.BackColor = Color.FromArgb(12, 61, 92);

            if (Application.OpenForms["FrmGestionCliente"] != null)
            {
                if (Application.OpenForms["FrmCliente"] == null)
                { Application.OpenForms["FrmGestionCliente"].Close(); }
            }
            if (Application.OpenForms["FrmGestionEmpleado"] != null)
            {
                if (Application.OpenForms["FrmEmpleado"] == null)
                { Application.OpenForms["FrmGestionEmpleado"].Close(); }
            }
            if (Application.OpenForms["FrmGestionVenta"] != null)
            {
                if (Application.OpenForms["FrmVentaProducto"] == null)
                { Application.OpenForms["FrmGestionVenta"].Close(); }
            }
            if (Application.OpenForms["FrmGestionProducto"] != null)
            {
                if (Application.OpenForms["FrmProducto"] == null)
                { Application.OpenForms["FrmGestionProducto"].Close(); }
            }
            if (Application.OpenForms["FrmGestionCategoria"] != null)
            {
                if (Application.OpenForms["FrmCategoria"] == null)
                { Application.OpenForms["FrmGestionCategoria"].Close(); }
            }
            if (Application.OpenForms["FrmGestionCompra"] != null)
            {
                if (Application.OpenForms["FrmCompraProducto"] == null)
                { Application.OpenForms["FrmGestionCompra"].Close(); }
            }
            if (Application.OpenForms["FrmGestionAsistencia"] != null)
            {
                //if (Application.OpenForms["FrmCompraProducto"] == null)
                Application.OpenForms["FrmGestionAsistencia"].Close();
            }
            if (Application.OpenForms["FrmGestionPagos"] != null)
            {
                if (Application.OpenForms["FrmPagoCredito"] == null)
                { Application.OpenForms["FrmGestionPago"].Close(); }
            }
            if (Application.OpenForms["FrmGestionServicio"] != null)
            {
                if (Application.OpenForms["FrmServicio"] == null)
                { Application.OpenForms["FrmGestionServicio"].Close(); }
            }
            if (Application.OpenForms["FrmGestionReporte"] != null)
            {
                if (Application.OpenForms["FrmReporte"] == null)
                { Application.OpenForms["FrmGestionReporte"].Close(); }
            }
            if (Application.OpenForms["FrmListaUsuarioRol"] != null)
            {
                if (Application.OpenForms["FrmUsuario"] == null)
                { Application.OpenForms["FrmListaUsuarioRol"].Close(); }
            }
            if (Application.OpenForms["FrmGestionEmpresa"] != null)
            {
                if (Application.OpenForms["FrmDescuento"] == null)
                { Application.OpenForms["FrmGestionEmpresa"].Close(); }
            }
        }
        private void btnEmpresa_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmGestionEmpresa>();
            btnEmpresa.BackColor = Color.FromArgb(12, 61, 92);

            if (Application.OpenForms["FrmGestionCliente"] != null)
            {
                if (Application.OpenForms["FrmCliente"] == null)
                { Application.OpenForms["FrmGestionCliente"].Close(); }
            }
            if (Application.OpenForms["FrmGestionEmpleado"] != null)
            {
                if (Application.OpenForms["FrmEmpleado"] == null)
                { Application.OpenForms["FrmGestionEmpleado"].Close(); }
            }
            if (Application.OpenForms["FrmGestionVenta"] != null)
            {
                if (Application.OpenForms["FrmVentaProducto"] == null)
                { Application.OpenForms["FrmGestionVenta"].Close(); }
            }
            if (Application.OpenForms["FrmGestionProducto"] != null)
            {
                if (Application.OpenForms["FrmProducto"] == null)
                { Application.OpenForms["FrmGestionProducto"].Close(); }
            }
            if (Application.OpenForms["FrmGestionCategoria"] != null)
            {
                if (Application.OpenForms["FrmCategoria"] == null)
                { Application.OpenForms["FrmGestionCategoria"].Close(); }
            }
            if (Application.OpenForms["FrmGestionCompra"] != null)
            {
                if (Application.OpenForms["FrmCompraProducto"] == null)
                { Application.OpenForms["FrmGestionCompra"].Close(); }
            }
            if (Application.OpenForms["FrmGestionAsistencia"] != null)
            {
                //if (Application.OpenForms["FrmCompraProducto"] == null)
                Application.OpenForms["FrmGestionAsistencia"].Close();
            }
            if (Application.OpenForms["FrmGestionPagos"] != null)
            {
                if (Application.OpenForms["FrmPagoCredito"] == null)
                { Application.OpenForms["FrmGestionPago"].Close(); }
            }
            if (Application.OpenForms["FrmGestionServicio"] != null)
            {
                if (Application.OpenForms["FrmServicio"] == null)
                { Application.OpenForms["FrmGestionServicio"].Close(); }
            }
            if (Application.OpenForms["FrmGestionReporte"] != null)
            {
                if (Application.OpenForms["FrmReporte"] == null)
                { Application.OpenForms["FrmGestionReporte"].Close(); }
            }
            if (Application.OpenForms["FrmListaUsuarioRol"] != null)
            {
                if (Application.OpenForms["FrmUsuario"] == null)
                { Application.OpenForms["FrmListaUsuarioRol"].Close(); }
            }
            if (Application.OpenForms["FrmGestionRolPermiso"] != null)
            {
                if (Application.OpenForms["FrmRol"] == null)
                { Application.OpenForms["FrmGestionRolPermiso"].Close(); }
            }
        }
        private void btnCategoria_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmGestionCategoria>();
            btnCategoria.BackColor = Color.FromArgb(12, 61, 92);

            if (Application.OpenForms["FrmGestionCliente"] != null)
            {
                if (Application.OpenForms["FrmCliente"] == null)
                { Application.OpenForms["FrmGestionCliente"].Close(); }
            }
            if (Application.OpenForms["FrmGestionEmpleado"] != null)
            {
                if (Application.OpenForms["FrmEmpleado"] == null)
                { Application.OpenForms["FrmGestionEmpleado"].Close(); }
            }
            if (Application.OpenForms["FrmGestionVenta"] != null)
            {
                if (Application.OpenForms["FrmVentaProducto"] == null)
                { Application.OpenForms["FrmGestionVenta"].Close(); }
            }
            if (Application.OpenForms["FrmGestionProducto"] != null)
            {
                if (Application.OpenForms["FrmProducto"] == null)
                { Application.OpenForms["FrmGestionProducto"].Close(); }
            }
            if (Application.OpenForms["FrmGestionCompra"] != null)
            {
                if (Application.OpenForms["FrmCompraProducto"] == null)
                { Application.OpenForms["FrmGestionCompra"].Close(); }
            }
            if (Application.OpenForms["FrmGestionAsistencia"] != null)
            {
                //if (Application.OpenForms["FrmCompraProducto"] == null)
                Application.OpenForms["FrmGestionAsistencia"].Close();
            }
            if (Application.OpenForms["FrmGestionPago"] != null)
            {
                if (Application.OpenForms["FrmPagoCredito"] == null)
                { Application.OpenForms["FrmGestionPago"].Close(); }
            }
            if (Application.OpenForms["FrmGestionServicio"] != null)
            {
                if (Application.OpenForms["FrmDiscplina"] == null)
                { Application.OpenForms["FrmGestionServicio"].Close(); }
            }
            if (Application.OpenForms["FrmGestionReporte"] != null)
            {
                if (Application.OpenForms["FrmReporte"] == null)
                { Application.OpenForms["FrmGestionReporte"].Close(); }
            }
            if (Application.OpenForms["FrmListaUsuarioRol"] != null)
            {
                if (Application.OpenForms["FrmUsuario"] == null)
                { Application.OpenForms["FrmListaUsuarioRol"].Close(); }
            }
            if (Application.OpenForms["FrmGestionRolPermiso"] != null)
            {
                if (Application.OpenForms["FrmRol"] == null)
                { Application.OpenForms["FrmGestionRolPermiso"].Close(); }
            }
            if (Application.OpenForms["FrmGestionEmpresa"] != null)
            {
                if (Application.OpenForms["FrmDescuento"] == null)
                { Application.OpenForms["FrmGestionEmpresa"].Close(); }
            }
        }
        private void btnCliente_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmGestionCliente>();
            btnCliente.BackColor = Color.FromArgb(12, 61, 92);

            if (Application.OpenForms["FrmGestionEmpleado"] != null)
            {
                if (Application.OpenForms["FrmEmpleado"] == null)
                { Application.OpenForms["FrmGestionEmpleado"].Close(); }
            }
            if (Application.OpenForms["FrmGestionVenta"] != null)
            {
                if (Application.OpenForms["FrmVentaProducto"] == null)
                { Application.OpenForms["FrmGestionVenta"].Close(); }
            }
            if (Application.OpenForms["FrmGestionProducto"] != null)
            {
                if (Application.OpenForms["FrmProducto"] == null)
                { Application.OpenForms["FrmGestionProducto"].Close(); }
            }
            if (Application.OpenForms["FrmGestionCategoria"] != null)
            {
                if (Application.OpenForms["FrmCategoria"] == null)
                { Application.OpenForms["FrmGestionCategoria"].Close(); }
            }
            if (Application.OpenForms["FrmGestionCompra"] != null)
            {
                if (Application.OpenForms["FrmCompraProducto"] == null)
                { Application.OpenForms["FrmGestionCompra"].Close(); }
            }
            if (Application.OpenForms["FrmGestionAsistencia"] != null)
            {
                //if (Application.OpenForms["FrmCompraProducto"] == null)
                 Application.OpenForms["FrmGestionAsistencia"].Close(); 
            }
            if (Application.OpenForms["FrmGestionPago"] != null)
            {
                if (Application.OpenForms["FrmPagoCredito"] == null)
                { Application.OpenForms["FrmGestionPago"].Close(); }
            }
            if (Application.OpenForms["FrmGestionServicio"] != null)
            {
                if (Application.OpenForms["FrmServicio"] == null)
                { Application.OpenForms["FrmGestionServicio"].Close(); }
            }
            if (Application.OpenForms["FrmGestionReporte"] != null)
            {
                if (Application.OpenForms["FrmReporte"] == null)
                { Application.OpenForms["FrmGestionReporte"].Close(); }
            }
            if (Application.OpenForms["FrmListaUsuarioRol"] != null)
            {
                if (Application.OpenForms["FrmUsuario"] == null)
                { Application.OpenForms["FrmListaUsuarioRol"].Close(); }
            }
            if (Application.OpenForms["FrmGestionRolPermiso"] != null)
            {
                if (Application.OpenForms["FrmRol"] == null)
                { Application.OpenForms["FrmGestionRolPermiso"].Close(); }
            }
            if (Application.OpenForms["FrmGestionEmpresa"] != null)
            {
                if (Application.OpenForms["FrmDescuento"] == null)
                { Application.OpenForms["FrmGestionEmpresa"].Close(); }
            }
            if (x == 1)
            { x = 1; }
            else { x = 0; }
            if (y == 1)
            { y = 1; }
            else { y = 0; }
        }
        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmGestionEmpleado>();
            btnEmpleado.BackColor = Color.FromArgb(12, 61, 92);

            if (Application.OpenForms["FrmGestionCliente"] != null)
            {
                if (Application.OpenForms["FrmCliente"] == null)
                { Application.OpenForms["FrmGestionCliente"].Close(); }
            }
            if (Application.OpenForms["FrmGestionVenta"] != null)
            {
                if (Application.OpenForms["FrmVentaProducto"] == null)
                { Application.OpenForms["FrmGestionVenta"].Close(); }
            }
            if (Application.OpenForms["FrmGestionProducto"] != null)
            {
                if (Application.OpenForms["FrmProducto"] == null)
                { Application.OpenForms["FrmGestionProducto"].Close(); }
            }
            if (Application.OpenForms["FrmGestionCategoria"] != null)
            {
                if (Application.OpenForms["FrmCategoria"] == null)
                { Application.OpenForms["FrmGestionCategoria"].Close(); }
            }
            if (Application.OpenForms["FrmGestionCompra"] != null)
            {
                if (Application.OpenForms["FrmCompraProducto"] == null)
                { Application.OpenForms["FrmGestionCompra"].Close(); }
            }
            if (Application.OpenForms["FrmGestionAsistencia"] != null)
            {
                //if (Application.OpenForms["FrmCompraProducto"] == null)
                Application.OpenForms["FrmGestionAsistencia"].Close();
            }
            if (Application.OpenForms["FrmGestionPago"] != null)
            {
                if (Application.OpenForms["FrmPagoCredito"] == null)
                { Application.OpenForms["FrmGestionPago"].Close(); }
            }
            if (Application.OpenForms["FrmGestionServicio"] != null)
            {
                if (Application.OpenForms["FrmServicio"] == null)
                { Application.OpenForms["FrmGestionServicio"].Close(); }
            }
            if (Application.OpenForms["FrmGestionReporte"] != null)
            {
                if (Application.OpenForms["FrmReporte"] == null)
                { Application.OpenForms["FrmGestionReporte"].Close(); }
            }
            if (Application.OpenForms["FrmListaUsuarioRol"] != null)
            {
                if (Application.OpenForms["FrmUsuario"] == null)
                { Application.OpenForms["FrmListaUsuarioRol"].Close(); }
            }
            if (Application.OpenForms["FrmGestionRolPermiso"] != null)
            {
                if (Application.OpenForms["FrmRol"] == null)
                { Application.OpenForms["FrmGestionRolPermiso"].Close(); }
            }
            if (Application.OpenForms["FrmGestionEmpresa"] != null)
            {
                if (Application.OpenForms["FrmDescuento"] == null)
                { Application.OpenForms["FrmGestionEmpresa"].Close(); }
            }
            if (x == 1)
            { x = 1; }
            else { x = 0; }
            if (y == 1)
            { y = 1; }
            else { y = 0; }
        }
        private void btnVentas_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmGestionVenta>();
            btnVentas.BackColor = Color.FromArgb(12, 61, 92);

            if (Application.OpenForms["FrmGestionCliente"] != null)
            {
                if (Application.OpenForms["FrmCliente"] == null)
                { Application.OpenForms["FrmGestionCliente"].Close(); }
            }
            if (Application.OpenForms["FrmGestionEmpleado"] != null)
            {
                if (Application.OpenForms["FrmEmpleado"] == null)
                { Application.OpenForms["FrmGestionEmpleado"].Close(); }
            }
            if (Application.OpenForms["FrmGestionProducto"] != null)
            {
                if (Application.OpenForms["FrmProducto"] == null)
                { Application.OpenForms["FrmGestionProducto"].Close(); }
            }
            if (Application.OpenForms["FrmGestionCategoria"] != null)
            {
                if (Application.OpenForms["FrmCategoria"] == null)
                { Application.OpenForms["FrmGestionCategoria"].Close(); }
            }
            if (Application.OpenForms["FrmGestionCompra"] != null)
            {
                if (Application.OpenForms["FrmCompraProducto"] == null)
                { Application.OpenForms["FrmGestionCompra"].Close(); }
            }
            if (Application.OpenForms["FrmGestionAsistencia"] != null)
            {
                //if (Application.OpenForms["FrmCompraProducto"] == null)
                Application.OpenForms["FrmGestionAsistencia"].Close();
            }
            if (Application.OpenForms["FrmGestionPago"] != null)
            {
                if (Application.OpenForms["FrmPagoCredito"] == null)
                { Application.OpenForms["FrmGestionPago"].Close(); }
            }
            if (Application.OpenForms["FrmGestionServicio"] != null)
            {
                if (Application.OpenForms["FrmServicio"] == null)
                { Application.OpenForms["FrmGestionServicio"].Close(); }
            }
            if (Application.OpenForms["FrmGestionReporte"] != null)
            {
                if (Application.OpenForms["FrmReporte"] == null)
                { Application.OpenForms["FrmGestionReporte"].Close(); }
            }
            if (Application.OpenForms["FrmListaUsuarioRol"] != null)
            {
                if (Application.OpenForms["FrmUsuario"] == null)
                { Application.OpenForms["FrmListaUsuarioRol"].Close(); }
            }
            if (Application.OpenForms["FrmGestionRolPermiso"] != null)
            {
                if (Application.OpenForms["FrmRol"] == null)
                { Application.OpenForms["FrmGestionRolPermiso"].Close(); }
            }
            if (Application.OpenForms["FrmGestionEmpresa"] != null)
            {
                if (Application.OpenForms["FrmDescuento"] == null)
                { Application.OpenForms["FrmGestionEmpresa"].Close(); }
            }
            if (x == 1)
            { x = 1; }
            else { x = 0; }
            if (y == 1)
            { y = 1; }
            else { y = 0; }

        }
        private void btnAlmacen_Click(object sender, EventArgs e)
        {
            if (pnMenuVertical.Width == 70)
            {
                pnMenuVertical.Width = 250;
            }

            if (x == 0 && btnAlmacen.BackColor != Color.FromArgb(12, 61, 92))
            {
                pnSubMenuAlmacen.Visible = true;
                btnAlmacen.BackColor = Color.FromArgb(12, 61, 92);
                btnCompras.Location = new Point(0, 306);
                btnAsistencia.Location = new Point(0, 338);
                btnPagos.Location = new Point(0, 369);
                btnServicios.Location = new Point(0, 401);
                btnReportes.Location = new Point(0, 432);
                btnConfiguracion.Location = new Point(0, 463);
                pnSubMenuConfig.Location = new Point(71, 495);
                x = 1;
            }
            else if (x > 0)
            {

                if ((Application.OpenForms["FrmGestionProducto"] != null) && (Application.OpenForms["FrmProducto"] == null)&&(Application.OpenForms["FrmCategoria"] == null))
                {
                        Application.OpenForms["FrmGestionProducto"].Close();
                        btnProductos.BackColor = Color.FromArgb(16, 145, 142);
                        btnCategoria.BackColor = Color.FromArgb(16, 145, 142);
                        btnAlmacen.BackColor = Color.FromArgb(16, 145, 142);
                        pnSubMenuAlmacen.Visible = false;
                        btnCompras.Location = new Point(0, 252);
                        btnAsistencia.Location = new Point(0, 283);
                        btnPagos.Location = new Point(0, 314);
                        btnServicios.Location = new Point(0, 345);
                        btnReportes.Location = new Point(0, 376);
                        btnConfiguracion.Location = new Point(0, 407);
                        pnSubMenuConfig.Location = new Point(71, 439);

                }
                if ((Application.OpenForms["FrmGestionCategoria"] != null)&&(Application.OpenForms["FrmCategoria"] == null)&&(Application.OpenForms["FrmProducto"] == null))
                { 
                        Application.OpenForms["FrmGestionCategoria"].Close();
                        btnProductos.BackColor = Color.FromArgb(16, 145, 142);
                        btnCategoria.BackColor = Color.FromArgb(16, 145, 142);
                        btnAlmacen.BackColor = Color.FromArgb(16, 145, 142);
                        pnSubMenuAlmacen.Visible = false;
                        btnCompras.Location = new Point(0, 252);
                        btnAsistencia.Location = new Point(0, 283);
                        btnPagos.Location = new Point(0, 314);
                        btnServicios.Location = new Point(0, 345);
                        btnReportes.Location = new Point(0, 376);
                        btnConfiguracion.Location = new Point(0, 407);
                        pnSubMenuConfig.Location = new Point(71, 439);
                 
                }
                if((Application.OpenForms["FrmGestionProducto"] == null)&&(Application.OpenForms["FrmGestionCategoria"] == null))
                {
                    btnProductos.BackColor = Color.FromArgb(16, 145, 142);
                    btnCategoria.BackColor = Color.FromArgb(16, 145, 142);
                    btnAlmacen.BackColor = Color.FromArgb(16, 145, 142);
                    pnSubMenuAlmacen.Visible = false;
                    btnCompras.Location = new Point(0, 252);
                    btnAsistencia.Location = new Point(0, 283);
                    btnPagos.Location = new Point(0, 314);
                    btnServicios.Location = new Point(0, 345);
                    btnReportes.Location = new Point(0, 376);
                    btnConfiguracion.Location = new Point(0, 407);
                    pnSubMenuConfig.Location = new Point(71, 439);
                    x = 0;
                    return;
                }
                x = 1;
            }
        }
        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            if (pnMenuVertical.Width == 70 && btnConfiguracion.BackColor != Color.FromArgb(12, 61, 92))
            {
                pnMenuVertical.Width = 250;
            }
  
            if (y == 0 && (btnConfiguracion.BackColor != Color.FromArgb(12, 61, 92)))
            {
                pnSubMenuConfig.Visible = true;
                btnConfiguracion.BackColor = Color.FromArgb(12, 61, 92);
                y = 1;
            }
            else if (y > 0)
            {
               
                if ((Application.OpenForms["FrmListaUsuarioRol"] != null)&&(Application.OpenForms["FrmUsuario"] == null)&&(Application.OpenForms["FrmRol"] == null))
                {
                   Application.OpenForms["FrmListaUsuarioRol"].Close();
                   pnSubMenuConfig.Visible = false;
                   btnConfiguracion.BackColor = Color.FromArgb(16, 145, 142);
                    return;
                }
                if ((Application.OpenForms["FrmGestionRolPermiso"] != null) && (Application.OpenForms["FrmRol"] == null)&&(Application.OpenForms["FrmUsuario"] == null))
                {
                   Application.OpenForms["FrmGestionRolPermiso"].Close();
                    pnSubMenuConfig.Visible = false;
                    btnConfiguracion.BackColor = Color.FromArgb(16, 145, 142);
                    return;
                }
                if ((Application.OpenForms["FrmListaUsuarioRol"] == null) && (Application.OpenForms["FrmGestionRolPermiso"] == null))
                {
                    pnSubMenuConfig.Visible = false;
                    btnConfiguracion.BackColor = Color.FromArgb(16, 145, 142);
                    y = 0;
                    return;
                }
                y = 1;
            }
            else
            {
                if ((Application.OpenForms["FrmListaUsuarioRol"] != null) && (Application.OpenForms["FrmUsuario"] == null) && (Application.OpenForms["FrmRol"] == null))
                {
                    Application.OpenForms["FrmListaUsuarioRol"].Close();
                    pnSubMenuConfig.Visible = false;
                    btnConfiguracion.BackColor = Color.FromArgb(16, 145, 142);
                    return;
                }
                if ((Application.OpenForms["FrmGestionRolPermiso"] != null) && (Application.OpenForms["FrmRol"] == null) && (Application.OpenForms["FrmUsuario"] == null))
                {
                    Application.OpenForms["FrmGestionRolPermiso"].Close();
                    pnSubMenuConfig.Visible = false;
                    btnConfiguracion.BackColor = Color.FromArgb(16, 145, 142);
                    return;
                }
                pnSubMenuConfig.Visible = false;
                btnConfiguracion.BackColor = Color.FromArgb(16, 145, 142);
                y = 0;
            }

        }
        private void btnProductos_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmGestionProducto>();
            btnProductos.BackColor = Color.FromArgb(12, 61, 92);

            if (Application.OpenForms["FrmGestionCliente"] != null)
            {
                if (Application.OpenForms["FrmCliente"] == null)
                { Application.OpenForms["FrmGestionCliente"].Close(); }
            }
            if (Application.OpenForms["FrmGestionEmpleado"] != null)
            {
                if (Application.OpenForms["FrmEmpleado"] == null)
                { Application.OpenForms["FrmGestionEmpleado"].Close(); }
            }
            if (Application.OpenForms["FrmGestionVenta"] != null)
            {
                if (Application.OpenForms["FrmVentaProducto"] == null)
                { Application.OpenForms["FrmGestionVenta"].Close(); }
            }
            if (Application.OpenForms["FrmGestionCategoria"] != null)
            {
                if (Application.OpenForms["FrmCategoria"] == null)
                { Application.OpenForms["FrmGestionCategoria"].Close(); }
            }
            if (Application.OpenForms["FrmGestionCompra"] != null)
            {
                if (Application.OpenForms["FrmCompraProducto"] == null)
                { Application.OpenForms["FrmGestionCompra"].Close(); }
            }
            if (Application.OpenForms["FrmGestionAsistencia"] != null)
            {
                //if (Application.OpenForms["FrmCompraProducto"] == null)
                Application.OpenForms["FrmGestionAsistencia"].Close();
            }
            if (Application.OpenForms["FrmGestionPago"] != null)
            {
                if (Application.OpenForms["FrmPagoCredito"] == null)
                { Application.OpenForms["FrmGestionPago"].Close(); }
            }
            if (Application.OpenForms["FrmGestionServicio"] != null)
            {
                if (Application.OpenForms["FrmServicio"] == null)
                { Application.OpenForms["FrmGestionServicio"].Close(); }
            }
            if (Application.OpenForms["FrmGestionReporte"] != null)
            {
                if (Application.OpenForms["FrmReporte"] == null)
                { Application.OpenForms["FrmGestionReporte"].Close(); }
            }
            if (Application.OpenForms["FrmListaUsuarioRol"] != null)
            {
                if (Application.OpenForms["FrmUsuario"] == null)
                { Application.OpenForms["FrmListaUsuarioRol"].Close(); }
            }
            if (Application.OpenForms["FrmGestionRolPermiso"] != null)
            {
                if (Application.OpenForms["FrmRol"] == null)
                { Application.OpenForms["FrmGestionRolPermiso"].Close(); }
            }
            if (Application.OpenForms["FrmGestionEmpresa"] != null)
            {
                if (Application.OpenForms["FrmDescuento"] == null)
                { Application.OpenForms["FrmGestionEmpresa"].Close(); }
            }
        }
        private void btnAsistencia_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmGestionAsistencia>();
            btnAsistencia.BackColor = Color.FromArgb(12, 61, 92);

            if (Application.OpenForms["FrmGestionCliente"] != null)
            {
                if (Application.OpenForms["FrmCliente"] == null)
                { Application.OpenForms["FrmGestionCliente"].Close(); }
            }
            if (Application.OpenForms["FrmGestionEmpleado"] != null)
            {
                if (Application.OpenForms["FrmEmpleado"] == null)
                { Application.OpenForms["FrmGestionEmpleado"].Close(); }
            }
            if (Application.OpenForms["FrmGestionVenta"] != null)
            {
                if (Application.OpenForms["FrmVentaProducto"] == null)
                { Application.OpenForms["FrmGestionVenta"].Close(); }
            }
            if (Application.OpenForms["FrmGestionProducto"] != null)
            {
                if (Application.OpenForms["FrmProducto"] == null)
                { Application.OpenForms["FrmGestionProducto"].Close(); }
            }
            if (Application.OpenForms["FrmGestionCategoria"] != null)
            {
                if (Application.OpenForms["FrmCategoria"] == null)
                { Application.OpenForms["FrmGestionCategoria"].Close(); }
            }
            if (Application.OpenForms["FrmGestionCompra"] != null)
            {
                if (Application.OpenForms["FrmCompraProducto"] == null)
                { Application.OpenForms["FrmGestionCompra"].Close(); }
            }
            if (Application.OpenForms["FrmGestionPago"] != null)
            {
                if (Application.OpenForms["FrmPagoCredito"] == null)
                { Application.OpenForms["FrmGestionPago"].Close(); }
            }
            if (Application.OpenForms["FrmGestionServicio"] != null)
            {
                if (Application.OpenForms["FrmServicio"] == null)
                { Application.OpenForms["FrmGestionServicio"].Close(); }
            }
            if (Application.OpenForms["FrmGestionReporte"] != null)
            {
                if (Application.OpenForms["FrmReporte"] == null)
                { Application.OpenForms["FrmGestionReporte"].Close(); }
            }
            if (Application.OpenForms["FrmListaUsuarioRol"] != null)
            {
                if (Application.OpenForms["FrmUsuario"] == null)
                { Application.OpenForms["FrmListaUsuarioRol"].Close(); }
            }
            if (Application.OpenForms["FrmGestionRolPermiso"] != null)
            {
                if (Application.OpenForms["FrmRol"] == null)
                { Application.OpenForms["FrmGestionRolPermiso"].Close(); }
            }
            if (Application.OpenForms["FrmGestionEmpresa"] != null)
            {
                if (Application.OpenForms["FrmDescuento"] == null)
                { Application.OpenForms["FrmGestionEmpresa"].Close(); }
            }
            if (x == 1)
            { x = 1; }
            else { x = 0; }
            if (y == 1)
            { y = 1; }
            else { y = 0; }
        }
        private void btnPagos_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmGestionPago>();
            btnPagos.BackColor = Color.FromArgb(12, 61, 92);

            if (Application.OpenForms["FrmGestionCliente"] != null)
            {
                if (Application.OpenForms["FrmCliente"] == null)
                { Application.OpenForms["FrmGestionCliente"].Close(); }
            }
            if (Application.OpenForms["FrmGestionEmpleado"] != null)
            {
                if (Application.OpenForms["FrmEmpleado"] == null)
                { Application.OpenForms["FrmGestionEmpleado"].Close(); }
            }
            if (Application.OpenForms["FrmGestionVenta"] != null)
            {
                if (Application.OpenForms["FrmVentaProducto"] == null)
                { Application.OpenForms["FrmGestionVenta"].Close(); }
            }
            if (Application.OpenForms["FrmGestionProducto"] != null)
            {
                if (Application.OpenForms["FrmProducto"] == null)
                { Application.OpenForms["FrmGestionProducto"].Close(); }
            }
            if (Application.OpenForms["FrmGestionCategoria"] != null)
            {
                if (Application.OpenForms["FrmCategoria"] == null)
                { Application.OpenForms["FrmGestionCategoria"].Close(); }
            }
            if (Application.OpenForms["FrmGestionCompra"] != null)
            {
                if (Application.OpenForms["FrmCompraProducto"] == null)
                { Application.OpenForms["FrmGestionCompra"].Close(); }
            }
            if (Application.OpenForms["FrmGestionAsistencia"] != null)
            {
                //if (Application.OpenForms["FrmCompraProducto"] == null)
                Application.OpenForms["FrmGestionAsistencia"].Close();
            }
            if (Application.OpenForms["FrmGestionServicio"] != null)
            {
                if (Application.OpenForms["FrmServicio"] == null)
                { Application.OpenForms["FrmGestionServicio"].Close(); }
            }
            if (Application.OpenForms["FrmGestionReporte"] != null)
            {
                if (Application.OpenForms["FrmReporte"] == null)
                { Application.OpenForms["FrmGestionReporte"].Close(); }
            }
            if (Application.OpenForms["FrmListaUsuarioRol"] != null)
            {
                if (Application.OpenForms["FrmUsuario"] == null)
                { Application.OpenForms["FrmListaUsuarioRol"].Close(); }
            }
            if (Application.OpenForms["FrmGestionRolPermiso"] != null)
            {
                if (Application.OpenForms["FrmRol"] == null)
                { Application.OpenForms["FrmGestionRolPermiso"].Close(); }
            }
            if (Application.OpenForms["FrmGestionEmpresa"] != null)
            {
                if (Application.OpenForms["FrmDescuento"] == null)
                { Application.OpenForms["FrmGestionEmpresa"].Close(); }
            }
            if (x == 1)
            { x = 1; }
            else { x = 0; }
            if (y == 1)
            { y = 1; }
            else { y = 0; }
        }
        private void btnServicios_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmGestionServicio>();
            btnServicios.BackColor = Color.FromArgb(12, 61, 92);

            if (Application.OpenForms["FrmGestionCliente"] != null)
            {
                if (Application.OpenForms["FrmCliente"] == null)
                { Application.OpenForms["FrmGestionCliente"].Close(); }
            }
            if (Application.OpenForms["FrmGestionEmpleado"] != null)
            {
                if (Application.OpenForms["FrmEmpleado"] == null)
                { Application.OpenForms["FrmGestionEmpleado"].Close(); }
            }
            if (Application.OpenForms["FrmGestionVenta"] != null)
            {
                if (Application.OpenForms["FrmVentaProducto"] == null)
                { Application.OpenForms["FrmGestionVenta"].Close(); }
            }
            if (Application.OpenForms["FrmGestionProducto"] != null)
            {
                if (Application.OpenForms["FrmProducto"] == null)
                { Application.OpenForms["FrmGestionProducto"].Close(); }
            }
            if (Application.OpenForms["FrmGestionCategoria"] != null)
            {
                if (Application.OpenForms["FrmCategoria"] == null)
                { Application.OpenForms["FrmGestionCategoria"].Close(); }
            }
            if (Application.OpenForms["FrmGestionCompra"] != null)
            {
                if (Application.OpenForms["FrmCompraProducto"] == null)
                { Application.OpenForms["FrmGestionCompra"].Close(); }
            }
            if (Application.OpenForms["FrmGestionAsistencia"] != null)
            {
                //if (Application.OpenForms["FrmCompraProducto"] == null)
                Application.OpenForms["FrmGestionAsistencia"].Close();
            }
            if (Application.OpenForms["FrmGestionPago"] != null)
            {
                if (Application.OpenForms["FrmPagoCredito"] == null)
                { Application.OpenForms["FrmGestionPago"].Close(); }
            }
            if (Application.OpenForms["FrmGestionReporte"] != null)
            {
                if (Application.OpenForms["FrmReporte"] == null)
                { Application.OpenForms["FrmGestionReporte"].Close(); }
            }
            if (Application.OpenForms["FrmListaUsuarioRol"] != null)
            {
                if (Application.OpenForms["FrmUsuario"] == null)
                { Application.OpenForms["FrmListaUsuarioRol"].Close(); }
            }
            if (Application.OpenForms["FrmGestionRolPermiso"] != null)
            {
                if (Application.OpenForms["FrmRol"] == null)
                { Application.OpenForms["FrmGestionRolPermiso"].Close(); }
            }
            if (Application.OpenForms["FrmGestionEmpresa"] != null)
            {
                if (Application.OpenForms["FrmDescuento"] == null)
                { Application.OpenForms["FrmGestionEmpresa"].Close(); }
            }
            if (x == 1)
            { x = 1; }
            else { x = 0; }
            if (y == 1)
            { y = 1; }
            else { y = 0; }
        }
        private void btnReportes_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmGestionReporte>();
            btnReportes.BackColor = Color.FromArgb(12, 61, 92);

            if (Application.OpenForms["FrmGestionCliente"] != null)
            {
                if (Application.OpenForms["FrmCliente"] == null)
                { Application.OpenForms["FrmGestionCliente"].Close(); }
            }
            if (Application.OpenForms["FrmGestionEmpleado"] != null)
            {
                if (Application.OpenForms["FrmEmpleado"] == null)
                { Application.OpenForms["FrmGestionEmpleado"].Close(); }
            }
            if (Application.OpenForms["FrmGestionVenta"] != null)
            {
                if (Application.OpenForms["FrmVentaProducto"] == null)
                { Application.OpenForms["FrmGestionVenta"].Close(); }
            }
            if (Application.OpenForms["FrmGestionProducto"] != null)
            {
                if (Application.OpenForms["FrmProducto"] == null)
                { Application.OpenForms["FrmGestionProducto"].Close(); }
            }
            if (Application.OpenForms["FrmGestionCategoria"] != null)
            {
                if (Application.OpenForms["FrmCategoria"] == null)
                { Application.OpenForms["FrmGestionCategoria"].Close(); }
            }
            if (Application.OpenForms["FrmGestionCompra"] != null)
            {
                if (Application.OpenForms["FrmCompraProducto"] == null)
                { Application.OpenForms["FrmGestionCompra"].Close(); }
            }
            if (Application.OpenForms["FrmGestionAsistencia"] != null)
            {
                //if (Application.OpenForms["FrmCompraProducto"] == null)
                Application.OpenForms["FrmGestionAsistencia"].Close();
            }
            if (Application.OpenForms["FrmGestionPago"] != null)
            {
                if (Application.OpenForms["FrmPagoCredito"] == null)
                { Application.OpenForms["FrmGestionPago"].Close(); }
            }
            if (Application.OpenForms["FrmGestionServicio"] != null)
            {
                if (Application.OpenForms["FrmServicio"] == null)
                { Application.OpenForms["FrmGestionServicio"].Close(); }
            }
            if (Application.OpenForms["FrmListaUsuarioRol"] != null)
            {
                if (Application.OpenForms["FrmUsuario"] == null)
                { Application.OpenForms["FrmListaUsuarioRol"].Close(); }
            }
            if (Application.OpenForms["FrmGestionRolPermiso"] != null)
            {
                if (Application.OpenForms["FrmRol"] == null)
                { Application.OpenForms["FrmGestionRolPermiso"].Close(); }
            }
            if (Application.OpenForms["FrmGestionEmpresa"] != null)
            {
                if (Application.OpenForms["FrmDescuento"] == null)
                { Application.OpenForms["FrmGestionEmpresa"].Close(); }
            }
            if (x == 1)
            { x = 1; }
            else { x = 0; }
            if (y == 1)
            { y = 1; }
            else { y = 0; }
        }
        private void btnCompras_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmGestionCompra>();
            btnCompras.BackColor = Color.FromArgb(12, 61, 92);

            if (Application.OpenForms["FrmGestionCliente"] != null)
            {
                if (Application.OpenForms["FrmCliente"] == null)
                { Application.OpenForms["FrmGestionCliente"].Close(); }
            }
            if (Application.OpenForms["FrmGestionEmpleado"] != null)
            {
                if (Application.OpenForms["FrmEmpleado"] == null)
                { Application.OpenForms["FrmGestionEmpleado"].Close(); }
            }
            if (Application.OpenForms["FrmGestionVenta"] != null)
            {
                if (Application.OpenForms["FrmVentaProducto"] == null)
                { Application.OpenForms["FrmGestionVenta"].Close(); }
            }
            if (Application.OpenForms["FrmGestionProducto"] != null)
            {
                if (Application.OpenForms["FrmProducto"] == null)
                { Application.OpenForms["FrmGestionProducto"].Close(); }
            }
            if (Application.OpenForms["FrmGestionCategoria"] != null)
            {
                if (Application.OpenForms["FrmCategoria"] == null)
                { Application.OpenForms["FrmGestionCategoria"].Close(); }
            }
            if (Application.OpenForms["FrmGestionAsistencia"] != null)
            {
                //if (Application.OpenForms["FrmCompraProducto"] == null)
                Application.OpenForms["FrmGestionAsistencia"].Close();
            }
            if (Application.OpenForms["FrmGestionPago"] != null)
            {
                if (Application.OpenForms["FrmPagoCredito"] == null)
                { Application.OpenForms["FrmGestionPago"].Close(); }
            }
            if (Application.OpenForms["FrmGestionServicio"] != null)
            {
                if (Application.OpenForms["FrmServicio"] == null)
                { Application.OpenForms["FrmGestionServicio"].Close(); }
            }
            if (Application.OpenForms["FrmGestionReporte"] != null)
            {
                if (Application.OpenForms["FrmReporte"] == null)
                { Application.OpenForms["FrmGestionReporte"].Close(); }
            }
            if (Application.OpenForms["FrmListaUsuarioRol"] != null)
            {
                if (Application.OpenForms["FrmUsuario"] == null)
                { Application.OpenForms["FrmListaUsuarioRol"].Close(); }
            }
            if (Application.OpenForms["FrmGestionRolPermiso"] != null)
            {
                if (Application.OpenForms["FrmRol"] == null)
                { Application.OpenForms["FrmGestionRolPermiso"].Close(); }
            }
            if (Application.OpenForms["FrmGestionEmpresa"] != null)
            {
                if (Application.OpenForms["FrmDescuento"] == null)
                { Application.OpenForms["FrmGestionEmpresa"].Close(); }
            }
            if (x == 1)
            { x = 1; }
            else { x = 0; }
            if (y == 1)
            { y = 1; }
            else { y = 0; }
        }
        private void CloseForms(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["FrmGestionCliente"] == null)
            { btnCliente.BackColor = Color.FromArgb(16, 145, 142); }
            if (Application.OpenForms["FrmGestionEmpleado"] == null)
            { btnEmpleado.BackColor = Color.FromArgb(16, 145, 142); }
            if (Application.OpenForms["FrmGestionVenta"] == null)
            { btnVentas.BackColor = Color.FromArgb(16, 145, 142); }
            if (Application.OpenForms["FrmGestionProducto"] == null)
            { btnProductos.BackColor = Color.FromArgb(16, 145, 142); }
            if (Application.OpenForms["FrmGestionCategoria"] == null)
            { btnCategoria.BackColor = Color.FromArgb(16, 145, 142); }
            if (Application.OpenForms["FrmGestionCompra"] == null)
            { btnCompras.BackColor = Color.FromArgb(16, 145, 142); }
            if (Application.OpenForms["FrmGestionAsistencia"] == null)
            { btnAsistencia.BackColor = Color.FromArgb(16, 145, 142); }
            if (Application.OpenForms["FrmGestionPago"] == null)
            { btnPagos.BackColor = Color.FromArgb(16, 145, 142); }
            if (Application.OpenForms["FrmGestionServicio"] == null)
            { btnServicios.BackColor = Color.FromArgb(16, 145, 142); }
            if (Application.OpenForms["FrmRptReporte"] == null)
            { btnReportes.BackColor = Color.FromArgb(16, 145, 142); }
            if (Application.OpenForms["FrmListaUsuarioRol"] == null)
            { btnUsuarios.BackColor = Color.FromArgb(16, 145, 142); }
            if(Application.OpenForms["FrmGestionRolPermiso"] == null)
            { btnRolPermisos.BackColor = Color.FromArgb(16, 145, 142); }
            if (Application.OpenForms["FrmGestionEmpresa"] == null)
            { btnEmpresa.BackColor = Color.FromArgb(16, 145, 142); }
            if (x==1 && btnCategoria.BackColor != Color.FromArgb(16, 145, 142))
            { x = 1; }
            else{ y = 0; }
            if (y == 1 && btnCategoria.BackColor != Color.FromArgb(16, 145, 142))
            { y = 1; }
            else { y = 0; }
        }
        private void pbDesplegar_Click(object sender, EventArgs e)
        {
            if (pnMenuVertical.Width == 250)
            {

                pnMenuVertical.Width = 70;
            }
            else
            {
                pnMenuVertical.Width = 250;
            }
        }
        private void pbIconoCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Salir del Sistema SportLine?", "Sistema de Gestión y Ventas", 
                MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {

              BitacoraLogin objBitacora = new BitacoraLogin();
              objBitacora.IdBitLogin = Utilitarios.Utilitarios.IdBitacoraLogin;
              objBitacora.HoraSalida = TimeSpan.Parse(DateTime.Now.ToString("HH:mm:ss"));
              objCtrlBitacora.ModificarBitacoraLogin(objBitacora);
              Application.Exit();
            }
        }
        private void pbIconoMaximizar_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
            Lx = this.Location.X;
            Ly = this.Location.Y;
            Sw = this.Size.Width;
            Sh = this.Size.Height;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            pbIconoRestaurar.Visible = true;
            pbIconoMaximizar.Visible = false;
        }
        private void pbIconoRestaurar_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Normal;
            this.Size= new Size(Sw, Sh);
            this.Location = new Point(Lx, Ly);
            pbIconoRestaurar.Visible = false;
            pbIconoMaximizar.Visible = true;
        }

        private void pbIconoMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void tmHoraFecha_Tick(object sender, EventArgs e)
        {
            lbHora.Text = DateTime.Now.ToString("HH:mm:ss");
            lbFecha.Text=DateTime.Now.ToLongDateString();
        }
        private void btnCerrarSession_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Estás seguro de Cerrar Session?", "Sistema de Gestión y Ventas",
                MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                if (Application.OpenForms["FrmCliente"] != null)
                {
                    Application.OpenForms["FrmCliente"].Close();
                }
                if (Application.OpenForms["FrmEmpleado"] != null)
                {
                    Application.OpenForms["FrmEmpleado"].Close();
                }
                if (Application.OpenForms["FrmCategoria"] != null)
                {
                    Application.OpenForms["FrmCategoria"].Close();
                }
                if (Application.OpenForms["FrmPagoCredito"] != null)
                {
                    Application.OpenForms["FrmPagoCredito"].Close();
                }
                if (Application.OpenForms["FrmProducto"] != null)
                {
                    Application.OpenForms["FrmProducto"].Close();
                }
                if (Application.OpenForms["FrmServicio"] != null)
                {
                    Application.OpenForms["FrmServicio"].Close();
                }
                if (Application.OpenForms["FrmVentaProducto"] != null)
                {
                    Application.OpenForms["FrmVentaProducto"].Close();
                }
                if (Application.OpenForms["FrmReporte"] != null)
                {
                    Application.OpenForms["FrmReporte"].Close();
                }
                if (Application.OpenForms["FrmRptFactura"] != null)
                {
                    Application.OpenForms["FrmRptFactura"].Close();
                }
                if (Application.OpenForms["FrmInforme"] != null)
                {
                    Application.OpenForms["FrmInforme"].Close();
                }
                if (Application.OpenForms["FrmDescuento"] != null)
                {
                    Application.OpenForms["FrmDescuento"].Close();
                }
                BitacoraLogin objBitacora = new BitacoraLogin();
                objBitacora.IdBitLogin = Utilitarios.Utilitarios.IdBitacoraLogin;
                objBitacora.HoraSalida = TimeSpan.Parse(DateTime.Now.ToString("HH:mm:ss"));
                objCtrlBitacora.ModificarBitacoraLogin(objBitacora);

                this.Close();
                //Application.Exit();
            }
        }

    }
}
