using ImageMagick;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.ServiceProcess;
using System.Text;

namespace IDINCU.RawPrinterServer
{
    public partial class RawPrinterServerService : ServiceBase
    {

        private const string SERVICE_NAME = "IDRawPrinterServer";

        public RawPrinterServerService()
        {
            InitializeComponent();

            this.ServiceName = SERVICE_NAME;
            //this.EventLog = new System.Diagnostics.EventLog();
            this.EventLog.Source = this.ServiceName;
            this.EventLog.Log = this.ServiceName;

            ((ISupportInitialize)(this.EventLog)).BeginInit();
            if (!EventLog.SourceExists(this.EventLog.Source))
            {
                EventLog.CreateEventSource(this.EventLog.Source, this.EventLog.Log);
            }
            ((ISupportInitialize)(this.EventLog)).EndInit();
        }

        public void OnDebug()
        {
            OnStart(null);
        }

        protected override void OnStart(string[] args)
        {
            EventLog.WriteEntry("Starting service", EventLogEntryType.Information);
            printSomething();
        }

        protected override void OnStop()
        {
            EventLog.WriteEntry("Stopping service", EventLogEntryType.Information);
        }

        protected void printSomething()
        {
            SerialPort serialPort = new SerialPort();
            serialPort.PortName = "COM4";
            serialPort.BaudRate = 115200;
            serialPort.Parity = Parity.None;
            serialPort.DataBits = 8;
            serialPort.StopBits = StopBits.One;
            serialPort.Handshake = Handshake.None;

            serialPort.ReadTimeout = 500;
            serialPort.WriteTimeout = 500;

            serialPort.Open();
            Bitmap bitmap = (Bitmap)Image.FromFile(@"C:\Users\kswchoo\Desktop\a.png", true);            
            byte[] buf = makeCommand(359, 163, 24, bitmap);
            serialPort.Write(buf, 0, buf.Length);
            serialPort.Close();
        }

        protected byte[] makeCommand(int width, int height, int gap, Bitmap bitmap)
        {
            MemoryStream stream = new MemoryStream();
            StreamWriter writer = new StreamWriter(stream);
            writer.AutoFlush = true;

            writer.WriteLine(""); // Newline to gurantee that any previous broked command is submitted.
            writer.WriteLine("N"); // Clear the image buffer
            writer.WriteLine(String.Format("q{0}", width)); // Set the label width
            writer.WriteLine(String.Format("Q{0},{1}", height, gap)); // Set the label height to 203 dots and 26 dot gap

            int xSizeInBytes = (width + 8) / 8;
            int xSize = xSizeInBytes * 8;
            int ySize = height;

            byte[] data = new byte[xSizeInBytes * ySize];
            for (int y = 0; y < ySize; y++)
            {
                for (int xByte = 0; xByte < xSizeInBytes; xByte ++)
                {
                    for (int xOffset = 0; xOffset < 8; xOffset ++)
                    {
                        int x = xByte * 8 + xOffset;
                        byte bit = 1;
                        if (x < bitmap.Width && y < bitmap.Height) {
                            bit = bitmap.GetPixel(x, y).GetBrightness() > 0.5f ? (byte)1 : (byte)0;
                        }
                        data[(xSizeInBytes * y) + xByte] |= (byte)(bit << (7 - xOffset));
                    }
                }
            }

            writer.Write(String.Format("GW0,0,{0},{1},", xSizeInBytes, ySize)); // Graphics write from 0,0,x,y
            stream.Write(data, 0, data.Length);

            writer.WriteLine("");
            writer.WriteLine("P1,1"); // Print!
            writer.Flush();

            return stream.ToArray();
        }
    }
}
