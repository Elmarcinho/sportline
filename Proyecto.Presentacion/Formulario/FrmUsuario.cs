using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto.Datos;
using Proyecto.Negocio;


namespace Proyecto.Presentacion.Formulario
{
    public partial class FrmUsuario : Form
    {
        CtrlUsuario objCtrlUsuario = new CtrlUsuario();
        Utilitarios.EncryptKey objEncrypt = new Utilitarios.EncryptKey();
        RNValidar objRNValidar = new RNValidar();
        private FrmListaEmpleado form = null;
        public FrmUsuario()
        {
            InitializeComponent();
           
        }
        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            this.CargarComboRol();
            this.CargarComboEstadoUsuario();
            txtContraseña.UseSystemPasswordChar = true;
            txtRContraseña.UseSystemPasswordChar = true;
        }
        private void CargarComboEstadoUsuario()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("IdEstadoUsuario");
            dt.Columns.Add("EstadoUsuario");
            dt.AcceptChanges();

            DataRow dr0 = dt.NewRow();
            dr0[0] = "1";
            dr0[1] = "Activo";

            DataRow dr1 = dt.NewRow();
            dr1[0] = "2";
            dr1[1] = "Inactivo";

            dt.Rows.Add(dr0);
            dt.Rows.Add(dr1);
            dt.AcceptChanges();

            this.cbEstadoUsuario.DisplayMember = "EstadoUsuario";
            this.cbEstadoUsuario.ValueMember = "IdEstadoUsuario";
            this.cbEstadoUsuario.DataSource = dt;
        }
        private void CargarComboRol()
        {
            Negocio.RNLista.RNRol objRNRol = new Negocio.RNLista.RNRol();
            var ObjRol= objRNRol.TraerRol(0);

            DataTable dta = new DataTable();
            dta.Columns.Add(new DataColumn("IdRol"));
            dta.Columns.Add(new DataColumn("NombreRol"));

            DataRow dr = dta.NewRow();
            dr["IdRol"] = 0;
            dr["NombreRol"] = "--- Seleccionar ---";
            dta.Rows.Add(dr);

            foreach (var item in ObjRol)
            {
                DataRow drColomn = dta.NewRow();
                drColomn["IdRol"] = item.IdRol;
                drColomn["NombreRol"] = item.NombreRol;
                dta.Rows.Add(drColomn);
            }
            this.cbRol.DataSource = dta;
            this.cbRol.DisplayMember = "NombreRol";
            this.cbRol.ValueMember = "IdRol";

        }
        private void btnGuardarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                if (objRNValidar.txtVacio(txtEmpleado, txtUsuario, txtContraseña) == true)
                {
                    if (Convert.ToInt64(cbRol.SelectedValue) != 0)
                    {
                        if (txtContraseña.Text == txtRContraseña.Text)
                        {
                            if (objRNValidar.Complejidad(txtContraseña))
                            {
                                if (Utilitarios.Utilitarios.Evento == 0)
                                {
                                    Usuario objUsuario = new Usuario();
                                    objUsuario.IdUsuario = objCtrlUsuario.GenerarID();
                                    objUsuario.NombreUsuario = txtUsuario.Text;
                                    objUsuario.Contraseña = objEncrypt.EncriptarSHA512(txtContraseña.Text);
                                    objUsuario.IdRol = long.Parse(this.cbRol.SelectedValue.ToString());
                                    objUsuario.IdPersona = Utilitarios.Utilitarios.IdEmpleado;
                                    objUsuario.EstadoUsuario = Convert.ToInt32(Utilitarios.Utilitarios.EstadoUsuario);

                                    if (objCtrlUsuario.InsertarUsuario(objUsuario))
                                    {
                                        MessageBox.Show("Usuario Registrado con éxito!","Sistema de Ventas");
                                        Utilitarios.Utilitarios.NombreEmpleado = null;
                                        this.Close();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Error en el registro de Usuario.","Sistema de Ventas",MessageBoxButtons.OK,MessageBoxIcon.Error);
                                    }
                                }
                                else
                                {
                                    Usuario objUsuario = new Usuario();
                                    objUsuario.IdUsuario = Utilitarios.Utilitarios.IdUsuario;
                                    objUsuario.NombreUsuario = txtUsuario.Text;
                                    if (txtContraseña.Text != Utilitarios.Utilitarios.PasswordTemp)
                                    { objUsuario.Contraseña = objEncrypt.EncriptarSHA512(txtContraseña.Text); }
                                    else { objUsuario.Contraseña = Utilitarios.Utilitarios.Pass; }
                                    objUsuario.IdRol = long.Parse(this.cbRol.SelectedValue.ToString());
                                    objUsuario.EstadoUsuario = Convert.ToInt32(this.cbEstadoUsuario.SelectedValue.ToString());

                                    if (objCtrlUsuario.ModificarUsuario(objUsuario))
                                    {
                                        MessageBox.Show("Usuario Actualizado con éxito!","Sistema de Ventas");
                                        this.Close();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Error en la actualizacion de Usuario.","Sistema de Ventas",MessageBoxButtons.OK,MessageBoxIcon.Error);
                                    }
                                }
                            }
                        }
                        else { MessageBox.Show("La contraseña no coinciden","Sistema de Ventas",MessageBoxButtons.OK,MessageBoxIcon.Warning); }
                    }
                    else { MessageBox.Show("Por favor seleccione un Rol","Sistema de Ventas",MessageBoxButtons.OK,MessageBoxIcon.Warning); }
                }
            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message,"Sistema de Ventas",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void btnBuscarEmpleado_Click(object sender, EventArgs e)
        {
            FrmListaEmpleado frm = FormInstance;
            frm.Show();
            frm.FormClosed += new FormClosedEventHandler(form2_FormClosed);//Para actualizar Grilla al cerrar un formulario
        }
        private void form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.txtEmpleado.Text = Utilitarios.Utilitarios.NombreEmpleado;
        }
        private void btnCerrarUsuario_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            objRNValidar.Letras(e,txtUsuario);
        }
        private void txtRContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtContraseña.Text!="")
            { objRNValidar.Longitud(txtContraseña); }
            else { }
        }
        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(txtContraseña.TextLength>0)
            {
                lbErrorUsu.Text = "      La contraseña tiene que estar compuesta\n      por: Mayúscula, Minúscula, Número y un\n      Carácter Especial '@,#,%,$'  Ej: PassWord12$";
                lbErrorUsu.Visible = true;
            }
        }
        private void form_Dispuesto(object sender, EventArgs e)
        {
            form = null;
        }
        private FrmListaEmpleado FormInstance
        {
            get
            {
                if (form == null)
                {
                    form = new FrmListaEmpleado();
                    form.Disposed += new EventHandler(form_Dispuesto);
                }
                else { form.BringToFront(); }
                return form;
            }
        }

        private void chkBoxPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxPassword.Checked == true)
            {
                if (txtRContraseña.UseSystemPasswordChar == true)
                {
                    txtContraseña.UseSystemPasswordChar = false;
                    txtRContraseña.UseSystemPasswordChar = false;
                }
            }
            else
            {
                txtContraseña.UseSystemPasswordChar = true;
                txtRContraseña.UseSystemPasswordChar = true;
            }
        }
    }
}
