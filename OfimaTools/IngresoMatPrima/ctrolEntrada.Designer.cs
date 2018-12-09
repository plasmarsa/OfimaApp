namespace IngresoMatPrima
{
    partial class ctrolEntrada
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
                serial.Close();
                serial.Dispose();
                components.Dispose();
                
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cmbProveedor = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFactura = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOrden = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtOtraEstiba = new System.Windows.Forms.TextBox();
            this.rbOtro = new System.Windows.Forms.RadioButton();
            this.rbMadera = new System.Windows.Forms.RadioButton();
            this.rbPlastico = new System.Windows.Forms.RadioButton();
            this.rbNoEstiba = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPesoN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPesoB = new System.Windows.Forms.TextBox();
            this.btnPeso = new System.Windows.Forms.Button();
            this.lblProducto2 = new System.Windows.Forms.Label();
            this.cmbProducto2 = new System.Windows.Forms.ComboBox();
            this.chkDosProductosEstiba = new System.Windows.Forms.CheckBox();
            this.serial = new System.IO.Ports.SerialPort(this.components);
            this.txtPesoActual = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblSegundoPeso = new System.Windows.Forms.Label();
            this.txtPesoN2 = new System.Windows.Forms.TextBox();
            this.lblUltEtiqueta = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbProveedor
            // 
            this.cmbProveedor.DropDownHeight = 100;
            this.cmbProveedor.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProveedor.FormattingEnabled = true;
            this.cmbProveedor.IntegralHeight = false;
            this.cmbProveedor.ItemHeight = 22;
            this.cmbProveedor.Location = new System.Drawing.Point(200, 7);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Size = new System.Drawing.Size(809, 30);
            this.cmbProveedor.TabIndex = 1;
            this.cmbProveedor.TextUpdate += new System.EventHandler(this.cmbProveedor_TextUpdate);
            this.cmbProveedor.Validating += new System.ComponentModel.CancelEventHandler(this.cmbProveedor_Validating);
            this.cmbProveedor.Validated += new System.EventHandler(this.cmbProveedor_Validated);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(65, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 22);
            this.label7.TabIndex = 34;
            this.label7.Text = "Observación";
            // 
            // txtObservacion
            // 
            this.txtObservacion.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacion.Location = new System.Drawing.Point(200, 105);
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(809, 111);
            this.txtObservacion.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(113, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 22);
            this.label3.TabIndex = 32;
            this.label3.Text = "Factura";
            // 
            // txtFactura
            // 
            this.txtFactura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFactura.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFactura.Location = new System.Drawing.Point(200, 39);
            this.txtFactura.Name = "txtFactura";
            this.txtFactura.Size = new System.Drawing.Size(323, 31);
            this.txtFactura.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(44, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 22);
            this.label2.TabIndex = 30;
            this.label2.Text = "Orden Compra";
            // 
            // txtOrden
            // 
            this.txtOrden.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOrden.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrden.Location = new System.Drawing.Point(200, 72);
            this.txtOrden.Name = "txtOrden";
            this.txtOrden.Size = new System.Drawing.Size(323, 31);
            this.txtOrden.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(74, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 25);
            this.label4.TabIndex = 28;
            this.label4.Text = "Producto";
            // 
            // cmbProducto
            // 
            this.cmbProducto.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.IntegralHeight = false;
            this.cmbProducto.ItemHeight = 24;
            this.cmbProducto.Location = new System.Drawing.Point(200, 264);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(809, 32);
            this.cmbProducto.Sorted = true;
            this.cmbProducto.TabIndex = 5;
            this.cmbProducto.TextUpdate += new System.EventHandler(this.cmbProducto_TextUpdate);
            this.cmbProducto.Validating += new System.ComponentModel.CancelEventHandler(this.cmbProducto_Validating);
            this.cmbProducto.Validated += new System.EventHandler(this.cmbProducto_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(88, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 22);
            this.label1.TabIndex = 26;
            this.label1.Text = "Proveedor";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtOtraEstiba);
            this.groupBox1.Controls.Add(this.rbOtro);
            this.groupBox1.Controls.Add(this.rbMadera);
            this.groupBox1.Controls.Add(this.rbPlastico);
            this.groupBox1.Controls.Add(this.rbNoEstiba);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(29, 369);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 177);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo Estiba";
            // 
            // txtOtraEstiba
            // 
            this.txtOtraEstiba.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOtraEstiba.Enabled = false;
            this.txtOtraEstiba.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOtraEstiba.Location = new System.Drawing.Point(91, 126);
            this.txtOtraEstiba.Name = "txtOtraEstiba";
            this.txtOtraEstiba.Size = new System.Drawing.Size(91, 27);
            this.txtOtraEstiba.TabIndex = 4;
            this.txtOtraEstiba.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOtraEstiba_KeyPress);
            this.txtOtraEstiba.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtOtraEstiba_KeyUp);
            this.txtOtraEstiba.Validating += new System.ComponentModel.CancelEventHandler(this.txtOtraEstiba_Validating);
            this.txtOtraEstiba.Validated += new System.EventHandler(this.txtOtraEstiba_Validated);
            // 
            // rbOtro
            // 
            this.rbOtro.AutoSize = true;
            this.rbOtro.Location = new System.Drawing.Point(12, 128);
            this.rbOtro.Name = "rbOtro";
            this.rbOtro.Size = new System.Drawing.Size(70, 26);
            this.rbOtro.TabIndex = 3;
            this.rbOtro.TabStop = true;
            this.rbOtro.Text = "Otro";
            this.rbOtro.UseVisualStyleBackColor = true;
            this.rbOtro.CheckedChanged += new System.EventHandler(this.rbOtro_CheckedChanged);
            // 
            // rbMadera
            // 
            this.rbMadera.AutoSize = true;
            this.rbMadera.Location = new System.Drawing.Point(12, 97);
            this.rbMadera.Name = "rbMadera";
            this.rbMadera.Size = new System.Drawing.Size(166, 26);
            this.rbMadera.TabIndex = 2;
            this.rbMadera.TabStop = true;
            this.rbMadera.Text = "Madera(1.5kg)";
            this.rbMadera.UseVisualStyleBackColor = true;
            this.rbMadera.CheckedChanged += new System.EventHandler(this.rbMadera_CheckedChanged);
            // 
            // rbPlastico
            // 
            this.rbPlastico.AutoSize = true;
            this.rbPlastico.Location = new System.Drawing.Point(12, 66);
            this.rbPlastico.Name = "rbPlastico";
            this.rbPlastico.Size = new System.Drawing.Size(160, 26);
            this.rbPlastico.TabIndex = 1;
            this.rbPlastico.TabStop = true;
            this.rbPlastico.Text = "Plástico(2.0kg)";
            this.rbPlastico.UseVisualStyleBackColor = true;
            this.rbPlastico.CheckedChanged += new System.EventHandler(this.rbPlastico_CheckedChanged);
            // 
            // rbNoEstiba
            // 
            this.rbNoEstiba.AutoSize = true;
            this.rbNoEstiba.Location = new System.Drawing.Point(12, 35);
            this.rbNoEstiba.Name = "rbNoEstiba";
            this.rbNoEstiba.Size = new System.Drawing.Size(170, 26);
            this.rbNoEstiba.TabIndex = 0;
            this.rbNoEstiba.TabStop = true;
            this.rbNoEstiba.Text = "Sin estiba (0 kg)";
            this.rbNoEstiba.UseVisualStyleBackColor = true;
            this.rbNoEstiba.CheckedChanged += new System.EventHandler(this.rbNoEstiba_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(638, 446);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 40);
            this.label6.TabIndex = 41;
            this.label6.Text = "Peso Neto";
            // 
            // txtPesoN
            // 
            this.txtPesoN.Enabled = false;
            this.txtPesoN.Font = new System.Drawing.Font("Century Gothic", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesoN.Location = new System.Drawing.Point(832, 428);
            this.txtPesoN.Name = "txtPesoN";
            this.txtPesoN.Size = new System.Drawing.Size(176, 60);
            this.txtPesoN.TabIndex = 40;
            this.txtPesoN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(638, 385);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 40);
            this.label5.TabIndex = 39;
            this.label5.Text = "Peso Bruto";
            // 
            // txtPesoB
            // 
            this.txtPesoB.Enabled = false;
            this.txtPesoB.Font = new System.Drawing.Font("Century Gothic", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesoB.Location = new System.Drawing.Point(832, 367);
            this.txtPesoB.Name = "txtPesoB";
            this.txtPesoB.Size = new System.Drawing.Size(176, 60);
            this.txtPesoB.TabIndex = 38;
            this.txtPesoB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnPeso
            // 
            this.btnPeso.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeso.Location = new System.Drawing.Point(352, 447);
            this.btnPeso.Name = "btnPeso";
            this.btnPeso.Size = new System.Drawing.Size(199, 104);
            this.btnPeso.TabIndex = 8;
            this.btnPeso.Text = "Generar Etiqueta";
            this.btnPeso.UseVisualStyleBackColor = true;
            this.btnPeso.Click += new System.EventHandler(this.btnPeso_Click);
            // 
            // lblProducto2
            // 
            this.lblProducto2.AutoSize = true;
            this.lblProducto2.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto2.ForeColor = System.Drawing.Color.White;
            this.lblProducto2.Location = new System.Drawing.Point(54, 303);
            this.lblProducto2.Name = "lblProducto2";
            this.lblProducto2.Size = new System.Drawing.Size(128, 25);
            this.lblProducto2.TabIndex = 43;
            this.lblProducto2.Text = "Producto 2";
            this.lblProducto2.Visible = false;
            // 
            // cmbProducto2
            // 
            this.cmbProducto2.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProducto2.FormattingEnabled = true;
            this.cmbProducto2.IntegralHeight = false;
            this.cmbProducto2.ItemHeight = 24;
            this.cmbProducto2.Location = new System.Drawing.Point(200, 298);
            this.cmbProducto2.Name = "cmbProducto2";
            this.cmbProducto2.Size = new System.Drawing.Size(809, 32);
            this.cmbProducto2.Sorted = true;
            this.cmbProducto2.TabIndex = 6;
            this.cmbProducto2.Visible = false;
            this.cmbProducto2.TextUpdate += new System.EventHandler(this.cmbProducto2_TextUpdate);
            this.cmbProducto2.Validating += new System.ComponentModel.CancelEventHandler(this.cmbProducto2_Validating);
            this.cmbProducto2.Validated += new System.EventHandler(this.cmbProducto2_Validated);
            // 
            // chkDosProductosEstiba
            // 
            this.chkDosProductosEstiba.AutoSize = true;
            this.chkDosProductosEstiba.ForeColor = System.Drawing.Color.White;
            this.chkDosProductosEstiba.Location = new System.Drawing.Point(200, 227);
            this.chkDosProductosEstiba.Name = "chkDosProductosEstiba";
            this.chkDosProductosEstiba.Size = new System.Drawing.Size(198, 25);
            this.chkDosProductosEstiba.TabIndex = 44;
            this.chkDosProductosEstiba.Text = "2 productos en estiba";
            this.chkDosProductosEstiba.UseVisualStyleBackColor = true;
            this.chkDosProductosEstiba.CheckedChanged += new System.EventHandler(this.chkDosProductosEstiba_CheckedChanged);
            // 
            // txtPesoActual
            // 
            this.txtPesoActual.BackColor = System.Drawing.Color.Gray;
            this.txtPesoActual.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPesoActual.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesoActual.ForeColor = System.Drawing.Color.White;
            this.txtPesoActual.Location = new System.Drawing.Point(753, 336);
            this.txtPesoActual.Name = "txtPesoActual";
            this.txtPesoActual.Size = new System.Drawing.Size(255, 24);
            this.txtPesoActual.TabIndex = 45;
            this.txtPesoActual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblSegundoPeso
            // 
            this.lblSegundoPeso.AutoSize = true;
            this.lblSegundoPeso.Font = new System.Drawing.Font("Century Gothic", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundoPeso.ForeColor = System.Drawing.Color.White;
            this.lblSegundoPeso.Location = new System.Drawing.Point(659, 507);
            this.lblSegundoPeso.Name = "lblSegundoPeso";
            this.lblSegundoPeso.Size = new System.Drawing.Size(167, 40);
            this.lblSegundoPeso.TabIndex = 47;
            this.lblSegundoPeso.Text = "2do Peso";
            this.lblSegundoPeso.Visible = false;
            // 
            // txtPesoN2
            // 
            this.txtPesoN2.Font = new System.Drawing.Font("Century Gothic", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesoN2.Location = new System.Drawing.Point(832, 489);
            this.txtPesoN2.Name = "txtPesoN2";
            this.txtPesoN2.Size = new System.Drawing.Size(176, 60);
            this.txtPesoN2.TabIndex = 46;
            this.txtPesoN2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPesoN2.Visible = false;
            this.txtPesoN2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOtraEstiba_KeyPress);
            this.txtPesoN2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtOtraEstiba_KeyUp);
            this.txtPesoN2.Validating += new System.ComponentModel.CancelEventHandler(this.txtPesoN2_Validating);
            this.txtPesoN2.Validated += new System.EventHandler(this.txtPesoN2_Validated);
            // 
            // lblUltEtiqueta
            // 
            this.lblUltEtiqueta.AutoSize = true;
            this.lblUltEtiqueta.BackColor = System.Drawing.Color.Gray;
            this.lblUltEtiqueta.ForeColor = System.Drawing.Color.White;
            this.lblUltEtiqueta.Location = new System.Drawing.Point(439, 339);
            this.lblUltEtiqueta.Name = "lblUltEtiqueta";
            this.lblUltEtiqueta.Size = new System.Drawing.Size(15, 21);
            this.lblUltEtiqueta.TabIndex = 48;
            this.lblUltEtiqueta.Text = "-";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(513, 364);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 35);
            this.button1.TabIndex = 49;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ctrolEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblUltEtiqueta);
            this.Controls.Add(this.lblSegundoPeso);
            this.Controls.Add(this.txtPesoN2);
            this.Controls.Add(this.txtPesoActual);
            this.Controls.Add(this.chkDosProductosEstiba);
            this.Controls.Add(this.lblProducto2);
            this.Controls.Add(this.cmbProducto2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPesoN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPesoB);
            this.Controls.Add(this.btnPeso);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbProveedor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtObservacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFactura);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOrden);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbProducto);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ctrolEntrada";
            this.Size = new System.Drawing.Size(1060, 564);
            this.Load += new System.EventHandler(this.ctrolEntrada_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbProveedor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFactura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOrden;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtOtraEstiba;
        private System.Windows.Forms.RadioButton rbOtro;
        private System.Windows.Forms.RadioButton rbMadera;
        private System.Windows.Forms.RadioButton rbPlastico;
        private System.Windows.Forms.RadioButton rbNoEstiba;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPesoN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPesoB;
        private System.Windows.Forms.Button btnPeso;
        private System.Windows.Forms.Label lblProducto2;
        private System.Windows.Forms.ComboBox cmbProducto2;
        private System.Windows.Forms.CheckBox chkDosProductosEstiba;
        public System.IO.Ports.SerialPort serial;
        private System.Windows.Forms.TextBox txtPesoActual;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblSegundoPeso;
        private System.Windows.Forms.TextBox txtPesoN2;
        private System.Windows.Forms.Label lblUltEtiqueta;
        private System.Windows.Forms.Button button1;
    }
}
