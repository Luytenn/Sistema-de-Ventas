namespace capaPresentacion
{
    partial class FrmIngreso
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdproveedor = new System.Windows.Forms.TextBox();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.chkAnular = new System.Windows.Forms.CheckBox();
            this.ttMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.dataListado = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dtFecha2 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dtFecha1 = new System.Windows.Forms.DateTimePicker();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage = new System.Windows.Forms.TabPage();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.dataListadoDetalle = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtIdarticulo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPrecio_Venta = new System.Windows.Forms.TextBox();
            this.txtPrecioCompra = new System.Windows.Forms.TextBox();
            this.dtFechaVen = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.dtFechaPro = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtArticulo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblTotal_Pagado = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIdingreso = new System.Windows.Forms.TextBox();
            this.cbTipo_comprobante = new System.Windows.Forms.ComboBox();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtIgv = new System.Windows.Forms.TextBox();
            this.txtCorrelativo = new System.Windows.Forms.TextBox();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.label17 = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnAnular = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnBuscarArticulo = new System.Windows.Forms.Button();
            this.btnBuscarProveedor = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage.SuspendLayout();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListadoDetalle)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(31, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ingresos Almacén";
            // 
            // txtIdproveedor
            // 
            this.txtIdproveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtIdproveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdproveedor.Location = new System.Drawing.Point(717, 76);
            this.txtIdproveedor.Name = "txtIdproveedor";
            this.txtIdproveedor.Size = new System.Drawing.Size(50, 20);
            this.txtIdproveedor.TabIndex = 17;
            // 
            // txtProveedor
            // 
            this.txtProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtProveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProveedor.Location = new System.Drawing.Point(320, 34);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(137, 20);
            this.txtProveedor.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fecha Inicio:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(424, 79);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(35, 13);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "label3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Comprobante:";
            // 
            // chkAnular
            // 
            this.chkAnular.AutoSize = true;
            this.chkAnular.Location = new System.Drawing.Point(35, 78);
            this.chkAnular.Name = "chkAnular";
            this.chkAnular.Size = new System.Drawing.Size(56, 17);
            this.chkAnular.TabIndex = 5;
            this.chkAnular.Text = "Anular";
            this.chkAnular.UseVisualStyleBackColor = true;
            this.chkAnular.CheckedChanged += new System.EventHandler(this.ChkEliminar_CheckedChanged);
            // 
            // ttMensaje
            // 
            this.ttMensaje.IsBalloon = true;
            // 
            // dataListado
            // 
            this.dataListado.AllowUserToAddRows = false;
            this.dataListado.AllowUserToDeleteRows = false;
            this.dataListado.AllowUserToOrderColumns = true;
            this.dataListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.dataListado.Location = new System.Drawing.Point(25, 106);
            this.dataListado.MultiSelect = false;
            this.dataListado.Name = "dataListado";
            this.dataListado.ReadOnly = true;
            this.dataListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataListado.Size = new System.Drawing.Size(923, 351);
            this.dataListado.TabIndex = 7;
            this.dataListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataListado_CellContentClick);
            this.dataListado.DoubleClick += new System.EventHandler(this.DataListado_DoubleClick);
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.TrueValue = "TRUE";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dtFecha2);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.dtFecha1);
            this.tabPage1.Controls.Add(this.dataListado);
            this.tabPage1.Controls.Add(this.lblTotal);
            this.tabPage1.Controls.Add(this.chkAnular);
            this.tabPage1.Controls.Add(this.btnImprimir);
            this.tabPage1.Controls.Add(this.btnAnular);
            this.tabPage1.Controls.Add(this.btnBuscar);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(981, 481);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dtFecha2
            // 
            this.dtFecha2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha2.Location = new System.Drawing.Point(204, 35);
            this.dtFecha2.Name = "dtFecha2";
            this.dtFecha2.Size = new System.Drawing.Size(105, 20);
            this.dtFecha2.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(201, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Fecha Fin:";
            // 
            // dtFecha1
            // 
            this.dtFecha1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha1.Location = new System.Drawing.Point(35, 35);
            this.dtFecha1.Name = "dtFecha1";
            this.dtFecha1.Size = new System.Drawing.Size(107, 20);
            this.dtFecha1.TabIndex = 8;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage);
            this.tabControl1.Location = new System.Drawing.Point(12, 72);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(989, 507);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage
            // 
            this.tabPage.Controls.Add(this.groupBox);
            this.tabPage.Location = new System.Drawing.Point(4, 22);
            this.tabPage.Name = "tabPage";
            this.tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage.Size = new System.Drawing.Size(981, 481);
            this.tabPage.TabIndex = 1;
            this.tabPage.Text = " Mantenimiento";
            this.tabPage.UseVisualStyleBackColor = true;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.label16);
            this.groupBox.Controls.Add(this.dataListadoDetalle);
            this.groupBox.Controls.Add(this.groupBox2);
            this.groupBox.Controls.Add(this.label11);
            this.groupBox.Controls.Add(this.lblTotal_Pagado);
            this.groupBox.Controls.Add(this.label9);
            this.groupBox.Controls.Add(this.txtIdingreso);
            this.groupBox.Controls.Add(this.cbTipo_comprobante);
            this.groupBox.Controls.Add(this.dtFecha);
            this.groupBox.Controls.Add(this.label7);
            this.groupBox.Controls.Add(this.label10);
            this.groupBox.Controls.Add(this.btnBuscarProveedor);
            this.groupBox.Controls.Add(this.txtIdproveedor);
            this.groupBox.Controls.Add(this.txtProveedor);
            this.groupBox.Controls.Add(this.label6);
            this.groupBox.Controls.Add(this.btnGuardar);
            this.groupBox.Controls.Add(this.btnCancelar);
            this.groupBox.Controls.Add(this.btnNuevo);
            this.groupBox.Controls.Add(this.txtIgv);
            this.groupBox.Controls.Add(this.txtCorrelativo);
            this.groupBox.Controls.Add(this.txtSerie);
            this.groupBox.Controls.Add(this.label3);
            this.groupBox.Location = new System.Drawing.Point(20, 24);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(940, 442);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Ingresos Almacén";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(40, 400);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(92, 13);
            this.label16.TabIndex = 31;
            this.label16.Text = "Total Pagado: S/.";
            // 
            // dataListadoDetalle
            // 
            this.dataListadoDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListadoDetalle.Location = new System.Drawing.Point(23, 252);
            this.dataListadoDetalle.Name = "dataListadoDetalle";
            this.dataListadoDetalle.Size = new System.Drawing.Size(876, 118);
            this.dataListadoDetalle.TabIndex = 28;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtIdarticulo);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnQuitar);
            this.groupBox2.Controls.Add(this.btnAgregar);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtPrecio_Venta);
            this.groupBox2.Controls.Add(this.txtPrecioCompra);
            this.groupBox2.Controls.Add(this.dtFechaVen);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.dtFechaPro);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txtStock);
            this.groupBox2.Controls.Add(this.txtArticulo);
            this.groupBox2.Controls.Add(this.btnBuscarArticulo);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(38, 111);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(861, 125);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            // 
            // txtIdarticulo
            // 
            this.txtIdarticulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtIdarticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdarticulo.Location = new System.Drawing.Point(6, 19);
            this.txtIdarticulo.Name = "txtIdarticulo";
            this.txtIdarticulo.Size = new System.Drawing.Size(65, 20);
            this.txtIdarticulo.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Stock Inicial:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(279, 75);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "Precio Venta:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(279, 46);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "Precio Compra:";
            // 
            // txtPrecio_Venta
            // 
            this.txtPrecio_Venta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtPrecio_Venta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecio_Venta.Location = new System.Drawing.Point(363, 73);
            this.txtPrecio_Venta.Name = "txtPrecio_Venta";
            this.txtPrecio_Venta.Size = new System.Drawing.Size(137, 20);
            this.txtPrecio_Venta.TabIndex = 15;
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtPrecioCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecioCompra.Location = new System.Drawing.Point(363, 44);
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.Size = new System.Drawing.Size(137, 20);
            this.txtPrecioCompra.TabIndex = 15;
            // 
            // dtFechaVen
            // 
            this.dtFechaVen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaVen.Location = new System.Drawing.Point(649, 74);
            this.dtFechaVen.Name = "dtFechaVen";
            this.dtFechaVen.Size = new System.Drawing.Size(113, 20);
            this.dtFechaVen.TabIndex = 23;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(528, 77);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(101, 13);
            this.label15.TabIndex = 22;
            this.label15.Text = "Fecha Vencimiento:";
            // 
            // dtFechaPro
            // 
            this.dtFechaPro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaPro.Location = new System.Drawing.Point(649, 44);
            this.dtFechaPro.Name = "dtFechaPro";
            this.dtFechaPro.Size = new System.Drawing.Size(106, 20);
            this.dtFechaPro.TabIndex = 23;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(528, 48);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 13);
            this.label14.TabIndex = 22;
            this.label14.Text = "Fecha Prodruccion:";
            // 
            // txtStock
            // 
            this.txtStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStock.Location = new System.Drawing.Point(87, 82);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(137, 20);
            this.txtStock.TabIndex = 15;
            // 
            // txtArticulo
            // 
            this.txtArticulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtArticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtArticulo.Location = new System.Drawing.Point(87, 46);
            this.txtArticulo.Name = "txtArticulo";
            this.txtArticulo.Size = new System.Drawing.Size(137, 20);
            this.txtArticulo.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Artículo:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(541, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "IGV:";
            // 
            // lblTotal_Pagado
            // 
            this.lblTotal_Pagado.AutoSize = true;
            this.lblTotal_Pagado.Location = new System.Drawing.Point(138, 400);
            this.lblTotal_Pagado.Name = "lblTotal_Pagado";
            this.lblTotal_Pagado.Size = new System.Drawing.Size(22, 13);
            this.lblTotal_Pagado.TabIndex = 28;
            this.lblTotal_Pagado.Text = "0.0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(268, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Número:";
            // 
            // txtIdingreso
            // 
            this.txtIdingreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtIdingreso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdingreso.Location = new System.Drawing.Point(93, 34);
            this.txtIdingreso.Name = "txtIdingreso";
            this.txtIdingreso.Size = new System.Drawing.Size(110, 20);
            this.txtIdingreso.TabIndex = 17;
            // 
            // cbTipo_comprobante
            // 
            this.cbTipo_comprobante.FormattingEnabled = true;
            this.cbTipo_comprobante.Items.AddRange(new object[] {
            "TICKET",
            "BOLETA",
            "FACTURA",
            "GUIA REMISIÓN"});
            this.cbTipo_comprobante.Location = new System.Drawing.Point(111, 67);
            this.cbTipo_comprobante.Name = "cbTipo_comprobante";
            this.cbTipo_comprobante.Size = new System.Drawing.Size(121, 21);
            this.cbTipo_comprobante.TabIndex = 24;
            this.cbTipo_comprobante.Text = "TICKET";
            // 
            // dtFecha
            // 
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha.Location = new System.Drawing.Point(593, 37);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(200, 20);
            this.dtFecha.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(534, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Fecha:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(255, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Proveedor:";
            // 
            // txtIgv
            // 
            this.txtIgv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtIgv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIgv.Location = new System.Drawing.Point(588, 75);
            this.txtIgv.Name = "txtIgv";
            this.txtIgv.Size = new System.Drawing.Size(94, 20);
            this.txtIgv.TabIndex = 4;
            // 
            // txtCorrelativo
            // 
            this.txtCorrelativo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtCorrelativo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCorrelativo.Location = new System.Drawing.Point(400, 76);
            this.txtCorrelativo.Name = "txtCorrelativo";
            this.txtCorrelativo.Size = new System.Drawing.Size(94, 20);
            this.txtCorrelativo.TabIndex = 4;
            // 
            // txtSerie
            // 
            this.txtSerie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtSerie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSerie.Location = new System.Drawing.Point(321, 76);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(66, 20);
            this.txtSerie.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Código:";
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // label17
            // 
            this.label17.Image = global::capaPresentacion.Properties.Resources.ingreso_almacen;
            this.label17.Location = new System.Drawing.Point(278, 9);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(97, 69);
            this.label17.TabIndex = 12;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Image = global::capaPresentacion.Properties.Resources.printer_78349;
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.Location = new System.Drawing.Point(759, 25);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(87, 45);
            this.btnImprimir.TabIndex = 4;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnAnular
            // 
            this.btnAnular.Image = global::capaPresentacion.Properties.Resources._1486564399_close_81512;
            this.btnAnular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnular.Location = new System.Drawing.Point(637, 25);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(94, 45);
            this.btnAnular.TabIndex = 3;
            this.btnAnular.Text = "Anular";
            this.btnAnular.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAnular.UseVisualStyleBackColor = true;
            this.btnAnular.Click += new System.EventHandler(this.BtnAnular_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::capaPresentacion.Properties.Resources.loupe_78956;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(526, 25);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(89, 45);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.BackgroundImage = global::capaPresentacion.Properties.Resources.minus_1_;
            this.btnQuitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuitar.Location = new System.Drawing.Point(770, 67);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(40, 35);
            this.btnQuitar.TabIndex = 30;
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.BtnQuitar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackgroundImage = global::capaPresentacion.Properties.Resources.plus_1_;
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregar.Location = new System.Drawing.Point(770, 26);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(40, 35);
            this.btnAgregar.TabIndex = 29;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // btnBuscarArticulo
            // 
            this.btnBuscarArticulo.BackgroundImage = global::capaPresentacion.Properties.Resources.loupe_78956;
            this.btnBuscarArticulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarArticulo.Location = new System.Drawing.Point(233, 38);
            this.btnBuscarArticulo.Name = "btnBuscarArticulo";
            this.btnBuscarArticulo.Size = new System.Drawing.Size(40, 32);
            this.btnBuscarArticulo.TabIndex = 18;
            this.btnBuscarArticulo.UseVisualStyleBackColor = true;
            this.btnBuscarArticulo.Click += new System.EventHandler(this.BtnBuscarArticulo_Click);
            // 
            // btnBuscarProveedor
            // 
            this.btnBuscarProveedor.BackgroundImage = global::capaPresentacion.Properties.Resources.loupe_78956;
            this.btnBuscarProveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarProveedor.Location = new System.Drawing.Point(463, 25);
            this.btnBuscarProveedor.Name = "btnBuscarProveedor";
            this.btnBuscarProveedor.Size = new System.Drawing.Size(40, 32);
            this.btnBuscarProveedor.TabIndex = 18;
            this.btnBuscarProveedor.UseVisualStyleBackColor = true;
            this.btnBuscarProveedor.Click += new System.EventHandler(this.BtnBuscarProveedor_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = global::capaPresentacion.Properties.Resources.diskette;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(630, 386);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(93, 41);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::capaPresentacion.Properties.Resources.menos2;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(746, 386);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(101, 41);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::capaPresentacion.Properties.Resources.folder;
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(510, 386);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(94, 41);
            this.btnNuevo.TabIndex = 6;
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // FrmIngreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1013, 585);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmIngreso";
            this.Text = "FrmIngreso";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmIngreso_FormClosing);
            this.Load += new System.EventHandler(this.FrmIngreso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage.ResumeLayout(false);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListadoDetalle)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscarProveedor;
        private System.Windows.Forms.TextBox txtIdproveedor;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.Button btnAnular;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.CheckBox chkAnular;
        private System.Windows.Forms.ToolTip ttMensaje;
        private System.Windows.Forms.DataGridView dataListado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorIcono;
        private System.Windows.Forms.DateTimePicker dtFecha2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtFecha1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbTipo_comprobante;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtIgv;
        private System.Windows.Forms.TextBox txtCorrelativo;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtArticulo;
        private System.Windows.Forms.Button btnBuscarArticulo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblTotal_Pagado;
        private System.Windows.Forms.TextBox txtPrecio_Venta;
        private System.Windows.Forms.TextBox txtPrecioCompra;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtIdingreso;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DateTimePicker dtFechaVen;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dtFechaPro;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView dataListadoDetalle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIdarticulo;
        private System.Windows.Forms.Label label17;
    }
}