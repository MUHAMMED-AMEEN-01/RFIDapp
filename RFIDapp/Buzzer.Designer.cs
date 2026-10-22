namespace RFIDapp
{
    partial class Buzzer
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
            btnActive = new Button();
            menuStrip = new MenuStrip();
            back = new ToolStripMenuItem();
            displayStatus = new Label();
            txtStatus = new Label();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // btnActive
            // 
            btnActive.Location = new Point(235, 33);
            btnActive.Name = "btnActive";
            btnActive.Size = new Size(112, 34);
            btnActive.TabIndex = 1;
            btnActive.Text = "Activate";
            btnActive.UseVisualStyleBackColor = true;
            btnActive.Click += button1_Click;
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(24, 24);
            menuStrip.Items.AddRange(new ToolStripItem[] { back });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(800, 33);
            menuStrip.TabIndex = 3;
            menuStrip.Text = "menuStrip1";
            // 
            // back
            // 
            back.Name = "back";
            back.Size = new Size(44, 29);
            back.Text = "←";
            back.Click += toolStripMenuItem1_Click;
            // 
            // displayStatus
            // 
            displayStatus.AutoSize = true;
            displayStatus.Location = new Point(257, 129);
            displayStatus.Name = "displayStatus";
            displayStatus.Size = new Size(59, 25);
            displayStatus.TabIndex = 5;
            displayStatus.Text = "label2";
            // 
            // txtStatus
            // 
            txtStatus.AutoSize = true;
            txtStatus.Location = new Point(110, 129);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(124, 25);
            txtStatus.TabIndex = 4;
            txtStatus.Text = "Buzzer status :";
            // 
            // Buzzer
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(displayStatus);
            Controls.Add(txtStatus);
            Controls.Add(btnActive);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Name = "Buzzer";
            Text = "Buzzer";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnActive;
        private MenuStrip menuStrip;
        private ToolStripMenuItem back;
        private Label displayStatus;
        private Label txtStatus;
    }
}