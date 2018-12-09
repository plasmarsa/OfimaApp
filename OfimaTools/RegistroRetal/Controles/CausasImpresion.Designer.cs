namespace RegistroRetal.Controles
{
    partial class CausasImpresion
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbMaterialMontaje = new System.Windows.Forms.RadioButton();
            this.rbPicadura = new System.Windows.Forms.RadioButton();
            this.rbRetalExtrusion = new System.Windows.Forms.RadioButton();
            this.rbRetalImpreso = new System.Windows.Forms.RadioButton();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbMaterialMontaje);
            this.groupBox4.Controls.Add(this.rbPicadura);
            this.groupBox4.Controls.Add(this.rbRetalExtrusion);
            this.groupBox4.Controls.Add(this.rbRetalImpreso);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(913, 143);
            this.groupBox4.TabIndex = 31;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Causas";
            // 
            // rbMaterialMontaje
            // 
            this.rbMaterialMontaje.AutoSize = true;
            this.rbMaterialMontaje.Location = new System.Drawing.Point(707, 58);
            this.rbMaterialMontaje.Name = "rbMaterialMontaje";
            this.rbMaterialMontaje.Size = new System.Drawing.Size(190, 24);
            this.rbMaterialMontaje.TabIndex = 20;
            this.rbMaterialMontaje.TabStop = true;
            this.rbMaterialMontaje.Text = "4.Material de Montaje";
            this.rbMaterialMontaje.UseVisualStyleBackColor = true;
            this.rbMaterialMontaje.CheckedChanged += new System.EventHandler(this.rbMaterialMontaje_CheckedChanged);
            // 
            // rbPicadura
            // 
            this.rbPicadura.AutoSize = true;
            this.rbPicadura.Location = new System.Drawing.Point(467, 58);
            this.rbPicadura.Name = "rbPicadura";
            this.rbPicadura.Size = new System.Drawing.Size(168, 24);
            this.rbPicadura.TabIndex = 19;
            this.rbPicadura.TabStop = true;
            this.rbPicadura.Text = "3.Picadura Impresa";
            this.rbPicadura.UseVisualStyleBackColor = true;
            this.rbPicadura.CheckedChanged += new System.EventHandler(this.rbPicadura_CheckedChanged);
            // 
            // rbRetalExtrusion
            // 
            this.rbRetalExtrusion.AutoSize = true;
            this.rbRetalExtrusion.Location = new System.Drawing.Point(253, 58);
            this.rbRetalExtrusion.Name = "rbRetalExtrusion";
            this.rbRetalExtrusion.Size = new System.Drawing.Size(142, 24);
            this.rbRetalExtrusion.TabIndex = 18;
            this.rbRetalExtrusion.TabStop = true;
            this.rbRetalExtrusion.Text = "2.Retal Extrusión";
            this.rbRetalExtrusion.UseVisualStyleBackColor = true;
            this.rbRetalExtrusion.CheckedChanged += new System.EventHandler(this.rbRetalExtrusion_CheckedChanged);
            // 
            // rbRetalImpreso
            // 
            this.rbRetalImpreso.AutoSize = true;
            this.rbRetalImpreso.Location = new System.Drawing.Point(42, 58);
            this.rbRetalImpreso.Name = "rbRetalImpreso";
            this.rbRetalImpreso.Size = new System.Drawing.Size(139, 24);
            this.rbRetalImpreso.TabIndex = 17;
            this.rbRetalImpreso.TabStop = true;
            this.rbRetalImpreso.Text = "1.Retal Impreso";
            this.rbRetalImpreso.UseVisualStyleBackColor = true;
            this.rbRetalImpreso.CheckedChanged += new System.EventHandler(this.rbRetalImpreso_CheckedChanged);
            // 
            // CausasImpresion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox4);
            this.Name = "CausasImpresion";
            this.Size = new System.Drawing.Size(913, 143);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbMaterialMontaje;
        private System.Windows.Forms.RadioButton rbPicadura;
        private System.Windows.Forms.RadioButton rbRetalExtrusion;
        private System.Windows.Forms.RadioButton rbRetalImpreso;
    }
}
