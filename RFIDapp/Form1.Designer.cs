namespace RFIDapp
{
    partial class Index
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip = new MenuStrip();
            readerConnection = new ToolStripMenuItem();
            epcTable = new ToolStripMenuItem();
            buzzer = new ToolStripMenuItem();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.BackColor = SystemColors.ActiveCaption;
            menuStrip.ImageScalingSize = new Size(24, 24);
            menuStrip.Items.AddRange(new ToolStripItem[] { readerConnection, epcTable, buzzer });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(800, 33);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip1";
            // 
            // readerConnection
            // 
            readerConnection.Name = "readerConnection";
            readerConnection.Size = new Size(174, 29);
            readerConnection.Text = "Reader connection";
            readerConnection.Click += readerConnectionToolStripMenuItem_Click;
            // 
            // epcTable
            // 
            epcTable.Name = "epcTable";
            epcTable.Size = new Size(102, 29);
            epcTable.Text = "EPC table";
            epcTable.Click += ePCTableToolStripMenuItem_Click;
            // 
            // buzzer
            // 
            buzzer.Name = "buzzer";
            buzzer.Size = new Size(79, 29);
            buzzer.Text = "Buzzer";
            buzzer.Click += buzzerToolStripMenuItem_Click;
            // 
            // Index
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Name = "Index";
            Text = "Wellcome";
            WindowState = FormWindowState.Maximized;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem readerConnection;
        private ToolStripMenuItem epcTable;
        private ToolStripMenuItem buzzer;
    }
}
