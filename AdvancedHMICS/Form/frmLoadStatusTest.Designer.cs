namespace AdvancedHMICS
{
    partial class frmLoadStatusTest
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
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.tlpButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnKills = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.grLoadList = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cbR16 = new System.Windows.Forms.CheckBox();
            this.cbR15 = new System.Windows.Forms.CheckBox();
            this.cbR14 = new System.Windows.Forms.CheckBox();
            this.cbR13 = new System.Windows.Forms.CheckBox();
            this.cbR12 = new System.Windows.Forms.CheckBox();
            this.cbR11 = new System.Windows.Forms.CheckBox();
            this.cbR10 = new System.Windows.Forms.CheckBox();
            this.cbR9 = new System.Windows.Forms.CheckBox();
            this.cbR8 = new System.Windows.Forms.CheckBox();
            this.cbR7 = new System.Windows.Forms.CheckBox();
            this.cbR6 = new System.Windows.Forms.CheckBox();
            this.cbR5 = new System.Windows.Forms.CheckBox();
            this.cbR4 = new System.Windows.Forms.CheckBox();
            this.cbR3 = new System.Windows.Forms.CheckBox();
            this.cbR2 = new System.Windows.Forms.CheckBox();
            this.cbR1 = new System.Windows.Forms.CheckBox();
            this.tlpMain.SuspendLayout();
            this.tlpButtons.SuspendLayout();
            this.grLoadList.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.tlpButtons, 0, 1);
            this.tlpMain.Controls.Add(this.grLoadList, 0, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 2;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.Size = new System.Drawing.Size(635, 234);
            this.tlpMain.TabIndex = 0;
            // 
            // tlpButtons
            // 
            this.tlpButtons.ColumnCount = 4;
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpButtons.Controls.Add(this.btnClose, 3, 0);
            this.tlpButtons.Controls.Add(this.btnKills, 2, 0);
            this.tlpButtons.Controls.Add(this.btnAll, 1, 0);
            this.tlpButtons.Controls.Add(this.lblStatus, 0, 0);
            this.tlpButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpButtons.Location = new System.Drawing.Point(3, 177);
            this.tlpButtons.Name = "tlpButtons";
            this.tlpButtons.RowCount = 1;
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpButtons.Size = new System.Drawing.Size(629, 54);
            this.tlpButtons.TabIndex = 3;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Salmon;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(489, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(137, 48);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnKills
            // 
            this.btnKills.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnKills.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKills.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKills.Location = new System.Drawing.Point(346, 3);
            this.btnKills.Name = "btnKills";
            this.btnKills.Size = new System.Drawing.Size(137, 48);
            this.btnKills.TabIndex = 3;
            this.btnKills.Text = "All kill";
            this.btnKills.UseVisualStyleBackColor = true;
            this.btnKills.Click += new System.EventHandler(this.btnKills_Click);
            // 
            // btnAll
            // 
            this.btnAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAll.Location = new System.Drawing.Point(203, 3);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(137, 48);
            this.btnAll.TabIndex = 2;
            this.btnAll.Text = "All bright";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(3, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(194, 54);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "POWER: 0 W";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grLoadList
            // 
            this.grLoadList.Controls.Add(this.tableLayoutPanel2);
            this.grLoadList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grLoadList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grLoadList.Location = new System.Drawing.Point(3, 3);
            this.grLoadList.Name = "grLoadList";
            this.grLoadList.Size = new System.Drawing.Size(629, 168);
            this.grLoadList.TabIndex = 2;
            this.grLoadList.TabStop = false;
            this.grLoadList.Text = "Load list";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.cbR16, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.cbR15, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.cbR14, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.cbR13, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.cbR12, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.cbR11, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.cbR10, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.cbR9, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.cbR8, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.cbR7, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.cbR6, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.cbR5, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.cbR4, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.cbR3, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.cbR2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.cbR1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(623, 147);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // cbR16
            // 
            this.cbR16.AutoSize = true;
            this.cbR16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbR16.Location = new System.Drawing.Point(468, 111);
            this.cbR16.Name = "cbR16";
            this.cbR16.Size = new System.Drawing.Size(152, 33);
            this.cbR16.TabIndex = 16;
            this.cbR16.Tag = "0";
            this.cbR16.Text = "Load16 = 0 W";
            this.cbR16.UseVisualStyleBackColor = true;
            this.cbR16.CheckedChanged += new System.EventHandler(this.RChanged);
            // 
            // cbR15
            // 
            this.cbR15.AutoSize = true;
            this.cbR15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbR15.Location = new System.Drawing.Point(313, 111);
            this.cbR15.Name = "cbR15";
            this.cbR15.Size = new System.Drawing.Size(149, 33);
            this.cbR15.TabIndex = 15;
            this.cbR15.Tag = "0";
            this.cbR15.Text = "Load15 = 0 W";
            this.cbR15.UseVisualStyleBackColor = true;
            this.cbR15.CheckedChanged += new System.EventHandler(this.RChanged);
            // 
            // cbR14
            // 
            this.cbR14.AutoSize = true;
            this.cbR14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbR14.Location = new System.Drawing.Point(158, 111);
            this.cbR14.Name = "cbR14";
            this.cbR14.Size = new System.Drawing.Size(149, 33);
            this.cbR14.TabIndex = 14;
            this.cbR14.Tag = "4000";
            this.cbR14.Text = "Load14 = 4000 W";
            this.cbR14.UseVisualStyleBackColor = true;
            this.cbR14.CheckedChanged += new System.EventHandler(this.RChanged);
            // 
            // cbR13
            // 
            this.cbR13.AutoSize = true;
            this.cbR13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbR13.Location = new System.Drawing.Point(3, 111);
            this.cbR13.Name = "cbR13";
            this.cbR13.Size = new System.Drawing.Size(149, 33);
            this.cbR13.TabIndex = 13;
            this.cbR13.Tag = "4000";
            this.cbR13.Text = "Load13 = 4000 W";
            this.cbR13.UseVisualStyleBackColor = true;
            this.cbR13.CheckedChanged += new System.EventHandler(this.RChanged);
            // 
            // cbR12
            // 
            this.cbR12.AutoSize = true;
            this.cbR12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbR12.Location = new System.Drawing.Point(468, 75);
            this.cbR12.Name = "cbR12";
            this.cbR12.Size = new System.Drawing.Size(152, 30);
            this.cbR12.TabIndex = 12;
            this.cbR12.Tag = "4000";
            this.cbR12.Text = "Load12 = 4000 W";
            this.cbR12.UseVisualStyleBackColor = true;
            this.cbR12.CheckedChanged += new System.EventHandler(this.RChanged);
            // 
            // cbR11
            // 
            this.cbR11.AutoSize = true;
            this.cbR11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbR11.Location = new System.Drawing.Point(313, 75);
            this.cbR11.Name = "cbR11";
            this.cbR11.Size = new System.Drawing.Size(149, 30);
            this.cbR11.TabIndex = 11;
            this.cbR11.Tag = "4000";
            this.cbR11.Text = "Load11 = 4000 W";
            this.cbR11.UseVisualStyleBackColor = true;
            this.cbR11.CheckedChanged += new System.EventHandler(this.RChanged);
            // 
            // cbR10
            // 
            this.cbR10.AutoSize = true;
            this.cbR10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbR10.Location = new System.Drawing.Point(158, 75);
            this.cbR10.Name = "cbR10";
            this.cbR10.Size = new System.Drawing.Size(149, 30);
            this.cbR10.TabIndex = 10;
            this.cbR10.Tag = "2000";
            this.cbR10.Text = "Load10 = 2000 W";
            this.cbR10.UseVisualStyleBackColor = true;
            this.cbR10.CheckedChanged += new System.EventHandler(this.RChanged);
            // 
            // cbR9
            // 
            this.cbR9.AutoSize = true;
            this.cbR9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbR9.Location = new System.Drawing.Point(3, 75);
            this.cbR9.Name = "cbR9";
            this.cbR9.Size = new System.Drawing.Size(149, 30);
            this.cbR9.TabIndex = 9;
            this.cbR9.Tag = "1280";
            this.cbR9.Text = "Load9 = 1280 W";
            this.cbR9.UseVisualStyleBackColor = true;
            this.cbR9.CheckedChanged += new System.EventHandler(this.RChanged);
            // 
            // cbR8
            // 
            this.cbR8.AutoSize = true;
            this.cbR8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbR8.Location = new System.Drawing.Point(468, 39);
            this.cbR8.Name = "cbR8";
            this.cbR8.Size = new System.Drawing.Size(152, 30);
            this.cbR8.TabIndex = 8;
            this.cbR8.Tag = "640";
            this.cbR8.Text = "Load8 = 640 W";
            this.cbR8.UseVisualStyleBackColor = true;
            this.cbR8.CheckedChanged += new System.EventHandler(this.RChanged);
            // 
            // cbR7
            // 
            this.cbR7.AutoSize = true;
            this.cbR7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbR7.Location = new System.Drawing.Point(313, 39);
            this.cbR7.Name = "cbR7";
            this.cbR7.Size = new System.Drawing.Size(149, 30);
            this.cbR7.TabIndex = 7;
            this.cbR7.Tag = "320";
            this.cbR7.Text = "Load7 = 320 W";
            this.cbR7.UseVisualStyleBackColor = true;
            this.cbR7.CheckedChanged += new System.EventHandler(this.RChanged);
            // 
            // cbR6
            // 
            this.cbR6.AutoSize = true;
            this.cbR6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbR6.Location = new System.Drawing.Point(158, 39);
            this.cbR6.Name = "cbR6";
            this.cbR6.Size = new System.Drawing.Size(149, 30);
            this.cbR6.TabIndex = 6;
            this.cbR6.Tag = "160";
            this.cbR6.Text = "Load6 = 160 W";
            this.cbR6.UseVisualStyleBackColor = true;
            this.cbR6.CheckedChanged += new System.EventHandler(this.RChanged);
            // 
            // cbR5
            // 
            this.cbR5.AutoSize = true;
            this.cbR5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbR5.Location = new System.Drawing.Point(3, 39);
            this.cbR5.Name = "cbR5";
            this.cbR5.Size = new System.Drawing.Size(149, 30);
            this.cbR5.TabIndex = 5;
            this.cbR5.Tag = "80";
            this.cbR5.Text = "Load5 = 80 W";
            this.cbR5.UseVisualStyleBackColor = true;
            this.cbR5.CheckedChanged += new System.EventHandler(this.RChanged);
            // 
            // cbR4
            // 
            this.cbR4.AutoSize = true;
            this.cbR4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbR4.Location = new System.Drawing.Point(468, 3);
            this.cbR4.Name = "cbR4";
            this.cbR4.Size = new System.Drawing.Size(152, 30);
            this.cbR4.TabIndex = 4;
            this.cbR4.Tag = "40";
            this.cbR4.Text = "Load4 = 40 W";
            this.cbR4.UseVisualStyleBackColor = true;
            this.cbR4.CheckedChanged += new System.EventHandler(this.RChanged);
            // 
            // cbR3
            // 
            this.cbR3.AutoSize = true;
            this.cbR3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbR3.Location = new System.Drawing.Point(313, 3);
            this.cbR3.Name = "cbR3";
            this.cbR3.Size = new System.Drawing.Size(149, 30);
            this.cbR3.TabIndex = 3;
            this.cbR3.Tag = "20";
            this.cbR3.Text = "Load3 = 20 W";
            this.cbR3.UseVisualStyleBackColor = true;
            this.cbR3.CheckedChanged += new System.EventHandler(this.RChanged);
            // 
            // cbR2
            // 
            this.cbR2.AutoSize = true;
            this.cbR2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbR2.Location = new System.Drawing.Point(158, 3);
            this.cbR2.Name = "cbR2";
            this.cbR2.Size = new System.Drawing.Size(149, 30);
            this.cbR2.TabIndex = 2;
            this.cbR2.Tag = "10";
            this.cbR2.Text = "Load2 = 10 W";
            this.cbR2.UseVisualStyleBackColor = true;
            this.cbR2.CheckedChanged += new System.EventHandler(this.RChanged);
            // 
            // cbR1
            // 
            this.cbR1.AutoSize = true;
            this.cbR1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbR1.Location = new System.Drawing.Point(3, 3);
            this.cbR1.Name = "cbR1";
            this.cbR1.Size = new System.Drawing.Size(149, 30);
            this.cbR1.TabIndex = 1;
            this.cbR1.Tag = "5";
            this.cbR1.Text = "Load1 = 5 W";
            this.cbR1.UseVisualStyleBackColor = true;
            this.cbR1.CheckedChanged += new System.EventHandler(this.RChanged);
            // 
            // frmLoadStatusTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 234);
            this.ControlBox = false;
            this.Controls.Add(this.tlpMain);
            this.Name = "frmLoadStatusTest";
            this.Text = "Load Debug";
            this.TopMost = true;
            this.tlpMain.ResumeLayout(false);
            this.tlpButtons.ResumeLayout(false);
            this.grLoadList.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.GroupBox grLoadList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tlpButtons;
        private System.Windows.Forms.CheckBox cbR1;
        private System.Windows.Forms.CheckBox cbR16;
        private System.Windows.Forms.CheckBox cbR15;
        private System.Windows.Forms.CheckBox cbR14;
        private System.Windows.Forms.CheckBox cbR13;
        private System.Windows.Forms.CheckBox cbR12;
        private System.Windows.Forms.CheckBox cbR11;
        private System.Windows.Forms.CheckBox cbR10;
        private System.Windows.Forms.CheckBox cbR9;
        private System.Windows.Forms.CheckBox cbR8;
        private System.Windows.Forms.CheckBox cbR7;
        private System.Windows.Forms.CheckBox cbR6;
        private System.Windows.Forms.CheckBox cbR5;
        private System.Windows.Forms.CheckBox cbR4;
        private System.Windows.Forms.CheckBox cbR3;
        private System.Windows.Forms.CheckBox cbR2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnKills;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Label lblStatus;
    }
}