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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
            label4 = new Label();
            label5 = new Label();
            button2 = new Button();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            ePCTableToolStripMenuItem = new ToolStripMenuItem();
            buzzerToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline);
            label1.Location = new Point(268, 43);
            label1.Name = "label1";
            label1.Size = new Size(174, 25);
            label1.TabIndex = 0;
            label1.Text = "Reader Connection";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 107);
            label2.Name = "label2";
            label2.Size = new Size(95, 25);
            label2.TabIndex = 1;
            label2.Text = "Reader IP :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(145, 109);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 180);
            label3.Name = "label3";
            label3.Size = new Size(114, 25);
            label3.TabIndex = 3;
            label3.Text = "Reader port :";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(185, 181);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(158, 248);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 5;
            button1.Text = "Connect";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(88, 325);
            label4.Name = "label4";
            label4.Size = new Size(69, 25);
            label4.TabIndex = 6;
            label4.Text = "Status :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(171, 329);
            label5.Name = "label5";
            label5.Size = new Size(0, 25);
            label5.TabIndex = 7;
            // 
            // button2
            // 
            button2.Location = new Point(290, 248);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 8;
            button2.Text = "Disconnect";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, ePCTableToolStripMenuItem, buzzerToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 9;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(44, 29);
            toolStripMenuItem1.Text = "←";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // ePCTableToolStripMenuItem
            // 
            ePCTableToolStripMenuItem.Name = "ePCTableToolStripMenuItem";
            ePCTableToolStripMenuItem.Size = new Size(103, 29);
            ePCTableToolStripMenuItem.Text = "EPC Table";
            ePCTableToolStripMenuItem.Click += ePCTableToolStripMenuItem_Click;
            // 
            // buzzerToolStripMenuItem
            // 
            buzzerToolStripMenuItem.Name = "buzzerToolStripMenuItem";
            buzzerToolStripMenuItem.Size = new Size(79, 29);
            buzzerToolStripMenuItem.Text = "Buzzer";
            buzzerToolStripMenuItem.Click += buzzerToolStripMenuItem_Click;
            // 
            // ReaderConnection
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "ReaderConnection";
            Text = "ReaderConnection";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
        private Button button1;
        private Label label4;
        private Label label5;
        private Button button2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem ePCTableToolStripMenuItem;
        private ToolStripMenuItem buzzerToolStripMenuItem;
    }
}