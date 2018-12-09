using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unitronics.ComDriver;
using Unitronics.ComDriver.Messages.DataRequest;
using System.Runtime.Remoting.Messaging;
using System.Reflection;
using Dataccess;

namespace MuestreoPLC
{
    public partial class frMain : Form
    {
        Unitronics.ComDriver.PLC plc;
        Properties.Settings _configuracion = new Properties.Settings();
        public OfimaticaDBContext _dbConexion;
        public frMain()
        {
            InitializeComponent();
            setButtonsEnableState(false);
        }
        private void setButtonsEnableState(bool value)
        {
            Connect.Enabled = !value;
            Reset.Enabled = value;
            Init.Enabled = value;
            Stop.Enabled = value;
            Run.Enabled = value;
            Disconnect.Enabled = value;
            Read.Enabled = value;
            ReadAsynch.Enabled = value;
            Write.Enabled = value;
            LongPeriodRead.Enabled = value;
            chkImp1.Checked = false;
            chkImp2.Checked = false;
            chkImp3.Checked = false;
            chkImp4.Checked = false;
            chkImp5.Checked = false;
            chkImp6.Checked = false;
            chkImp7.Checked = false;
            chkImp8.Checked = false;
            chkImp9.Checked = false;
            chkImp10.Checked = false;
        }

        private void Connect_Click(object sender, EventArgs e)
        {
            Ethernet ethernet = new Ethernet("192.168.0.49", 20256, EthProtocol.TCP, 3, 3000);
            try
            {
                plc = PLCFactory.GetPLC(ethernet, 0);
                plc.EventAbortCompleted += new Unitronics.ComDriver.PLC.AbortCompletedDelegate(plc_EventAbortCompleted);
                setButtonsEnableState(true);
                PlcVersion version = plc.Version;
                txtModel.Text = version.OPLCModel;
                txtHW.Text = version.HWVersion;
                txtOS.Text = version.OSVersion;
                txtBoot.Text = version.Boot;
                txtBinLib.Text = version.BinLib;
                txtFactoryBoot.Text = version.FactoryBoot;
                try
                {
                    txtPlcName.Text = plc.PlcName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error al conectar con PLC", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.ExitThread();
                }

            }
            catch (Exception ex)
            {
                setButtonsEnableState(false);
                ethernet.Disconnect();
                MessageBox.Show(ex.Message, "Error al conectar con PLC", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.ExitThread();

            }
        }
        private void plc_EventAbortCompleted()
        {
            MethodInvoker mi = delegate ()
            {
                Abort.Enabled = false;
                System.Windows.Forms.MessageBox.Show("Requests abort completed");
            };
            UpdateUI(mi);
        }
        private void UpdateUI(MethodInvoker del)
        {
            if (this.InvokeRequired)
                this.Invoke(del);
            else
                del();
        }

        private void Disconnect_Click(object sender, EventArgs e)
        {
            plc.Disconnect();
            plc.EventAbortCompleted -= new Unitronics.ComDriver.PLC.AbortCompletedDelegate(plc_EventAbortCompleted);
            setButtonsEnableState(false);
            txtModel.Text = "";
            txtHW.Text = "";
            txtOS.Text = "";
            txtBoot.Text = "";
            txtBinLib.Text = "";
            txtFactoryBoot.Text = "";
            txtPlcName.Text = "";

        }

        private void LongPeriodRead_Click(object sender, EventArgs e)
        {
            Abort.Enabled = true;
            for (int i = 0; i < 10; i++)
            {
                ReadWriteRequest[] rw = new ReadWriteRequest[8];

                rw[0] = new ReadOperands()
                {
                    OperandType = OperandTypes.MB,
                    NumberOfOperands = 4096,
                    StartAddress = 0
                };

                rw[1] = new ReadOperands()
                {
                    OperandType = OperandTypes.MI,
                    NumberOfOperands = 2048,
                    StartAddress = 0
                };

                rw[2] = new ReadOperands()
                {
                    OperandType = OperandTypes.ML,
                    NumberOfOperands = 256,
                    StartAddress = 0
                };

                rw[3] = new ReadOperands()
                {
                    OperandType = OperandTypes.DW,
                    NumberOfOperands = 64,
                    StartAddress = 0
                };


                rw[4] = new ReadOperands()
                {
                    OperandType = OperandTypes.SB,
                    NumberOfOperands = 512,
                    StartAddress = 0
                };

                rw[5] = new ReadOperands()
                {
                    OperandType = OperandTypes.SI,
                    NumberOfOperands = 512,
                    StartAddress = 0
                };

                rw[6] = new ReadOperands()
                {
                    OperandType = OperandTypes.SL,
                    NumberOfOperands = 56,
                    StartAddress = 0
                };

                rw[7] = new ReadOperands()
                {
                    OperandType = OperandTypes.SDW,
                    NumberOfOperands = 64,
                    StartAddress = 0
                };

                try
                {
                    plc.ReadWrite(ref rw, TestAbortAsyncReply);
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("Could not communicate with the PLC:" + ex.Message);
                }
            }
        }
        private void TestAbortAsyncReply(IAsyncResult ar)
        {
            AsyncResult async;
            async = (AsyncResult)ar;
            ReadWriteOperandsDelegate del = (ReadWriteOperandsDelegate)async.AsyncDelegate;
            ReadWriteRequest[] rw = new ReadWriteRequest[0];
            try
            {
                del.EndInvoke(ref rw, ar);
            }
            catch (ComDriveExceptions ex)
            {
                if (ex.ErrorCode == ComDriveExceptions.ComDriveException.AbortedByUser)
                {
                    System.Diagnostics.Debug.Print("Aborted by user");
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Unexpected error" + ex.Message);
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Unexpected error: " + ex.Message);
            }
        }

        private void Abort_Click(object sender, EventArgs e)
        {
            plc.Abort();
        }

        private bool ConvertValue(object estadoImpresora)
        {

                return false;

        }
        private void btnMonitor_Click(object sender, EventArgs e)
        {
            bool imp1State, imp2State, imp3State, imp4State, imp5State, imp6State, imp7State, imp8State, imp9State, imp10State;
            tblProdMuestreoUsoImpresoras muestreo = new tblProdMuestreoUsoImpresoras();

            ReadWriteRequest[] rw = new ReadWriteRequest[1];
            rw[0] = new ReadOperands()
            {
                OperandType = OperandTypes.MB,
                NumberOfOperands = 16,
                StartAddress = 0
            };

            try
            {
                plc.ReadWrite(ref rw);
                object[] values = (object[])(rw[0].ResponseValues);

                for (int i = 0; i < values.Length; i++)
                 {
                    if (values[i] != null)
                    {
                        switch (i)
                        {
                            case 1:
                                imp1State = Convert.ToBoolean(values[i]);
                                chkImp1.Checked = imp1State;
                                muestreo.Impresora1 = imp1State;
                                break;
                            case 2:
                                imp2State = Convert.ToBoolean(values[i]);
                                chkImp2.Checked = imp2State;
                                muestreo.Impresora2 = imp2State;
                                break;
                            case 3:
                                imp3State = Convert.ToBoolean(values[i]);
                                chkImp3.Checked = imp3State;
                                muestreo.Impresora3 = imp3State;
                                break;
                            case 4:
                                imp4State = Convert.ToBoolean(values[i]);
                                chkImp4.Checked = imp4State;
                                muestreo.Impresora4 = imp4State;
                                break;
                            case 5:
                                imp5State = Convert.ToBoolean(values[i]);
                                chkImp5.Checked = imp5State;
                                muestreo.Impresora5 = imp5State;
                                break;
                            case 6:
                                imp10State = Convert.ToBoolean(values[i]);
                                chkImp10.Checked = imp10State;
                                muestreo.Impresora10= imp10State;
                                break;
                            case 7:
                                imp7State = Convert.ToBoolean(values[i]);
                                chkImp7.Checked = imp7State;
                                muestreo.Impresora7 = imp7State;
                                break;
                            case 8:
                                imp8State = Convert.ToBoolean(values[i]);
                                chkImp8.Checked = imp8State;
                                muestreo.Impresora8 = imp8State;
                                break;
                            case 9:
                                imp9State = Convert.ToBoolean(values[i]);
                                chkImp9.Checked = imp9State;
                                muestreo.Impresora9 = imp9State;
                                break;
                            case 10:
                                imp6State = Convert.ToBoolean(values[i]);
                                chkImp6.Checked = imp6State;
                                muestreo.Impresora6 = imp6State;
                                break;
                        }
                    }

                }
                muestreo.FechaHora = DateTime.Now;
                _dbConexion.tblProdMuestreoUsoImpresoras.InsertOnSubmit(muestreo);
                _dbConexion.SubmitChanges();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("No se puede conectar con el PLC: " + ex.Message);
                Application.ExitThread();
            }
        }
        #region Modificar cadena de conexion
        private String ModificarDBConexion(String Servidor, String Database, string DBUser, string DBPassword)
        {
            //Data Source=hestia;Initial Catalog=PLASMARSA;Persist Security Info=True;User ID=ofimatica;Password=ofimatica
            String connString = string.Format("Data Source={0};Initial Catalog={1};Persist Security Info=True;User ID={2};Password={3}", Servidor, Database, DBUser, DBPassword);
            return connString;
        }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] Argumentos = Environment.GetCommandLineArgs();
            if (Argumentos.Length > 1)
            {
                _dbConexion = new OfimaticaDBContext();
                _dbConexion = new OfimaticaDBContext(ModificarDBConexion(_configuracion.Servidor, Argumentos[2], _configuracion.dbUser, _configuracion.dbPassword));
                Connect_Click(null, null);
                btnMonitor_Click(null, null);
                Disconnect_Click(null, null);
                Application.Exit();
            }
            else
            {
                _dbConexion = new OfimaticaDBContext(ModificarDBConexion(_configuracion.Servidor, _configuracion.DataBase, _configuracion.dbUser, _configuracion.dbPassword));

            }
                //_dbConexion.ExecuteCommand(string.Format("DELETE FROM dbo.tblProdMuestreoUsoImpresoras WHERE GETDATE()- FechaHora >{0}", _configuracion.MantenerUltDias));
        }
    }
}
