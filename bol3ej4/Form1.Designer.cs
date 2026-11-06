namespace bol3ej4
{
    partial class bol3ej4
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bol3ej4));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btnAnhadir = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnTraspasa = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbListBox1 = new System.Windows.Forms.RadioButton();
            this.rbListBox2 = new System.Windows.Forms.RadioButton();
            this.rb1a2 = new System.Windows.Forms.RadioButton();
            this.rb2a1 = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(222, 75);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBox1.MultiColumn = true;
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox1.Size = new System.Drawing.Size(134, 104);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(439, 75);
            this.listBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(134, 104);
            this.listBox2.TabIndex = 1;
            // 
            // btnAnhadir
            // 
            this.btnAnhadir.Location = new System.Drawing.Point(202, 275);
            this.btnAnhadir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAnhadir.Name = "btnAnhadir";
            this.btnAnhadir.Size = new System.Drawing.Size(84, 29);
            this.btnAnhadir.TabIndex = 3;
            this.btnAnhadir.Text = "Añadir ";
            this.toolTip1.SetToolTip(this.btnAnhadir, "Añadir Texto");
            this.btnAnhadir.UseVisualStyleBackColor = true;
            this.btnAnhadir.Click += new System.EventHandler(this.BtnAnhadir_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(356, 274);
            this.btnQuitar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(84, 29);
            this.btnQuitar.TabIndex = 4;
            this.btnQuitar.Text = "Quitar";
            this.toolTip1.SetToolTip(this.btnQuitar, "Quitar texto");
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.BtnQuitar_Click);
            // 
            // btnTraspasa
            // 
            this.btnTraspasa.Location = new System.Drawing.Point(522, 272);
            this.btnTraspasa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTraspasa.Name = "btnTraspasa";
            this.btnTraspasa.Size = new System.Drawing.Size(84, 29);
            this.btnTraspasa.TabIndex = 5;
            this.btnTraspasa.Text = "Traspasar";
            this.toolTip1.SetToolTip(this.btnTraspasa, "Traspasar texto");
            this.btnTraspasa.UseVisualStyleBackColor = true;
            this.btnTraspasa.Click += new System.EventHandler(this.BtnTraspasa_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(339, 206);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(112, 26);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(277, 351);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "label 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(507, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            // 
            // rbListBox1
            // 
            this.rbListBox1.AutoSize = true;
            this.rbListBox1.Location = new System.Drawing.Point(28, 26);
            this.rbListBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbListBox1.Name = "rbListBox1";
            this.rbListBox1.Size = new System.Drawing.Size(89, 24);
            this.rbListBox1.TabIndex = 0;
            this.rbListBox1.TabStop = true;
            this.rbListBox1.Text = "listBox1";
            this.rbListBox1.UseVisualStyleBackColor = true;
            // 
            // rbListBox2
            // 
            this.rbListBox2.AutoSize = true;
            this.rbListBox2.Location = new System.Drawing.Point(177, 26);
            this.rbListBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbListBox2.Name = "rbListBox2";
            this.rbListBox2.Size = new System.Drawing.Size(89, 24);
            this.rbListBox2.TabIndex = 1;
            this.rbListBox2.TabStop = true;
            this.rbListBox2.Text = "listBox2";
            this.rbListBox2.UseVisualStyleBackColor = true;
            // 
            // rb1a2
            // 
            this.rb1a2.AutoSize = true;
            this.rb1a2.Location = new System.Drawing.Point(42, 26);
            this.rb1a2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rb1a2.Name = "rb1a2";
            this.rb1a2.Size = new System.Drawing.Size(69, 24);
            this.rb1a2.TabIndex = 0;
            this.rb1a2.TabStop = true;
            this.rb1a2.Text = "1 a 2";
            this.rb1a2.UseVisualStyleBackColor = true;
            // 
            // rb2a1
            // 
            this.rb2a1.AutoSize = true;
            this.rb2a1.Location = new System.Drawing.Point(197, 26);
            this.rb2a1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rb2a1.Name = "rb2a1";
            this.rb2a1.Size = new System.Drawing.Size(69, 24);
            this.rb2a1.TabIndex = 1;
            this.rb2a1.TabStop = true;
            this.rb2a1.Text = "2 a 1";
            this.rb2a1.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbListBox1);
            this.groupBox1.Controls.Add(this.rbListBox2);
            this.groupBox1.Location = new System.Drawing.Point(124, 396);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 60);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb2a1);
            this.groupBox2.Controls.Add(this.rb1a2);
            this.groupBox2.Location = new System.Drawing.Point(463, 396);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 61);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // bol3ej4
            // 
            this.AcceptButton = this.btnAnhadir;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnTraspasa);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnAnhadir);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "bol3ej4";
            this.Text = "bol3ej4";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btnAnhadir;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnTraspasa;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbListBox1;
        private System.Windows.Forms.RadioButton rbListBox2;
        private System.Windows.Forms.RadioButton rb1a2;
        private System.Windows.Forms.RadioButton rb2a1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

