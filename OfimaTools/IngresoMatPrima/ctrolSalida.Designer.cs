namespace IngresoMatPrima
{
    partial class ctrolSalida
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrolSalida));
            this.label6 = new System.Windows.Forms.Label();
            this.txtPesoNeto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPesoBruto = new System.Windows.Forms.TextBox();
            this.btnPeso = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtOtraEstiba = new System.Windows.Forms.TextBox();
            this.rbOtro = new System.Windows.Forms.RadioButton();
            this.rbMadera = new System.Windows.Forms.RadioButton();
            this.rbPlastico = new System.Windows.Forms.RadioButton();
            this.rbNoEstiba = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFactura = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOrden = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtIdEtiqueta = new System.Windows.Forms.TextBox();
            this.txtprovedor = new System.Windows.Forms.TextBox();
            this.txtproducto = new System.Windows.Forms.TextBox();
            this.txtnit = new System.Windows.Forms.TextBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(713, 498);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 40);
            this.label6.TabIndex = 58;
            this.label6.Text = "Peso Neto";
            // 
            // txtPesoNeto
            // 
            this.txtPesoNeto.Enabled = false;
            this.txtPesoNeto.Font = new System.Drawing.Font("Century Gothic", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesoNeto.Location = new System.Drawing.Point(898, 478);
            this.txtPesoNeto.Name = "txtPesoNeto";
            this.txtPesoNeto.Size = new System.Drawing.Size(145, 60);
            this.txtPesoNeto.TabIndex = 57;
            this.txtPesoNeto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(709, 435);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 40);
            this.label5.TabIndex = 56;
            this.label5.Text = "Peso Bruto";
            // 
            // txtPesoBruto
            // 
            this.txtPesoBruto.Enabled = false;
            this.txtPesoBruto.Font = new System.Drawing.Font("Century Gothic", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesoBruto.Location = new System.Drawing.Point(898, 415);
            this.txtPesoBruto.Name = "txtPesoBruto";
            this.txtPesoBruto.Size = new System.Drawing.Size(145, 60);
            this.txtPesoBruto.TabIndex = 55;
            this.txtPesoBruto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnPeso
            // 
            this.btnPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeso.Location = new System.Drawing.Point(474, 437);
            this.btnPeso.Name = "btnPeso";
            this.btnPeso.Size = new System.Drawing.Size(199, 104);
            this.btnPeso.TabIndex = 50;
            this.btnPeso.Text = "Generar Etiqueta";
            this.btnPeso.UseVisualStyleBackColor = true;
            this.btnPeso.Click += new System.EventHandler(this.btnPeso_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtOtraEstiba);
            this.groupBox1.Controls.Add(this.rbOtro);
            this.groupBox1.Controls.Add(this.rbMadera);
            this.groupBox1.Controls.Add(this.rbPlastico);
            this.groupBox1.Controls.Add(this.rbNoEstiba);
            this.groupBox1.Enabled = false;
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(61, 364);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(201, 177);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo Estiba";
            // 
            // txtOtraEstiba
            // 
            this.txtOtraEstiba.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOtraEstiba.Enabled = false;
            this.txtOtraEstiba.Location = new System.Drawing.Point(75, 126);
            this.txtOtraEstiba.Name = "txtOtraEstiba";
            this.txtOtraEstiba.Size = new System.Drawing.Size(91, 31);
            this.txtOtraEstiba.TabIndex = 4;
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
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(145, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 22);
            this.label3.TabIndex = 54;
            this.label3.Text = "Factura";
            // 
            // txtFactura
            // 
            this.txtFactura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFactura.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFactura.Location = new System.Drawing.Point(232, 218);
            this.txtFactura.Name = "txtFactura";
            this.txtFactura.ReadOnly = true;
            this.txtFactura.Size = new System.Drawing.Size(255, 31);
            this.txtFactura.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(76, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 22);
            this.label2.TabIndex = 53;
            this.label2.Text = "Orden Compra";
            // 
            // txtOrden
            // 
            this.txtOrden.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOrden.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrden.Location = new System.Drawing.Point(232, 251);
            this.txtOrden.Name = "txtOrden";
            this.txtOrden.ReadOnly = true;
            this.txtOrden.Size = new System.Drawing.Size(255, 31);
            this.txtOrden.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(132, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 22);
            this.label4.TabIndex = 52;
            this.label4.Text = "Producto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(120, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 22);
            this.label1.TabIndex = 51;
            this.label1.Text = "Proveedor";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1044, 155);
            this.pictureBox1.TabIndex = 60;
            this.pictureBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(211)))), ((int)(((byte)(19)))));
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(70, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(171, 41);
            this.label10.TabIndex = 61;
            this.label10.Text = "ETIQUETA";
            // 
            // txtIdEtiqueta
            // 
            this.txtIdEtiqueta.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdEtiqueta.Location = new System.Drawing.Point(247, 42);
            this.txtIdEtiqueta.Name = "txtIdEtiqueta";
            this.txtIdEtiqueta.Size = new System.Drawing.Size(726, 86);
            this.txtIdEtiqueta.TabIndex = 62;
            this.txtIdEtiqueta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdEtiqueta_KeyPress);
            this.txtIdEtiqueta.Validating += new System.ComponentModel.CancelEventHandler(this.txtIdEtiqueta_Validating);
            // 
            // txtprovedor
            // 
            this.txtprovedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtprovedor.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprovedor.Location = new System.Drawing.Point(381, 185);
            this.txtprovedor.Name = "txtprovedor";
            this.txtprovedor.ReadOnly = true;
            this.txtprovedor.Size = new System.Drawing.Size(562, 31);
            this.txtprovedor.TabIndex = 63;
            // 
            // txtproducto
            // 
            this.txtproducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtproducto.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtproducto.Location = new System.Drawing.Point(381, 284);
            this.txtproducto.Name = "txtproducto";
            this.txtproducto.ReadOnly = true;
            this.txtproducto.Size = new System.Drawing.Size(562, 31);
            this.txtproducto.TabIndex = 65;
            // 
            // txtnit
            // 
            this.txtnit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnit.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnit.Location = new System.Drawing.Point(232, 185);
            this.txtnit.Name = "txtnit";
            this.txtnit.ReadOnly = true;
            this.txtnit.Size = new System.Drawing.Size(148, 31);
            this.txtnit.TabIndex = 66;
            // 
            // txtcodigo
            // 
            this.txtcodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcodigo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigo.Location = new System.Drawing.Point(232, 284);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.ReadOnly = true;
            this.txtcodigo.Size = new System.Drawing.Size(148, 31);
            this.txtcodigo.TabIndex = 67;
            // 
            // ctrolSalida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.txtnit);
            this.Controls.Add(this.txtproducto);
            this.Controls.Add(this.txtprovedor);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtIdEtiqueta);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPesoNeto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPesoBruto);
            this.Controls.Add(this.btnPeso);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFactura);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOrden);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ctrolSalida";
            this.Size = new System.Drawing.Size(1060, 564);
            this.Load += new System.EventHandler(this.ctrolSalida_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPesoNeto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPesoBruto;
        private System.Windows.Forms.Button btnPeso;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtOtraEstiba;
        private System.Windows.Forms.RadioButton rbOtro;
        private System.Windows.Forms.RadioButton rbMadera;
        private System.Windows.Forms.RadioButton rbPlastico;
        private System.Windows.Forms.RadioButton rbNoEstiba;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFactura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOrden;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtIdEtiqueta;
        private System.Windows.Forms.TextBox txtprovedor;
        private System.Windows.Forms.TextBox txtproducto;
        private System.Windows.Forms.TextBox txtnit;
        private System.Windows.Forms.TextBox txtcodigo;
    }
}
