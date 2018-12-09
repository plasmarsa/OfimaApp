namespace CtrolAlmacenMantenimiento
{
    partial class ctrolSalidaRepuesto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrolSalidaRepuesto));
            this.cmbCatalogo = new System.Windows.Forms.ComboBox();
            this.chkCatalogo = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbMaquina = new System.Windows.Forms.ComboBox();
            this.labelMaquina = new System.Windows.Forms.Label();
            this.cmbCentCos = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbTecnico = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbProyecto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grid = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codproyecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proyecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codmaquina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maquina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedulatecnico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tecnico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codcc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.centrocostos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblMantenMovRepuestoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.dFecha = new System.Windows.Forms.DateTimePicker();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMantenMovRepuestoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCatalogo
            // 
            this.cmbCatalogo.BackColor = System.Drawing.Color.Moccasin;
            this.cmbCatalogo.DropDownHeight = 100;
            this.cmbCatalogo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbCatalogo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCatalogo.FormattingEnabled = true;
            this.cmbCatalogo.IntegralHeight = false;
            this.cmbCatalogo.Location = new System.Drawing.Point(198, 55);
            this.cmbCatalogo.MaxDropDownItems = 10;
            this.cmbCatalogo.Name = "cmbCatalogo";
            this.cmbCatalogo.Size = new System.Drawing.Size(474, 25);
            this.cmbCatalogo.Sorted = true;
            this.cmbCatalogo.TabIndex = 53;
            this.cmbCatalogo.TextUpdate += new System.EventHandler(this.cmbCatalogo_TextUpdate);
            // 
            // chkCatalogo
            // 
            this.chkCatalogo.AutoSize = true;
            this.chkCatalogo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCatalogo.Location = new System.Drawing.Point(97, 61);
            this.chkCatalogo.Margin = new System.Windows.Forms.Padding(2);
            this.chkCatalogo.Name = "chkCatalogo";
            this.chkCatalogo.Size = new System.Drawing.Size(15, 14);
            this.chkCatalogo.TabIndex = 52;
            this.chkCatalogo.UseVisualStyleBackColor = true;
            this.chkCatalogo.CheckedChanged += new System.EventHandler(this.chkCatalogo_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(27, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 62;
            this.label4.Text = "Catálogo";
            // 
            // cmbMaquina
            // 
            this.cmbMaquina.DropDownHeight = 100;
            this.cmbMaquina.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbMaquina.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMaquina.FormattingEnabled = true;
            this.cmbMaquina.IntegralHeight = false;
            this.cmbMaquina.ItemHeight = 17;
            this.cmbMaquina.Location = new System.Drawing.Point(431, 3);
            this.cmbMaquina.MaxDropDownItems = 10;
            this.cmbMaquina.Name = "cmbMaquina";
            this.cmbMaquina.Size = new System.Drawing.Size(241, 25);
            this.cmbMaquina.Sorted = true;
            this.cmbMaquina.TabIndex = 50;
            this.cmbMaquina.SelectedIndexChanged += new System.EventHandler(this.cmbMaquina_SelectedIndexChanged);
            this.cmbMaquina.TextUpdate += new System.EventHandler(this.cmbMaquina_TextUpdate);
            // 
            // labelMaquina
            // 
            this.labelMaquina.AutoSize = true;
            this.labelMaquina.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaquina.ForeColor = System.Drawing.Color.Black;
            this.labelMaquina.Location = new System.Drawing.Point(367, 7);
            this.labelMaquina.Name = "labelMaquina";
            this.labelMaquina.Size = new System.Drawing.Size(60, 17);
            this.labelMaquina.TabIndex = 61;
            this.labelMaquina.Text = "Máquina";
            // 
            // cmbCentCos
            // 
            this.cmbCentCos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.cmbCentCos.DropDownHeight = 100;
            this.cmbCentCos.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbCentCos.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCentCos.FormattingEnabled = true;
            this.cmbCentCos.IntegralHeight = false;
            this.cmbCentCos.Location = new System.Drawing.Point(97, 81);
            this.cmbCentCos.MaxDropDownItems = 5;
            this.cmbCentCos.Name = "cmbCentCos";
            this.cmbCentCos.Size = new System.Drawing.Size(299, 25);
            this.cmbCentCos.Sorted = true;
            this.cmbCentCos.TabIndex = 54;
            this.cmbCentCos.TextUpdate += new System.EventHandler(this.cmbCentCos_TextUpdate);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(28, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 60;
            this.label6.Text = "Centro C.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(128, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 59;
            this.label2.Text = "Repuesto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(432, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 23);
            this.label5.TabIndex = 58;
            this.label5.Text = "Cantidad";
            // 
            // cmbTecnico
            // 
            this.cmbTecnico.DropDownHeight = 100;
            this.cmbTecnico.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbTecnico.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTecnico.FormattingEnabled = true;
            this.cmbTecnico.IntegralHeight = false;
            this.cmbTecnico.Location = new System.Drawing.Point(97, 29);
            this.cmbTecnico.MaxDropDownItems = 10;
            this.cmbTecnico.Name = "cmbTecnico";
            this.cmbTecnico.Size = new System.Drawing.Size(575, 25);
            this.cmbTecnico.Sorted = true;
            this.cmbTecnico.TabIndex = 51;
            this.cmbTecnico.TextUpdate += new System.EventHandler(this.cmbTecnico_TextUpdate);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(37, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 57;
            this.label3.Text = "Técnico";
            // 
            // cmbProyecto
            // 
            this.cmbProyecto.DropDownHeight = 100;
            this.cmbProyecto.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbProyecto.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProyecto.FormattingEnabled = true;
            this.cmbProyecto.IntegralHeight = false;
            this.cmbProyecto.Location = new System.Drawing.Point(97, 3);
            this.cmbProyecto.MaxDropDownItems = 10;
            this.cmbProyecto.Name = "cmbProyecto";
            this.cmbProyecto.Size = new System.Drawing.Size(238, 25);
            this.cmbProyecto.Sorted = true;
            this.cmbProyecto.TabIndex = 49;
            this.cmbProyecto.TextUpdate += new System.EventHandler(this.cmbProyecto_TextUpdate);
            this.cmbProyecto.Validating += new System.ComponentModel.CancelEventHandler(this.cmbProyecto_Validating);
            this.cmbProyecto.Validated += new System.EventHandler(this.cmbProyecto_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(30, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 56;
            this.label1.Text = "Proyecto";
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.descripcion,
            this.codproyecto,
            this.proyecto,
            this.codmaquina,
            this.maquina,
            this.cedulatecnico,
            this.tecnico,
            this.codcc,
            this.centrocostos,
            this.cantidad});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid.DefaultCellStyle = dataGridViewCellStyle3;
            this.grid.Location = new System.Drawing.Point(8, 159);
            this.grid.Name = "grid";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grid.Size = new System.Drawing.Size(781, 306);
            this.grid.TabIndex = 63;
            this.grid.TabStop = false;
            // 
            // codigo
            // 
            this.codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.codigo.HeaderText = "Repuesto";
            this.codigo.Name = "codigo";
            this.codigo.Width = 89;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.Name = "descripcion";
            this.descripcion.Width = 104;
            // 
            // codproyecto
            // 
            this.codproyecto.HeaderText = "codproyecto";
            this.codproyecto.Name = "codproyecto";
            this.codproyecto.Visible = false;
            this.codproyecto.Width = 112;
            // 
            // proyecto
            // 
            this.proyecto.HeaderText = "Proyecto";
            this.proyecto.Name = "proyecto";
            this.proyecto.Width = 87;
            // 
            // codmaquina
            // 
            this.codmaquina.HeaderText = "codmaquina";
            this.codmaquina.Name = "codmaquina";
            this.codmaquina.Visible = false;
            this.codmaquina.Width = 109;
            // 
            // maquina
            // 
            this.maquina.HeaderText = "Maquina";
            this.maquina.Name = "maquina";
            this.maquina.Width = 85;
            // 
            // cedulatecnico
            // 
            this.cedulatecnico.HeaderText = "cedulatecnico";
            this.cedulatecnico.Name = "cedulatecnico";
            this.cedulatecnico.Visible = false;
            this.cedulatecnico.Width = 122;
            // 
            // tecnico
            // 
            this.tecnico.HeaderText = "Tecnico";
            this.tecnico.Name = "tecnico";
            this.tecnico.Width = 80;
            // 
            // codcc
            // 
            this.codcc.HeaderText = "codcc";
            this.codcc.Name = "codcc";
            this.codcc.Visible = false;
            this.codcc.Width = 73;
            // 
            // centrocostos
            // 
            this.centrocostos.HeaderText = "CentroCostos";
            this.centrocostos.Name = "centrocostos";
            this.centrocostos.Width = 114;
            // 
            // cantidad
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.cantidad.DefaultCellStyle = dataGridViewCellStyle2;
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.Width = 89;
            // 
            // tblMantenMovRepuestoBindingSource
            // 
            this.tblMantenMovRepuestoBindingSource.DataSource = typeof(Dataccess.tblMantenMovRepuesto);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(44, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 17);
            this.label7.TabIndex = 67;
            this.label7.Text = "Fecha";
            // 
            // dFecha
            // 
            this.dFecha.CustomFormat = "\"dd/MM/yyyy\"";
            this.dFecha.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dFecha.Location = new System.Drawing.Point(97, 107);
            this.dFecha.Name = "dFecha";
            this.dFecha.Size = new System.Drawing.Size(122, 23);
            this.dFecha.TabIndex = 66;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(539, 82);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(133, 47);
            this.txtCantidad.TabIndex = 68;
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            this.txtCantidad.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCantidad_KeyUp);
            this.txtCantidad.Validated += new System.EventHandler(this.txtCantidad_Validated);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(211)))), ((int)(((byte)(19)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(689, 117);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 35);
            this.btnEliminar.TabIndex = 75;
            this.btnEliminar.Text = "Guardar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(211)))), ((int)(((byte)(19)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(689, 81);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 35);
            this.btnAdd.TabIndex = 74;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // ctrolSalidaRepuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dFecha);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.cmbCatalogo);
            this.Controls.Add(this.chkCatalogo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbMaquina);
            this.Controls.Add(this.labelMaquina);
            this.Controls.Add(this.cmbCentCos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbTecnico);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbProyecto);
            this.Controls.Add(this.label1);
            this.Name = "ctrolSalidaRepuesto";
            this.Size = new System.Drawing.Size(800, 480);
            this.Load += new System.EventHandler(this.ctrolSalidaRepuesto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMantenMovRepuestoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCatalogo;
        private System.Windows.Forms.CheckBox chkCatalogo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbMaquina;
        private System.Windows.Forms.Label labelMaquina;
        private System.Windows.Forms.ComboBox cmbCentCos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbTecnico;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbProyecto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dFecha;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.BindingSource tblMantenMovRepuestoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn codproyecto;
        private System.Windows.Forms.DataGridViewTextBoxColumn proyecto;
        private System.Windows.Forms.DataGridViewTextBoxColumn codmaquina;
        private System.Windows.Forms.DataGridViewTextBoxColumn maquina;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedulatecnico;
        private System.Windows.Forms.DataGridViewTextBoxColumn tecnico;
        private System.Windows.Forms.DataGridViewTextBoxColumn codcc;
        private System.Windows.Forms.DataGridViewTextBoxColumn centrocostos;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAdd;
    }
}
