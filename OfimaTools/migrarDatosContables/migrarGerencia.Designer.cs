namespace migrarDatosContables
{
    partial class migrarGerencia
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grid = new System.Windows.Forms.DataGridView();
            this.fecha = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMigrarDctoContable = new System.Windows.Forms.Button();
            this.cmbGrCompensacion = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTipoCausacion = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbComprobante = new System.Windows.Forms.ComboBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.lblGrupo = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblDoc = new System.Windows.Forms.Label();
            this.xpProgreso = new Framework.Controls.XpProgressBar();
            this.btnexcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid.DefaultCellStyle = dataGridViewCellStyle2;
            this.grid.Location = new System.Drawing.Point(11, 118);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(886, 410);
            this.grid.TabIndex = 1;
            // 
            // fecha
            // 
            this.fecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(189)))), ((int)(((byte)(241)))));
            this.fecha.BorderRadius = 0;
            this.fecha.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha.ForeColor = System.Drawing.Color.White;
            this.fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecha.FormatCustom = null;
            this.fecha.Location = new System.Drawing.Point(161, 84);
            this.fecha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(156, 24);
            this.fecha.TabIndex = 20;
            this.fecha.Value = new System.DateTime(2017, 10, 25, 14, 24, 7, 311);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(16, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 19);
            this.label2.TabIndex = 23;
            this.label2.Text = "Fecha documento";
            // 
            // btnMigrarDctoContable
            // 
            this.btnMigrarDctoContable.BackColor = System.Drawing.Color.White;
            this.btnMigrarDctoContable.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(189)))), ((int)(((byte)(241)))));
            this.btnMigrarDctoContable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMigrarDctoContable.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMigrarDctoContable.Location = new System.Drawing.Point(800, 86);
            this.btnMigrarDctoContable.Name = "btnMigrarDctoContable";
            this.btnMigrarDctoContable.Size = new System.Drawing.Size(97, 28);
            this.btnMigrarDctoContable.TabIndex = 26;
            this.btnMigrarDctoContable.Text = "Integrar";
            this.btnMigrarDctoContable.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMigrarDctoContable.UseVisualStyleBackColor = false;
            this.btnMigrarDctoContable.Click += new System.EventHandler(this.btnMigrarDctoContable_Click);
            // 
            // cmbGrCompensacion
            // 
            this.cmbGrCompensacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(189)))), ((int)(((byte)(241)))));
            this.cmbGrCompensacion.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGrCompensacion.ForeColor = System.Drawing.Color.White;
            this.cmbGrCompensacion.FormattingEnabled = true;
            this.cmbGrCompensacion.Location = new System.Drawing.Point(161, 5);
            this.cmbGrCompensacion.Name = "cmbGrCompensacion";
            this.cmbGrCompensacion.Size = new System.Drawing.Size(306, 25);
            this.cmbGrCompensacion.TabIndex = 27;
            this.cmbGrCompensacion.SelectedIndexChanged += new System.EventHandler(this.cmbGrCompensacion_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 19);
            this.label1.TabIndex = 28;
            this.label1.Text = "Grp Compensación";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(40, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 19);
            this.label3.TabIndex = 30;
            this.label3.Text = "Tipo Causación";
            // 
            // cmbTipoCausacion
            // 
            this.cmbTipoCausacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(189)))), ((int)(((byte)(241)))));
            this.cmbTipoCausacion.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoCausacion.ForeColor = System.Drawing.Color.White;
            this.cmbTipoCausacion.FormattingEnabled = true;
            this.cmbTipoCausacion.Location = new System.Drawing.Point(161, 31);
            this.cmbTipoCausacion.Name = "cmbTipoCausacion";
            this.cmbTipoCausacion.Size = new System.Drawing.Size(306, 25);
            this.cmbTipoCausacion.TabIndex = 29;
            this.cmbTipoCausacion.SelectedIndexChanged += new System.EventHandler(this.cmbTipoCausacion_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(47, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 19);
            this.label4.TabIndex = 32;
            this.label4.Text = "Comprobante";
            // 
            // cmbComprobante
            // 
            this.cmbComprobante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(189)))), ((int)(((byte)(241)))));
            this.cmbComprobante.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbComprobante.ForeColor = System.Drawing.Color.White;
            this.cmbComprobante.FormattingEnabled = true;
            this.cmbComprobante.Location = new System.Drawing.Point(161, 57);
            this.cmbComprobante.Name = "cmbComprobante";
            this.cmbComprobante.Size = new System.Drawing.Size(617, 25);
            this.cmbComprobante.TabIndex = 31;
            this.cmbComprobante.SelectedIndexChanged += new System.EventHandler(this.cmbComprobante_SelectedIndexChanged);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.White;
            this.btnConsultar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(189)))), ((int)(((byte)(241)))));
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(702, 86);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(97, 28);
            this.btnConsultar.TabIndex = 33;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.ForeColor = System.Drawing.Color.Black;
            this.lblMensaje.Location = new System.Drawing.Point(12, 532);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(18, 21);
            this.lblMensaje.TabIndex = 34;
            this.lblMensaje.Text = "_";
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGrupo
            // 
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrupo.ForeColor = System.Drawing.Color.Gray;
            this.lblGrupo.Location = new System.Drawing.Point(473, 9);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(14, 17);
            this.lblGrupo.TabIndex = 35;
            this.lblGrupo.Text = "_";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.ForeColor = System.Drawing.Color.Gray;
            this.lblTipo.Location = new System.Drawing.Point(473, 35);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(14, 17);
            this.lblTipo.TabIndex = 36;
            this.lblTipo.Text = "_";
            // 
            // lblDoc
            // 
            this.lblDoc.AutoSize = true;
            this.lblDoc.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoc.ForeColor = System.Drawing.Color.Gray;
            this.lblDoc.Location = new System.Drawing.Point(784, 60);
            this.lblDoc.Name = "lblDoc";
            this.lblDoc.Size = new System.Drawing.Size(14, 17);
            this.lblDoc.TabIndex = 37;
            this.lblDoc.Text = "_";
            // 
            // xpProgreso
            // 
            this.xpProgreso.ColorBackGround = System.Drawing.Color.Yellow;
            this.xpProgreso.ColorBarBorder = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(201)))));
            this.xpProgreso.ColorBarCenter = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(201)))));
            this.xpProgreso.ColorText = System.Drawing.Color.Red;
            this.xpProgreso.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xpProgreso.ForeColor = System.Drawing.Color.Red;
            this.xpProgreso.Location = new System.Drawing.Point(13, 560);
            this.xpProgreso.Name = "xpProgreso";
            this.xpProgreso.Position = 0;
            this.xpProgreso.PositionMax = 323;
            this.xpProgreso.PositionMin = 0;
            this.xpProgreso.Size = new System.Drawing.Size(886, 29);
            this.xpProgreso.TabIndex = 39;
            this.xpProgreso.Text = "xpProgressBar1";
            // 
            // btnexcel
            // 
            this.btnexcel.BackColor = System.Drawing.Color.White;
            this.btnexcel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(189)))), ((int)(((byte)(241)))));
            this.btnexcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexcel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexcel.Location = new System.Drawing.Point(840, 55);
            this.btnexcel.Name = "btnexcel";
            this.btnexcel.Size = new System.Drawing.Size(57, 28);
            this.btnexcel.TabIndex = 40;
            this.btnexcel.Text = "Excel";
            this.btnexcel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnexcel.UseVisualStyleBackColor = false;
            this.btnexcel.Click += new System.EventHandler(this.btnexcel_Click);
            // 
            // migrarGerencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnexcel);
            this.Controls.Add(this.xpProgreso);
            this.Controls.Add(this.lblDoc);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblGrupo);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbComprobante);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbTipoCausacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbGrCompensacion);
            this.Controls.Add(this.btnMigrarDctoContable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.grid);
            this.Name = "migrarGerencia";
            this.Size = new System.Drawing.Size(911, 595);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid;
        private Bunifu.Framework.UI.BunifuDatepicker fecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMigrarDctoContable;
        private System.Windows.Forms.ComboBox cmbGrCompensacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTipoCausacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbComprobante;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Label lblGrupo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblDoc;
        private Framework.Controls.XpProgressBar xpProgreso;
        private System.Windows.Forms.Button btnexcel;
    }
}
