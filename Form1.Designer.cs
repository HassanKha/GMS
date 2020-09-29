﻿namespace WindowsFormsApp1
{
    partial class GymManagmentSystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GymManagmentSystem));
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip2.Font = new System.Drawing.Font("Segoe Script", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.menuStrip2.GripMargin = new System.Windows.Forms.Padding(2);
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.MaximumSize = new System.Drawing.Size(5625, 5000);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(17, 3, 0, 3);
            this.menuStrip2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip2.Size = new System.Drawing.Size(1521, 106);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip1";
            this.menuStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip2_ItemClicked);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(223, 100);
            this.toolStripMenuItem1.Text = "New member";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.addNewMember);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.toolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem2.Image")));
            this.toolStripMenuItem2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(207, 100);
            this.toolStripMenuItem2.Text = "Delete member";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.deleteMember);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.CheckOnClick = true;
            this.toolStripMenuItem3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.toolStripMenuItem3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem3.Image")));
            this.toolStripMenuItem3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(226, 100);
            this.toolStripMenuItem3.Text = "Search member";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.searchMember);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.toolStripMenuItem4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem4.Image")));
            this.toolStripMenuItem4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(155, 100);
            this.toolStripMenuItem4.Text = "Exit";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.exitAppliction);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(32758, 32729);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(125, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "new member";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Location = new System.Drawing.Point(14, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 129);
            this.button1.TabIndex = 1;
            this.button1.Text = "DeletedList";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GymManagmentSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1521, 525);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip2);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.MainMenuStrip = this.menuStrip2;
            this.Name = "GymManagmentSystem";
            this.Text = "GymManagmentSystem";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.Button button1;
    }
}

