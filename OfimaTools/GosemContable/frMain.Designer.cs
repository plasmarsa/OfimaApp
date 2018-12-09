namespace GosemContable
{
    partial class frMain
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frMain));
            this.pLateral = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pLogo = new System.Windows.Forms.Panel();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.pTitulo = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblMarco1 = new System.Windows.Forms.Label();
            this.lblDatabase = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.imgdataBase = new System.Windows.Forms.PictureBox();
            this.imguser = new System.Windows.Forms.PictureBox();
            this.pControl = new System.Windows.Forms.Panel();
            this.btnMigrarDatos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.pTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgdataBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imguser)).BeginInit();
            this.SuspendLayout();
            // 
            // pLateral
            // 
            this.pLateral.BackColor = System.Drawing.Color.DodgerBlue;
            this.pLateral.Controls.Add(this.btnMigrarDatos);
            this.pLateral.Controls.Add(this.pictureBox1);
            this.pLateral.Controls.Add(this.pLogo);
            this.pLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pLateral.Location = new System.Drawing.Point(0, 0);
            this.pLateral.Name = "pLateral";
            this.pLateral.Size = new System.Drawing.Size(155, 561);
            this.pLateral.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(59, 491);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 65);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pLogo
            // 
            this.pLogo.BackColor = System.Drawing.Color.DodgerBlue;
            this.pLogo.Controls.Add(this.imgLogo);
            this.pLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pLogo.Location = new System.Drawing.Point(0, 0);
            this.pLogo.Name = "pLogo";
            this.pLogo.Size = new System.Drawing.Size(155, 72);
            this.pLogo.TabIndex = 1;
            // 
            // imgLogo
            // 
            this.imgLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgLogo.Image")));
            this.imgLogo.Location = new System.Drawing.Point(13, 4);
            this.imgLogo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(125, 65);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLogo.TabIndex = 1;
            this.imgLogo.TabStop = false;
            // 
            // pTitulo
            // 
            this.pTitulo.BackColor = System.Drawing.Color.DodgerBlue;
            this.pTitulo.Controls.Add(this.btnClose);
            this.pTitulo.Controls.Add(this.label1);
            this.pTitulo.Controls.Add(this.lblTitulo);
            this.pTitulo.Controls.Add(this.lblMarco1);
            this.pTitulo.Controls.Add(this.lblDatabase);
            this.pTitulo.Controls.Add(this.lblUsuario);
            this.pTitulo.Controls.Add(this.imgdataBase);
            this.pTitulo.Controls.Add(this.imguser);
            this.pTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTitulo.Location = new System.Drawing.Point(155, 0);
            this.pTitulo.Name = "pTitulo";
            this.pTitulo.Size = new System.Drawing.Size(829, 72);
            this.pTitulo.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(792, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 32);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 15;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(747, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "PLASMAR S.A";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(31, 39);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(185, 30);
            this.lblTitulo.TabIndex = 20;
            this.lblTitulo.Text = "Titulo Ventana";
            // 
            // lblMarco1
            // 
            this.lblMarco1.AutoSize = true;
            this.lblMarco1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarco1.ForeColor = System.Drawing.Color.White;
            this.lblMarco1.Location = new System.Drawing.Point(664, 52);
            this.lblMarco1.Name = "lblMarco1";
            this.lblMarco1.Size = new System.Drawing.Size(160, 16);
            this.lblMarco1.TabIndex = 13;
            this.lblMarco1.Text = "Almacen de Mantenimiento";
            // 
            // lblDatabase
            // 
            this.lblDatabase.AutoSize = true;
            this.lblDatabase.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatabase.ForeColor = System.Drawing.Color.White;
            this.lblDatabase.Location = new System.Drawing.Point(22, 24);
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.Size = new System.Drawing.Size(63, 16);
            this.lblDatabase.TabIndex = 19;
            this.lblDatabase.Text = "Database";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(22, 9);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(47, 16);
            this.lblUsuario.TabIndex = 18;
            this.lblUsuario.Text = "Usuario";
            // 
            // imgdataBase
            // 
            this.imgdataBase.Image = ((System.Drawing.Image)(resources.GetObject("imgdataBase.Image")));
            this.imgdataBase.Location = new System.Drawing.Point(7, 23);
            this.imgdataBase.Name = "imgdataBase";
            this.imgdataBase.Size = new System.Drawing.Size(15, 15);
            this.imgdataBase.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgdataBase.TabIndex = 17;
            this.imgdataBase.TabStop = false;
            // 
            // imguser
            // 
            this.imguser.Image = ((System.Drawing.Image)(resources.GetObject("imguser.Image")));
            this.imguser.Location = new System.Drawing.Point(7, 8);
            this.imguser.Name = "imguser";
            this.imguser.Size = new System.Drawing.Size(15, 15);
            this.imguser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imguser.TabIndex = 16;
            this.imguser.TabStop = false;
            // 
            // pControl
            // 
            this.pControl.BackColor = System.Drawing.Color.Silver;
            this.pControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pControl.Location = new System.Drawing.Point(155, 72);
            this.pControl.Name = "pControl";
            this.pControl.Size = new System.Drawing.Size(829, 489);
            this.pControl.TabIndex = 3;
            // 
            // btnMigrarDatos
            // 
            this.btnMigrarDatos.Activecolor = System.Drawing.Color.SteelBlue;
            this.btnMigrarDatos.BackColor = System.Drawing.Color.SteelBlue;
            this.btnMigrarDatos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMigrarDatos.BorderRadius = 0;
            this.btnMigrarDatos.ButtonText = "Migrar Datos Contables";
            this.btnMigrarDatos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMigrarDatos.DisabledColor = System.Drawing.Color.Gray;
            this.btnMigrarDatos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMigrarDatos.Iconcolor = System.Drawing.Color.SteelBlue;
            this.btnMigrarDatos.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnMigrarDatos.Iconimage")));
            this.btnMigrarDatos.Iconimage_right = null;
            this.btnMigrarDatos.Iconimage_right_Selected = null;
            this.btnMigrarDatos.Iconimage_Selected = null;
            this.btnMigrarDatos.IconMarginLeft = 0;
            this.btnMigrarDatos.IconMarginRight = 0;
            this.btnMigrarDatos.IconRightVisible = true;
            this.btnMigrarDatos.IconRightZoom = 0D;
            this.btnMigrarDatos.IconVisible = true;
            this.btnMigrarDatos.IconZoom = 70D;
            this.btnMigrarDatos.IsTab = false;
            this.btnMigrarDatos.Location = new System.Drawing.Point(0, 72);
            this.btnMigrarDatos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMigrarDatos.Name = "btnMigrarDatos";
            this.btnMigrarDatos.Normalcolor = System.Drawing.Color.SteelBlue;
            this.btnMigrarDatos.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(211)))), ((int)(((byte)(19)))));
            this.btnMigrarDatos.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMigrarDatos.selected = false;
            this.btnMigrarDatos.Size = new System.Drawing.Size(155, 50);
            this.btnMigrarDatos.TabIndex = 4;
            this.btnMigrarDatos.Text = "Migrar Datos Contables";
            this.btnMigrarDatos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMigrarDatos.Textcolor = System.Drawing.Color.White;
            this.btnMigrarDatos.TextFont = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMigrarDatos.Click += new System.EventHandler(this.btnMigrarDatos_Click);
            // 
            // frMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.pControl);
            this.Controls.Add(this.pTitulo);
            this.Controls.Add(this.pLateral);
            this.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frMain";
            this.Text = "Form1";
            this.pLateral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.pTitulo.ResumeLayout(false);
            this.pTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgdataBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imguser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pLateral;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pLogo;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Panel pTitulo;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblMarco1;
        private System.Windows.Forms.Label lblDatabase;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.PictureBox imgdataBase;
        private System.Windows.Forms.PictureBox imguser;
        private System.Windows.Forms.Panel pControl;
        private Bunifu.Framework.UI.BunifuFlatButton btnMigrarDatos;
    }
}

