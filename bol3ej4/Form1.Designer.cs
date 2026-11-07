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
            this.lstLista1 = new System.Windows.Forms.ListBox();
            this.lstLista2 = new System.Windows.Forms.ListBox();
            this.btnAnhadir = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnTraspasa = new System.Windows.Forms.Button();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.lblInformativa1 = new System.Windows.Forms.Label();
            this.lblInformativa2 = new System.Windows.Forms.Label();
            this.rbListBox1 = new System.Windows.Forms.RadioButton();
            this.rbListBox2 = new System.Windows.Forms.RadioButton();
            this.rb1a2 = new System.Windows.Forms.RadioButton();
            this.rb2a1 = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstLista1
            // 
            this.lstLista1.FormattingEnabled = true;
            this.lstLista1.ItemHeight = 16;
            this.lstLista1.Location = new System.Drawing.Point(197, 60);
            this.lstLista1.MultiColumn = true;
            this.lstLista1.Name = "lstLista1";
            this.lstLista1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstLista1.Size = new System.Drawing.Size(120, 84);
            this.lstLista1.TabIndex = 0;
            this.lstLista1.SelectedIndexChanged += new System.EventHandler(this.lstLista1_IndiceCambiado);
            // 
            // lstLista2
            // 
            this.lstLista2.FormattingEnabled = true;
            this.lstLista2.ItemHeight = 16;
            this.lstLista2.Location = new System.Drawing.Point(390, 60);
            this.lstLista2.Name = "lstLista2";
            this.lstLista2.Size = new System.Drawing.Size(120, 84);
            this.lstLista2.TabIndex = 1;
            // 
            // btnAnhadir
            // 
            this.btnAnhadir.Location = new System.Drawing.Point(180, 220);
            this.btnAnhadir.Name = "btnAnhadir";
            this.btnAnhadir.Size = new System.Drawing.Size(75, 23);
            this.btnAnhadir.TabIndex = 3;
            this.btnAnhadir.Text = "Añadir ";
            this.btnAnhadir.UseVisualStyleBackColor = true;
            this.btnAnhadir.Click += new System.EventHandler(this.BtnAnhadir_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(316, 219);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(75, 23);
            this.btnQuitar.TabIndex = 4;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.BtnQuitar_Click);
            // 
            // btnTraspasa
            // 
            this.btnTraspasa.Location = new System.Drawing.Point(464, 218);
            this.btnTraspasa.Name = "btnTraspasa";
            this.btnTraspasa.Size = new System.Drawing.Size(75, 23);
            this.btnTraspasa.TabIndex = 5;
            this.btnTraspasa.Text = "Traspasar";
            this.btnTraspasa.UseVisualStyleBackColor = true;
            this.btnTraspasa.Click += new System.EventHandler(this.BtnTraspasa_Click);
            // 
            // txtTexto
            // 
            this.txtTexto.Location = new System.Drawing.Point(301, 165);
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(100, 22);
            this.txtTexto.TabIndex = 2;
            // 
            // lblInformativa1
            // 
            this.lblInformativa1.AutoSize = true;
            this.lblInformativa1.Location = new System.Drawing.Point(246, 281);
            this.lblInformativa1.Name = "lblInformativa1";
            this.lblInformativa1.Size = new System.Drawing.Size(93, 16);
            this.lblInformativa1.TabIndex = 6;
            this.lblInformativa1.Text = "lblInformativa1";
            // 
            // lblInformativa2
            // 
            this.lblInformativa2.AutoSize = true;
            this.lblInformativa2.Location = new System.Drawing.Point(451, 281);
            this.lblInformativa2.Name = "lblInformativa2";
            this.lblInformativa2.Size = new System.Drawing.Size(93, 16);
            this.lblInformativa2.TabIndex = 7;
            this.lblInformativa2.Text = "lblInformativa2";
            // 
            // rbListBox1
            // 
            this.rbListBox1.AutoSize = true;
            this.rbListBox1.Location = new System.Drawing.Point(25, 21);
            this.rbListBox1.Name = "rbListBox1";
            this.rbListBox1.Size = new System.Drawing.Size(63, 20);
            this.rbListBox1.TabIndex = 0;
            this.rbListBox1.TabStop = true;
            this.rbListBox1.Text = "Lista1";
            this.rbListBox1.UseVisualStyleBackColor = true;
            // 
            // rbListBox2
            // 
            this.rbListBox2.AutoSize = true;
            this.rbListBox2.Location = new System.Drawing.Point(157, 21);
            this.rbListBox2.Name = "rbListBox2";
            this.rbListBox2.Size = new System.Drawing.Size(63, 20);
            this.rbListBox2.TabIndex = 1;
            this.rbListBox2.TabStop = true;
            this.rbListBox2.Text = "Lista2";
            this.rbListBox2.UseVisualStyleBackColor = true;
            // 
            // rb1a2
            // 
            this.rb1a2.AutoSize = true;
            this.rb1a2.Location = new System.Drawing.Point(37, 21);
            this.rb1a2.Name = "rb1a2";
            this.rb1a2.Size = new System.Drawing.Size(56, 20);
            this.rb1a2.TabIndex = 0;
            this.rb1a2.TabStop = true;
            this.rb1a2.Text = "1 a 2";
            this.rb1a2.UseVisualStyleBackColor = true;
            // 
            // rb2a1
            // 
            this.rb2a1.AutoSize = true;
            this.rb2a1.Location = new System.Drawing.Point(175, 21);
            this.rb2a1.Name = "rb2a1";
            this.rb2a1.Size = new System.Drawing.Size(56, 20);
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
            this.groupBox1.Location = new System.Drawing.Point(110, 317);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(275, 48);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Eliminar de:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb2a1);
            this.groupBox2.Controls.Add(this.rb1a2);
            this.groupBox2.Location = new System.Drawing.Point(412, 317);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(267, 49);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Traspasar de:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Introduce el texto:";
            // 
            // bol3ej4
            // 
            this.AcceptButton = this.btnAnhadir;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblInformativa2);
            this.Controls.Add(this.lblInformativa1);
            this.Controls.Add(this.txtTexto);
            this.Controls.Add(this.btnTraspasa);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnAnhadir);
            this.Controls.Add(this.lstLista2);
            this.Controls.Add(this.lstLista1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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

        private System.Windows.Forms.ListBox lstLista1;
        private System.Windows.Forms.ListBox lstLista2;
        private System.Windows.Forms.Button btnAnhadir;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnTraspasa;
        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.Label lblInformativa1;
        private System.Windows.Forms.Label lblInformativa2;
        private System.Windows.Forms.RadioButton rbListBox1;
        private System.Windows.Forms.RadioButton rbListBox2;
        private System.Windows.Forms.RadioButton rb1a2;
        private System.Windows.Forms.RadioButton rb2a1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label3;
    }
}

