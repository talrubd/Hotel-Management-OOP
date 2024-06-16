namespace OOP_System
{
    partial class Forgot_Password
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
            Base = new Panel();
            panel1 = new Panel();
            Base.SuspendLayout();
            SuspendLayout();
            // 
            // Base
            // 
            Base.Controls.Add(panel1);
            Base.Dock = DockStyle.Fill;
            Base.Location = new Point(0, 0);
            Base.Name = "Base";
            Base.Size = new Size(800, 450);
            Base.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Location = new Point(163, 108);
            panel1.Name = "panel1";
            panel1.Size = new Size(464, 263);
            panel1.TabIndex = 0;
            // 
            // Forgot_Password
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Base);
            MaximizeBox = false;
            Name = "Forgot_Password";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Forgot Password";
            WindowState = FormWindowState.Minimized;
            Base.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel Base;
        private Panel panel1;
    }
}