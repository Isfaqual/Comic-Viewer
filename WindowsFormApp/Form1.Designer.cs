using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Point startingPoint = Point.Empty;
        private Point movingPoint = Point.Empty;
        private bool panning = false;

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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.pictureBoxLeft = new System.Windows.Forms.PictureBox();
            this.pictureBoxRight = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).BeginInit();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeft)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(965, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openImageToolStripMenuItem});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // openImageToolStripMenuItem
            // 
            this.openImageToolStripMenuItem.Name = "openImageToolStripMenuItem";
            this.openImageToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.openImageToolStripMenuItem.Text = "Open Image";
            this.openImageToolStripMenuItem.Click += new System.EventHandler(this.openImageToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // mainSplitContainer
            // 
            this.mainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplitContainer.Location = new System.Drawing.Point(0, 24);
            this.mainSplitContainer.Name = "mainSplitContainer";
            this.mainSplitContainer.Size = new System.Drawing.Size(965, 603);
            this.mainSplitContainer.SplitterDistance = (this.mainSplitContainer.Size.Width / 2);
            this.mainSplitContainer.TabIndex = 3;
            this.mainSplitContainer.IsSplitterFixed = true;
            // 
            // mainSplitContainer.Panel1
            // 
            this.mainSplitContainer.Panel1.Controls.Add(this.pictureBoxLeft);
            this.mainSplitContainer.Panel2.Controls.Add(this.pictureBoxRight);
            // 
            // pictureBoxLeft
            // 
            this.pictureBoxLeft.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxLeft.Name = "pictureBoxLeft";
            this.pictureBoxLeft.Size = this.mainSplitContainer.Panel1.Size;
            this.pictureBoxLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxLeft.TabIndex = 0;
            this.pictureBoxLeft.TabStop = false;
            this.pictureBoxLeft.Click += new System.EventHandler(this.pictureBoxLeft_Click);
            this.pictureBoxLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pictureBoxLeft.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            this.pictureBoxLeft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            // 
            // pictureBoxRight
            //
            this.pictureBoxRight.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxRight.Name = "pictureBoxRight";
            this.pictureBoxRight.Size = this.mainSplitContainer.Panel2.Size;
            this.pictureBoxRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxRight.TabIndex = 0;
            this.pictureBoxRight.TabStop = false;
            this.pictureBoxRight.Click += new System.EventHandler(this.pictureBoxLeft_Click);
            this.pictureBoxRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pictureBoxRight.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            this.pictureBoxRight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 627);
            this.Controls.Add(this.mainSplitContainer);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            this.mainSplitContainer.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).EndInit();
            this.mainSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeft)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                panning = true;
                startingPoint = e.Location;
            }
        }

        void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            panning = false;
            //
            //Limits panning to edge of image
            //
            if (left < mainSplitContainer.Panel1.Width - pictureBoxLeft.Image.Width) { left = mainSplitContainer.Panel1.Width - pictureBoxLeft.Image.Width; }
            if (left > 0) { left = 0; }
            if (top < mainSplitContainer.Panel1.Height - pictureBoxLeft.Image.Height) { top = mainSplitContainer.Panel1.Height - pictureBoxLeft.Image.Height; }
            if (top > 0) { top = 0; }
            newLocation = new Point(left, top);
            pictureBoxLeft.Location = newLocation;
        }

        void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (panning)
            {
                left = pictureBoxLeft.Left + e.Location.X - startingPoint.X;
                top = pictureBoxLeft.Top + e.Location.Y - startingPoint.Y;
                newLocation = new Point(left, top);
                pictureBoxLeft.Location = newLocation;
            }
        }

        void panel_MouseWheel(object sender, MouseEventArgs e)
        {
            msg(e.Delta.ToString());
        }

        void pictureBox_KeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Oemplus) {
                msg("Pressed +");
            } 
            if (e.KeyCode == Keys.OemMinus)
            {
                msg("Pressed -");
            }
        }

        void msg(string s)
        {
            System.Diagnostics.Debug.WriteLine(s);
        }

        private Point newLocation;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openImageToolStripMenuItem;
        private int left, top;
        private SplitContainer mainSplitContainer;
        private PictureBox pictureBoxLeft;
        private PictureBox pictureBoxRight;
    }
}

