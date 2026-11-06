namespace bol3ej3
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ajustarAImagenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noDeformarseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(482, 316);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajustarAImagenToolStripMenuItem,
            this.noDeformarseToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(191, 52);
            // 
            // ajustarAImagenToolStripMenuItem
            // 
            this.ajustarAImagenToolStripMenuItem.Name = "ajustarAImagenToolStripMenuItem";
            this.ajustarAImagenToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.ajustarAImagenToolStripMenuItem.Text = "Ajustar a imagen";
            this.ajustarAImagenToolStripMenuItem.Click += new System.EventHandler(this.ajustarAImagenToolStripMenuItem_Click);
            // 
            // noDeformarseToolStripMenuItem
            // 
            this.noDeformarseToolStripMenuItem.Name = "noDeformarseToolStripMenuItem";
            this.noDeformarseToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.noDeformarseToolStripMenuItem.Text = "No deformarse";
            this.noDeformarseToolStripMenuItem.Click += new System.EventHandler(this.noDeformarseToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(482, 316);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ajustarAImagenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noDeformarseToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
    }
}