namespace CalidadTintas
{
    partial class ctrolPersonal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grid = new System.Windows.Forms.DataGridView();
            this.cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roll = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbPersonal = new System.Windows.Forms.ComboBox();
            this.txtRoll = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cedula,
            this.nombre,
            this.roll});
            this.grid.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.grid.Location = new System.Drawing.Point(30, 141);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grid.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.grid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(873, 356);
            this.grid.TabIndex = 58;
            this.grid.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellEnter);
            // 
            // cedula
            // 
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.cedula.DefaultCellStyle = dataGridViewCellStyle2;
            this.cedula.HeaderText = "Cedula";
            this.cedula.Name = "cedula";
            this.cedula.ReadOnly = true;
            this.cedula.Visible = false;
            // 
            // nombre
            // 
            this.nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.nombre.DefaultCellStyle = dataGridViewCellStyle3;
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 98;
            // 
            // roll
            // 
            this.roll.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.roll.DefaultCellStyle = dataGridViewCellStyle4;
            this.roll.HeaderText = "Roll";
            this.roll.Name = "roll";
            this.roll.ReadOnly = true;
            this.roll.Width = 61;
            // 
            // cmbPersonal
            // 
            this.cmbPersonal.DropDownHeight = 100;
            this.cmbPersonal.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbPersonal.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPersonal.FormattingEnabled = true;
            this.cmbPersonal.IntegralHeight = false;
            this.cmbPersonal.Location = new System.Drawing.Point(195, 70);
            this.cmbPersonal.MaxDropDownItems = 10;
            this.cmbPersonal.Name = "cmbPersonal";
            this.cmbPersonal.Size = new System.Drawing.Size(441, 25);
            this.cmbPersonal.Sorted = true;
            this.cmbPersonal.TabIndex = 57;
            this.cmbPersonal.SelectedIndexChanged += new System.EventHandler(this.cmbPersonal_SelectedIndexChanged);
            this.cmbPersonal.TextUpdate += new System.EventHandler(this.cmbPersonal_TextUpdate);
            // 
            // txtRoll
            // 
            this.txtRoll.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRoll.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoll.Location = new System.Drawing.Point(195, 98);
            this.txtRoll.Name = "txtRoll";
            this.txtRoll.Size = new System.Drawing.Size(441, 22);
            this.txtRoll.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(51, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 19);
            this.label2.TabIndex = 55;
            this.label2.Text = "Roll";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(48, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 19);
            this.label1.TabIndex = 54;
            this.label1.Text = "Empleado tintas";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = global::CalidadTintas.Properties.Resources.Delete_a_record_50px;
            this.btnEliminar.InitialImage = global::CalidadTintas.Properties.Resources.Delete_a_record_50px;
            this.btnEliminar.Location = new System.Drawing.Point(862, 95);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(40, 40);
            this.btnEliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnEliminar.TabIndex = 60;
            this.btnEliminar.TabStop = false;
            this.btnEliminar.Tag = "Aprobar control";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::CalidadTintas.Properties.Resources.Save_as_50px;
            this.btnSave.InitialImage = null;
            this.btnSave.Location = new System.Drawing.Point(824, 99);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(32, 32);
            this.btnSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSave.TabIndex = 59;
            this.btnSave.TabStop = false;
            this.btnSave.Tag = "Guardar control";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ctrolPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.cmbPersonal);
            this.Controls.Add(this.txtRoll);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ctrolPersonal";
            this.Size = new System.Drawing.Size(1050, 606);
            this.Load += new System.EventHandler(this.ctrolPersonal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.ComboBox cmbPersonal;
        private System.Windows.Forms.TextBox txtRoll;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnEliminar;
        private System.Windows.Forms.PictureBox btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn roll;
    }
}
