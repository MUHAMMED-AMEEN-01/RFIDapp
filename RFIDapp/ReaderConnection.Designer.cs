namespace RFIDapp
{
    partial class ReaderConnection
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
            heading = new Label();
            txtIP = new Label();
            inputIp = new TextBox();
            txtPort = new Label();
            inputPort = new TextBox();
            btnConnect = new Button();
            txtStatus = new Label();
            dispStatus = new Label();
            btnDisconnect = new Button();
            menuStrip = new MenuStrip();
            back = new ToolStripMenuItem();
            epcTable = new ToolStripMenuItem();
            buzzer = new ToolStripMenuItem();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // heading
            // 
            heading.AutoSize = true;
            heading.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline);
            heading.Location = new Point(268, 43);
            heading.Name = "heading";
            heading.Size = new Size(174, 25);
            heading.TabIndex = 0;
            heading.Text = "Reader Connection";
            // 
            // txtIP
            // 
            txtIP.AutoSize = true;
            txtIP.Location = new Point(43, 107);
            txtIP.Name = "txtIP";
            txtIP.Size = new Size(95, 25);
            txtIP.TabIndex = 1;
            txtIP.Text = "Reader IP :";
            // 
            // inputIp
            // 
            inputIp.Location = new Point(145, 109);
            inputIp.Name = "inputIp";
            inputIp.Size = new Size(150, 31);
            inputIp.TabIndex = 2;
            // 
            // txtPort
            // 
            txtPort.AutoSize = true;
            txtPort.Location = new Point(61, 180);
            txtPort.Name = "txtPort";
            txtPort.Size = new Size(114, 25);
            txtPort.TabIndex = 3;
            txtPort.Text = "Reader port :";
            // 
            // inputPort
            // 
            inputPort.Location = new Point(185, 181);
            inputPort.Name = "inputPort";
            inputPort.Size = new Size(150, 31);
            inputPort.TabIndex = 4;
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(158, 248);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(112, 34);
            btnConnect.TabIndex = 5;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += button1_Click;
            // 
            // txtStatus
            // 
            txtStatus.AutoSize = true;
            txtStatus.Location = new Point(88, 325);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(69, 25);
            txtStatus.TabIndex = 6;
            txtStatus.Text = "Status :";
            // 
            // dispStatus
            // 
            dispStatus.AutoSize = true;
            dispStatus.Location = new Point(171, 329);
            dispStatus.Name = "dispStatus";
            dispStatus.Size = new Size(0, 25);
            dispStatus.TabIndex = 7;
            // 
            // btnDisconnect
            // 
            btnDisconnect.Location = new Point(290, 248);
            btnDisconnect.Name = "btnDisconnect";
            btnDisconnect.Size = new Size(112, 34);
            btnDisconnect.TabIndex = 8;
            btnDisconnect.Text = "Disconnect";
            btnDisconnect.UseVisualStyleBackColor = true;
            btnDisconnect.Click += button2_Click;
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(24, 24);
            menuStrip.Items.AddRange(new ToolStripItem[] { back, epcTable, buzzer });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(800, 33);
            menuStrip.TabIndex = 9;
            menuStrip.Text = "menuStrip1";
            // 
            // back
            // 
            back.Name = "back";
            back.Size = new Size(44, 29);
            back.Text = "←";
            back.Click += toolStripMenuItem1_Click;
            // 
            // epcTable
            // 
            epcTable.Name = "epcTable";
            epcTable.Size = new Size(103, 29);
            epcTable.Text = "EPC Table";
            epcTable.Click += ePCTableToolStripMenuItem_Click;
            // 
            // buzzer
            // 
            buzzer.Name = "buzzer";
            buzzer.Size = new Size(79, 29);
            buzzer.Text = "Buzzer";
            buzzer.Click += buzzerToolStripMenuItem_Click;
            // 
            // ReaderConnection
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDisconnect);
            Controls.Add(dispStatus);
            Controls.Add(txtStatus);
            Controls.Add(btnConnect);
            Controls.Add(inputPort);
            Controls.Add(txtPort);
            Controls.Add(inputIp);
            Controls.Add(txtIP);
            Controls.Add(heading);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Name = "ReaderConnection";
            Text = "ReaderConnection";
            WindowState = FormWindowState.Maximized;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label heading;
        private Label txtIP;
        private TextBox inputIp;
        private Label txtPort;
        private TextBox inputPort;
        private Button btnConnect;
        private Label txtStatus;
        private Label dispStatus;
        private Button btnDisconnect;
        private MenuStrip menuStrip;
        private ToolStripMenuItem back;
        private ToolStripMenuItem epcTable;
        private ToolStripMenuItem buzzer;
    }
}