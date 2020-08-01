namespace Proyecto.Presentacion.Formulario
{
    partial class FrmVentaProducto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFechaVenta = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdpedido = new System.Windows.Forms.TextBox();
            this.txtMontoTotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGenerarFactura = new System.Windows.Forms.Button();
            this.btnGuardarPedidoProducto = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNombreProductoServicio = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnNuevoCliente = new System.Windows.Forms.Button();
            this.txtCedulaNit = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDetallePedidoProducto = new System.Windows.Forms.DataGridView();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnQuitarProducto = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.cbFormaPago = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtCambio = new System.Windows.Forms.TextBox();
            this.lbCambio = new System.Windows.Forms.Label();
            this.lbEfectivo = new System.Windows.Forms.Label();
            this.txtEfectivo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMontoCredito = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFechaPlazo = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCuotaInicial = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallePedidoProducto)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.dtpFechaVenta);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.txtIdpedido);
            this.groupBox5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(568, 66);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(221, 95);
            this.groupBox5.TabIndex = 31;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "VENTA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Fecha:";
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
            // txtMontoTotal
            // 
            this.txtMontoTotal.BackColor = System.Drawing.SystemColors.Control;
            this.txtMontoTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMontoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoTotal.Location = new System.Drawing.Point(634, 552);
            this.txtMontoTotal.Name = "txtMontoTotal";
            this.txtMontoTotal.Size = new System.Drawing.Size(88, 22);
            this.txtMontoTotal.TabIndex = 30;
            this.txtMontoTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(567, 554);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 29;
            this.label2.Text = "Total";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGenerarFactura);
            this.groupBox1.Controls.Add(this.btnGuardarPedidoProducto);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(46, 624);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(743, 49);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FUNCIONES";
            // 
            // btnGenerarFactura
            // 
            this.btnGenerarFactura.Enabled = false;
            this.btnGenerarFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarFactura.Location = new System.Drawing.Point(270, 12);
            this.btnGenerarFactura.Name = "btnGenerarFactura";
            this.btnGenerarFactura.Size = new System.Drawing.Size(123, 31);
            this.btnGenerarFactura.TabIndex = 10;
            this.btnGenerarFactura.Text = "Generar Factura";
            this.btnGenerarFactura.UseVisualStyleBackColor = true;
            this.btnGenerarFactura.Click += new System.EventHandler(this.btnGenerarFactura_Click);
            // 
            // btnGuardarPedidoProducto
            // 
            this.btnGuardarPedidoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarPedidoProducto.Location = new System.Drawing.Point(122, 12);
            this.btnGuardarPedidoProducto.Name = "btnGuardarPedidoProducto";
            this.btnGuardarPedidoProducto.Size = new System.Drawing.Size(100, 31);
            this.btnGuardarPedidoProducto.TabIndex = 8;
            this.btnGuardarPedidoProducto.Text = "Guardar";
            this.btnGuardarPedidoProducto.UseVisualStyleBackColor = true;
            this.btnGuardarPedidoProducto.Click += new System.EventHandler(this.btnGuardarPedidoProducto_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnBuscarProducto);
            this.groupBox4.Controls.Add(this.txtDescripcion);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.txtStock);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.txtNombreProductoServicio);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(46, 165);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(743, 92);
            this.groupBox4.TabIndex = 27;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "PRODUCTO";
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProducto.Location = new System.Drawing.Point(404, 56);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(93, 25);
            this.btnBuscarProducto.TabIndex = 14;
            this.btnBuscarProducto.Text = "Buscador";
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(404, 24);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.Size = new System.Drawing.Size(284, 22);
            this.txtDescripcion.TabIndex = 2;
            this.txtDescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(304, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Descripción:";
            // 
            // txtStock
            // 
            this.txtStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStock.Location = new System.Drawing.Point(116, 56);
            this.txtStock.Name = "txtStock";
            this.txtStock.ReadOnly = true;
            this.txtStock.Size = new System.Drawing.Size(144, 22);
            this.txtStock.TabIndex = 5;
            this.txtStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(21, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 16);
            this.label8.TabIndex = 4;
            this.label8.Text = "Stock:";
            // 
            // txtNombreProductoServicio
            // 
            this.txtNombreProductoServicio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreProductoServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProductoServicio.Location = new System.Drawing.Point(116, 22);
            this.txtNombreProductoServicio.Name = "txtNombreProductoServicio";
            this.txtNombreProductoServicio.ReadOnly = true;
            this.txtNombreProductoServicio.Size = new System.Drawing.Size(144, 22);
            this.txtNombreProductoServicio.TabIndex = 3;
            this.txtNombreProductoServicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Nombre:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnNuevoCliente);
            this.groupBox3.Controls.Add(this.txtCedulaNit);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.btnBuscarCliente);
            this.groupBox3.Controls.Add(this.txtNombreCliente);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(46, 66);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(510, 95);
            this.groupBox3.TabIndex = 25;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sr (a):";
            // 
            // dgvDetallePedidoProducto
            // 
            this.dgvDetallePedidoProducto.AllowUserToAddRows = false;
            this.dgvDetallePedidoProducto.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetallePedidoProducto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDetallePedidoProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetallePedidoProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProducto,
            this.Producto,
            this.Descripcion,
            this.IdPrecio,
            this.Precio,
            this.Stock,
            this.Cantidad,
            this.Total,
            this.btnQuitarProducto});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetallePedidoProducto.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDetallePedidoProducto.Location = new System.Drawing.Point(45, 353);
            this.dgvDetallePedidoProducto.Name = "dgvDetallePedidoProducto";
            this.dgvDetallePedidoProducto.Size = new System.Drawing.Size(744, 191);
            this.dgvDetallePedidoProducto.TabIndex = 24;
            this.dgvDetallePedidoProducto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetallePedidoProducto_CellClick);
            this.dgvDetallePedidoProducto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetallePedidoProducto_CellContentClick);
            this.dgvDetallePedidoProducto.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetallePedidoProducto_CellMouseEnter);
            this.dgvDetallePedidoProducto.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetallePedidoProducto_CellMouseLeave);
            this.dgvDetallePedidoProducto.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetallePedidoProducto_CellValueChanged);
            this.dgvDetallePedidoProducto.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvDetallePedidoProducto_EditingControlShowing);
            this.dgvDetallePedidoProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvDetallePedidoProducto_KeyPress);
            // 
            // IdProducto
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.IdProducto.DefaultCellStyle = dataGridViewCellStyle2;
            this.IdProducto.HeaderText = "Cod.";
            this.IdProducto.Name = "IdProducto";
            this.IdProducto.ReadOnly = true;
            this.IdProducto.Width = 50;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            this.Producto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Producto.Width = 130;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Descripcion.Width = 210;
            // 
            // IdPrecio
            // 
            this.IdPrecio.HeaderText = "IdPrecio";
            this.IdPrecio.Name = "IdPrecio";
            this.IdPrecio.Visible = false;
            // 
            // Precio
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.Precio.DefaultCellStyle = dataGridViewCellStyle3;
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Precio.Width = 80;
            // 
            // Stock
            // 
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            this.Stock.Visible = false;
            // 
            // Cantidad
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.Cantidad.DefaultCellStyle = dataGridViewCellStyle4;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Cantidad.Width = 80;
            // 
            // Total
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.Total.DefaultCellStyle = dataGridViewCellStyle5;
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Total.Width = 80;
            // 
            // btnQuitarProducto
            // 
            this.btnQuitarProducto.HeaderText = "Opción";
            this.btnQuitarProducto.Name = "btnQuitarProducto";
            this.btnQuitarProducto.Text = "Quitar";
            this.btnQuitarProducto.UseColumnTextForButtonValue = true;
            this.btnQuitarProducto.Width = 70;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.cbFormaPago);
            this.groupBox7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(46, 262);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(247, 82);
            this.groupBox7.TabIndex = 32;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "FORMA DE PAGO";
            // 
            // cbFormaPago
            // 
            this.cbFormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFormaPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFormaPago.FormattingEnabled = true;
            this.cbFormaPago.Location = new System.Drawing.Point(100, 33);
            this.cbFormaPago.Name = "cbFormaPago";
            this.cbFormaPago.Size = new System.Drawing.Size(124, 24);
            this.cbFormaPago.TabIndex = 6;
            this.cbFormaPago.SelectedIndexChanged += new System.EventHandler(this.cbFormaPago_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 21.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label16.Location = new System.Drawing.Point(191, 3);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(479, 36);
            this.label16.TabIndex = 69;
            this.label16.Text = "Registro de Ventas de Productos";
            // 
            // txtCambio
            // 
            this.txtCambio.BackColor = System.Drawing.SystemColors.Control;
            this.txtCambio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCambio.Location = new System.Drawing.Point(634, 602);
            this.txtCambio.Name = "txtCambio";
            this.txtCambio.ReadOnly = true;
            this.txtCambio.Size = new System.Drawing.Size(88, 22);
            this.txtCambio.TabIndex = 72;
            this.txtCambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCambio.Visible = false;
            // 
            // lbCambio
            // 
            this.lbCambio.AutoSize = true;
            this.lbCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCambio.Location = new System.Drawing.Point(567, 604);
            this.lbCambio.Name = "lbCambio";
            this.lbCambio.Size = new System.Drawing.Size(55, 16);
            this.lbCambio.TabIndex = 71;
            this.lbCambio.Text = "Cambio";
            this.lbCambio.Visible = false;
            // 
            // lbEfectivo
            // 
            this.lbEfectivo.AutoSize = true;
            this.lbEfectivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEfectivo.Location = new System.Drawing.Point(567, 579);
            this.lbEfectivo.Name = "lbEfectivo";
            this.lbEfectivo.Size = new System.Drawing.Size(56, 16);
            this.lbEfectivo.TabIndex = 73;
            this.lbEfectivo.Text = "Efectivo";
            this.lbEfectivo.Visible = false;
            // 
            // txtEfectivo
            // 
            this.txtEfectivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEfectivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEfectivo.Location = new System.Drawing.Point(634, 577);
            this.txtEfectivo.Name = "txtEfectivo";
            this.txtEfectivo.Size = new System.Drawing.Size(88, 22);
            this.txtEfectivo.TabIndex = 75;
            this.txtEfectivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtEfectivo.Visible = false;
            this.txtEfectivo.TextChanged += new System.EventHandler(this.txtEfectivo_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(726, 554);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 16);
            this.label12.TabIndex = 76;
            this.label12.Text = "Bs.-";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(726, 579);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 16);
            this.label13.TabIndex = 77;
            this.label13.Text = "Bs.-";
            this.label13.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(726, 605);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 16);
            this.label14.TabIndex = 78;
            this.label14.Text = "Bs.-";
            this.label14.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(36, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 16);
            this.label9.TabIndex = 1;
            this.label9.Text = "Saldo Crédito:";
            // 
            // txtMontoCredito
            // 
            this.txtMontoCredito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMontoCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoCredito.Location = new System.Drawing.Point(136, 50);
            this.txtMontoCredito.Name = "txtMontoCredito";
            this.txtMontoCredito.ReadOnly = true;
            this.txtMontoCredito.Size = new System.Drawing.Size(110, 22);
            this.txtMontoCredito.TabIndex = 3;
            this.txtMontoCredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(314, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Fecha de Plazo:";
            // 
            // dtpFechaPlazo
            // 
            this.dtpFechaPlazo.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaPlazo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaPlazo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaPlazo.Location = new System.Drawing.Point(315, 47);
            this.dtpFechaPlazo.Name = "dtpFechaPlazo";
            this.dtpFechaPlazo.Size = new System.Drawing.Size(119, 22);
            this.dtpFechaPlazo.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(36, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 16);
            this.label11.TabIndex = 17;
            this.label11.Text = "Cuota Inicial:";
            // 
            // txtCuotaInicial
            // 
            this.txtCuotaInicial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCuotaInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuotaInicial.Location = new System.Drawing.Point(136, 21);
            this.txtCuotaInicial.Name = "txtCuotaInicial";
            this.txtCuotaInicial.Size = new System.Drawing.Size(110, 22);
            this.txtCuotaInicial.TabIndex = 18;
            this.txtCuotaInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCuotaInicial.TextChanged += new System.EventHandler(this.txtCuotaInicial_TextChanged);
            this.txtCuotaInicial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCuotaInicial_KeyPress);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtCuotaInicial);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.dtpFechaPlazo);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.txtMontoCredito);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(314, 262);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(475, 82);
            this.groupBox6.TabIndex = 70;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "CRÉDITO";
            this.groupBox6.Visible = false;
            // 
            // FrmVentaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(825, 683);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtEfectivo);
            this.Controls.Add(this.lbEfectivo);
            this.Controls.Add(this.txtCambio);
            this.Controls.Add(this.lbCambio);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.txtMontoTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dgvDetallePedidoProducto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmVentaProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Información - Venta de Producto";
            this.Load += new System.EventHandler(this.FrmVenta_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallePedidoProducto)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGenerarFactura;
        private System.Windows.Forms.Button btnGuardarPedidoProducto;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.GroupBox groupBox7;
        public System.Windows.Forms.DataGridView dgvDetallePedidoProducto;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtNombreProductoServicio;
        public System.Windows.Forms.TextBox txtCedulaNit;
        public System.Windows.Forms.TextBox txtNombreCliente;
        public System.Windows.Forms.DateTimePicker dtpFechaVenta;
        public System.Windows.Forms.TextBox txtIdpedido;
        public System.Windows.Forms.TextBox txtMontoTotal;
        public System.Windows.Forms.TextBox txtCambio;
        private System.Windows.Forms.Label lbCambio;
        private System.Windows.Forms.Label lbEfectivo;
        private System.Windows.Forms.TextBox txtEfectivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewButtonColumn btnQuitarProducto;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox cbFormaPago;
        public System.Windows.Forms.Button btnBuscarCliente;
        public System.Windows.Forms.Button btnNuevoCliente;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMontoCredito;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.DateTimePicker dtpFechaPlazo;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox txtCuotaInicial;
        public System.Windows.Forms.GroupBox groupBox6;
    }
}