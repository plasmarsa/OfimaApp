namespace CalidadTintas
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pLateral = new System.Windows.Forms.Panel();
            this.pBotonera = new System.Windows.Forms.Panel();
            this.btnPersonal = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnInformes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPendienteDetalle = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAprobadoDetalle = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnVehiculos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnVisitantes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCtrolAprobado = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCtrolProceso = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDashboard = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pLogo = new System.Windows.Forms.Panel();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.pTitulo = new System.Windows.Forms.Panel();
            this.lblDatabase = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.imgdataBase = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.imguser = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMarco1 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pControl = new System.Windows.Forms.Panel();
            this.pLateral.SuspendLayout();
            this.pBotonera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.pTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgdataBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imguser)).BeginInit();
            this.SuspendLayout();
            // 
            // pLateral
            // 
            this.pLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(82)))), ((int)(((byte)(97)))));
            this.pLateral.Controls.Add(this.pBotonera);
            this.pLateral.Controls.Add(this.pLogo);
            this.pLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pLateral.Location = new System.Drawing.Point(0, 0);
            this.pLateral.Name = "pLateral";
            this.pLateral.Size = new System.Drawing.Size(167, 680);
            this.pLateral.TabIndex = 0;
            // 
            // pBotonera
            // 
            this.pBotonera.BackColor = System.Drawing.Color.DodgerBlue;
            this.pBotonera.Controls.Add(this.btnPersonal);
            this.pBotonera.Controls.Add(this.btnInformes);
            this.pBotonera.Controls.Add(this.btnPendienteDetalle);
            this.pBotonera.Controls.Add(this.btnAprobadoDetalle);
            this.pBotonera.Controls.Add(this.pictureBox1);
            this.pBotonera.Controls.Add(this.btnVehiculos);
            this.pBotonera.Controls.Add(this.btnVisitantes);
            this.pBotonera.Controls.Add(this.btnCtrolAprobado);
            this.pBotonera.Controls.Add(this.btnCtrolProceso);
            this.pBotonera.Controls.Add(this.btnDashboard);
            this.pBotonera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBotonera.Location = new System.Drawing.Point(0, 72);
            this.pBotonera.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pBotonera.Name = "pBotonera";
            this.pBotonera.Size = new System.Drawing.Size(167, 608);
            this.pBotonera.TabIndex = 4;
            // 
            // btnPersonal
            // 
            this.btnPersonal.Activecolor = System.Drawing.Color.SteelBlue;
            this.btnPersonal.BackColor = System.Drawing.Color.SteelBlue;
            this.btnPersonal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPersonal.BorderRadius = 0;
            this.btnPersonal.ButtonText = "Personal Tintas";
            this.btnPersonal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPersonal.DisabledColor = System.Drawing.Color.Gray;
            this.btnPersonal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersonal.Iconcolor = System.Drawing.Color.SteelBlue;
            this.btnPersonal.Iconimage = global::CalidadTintas.Properties.Resources.Worker_50px;
            this.btnPersonal.Iconimage_right = null;
            this.btnPersonal.Iconimage_right_Selected = null;
            this.btnPersonal.Iconimage_Selected = null;
            this.btnPersonal.IconMarginLeft = 0;
            this.btnPersonal.IconMarginRight = 0;
            this.btnPersonal.IconRightVisible = true;
            this.btnPersonal.IconRightZoom = 0D;
            this.btnPersonal.IconVisible = true;
            this.btnPersonal.IconZoom = 60D;
            this.btnPersonal.IsTab = false;
            this.btnPersonal.Location = new System.Drawing.Point(0, 240);
            this.btnPersonal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPersonal.Name = "btnPersonal";
            this.btnPersonal.Normalcolor = System.Drawing.Color.SteelBlue;
            this.btnPersonal.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(211)))), ((int)(((byte)(19)))));
            this.btnPersonal.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPersonal.selected = false;
            this.btnPersonal.Size = new System.Drawing.Size(167, 48);
            this.btnPersonal.TabIndex = 17;
            this.btnPersonal.Text = "Personal Tintas";
            this.btnPersonal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPersonal.Textcolor = System.Drawing.Color.White;
            this.btnPersonal.TextFont = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersonal.Click += new System.EventHandler(this.btnPersonal_Click);
            // 
            // btnInformes
            // 
            this.btnInformes.Activecolor = System.Drawing.Color.SteelBlue;
            this.btnInformes.BackColor = System.Drawing.Color.SteelBlue;
            this.btnInformes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInformes.BorderRadius = 0;
            this.btnInformes.ButtonText = "Informes";
            this.btnInformes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInformes.DisabledColor = System.Drawing.Color.Gray;
            this.btnInformes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInformes.Iconcolor = System.Drawing.Color.SteelBlue;
            this.btnInformes.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnInformes.Iconimage")));
            this.btnInformes.Iconimage_right = null;
            this.btnInformes.Iconimage_right_Selected = null;
            this.btnInformes.Iconimage_Selected = null;
            this.btnInformes.IconMarginLeft = 0;
            this.btnInformes.IconMarginRight = 0;
            this.btnInformes.IconRightVisible = true;
            this.btnInformes.IconRightZoom = 0D;
            this.btnInformes.IconVisible = true;
            this.btnInformes.IconZoom = 60D;
            this.btnInformes.IsTab = false;
            this.btnInformes.Location = new System.Drawing.Point(0, 288);
            this.btnInformes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnInformes.Name = "btnInformes";
            this.btnInformes.Normalcolor = System.Drawing.Color.SteelBlue;
            this.btnInformes.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(211)))), ((int)(((byte)(19)))));
            this.btnInformes.OnHoverTextColor = System.Drawing.Color.White;
            this.btnInformes.selected = false;
            this.btnInformes.Size = new System.Drawing.Size(167, 48);
            this.btnInformes.TabIndex = 16;
            this.btnInformes.Text = "Informes";
            this.btnInformes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInformes.Textcolor = System.Drawing.Color.White;
            this.btnInformes.TextFont = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInformes.Click += new System.EventHandler(this.btnInformes_Click);
            // 
            // btnPendienteDetalle
            // 
            this.btnPendienteDetalle.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(75)))), ((int)(((byte)(89)))));
            this.btnPendienteDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(75)))), ((int)(((byte)(89)))));
            this.btnPendienteDetalle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPendienteDetalle.BorderRadius = 0;
            this.btnPendienteDetalle.ButtonText = "PendienteDetalle";
            this.btnPendienteDetalle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPendienteDetalle.DisabledColor = System.Drawing.Color.Gray;
            this.btnPendienteDetalle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPendienteDetalle.Iconcolor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(75)))), ((int)(((byte)(89)))));
            this.btnPendienteDetalle.Iconimage = null;
            this.btnPendienteDetalle.Iconimage_right = null;
            this.btnPendienteDetalle.Iconimage_right_Selected = null;
            this.btnPendienteDetalle.Iconimage_Selected = null;
            this.btnPendienteDetalle.IconMarginLeft = 0;
            this.btnPendienteDetalle.IconMarginRight = 0;
            this.btnPendienteDetalle.IconRightVisible = true;
            this.btnPendienteDetalle.IconRightZoom = 0D;
            this.btnPendienteDetalle.IconVisible = true;
            this.btnPendienteDetalle.IconZoom = 60D;
            this.btnPendienteDetalle.IsTab = false;
            this.btnPendienteDetalle.Location = new System.Drawing.Point(2, 394);
            this.btnPendienteDetalle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPendienteDetalle.Name = "btnPendienteDetalle";
            this.btnPendienteDetalle.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(75)))), ((int)(((byte)(89)))));
            this.btnPendienteDetalle.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(211)))), ((int)(((byte)(19)))));
            this.btnPendienteDetalle.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPendienteDetalle.selected = false;
            this.btnPendienteDetalle.Size = new System.Drawing.Size(163, 37);
            this.btnPendienteDetalle.TabIndex = 15;
            this.btnPendienteDetalle.Text = "PendienteDetalle";
            this.btnPendienteDetalle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPendienteDetalle.Textcolor = System.Drawing.Color.White;
            this.btnPendienteDetalle.TextFont = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPendienteDetalle.Visible = false;
            this.btnPendienteDetalle.Click += new System.EventHandler(this.btnPendienteDetalle_Click);
            // 
            // btnAprobadoDetalle
            // 
            this.btnAprobadoDetalle.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(75)))), ((int)(((byte)(89)))));
            this.btnAprobadoDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(75)))), ((int)(((byte)(89)))));
            this.btnAprobadoDetalle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAprobadoDetalle.BorderRadius = 0;
            this.btnAprobadoDetalle.ButtonText = "AprobadoDetalle";
            this.btnAprobadoDetalle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAprobadoDetalle.DisabledColor = System.Drawing.Color.Gray;
            this.btnAprobadoDetalle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAprobadoDetalle.Iconcolor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(75)))), ((int)(((byte)(89)))));
            this.btnAprobadoDetalle.Iconimage = null;
            this.btnAprobadoDetalle.Iconimage_right = null;
            this.btnAprobadoDetalle.Iconimage_right_Selected = null;
            this.btnAprobadoDetalle.Iconimage_Selected = null;
            this.btnAprobadoDetalle.IconMarginLeft = 0;
            this.btnAprobadoDetalle.IconMarginRight = 0;
            this.btnAprobadoDetalle.IconRightVisible = true;
            this.btnAprobadoDetalle.IconRightZoom = 0D;
            this.btnAprobadoDetalle.IconVisible = true;
            this.btnAprobadoDetalle.IconZoom = 60D;
            this.btnAprobadoDetalle.IsTab = false;
            this.btnAprobadoDetalle.Location = new System.Drawing.Point(0, 413);
            this.btnAprobadoDetalle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAprobadoDetalle.Name = "btnAprobadoDetalle";
            this.btnAprobadoDetalle.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(75)))), ((int)(((byte)(89)))));
            this.btnAprobadoDetalle.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(211)))), ((int)(((byte)(19)))));
            this.btnAprobadoDetalle.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAprobadoDetalle.selected = false;
            this.btnAprobadoDetalle.Size = new System.Drawing.Size(164, 41);
            this.btnAprobadoDetalle.TabIndex = 14;
            this.btnAprobadoDetalle.Text = "AprobadoDetalle";
            this.btnAprobadoDetalle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAprobadoDetalle.Textcolor = System.Drawing.Color.White;
            this.btnAprobadoDetalle.TextFont = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAprobadoDetalle.Visible = false;
            this.btnAprobadoDetalle.Click += new System.EventHandler(this.btnAprobadoDetalle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CalidadTintas.Properties.Resources.tintas_Logo_64px;
            this.pictureBox1.Location = new System.Drawing.Point(13, 456);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // btnVehiculos
            // 
            this.btnVehiculos.Activecolor = System.Drawing.Color.SteelBlue;
            this.btnVehiculos.BackColor = System.Drawing.Color.SteelBlue;
            this.btnVehiculos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVehiculos.BorderRadius = 0;
            this.btnVehiculos.ButtonText = "Sticker";
            this.btnVehiculos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVehiculos.DisabledColor = System.Drawing.Color.Gray;
            this.btnVehiculos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVehiculos.Iconcolor = System.Drawing.Color.SteelBlue;
            this.btnVehiculos.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnVehiculos.Iconimage")));
            this.btnVehiculos.Iconimage_right = null;
            this.btnVehiculos.Iconimage_right_Selected = null;
            this.btnVehiculos.Iconimage_Selected = null;
            this.btnVehiculos.IconMarginLeft = 0;
            this.btnVehiculos.IconMarginRight = 0;
            this.btnVehiculos.IconRightVisible = true;
            this.btnVehiculos.IconRightZoom = 0D;
            this.btnVehiculos.IconVisible = true;
            this.btnVehiculos.IconZoom = 60D;
            this.btnVehiculos.IsTab = false;
            this.btnVehiculos.Location = new System.Drawing.Point(0, 192);
            this.btnVehiculos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnVehiculos.Name = "btnVehiculos";
            this.btnVehiculos.Normalcolor = System.Drawing.Color.SteelBlue;
            this.btnVehiculos.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(211)))), ((int)(((byte)(19)))));
            this.btnVehiculos.OnHoverTextColor = System.Drawing.Color.White;
            this.btnVehiculos.selected = false;
            this.btnVehiculos.Size = new System.Drawing.Size(167, 48);
            this.btnVehiculos.TabIndex = 6;
            this.btnVehiculos.Text = "Sticker";
            this.btnVehiculos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVehiculos.Textcolor = System.Drawing.Color.White;
            this.btnVehiculos.TextFont = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVehiculos.Click += new System.EventHandler(this.btnVehiculos_Click);
            // 
            // btnVisitantes
            // 
            this.btnVisitantes.Activecolor = System.Drawing.Color.SteelBlue;
            this.btnVisitantes.BackColor = System.Drawing.Color.SteelBlue;
            this.btnVisitantes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVisitantes.BorderRadius = 0;
            this.btnVisitantes.ButtonText = "Anilox";
            this.btnVisitantes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVisitantes.DisabledColor = System.Drawing.Color.Gray;
            this.btnVisitantes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisitantes.Iconcolor = System.Drawing.Color.SteelBlue;
            this.btnVisitantes.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnVisitantes.Iconimage")));
            this.btnVisitantes.Iconimage_right = null;
            this.btnVisitantes.Iconimage_right_Selected = null;
            this.btnVisitantes.Iconimage_Selected = null;
            this.btnVisitantes.IconMarginLeft = 0;
            this.btnVisitantes.IconMarginRight = 0;
            this.btnVisitantes.IconRightVisible = true;
            this.btnVisitantes.IconRightZoom = 0D;
            this.btnVisitantes.IconVisible = true;
            this.btnVisitantes.IconZoom = 60D;
            this.btnVisitantes.IsTab = false;
            this.btnVisitantes.Location = new System.Drawing.Point(0, 144);
            this.btnVisitantes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnVisitantes.Name = "btnVisitantes";
            this.btnVisitantes.Normalcolor = System.Drawing.Color.SteelBlue;
            this.btnVisitantes.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(211)))), ((int)(((byte)(19)))));
            this.btnVisitantes.OnHoverTextColor = System.Drawing.Color.White;
            this.btnVisitantes.selected = false;
            this.btnVisitantes.Size = new System.Drawing.Size(167, 48);
            this.btnVisitantes.TabIndex = 5;
            this.btnVisitantes.Text = "Anilox";
            this.btnVisitantes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVisitantes.Textcolor = System.Drawing.Color.White;
            this.btnVisitantes.TextFont = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisitantes.Click += new System.EventHandler(this.btnVisitantes_Click);
            // 
            // btnCtrolAprobado
            // 
            this.btnCtrolAprobado.Activecolor = System.Drawing.Color.SteelBlue;
            this.btnCtrolAprobado.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCtrolAprobado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCtrolAprobado.BorderRadius = 0;
            this.btnCtrolAprobado.ButtonText = "Aprobados";
            this.btnCtrolAprobado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCtrolAprobado.DisabledColor = System.Drawing.Color.Gray;
            this.btnCtrolAprobado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCtrolAprobado.Iconcolor = System.Drawing.Color.SteelBlue;
            this.btnCtrolAprobado.Iconimage = global::CalidadTintas.Properties.Resources.Approve_50px;
            this.btnCtrolAprobado.Iconimage_right = null;
            this.btnCtrolAprobado.Iconimage_right_Selected = null;
            this.btnCtrolAprobado.Iconimage_Selected = null;
            this.btnCtrolAprobado.IconMarginLeft = 0;
            this.btnCtrolAprobado.IconMarginRight = 0;
            this.btnCtrolAprobado.IconRightVisible = true;
            this.btnCtrolAprobado.IconRightZoom = 0D;
            this.btnCtrolAprobado.IconVisible = true;
            this.btnCtrolAprobado.IconZoom = 60D;
            this.btnCtrolAprobado.IsTab = false;
            this.btnCtrolAprobado.Location = new System.Drawing.Point(0, 96);
            this.btnCtrolAprobado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCtrolAprobado.Name = "btnCtrolAprobado";
            this.btnCtrolAprobado.Normalcolor = System.Drawing.Color.SteelBlue;
            this.btnCtrolAprobado.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(211)))), ((int)(((byte)(19)))));
            this.btnCtrolAprobado.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCtrolAprobado.selected = false;
            this.btnCtrolAprobado.Size = new System.Drawing.Size(167, 48);
            this.btnCtrolAprobado.TabIndex = 4;
            this.btnCtrolAprobado.Text = "Aprobados";
            this.btnCtrolAprobado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCtrolAprobado.Textcolor = System.Drawing.Color.White;
            this.btnCtrolAprobado.TextFont = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCtrolAprobado.Click += new System.EventHandler(this.btnCtrolAprobado_Click);
            // 
            // btnCtrolProceso
            // 
            this.btnCtrolProceso.Activecolor = System.Drawing.Color.SteelBlue;
            this.btnCtrolProceso.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCtrolProceso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCtrolProceso.BorderRadius = 0;
            this.btnCtrolProceso.ButtonText = "En Proceso";
            this.btnCtrolProceso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCtrolProceso.DisabledColor = System.Drawing.Color.Gray;
            this.btnCtrolProceso.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCtrolProceso.Iconcolor = System.Drawing.Color.SteelBlue;
            this.btnCtrolProceso.Iconimage = global::CalidadTintas.Properties.Resources.Save_as_48px;
            this.btnCtrolProceso.Iconimage_right = null;
            this.btnCtrolProceso.Iconimage_right_Selected = null;
            this.btnCtrolProceso.Iconimage_Selected = null;
            this.btnCtrolProceso.IconMarginLeft = 0;
            this.btnCtrolProceso.IconMarginRight = 0;
            this.btnCtrolProceso.IconRightVisible = true;
            this.btnCtrolProceso.IconRightZoom = 0D;
            this.btnCtrolProceso.IconVisible = true;
            this.btnCtrolProceso.IconZoom = 48D;
            this.btnCtrolProceso.IsTab = false;
            this.btnCtrolProceso.Location = new System.Drawing.Point(0, 48);
            this.btnCtrolProceso.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCtrolProceso.Name = "btnCtrolProceso";
            this.btnCtrolProceso.Normalcolor = System.Drawing.Color.SteelBlue;
            this.btnCtrolProceso.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(211)))), ((int)(((byte)(19)))));
            this.btnCtrolProceso.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCtrolProceso.selected = false;
            this.btnCtrolProceso.Size = new System.Drawing.Size(167, 48);
            this.btnCtrolProceso.TabIndex = 3;
            this.btnCtrolProceso.Text = "En Proceso";
            this.btnCtrolProceso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCtrolProceso.Textcolor = System.Drawing.Color.White;
            this.btnCtrolProceso.TextFont = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCtrolProceso.Click += new System.EventHandler(this.btnCtrolProceso_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Activecolor = System.Drawing.Color.SteelBlue;
            this.btnDashboard.BackColor = System.Drawing.Color.SteelBlue;
            this.btnDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDashboard.BorderRadius = 0;
            this.btnDashboard.ButtonText = "Dashboard";
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.DisabledColor = System.Drawing.Color.Gray;
            this.btnDashboard.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.Iconcolor = System.Drawing.Color.SteelBlue;
            this.btnDashboard.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Iconimage")));
            this.btnDashboard.Iconimage_right = null;
            this.btnDashboard.Iconimage_right_Selected = null;
            this.btnDashboard.Iconimage_Selected = null;
            this.btnDashboard.IconMarginLeft = 0;
            this.btnDashboard.IconMarginRight = 0;
            this.btnDashboard.IconRightVisible = true;
            this.btnDashboard.IconRightZoom = 0D;
            this.btnDashboard.IconVisible = true;
            this.btnDashboard.IconZoom = 60D;
            this.btnDashboard.IsTab = false;
            this.btnDashboard.Location = new System.Drawing.Point(0, 0);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Normalcolor = System.Drawing.Color.SteelBlue;
            this.btnDashboard.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(211)))), ((int)(((byte)(19)))));
            this.btnDashboard.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDashboard.selected = false;
            this.btnDashboard.Size = new System.Drawing.Size(167, 48);
            this.btnDashboard.TabIndex = 2;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Textcolor = System.Drawing.Color.White;
            this.btnDashboard.TextFont = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // pLogo
            // 
            this.pLogo.BackColor = System.Drawing.Color.DodgerBlue;
            this.pLogo.Controls.Add(this.imgLogo);
            this.pLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pLogo.Location = new System.Drawing.Point(0, 0);
            this.pLogo.Name = "pLogo";
            this.pLogo.Size = new System.Drawing.Size(167, 72);
            this.pLogo.TabIndex = 0;
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
            this.pTitulo.Controls.Add(this.lblDatabase);
            this.pTitulo.Controls.Add(this.lblUsuario);
            this.pTitulo.Controls.Add(this.imgdataBase);
            this.pTitulo.Controls.Add(this.btnClose);
            this.pTitulo.Controls.Add(this.imguser);
            this.pTitulo.Controls.Add(this.label1);
            this.pTitulo.Controls.Add(this.lblMarco1);
            this.pTitulo.Controls.Add(this.lblTitulo);
            this.pTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTitulo.Location = new System.Drawing.Point(167, 0);
            this.pTitulo.Name = "pTitulo";
            this.pTitulo.Size = new System.Drawing.Size(1082, 69);
            this.pTitulo.TabIndex = 1;
            // 
            // lblDatabase
            // 
            this.lblDatabase.AutoSize = true;
            this.lblDatabase.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatabase.Location = new System.Drawing.Point(21, 22);
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.Size = new System.Drawing.Size(63, 16);
            this.lblDatabase.TabIndex = 15;
            this.lblDatabase.Text = "Database";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(21, 7);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(47, 16);
            this.lblUsuario.TabIndex = 14;
            this.lblUsuario.Text = "Usuario";
            // 
            // imgdataBase
            // 
            this.imgdataBase.Image = ((System.Drawing.Image)(resources.GetObject("imgdataBase.Image")));
            this.imgdataBase.Location = new System.Drawing.Point(6, 21);
            this.imgdataBase.Name = "imgdataBase";
            this.imgdataBase.Size = new System.Drawing.Size(15, 15);
            this.imgdataBase.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgdataBase.TabIndex = 13;
            this.imgdataBase.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1025, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 32);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 12;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // imguser
            // 
            this.imguser.Image = ((System.Drawing.Image)(resources.GetObject("imguser.Image")));
            this.imguser.Location = new System.Drawing.Point(6, 6);
            this.imguser.Name = "imguser";
            this.imguser.Size = new System.Drawing.Size(15, 15);
            this.imguser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imguser.TabIndex = 11;
            this.imguser.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(980, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "PLASMAR S.A";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMarco1
            // 
            this.lblMarco1.AutoSize = true;
            this.lblMarco1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarco1.Location = new System.Drawing.Point(973, 54);
            this.lblMarco1.Name = "lblMarco1";
            this.lblMarco1.Size = new System.Drawing.Size(84, 16);
            this.lblMarco1.TabIndex = 9;
            this.lblMarco1.Text = "Area de Tintas";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(32, 39);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(185, 30);
            this.lblTitulo.TabIndex = 8;
            this.lblTitulo.Text = "Titulo Ventana";
            // 
            // pControl
            // 
            this.pControl.BackColor = System.Drawing.Color.Silver;
            this.pControl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pControl.Location = new System.Drawing.Point(167, 69);
            this.pControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pControl.Name = "pControl";
            this.pControl.Size = new System.Drawing.Size(1082, 611);
            this.pControl.TabIndex = 2;
            this.pControl.Paint += new System.Windows.Forms.PaintEventHandler(this.pControl_Paint);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 680);
            this.Controls.Add(this.pControl);
            this.Controls.Add(this.pTitulo);
            this.Controls.Add(this.pLateral);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calidad tintas";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pLateral.ResumeLayout(false);
            this.pBotonera.ResumeLayout(false);
            this.pBotonera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.pTitulo.ResumeLayout(false);
            this.pTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgdataBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imguser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pLateral;
        private System.Windows.Forms.Panel pLogo;
        private System.Windows.Forms.Panel pTitulo;
        private System.Windows.Forms.Panel pControl;
        private System.Windows.Forms.Label lblDatabase;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.PictureBox imgdataBase;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.PictureBox imguser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMarco1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pBotonera;
        private Bunifu.Framework.UI.BunifuFlatButton btnVehiculos;
        private Bunifu.Framework.UI.BunifuFlatButton btnVisitantes;
        private Bunifu.Framework.UI.BunifuFlatButton btnCtrolAprobado;
        private Bunifu.Framework.UI.BunifuFlatButton btnCtrolProceso;
        private Bunifu.Framework.UI.BunifuFlatButton btnDashboard;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuFlatButton btnPendienteDetalle;
        private Bunifu.Framework.UI.BunifuFlatButton btnAprobadoDetalle;
        private Bunifu.Framework.UI.BunifuFlatButton btnPersonal;
        private Bunifu.Framework.UI.BunifuFlatButton btnInformes;
    }
}

