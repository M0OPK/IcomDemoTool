using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using CIVSharp;

namespace IcomTool
{
    public partial class IcomDemo : Form
    {
        CIVSharp.CIV myCIV;
        public IcomDemo()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmdDisconnect.Enabled = false;
            cmdSend.Enabled = false;
            cmdTune.Enabled = false;
            myCIV = new CIVSharp.CIV();
            string[] radios = myCIV.GetRadioNames();
            string[] ports = myCIV.GetSerialPorts();
            foreach (string radio in radios)
                lbRadios.Items.Add(radio);
            foreach (string port in ports)
                lbPorts.Items.Add(port);
        }

        private void cmdConnect_Click(object sender, EventArgs e)
        {
            myCIV.setRadioID(CIVSharp.CIV.Radio.IC_7100);
            if (!myCIV.OpenSerialPort(lbPorts.SelectedItem.ToString(), 19200))
            {
                string exceptionText = myCIV.GetSerialException().Message;
                MessageBox.Show("Unable to open port " + lbPorts.SelectedItem.ToString() + ": " + exceptionText, "Error opening port: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                myCIV.CommandWaiting += new CIVSharp.CIVCommandReadyEvent(CIVDataHandler);
                cmdConnect.Enabled = false;
                cmdFind.Enabled = false;
                cmdDisconnect.Enabled = true;
                cmdSend.Enabled = true;
                cmdTune.Enabled = true;
            }
        }

        private void CIVDataHandler(object sender, EventArgs e)
        {
            CIVSharp.CIV thisCIV = (CIVSharp.CIV)sender;

            while (thisCIV.CommandQueued())
            {
                byte[] thisCommand = thisCIV.ReadCommand();
                string hex = BitConverter.ToString(thisCommand);
                this.Invoke((MethodInvoker)delegate
                {
                    mlText.AppendText(hex + "\r\n");
                });
            }
        }

        private void cmdSend_Click(object sender, EventArgs e)
        {

            //byte[] buffer = { 0x88, 0xE0, 0x19, 0x00 };
            //byte[] buffer = { (byte)CIVSharp.CIV.CommandBytes.COMMAND_TRANCEIVER_ID_READ, 0x00 };
            //myCIV.TransmitCommand(buffer);
            //myCIV.AutoDetectrRadio();
        }

        private void cmdFind_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            CIV.RadioInfo radioInfo = myCIV.AutoDetectRadio(true);
            Cursor.Current = Cursors.Default;
            if (radioInfo.RadioID != CIV.Radio.NULL_RADIO)
            {
                myCIV.CommandWaiting += new CIVSharp.CIVCommandReadyEvent(CIVDataHandler);
                cmdConnect.Enabled = false;
                cmdFind.Enabled = false;
                cmdDisconnect.Enabled = true;
                cmdSend.Enabled = true;
                cmdTune.Enabled = true;
                MessageBox.Show("Found radio: " + radioInfo.RadioName + " on port " + radioInfo.CommPort + " with baud rate " + radioInfo.baudRate.ToString() + " with address " + radioInfo.RadioAddress.ToString("X2"), "Radio Autodetect", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cmdDisconnect_Click(object sender, EventArgs e)
        {
            myCIV.CloseSerialPort();
            cmdConnect.Enabled = true;
            cmdFind.Enabled = true;
            cmdDisconnect.Enabled = false;
            cmdSend.Enabled = false;
            cmdTune.Enabled = false;
        }

        private void cmdTune_Click(object sender, EventArgs e)
        {
            double frequency;
            if (double.TryParse(txtFrequency.Text, out frequency))
            {
                myCIV.TuneFrequency(frequency);
            }
        }
    }
}
