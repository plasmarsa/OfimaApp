namespace RegistroRetal.Controles
{
    partial class CausaSellado
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
            this.rbTira = new System.Windows.Forms.RadioButton();
            this.rbEnfuellado = new System.Windows.Forms.RadioButton();
            this.rbImpresion = new System.Windows.Forms.RadioButton();
            this.rbTroquel = new System.Windows.Forms.RadioButton();
            this.rbExtruder = new System.Windows.Forms.RadioButton();
            this.rbMaquina = new System.Windows.Forms.RadioButton();
            this.rbRefilado = new System.Windows.Forms.RadioButton();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbRefilado);
            this.groupBox4.Controls.Add(this.rbTira);
            this.groupBox4.Controls.Add(this.rbEnfuellado);
            this.groupBox4.Controls.Add(this.rbImpresion);
            this.groupBox4.Controls.Add(this.rbTroquel);
            this.groupBox4.Controls.Add(this.rbExtruder);
            this.groupBox4.Controls.Add(this.rbMaquina);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(913, 143);
            this.groupBox4.TabIndex = 33;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Causas";
            // 
            // rbTira
            // 
            this.rbTira.AutoSize = true;
            this.rbTira.Location = new System.Drawing.Point(555, 64);
            this.rbTira.Name = "rbTira";
            this.rbTira.Size = new System.Drawing.Size(62, 24);
            this.rbTira.TabIndex = 46;
            this.rbTira.TabStop = true;
            this.rbTira.Text = "5.Tira";
            this.rbTira.UseVisualStyleBackColor = true;
            this.rbTira.CheckedChanged += new System.EventHandler(this.rbTira_CheckedChanged);
            // 
            // rbEnfuellado
            // 
            this.rbEnfuellado.AutoSize = true;
            this.rbEnfuellado.Location = new System.Drawing.Point(650, 64);
            this.rbEnfuellado.Name = "rbEnfuellado";
            this.rbEnfuellado.Size = new System.Drawing.Size(116, 24);
            this.rbEnfuellado.TabIndex = 45;
            this.rbEnfuellado.TabStop = true;
            this.rbEnfuellado.Text = "6.Enfuellado";
            this.rbEnfuellado.UseVisualStyleBackColor = true;
            this.rbEnfuellado.CheckedChanged += new System.EventHandler(this.rbEnfuellado_CheckedChanged);
            // 
            // rbImpresion
            // 
            this.rbImpresion.AutoSize = true;
            this.rbImpresion.Location = new System.Drawing.Point(150, 64);
            this.rbImpresion.Name = "rbImpresion";
            this.rbImpresion.Size = new System.Drawing.Size(110, 24);
            this.rbImpresion.TabIndex = 43;
            this.rbImpresion.TabStop = true;
            this.rbImpresion.Text = "2.Impresión";
            this.rbImpresion.UseVisualStyleBackColor = true;
            this.rbImpresion.CheckedChanged += new System.EventHandler(this.rbImpresion_CheckedChanged);
            // 
            // rbTroquel
            // 
            this.rbTroquel.AutoSize = true;
            this.rbTroquel.Location = new System.Drawing.Point(431, 64);
            this.rbTroquel.Name = "rbTroquel";
            this.rbTroquel.Size = new System.Drawing.Size(91, 24);
            this.rbTroquel.TabIndex = 42;
            this.rbTroquel.TabStop = true;
            this.rbTroquel.Text = "4.Troquel";
            this.rbTroquel.UseVisualStyleBackColor = true;
            this.rbTroquel.CheckedChanged += new System.EventHandler(this.rbTroquel_CheckedChanged);
            // 
            // rbExtruder
            // 
            this.rbExtruder.AutoSize = true;
            this.rbExtruder.Location = new System.Drawing.Point(19, 64);
            this.rbExtruder.Name = "rbExtruder";
            this.rbExtruder.Size = new System.Drawing.Size(98, 24);
            this.rbExtruder.TabIndex = 41;
            this.rbExtruder.TabStop = true;
            this.rbExtruder.Text = "1.Extruder";
            this.rbExtruder.UseVisualStyleBackColor = true;
            this.rbExtruder.CheckedChanged += new System.EventHandler(this.rbExtruder_CheckedChanged);
            // 
            // rbMaquina
            // 
            this.rbMaquina.AutoSize = true;
            this.rbMaquina.Location = new System.Drawing.Point(293, 64);
            this.rbMaquina.Name = "rbMaquina";
            this.rbMaquina.Size = new System.Drawing.Size(105, 24);
            this.rbMaquina.TabIndex = 32;
            this.rbMaquina.TabStop = true;
            this.rbMaquina.Text = "3.Maquina";
            this.rbMaquina.UseVisualStyleBackColor = true;
            this.rbMaquina.CheckedChanged += new System.EventHandler(this.rbMaquina_CheckedChanged);
            // 
            // rbRefilado
            // 
            this.rbRefilado.AutoSize = true;
            this.rbRefilado.Location = new System.Drawing.Point(799, 64);
            this.rbRefilado.Name = "rbRefilado";
            this.rbRefilado.Size = new System.Drawing.Size(99, 24);
            this.rbRefilado.TabIndex = 47;
            this.rbRefilado.TabStop = true;
            this.rbRefilado.Text = "7.Refilado";
            this.rbRefilado.UseVisualStyleBackColor = true;
            this.rbRefilado.CheckedChanged += new System.EventHandler(this.rbRefilado_CheckedChanged);
            // 
            // CausaSellado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox4);
            this.Name = "CausaSellado";
            this.Size = new System.Drawing.Size(913, 143);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbTira;
        private System.Windows.Forms.RadioButton rbEnfuellado;
        private System.Windows.Forms.RadioButton rbImpresion;
        private System.Windows.Forms.RadioButton rbTroquel;
        private System.Windows.Forms.RadioButton rbExtruder;
        private System.Windows.Forms.RadioButton rbMaquina;
        private System.Windows.Forms.RadioButton rbRefilado;
    }
}
