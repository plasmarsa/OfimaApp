namespace MezclasExt
{
    partial class MovMezclaHistorico
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
            this.Grid = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.fechahora = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.operario = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.movimiento = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.lblMezclaBase = new DevComponents.DotNetBar.LabelX();
            this.pedido = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.entradas = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.salidas = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.SuspendLayout();
            // 
            // Grid
            // 
            this.Grid.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.Grid.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.Grid.Location = new System.Drawing.Point(12, 61);
            this.Grid.Name = "Grid";
            // 
            // 
            // 
            this.Grid.PrimaryGrid.Columns.Add(this.fechahora);
            this.Grid.PrimaryGrid.Columns.Add(this.operario);
            this.Grid.PrimaryGrid.Columns.Add(this.pedido);
            this.Grid.PrimaryGrid.Columns.Add(this.movimiento);
            this.Grid.PrimaryGrid.Columns.Add(this.entradas);
            this.Grid.PrimaryGrid.Columns.Add(this.salidas);
            this.Grid.PrimaryGrid.MultiSelect = false;
            this.Grid.PrimaryGrid.SelectionGranularity = DevComponents.DotNetBar.SuperGrid.SelectionGranularity.Row;
            this.Grid.PrimaryGrid.UseAlternateRowStyle = true;
            this.Grid.Size = new System.Drawing.Size(776, 424);
            this.Grid.TabIndex = 31;
            this.Grid.Text = "superGridControl1";
            // 
            // fechahora
            // 
            this.fechahora.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.DisplayedCells;
            this.fechahora.CellStyles.Default.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.fechahora.HeaderStyles.Default.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.fechahora.HeaderText = "Fecha";
            this.fechahora.Name = "fechahora";
            // 
            // operario
            // 
            this.operario.AllowEdit = false;
            this.operario.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.DisplayedCells;
            this.operario.CellStyles.Default.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operario.HeaderStyles.Default.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operario.HeaderText = "Operario";
            this.operario.Name = "operario";
            // 
            // movimiento
            // 
            this.movimiento.AllowEdit = false;
            this.movimiento.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.DisplayedCells;
            this.movimiento.CellStyles.Default.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.movimiento.HeaderStyles.Default.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.movimiento.HeaderText = "Movimiento";
            this.movimiento.Name = "movimiento";
            // 
            // lblMezclaBase
            // 
            this.lblMezclaBase.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblMezclaBase.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblMezclaBase.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMezclaBase.Location = new System.Drawing.Point(12, 12);
            this.lblMezclaBase.Name = "lblMezclaBase";
            this.lblMezclaBase.Size = new System.Drawing.Size(276, 23);
            this.lblMezclaBase.TabIndex = 32;
            this.lblMezclaBase.Text = "mezclaBase";
            // 
            // pedido
            // 
            this.pedido.CellStyles.Default.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.pedido.HeaderStyles.Default.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.pedido.HeaderText = "Pedido";
            this.pedido.Name = "pedido";
            // 
            // entradas
            // 
            this.entradas.CellStyles.Default.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.entradas.HeaderStyles.Default.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.entradas.HeaderText = "Entradas";
            this.entradas.Name = "entradas";
            // 
            // salidas
            // 
            this.salidas.CellStyles.Default.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.salidas.HeaderStyles.Default.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.salidas.HeaderText = "Salidas";
            this.salidas.Name = "salidas";
            // 
            // MovMezclaHistorico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.lblMezclaBase);
            this.Controls.Add(this.Grid);
            this.DoubleBuffered = true;
            this.Name = "MovMezclaHistorico";
            this.Text = "Movimientos";
            this.Load += new System.EventHandler(this.MovMezclaHistorico_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.SuperGrid.SuperGridControl Grid;
        private DevComponents.DotNetBar.SuperGrid.GridColumn fechahora;
        private DevComponents.DotNetBar.SuperGrid.GridColumn operario;
        private DevComponents.DotNetBar.SuperGrid.GridColumn movimiento;
        public DevComponents.DotNetBar.LabelX lblMezclaBase;
        private DevComponents.DotNetBar.SuperGrid.GridColumn pedido;
        private DevComponents.DotNetBar.SuperGrid.GridColumn entradas;
        private DevComponents.DotNetBar.SuperGrid.GridColumn salidas;
    }
}