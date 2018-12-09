namespace RegistroRetal
{
    partial class frMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frMain));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ctxtMaquina = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.lblNombreResponsable = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbResponsable = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtMaquinaOld = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPedido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbSell = new System.Windows.Forms.RadioButton();
            this.rbRefil = new System.Windows.Forms.RadioButton();
            this.rbLam = new System.Windows.Forms.RadioButton();
            this.rbImp = new System.Windows.Forms.RadioButton();
            this.rbExt = new System.Windows.Forms.RadioButton();
            this.lblDB = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.causaSellado = new RegistroRetal.Controles.CausaSellado();
            this.causaRefilado = new RegistroRetal.Controles.CausaRefilado();
            this.causasLaminacion = new RegistroRetal.Controles.CausasLaminacion();
            this.causasImpresion = new RegistroRetal.Controles.CausasImpresion();
            this.causaExtrusion = new RegistroRetal.Controles.CausaExtrusion();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.ctxtMaquina);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtObservacion);
            this.groupBox1.Controls.Add(this.lblNombreResponsable);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.causaSellado);
            this.groupBox1.Controls.Add(this.causaRefilado);
            this.groupBox1.Controls.Add(this.causasLaminacion);
            this.groupBox1.Controls.Add(this.causasImpresion);
            this.groupBox1.Controls.Add(this.causaExtrusion);
            this.groupBox1.Controls.Add(this.cmbResponsable);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDescripcion);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.txtCliente);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.txtMaquinaOld);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtPeso);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPedido);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(17, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(938, 558);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(61, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 24);
            this.button1.TabIndex = 32;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ctxtMaquina
            // 
            this.ctxtMaquina.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.ctxtMaquina.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ctxtMaquina.DropDownHeight = 100;
            this.ctxtMaquina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ctxtMaquina.DropDownWidth = 50;
            this.ctxtMaquina.FormattingEnabled = true;
            this.ctxtMaquina.IntegralHeight = false;
            this.ctxtMaquina.Location = new System.Drawing.Point(824, 175);
            this.ctxtMaquina.Name = "ctxtMaquina";
            this.ctxtMaquina.Size = new System.Drawing.Size(97, 29);
            this.ctxtMaquina.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 425);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "Observación";
            // 
            // txtObservacion
            // 
            this.txtObservacion.Location = new System.Drawing.Point(133, 421);
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(502, 130);
            this.txtObservacion.TabIndex = 29;
            // 
            // lblNombreResponsable
            // 
            this.lblNombreResponsable.AutoSize = true;
            this.lblNombreResponsable.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreResponsable.Location = new System.Drawing.Point(384, 177);
            this.lblNombreResponsable.Name = "lblNombreResponsable";
            this.lblNombreResponsable.Size = new System.Drawing.Size(102, 20);
            this.lblNombreResponsable.TabIndex = 28;
            this.lblNombreResponsable.Text = "Responsable";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RegistroRetal.Properties.Resources.icons8_Trash_Can_48;
            this.pictureBox1.Location = new System.Drawing.Point(9, 484);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // cmbResponsable
            // 
            this.cmbResponsable.DropDownHeight = 100;
            this.cmbResponsable.DropDownWidth = 394;
            this.cmbResponsable.FormattingEnabled = true;
            this.cmbResponsable.IntegralHeight = false;
            this.cmbResponsable.Location = new System.Drawing.Point(122, 170);
            this.cmbResponsable.Name = "cmbResponsable";
            this.cmbResponsable.Size = new System.Drawing.Size(256, 29);
            this.cmbResponsable.TabIndex = 3;
            this.cmbResponsable.SelectedIndexChanged += new System.EventHandler(this.cmbResponsable_SelectedIndexChanged);
            this.cmbResponsable.TextUpdate += new System.EventHandler(this.cmbResponsable_TextUpdate);
            this.cmbResponsable.TextChanged += new System.EventHandler(this.cmbResponsable_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(393, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Código";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripcion.Enabled = false;
            this.txtDescripcion.Location = new System.Drawing.Point(484, 93);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(437, 27);
            this.txtDescripcion.TabIndex = 20;
            // 
            // txtCodigo
            // 
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(484, 59);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(166, 27);
            this.txtCodigo.TabIndex = 19;
            // 
            // txtCliente
            // 
            this.txtCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCliente.Enabled = false;
            this.txtCliente.Location = new System.Drawing.Point(484, 26);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(437, 27);
            this.txtCliente.TabIndex = 18;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = global::RegistroRetal.Properties.Resources.Save_as_40px;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(789, 491);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(132, 60);
            this.btnGuardar.TabIndex = 17;
            this.btnGuardar.Text = "Registrar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtMaquinaOld
            // 
            this.txtMaquinaOld.Location = new System.Drawing.Point(824, 143);
            this.txtMaquinaOld.Name = "txtMaquinaOld";
            this.txtMaquinaOld.Size = new System.Drawing.Size(97, 27);
            this.txtMaquinaOld.TabIndex = 4;
            this.txtMaquinaOld.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(717, 178);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "#Máquina";
            // 
            // txtPeso
            // 
            this.txtPeso.Font = new System.Drawing.Font("Century Gothic", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeso.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txtPeso.Location = new System.Drawing.Point(716, 421);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(205, 65);
            this.txtPeso.TabIndex = 6;
            this.txtPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPeso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPeso_KeyPress);
            this.txtPeso.Leave += new System.EventHandler(this.txtPeso_Leave);
            this.txtPeso.Validating += new System.ComponentModel.CancelEventHandler(this.txtPeso_Validating);
            this.txtPeso.Validated += new System.EventHandler(this.txtPeso_Validated);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(641, 456);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 30);
            this.label8.TabIndex = 12;
            this.label8.Text = "Peso";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(395, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Responsable";
            // 
            // txtPedido
            // 
            this.txtPedido.Location = new System.Drawing.Point(103, 28);
            this.txtPedido.Name = "txtPedido";
            this.txtPedido.Size = new System.Drawing.Size(146, 27);
            this.txtPedido.TabIndex = 2;
            this.txtPedido.Validating += new System.ComponentModel.CancelEventHandler(this.txtPedido_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pedido";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbSell);
            this.groupBox3.Controls.Add(this.rbRefil);
            this.groupBox3.Controls.Add(this.rbLam);
            this.groupBox3.Controls.Add(this.rbImp);
            this.groupBox3.Controls.Add(this.rbExt);
            this.groupBox3.Location = new System.Drawing.Point(17, 9);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(803, 53);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Proceso";
            this.groupBox3.Validated += new System.EventHandler(this.groupBox3_Validated);
            // 
            // rbSell
            // 
            this.rbSell.AccessibleName = "sellado";
            this.rbSell.AutoSize = true;
            this.rbSell.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSell.Location = new System.Drawing.Point(704, 22);
            this.rbSell.Name = "rbSell";
            this.rbSell.Size = new System.Drawing.Size(91, 24);
            this.rbSell.TabIndex = 4;
            this.rbSell.TabStop = true;
            this.rbSell.Tag = "proceso";
            this.rbSell.Text = "SELLADO";
            this.rbSell.UseVisualStyleBackColor = true;
            this.rbSell.CheckedChanged += new System.EventHandler(this.rbSell_CheckedChanged);
            // 
            // rbRefil
            // 
            this.rbRefil.AccessibleName = "refilado";
            this.rbRefil.AutoSize = true;
            this.rbRefil.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRefil.Location = new System.Drawing.Point(546, 22);
            this.rbRefil.Name = "rbRefil";
            this.rbRefil.Size = new System.Drawing.Size(98, 24);
            this.rbRefil.TabIndex = 3;
            this.rbRefil.TabStop = true;
            this.rbRefil.Tag = "proceso";
            this.rbRefil.Text = "REFILADO";
            this.rbRefil.UseVisualStyleBackColor = true;
            this.rbRefil.CheckedChanged += new System.EventHandler(this.rbRefil_CheckedChanged);
            // 
            // rbLam
            // 
            this.rbLam.AccessibleName = "laminacion";
            this.rbLam.AutoSize = true;
            this.rbLam.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLam.Location = new System.Drawing.Point(358, 22);
            this.rbLam.Name = "rbLam";
            this.rbLam.Size = new System.Drawing.Size(128, 24);
            this.rbLam.TabIndex = 2;
            this.rbLam.TabStop = true;
            this.rbLam.Tag = "proceso";
            this.rbLam.Text = "LAMINACION";
            this.rbLam.UseVisualStyleBackColor = true;
            this.rbLam.CheckedChanged += new System.EventHandler(this.rbLam_CheckedChanged);
            // 
            // rbImp
            // 
            this.rbImp.AccessibleName = "impresion";
            this.rbImp.AutoSize = true;
            this.rbImp.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbImp.Location = new System.Drawing.Point(189, 22);
            this.rbImp.Name = "rbImp";
            this.rbImp.Size = new System.Drawing.Size(109, 24);
            this.rbImp.TabIndex = 1;
            this.rbImp.TabStop = true;
            this.rbImp.Tag = "proceso";
            this.rbImp.Text = "IMPRESION";
            this.rbImp.UseVisualStyleBackColor = true;
            this.rbImp.CheckedChanged += new System.EventHandler(this.rbImp_CheckedChanged);
            // 
            // rbExt
            // 
            this.rbExt.AccessibleName = "extrusion";
            this.rbExt.AutoSize = true;
            this.rbExt.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbExt.Location = new System.Drawing.Point(24, 22);
            this.rbExt.Name = "rbExt";
            this.rbExt.Size = new System.Drawing.Size(105, 24);
            this.rbExt.TabIndex = 0;
            this.rbExt.TabStop = true;
            this.rbExt.Tag = "proceso";
            this.rbExt.Text = "EXTRUSION";
            this.rbExt.UseVisualStyleBackColor = true;
            this.rbExt.CheckedChanged += new System.EventHandler(this.rbExt_CheckedChanged);
            // 
            // lblDB
            // 
            this.lblDB.AutoSize = true;
            this.lblDB.Font = new System.Drawing.Font("Century Gothic", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDB.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblDB.Location = new System.Drawing.Point(827, 43);
            this.lblDB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDB.Name = "lblDB";
            this.lblDB.Size = new System.Drawing.Size(20, 14);
            this.lblDB.TabIndex = 24;
            this.lblDB.Text = "DB";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Century Gothic", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblUsuario.Location = new System.Drawing.Point(827, 18);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(41, 14);
            this.lblUsuario.TabIndex = 23;
            this.lblUsuario.Text = "Usuario";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // causaSellado
            // 
            this.causaSellado.AccessibleName = "sellado";
            this.causaSellado.Font = new System.Drawing.Font("Century Gothic", 7F);
            this.causaSellado.Location = new System.Drawing.Point(9, 270);
            this.causaSellado.Margin = new System.Windows.Forms.Padding(5);
            this.causaSellado.Name = "causaSellado";
            this.causaSellado.opcion_seleccionada = ((short)(0));
            this.causaSellado.Size = new System.Drawing.Size(913, 143);
            this.causaSellado.TabIndex = 26;
            // 
            // causaRefilado
            // 
            this.causaRefilado.AccessibleName = "refilado";
            this.causaRefilado.Font = new System.Drawing.Font("Century Gothic", 7F);
            this.causaRefilado.Location = new System.Drawing.Point(9, 270);
            this.causaRefilado.Margin = new System.Windows.Forms.Padding(5);
            this.causaRefilado.Name = "causaRefilado";
            this.causaRefilado.opcion_seleccionada = ((short)(0));
            this.causaRefilado.Size = new System.Drawing.Size(913, 143);
            this.causaRefilado.TabIndex = 25;
            // 
            // causasLaminacion
            // 
            this.causasLaminacion.AccessibleName = "laminacion";
            this.causasLaminacion.Font = new System.Drawing.Font("Century Gothic", 7F);
            this.causasLaminacion.Location = new System.Drawing.Point(9, 270);
            this.causasLaminacion.Margin = new System.Windows.Forms.Padding(5);
            this.causasLaminacion.Name = "causasLaminacion";
            this.causasLaminacion.opcion_seleccionada = ((short)(0));
            this.causasLaminacion.Size = new System.Drawing.Size(913, 143);
            this.causasLaminacion.TabIndex = 24;
            // 
            // causasImpresion
            // 
            this.causasImpresion.AccessibleName = "impresion";
            this.causasImpresion.Font = new System.Drawing.Font("Century Gothic", 7F);
            this.causasImpresion.Location = new System.Drawing.Point(9, 270);
            this.causasImpresion.Margin = new System.Windows.Forms.Padding(5);
            this.causasImpresion.Name = "causasImpresion";
            this.causasImpresion.opcion_seleccionada = ((short)(0));
            this.causasImpresion.Size = new System.Drawing.Size(913, 143);
            this.causasImpresion.TabIndex = 23;
            // 
            // causaExtrusion
            // 
            this.causaExtrusion.AccessibleName = "extrusion";
            this.causaExtrusion.Font = new System.Drawing.Font("Century Gothic", 7F);
            this.causaExtrusion.Location = new System.Drawing.Point(9, 270);
            this.causaExtrusion.Margin = new System.Windows.Forms.Padding(5);
            this.causaExtrusion.Name = "causaExtrusion";
            this.causaExtrusion.opcion_seleccionada = ((short)(0));
            this.causaExtrusion.Size = new System.Drawing.Size(913, 143);
            this.causaExtrusion.TabIndex = 22;
            this.causaExtrusion.Load += new System.EventHandler(this.causaExtrusion1_Load);
            // 
            // frMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 638);
            this.Controls.Add(this.lblDB);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Retal";
            this.Load += new System.EventHandler(this.frMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbResponsable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtMaquinaOld;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPedido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbSell;
        private System.Windows.Forms.RadioButton rbRefil;
        private System.Windows.Forms.RadioButton rbLam;
        private System.Windows.Forms.RadioButton rbImp;
        private System.Windows.Forms.RadioButton rbExt;
        private System.Windows.Forms.Label lblDB;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Controles.CausaExtrusion causaExtrusion;
        private Controles.CausasLaminacion causasLaminacion;
        private Controles.CausasImpresion causasImpresion;
        private Controles.CausaRefilado causaRefilado;
        private Controles.CausaSellado causaSellado;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNombreResponsable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.ComboBox ctxtMaquina;
        private System.Windows.Forms.Button button1;
    }
}

