using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Text;
using System.Windows.Forms;

namespace RawPrinterServerConfig
{
    public partial class ConfigForm : Form
    {

        public ConfigForm()
        {
            InitializeComponent();
        }

        private void ConfigForm_Load(object sender, EventArgs e)
        {
            ClearForm(false);

            cmbPort.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            foreach(string port in ports) {
                cmbPort.Items.Add(port);
            }
        }

        private void ClearForm(bool enabled)
        {
            txtId.Text = "";
            txtId.Enabled = enabled;
            cmbProtocol.SelectedItem = null;
            cmbProtocol.Enabled = enabled;
            txtManufacturer.Text = "";
            txtManufacturer.Enabled = enabled;
            txtModel.Text = "";
            txtModel.Enabled = enabled;
            txtDescription.Text = "";
            txtDescription.Enabled = enabled;
            cmbPort.SelectedItem = null;
            cmbPort.Enabled = enabled;
            cmbBaudRate.SelectedItem = null;
            cmbBaudRate.Enabled = enabled;
            cmbParity.SelectedItem = null;
            cmbParity.Enabled = enabled;
            cmbDataBits.SelectedItem = null;
            cmbDataBits.Enabled = enabled;
            cmbStopBits.SelectedItem = null;
            cmbStopBits.Enabled = enabled;
            cmbHandshake.SelectedItem = null;
            cmbHandshake.Enabled = enabled;
        }

        private void btnAddPrinter_Click(object sender, EventArgs e)
        {
            ClearForm(true);
        }

    }
}
