namespace CtrolAlmacenMantenimiento
{
    partial class ctrolRegistro
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbProveedor = new System.Windows.Forms.ComboBox();
            this.gridMov = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbRepuesto = new System.Windows.Forms.ComboBox();
            this.txtDescripcionProducto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridMov)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(15, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Proveedor";
            // 
            // cmbProveedor
            // 
            this.cmbProveedor.DropDownHeight = 100;
            this.cmbProveedor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProveedor.FormattingEnabled = true;
            this.cmbProveedor.IntegralHeight = false;
            this.cmbProveedor.Location = new System.Drawing.Point(96, 7);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Size = new System.Drawing.Size(547, 25);
            this.cmbProveedor.TabIndex = 2;
            this.cmbProveedor.SelectedIndexChanged += new System.EventHandler(this.cmbProveedor_SelectedIndexChanged);
            this.cmbProveedor.TextUpdate += new System.EventHandler(this.cmbProveedor_TextUpdate);
            // 
            // gridMov
            // 
            this.gridMov.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMov.Location = new System.Drawing.Point(12, 64);
            this.gridMov.Name = "gridMov";
            this.gridMov.Size = new System.Drawing.Size(774, 409);
            this.gridMov.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(15, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Repuesto";
            // 
            // cmbRepuesto
            // 
            this.cmbRepuesto.DropDownHeight = 100;
            this.cmbRepuesto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRepuesto.FormattingEnabled = true;
            this.cmbRepuesto.IntegralHeight = false;
            this.cmbRepuesto.Location = new System.Drawing.Point(96, 33);
            this.cmbRepuesto.Name = "cmbRepuesto";
            this.cmbRepuesto.Size = new System.Drawing.Size(176, 25);
            this.cmbRepuesto.TabIndex = 18;
            this.cmbRepuesto.TextChanged += new System.EventHandler(this.cmbRepuesto_TextChanged);
            // 
            // txtDescripcionProducto
            // 
            this.txtDescripcionProducto.Location = new System.Drawing.Point(464, 37);
            this.txtDescripcionProducto.Name = "txtDescripcionProducto";
            this.txtDescripcionProducto.Size = new System.Drawing.Size(100, 22);
            this.txtDescripcionProducto.TabIndex = 20;
            this.txtDescripcionProducto.TextChanged += new System.EventHandler(this.txtDescripcionProducto_TextChanged);
            // 
            // ctrolRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtDescripcionProducto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbRepuesto);
            this.Controls.Add(this.gridMov);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbProveedor);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ctrolRegistro";
            this.Size = new System.Drawing.Size(800, 480);
            this.Load += new System.EventHandler(this.ctrolRegistro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridMov)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbProveedor;
        private System.Windows.Forms.DataGridView gridMov;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbRepuesto;
        private System.Windows.Forms.TextBox txtDescripcionProducto;
    }
}
