namespace RFIDapp
{
    partial class Form1
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
            menuStrip1 = new MenuStrip();
            readerConnectionToolStripMenuItem = new ToolStripMenuItem();
            ePCTableToolStripMenuItem = new ToolStripMenuItem();
            buzzerToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ActiveCaption;
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { readerConnectionToolStripMenuItem, ePCTableToolStripMenuItem, buzzerToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // readerConnectionToolStripMenuItem
            // 
            readerConnectionToolStripMenuItem.Name = "readerConnectionToolStripMenuItem";
            readerConnectionToolStripMenuItem.Size = new Size(174, 29);
            readerConnectionToolStripMenuItem.Text = "Reader connection";
            readerConnectionToolStripMenuItem.Click += readerConnectionToolStripMenuItem_Click;
            // 
            // ePCTableToolStripMenuItem
            // 
            ePCTableToolStripMenuItem.Name = "ePCTableToolStripMenuItem";
            ePCTableToolStripMenuItem.Size = new Size(102, 29);
            ePCTableToolStripMenuItem.Text = "EPC table";
            ePCTableToolStripMenuItem.Click += ePCTableToolStripMenuItem_Click;
            // 
            // buzzerToolStripMenuItem
            // 
            buzzerToolStripMenuItem.Name = "buzzerToolStripMenuItem";
            buzzerToolStripMenuItem.Size = new Size(79, 29);
            buzzerToolStripMenuItem.Text = "Buzzer";
            buzzerToolStripMenuItem.Click += buzzerToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem readerConnectionToolStripMenuItem;
        private ToolStripMenuItem ePCTableToolStripMenuItem;
        private ToolStripMenuItem buzzerToolStripMenuItem;
    }
}
