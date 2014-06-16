using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Text;

namespace IDINCU.RawPrinterServer
{
    public static class ConfigurationManager
    {
        public const string REGISTRY_KEY = "IDRawPrinterServer";
        public const string PRINTERS_KEY = "Printers";

        public static void SavePrinterConfig(PrinterConfig config)
        {
            RegistryKey rootKey = Registry.CurrentConfig.OpenSubKey(ConfigurationManager.REGISTRY_KEY);
            RegistryKey printersKey = rootKey.OpenSubKey(ConfigurationManager.PRINTERS_KEY, true);

            // Remove if exists
            printersKey.DeleteSubKeyTree(config.Id);

            // Write configuration
            RegistryKey printer = printersKey.CreateSubKey(config.Id);
            printer.SetValue("Id", config.Id, RegistryValueKind.String);
            printer.SetValue("Protocol", config.Protocol.GetTypeCode(), RegistryValueKind.DWord);
            printer.SetValue("Manufacturer", config.Manufacturer, RegistryValueKind.String);
            printer.SetValue("Model", config.Model, RegistryValueKind.String);
            printer.SetValue("Description", config.Description, RegistryValueKind.String);
            printer.SetValue("Port", config.Port, RegistryValueKind.String);
            printer.SetValue("BaudRate", config.BaudRate, RegistryValueKind.DWord);
            printer.SetValue("Parity", config.Parity.GetTypeCode(), RegistryValueKind.DWord);
            printer.SetValue("DataBits", config.DataBits, RegistryValueKind.DWord);
            printer.SetValue("StopBits", config.StopBits.GetTypeCode(), RegistryValueKind.DWord);
            printer.SetValue("Handshake", config.Handshake.GetTypeCode(), RegistryValueKind.DWord);
        }

        public static PrinterConfig LoadPrinterConfig(String id)
        {
            RegistryKey rootKey = Registry.CurrentConfig.OpenSubKey(ConfigurationManager.REGISTRY_KEY);
            if (rootKey == null)
            {
                return null;
            }
            
            RegistryKey printersKey = rootKey.OpenSubKey(ConfigurationManager.PRINTERS_KEY, true);
            if (printersKey == null)
            {
                return null;
            }

            RegistryKey printer = printersKey.OpenSubKey(id);
            if (printer == null)
            {
                return null;
            }

            PrinterConfig config = new PrinterConfig();
            config.Id = (String) printer.GetValue("Id");

            return config;
        }
    }
}
