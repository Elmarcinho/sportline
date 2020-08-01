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
using AForge.Video;
using AForge.Video.DirectShow;

namespace Proyecto.Presentacion.Formulario
{
    public partial class FrmCliente : Form
    {
        CtrlCliente objCtrlCliente = new CtrlCliente();
        OpenFileDialog openFileDialog = new OpenFileDialog();
        RNValidar objRNValidar = new RNValidar();
        Negocio.RNLista.RNCliente objRNCliente = new Negocio.RNLista.RNCliente();
        //CODIGO PARA VER WEBCAM
        private bool ExisteDispositivo = false;
        private FilterInfoCollection DispositivoDeVideo;
        private VideoCaptureDevice FuenteDeVideo = null;

        public FrmCliente()
        {
            InitializeComponent();
        }
        private void FrmCliente_Load(object sender, EventArgs e)
        {
            CargarComboCiudadZona();
            BuscarDispositivos();
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
            this.cbCiudadZonaCli.DataSource = dta;
            this.cbCiudadZonaCli.DisplayMember = "NombreCiudadZona";
            this.cbCiudadZonaCli.ValueMember = "IdZona";
        }
        private void BtnGuardarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (objCtrlCliente.Validar(txtNombreCliente.Text, txtApp.Text, txtCiNit.Text, rbMasculino.Checked, rbFemenino.Checked))
                {
                    if (Convert.ToInt64(cbCiudadZonaCli.SelectedValue) != 0)
                    {
                        Persona ObjAuxPersona = new Persona();
                        Cliente ObjAuxCliente = new Cliente();

                        if (Utilitarios.Utilitarios.Evento == 0)
                        {
                            if (CargarObjetoCliente(ObjAuxPersona, ObjAuxCliente))
                            {
                                if (objCtrlCliente.InsertarCliente(ObjAuxPersona, ObjAuxCliente))
                                {

                                    MessageBox.Show("Cliente registrado con éxito!","Sistema de Ventas");
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Error en el registro de cliente.","Sistemas de Ventas",MessageBoxButtons.OK,MessageBoxIcon.Error);
                                }
                            }
                        }
                        else
                        {
                            if (CargarObjetoCliente(ObjAuxPersona, ObjAuxCliente))
                            {
                                if (objCtrlCliente.ModificarCliente(ObjAuxPersona, ObjAuxCliente))
                                {

                                    MessageBox.Show("Cliente Actualizado con éxito!","Sistema de Ventas");
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Error en la Actualización del Cliente.", "Sistemas de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                    else { MessageBox.Show("Favor seleccionar Ciudad/Zona", "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool CargarObjetoCliente(Persona objPersona,Cliente objCliente)
        {
            try
            {
                
                if (Utilitarios.Utilitarios.Evento == 0)
                {
                    objPersona.IdPersona = objCtrlCliente.GenerarID();
                    
                    if (! objCtrlCliente.VerificarClienteExistente(int.Parse(txtCiNit.Text))){

                        objPersona.DocumentoIdentidad = Int64.Parse(this.txtCiNit.Text);
                    }
                    else {
                        MessageBox.Show("No se puede registrar Cliente, porque ya existe registro con la misma cedula de identidad, por favor verifique e intente nuevamente.", "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
                else
                {
                    objPersona.IdPersona = Utilitarios.Utilitarios.IdCliente;

                    if (Utilitarios.Utilitarios.CedulaIdendidad == long.Parse(this.txtCiNit.Text)){

                        objPersona.DocumentoIdentidad = Int64.Parse(this.txtCiNit.Text);
                    }
                    else if (! objCtrlCliente.VerificarClienteExistente(int.Parse(txtCiNit.Text))){

                        objPersona.DocumentoIdentidad = Int64.Parse(this.txtCiNit.Text);
                    }
                    else {
                        MessageBox.Show("No se puede registrar Cliente, porque ya existe registro con la misma cedula de identidad, por favor verifique e intente nuevamente.", "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }

                objPersona.NombrePersona = this.txtNombreCliente.Text.Trim();
                objPersona.ApellidoPaterno = this.txtApp.Text.Trim();
                objPersona.ApellidoMaterno = this.txtApm.Text.Trim();
                
                if (txtEmail.Text == string.Empty)
                { objPersona.CorreoElectronico = txtEmail.Text; }
                else if (objRNValidar.email(txtEmail))
                { objPersona.CorreoElectronico = txtEmail.Text; }
                else { MessageBox.Show("Correo electrónico no valida.","Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }
                
                if (dtFechaNacimiento.Text != "01/01/1900")
                { objPersona.FechaNacimiento = DateTime.Parse(dtFechaNacimiento.Text); }
                else { objPersona.FechaNacimiento=null; }

                if (rbMasculino.Checked)
                { objPersona.Sexo = "M".ToString(); }
                else { objPersona.Sexo = "F".ToString(); }
   
                objPersona.Telefono = txtTelefono.Text.Trim();
                objPersona.Direccion = txtDireccion.Text.Trim(); 

                //Guardar la Imagen en byte
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                pbcCliente.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] imagen = ms.ToArray();
                objPersona.Foto = imagen;

                objPersona.IdZona = Int64.Parse(this.cbCiudadZonaCli.SelectedValue.ToString());
                objPersona.IdSucursal = Convert.ToInt32(Utilitarios.Utilitarios.IdSucursal);

                objCliente.IdPersona = objPersona.IdPersona;
                if (txtPeso.Text.Trim() != "")
                { objCliente.Peso = Convert.ToDouble(txtPeso.Text.Replace(".", ",")); }
                if (txtAltura.Text.Trim() != "")
                { objCliente.Estatura = Convert.ToDouble(txtAltura.Text.Replace(".", ",")); }
                
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Error en cargar los datos del Cliente.","Sistemas de Ventas",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
        }
        //WebCam
        private void btnIniciarWebCam_Click(object sender, EventArgs e)
        {
            if (btnIniciarWebCam.Text == "Iniciar WebCam")

            {
                if (ExisteDispositivo)
                {
                    FuenteDeVideo = new VideoCaptureDevice(DispositivoDeVideo[cbDispositivo.SelectedIndex].MonikerString);
                    FuenteDeVideo.NewFrame += new NewFrameEventHandler(Video_NuevoFrame);
                    FuenteDeVideo.Start();
                    Estado.Text = "Ejecutando Dispositivo…";
                    Estado.Visible = true;
                    btnIniciarWebCam.Text = "Capturar Foto";
                    cbDispositivo.Enabled = false;
                }
                else
                {
                    Estado.Text = "No se dectecto Cámara Web.";
                    Estado.ForeColor=Color.Red;
                    Estado.Visible = true;
                }
            }
            else
            {
                if (FuenteDeVideo.IsRunning)
                {
                    TerminarFuenteDeVideo();
                    Estado.Text = "Dispositivo Detenido…";
                    btnIniciarWebCam.Text = "Iniciar WebCam";
                    cbDispositivo.Enabled = true;
                }
            }
        }
        public void Video_NuevoFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap Imagen = (Bitmap)eventArgs.Frame.Clone();
            pbcCliente.Image = Imagen;
        }
        public void BuscarDispositivos()
        {
            DispositivoDeVideo = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (DispositivoDeVideo.Count == 0)
            {
                ExisteDispositivo = false;
            }
            else
            {
                ExisteDispositivo = true;
                CargarDispositivos(DispositivoDeVideo);
            }
        }
        public void CargarDispositivos(FilterInfoCollection Dispositivos)
        {
            for (int i = 0; i < Dispositivos.Count; i++)
            { 
            cbDispositivo.Items.Add(Dispositivos[i].Name.ToString());
            cbDispositivo.Text = cbDispositivo.Items[i].ToString();
            }
        }
        public void TerminarFuenteDeVideo()
        {
            if (!(FuenteDeVideo == null))
                if (FuenteDeVideo.IsRunning)
                {
                    FuenteDeVideo.SignalToStop();
                    FuenteDeVideo = null;
                }
        }
        private void txtNombreCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            objRNValidar.Letras(e, txtNombreCliente);
        }
        private void txtApp_KeyPress(object sender, KeyPressEventArgs e)
        {
            objRNValidar.Letras(e, txtApp);
        }

        private void txtApm_KeyPress(object sender, KeyPressEventArgs e)
        {
            objRNValidar.Letras(e, txtApm);
        }
        private void txtCi_KeyPress(object sender, KeyPressEventArgs e)
        {
            objRNValidar.Numeros(e);
        }
        private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            objRNValidar.Decimal(e,txtPeso);
        }
        private void txtAltura_KeyPress(object sender, KeyPressEventArgs e)
        {
            objRNValidar.Decimal(e,txtAltura);
        }
        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            objRNValidar.Alfanumerico(e);
        }
        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            objRNValidar.Alfanumerico(e);
        }
        private void txtNombreCliente_TextChanged(object sender, EventArgs e)
        {
            pictureBox1.Visible=false;
            txtNombreCliente.BackColor = Color.White;
        }
        private void txtNombreCliente_Leave(object sender, EventArgs e)
        {
            this.pictureBox1.Visible = false;
        }
        private void txtNombreCliente_Validated(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(this.txtNombreCliente.Text) || txtNombreCliente.Text.Length < 3)
                {
                    pictureBox1.BackColor = Color.Red;
                    this.txtNombreCliente.BackColor = Color.LightYellow;
                    pictureBox1.Visible = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtApp_TextChanged(object sender, EventArgs e)
        {
            pictureBox2.Visible=false;
            txtApp.BackColor = Color.White;
        }
        private void txtApp_Leave(object sender, EventArgs e)
        {
            this.pictureBox2.Visible = false;
        }
        private void txtApp_Validated(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(this.txtApp.Text) || txtApp.Text.Length < 3)
                {
                    pictureBox2.BackColor = Color.Red;
                    this.txtApp.BackColor = Color.LightYellow;
                    pictureBox2.Visible = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void txtCiNit_TextChanged(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
            txtCiNit.BackColor = Color.White;
        }
        private void txtCiNit_Leave(object sender, EventArgs e)
        {
            this.pictureBox3.Visible = false;
        }
        private void txtCiNit_Validated(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(this.txtCiNit.Text) || txtCiNit.Text.Length < 7)
                {
                    pictureBox3.BackColor = Color.Red;
                    this.txtCiNit.BackColor = Color.LightYellow;
                    pictureBox3.Visible = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
