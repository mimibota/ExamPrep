namespace Exam.Views
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
            this.menuStripExit = new System.Windows.Forms.MenuStrip();
            this.fiileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonManage = new System.Windows.Forms.Button();
            this.menuStripExit.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripExit
            // 
            this.menuStripExit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fiileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStripExit.Location = new System.Drawing.Point(0, 0);
            this.menuStripExit.Name = "menuStripExit";
            this.menuStripExit.Size = new System.Drawing.Size(800, 24);
            this.menuStripExit.TabIndex = 0;
            this.menuStripExit.Text = "Exit";
            // 
            // fiileToolStripMenuItem
            // 
            this.fiileToolStripMenuItem.Name = "fiileToolStripMenuItem";
            this.fiileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fiileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitApplicationToolStripMenuItem});
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // exitApplicationToolStripMenuItem
            // 
            this.exitApplicationToolStripMenuItem.Name = "exitApplicationToolStripMenuItem";
            this.exitApplicationToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.exitApplicationToolStripMenuItem.Text = "Exit Application";
            this.exitApplicationToolStripMenuItem.Click += new System.EventHandler(this.exitApplicationToolStripMenuItem_Click);
            // 
            // buttonManage
            // 
            this.buttonManage.Location = new System.Drawing.Point(251, 77);
            this.buttonManage.Name = "buttonManage";
            this.buttonManage.Size = new System.Drawing.Size(208, 60);
            this.buttonManage.TabIndex = 1;
            this.buttonManage.Text = "Manage Courses";
            this.buttonManage.UseVisualStyleBackColor = true;
            this.buttonManage.Click += new System.EventHandler(this.buttonManage_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonManage);
            this.Controls.Add(this.menuStripExit);
            this.MainMenuStrip = this.menuStripExit;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.menuStripExit.ResumeLayout(false);
            this.menuStripExit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripExit;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fiileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.Button buttonManage;
    }
}

