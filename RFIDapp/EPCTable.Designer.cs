namespace RFIDapp
{
    partial class EPCTable
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
            tableEpc = new DataGridView();
            btnStop = new Button();
            btnClear = new Button();
            btnStart = new Button();
            menuStrip = new MenuStrip();
            back = new ToolStripMenuItem();
            EPC = new DataGridViewTextBoxColumn();
            antennaId = new DataGridViewTextBoxColumn();
            lastSeen = new DataGridViewTextBoxColumn();
            readCount = new DataGridViewTextBoxColumn();
            RSSI = new DataGridViewTextBoxColumn();
            timestamp = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)tableEpc).BeginInit();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // heading
            // 
            heading.AutoSize = true;
            heading.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline);
            heading.Location = new Point(304, 50);
            heading.Name = "heading";
            heading.Size = new Size(94, 25);
            heading.TabIndex = 0;
            heading.Text = "EPC Table";
            // 
            // tableEpc
            // 
            tableEpc.AllowUserToAddRows = false;
            tableEpc.AllowUserToDeleteRows = false;
            tableEpc.AllowUserToOrderColumns = true;
            tableEpc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableEpc.Columns.AddRange(new DataGridViewColumn[] { EPC, antennaId, lastSeen, readCount, RSSI, timestamp });
            tableEpc.Location = new Point(12, 127);
            tableEpc.Name = "tableEpc";
            tableEpc.ReadOnly = true;
            tableEpc.RowHeadersWidth = 62;
            tableEpc.Size = new Size(876, 225);
            tableEpc.TabIndex = 1;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(152, 369);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(140, 34);
            btnStop.TabIndex = 2;
            btnStop.Text = "Stop Reading";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += button1_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(327, 375);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 34);
            btnClear.TabIndex = 3;
            btnClear.Text = "Clear Table";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += button2_Click;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(286, 87);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(112, 34);
            btnStart.TabIndex = 4;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += button3_Click;
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(24, 24);
            menuStrip.Items.AddRange(new ToolStripItem[] { back });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(919, 33);
            menuStrip.TabIndex = 5;
            menuStrip.Text = "menuStrip1";
            // 
            // back
            // 
            back.Name = "back";
            back.Size = new Size(44, 29);
            back.Text = "←";
            back.Click += toolStripMenuItem1_Click;
            // 
            // EPC
            // 
            EPC.HeaderText = "EPC";
            EPC.MinimumWidth = 8;
            EPC.Name = "EPC";
            EPC.ReadOnly = true;
            EPC.Width = 150;
            // 
            // antennaId
            // 
            antennaId.HeaderText = "Antenna ID";
            antennaId.MinimumWidth = 8;
            antennaId.Name = "antennaId";
            antennaId.ReadOnly = true;
            antennaId.Width = 150;
            // 
            // lastSeen
            // 
            lastSeen.HeaderText = "Last Seen";
            lastSeen.MinimumWidth = 8;
            lastSeen.Name = "lastSeen";
            lastSeen.ReadOnly = true;
            lastSeen.Width = 150;
            // 
            // readCount
            // 
            readCount.HeaderText = "Read Count";
            readCount.MinimumWidth = 8;
            readCount.Name = "readCount";
            readCount.ReadOnly = true;
            readCount.Width = 75;
            // 
            // RSSI
            // 
            RSSI.HeaderText = "RSSI";
            RSSI.MinimumWidth = 8;
            RSSI.Name = "RSSI";
            RSSI.ReadOnly = true;
            RSSI.Width = 150;
            // 
            // timestamp
            // 
            timestamp.HeaderText = "Timestamp";
            timestamp.MinimumWidth = 8;
            timestamp.Name = "timestamp";
            timestamp.ReadOnly = true;
            timestamp.Width = 150;
            // 
            // EPCTable
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg;
            ClientSize = new Size(919, 450);
            Controls.Add(btnStart);
            Controls.Add(btnClear);
            Controls.Add(btnStop);
            Controls.Add(tableEpc);
            Controls.Add(heading);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Name = "EPCTable";
            Text = "EPCTable";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)tableEpc).EndInit();
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label heading;
        private Button btnStop;
        private Button btnClear;
        private Button btnStart;
        private DataGridView tableEpc;
        private MenuStrip menuStrip;
        private ToolStripMenuItem back;
        private DataGridViewTextBoxColumn EPC;
        private DataGridViewTextBoxColumn antennaId;
        private DataGridViewTextBoxColumn lastSeen;
        private DataGridViewTextBoxColumn readCount;
        private DataGridViewTextBoxColumn RSSI;
        private DataGridViewTextBoxColumn timestamp;
    }
}