namespace RegistroRetal.Controles
{
    partial class CausasLaminacion
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
            this.rbOtroMaterial = new System.Windows.Forms.RadioButton();
            this.rbLaminacion = new System.Windows.Forms.RadioButton();
            this.rbImpresion = new System.Windows.Forms.RadioButton();
            this.rbExtruder = new System.Windows.Forms.RadioButton();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbOtroMaterial);
            this.groupBox4.Controls.Add(this.rbLaminacion);
            this.groupBox4.Controls.Add(this.rbImpresion);
            this.groupBox4.Controls.Add(this.rbExtruder);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(913, 143);
            this.groupBox4.TabIndex = 32;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Causas";
            // 
            // rbOtroMaterial
            // 
            this.rbOtroMaterial.AutoSize = true;
            this.rbOtroMaterial.Location = new System.Drawing.Point(716, 63);
            this.rbOtroMaterial.Name = "rbOtroMaterial";
            this.rbOtroMaterial.Size = new System.Drawing.Size(137, 24);
            this.rbOtroMaterial.TabIndex = 24;
            this.rbOtroMaterial.TabStop = true;
            this.rbOtroMaterial.Text = "4.Otro Material";
            this.rbOtroMaterial.UseVisualStyleBackColor = true;
            this.rbOtroMaterial.CheckedChanged += new System.EventHandler(this.rbOtroMaterial_CheckedChanged);
            // 
            // rbLaminacion
            // 
            this.rbLaminacion.AutoSize = true;
            this.rbLaminacion.Location = new System.Drawing.Point(476, 63);
            this.rbLaminacion.Name = "rbLaminacion";
            this.rbLaminacion.Size = new System.Drawing.Size(123, 24);
            this.rbLaminacion.TabIndex = 23;
            this.rbLaminacion.TabStop = true;
            this.rbLaminacion.Text = "3.Laminación";
            this.rbLaminacion.UseVisualStyleBackColor = true;
            this.rbLaminacion.CheckedChanged += new System.EventHandler(this.rbLaminacion_CheckedChanged);
            // 
            // rbImpresion
            // 
            this.rbImpresion.AutoSize = true;
            this.rbImpresion.Location = new System.Drawing.Point(262, 63);
            this.rbImpresion.Name = "rbImpresion";
            this.rbImpresion.Size = new System.Drawing.Size(110, 24);
            this.rbImpresion.TabIndex = 22;
            this.rbImpresion.TabStop = true;
            this.rbImpresion.Text = "2.Impresión";
            this.rbImpresion.UseVisualStyleBackColor = true;
            this.rbImpresion.CheckedChanged += new System.EventHandler(this.rbImpresion_CheckedChanged);
            // 
            // rbExtruder
            // 
            this.rbExtruder.AutoSize = true;
            this.rbExtruder.Location = new System.Drawing.Point(51, 63);
            this.rbExtruder.Name = "rbExtruder";
            this.rbExtruder.Size = new System.Drawing.Size(98, 24);
            this.rbExtruder.TabIndex = 21;
            this.rbExtruder.TabStop = true;
            this.rbExtruder.Text = "1.Extruder";
            this.rbExtruder.UseVisualStyleBackColor = true;
            this.rbExtruder.CheckedChanged += new System.EventHandler(this.rbExtruder_CheckedChanged);
            // 
            // CausasLaminacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox4);
            this.Name = "CausasLaminacion";
            this.Size = new System.Drawing.Size(913, 143);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbOtroMaterial;
        private System.Windows.Forms.RadioButton rbLaminacion;
        private System.Windows.Forms.RadioButton rbImpresion;
        private System.Windows.Forms.RadioButton rbExtruder;
    }
}
