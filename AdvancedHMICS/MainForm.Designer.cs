namespace AdvancedHMICS
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Label1 = new System.Windows.Forms.Label();
            this.modbusRTUCom1 = new AdvancedHMIDrivers.ModbusRTUCom(this.components);
            this.digitalPanelMeter2 = new AdvancedHMIControls.DigitalPanelMeter();
            this.digitalPanelMeter1 = new AdvancedHMIControls.DigitalPanelMeter();
            this.modbusRTUCom2 = new AdvancedHMIDrivers.ModbusRTUCom(this.components);
            this.basicButton2 = new AdvancedHMIControls.BasicButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.keyboardInput1 = new AdvancedHMIControls.KeyboardInput();
            this.basicLabel1 = new AdvancedHMIControls.BasicLabel();
            this.analogValueDisplay1 = new AdvancedHMIControls.AnalogValueDisplay();
            this.basicButton1 = new AdvancedHMIControls.BasicButton();
            ((System.ComponentModel.ISupportInitialize)(this.modbusRTUCom1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modbusRTUCom2)).BeginInit();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Label1.Location = new System.Drawing.Point(12, 584);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(194, 32);
            this.Label1.TabIndex = 43;
            this.Label1.Text = "For Development Source Code Visit\r\nhttp://www.advancedhmi.com";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // modbusRTUCom1
            // 
            this.modbusRTUCom1.BaudRate = 9600;
            this.modbusRTUCom1.DataBits = 8;
            this.modbusRTUCom1.DisableSubscriptions = false;
            this.modbusRTUCom1.EnableLogging = false;
            this.modbusRTUCom1.IniFileName = "";
            this.modbusRTUCom1.IniFileSection = null;
            this.modbusRTUCom1.MaxReadGroupSize = 32;
            this.modbusRTUCom1.Parity = System.IO.Ports.Parity.None;
            this.modbusRTUCom1.PollRateOverride = 100;
            this.modbusRTUCom1.PortName = "COM4";
            this.modbusRTUCom1.StationAddress = ((byte)(1));
            this.modbusRTUCom1.StopBits = System.IO.Ports.StopBits.One;
            this.modbusRTUCom1.SwapBytes = true;
            this.modbusRTUCom1.SwapWords = false;
            this.modbusRTUCom1.TimeOut = 1000;
            // 
            // digitalPanelMeter2
            // 
            this.digitalPanelMeter2.BackColor = System.Drawing.Color.Transparent;
            this.digitalPanelMeter2.ComComponent = this.modbusRTUCom1;
            this.digitalPanelMeter2.DecimalPosition = 0;
            this.digitalPanelMeter2.ForeColor = System.Drawing.Color.LightGray;
            this.digitalPanelMeter2.KeypadFontColor = System.Drawing.Color.WhiteSmoke;
            this.digitalPanelMeter2.KeypadMaxValue = 0D;
            this.digitalPanelMeter2.KeypadMinValue = 0D;
            this.digitalPanelMeter2.KeypadScaleFactor = 1D;
            this.digitalPanelMeter2.KeypadText = null;
            this.digitalPanelMeter2.KeypadWidth = 300;
            this.digitalPanelMeter2.Location = new System.Drawing.Point(375, 134);
            this.digitalPanelMeter2.Name = "digitalPanelMeter2";
            this.digitalPanelMeter2.NumberOfDigits = 6;
            this.digitalPanelMeter2.PLCAddressKeypad = "";
            this.digitalPanelMeter2.PLCAddressValue = "44001";
            this.digitalPanelMeter2.Resolution = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.digitalPanelMeter2.Size = new System.Drawing.Size(282, 106);
            this.digitalPanelMeter2.TabIndex = 56;
            this.digitalPanelMeter2.Text = "digitalPanelMeter2";
            this.digitalPanelMeter2.Value = 0D;
            this.digitalPanelMeter2.ValueScaleFactor = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.digitalPanelMeter2.ValueScaleOffset = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // digitalPanelMeter1
            // 
            this.digitalPanelMeter1.BackColor = System.Drawing.Color.Transparent;
            this.digitalPanelMeter1.ComComponent = this.modbusRTUCom1;
            this.digitalPanelMeter1.DecimalPosition = 0;
            this.digitalPanelMeter1.ForeColor = System.Drawing.Color.LightGray;
            this.digitalPanelMeter1.KeypadFontColor = System.Drawing.Color.WhiteSmoke;
            this.digitalPanelMeter1.KeypadMaxValue = 0D;
            this.digitalPanelMeter1.KeypadMinValue = 0D;
            this.digitalPanelMeter1.KeypadScaleFactor = 1D;
            this.digitalPanelMeter1.KeypadText = null;
            this.digitalPanelMeter1.KeypadWidth = 300;
            this.digitalPanelMeter1.Location = new System.Drawing.Point(59, 134);
            this.digitalPanelMeter1.Name = "digitalPanelMeter1";
            this.digitalPanelMeter1.NumberOfDigits = 6;
            this.digitalPanelMeter1.PLCAddressKeypad = "";
            this.digitalPanelMeter1.PLCAddressValue = "44001";
            this.digitalPanelMeter1.Resolution = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.digitalPanelMeter1.Size = new System.Drawing.Size(282, 106);
            this.digitalPanelMeter1.TabIndex = 55;
            this.digitalPanelMeter1.Text = "digitalPanelMeter1";
            this.digitalPanelMeter1.Value = 0D;
            this.digitalPanelMeter1.ValueScaleFactor = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.digitalPanelMeter1.ValueScaleOffset = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.digitalPanelMeter1.ValueChanged += new System.EventHandler(this.digitalPanelMeter1_ValueChanged);
            // 
            // modbusRTUCom2
            // 
            this.modbusRTUCom2.BaudRate = 9600;
            this.modbusRTUCom2.DataBits = 8;
            this.modbusRTUCom2.DisableSubscriptions = false;
            this.modbusRTUCom2.EnableLogging = false;
            this.modbusRTUCom2.IniFileName = "";
            this.modbusRTUCom2.IniFileSection = null;
            this.modbusRTUCom2.MaxReadGroupSize = 32;
            this.modbusRTUCom2.Parity = System.IO.Ports.Parity.None;
            this.modbusRTUCom2.PollRateOverride = 100;
            this.modbusRTUCom2.PortName = "COM6";
            this.modbusRTUCom2.StationAddress = ((byte)(1));
            this.modbusRTUCom2.StopBits = System.IO.Ports.StopBits.One;
            this.modbusRTUCom2.SwapBytes = true;
            this.modbusRTUCom2.SwapWords = false;
            this.modbusRTUCom2.TimeOut = 1000;
            // 
            // basicButton2
            // 
            this.basicButton2.BackColor = System.Drawing.Color.Black;
            this.basicButton2.ComComponent = this.modbusRTUCom2;
            this.basicButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.basicButton2.ForeColor = System.Drawing.Color.Black;
            this.basicButton2.ForeColorAltername = System.Drawing.Color.Black;
            this.basicButton2.Highlight = false;
            this.basicButton2.HighlightColor = System.Drawing.Color.Green;
            this.basicButton2.Location = new System.Drawing.Point(50, 296);
            this.basicButton2.MaximumHoldTime = 3000;
            this.basicButton2.MinimumHoldTime = 500;
            this.basicButton2.Name = "basicButton2";
            this.basicButton2.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet;
            this.basicButton2.PLCAddressClick = "00001";
            this.basicButton2.SelectTextAlternate = false;
            this.basicButton2.Size = new System.Drawing.Size(114, 35);
            this.basicButton2.TabIndex = 58;
            this.basicButton2.Text = "MB02";
            this.basicButton2.TextAlternate = null;
            this.basicButton2.UseVisualStyleBackColor = true;
            this.basicButton2.ValueToWrite = 0;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(59, 83);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(281, 31);
            this.textBox1.TabIndex = 60;
            // 
            // keyboardInput1
            // 
            this.keyboardInput1.ClearAfterEnterKey = true;
            this.keyboardInput1.ComComponent = this.modbusRTUCom1;
            this.keyboardInput1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keyboardInput1.GetFocusMatchValue = 1;
            this.keyboardInput1.GetFocusValue = 0;
            this.keyboardInput1.Location = new System.Drawing.Point(375, 83);
            this.keyboardInput1.Name = "keyboardInput1";
            this.keyboardInput1.PLCAddressGetFocusValue = null;
            this.keyboardInput1.PLCAddressWriteValue = ((MfgControl.AdvancedHMI.Drivers.PLCAddressItem)(resources.GetObject("keyboardInput1.PLCAddressWriteValue")));
            this.keyboardInput1.Size = new System.Drawing.Size(252, 31);
            this.keyboardInput1.TabIndex = 61;
            // 
            // basicLabel1
            // 
            this.basicLabel1.AutoSize = true;
            this.basicLabel1.BackColor = System.Drawing.Color.Black;
            this.basicLabel1.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse;
            this.basicLabel1.ComComponent = this.modbusRTUCom2;
            this.basicLabel1.DisplayAsTime = false;
            this.basicLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.basicLabel1.ForeColor = System.Drawing.Color.White;
            this.basicLabel1.Highlight = false;
            this.basicLabel1.HighlightColor = System.Drawing.Color.Red;
            this.basicLabel1.HighlightForeColor = System.Drawing.Color.White;
            this.basicLabel1.HighlightKeyCharacter = "!";
            this.basicLabel1.InterpretValueAsBCD = false;
            this.basicLabel1.KeypadAlphaNumeric = false;
            this.basicLabel1.KeypadFont = new System.Drawing.Font("Arial", 10F);
            this.basicLabel1.KeypadFontColor = System.Drawing.Color.WhiteSmoke;
            this.basicLabel1.KeypadMaxValue = 0D;
            this.basicLabel1.KeypadMinValue = 0D;
            this.basicLabel1.KeypadScaleFactor = 1D;
            this.basicLabel1.KeypadShowCurrentValue = false;
            this.basicLabel1.KeypadText = null;
            this.basicLabel1.KeypadWidth = 300;
            this.basicLabel1.Location = new System.Drawing.Point(204, 301);
            this.basicLabel1.Name = "basicLabel1";
            this.basicLabel1.NumericFormat = null;
            this.basicLabel1.PLCAddressKeypad = "";
            this.basicLabel1.PLCAddressValue = "00001";
            this.basicLabel1.PollRate = 0;
            this.basicLabel1.Size = new System.Drawing.Size(118, 25);
            this.basicLabel1.TabIndex = 62;
            this.basicLabel1.Text = "BasicLabel";
            this.basicLabel1.Value = "BasicLabel";
            this.basicLabel1.ValueLeftPadCharacter = ' ';
            this.basicLabel1.ValueLeftPadLength = 0;
            this.basicLabel1.ValuePrefix = null;
            this.basicLabel1.ValueScaleFactor = 1D;
            this.basicLabel1.ValueSuffix = null;
            this.basicLabel1.ValueToSubtractFrom = 0F;
            // 
            // analogValueDisplay1
            // 
            this.analogValueDisplay1.AutoSize = true;
            this.analogValueDisplay1.ComComponent = this.modbusRTUCom2;
            this.analogValueDisplay1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.analogValueDisplay1.ForeColor = System.Drawing.Color.White;
            this.analogValueDisplay1.ForeColorInLimits = System.Drawing.Color.White;
            this.analogValueDisplay1.ForeColorOverLimit = System.Drawing.Color.Red;
            this.analogValueDisplay1.ForeColorUnderLimit = System.Drawing.Color.Yellow;
            this.analogValueDisplay1.KeypadFontColor = System.Drawing.Color.WhiteSmoke;
            this.analogValueDisplay1.KeypadMaxValue = 0D;
            this.analogValueDisplay1.KeypadMinValue = 0D;
            this.analogValueDisplay1.KeypadPasscode = null;
            this.analogValueDisplay1.KeypadScaleFactor = 1D;
            this.analogValueDisplay1.KeypadText = null;
            this.analogValueDisplay1.KeypadWidth = 300;
            this.analogValueDisplay1.Location = new System.Drawing.Point(390, 301);
            this.analogValueDisplay1.Name = "analogValueDisplay1";
            this.analogValueDisplay1.NumericFormat = null;
            this.analogValueDisplay1.PLCAddressKeypad = "";
            this.analogValueDisplay1.PLCAddressValue = ((MfgControl.AdvancedHMI.Drivers.PLCAddressItem)(resources.GetObject("analogValueDisplay1.PLCAddressValue")));
            this.analogValueDisplay1.PLCAddressValueLimitLower = null;
            this.analogValueDisplay1.PLCAddressValueLimitUpper = null;
            this.analogValueDisplay1.PLCAddressVisible = null;
            this.analogValueDisplay1.ShowValue = true;
            this.analogValueDisplay1.Size = new System.Drawing.Size(60, 25);
            this.analogValueDisplay1.TabIndex = 63;
            this.analogValueDisplay1.Text = "0000";
            this.analogValueDisplay1.Value = "0000";
            this.analogValueDisplay1.ValueLimitLower = -999999D;
            this.analogValueDisplay1.ValueLimitUpper = 999999D;
            this.analogValueDisplay1.ValuePrefix = null;
            this.analogValueDisplay1.ValueSuffix = null;
            this.analogValueDisplay1.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always;
            // 
            // basicButton1
            // 
            this.basicButton1.BackColor = System.Drawing.Color.Black;
            this.basicButton1.ComComponent = this.modbusRTUCom2;
            this.basicButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.basicButton1.ForeColor = System.Drawing.Color.Black;
            this.basicButton1.ForeColorAltername = System.Drawing.Color.Black;
            this.basicButton1.Highlight = false;
            this.basicButton1.HighlightColor = System.Drawing.Color.Green;
            this.basicButton1.Location = new System.Drawing.Point(50, 42);
            this.basicButton1.MaximumHoldTime = 3000;
            this.basicButton1.MinimumHoldTime = 500;
            this.basicButton1.Name = "basicButton1";
            this.basicButton1.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet;
            this.basicButton1.PLCAddressClick = "00001";
            this.basicButton1.SelectTextAlternate = false;
            this.basicButton1.Size = new System.Drawing.Size(114, 35);
            this.basicButton1.TabIndex = 64;
            this.basicButton1.Text = "MB01";
            this.basicButton1.TextAlternate = null;
            this.basicButton1.UseVisualStyleBackColor = true;
            this.basicButton1.ValueToWrite = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1005, 453);
            this.Controls.Add(this.basicButton1);
            this.Controls.Add(this.analogValueDisplay1);
            this.Controls.Add(this.basicLabel1);
            this.Controls.Add(this.keyboardInput1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.basicButton2);
            this.Controls.Add(this.digitalPanelMeter2);
            this.Controls.Add(this.digitalPanelMeter1);
            this.Controls.Add(this.Label1);
            this.Name = "MainForm";
            this.Text = "AdvancedHMI V3.99x";
            ((System.ComponentModel.ISupportInitialize)(this.modbusRTUCom1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modbusRTUCom2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Label Label1;
        private AdvancedHMIDrivers.ModbusRTUCom modbusRTUCom1;
        private AdvancedHMIControls.DigitalPanelMeter digitalPanelMeter2;
        private AdvancedHMIControls.DigitalPanelMeter digitalPanelMeter1;
        private AdvancedHMIDrivers.ModbusRTUCom modbusRTUCom2;
        private AdvancedHMIControls.BasicButton basicButton2;
        private System.Windows.Forms.TextBox textBox1;
        private AdvancedHMIControls.KeyboardInput keyboardInput1;
        private AdvancedHMIControls.BasicLabel basicLabel1;
        private AdvancedHMIControls.AnalogValueDisplay analogValueDisplay1;
        private AdvancedHMIControls.BasicButton basicButton1;
    }
}

