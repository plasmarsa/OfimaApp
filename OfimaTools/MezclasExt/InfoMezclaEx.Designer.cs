namespace MezclasExt
{
    partial class InfoMezclaEx
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
            this.bntAceptar = new DevComponents.DotNetBar.ButtonX();
            this.lblMezclaBase = new DevComponents.DotNetBar.LabelX();
            this.lblCantidad = new DevComponents.DotNetBar.LabelX();
            this.txtComponentesMezcla = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.SuspendLayout();
            // 
            // bntAceptar
            // 
            this.bntAceptar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bntAceptar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bntAceptar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntAceptar.Location = new System.Drawing.Point(447, 435);
            this.bntAceptar.Name = "bntAceptar";
            this.bntAceptar.Size = new System.Drawing.Size(92, 27);
            this.bntAceptar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bntAceptar.TabIndex = 39;
            this.bntAceptar.Text = "Aceptar";
            this.bntAceptar.Click += new System.EventHandler(this.bntAceptar_Click);
            // 
            // lblMezclaBase
            // 
            this.lblMezclaBase.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblMezclaBase.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblMezclaBase.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMezclaBase.Location = new System.Drawing.Point(3, 7);
            this.lblMezclaBase.Name = "lblMezclaBase";
            this.lblMezclaBase.Size = new System.Drawing.Size(276, 23);
            this.lblMezclaBase.TabIndex = 40;
            this.lblMezclaBase.Text = "mezclaBase";
            // 
            // lblCantidad
            // 
            this.lblCantidad.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblCantidad.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblCantidad.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(12, 47);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(527, 29);
            this.lblCantidad.TabIndex = 41;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // txtComponentesMezcla
            // 
            // 
            // 
            // 
            this.txtComponentesMezcla.Border.Class = "TextBoxBorder";
            this.txtComponentesMezcla.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtComponentesMezcla.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComponentesMezcla.Location = new System.Drawing.Point(12, 82);
            this.txtComponentesMezcla.Multiline = true;
            this.txtComponentesMezcla.Name = "txtComponentesMezcla";
            this.txtComponentesMezcla.PreventEnterBeep = true;
            this.txtComponentesMezcla.ReadOnly = true;
            this.txtComponentesMezcla.Size = new System.Drawing.Size(528, 334);
            this.txtComponentesMezcla.TabIndex = 42;
            // 
            // InfoMezclaEx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 470);
            this.Controls.Add(this.txtComponentesMezcla);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblMezclaBase);
            this.Controls.Add(this.bntAceptar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InfoMezclaEx";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Información general mezcla";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX bntAceptar;
        public DevComponents.DotNetBar.LabelX lblMezclaBase;
        public DevComponents.DotNetBar.LabelX lblCantidad;
        public DevComponents.DotNetBar.Controls.TextBoxX txtComponentesMezcla;
    }
}