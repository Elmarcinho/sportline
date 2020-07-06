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
    public partial class FrmEmpleado : Form
    {
        CtrlEmpleado objCtrlEmpleado = new CtrlEmpleado();
        OpenFileDialog openFileDialog = new OpenFileDialog();
        RNValidar objRNValidar = new RNValidar();
        Negocio.RNLista.RNCliente objRNCliente = new Negocio.RNLista.RNCliente();
        public FrmEmpleado()
        {
            InitializeComponent();
        }
        private void FrmEmpleado_Load(object sender, EventArgs e)
        {
            CargarComboCiudadZona();
        }
        private void CargarComboCiudadZona()
        {
            DataTable dta = new DataTable();
            dta.Columns.Add(new DataColumn("IdZona"));
            dta.Columns.Add(new DataColumn("NombreCiudadZona"));

            DataRow dr = dta.NewRow();
            dr["IdZona"] = 0;
            dr["NombreCiudadZona"] = "         ----------- Seleccionar -----------";
            dta.Rows.Add(dr);

            Negocio.RNLista.RNCiudad objRNCiudad = new Negocio.RNLista.RNCiudad();
            Negocio.RNLista.RNZona objRNZona = new Negocio.RNLista.RNZona();
            foreach (Ciudad objCiudad in objRNCiudad.TraerCiudad(0))
            {
                foreach (Zona objZona in objRNZona.TraerZonaPorCiudad(objCiudad.IdCiudad))
                {
                    DataRow drColomn = dta.NewRow();
                    drColomn["IdZona"] = objZona.IdZona;
                    drColomn["NombreCiudadZona"] = objCiudad.NombreCiudad + " / " + objZona.NombreZona;
                    dta.Rows.Add(drColomn);
                }
            }
            this.cbCiudadZonaEmpleado.DataSource = dta;
            this.cbCiudadZonaEmpleado.DisplayMember = "NombreCiudadZona";
            this.cbCiudadZonaEmpleado.ValueMember = "IdZona";
        }
        private void BtnGuardarEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                if (objCtrlEmpleado.Validar(txtNombreEmpleado.Text, txtAppE.Text, txtCiE.Text))
                {
                    if (Convert.ToInt64(cbCiudadZonaEmpleado.SelectedValue) != 0)
                    {
                        Persona objPersona = new Persona();
                        Empleado objEmpleado = new Empleado();

                        if (Utilitarios.Utilitarios.Evento == 0)
                        {
                            if (CargarObjetoEmpleado(objPersona, objEmpleado))
                            {
                                if (objCtrlEmpleado.InsertarEmpleado(objPersona, objEmpleado))
                                {
                                    MessageBox.Show("Empleado Registrado con éxito!","Sistema de Ventas");
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Error en el registro de Empleado", "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        else
                        {
                            if (CargarObjetoEmpleado(objPersona, objEmpleado))
                            {
                                if (objCtrlEmpleado.ActualizarEmpleado(objPersona, objEmpleado))
                                {
                                    MessageBox.Show("Empleado Actualizado con éxito!","Sistema de Ventas");
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Error en la Actualizacion del Empleado", "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                     }
                     else { MessageBox.Show("Favor seleccionar Ciudad/Zona", "Sistema de Gestión y Ventas", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Sistema de Gestión y Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool CargarObjetoEmpleado(Persona objPersona, Empleado objEmpleado)
        {
            try
            {
                var x = objRNCliente.TraerClienteGeneralPorCedula(long.Parse(txtCiE.Text));
                if (Utilitarios.Utilitarios.Evento == 0)
                {
                    objPersona.IdPersona = objCtrlEmpleado.GenerarID();

                    if (x.LongCount() == 0)
                    { objPersona.DocumentoIdentidad = Int64.Parse(this.txtCiE.Text); }
                    else { MessageBox.Show("No se puede registrar Empleado, porque ya existe registro con la misma cedula de identidad, por favor verifique e intente nuevamente.", "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }
                }
                else
                {
                    objPersona.IdPersona = Utilitarios.Utilitarios.IdEmpleado;

                    if (x.LongCount() == 0)
                    { objPersona.DocumentoIdentidad = Int64.Parse(this.txtCiE.Text); }
                    else if (x.LongCount() == 1)
                    { objPersona.DocumentoIdentidad = Int64.Parse(this.txtCiE.Text); }
                    else { MessageBox.Show("No se puede registrar Empleado, porque ya existe registro con la misma cedula de identidad, por favor verifique e intente nuevamente.", "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }
                }
                objPersona.NombrePersona = this.txtNombreEmpleado.Text;
                objPersona.ApellidoPaterno = this.txtAppE.Text;
                objPersona.ApellidoMaterno = this.txtApmE.Text;
                
                if (dtFechanacimientoE.Text != "01/01/1900")
                {
                    objPersona.FechaNacimiento = DateTime.Parse(this.dtFechanacimientoE.Text);
                }
                else { objPersona.FechaNacimiento = null; }
                if (rbMasculinoE.Checked)
                { objPersona.Sexo = "M"; }
                else { objPersona.Sexo = "F"; }
                objPersona.Telefono = this.txtTelefonoE.Text;
                objPersona.Direccion = this.txtDireccionE.Text;
                //Guardar la Imagen en byte
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                pbcEmpleado.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] imagen = ms.ToArray();
                objPersona.Foto = imagen;

                objPersona.IdZona = Int64.Parse(this.cbCiudadZonaEmpleado.SelectedValue.ToString());
                objPersona.IdSucursal = Convert.ToInt32(Utilitarios.Utilitarios.IdSucursal);

                objEmpleado.IdPersona = objPersona.IdPersona;
                objEmpleado.FechaIngreso = DateTime.Parse(this.dtFechaIngresoE.Text);
                objEmpleado.EstadoEmpleado = Convert.ToInt32(Utilitarios.Utilitarios.EstadoEmpleado);

                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Error en cargar los datos del Empleado.","Sistema de Ventas",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
        }
        private void pbcEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = openFileDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    this.pbcEmpleado.SizeMode = PictureBoxSizeMode.StretchImage;
                    this.pbcEmpleado.Image = Image.FromFile(openFileDialog.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Sistema de Ventas",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void txtNombreEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            objRNValidar.Letras(e, txtNombreEmpleado);
        }
        private void txtAppE_KeyPress(object sender, KeyPressEventArgs e)
        {
            objRNValidar.Letras(e, txtAppE);
        }
        private void txtApmE_KeyPress(object sender, KeyPressEventArgs e)
        {
            objRNValidar.Letras(e, txtApmE);
        }
        private void txtCiE_KeyPress(object sender, KeyPressEventArgs e)
        {
            objRNValidar.Numeros(e);
        }
        private void txtTelefonoE_KeyPress(object sender, KeyPressEventArgs e)
        {
            objRNValidar.Alfanumerico(e);
        }
        private void txtDireccionE_KeyPress(object sender, KeyPressEventArgs e)
        {
            objRNValidar.Alfanumerico(e);
        }
       
    }
}

