namespace RawPrinterServerConfig
{
    partial class ConfigForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigForm));
            this.printerListBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtManufacturer = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbProtocol = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbHandshake = new System.Windows.Forms.ComboBox();
            this.cmbStopBits = new System.Windows.Forms.ComboBox();
            this.cmbDataBits = new System.Windows.Forms.ComboBox();
            this.cmbParity = new System.Windows.Forms.ComboBox();
            this.cmbBaudRate = new System.Windows.Forms.ComboBox();
            this.cmbPort = new System.Windows.Forms.ComboBox();
            this.btnDeletePrinter = new System.Windows.Forms.Button();
            this.btnAddPrinter = new System.Windows.Forms.Button();
            this.btnServiceStart = new System.Windows.Forms.Button();
            this.btnServiceStop = new System.Windows.Forms.Button();
            this.btnRestartService = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // printerListBox
            // 
            this.printerListBox.FormattingEnabled = true;
            resources.ApplyResources(this.printerListBox, "printerListBox");
            this.printerListBox.Name = "printerListBox";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtModel);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtManufacturer);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cmbProtocol);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbHandshake);
            this.groupBox1.Controls.Add(this.cmbStopBits);
            this.groupBox1.Controls.Add(this.cmbDataBits);
            this.groupBox1.Controls.Add(this.cmbParity);
            this.groupBox1.Controls.Add(this.cmbBaudRate);
            this.groupBox1.Controls.Add(this.cmbPort);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // txtDescription
            // 
            resources.ApplyResources(this.txtDescription, "txtDescription");
            this.txtDescription.Name = "txtDescription";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // txtModel
            // 
            resources.ApplyResources(this.txtModel, "txtModel");
            this.txtModel.Name = "txtModel";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // txtManufacturer
            // 
            resources.ApplyResources(this.txtManufacturer, "txtManufacturer");
            this.txtManufacturer.Name = "txtManufacturer";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            resources.ApplyResources(this.txtId, "txtId");
            this.txtId.Name = "txtId";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // cmbProtocol
            // 
            this.cmbProtocol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProtocol.FormattingEnabled = true;
            this.cmbProtocol.Items.AddRange(new object[] {
            resources.GetString("cmbProtocol.Items")});
            resources.ApplyResources(this.cmbProtocol, "cmbProtocol");
            this.cmbProtocol.Name = "cmbProtocol";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // cmbHandshake
            // 
            this.cmbHandshake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHandshake.FormattingEnabled = true;
            this.cmbHandshake.Items.AddRange(new object[] {
            resources.GetString("cmbHandshake.Items")});
            resources.ApplyResources(this.cmbHandshake, "cmbHandshake");
            this.cmbHandshake.Name = "cmbHandshake";
            // 
            // cmbStopBits
            // 
            this.cmbStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStopBits.FormattingEnabled = true;
            this.cmbStopBits.Items.AddRange(new object[] {
            resources.GetString("cmbStopBits.Items")});
            resources.ApplyResources(this.cmbStopBits, "cmbStopBits");
            this.cmbStopBits.Name = "cmbStopBits";
            // 
            // cmbDataBits
            // 
            this.cmbDataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDataBits.FormattingEnabled = true;
            this.cmbDataBits.Items.AddRange(new object[] {
            resources.GetString("cmbDataBits.Items"),
            resources.GetString("cmbDataBits.Items1"),
            resources.GetString("cmbDataBits.Items2"),
            resources.GetString("cmbDataBits.Items3"),
            resources.GetString("cmbDataBits.Items4")});
            resources.ApplyResources(this.cmbDataBits, "cmbDataBits");
            this.cmbDataBits.Name = "cmbDataBits";
            // 
            // cmbParity
            // 
            this.cmbParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbParity.FormattingEnabled = true;
            this.cmbParity.Items.AddRange(new object[] {
            resources.GetString("cmbParity.Items"),
            resources.GetString("cmbParity.Items1"),
            resources.GetString("cmbParity.Items2"),
            resources.GetString("cmbParity.Items3"),
            resources.GetString("cmbParity.Items4")});
            resources.ApplyResources(this.cmbParity, "cmbParity");
            this.cmbParity.Name = "cmbParity";
            // 
            // cmbBaudRate
            // 
            this.cmbBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBaudRate.FormattingEnabled = true;
            this.cmbBaudRate.Items.AddRange(new object[] {
            resources.GetString("cmbBaudRate.Items"),
            resources.GetString("cmbBaudRate.Items1"),
            resources.GetString("cmbBaudRate.Items2"),
            resources.GetString("cmbBaudRate.Items3"),
            resources.GetString("cmbBaudRate.Items4"),
            resources.GetString("cmbBaudRate.Items5"),
            resources.GetString("cmbBaudRate.Items6"),
            resources.GetString("cmbBaudRate.Items7")});
            resources.ApplyResources(this.cmbBaudRate, "cmbBaudRate");
            this.cmbBaudRate.Name = "cmbBaudRate";
            // 
            // cmbPort
            // 
            this.cmbPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPort.FormattingEnabled = true;
            resources.ApplyResources(this.cmbPort, "cmbPort");
            this.cmbPort.Name = "cmbPort";
            // 
            // btnDeletePrinter
            // 
            resources.ApplyResources(this.btnDeletePrinter, "btnDeletePrinter");
            this.btnDeletePrinter.Name = "btnDeletePrinter";
            this.btnDeletePrinter.UseVisualStyleBackColor = true;
            // 
            // btnAddPrinter
            // 
            resources.ApplyResources(this.btnAddPrinter, "btnAddPrinter");
            this.btnAddPrinter.Name = "btnAddPrinter";
            this.btnAddPrinter.UseVisualStyleBackColor = true;
            this.btnAddPrinter.Click += new System.EventHandler(this.btnAddPrinter_Click);
            // 
            // btnServiceStart
            // 
            resources.ApplyResources(this.btnServiceStart, "btnServiceStart");
            this.btnServiceStart.Name = "btnServiceStart";
            this.btnServiceStart.UseVisualStyleBackColor = true;
            // 
            // btnServiceStop
            // 
            resources.ApplyResources(this.btnServiceStop, "btnServiceStop");
            this.btnServiceStop.Name = "btnServiceStop";
            this.btnServiceStop.UseVisualStyleBackColor = true;
            // 
            // btnRestartService
            // 
            resources.ApplyResources(this.btnRestartService, "btnRestartService");
            this.btnRestartService.Name = "btnRestartService";
            this.btnRestartService.UseVisualStyleBackColor = true;
            // 
            // ConfigForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRestartService);
            this.Controls.Add(this.btnServiceStop);
            this.Controls.Add(this.btnServiceStart);
            this.Controls.Add(this.btnAddPrinter);
            this.Controls.Add(this.btnDeletePrinter);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.printerListBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfigForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Load += new System.EventHandler(this.ConfigForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox printerListBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbHandshake;
        private System.Windows.Forms.ComboBox cmbStopBits;
        private System.Windows.Forms.ComboBox cmbDataBits;
        private System.Windows.Forms.ComboBox cmbParity;
        private System.Windows.Forms.ComboBox cmbBaudRate;
        private System.Windows.Forms.ComboBox cmbPort;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtManufacturer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbProtocol;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeletePrinter;
        private System.Windows.Forms.Button btnAddPrinter;
        private System.Windows.Forms.Button btnServiceStart;
        private System.Windows.Forms.Button btnServiceStop;
        private System.Windows.Forms.Button btnRestartService;
    }
}

