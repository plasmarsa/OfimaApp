namespace RegistroRetal.Controles
{
    partial class CausaRefilado
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
            this.rbCola = new System.Windows.Forms.RadioButton();
            this.rbLaminacion = new System.Windows.Forms.RadioButton();
            this.rbImpresion = new System.Windows.Forms.RadioButton();
            this.rbExtruder = new System.Windows.Forms.RadioButton();
            this.rbMaquina = new System.Windows.Forms.RadioButton();
            this.rbTiraTTE = new System.Windows.Forms.RadioButton();
            this.rbTiraImpresa = new System.Windows.Forms.RadioButton();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbTiraImpresa);
            this.groupBox4.Controls.Add(this.rbTiraTTE);
            this.groupBox4.Controls.Add(this.rbMaquina);
            this.groupBox4.Controls.Add(this.rbCola);
            this.groupBox4.Controls.Add(this.rbLaminacion);
            this.groupBox4.Controls.Add(this.rbImpresion);
            this.groupBox4.Controls.Add(this.rbExtruder);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(913, 143);
            this.groupBox4.TabIndex = 33;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Causas";
            // 
            // rbCola
            // 
            this.rbCola.AutoSize = true;
            this.rbCola.Location = new System.Drawing.Point(254, 77);
            this.rbCola.Name = "rbCola";
            this.rbCola.Size = new System.Drawing.Size(74, 24);
            this.rbCola.TabIndex = 30;
            this.rbCola.TabStop = true;
            this.rbCola.Text = "4.Cola";
            this.rbCola.UseVisualStyleBackColor = true;
            this.rbCola.CheckedChanged += new System.EventHandler(this.rbCola_CheckedChanged);
            // 
            // rbLaminacion
            // 
            this.rbLaminacion.AutoSize = true;
            this.rbLaminacion.Location = new System.Drawing.Point(254, 37);
            this.rbLaminacion.Name = "rbLaminacion";
            this.rbLaminacion.Size = new System.Drawing.Size(123, 24);
            this.rbLaminacion.TabIndex = 28;
            this.rbLaminacion.TabStop = true;
            this.rbLaminacion.Text = "3.Laminación";
            this.rbLaminacion.UseVisualStyleBackColor = true;
            this.rbLaminacion.CheckedChanged += new System.EventHandler(this.rbLaminacion_CheckedChanged);
            // 
            // rbImpresion
            // 
            this.rbImpresion.AutoSize = true;
            this.rbImpresion.Location = new System.Drawing.Point(30, 77);
            this.rbImpresion.Name = "rbImpresion";
            this.rbImpresion.Size = new System.Drawing.Size(110, 24);
            this.rbImpresion.TabIndex = 26;
            this.rbImpresion.TabStop = true;
            this.rbImpresion.Text = "2.Impresión";
            this.rbImpresion.UseVisualStyleBackColor = true;
            this.rbImpresion.CheckedChanged += new System.EventHandler(this.rbImpresion_CheckedChanged);
            // 
            // rbExtruder
            // 
            this.rbExtruder.AutoSize = true;
            this.rbExtruder.Location = new System.Drawing.Point(30, 37);
            this.rbExtruder.Name = "rbExtruder";
            this.rbExtruder.Size = new System.Drawing.Size(98, 24);
            this.rbExtruder.TabIndex = 24;
            this.rbExtruder.TabStop = true;
            this.rbExtruder.Text = "1.Extruder";
            this.rbExtruder.UseVisualStyleBackColor = true;
            this.rbExtruder.CheckedChanged += new System.EventHandler(this.rbExtruder_CheckedChanged);
            // 
            // rbMaquina
            // 
            this.rbMaquina.AutoSize = true;
            this.rbMaquina.Location = new System.Drawing.Point(503, 37);
            this.rbMaquina.Name = "rbMaquina";
            this.rbMaquina.Size = new System.Drawing.Size(74, 24);
            this.rbMaquina.TabIndex = 31;
            this.rbMaquina.TabStop = true;
            this.rbMaquina.Text = "5.Maq";
            this.rbMaquina.UseVisualStyleBackColor = true;
            this.rbMaquina.CheckedChanged += new System.EventHandler(this.rbMaquina_CheckedChanged);
            // 
            // rbTiraTTE
            // 
            this.rbTiraTTE.AutoSize = true;
            this.rbTiraTTE.Location = new System.Drawing.Point(503, 77);
            this.rbTiraTTE.Name = "rbTiraTTE";
            this.rbTiraTTE.Size = new System.Drawing.Size(84, 24);
            this.rbTiraTTE.TabIndex = 32;
            this.rbTiraTTE.TabStop = true;
            this.rbTiraTTE.Text = "6.Tira TTE";
            this.rbTiraTTE.UseVisualStyleBackColor = true;
            this.rbTiraTTE.CheckedChanged += new System.EventHandler(this.rbTiraTTE_CheckedChanged);
            // 
            // rbTiraImpresa
            // 
            this.rbTiraImpresa.AutoSize = true;
            this.rbTiraImpresa.Location = new System.Drawing.Point(703, 37);
            this.rbTiraImpresa.Name = "rbTiraImpresa";
            this.rbTiraImpresa.Size = new System.Drawing.Size(125, 24);
            this.rbTiraImpresa.TabIndex = 33;
            this.rbTiraImpresa.TabStop = true;
            this.rbTiraImpresa.Text = "7.Tira Impresa";
            this.rbTiraImpresa.UseVisualStyleBackColor = true;
            this.rbTiraImpresa.CheckedChanged += new System.EventHandler(this.rbTiraImpresa_CheckedChanged_1);
            // 
            // CausaRefilado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox4);
            this.Name = "CausaRefilado";
            this.Size = new System.Drawing.Size(913, 143);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbCola;
        private System.Windows.Forms.RadioButton rbLaminacion;
        private System.Windows.Forms.RadioButton rbImpresion;
        private System.Windows.Forms.RadioButton rbExtruder;
        private System.Windows.Forms.RadioButton rbTiraImpresa;
        private System.Windows.Forms.RadioButton rbTiraTTE;
        private System.Windows.Forms.RadioButton rbMaquina;
    }
}
