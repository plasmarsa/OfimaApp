namespace CtrolAlmacenMantenimiento
{
    partial class ctrolEntradaRepuesto
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrolEntradaRepuesto));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmbProveedor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbRepuesto = new System.Windows.Forms.ComboBox();
            this.txtFactura = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOrden = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.gridMov = new System.Windows.Forms.DataGridView();
            this.tblMantenMovRepuestoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dFecha = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.lblRepuesto = new System.Windows.Forms.Label();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.chkOrden = new System.Windows.Forms.CheckBox();
            this.btnAddItemsOrden = new System.Windows.Forms.PictureBox();
            this.gridOrden = new System.Windows.Forms.DataGridView();
            this.btnOrdenAdd = new System.Windows.Forms.Button();
            this.clfecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clOrden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clrepuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cldescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clcantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clvalor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMovDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaHoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProyectoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codMaquinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTecnicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codCCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordenCompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facturaProveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.integradoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionOrden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clvalorunit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridMov)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMantenMovRepuestoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddItemsOrden)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrden)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbProveedor
            // 
            this.cmbProveedor.DropDownHeight = 100;
            this.cmbProveedor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProveedor.FormattingEnabled = true;
            this.cmbProveedor.IntegralHeight = false;
            this.cmbProveedor.Location = new System.Drawing.Point(141, 7);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Size = new System.Drawing.Size(362, 25);
            this.cmbProveedor.TabIndex = 0;
            this.cmbProveedor.SelectedIndexChanged += new System.EventHandler(this.cmbProveedor_SelectedIndexChanged);
            this.cmbProveedor.TextUpdate += new System.EventHandler(this.cmbProveedor_TextUpdate);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(60, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Proveedor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(67, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Repuesto";
            // 
            // cmbRepuesto
            // 
            this.cmbRepuesto.DropDownHeight = 100;
            this.cmbRepuesto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRepuesto.FormattingEnabled = true;
            this.cmbRepuesto.IntegralHeight = false;
            this.cmbRepuesto.Location = new System.Drawing.Point(141, 33);
            this.cmbRepuesto.Name = "cmbRepuesto";
            this.cmbRepuesto.Size = new System.Drawing.Size(362, 25);
            this.cmbRepuesto.TabIndex = 2;
            this.cmbRepuesto.SelectedIndexChanged += new System.EventHandler(this.cmbRepuesto_SelectedIndexChanged);
            this.cmbRepuesto.TextUpdate += new System.EventHandler(this.cmbRepuesto_TextUpdate);
            this.cmbRepuesto.Validating += new System.ComponentModel.CancelEventHandler(this.cmbRepuesto_Validating);
            this.cmbRepuesto.Validated += new System.EventHandler(this.cmbRepuesto_Validated);
            // 
            // txtFactura
            // 
            this.txtFactura.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFactura.Location = new System.Drawing.Point(141, 59);
            this.txtFactura.Name = "txtFactura";
            this.txtFactura.Size = new System.Drawing.Size(207, 23);
            this.txtFactura.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(78, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Factura";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(87, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Orden";
            // 
            // txtOrden
            // 
            this.txtOrden.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrden.Location = new System.Drawing.Point(141, 83);
            this.txtOrden.Name = "txtOrden";
            this.txtOrden.Size = new System.Drawing.Size(207, 23);
            this.txtOrden.TabIndex = 6;
            this.txtOrden.TextChanged += new System.EventHandler(this.txtOrden_TextChanged);
            this.txtOrden.Validating += new System.ComponentModel.CancelEventHandler(this.txtOrden_Validating);
            this.txtOrden.Validated += new System.EventHandler(this.txtOrden_Validated);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(412, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 24);
            this.label5.TabIndex = 15;
            this.label5.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(522, 79);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(133, 47);
            this.txtCantidad.TabIndex = 14;
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            this.txtCantidad.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCantidad_KeyUp);
            this.txtCantidad.Validated += new System.EventHandler(this.txtCantidad_Validated);
            // 
            // gridMov
            // 
            this.gridMov.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridMov.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridMov.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMov.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMovDataGridViewTextBoxColumn,
            this.fechaHoraDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn,
            this.proveedorDataGridViewTextBoxColumn,
            this.codProductoDataGridViewTextBoxColumn,
            this.idProyectoDataGridViewTextBoxColumn,
            this.codMaquinaDataGridViewTextBoxColumn,
            this.idTecnicoDataGridViewTextBoxColumn,
            this.codCCDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.ordenCompraDataGridViewTextBoxColumn,
            this.facturaProveedorDataGridViewTextBoxColumn,
            this.observacionDataGridViewTextBoxColumn,
            this.integradoDataGridViewTextBoxColumn,
            this.DescripcionOrden,
            this.clvalorunit});
            this.gridMov.DataSource = this.tblMantenMovRepuestoBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridMov.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridMov.Location = new System.Drawing.Point(24, 148);
            this.gridMov.Name = "gridMov";
            this.gridMov.Size = new System.Drawing.Size(754, 311);
            this.gridMov.TabIndex = 16;
            // 
            // tblMantenMovRepuestoBindingSource
            // 
            this.tblMantenMovRepuestoBindingSource.DataSource = typeof(Dataccess.tblMantenMovRepuesto);
            // 
            // dFecha
            // 
            this.dFecha.CustomFormat = "\"dd/MM/yyyy\"";
            this.dFecha.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dFecha.Location = new System.Drawing.Point(141, 107);
            this.dFecha.Name = "dFecha";
            this.dFecha.Size = new System.Drawing.Size(122, 23);
            this.dFecha.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(88, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Fecha";
            // 
            // lblRepuesto
            // 
            this.lblRepuesto.AutoSize = true;
            this.lblRepuesto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepuesto.ForeColor = System.Drawing.Color.Black;
            this.lblRepuesto.Location = new System.Drawing.Point(525, 34);
            this.lblRepuesto.Name = "lblRepuesto";
            this.lblRepuesto.Size = new System.Drawing.Size(15, 17);
            this.lblRepuesto.TabIndex = 20;
            this.lblRepuesto.Text = "_";
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedor.ForeColor = System.Drawing.Color.Black;
            this.lblProveedor.Location = new System.Drawing.Point(525, 8);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(15, 17);
            this.lblProveedor.TabIndex = 19;
            this.lblProveedor.Text = "_";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAdicionar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAdicionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(211)))), ((int)(((byte)(19)))));
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.ForeColor = System.Drawing.Color.White;
            this.btnAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionar.Image")));
            this.btnAdicionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdicionar.Location = new System.Drawing.Point(678, 75);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(100, 35);
            this.btnAdicionar.TabIndex = 55;
            this.btnAdicionar.Text = "Agregar";
            this.btnAdicionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(211)))), ((int)(((byte)(19)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(678, 111);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 35);
            this.btnGuardar.TabIndex = 56;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // chkOrden
            // 
            this.chkOrden.AutoSize = true;
            this.chkOrden.Location = new System.Drawing.Point(355, 86);
            this.chkOrden.Name = "chkOrden";
            this.chkOrden.Size = new System.Drawing.Size(15, 14);
            this.chkOrden.TabIndex = 57;
            this.chkOrden.UseVisualStyleBackColor = true;
            this.chkOrden.CheckedChanged += new System.EventHandler(this.chkOrden_CheckedChanged);
            // 
            // btnAddItemsOrden
            // 
            this.btnAddItemsOrden.InitialImage = null;
            this.btnAddItemsOrden.Location = new System.Drawing.Point(24, 62);
            this.btnAddItemsOrden.Name = "btnAddItemsOrden";
            this.btnAddItemsOrden.Size = new System.Drawing.Size(32, 32);
            this.btnAddItemsOrden.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAddItemsOrden.TabIndex = 59;
            this.btnAddItemsOrden.TabStop = false;
            this.btnAddItemsOrden.Tag = "Guardar control";
            this.btnAddItemsOrden.Visible = false;
            this.btnAddItemsOrden.Click += new System.EventHandler(this.btnAddItemsOrden_Click);
            // 
            // gridOrden
            // 
            this.gridOrden.AllowUserToAddRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridOrden.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridOrden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridOrden.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clfecha,
            this.clnit,
            this.clOrden,
            this.clrepuesto,
            this.cldescripcion,
            this.clcantidad,
            this.clvalor});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridOrden.DefaultCellStyle = dataGridViewCellStyle5;
            this.gridOrden.Location = new System.Drawing.Point(24, 148);
            this.gridOrden.Name = "gridOrden";
            this.gridOrden.Size = new System.Drawing.Size(620, 311);
            this.gridOrden.TabIndex = 60;
            this.gridOrden.Visible = false;
            // 
            // btnOrdenAdd
            // 
            this.btnOrdenAdd.BackColor = System.Drawing.Color.SteelBlue;
            this.btnOrdenAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnOrdenAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(211)))), ((int)(((byte)(19)))));
            this.btnOrdenAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrdenAdd.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenAdd.ForeColor = System.Drawing.Color.White;
            this.btnOrdenAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnOrdenAdd.Image")));
            this.btnOrdenAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrdenAdd.Location = new System.Drawing.Point(649, 148);
            this.btnOrdenAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnOrdenAdd.Name = "btnOrdenAdd";
            this.btnOrdenAdd.Size = new System.Drawing.Size(129, 35);
            this.btnOrdenAdd.TabIndex = 61;
            this.btnOrdenAdd.Text = "Agregar Items";
            this.btnOrdenAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOrdenAdd.UseVisualStyleBackColor = false;
            this.btnOrdenAdd.Visible = false;
            this.btnOrdenAdd.Click += new System.EventHandler(this.btnOrdenAdd_Click);
            // 
            // clfecha
            // 
            this.clfecha.HeaderText = "Fecha";
            this.clfecha.Name = "clfecha";
            this.clfecha.ReadOnly = true;
            this.clfecha.Visible = false;
            // 
            // clnit
            // 
            this.clnit.HeaderText = "Nit";
            this.clnit.Name = "clnit";
            this.clnit.ReadOnly = true;
            this.clnit.Visible = false;
            // 
            // clOrden
            // 
            this.clOrden.HeaderText = "Orden";
            this.clOrden.Name = "clOrden";
            this.clOrden.ReadOnly = true;
            // 
            // clrepuesto
            // 
            this.clrepuesto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clrepuesto.HeaderText = "Repuesto";
            this.clrepuesto.Name = "clrepuesto";
            this.clrepuesto.ReadOnly = true;
            this.clrepuesto.Width = 89;
            // 
            // cldescripcion
            // 
            this.cldescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cldescripcion.HeaderText = "Descripcion";
            this.cldescripcion.Name = "cldescripcion";
            this.cldescripcion.ReadOnly = true;
            this.cldescripcion.Width = 104;
            // 
            // clcantidad
            // 
            this.clcantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = "0";
            this.clcantidad.DefaultCellStyle = dataGridViewCellStyle4;
            this.clcantidad.HeaderText = "Cantidad";
            this.clcantidad.Name = "clcantidad";
            this.clcantidad.Width = 89;
            // 
            // clvalor
            // 
            this.clvalor.HeaderText = "Valor Unit";
            this.clvalor.Name = "clvalor";
            // 
            // idMovDataGridViewTextBoxColumn
            // 
            this.idMovDataGridViewTextBoxColumn.DataPropertyName = "IdMov";
            this.idMovDataGridViewTextBoxColumn.HeaderText = "IdMov";
            this.idMovDataGridViewTextBoxColumn.Name = "idMovDataGridViewTextBoxColumn";
            this.idMovDataGridViewTextBoxColumn.Visible = false;
            // 
            // fechaHoraDataGridViewTextBoxColumn
            // 
            this.fechaHoraDataGridViewTextBoxColumn.DataPropertyName = "Fecha_Hora";
            this.fechaHoraDataGridViewTextBoxColumn.HeaderText = "Fecha_Hora";
            this.fechaHoraDataGridViewTextBoxColumn.Name = "fechaHoraDataGridViewTextBoxColumn";
            this.fechaHoraDataGridViewTextBoxColumn.Visible = false;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            this.tipoDataGridViewTextBoxColumn.Visible = false;
            // 
            // proveedorDataGridViewTextBoxColumn
            // 
            this.proveedorDataGridViewTextBoxColumn.DataPropertyName = "Proveedor";
            this.proveedorDataGridViewTextBoxColumn.HeaderText = "Proveedor";
            this.proveedorDataGridViewTextBoxColumn.Name = "proveedorDataGridViewTextBoxColumn";
            // 
            // codProductoDataGridViewTextBoxColumn
            // 
            this.codProductoDataGridViewTextBoxColumn.DataPropertyName = "CodProducto";
            this.codProductoDataGridViewTextBoxColumn.HeaderText = "Repuesto";
            this.codProductoDataGridViewTextBoxColumn.Name = "codProductoDataGridViewTextBoxColumn";
            // 
            // idProyectoDataGridViewTextBoxColumn
            // 
            this.idProyectoDataGridViewTextBoxColumn.DataPropertyName = "IdProyecto";
            this.idProyectoDataGridViewTextBoxColumn.HeaderText = "IdProyecto";
            this.idProyectoDataGridViewTextBoxColumn.Name = "idProyectoDataGridViewTextBoxColumn";
            this.idProyectoDataGridViewTextBoxColumn.Visible = false;
            // 
            // codMaquinaDataGridViewTextBoxColumn
            // 
            this.codMaquinaDataGridViewTextBoxColumn.DataPropertyName = "CodMaquina";
            this.codMaquinaDataGridViewTextBoxColumn.HeaderText = "CodMaquina";
            this.codMaquinaDataGridViewTextBoxColumn.Name = "codMaquinaDataGridViewTextBoxColumn";
            this.codMaquinaDataGridViewTextBoxColumn.Visible = false;
            // 
            // idTecnicoDataGridViewTextBoxColumn
            // 
            this.idTecnicoDataGridViewTextBoxColumn.DataPropertyName = "IdTecnico";
            this.idTecnicoDataGridViewTextBoxColumn.HeaderText = "IdTecnico";
            this.idTecnicoDataGridViewTextBoxColumn.Name = "idTecnicoDataGridViewTextBoxColumn";
            this.idTecnicoDataGridViewTextBoxColumn.Visible = false;
            // 
            // codCCDataGridViewTextBoxColumn
            // 
            this.codCCDataGridViewTextBoxColumn.DataPropertyName = "CodCC";
            this.codCCDataGridViewTextBoxColumn.HeaderText = "CodCC";
            this.codCCDataGridViewTextBoxColumn.Name = "codCCDataGridViewTextBoxColumn";
            this.codCCDataGridViewTextBoxColumn.Visible = false;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            // 
            // ordenCompraDataGridViewTextBoxColumn
            // 
            this.ordenCompraDataGridViewTextBoxColumn.DataPropertyName = "OrdenCompra";
            this.ordenCompraDataGridViewTextBoxColumn.HeaderText = "Orden";
            this.ordenCompraDataGridViewTextBoxColumn.Name = "ordenCompraDataGridViewTextBoxColumn";
            // 
            // facturaProveedorDataGridViewTextBoxColumn
            // 
            this.facturaProveedorDataGridViewTextBoxColumn.DataPropertyName = "FacturaProveedor";
            this.facturaProveedorDataGridViewTextBoxColumn.HeaderText = "Factura";
            this.facturaProveedorDataGridViewTextBoxColumn.Name = "facturaProveedorDataGridViewTextBoxColumn";
            // 
            // observacionDataGridViewTextBoxColumn
            // 
            this.observacionDataGridViewTextBoxColumn.DataPropertyName = "Observacion";
            this.observacionDataGridViewTextBoxColumn.HeaderText = "Observacion";
            this.observacionDataGridViewTextBoxColumn.Name = "observacionDataGridViewTextBoxColumn";
            this.observacionDataGridViewTextBoxColumn.Visible = false;
            // 
            // integradoDataGridViewTextBoxColumn
            // 
            this.integradoDataGridViewTextBoxColumn.DataPropertyName = "Integrado";
            this.integradoDataGridViewTextBoxColumn.HeaderText = "Integrado";
            this.integradoDataGridViewTextBoxColumn.Name = "integradoDataGridViewTextBoxColumn";
            this.integradoDataGridViewTextBoxColumn.Visible = false;
            // 
            // DescripcionOrden
            // 
            this.DescripcionOrden.DataPropertyName = "DescripcionOrden";
            this.DescripcionOrden.HeaderText = "DescripcionOrden";
            this.DescripcionOrden.Name = "DescripcionOrden";
            this.DescripcionOrden.Visible = false;
            // 
            // clvalorunit
            // 
            this.clvalorunit.HeaderText = "Valor Unit";
            this.clvalorunit.Name = "clvalorunit";
            // 
            // ctrolEntradaRepuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnOrdenAdd);
            this.Controls.Add(this.gridOrden);
            this.Controls.Add(this.btnAddItemsOrden);
            this.Controls.Add(this.chkOrden);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.lblRepuesto);
            this.Controls.Add(this.lblProveedor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dFecha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtOrden);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFactura);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbRepuesto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbProveedor);
            this.Controls.Add(this.gridMov);
            this.Name = "ctrolEntradaRepuesto";
            this.Size = new System.Drawing.Size(800, 480);
            this.Load += new System.EventHandler(this.ctrolEntradaRepuesto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridMov)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMantenMovRepuestoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddItemsOrden)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrden)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbProveedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbRepuesto;
        private System.Windows.Forms.TextBox txtFactura;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOrden;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.DataGridView gridMov;
        private System.Windows.Forms.DateTimePicker dFecha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblRepuesto;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.CheckBox chkOrden;
        private System.Windows.Forms.PictureBox btnAddItemsOrden;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn orden;
        private System.Windows.Forms.DataGridViewTextBoxColumn repuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.BindingSource tblMantenMovRepuestoBindingSource;
        private System.Windows.Forms.Button btnOrdenAdd;
        private System.Windows.Forms.DataGridView gridOrden;
        private System.Windows.Forms.DataGridViewTextBoxColumn productoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroDctoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoRepuestoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clfecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn clOrden;
        private System.Windows.Forms.DataGridViewTextBoxColumn clrepuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cldescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn clcantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn clvalor;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMovDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaHoraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn proveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProyectoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codMaquinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTecnicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codCCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordenCompraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn facturaProveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn integradoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionOrden;
        private System.Windows.Forms.DataGridViewTextBoxColumn clvalorunit;
    }
}
