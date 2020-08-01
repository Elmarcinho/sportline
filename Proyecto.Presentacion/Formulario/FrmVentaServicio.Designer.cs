namespace Proyecto.Presentacion.Formulario
{
    partial class FrmVentaServicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbDescuento = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.cbFormaPago = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGenerarFactura = new System.Windows.Forms.Button();
            this.btnGuardarPedidoServicio = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbPlazo = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnBuscarServicio = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNombreProductoServicio = new System.Windows.Forms.TextBox();
            this.dtpFechaCulminacion = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaVenta = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdpedido = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnNuevoCliente = new System.Windows.Forms.Button();
            this.txtCedulaNit = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvDetallePedidoServicio = new System.Windows.Forms.DataGridView();
            this.IdServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Servicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Turno = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.IdPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RangoDias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnQuitarServicio = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.txtMontoTotal = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtCuotaInicial = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.dtpFechaPlazo = new System.Windows.Forms.DateTimePicker();
            this.label18 = new System.Windows.Forms.Label();
            this.txtMontoCredito = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallePedidoServicio)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbDescuento);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(574, 303);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(204, 82);
            this.groupBox2.TabIndex = 87;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DESCUENTO";
            // 
            // cbDescuento
            // 
            this.cbDescuento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDescuento.Enabled = false;
            this.cbDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDescuento.FormattingEnabled = true;
            this.cbDescuento.Location = new System.Drawing.Point(19, 32);
            this.cbDescuento.Name = "cbDescuento";
            this.cbDescuento.Size = new System.Drawing.Size(168, 24);
            this.cbDescuento.TabIndex = 6;
            this.cbDescuento.SelectedIndexChanged += new System.EventHandler(this.cbDescuento_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(560, 541);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 16);
            this.label9.TabIndex = 85;
            this.label9.Text = "SubTotal";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 21.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label16.Location = new System.Drawing.Point(176, 5);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(459, 36);
            this.label16.TabIndex = 84;
            this.label16.Text = "Registro de Ventas de Servicios";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(560, 569);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 82;
            this.label5.Text = "Descuento";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.cbFormaPago);
            this.groupBox7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(35, 303);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(174, 82);
            this.groupBox7.TabIndex = 81;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "FORMA DE PAGO";
            // 
            // cbFormaPago
            // 
            this.cbFormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFormaPago.Enabled = false;
            this.cbFormaPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFormaPago.FormattingEnabled = true;
            this.cbFormaPago.Location = new System.Drawing.Point(46, 32);
            this.cbFormaPago.Name = "cbFormaPago";
            this.cbFormaPago.Size = new System.Drawing.Size(111, 24);
            this.cbFormaPago.TabIndex = 6;
            this.cbFormaPago.SelectedIndexChanged += new System.EventHandler(this.cbFormaPago_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(560, 597);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 78;
            this.label2.Text = "Total";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGenerarFactura);
            this.groupBox1.Controls.Add(this.btnGuardarPedidoServicio);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(47, 620);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(710, 55);
            this.groupBox1.TabIndex = 77;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FUNCIONES";
            // 
            // btnGenerarFactura
            // 
            this.btnGenerarFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarFactura.Location = new System.Drawing.Point(282, 17);
            this.btnGenerarFactura.Name = "btnGenerarFactura";
            this.btnGenerarFactura.Size = new System.Drawing.Size(120, 31);
            this.btnGenerarFactura.TabIndex = 10;
            this.btnGenerarFactura.Text = "Generar Factura";
            this.btnGenerarFactura.UseVisualStyleBackColor = true;
            this.btnGenerarFactura.Click += new System.EventHandler(this.btnGenerarFactura_Click);
            // 
            // btnGuardarPedidoServicio
            // 
            this.btnGuardarPedidoServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarPedidoServicio.Location = new System.Drawing.Point(122, 17);
            this.btnGuardarPedidoServicio.Name = "btnGuardarPedidoServicio";
            this.btnGuardarPedidoServicio.Size = new System.Drawing.Size(100, 31);
            this.btnGuardarPedidoServicio.TabIndex = 8;
            this.btnGuardarPedidoServicio.Text = "Guardar";
            this.btnGuardarPedidoServicio.UseVisualStyleBackColor = true;
            this.btnGuardarPedidoServicio.Click += new System.EventHandler(this.btnGuardarPedidoServicio_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.cbPlazo);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.btnBuscarServicio);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.txtNombreProductoServicio);
            this.groupBox4.Controls.Add(this.dtpFechaCulminacion);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.dtpFechaIngreso);
            this.groupBox4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(35, 182);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(743, 115);
            this.groupBox4.TabIndex = 76;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "SERVICIO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "Plan:";
            // 
            // cbPlazo
            // 
            this.cbPlazo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPlazo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPlazo.FormattingEnabled = true;
            this.cbPlazo.Location = new System.Drawing.Point(61, 26);
            this.cbPlazo.Name = "cbPlazo";
            this.cbPlazo.Size = new System.Drawing.Size(144, 24);
            this.cbPlazo.TabIndex = 6;
            this.cbPlazo.SelectedIndexChanged += new System.EventHandler(this.cbPlazo_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(412, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 16);
            this.label11.TabIndex = 23;
            this.label11.Text = "Fecha Culminación:";
            // 
            // btnBuscarServicio
            // 
            this.btnBuscarServicio.Enabled = false;
            this.btnBuscarServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarServicio.Location = new System.Drawing.Point(628, 25);
            this.btnBuscarServicio.Name = "btnBuscarServicio";
            this.btnBuscarServicio.Size = new System.Drawing.Size(93, 25);
            this.btnBuscarServicio.TabIndex = 14;
            this.btnBuscarServicio.Text = "Buscador";
            this.btnBuscarServicio.UseVisualStyleBackColor = true;
            this.btnBuscarServicio.Click += new System.EventHandler(this.btnBuscarServicio_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(93, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 16);
            this.label8.TabIndex = 22;
            this.label8.Text = "Fecha Ingreso:";
            // 
            // txtNombreProductoServicio
            // 
            this.txtNombreProductoServicio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreProductoServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProductoServicio.Location = new System.Drawing.Point(444, 28);
            this.txtNombreProductoServicio.Name = "txtNombreProductoServicio";
            this.txtNombreProductoServicio.ReadOnly = true;
            this.txtNombreProductoServicio.Size = new System.Drawing.Size(144, 22);
            this.txtNombreProductoServicio.TabIndex = 3;
            this.txtNombreProductoServicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtpFechaCulminacion
            // 
            this.dtpFechaCulminacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaCulminacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaCulminacion.Location = new System.Drawing.Point(563, 78);
            this.dtpFechaCulminacion.Name = "dtpFechaCulminacion";
            this.dtpFechaCulminacion.Size = new System.Drawing.Size(119, 22);
            this.dtpFechaCulminacion.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(372, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Nombre:";
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaIngreso.Location = new System.Drawing.Point(219, 78);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(119, 22);
            this.dtpFechaIngreso.TabIndex = 1;
            this.dtpFechaIngreso.ValueChanged += new System.EventHandler(this.dtpFechaIngreso_ValueChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.dtpFechaVenta);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.txtIdpedido);
            this.groupBox5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(557, 81);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(221, 95);
            this.groupBox5.TabIndex = 89;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "VENTA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Fecha:";
            // 
            // dtpFechaVenta
            // 
            this.dtpFechaVenta.Enabled = false;
            this.dtpFechaVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaVenta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaVenta.Location = new System.Drawing.Point(80, 62);
            this.dtpFechaVenta.Name = "dtpFechaVenta";
            this.dtpFechaVenta.Size = new System.Drawing.Size(119, 22);
            this.dtpFechaVenta.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Código:";
            // 
            // txtIdpedido
            // 
            this.txtIdpedido.BackColor = System.Drawing.SystemColors.Control;
            this.txtIdpedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdpedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdpedido.Location = new System.Drawing.Point(80, 27);
            this.txtIdpedido.Name = "txtIdpedido";
            this.txtIdpedido.ReadOnly = true;
            this.txtIdpedido.Size = new System.Drawing.Size(119, 22);
            this.txtIdpedido.TabIndex = 19;
            this.txtIdpedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnNuevoCliente);
            this.groupBox3.Controls.Add(this.txtCedulaNit);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.btnBuscarCliente);
            this.groupBox3.Controls.Add(this.txtNombreCliente);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(35, 81);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(510, 95);
            this.groupBox3.TabIndex = 88;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "CLIENTE";
            // 
            // btnNuevoCliente
            // 
            this.btnNuevoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoCliente.Location = new System.Drawing.Point(404, 27);
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.Size = new System.Drawing.Size(93, 25);
            this.btnNuevoCliente.TabIndex = 12;
            this.btnNuevoCliente.Text = "Nuevo";
            this.btnNuevoCliente.UseVisualStyleBackColor = true;
            this.btnNuevoCliente.Click += new System.EventHandler(this.btnNuevoCliente_Click);
            // 
            // txtCedulaNit
            // 
            this.txtCedulaNit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCedulaNit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedulaNit.Location = new System.Drawing.Point(116, 29);
            this.txtCedulaNit.Name = "txtCedulaNit";
            this.txtCedulaNit.Size = new System.Drawing.Size(144, 22);
            this.txtCedulaNit.TabIndex = 11;
            this.txtCedulaNit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCedulaNit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedulaNit_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(21, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 16);
            this.label10.TabIndex = 10;
            this.label10.Text = "CI / NIT:";
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCliente.Location = new System.Drawing.Point(294, 27);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(93, 25);
            this.btnBuscarCliente.TabIndex = 9;
            this.btnBuscarCliente.Text = "Buscador";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCliente.Location = new System.Drawing.Point(116, 62);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.ReadOnly = true;
            this.txtNombreCliente.Size = new System.Drawing.Size(271, 22);
            this.txtNombreCliente.TabIndex = 1;
            this.txtNombreCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Sr (a):";
            // 
            // dgvDetallePedidoServicio
            // 
            this.dgvDetallePedidoServicio.AllowUserToAddRows = false;
            this.dgvDetallePedidoServicio.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetallePedidoServicio.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvDetallePedidoServicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetallePedidoServicio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdServicio,
            this.Servicio,
            this.Turno,
            this.IdPrecio,
            this.Precio,
            this.Cantidad,
            this.HoraInicio,
            this.HoraFin,
            this.RangoDias,
            this.Total,
            this.btnQuitarServicio});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetallePedidoServicio.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvDetallePedidoServicio.Location = new System.Drawing.Point(35, 398);
            this.dgvDetallePedidoServicio.Name = "dgvDetallePedidoServicio";
            this.dgvDetallePedidoServicio.Size = new System.Drawing.Size(744, 130);
            this.dgvDetallePedidoServicio.TabIndex = 90;
            this.dgvDetallePedidoServicio.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetallePedidoServicio_CellContentClick);
            this.dgvDetallePedidoServicio.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetallePedidoServicio_CellValueChanged);
            this.dgvDetallePedidoServicio.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvDetallePedidoServicio_EditingControlShowing);
            this.dgvDetallePedidoServicio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvDetallePedidoServicio_KeyPress);
            // 
            // IdServicio
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.IdServicio.DefaultCellStyle = dataGridViewCellStyle9;
            this.IdServicio.HeaderText = "Cod.";
            this.IdServicio.Name = "IdServicio";
            this.IdServicio.ReadOnly = true;
            this.IdServicio.Width = 50;
            // 
            // Servicio
            // 
            this.Servicio.HeaderText = "Servicio";
            this.Servicio.Name = "Servicio";
            this.Servicio.ReadOnly = true;
            this.Servicio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Servicio.Width = 220;
            // 
            // Turno
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Turno.DefaultCellStyle = dataGridViewCellStyle10;
            this.Turno.HeaderText = "Turno";
            this.Turno.Name = "Turno";
            this.Turno.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Turno.Width = 120;
            // 
            // IdPrecio
            // 
            this.IdPrecio.HeaderText = "IdPrecio";
            this.IdPrecio.Name = "IdPrecio";
            this.IdPrecio.Visible = false;
            // 
            // Precio
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle11.Format = "N1";
            dataGridViewCellStyle11.NullValue = null;
            this.Precio.DefaultCellStyle = dataGridViewCellStyle11;
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Precio.Width = 80;
            // 
            // Cantidad
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.Cantidad.DefaultCellStyle = dataGridViewCellStyle12;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Cantidad.Width = 80;
            // 
            // HoraInicio
            // 
            this.HoraInicio.HeaderText = "HoraInicio";
            this.HoraInicio.Name = "HoraInicio";
            this.HoraInicio.Visible = false;
            // 
            // HoraFin
            // 
            this.HoraFin.HeaderText = "HoraFin";
            this.HoraFin.Name = "HoraFin";
            this.HoraFin.Visible = false;
            // 
            // RangoDias
            // 
            this.RangoDias.HeaderText = "RangoDias";
            this.RangoDias.Name = "RangoDias";
            this.RangoDias.Visible = false;
            // 
            // Total
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.Total.DefaultCellStyle = dataGridViewCellStyle13;
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Total.Width = 80;
            // 
            // btnQuitarServicio
            // 
            this.btnQuitarServicio.HeaderText = "Opción";
            this.btnQuitarServicio.Name = "btnQuitarServicio";
            this.btnQuitarServicio.Text = "Quitar";
            this.btnQuitarServicio.UseColumnTextForButtonValue = true;
            this.btnQuitarServicio.Width = 70;
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.BackColor = System.Drawing.SystemColors.Control;
            this.txtSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubTotal.Location = new System.Drawing.Point(634, 539);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(88, 22);
            this.txtSubTotal.TabIndex = 93;
            this.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(726, 541);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 16);
            this.label12.TabIndex = 94;
            this.label12.Text = "Bs.-";
            // 
            // txtDescuento
            // 
            this.txtDescuento.BackColor = System.Drawing.SystemColors.Control;
            this.txtDescuento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescuento.Location = new System.Drawing.Point(634, 567);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(88, 22);
            this.txtDescuento.TabIndex = 95;
            this.txtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMontoTotal
            // 
            this.txtMontoTotal.BackColor = System.Drawing.SystemColors.Control;
            this.txtMontoTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMontoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoTotal.Location = new System.Drawing.Point(634, 595);
            this.txtMontoTotal.Name = "txtMontoTotal";
            this.txtMontoTotal.Size = new System.Drawing.Size(88, 22);
            this.txtMontoTotal.TabIndex = 96;
            this.txtMontoTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(726, 598);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 16);
            this.label14.TabIndex = 98;
            this.label14.Text = "Bs.-";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(726, 569);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 16);
            this.label13.TabIndex = 97;
            this.label13.Text = "Bs.-";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtCuotaInicial);
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Controls.Add(this.dtpFechaPlazo);
            this.groupBox6.Controls.Add(this.label18);
            this.groupBox6.Controls.Add(this.txtMontoCredito);
            this.groupBox6.Controls.Add(this.label19);
            this.groupBox6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(222, 303);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(339, 82);
            this.groupBox6.TabIndex = 99;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "CRÉDITO";
            this.groupBox6.Visible = false;
            // 
            // txtCuotaInicial
            // 
            this.txtCuotaInicial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCuotaInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuotaInicial.Location = new System.Drawing.Point(114, 21);
            this.txtCuotaInicial.Name = "txtCuotaInicial";
            this.txtCuotaInicial.Size = new System.Drawing.Size(82, 22);
            this.txtCuotaInicial.TabIndex = 18;
            this.txtCuotaInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCuotaInicial.TextChanged += new System.EventHandler(this.txtCuotaInicial_TextChanged);
            this.txtCuotaInicial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCuotaInicial_KeyPress);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(20, 23);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(83, 16);
            this.label17.TabIndex = 17;
            this.label17.Text = "Cuota Inicial:";
            // 
            // dtpFechaPlazo
            // 
            this.dtpFechaPlazo.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaPlazo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaPlazo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaPlazo.Location = new System.Drawing.Point(208, 47);
            this.dtpFechaPlazo.Name = "dtpFechaPlazo";
            this.dtpFechaPlazo.Size = new System.Drawing.Size(106, 22);
            this.dtpFechaPlazo.TabIndex = 15;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(207, 21);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(105, 16);
            this.label18.TabIndex = 16;
            this.label18.Text = "Fecha de Plazo:";
            // 
            // txtMontoCredito
            // 
            this.txtMontoCredito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMontoCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoCredito.Location = new System.Drawing.Point(114, 50);
            this.txtMontoCredito.Name = "txtMontoCredito";
            this.txtMontoCredito.ReadOnly = true;
            this.txtMontoCredito.Size = new System.Drawing.Size(82, 22);
            this.txtMontoCredito.TabIndex = 3;
            this.txtMontoCredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(20, 52);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(93, 16);
            this.label19.TabIndex = 1;
            this.label19.Text = "Saldo Crédito:";
            // 
            // FrmVentaServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(804, 683);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtMontoTotal);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtSubTotal);
            this.Controls.Add(this.dgvDetallePedidoServicio);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Name = "FrmVentaServicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Información - Solicitud de Servicio";
            this.Load += new System.EventHandler(this.FrmVentaServicio_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallePedidoServicio)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbDescuento;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ComboBox cbFormaPago;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGenerarFactura;
        private System.Windows.Forms.Button btnGuardarPedidoServicio;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnBuscarServicio;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DateTimePicker dtpFechaVenta;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtIdpedido;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.Button btnNuevoCliente;
        public System.Windows.Forms.TextBox txtCedulaNit;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.Button btnBuscarCliente;
        public System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.DataGridView dgvDetallePedidoServicio;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.DateTimePicker dtpFechaCulminacion;
        public System.Windows.Forms.DateTimePicker dtpFechaIngreso;
        public System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox txtDescuento;
        public System.Windows.Forms.TextBox txtMontoTotal;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.ComboBox cbPlazo;
        public System.Windows.Forms.GroupBox groupBox6;
        public System.Windows.Forms.TextBox txtCuotaInicial;
        private System.Windows.Forms.Label label17;
        public System.Windows.Forms.DateTimePicker dtpFechaPlazo;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtMontoCredito;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtNombreProductoServicio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Servicio;
        private System.Windows.Forms.DataGridViewComboBoxColumn Turno;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn RangoDias;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewButtonColumn btnQuitarServicio;
    }
}