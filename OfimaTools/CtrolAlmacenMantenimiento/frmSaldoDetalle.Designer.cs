namespace CtrolAlmacenMantenimiento
{
    partial class frmSaldoDetalle
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridMov = new System.Windows.Forms.DataGridView();
            this.lblLinea = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblRepuesto = new System.Windows.Forms.Label();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.PictureBox();
            this.idmvto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tecnico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Orden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.factura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipomvto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modificar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridMov)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            this.SuspendLayout();
            // 
            // gridMov
            // 
            this.gridMov.AllowUserToAddRows = false;
            this.gridMov.AllowUserToDeleteRows = false;
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
            this.idmvto,
            this.fecha,
            this.tecnico,
            this.Orden,
            this.factura,
            this.tipomvto,
            this.entrada,
            this.salida,
            this.modificar});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridMov.DefaultCellStyle = dataGridViewCellStyle5;
            this.gridMov.Location = new System.Drawing.Point(12, 55);
            this.gridMov.Name = "gridMov";
            this.gridMov.ReadOnly = true;
            this.gridMov.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridMov.Size = new System.Drawing.Size(861, 249);
            this.gridMov.TabIndex = 18;
            this.gridMov.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridMov_CellContentClick);
            // 
            // lblLinea
            // 
            this.lblLinea.AutoSize = true;
            this.lblLinea.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLinea.ForeColor = System.Drawing.Color.Black;
            this.lblLinea.Location = new System.Drawing.Point(85, 7);
            this.lblLinea.Name = "lblLinea";
            this.lblLinea.Size = new System.Drawing.Size(14, 16);
            this.lblLinea.TabIndex = 22;
            this.lblLinea.Text = "_";
            // 
            // lblRepuesto
            // 
            this.lblRepuesto.AutoSize = true;
            this.lblRepuesto.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepuesto.Location = new System.Drawing.Point(85, 30);
            this.lblRepuesto.Name = "lblRepuesto";
            this.lblRepuesto.Size = new System.Drawing.Size(14, 17);
            this.lblRepuesto.TabIndex = 21;
            this.lblRepuesto.Text = "_";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(14, 30);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(64, 17);
            this.bunifuCustomLabel3.TabIndex = 20;
            this.bunifuCustomLabel3.Text = "Repuesto";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(14, 6);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(37, 17);
            this.bunifuCustomLabel2.TabIndex = 19;
            this.bunifuCustomLabel2.Text = "línea";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(698, 312);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(42, 17);
            this.bunifuCustomLabel1.TabIndex = 23;
            this.bunifuCustomLabel1.Text = "Saldo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(789, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "_";
            // 
            // btnSave
            // 
            this.btnSave.Image = global::CtrolAlmacenMantenimiento.Properties.Resources.Cancel_black_50px;
            this.btnSave.InitialImage = null;
            this.btnSave.Location = new System.Drawing.Point(839, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(32, 32);
            this.btnSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSave.TabIndex = 68;
            this.btnSave.TabStop = false;
            this.btnSave.Tag = "Guardar control";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // idmvto
            // 
            this.idmvto.HeaderText = "idreg";
            this.idmvto.Name = "idmvto";
            this.idmvto.ReadOnly = true;
            this.idmvto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.idmvto.Visible = false;
            this.idmvto.Width = 5;
            // 
            // fecha
            // 
            dataGridViewCellStyle2.Format = "g";
            dataGridViewCellStyle2.NullValue = null;
            this.fecha.DefaultCellStyle = dataGridViewCellStyle2;
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            this.fecha.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.fecha.Width = 110;
            // 
            // tecnico
            // 
            this.tecnico.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.tecnico.HeaderText = "Técnico";
            this.tecnico.Name = "tecnico";
            this.tecnico.ReadOnly = true;
            this.tecnico.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tecnico.Width = 80;
            // 
            // Orden
            // 
            this.Orden.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Orden.HeaderText = "Orden";
            this.Orden.Name = "Orden";
            this.Orden.ReadOnly = true;
            this.Orden.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Orden.Width = 70;
            // 
            // factura
            // 
            this.factura.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.factura.HeaderText = "Factura";
            this.factura.Name = "factura";
            this.factura.ReadOnly = true;
            this.factura.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.factura.Width = 79;
            // 
            // tipomvto
            // 
            this.tipomvto.HeaderText = "Mvto";
            this.tipomvto.Name = "tipomvto";
            this.tipomvto.ReadOnly = true;
            this.tipomvto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tipomvto.Width = 50;
            // 
            // entrada
            // 
            this.entrada.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.entrada.DefaultCellStyle = dataGridViewCellStyle3;
            this.entrada.HeaderText = "Entrada";
            this.entrada.Name = "entrada";
            this.entrada.ReadOnly = true;
            this.entrada.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.entrada.Width = 79;
            // 
            // salida
            // 
            this.salida.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.salida.DefaultCellStyle = dataGridViewCellStyle4;
            this.salida.HeaderText = "Salida";
            this.salida.Name = "salida";
            this.salida.ReadOnly = true;
            this.salida.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.salida.Width = 70;
            // 
            // modificar
            // 
            this.modificar.HeaderText = "Modificar";
            this.modificar.Name = "modificar";
            this.modificar.ReadOnly = true;
            this.modificar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.modificar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // frmSaldoDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 337);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.lblLinea);
            this.Controls.Add(this.lblRepuesto);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.gridMov);
            this.Name = "frmSaldoDetalle";
            this.Text = "Detalle Entradas & Salidas";
            this.Activated += new System.EventHandler(this.frmSaldoDetalle_Activated);
            this.Load += new System.EventHandler(this.frmSaldoDetalle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridMov)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridMov;
        private Bunifu.Framework.UI.BunifuCustomLabel lblLinea;
        private System.Windows.Forms.Label lblRepuesto;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmvto;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn tecnico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Orden;
        private System.Windows.Forms.DataGridViewTextBoxColumn factura;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipomvto;
        private System.Windows.Forms.DataGridViewTextBoxColumn entrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn salida;
        private System.Windows.Forms.DataGridViewButtonColumn modificar;
    }
}