namespace CtrolAlmacenMantenimiento
{
    partial class ctrolInventario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrolInventario));
            this.gridMov = new System.Windows.Forms.DataGridView();
            this.codlinea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.repuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entradas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salidas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalle = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cmbLinea = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridMov)).BeginInit();
            this.SuspendLayout();
            // 
            // gridMov
            // 
            this.gridMov.AllowUserToAddRows = false;
            this.gridMov.AllowUserToDeleteRows = false;
            this.gridMov.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMov.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codlinea,
            this.linea,
            this.repuesto,
            this.descripcion,
            this.entradas,
            this.salidas,
            this.saldo,
            this.detalle});
            this.gridMov.Location = new System.Drawing.Point(12, 64);
            this.gridMov.Name = "gridMov";
            this.gridMov.ReadOnly = true;
            this.gridMov.Size = new System.Drawing.Size(774, 409);
            this.gridMov.TabIndex = 18;
            this.gridMov.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridMov_CellContentClick);
            // 
            // codlinea
            // 
            this.codlinea.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.codlinea.FillWeight = 60F;
            this.codlinea.HeaderText = "CodLinea";
            this.codlinea.Name = "codlinea";
            this.codlinea.ReadOnly = true;
            this.codlinea.Visible = false;
            this.codlinea.Width = 90;
            // 
            // linea
            // 
            this.linea.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.linea.HeaderText = "Linea";
            this.linea.Name = "linea";
            this.linea.ReadOnly = true;
            // 
            // repuesto
            // 
            this.repuesto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.repuesto.FillWeight = 150F;
            this.repuesto.HeaderText = "Repuesto";
            this.repuesto.Name = "repuesto";
            this.repuesto.ReadOnly = true;
            this.repuesto.Width = 140;
            // 
            // descripcion
            // 
            this.descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.descripcion.FillWeight = 150F;
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Width = 200;
            // 
            // entradas
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.entradas.DefaultCellStyle = dataGridViewCellStyle4;
            this.entradas.HeaderText = "Entradas";
            this.entradas.Name = "entradas";
            this.entradas.ReadOnly = true;
            this.entradas.Width = 60;
            // 
            // salidas
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            this.salidas.DefaultCellStyle = dataGridViewCellStyle5;
            this.salidas.HeaderText = "Salidas";
            this.salidas.Name = "salidas";
            this.salidas.ReadOnly = true;
            this.salidas.Width = 60;
            // 
            // saldo
            // 
            this.saldo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N1";
            dataGridViewCellStyle6.NullValue = null;
            this.saldo.DefaultCellStyle = dataGridViewCellStyle6;
            this.saldo.HeaderText = "Saldo";
            this.saldo.Name = "saldo";
            this.saldo.ReadOnly = true;
            this.saldo.Width = 67;
            // 
            // detalle
            // 
            this.detalle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.detalle.HeaderText = "Ver";
            this.detalle.Name = "detalle";
            this.detalle.ReadOnly = true;
            this.detalle.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.detalle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.detalle.Width = 54;
            // 
            // cmbLinea
            // 
            this.cmbLinea.DropDownHeight = 100;
            this.cmbLinea.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbLinea.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLinea.FormattingEnabled = true;
            this.cmbLinea.IntegralHeight = false;
            this.cmbLinea.Location = new System.Drawing.Point(89, 7);
            this.cmbLinea.MaxDropDownItems = 10;
            this.cmbLinea.Name = "cmbLinea";
            this.cmbLinea.Size = new System.Drawing.Size(260, 25);
            this.cmbLinea.Sorted = true;
            this.cmbLinea.TabIndex = 54;
            this.cmbLinea.SelectedIndexChanged += new System.EventHandler(this.cmbLinea_SelectedIndexChanged);
            this.cmbLinea.TextUpdate += new System.EventHandler(this.cmbLinea_TextUpdate);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(14, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 19);
            this.label1.TabIndex = 53;
            this.label1.Text = "Linea";
            // 
            // cmbProducto
            // 
            this.cmbProducto.DropDownHeight = 100;
            this.cmbProducto.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbProducto.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.IntegralHeight = false;
            this.cmbProducto.Location = new System.Drawing.Point(89, 33);
            this.cmbProducto.MaxDropDownItems = 10;
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(370, 25);
            this.cmbProducto.Sorted = true;
            this.cmbProducto.TabIndex = 56;
            this.cmbProducto.SelectedIndexChanged += new System.EventHandler(this.cmbProducto_SelectedIndexChanged);
            this.cmbProducto.TextUpdate += new System.EventHandler(this.cmbProducto_TextUpdate);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(14, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 55;
            this.label2.Text = "Producto";
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.BackColor = System.Drawing.Color.SteelBlue;
            this.btnExportExcel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnExportExcel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(211)))), ((int)(((byte)(19)))));
            this.btnExportExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportExcel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportExcel.ForeColor = System.Drawing.Color.White;
            this.btnExportExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExportExcel.Image")));
            this.btnExportExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportExcel.Location = new System.Drawing.Point(645, 26);
            this.btnExportExcel.Margin = new System.Windows.Forms.Padding(2);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(141, 32);
            this.btnExportExcel.TabIndex = 73;
            this.btnExportExcel.Text = "Exportar a Excel";
            this.btnExportExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportExcel.UseVisualStyleBackColor = false;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnActualizar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(211)))), ((int)(((byte)(19)))));
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizar.Location = new System.Drawing.Point(598, 26);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(43, 32);
            this.btnActualizar.TabIndex = 74;
            this.btnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // ctrolInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnExportExcel);
            this.Controls.Add(this.cmbProducto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbLinea);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridMov);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ctrolInventario";
            this.Size = new System.Drawing.Size(800, 480);
            this.Load += new System.EventHandler(this.ctrolInventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridMov)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridMov;
        private System.Windows.Forms.ComboBox cmbLinea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn codlinea;
        private System.Windows.Forms.DataGridViewTextBoxColumn linea;
        private System.Windows.Forms.DataGridViewTextBoxColumn repuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn entradas;
        private System.Windows.Forms.DataGridViewTextBoxColumn salidas;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldo;
        private System.Windows.Forms.DataGridViewButtonColumn detalle;
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.Button btnActualizar;
    }
}
