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
    public partial class FrmCredito : Form
    {
        CtrlCuota objCtrlCuota = new CtrlCuota();
        RNValidar objRNValidar = new RNValidar();
        Negocio.RNLista.RNCredito objRNCredito = new Negocio.RNLista.RNCredito();
        public FrmCredito()
        {
            InitializeComponent();
        }
        private void txtCuotaPagar_TextChanged(object sender, EventArgs e)
        {
            Double CuotaPagar = 0;
            Double.TryParse(txtCuotaPagar.Text.Replace(".",","), out CuotaPagar);

            Double SaldoActualCredito = 0;
            Double.TryParse(txtSaldoActualCredito.Text, out SaldoActualCredito);

            txtNuevoSaldoCredito.Text = (SaldoActualCredito - CuotaPagar).ToString();
        }

        private void txtCuotaPagar_KeyPress(object sender, KeyPressEventArgs e)
        {
            objRNValidar.Decimal(e, txtCuotaPagar);
        }

        private void btnGuardarCredito_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckCreditoTotal.Checked==false)
                {
                    Cuota objCuota = new Cuota();
                    //objCuota.IdCuota = objCtrlCuota.GenerarID();
                    objCuota.MontoCuota = Convert.ToDouble(txtCuotaPagar.Text.Replace(".", ","));
                    objCuota.FechaPago = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                    objCuota.IdCredito = Utilitarios.Utilitarios.IdCredito;
                    if (objCtrlCuota.InsertarCuota(objCuota))
                    {
                        MessageBox.Show("Pago del Crédito registrado con éxito!","Sistema de Ventas");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error en el registro del Pago de Crédito", "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    Cuota objCuota = new Cuota();
                    var ListaCredito = objRNCredito.TraerClienteCreditoPorNombre(lbNombreCliente.Text);
                    int contar=0;
                    foreach (var item in ListaCredito)
                    {
                        objCuota.MontoCuota = Convert.ToDouble(item.Saldo);
                        objCuota.FechaPago = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                        objCuota.IdCredito = item.CodCrédito;
                        if (objCtrlCuota.InsertarCuota(objCuota))
                        {
                            contar = contar + 1;
                        }
                        else
                        {
                            MessageBox.Show("Error en el registro del Pago de Crédito", "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                    }
                    if(ListaCredito.LongCount()==contar)
                    {
                        MessageBox.Show("Pago Total del Crédito registrado con éxito!","Sistema de Ventas");
                        this.Close();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CheckCreditoTotal_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckCreditoTotal.Checked == true)
            {
                if (MessageBox.Show("¿Está seguro de Pagar todos los Crédito del Cliente?", "Sistema de Ventas",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    decimal Total = 0;
                    var ListaCredito = objRNCredito.TraerClienteCreditoPorNombre(lbNombreCliente.Text);
                    foreach (var item in ListaCredito)
                    {
                        Total = Total + Convert.ToDecimal(item.Saldo);
                    }
                    txtSaldoActualCredito.Text = Total.ToString("N2");
                    txtCuotaPagar.Text = Total.ToString("N2");
                }
                else { CheckCreditoTotal.Checked = false; }
            }
            else
            {
                txtSaldoActualCredito.Text = Utilitarios.Utilitarios.SaldoActualCredito.ToString("N2");
                txtCuotaPagar.Clear();
                txtNuevoSaldoCredito.Clear();
            }
        }
    }
}
