namespace CalidadTintas
{
    partial class frmCambiarTinteros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCambiarTinteros));
            this.cmbOrigen = new System.Windows.Forms.ComboBox();
            this.cmbDestino = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCambiarTinteros = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnCambiarTinteros)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbOrigen
            // 
            this.cmbOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrigen.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOrigen.FormattingEnabled = true;
            this.cmbOrigen.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cmbOrigen.Location = new System.Drawing.Point(14, 42);
            this.cmbOrigen.Name = "cmbOrigen";
            this.cmbOrigen.Size = new System.Drawing.Size(121, 29);
            this.cmbOrigen.TabIndex = 0;
            // 
            // cmbDestino
            // 
            this.cmbDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDestino.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDestino.FormattingEnabled = true;
            this.cmbDestino.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cmbDestino.Location = new System.Drawing.Point(175, 42);
            this.cmbDestino.Name = "cmbDestino";
            this.cmbDestino.Size = new System.Drawing.Size(121, 29);
            this.cmbDestino.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tintero Origen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(175, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tintero Destino";
            // 
            // btnCambiarTinteros
            // 
            this.btnCambiarTinteros.Image = ((System.Drawing.Image)(resources.GetObject("btnCambiarTinteros.Image")));
            this.btnCambiarTinteros.Location = new System.Drawing.Point(347, 18);
            this.btnCambiarTinteros.Name = "btnCambiarTinteros";
            this.btnCambiarTinteros.Size = new System.Drawing.Size(40, 40);
            this.btnCambiarTinteros.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCambiarTinteros.TabIndex = 66;
            this.btnCambiarTinteros.TabStop = false;
            this.btnCambiarTinteros.Tag = "Aprobar control";
            this.btnCambiarTinteros.Click += new System.EventHandler(this.btnCambiarTinteros_Click);
            // 
            // frmCambiarTinteros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 90);
            this.Controls.Add(this.btnCambiarTinteros);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbDestino);
            this.Controls.Add(this.cmbOrigen);
            this.Name = "frmCambiarTinteros";
            this.Text = "frmCambiarTinteros";
            this.Load += new System.EventHandler(this.frmCambiarTinteros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnCambiarTinteros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbOrigen;
        private System.Windows.Forms.ComboBox cmbDestino;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox btnCambiarTinteros;
    }
}