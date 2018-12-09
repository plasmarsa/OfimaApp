namespace MuestreoPLC
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Abort = new System.Windows.Forms.Button();
            this.btnMonitor = new System.Windows.Forms.Button();
            this.chkImp10 = new System.Windows.Forms.CheckBox();
            this.chkImp9 = new System.Windows.Forms.CheckBox();
            this.chkImp8 = new System.Windows.Forms.CheckBox();
            this.chkImp7 = new System.Windows.Forms.CheckBox();
            this.chkImp6 = new System.Windows.Forms.CheckBox();
            this.chkImp5 = new System.Windows.Forms.CheckBox();
            this.chkImp4 = new System.Windows.Forms.CheckBox();
            this.Disconnect = new System.Windows.Forms.Button();
            this.chkImp3 = new System.Windows.Forms.CheckBox();
            this.chkImp2 = new System.Windows.Forms.CheckBox();
            this.chkImp1 = new System.Windows.Forms.CheckBox();
            this.plcInformation = new System.Windows.Forms.GroupBox();
            this.txtPlcName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtFactoryBoot = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBinLib = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoot = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOS = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHW = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Connect = new System.Windows.Forms.Button();
            this.LongPeriodRead = new System.Windows.Forms.Button();
            this.Run = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.Init = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.ReadAsynch = new System.Windows.Forms.Button();
            this.Write = new System.Windows.Forms.Button();
            this.Read = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.plcInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Abort);
            this.groupBox2.Controls.Add(this.btnMonitor);
            this.groupBox2.Controls.Add(this.chkImp10);
            this.groupBox2.Controls.Add(this.chkImp9);
            this.groupBox2.Controls.Add(this.chkImp8);
            this.groupBox2.Controls.Add(this.chkImp7);
            this.groupBox2.Controls.Add(this.chkImp6);
            this.groupBox2.Controls.Add(this.chkImp5);
            this.groupBox2.Controls.Add(this.chkImp4);
            this.groupBox2.Controls.Add(this.Disconnect);
            this.groupBox2.Controls.Add(this.chkImp3);
            this.groupBox2.Controls.Add(this.chkImp2);
            this.groupBox2.Controls.Add(this.chkImp1);
            this.groupBox2.Location = new System.Drawing.Point(12, 216);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(366, 178);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Impresoras";
            // 
            // Abort
            // 
            this.Abort.Enabled = false;
            this.Abort.Location = new System.Drawing.Point(247, 53);
            this.Abort.Name = "Abort";
            this.Abort.Size = new System.Drawing.Size(113, 22);
            this.Abort.TabIndex = 33;
            this.Abort.Text = "Abort";
            this.Abort.UseVisualStyleBackColor = true;
            this.Abort.Click += new System.EventHandler(this.Abort_Click);
            // 
            // btnMonitor
            // 
            this.btnMonitor.Location = new System.Drawing.Point(247, 10);
            this.btnMonitor.Name = "btnMonitor";
            this.btnMonitor.Size = new System.Drawing.Size(113, 23);
            this.btnMonitor.TabIndex = 10;
            this.btnMonitor.Text = "Read PLC";
            this.btnMonitor.UseVisualStyleBackColor = true;
            this.btnMonitor.Click += new System.EventHandler(this.btnMonitor_Click);
            // 
            // chkImp10
            // 
            this.chkImp10.AutoSize = true;
            this.chkImp10.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkImp10.Location = new System.Drawing.Point(98, 114);
            this.chkImp10.Name = "chkImp10";
            this.chkImp10.Size = new System.Drawing.Size(74, 23);
            this.chkImp10.TabIndex = 9;
            this.chkImp10.Text = "Imp 10";
            this.chkImp10.UseVisualStyleBackColor = true;
            // 
            // chkImp9
            // 
            this.chkImp9.AutoSize = true;
            this.chkImp9.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkImp9.Location = new System.Drawing.Point(98, 91);
            this.chkImp9.Name = "chkImp9";
            this.chkImp9.Size = new System.Drawing.Size(66, 23);
            this.chkImp9.TabIndex = 8;
            this.chkImp9.Text = "Imp 9";
            this.chkImp9.UseVisualStyleBackColor = true;
            // 
            // chkImp8
            // 
            this.chkImp8.AutoSize = true;
            this.chkImp8.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkImp8.Location = new System.Drawing.Point(98, 65);
            this.chkImp8.Name = "chkImp8";
            this.chkImp8.Size = new System.Drawing.Size(66, 23);
            this.chkImp8.TabIndex = 7;
            this.chkImp8.Text = "Imp 8";
            this.chkImp8.UseVisualStyleBackColor = true;
            // 
            // chkImp7
            // 
            this.chkImp7.AutoSize = true;
            this.chkImp7.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkImp7.Location = new System.Drawing.Point(98, 42);
            this.chkImp7.Name = "chkImp7";
            this.chkImp7.Size = new System.Drawing.Size(66, 23);
            this.chkImp7.TabIndex = 6;
            this.chkImp7.Text = "Imp 7";
            this.chkImp7.UseVisualStyleBackColor = true;
            // 
            // chkImp6
            // 
            this.chkImp6.AutoSize = true;
            this.chkImp6.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkImp6.Location = new System.Drawing.Point(98, 19);
            this.chkImp6.Name = "chkImp6";
            this.chkImp6.Size = new System.Drawing.Size(66, 23);
            this.chkImp6.TabIndex = 5;
            this.chkImp6.Text = "Imp 6";
            this.chkImp6.UseVisualStyleBackColor = true;
            // 
            // chkImp5
            // 
            this.chkImp5.AutoSize = true;
            this.chkImp5.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkImp5.Location = new System.Drawing.Point(12, 114);
            this.chkImp5.Name = "chkImp5";
            this.chkImp5.Size = new System.Drawing.Size(66, 23);
            this.chkImp5.TabIndex = 4;
            this.chkImp5.Text = "Imp 5";
            this.chkImp5.UseVisualStyleBackColor = true;
            // 
            // chkImp4
            // 
            this.chkImp4.AutoSize = true;
            this.chkImp4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkImp4.Location = new System.Drawing.Point(12, 91);
            this.chkImp4.Name = "chkImp4";
            this.chkImp4.Size = new System.Drawing.Size(66, 23);
            this.chkImp4.TabIndex = 3;
            this.chkImp4.Text = "Imp 4";
            this.chkImp4.UseVisualStyleBackColor = true;
            // 
            // Disconnect
            // 
            this.Disconnect.Location = new System.Drawing.Point(247, 32);
            this.Disconnect.Name = "Disconnect";
            this.Disconnect.Size = new System.Drawing.Size(113, 22);
            this.Disconnect.TabIndex = 32;
            this.Disconnect.Text = "Disconnect";
            this.Disconnect.UseVisualStyleBackColor = true;
            this.Disconnect.Click += new System.EventHandler(this.Disconnect_Click);
            // 
            // chkImp3
            // 
            this.chkImp3.AutoSize = true;
            this.chkImp3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkImp3.Location = new System.Drawing.Point(12, 67);
            this.chkImp3.Name = "chkImp3";
            this.chkImp3.Size = new System.Drawing.Size(66, 23);
            this.chkImp3.TabIndex = 2;
            this.chkImp3.Text = "Imp 3";
            this.chkImp3.UseVisualStyleBackColor = true;
            // 
            // chkImp2
            // 
            this.chkImp2.AutoSize = true;
            this.chkImp2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkImp2.Location = new System.Drawing.Point(12, 42);
            this.chkImp2.Name = "chkImp2";
            this.chkImp2.Size = new System.Drawing.Size(66, 23);
            this.chkImp2.TabIndex = 1;
            this.chkImp2.Text = "Imp 2";
            this.chkImp2.UseVisualStyleBackColor = true;
            // 
            // chkImp1
            // 
            this.chkImp1.AutoSize = true;
            this.chkImp1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkImp1.Location = new System.Drawing.Point(12, 19);
            this.chkImp1.Name = "chkImp1";
            this.chkImp1.Size = new System.Drawing.Size(66, 23);
            this.chkImp1.TabIndex = 0;
            this.chkImp1.Text = "Imp 1";
            this.chkImp1.UseVisualStyleBackColor = true;
            // 
            // plcInformation
            // 
            this.plcInformation.Controls.Add(this.txtPlcName);
            this.plcInformation.Controls.Add(this.label7);
            this.plcInformation.Controls.Add(this.txtModel);
            this.plcInformation.Controls.Add(this.txtFactoryBoot);
            this.plcInformation.Controls.Add(this.label6);
            this.plcInformation.Controls.Add(this.txtBinLib);
            this.plcInformation.Controls.Add(this.label5);
            this.plcInformation.Controls.Add(this.txtBoot);
            this.plcInformation.Controls.Add(this.label4);
            this.plcInformation.Controls.Add(this.txtOS);
            this.plcInformation.Controls.Add(this.label3);
            this.plcInformation.Controls.Add(this.txtHW);
            this.plcInformation.Controls.Add(this.label2);
            this.plcInformation.Controls.Add(this.label1);
            this.plcInformation.Location = new System.Drawing.Point(143, 12);
            this.plcInformation.Name = "plcInformation";
            this.plcInformation.Size = new System.Drawing.Size(246, 197);
            this.plcInformation.TabIndex = 30;
            this.plcInformation.TabStop = false;
            this.plcInformation.Text = "PLC Information";
            // 
            // txtPlcName
            // 
            this.txtPlcName.BackColor = System.Drawing.SystemColors.Window;
            this.txtPlcName.Location = new System.Drawing.Point(88, 170);
            this.txtPlcName.Name = "txtPlcName";
            this.txtPlcName.ReadOnly = true;
            this.txtPlcName.Size = new System.Drawing.Size(152, 20);
            this.txtPlcName.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "PLC Name";
            // 
            // txtModel
            // 
            this.txtModel.BackColor = System.Drawing.SystemColors.Window;
            this.txtModel.Location = new System.Drawing.Point(88, 15);
            this.txtModel.Name = "txtModel";
            this.txtModel.ReadOnly = true;
            this.txtModel.Size = new System.Drawing.Size(152, 20);
            this.txtModel.TabIndex = 3;
            // 
            // txtFactoryBoot
            // 
            this.txtFactoryBoot.BackColor = System.Drawing.SystemColors.Window;
            this.txtFactoryBoot.Location = new System.Drawing.Point(88, 144);
            this.txtFactoryBoot.Name = "txtFactoryBoot";
            this.txtFactoryBoot.ReadOnly = true;
            this.txtFactoryBoot.Size = new System.Drawing.Size(152, 20);
            this.txtFactoryBoot.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Factory Boot";
            // 
            // txtBinLib
            // 
            this.txtBinLib.BackColor = System.Drawing.SystemColors.Window;
            this.txtBinLib.Location = new System.Drawing.Point(88, 118);
            this.txtBinLib.Name = "txtBinLib";
            this.txtBinLib.ReadOnly = true;
            this.txtBinLib.Size = new System.Drawing.Size(152, 20);
            this.txtBinLib.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "BinLib Version";
            // 
            // txtBoot
            // 
            this.txtBoot.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoot.Location = new System.Drawing.Point(88, 92);
            this.txtBoot.Name = "txtBoot";
            this.txtBoot.ReadOnly = true;
            this.txtBoot.Size = new System.Drawing.Size(152, 20);
            this.txtBoot.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Boot Version";
            // 
            // txtOS
            // 
            this.txtOS.BackColor = System.Drawing.SystemColors.Window;
            this.txtOS.Location = new System.Drawing.Point(88, 66);
            this.txtOS.Name = "txtOS";
            this.txtOS.ReadOnly = true;
            this.txtOS.Size = new System.Drawing.Size(152, 20);
            this.txtOS.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "OS Version";
            // 
            // txtHW
            // 
            this.txtHW.BackColor = System.Drawing.SystemColors.Window;
            this.txtHW.Location = new System.Drawing.Point(88, 40);
            this.txtHW.Name = "txtHW";
            this.txtHW.ReadOnly = true;
            this.txtHW.Size = new System.Drawing.Size(152, 20);
            this.txtHW.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "HW Revision";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "PLC Model";
            // 
            // Connect
            // 
            this.Connect.Location = new System.Drawing.Point(12, 12);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(113, 22);
            this.Connect.TabIndex = 31;
            this.Connect.Text = "Connect to PLC";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // LongPeriodRead
            // 
            this.LongPeriodRead.Location = new System.Drawing.Point(13, 180);
            this.LongPeriodRead.Name = "LongPeriodRead";
            this.LongPeriodRead.Size = new System.Drawing.Size(113, 22);
            this.LongPeriodRead.TabIndex = 33;
            this.LongPeriodRead.Text = "Long Period Read";
            this.LongPeriodRead.UseVisualStyleBackColor = true;
            this.LongPeriodRead.Click += new System.EventHandler(this.LongPeriodRead_Click);
            // 
            // Run
            // 
            this.Run.Location = new System.Drawing.Point(12, 96);
            this.Run.Name = "Run";
            this.Run.Size = new System.Drawing.Size(113, 22);
            this.Run.TabIndex = 36;
            this.Run.Text = "Run PLC";
            this.Run.UseVisualStyleBackColor = true;
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(12, 75);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(113, 22);
            this.Stop.TabIndex = 35;
            this.Stop.Text = "Stop PLC";
            this.Stop.UseVisualStyleBackColor = true;
            // 
            // Init
            // 
            this.Init.Location = new System.Drawing.Point(12, 54);
            this.Init.Name = "Init";
            this.Init.Size = new System.Drawing.Size(113, 22);
            this.Init.TabIndex = 34;
            this.Init.Text = "Init PLC";
            this.Init.UseVisualStyleBackColor = true;
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(12, 33);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(113, 22);
            this.Reset.TabIndex = 37;
            this.Reset.Text = "Reset PLC";
            this.Reset.UseVisualStyleBackColor = true;
            // 
            // ReadAsynch
            // 
            this.ReadAsynch.Location = new System.Drawing.Point(12, 138);
            this.ReadAsynch.Name = "ReadAsynch";
            this.ReadAsynch.Size = new System.Drawing.Size(113, 22);
            this.ReadAsynch.TabIndex = 43;
            this.ReadAsynch.Text = "Async Val Read";
            this.ReadAsynch.UseVisualStyleBackColor = true;
            // 
            // Write
            // 
            this.Write.Location = new System.Drawing.Point(12, 159);
            this.Write.Name = "Write";
            this.Write.Size = new System.Drawing.Size(113, 22);
            this.Write.TabIndex = 42;
            this.Write.Text = "Write Values";
            this.Write.UseVisualStyleBackColor = true;
            // 
            // Read
            // 
            this.Read.Location = new System.Drawing.Point(12, 117);
            this.Read.Name = "Read";
            this.Read.Size = new System.Drawing.Size(113, 22);
            this.Read.TabIndex = 41;
            this.Read.Text = "Read Values";
            this.Read.UseVisualStyleBackColor = true;
            // 
            // frMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 402);
            this.Controls.Add(this.ReadAsynch);
            this.Controls.Add(this.Write);
            this.Controls.Add(this.Read);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Run);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Init);
            this.Controls.Add(this.LongPeriodRead);
            this.Controls.Add(this.Connect);
            this.Controls.Add(this.plcInformation);
            this.Controls.Add(this.groupBox2);
            this.Name = "frMain";
            this.Text = "Muestreo PCL Impresoras produccion";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.plcInformation.ResumeLayout(false);
            this.plcInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnMonitor;
        private System.Windows.Forms.CheckBox chkImp10;
        private System.Windows.Forms.CheckBox chkImp9;
        private System.Windows.Forms.CheckBox chkImp8;
        private System.Windows.Forms.CheckBox chkImp7;
        private System.Windows.Forms.CheckBox chkImp6;
        private System.Windows.Forms.CheckBox chkImp5;
        private System.Windows.Forms.CheckBox chkImp4;
        private System.Windows.Forms.CheckBox chkImp3;
        private System.Windows.Forms.CheckBox chkImp2;
        private System.Windows.Forms.CheckBox chkImp1;
        private System.Windows.Forms.GroupBox plcInformation;
        private System.Windows.Forms.TextBox txtPlcName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtFactoryBoot;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBinLib;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoot;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHW;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.Button Disconnect;
        private System.Windows.Forms.Button LongPeriodRead;
        private System.Windows.Forms.Button Run;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Button Init;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button ReadAsynch;
        private System.Windows.Forms.Button Write;
        private System.Windows.Forms.Button Read;
        private System.Windows.Forms.Button Abort;
    }
}

