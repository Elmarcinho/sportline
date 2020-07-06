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
    public partial class Form1 : Form
    {
        Utilitarios.EncryptKey objEncrypt = new Utilitarios.EncryptKey();
        CtrlUsuario objCtrlUsuario = new CtrlUsuario();
        CtrlBitacora objCtrlBitacora = new CtrlBitacora();
        RNValidar objRNValidar = new RNValidar();
        int contador;
        public Form1()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtuser.Text != "Usuario" && txtuser.TextLength > 2)
                {
                    if (txtpass.Text != "Contraseña")
                    {
                        Usuario objUsuario = new Usuario();
                        objUsuario.NombreUsuario = txtuser.Text;
                        objUsuario.Contraseña = objEncrypt.EncriptarSHA512(txtpass.Text);
                        if (objCtrlUsuario.ValidarUsuario(objUsuario))
                        {
                            BitacoraLogin objBitacora = new BitacoraLogin();
                            objBitacora.IdBitLogin = objCtrlBitacora.GenerarID();
                            Utilitarios.Utilitarios.IdBitacoraLogin = objBitacora.IdBitLogin;
                            objBitacora.NombreEmpleado = Utilitarios.Utilitarios.NombreEmpleadoSession;
                            objBitacora.NombreUsuario = Utilitarios.Utilitarios.NombreUsuarioSession;
                            objBitacora.FechaIngreso = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                            objBitacora.HoraIngreso = TimeSpan.Parse(DateTime.Now.ToString("HH:mm:ss"));
                            objBitacora.HoraSalida = null;
                            objCtrlBitacora.InsertarBitacoraLogin(objBitacora);
                            FrmMenu FMenu = new FrmMenu();
                            MessageBox.Show("Bienvenido(a) " + Utilitarios.Utilitarios.NombreEmpleadoSession, "Sistema de Ventas");
                            FMenu.Show();
                            FMenu.Text = "Menu Principal";
                            FMenu.FormClosed += CerrarSession;
                            Hide();

                        }
                        else if (contador > 1)
                        { MessageBox.Show("Excedio los intentos maximos. El Sistema se cerrara automaticamente", "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error); this.Close(); }
                        else
                        {
                            msgError("  Nombre de usuario o contraseña incorrectos. \n      Por favor intente nuevamente.");
                            txtpass.Text = "Contraseña";
                            txtpass.UseSystemPasswordChar = false;
                            txtuser.Focus();
                            contador += 1;
                            lbIntentos.Text = "      Intento: " + contador;
                            lbIntentos.Visible = true;
                        }
                    }
                    else if (contador > 1)
                    {
                        MessageBox.Show("Excedio los intentos maximos. El Sistema se cerrara automaticamente", "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error); this.Close();
                    }
                    else
                    {
                        msgError("  Por favor Ingrese su Contraseña.");
                        contador += 1;
                        lbIntentos.Text = "      Intentos: " + contador;
                        lbIntentos.Visible = true;
                    }

                }
                else if (contador > 1)
                { MessageBox.Show("Excedio los intentos maximos. El Sistema se cerrara automaticamente", "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error); this.Close(); }

                else
                {
                    msgError("  Por favor ingreso su nombre de Usuario.");
                    contador += 1;
                    lbIntentos.Text = "      Intentos: " + contador;
                    lbIntentos.Visible = true;
                }
            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message, "Sistema de Gestión y Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void msgError(string msg)
        {
            lbErrorMensaje.Text = "    " + msg;
            lbErrorMensaje.Visible = true;
        }
        private void CerrarSession(object sender, FormClosedEventArgs e)
        {
            txtpass.Text = "Contraseña";
            txtpass.UseSystemPasswordChar = false;
            txtuser.Text = "Usuario";
            lbErrorMensaje.Visible = false;
            lbIntentos.Visible = false;
            Show();
            btnlogin.Focus();
        }
        private void txtuser_Enter(object sender, EventArgs e)
        {
            if (txtuser.Text == "Usuario")
            {
                txtuser.Text = "";
                txtuser.ForeColor = Color.Transparent;
            }
        }
        private void txtuser_Leave(object sender, EventArgs e)
        {
            if (txtuser.Text == "")
            {
                txtuser.Text = "Usuario";
                txtuser.ForeColor = Color.Transparent;
            }
        }
        private void txtpass_Enter(object sender, EventArgs e)
        {
            if (txtpass.Text == "Contraseña")
            {
                txtpass.Text = "";
                txtpass.ForeColor = Color.Transparent;
                txtpass.UseSystemPasswordChar = true;
            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (txtpass.Text == "")
            {
                txtpass.Text = "Contraseña";
                txtpass.ForeColor = Color.Transparent;
                txtpass.UseSystemPasswordChar = false;
            }
        }
        private void txtpass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnlogin.PerformClick();
            }
        }
        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

    }
}
