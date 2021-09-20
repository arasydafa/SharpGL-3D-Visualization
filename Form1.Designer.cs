
namespace SharpGL_3D_Visualization
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comPortDropdown = new Bunifu.Framework.UI.BunifuDropdown();
            this.baudRateDropdown = new Bunifu.Framework.UI.BunifuDropdown();
            this.refreshPortButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.connectPortButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.rollLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pitchLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.rollValue = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pitchValue = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.yawLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.yawValue = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.portLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.baudLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.openGLControl1 = new SharpGL.OpenGLControl();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.axesLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.refreshPortButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectPortButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comPortDropdown
            // 
            this.comPortDropdown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.comPortDropdown.BorderRadius = 3;
            this.comPortDropdown.DisabledColor = System.Drawing.Color.Gray;
            this.comPortDropdown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(102)))));
            this.comPortDropdown.Items = new string[0];
            this.comPortDropdown.Location = new System.Drawing.Point(832, 132);
            this.comPortDropdown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comPortDropdown.Name = "comPortDropdown";
            this.comPortDropdown.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.comPortDropdown.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.comPortDropdown.selectedIndex = -1;
            this.comPortDropdown.Size = new System.Drawing.Size(185, 43);
            this.comPortDropdown.TabIndex = 4;
            // 
            // baudRateDropdown
            // 
            this.baudRateDropdown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.baudRateDropdown.BorderRadius = 3;
            this.baudRateDropdown.DisabledColor = System.Drawing.Color.Gray;
            this.baudRateDropdown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(102)))));
            this.baudRateDropdown.Items = new string[0];
            this.baudRateDropdown.Location = new System.Drawing.Point(832, 60);
            this.baudRateDropdown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.baudRateDropdown.Name = "baudRateDropdown";
            this.baudRateDropdown.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.baudRateDropdown.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.baudRateDropdown.selectedIndex = -1;
            this.baudRateDropdown.Size = new System.Drawing.Size(185, 43);
            this.baudRateDropdown.TabIndex = 4;
            // 
            // refreshPortButton
            // 
            this.refreshPortButton.BackColor = System.Drawing.Color.Transparent;
            this.refreshPortButton.Image = ((System.Drawing.Image)(resources.GetObject("refreshPortButton.Image")));
            this.refreshPortButton.ImageActive = null;
            this.refreshPortButton.Location = new System.Drawing.Point(872, 233);
            this.refreshPortButton.Name = "refreshPortButton";
            this.refreshPortButton.Size = new System.Drawing.Size(46, 49);
            this.refreshPortButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.refreshPortButton.TabIndex = 5;
            this.refreshPortButton.TabStop = false;
            this.refreshPortButton.Zoom = 10;
            this.refreshPortButton.Click += new System.EventHandler(this.refreshPortButton_Click);
            // 
            // connectPortButton
            // 
            this.connectPortButton.BackColor = System.Drawing.Color.Transparent;
            this.connectPortButton.Image = ((System.Drawing.Image)(resources.GetObject("connectPortButton.Image")));
            this.connectPortButton.ImageActive = null;
            this.connectPortButton.Location = new System.Drawing.Point(747, 207);
            this.connectPortButton.Name = "connectPortButton";
            this.connectPortButton.Size = new System.Drawing.Size(94, 100);
            this.connectPortButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.connectPortButton.TabIndex = 5;
            this.connectPortButton.TabStop = false;
            this.connectPortButton.Zoom = 10;
            this.connectPortButton.Click += new System.EventHandler(this.connectPortButton_Click);
            // 
            // serialPort
            // 
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // rollLabel
            // 
            this.rollLabel.AutoSize = true;
            this.rollLabel.Font = new System.Drawing.Font("Roboto Condensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollLabel.ForeColor = System.Drawing.Color.White;
            this.rollLabel.Location = new System.Drawing.Point(693, 425);
            this.rollLabel.Name = "rollLabel";
            this.rollLabel.Size = new System.Drawing.Size(69, 41);
            this.rollLabel.TabIndex = 6;
            this.rollLabel.Text = "Roll";
            // 
            // pitchLabel
            // 
            this.pitchLabel.AutoSize = true;
            this.pitchLabel.Font = new System.Drawing.Font("Roboto Condensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pitchLabel.ForeColor = System.Drawing.Color.White;
            this.pitchLabel.Location = new System.Drawing.Point(693, 475);
            this.pitchLabel.Name = "pitchLabel";
            this.pitchLabel.Size = new System.Drawing.Size(87, 41);
            this.pitchLabel.TabIndex = 6;
            this.pitchLabel.Text = "Pitch";
            // 
            // rollValue
            // 
            this.rollValue.AutoSize = true;
            this.rollValue.Font = new System.Drawing.Font("Roboto Condensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollValue.ForeColor = System.Drawing.Color.White;
            this.rollValue.Location = new System.Drawing.Point(849, 425);
            this.rollValue.Name = "rollValue";
            this.rollValue.Size = new System.Drawing.Size(112, 41);
            this.rollValue.TabIndex = 6;
            this.rollValue.Text = "000.00";
            // 
            // pitchValue
            // 
            this.pitchValue.AutoSize = true;
            this.pitchValue.Font = new System.Drawing.Font("Roboto Condensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pitchValue.ForeColor = System.Drawing.Color.White;
            this.pitchValue.Location = new System.Drawing.Point(849, 475);
            this.pitchValue.Name = "pitchValue";
            this.pitchValue.Size = new System.Drawing.Size(112, 41);
            this.pitchValue.TabIndex = 6;
            this.pitchValue.Text = "000.00";
            // 
            // yawLabel
            // 
            this.yawLabel.AutoSize = true;
            this.yawLabel.Font = new System.Drawing.Font("Roboto Condensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yawLabel.ForeColor = System.Drawing.Color.White;
            this.yawLabel.Location = new System.Drawing.Point(693, 528);
            this.yawLabel.Name = "yawLabel";
            this.yawLabel.Size = new System.Drawing.Size(73, 41);
            this.yawLabel.TabIndex = 6;
            this.yawLabel.Text = "Yaw";
            // 
            // yawValue
            // 
            this.yawValue.AutoSize = true;
            this.yawValue.Font = new System.Drawing.Font("Roboto Condensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yawValue.ForeColor = System.Drawing.Color.White;
            this.yawValue.Location = new System.Drawing.Point(849, 528);
            this.yawValue.Name = "yawValue";
            this.yawValue.Size = new System.Drawing.Size(112, 41);
            this.yawValue.TabIndex = 6;
            this.yawValue.Text = "000.00";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Roboto Condensed", 19.8F);
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(205, 15);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(234, 41);
            this.bunifuCustomLabel1.TabIndex = 7;
            this.bunifuCustomLabel1.Text = "3D Visualization";
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Font = new System.Drawing.Font("Roboto Condensed", 19.8F);
            this.portLabel.ForeColor = System.Drawing.Color.White;
            this.portLabel.Location = new System.Drawing.Point(643, 61);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(148, 41);
            this.portLabel.TabIndex = 7;
            this.portLabel.Text = "COM Port";
            // 
            // baudLabel
            // 
            this.baudLabel.AutoSize = true;
            this.baudLabel.Font = new System.Drawing.Font("Roboto Condensed", 19.8F);
            this.baudLabel.ForeColor = System.Drawing.Color.White;
            this.baudLabel.Location = new System.Drawing.Point(643, 133);
            this.baudLabel.Name = "baudLabel";
            this.baudLabel.Size = new System.Drawing.Size(137, 41);
            this.baudLabel.TabIndex = 7;
            this.baudLabel.Text = "Baudrate";
            // 
            // openGLControl1
            // 
            this.openGLControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.openGLControl1.BitDepth = 24;
            this.openGLControl1.DrawFPS = false;
            this.openGLControl1.FrameRate = 20;
            this.openGLControl1.Location = new System.Drawing.Point(23, 60);
            this.openGLControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.openGLControl1.Name = "openGLControl1";
            this.openGLControl1.RenderContextType = SharpGL.RenderContextType.DIBSection;
            this.openGLControl1.Size = new System.Drawing.Size(598, 598);
            this.openGLControl1.TabIndex = 8;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(622, 324);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(412, 43);
            this.bunifuSeparator1.TabIndex = 9;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // axesLabel
            // 
            this.axesLabel.AutoSize = true;
            this.axesLabel.Font = new System.Drawing.Font("Roboto Condensed", 19.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.axesLabel.ForeColor = System.Drawing.Color.White;
            this.axesLabel.Location = new System.Drawing.Point(757, 359);
            this.axesLabel.Name = "axesLabel";
            this.axesLabel.Size = new System.Drawing.Size(166, 41);
            this.axesLabel.TabIndex = 7;
            this.axesLabel.Text = "Axes Value";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 673);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1041, 27);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(102)))));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(229, 24);
            this.toolStripLabel1.Text = "Please Connect a COM Port";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(1041, 700);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.openGLControl1);
            this.Controls.Add(this.axesLabel);
            this.Controls.Add(this.baudLabel);
            this.Controls.Add(this.portLabel);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.yawValue);
            this.Controls.Add(this.pitchValue);
            this.Controls.Add(this.rollValue);
            this.Controls.Add(this.yawLabel);
            this.Controls.Add(this.pitchLabel);
            this.Controls.Add(this.rollLabel);
            this.Controls.Add(this.connectPortButton);
            this.Controls.Add(this.refreshPortButton);
            this.Controls.Add(this.baudRateDropdown);
            this.Controls.Add(this.comPortDropdown);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.refreshPortButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectPortButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuDropdown comPortDropdown;
        private Bunifu.Framework.UI.BunifuDropdown baudRateDropdown;
        private Bunifu.Framework.UI.BunifuImageButton refreshPortButton;
        private Bunifu.Framework.UI.BunifuImageButton connectPortButton;
        private System.IO.Ports.SerialPort serialPort;
        private Bunifu.Framework.UI.BunifuCustomLabel rollLabel;
        private Bunifu.Framework.UI.BunifuCustomLabel pitchLabel;
        private Bunifu.Framework.UI.BunifuCustomLabel rollValue;
        private Bunifu.Framework.UI.BunifuCustomLabel pitchValue;
        private Bunifu.Framework.UI.BunifuCustomLabel yawLabel;
        private Bunifu.Framework.UI.BunifuCustomLabel yawValue;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel portLabel;
        private Bunifu.Framework.UI.BunifuCustomLabel baudLabel;
        private SharpGL.OpenGLControl openGLControl1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuCustomLabel axesLabel;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    }
}

