using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Text;

namespace IDINCU.RawPrinterServer
{
    public class PrinterConfig
    {
        public enum PrinterProtocol { EPL = 1 };

        // Generic configurations
        public string Id { get; set; }
        public PrinterProtocol Protocol { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string Description { get; set; }

        // Serial port configuration
        public string Port { get; set; }
        public int BaudRate { get; set; }
        public Parity Parity { get; set; }
        public int DataBits { get; set; }
        public StopBits StopBits { get; set; }
        public Handshake Handshake { get; set; }

        public PrinterConfig()
        {
            // TODO: Complete member initialization
        }

        public void SaveConfig()
        {
            ConfigurationManager.SavePrinterConfig(this);
        }

    }
}
