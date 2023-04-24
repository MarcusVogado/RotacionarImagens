namespace Image_Rotator
{
    partial class Form1
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
            this.Menu1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OFD1 = new System.Windows.Forms.OpenFileDialog();
            this.IMG_Path = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboRotacionar = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboSalvarFormato = new System.Windows.Forms.ComboBox();
            this.Pic_IMG = new System.Windows.Forms.PictureBox();
            this.SFD1 = new System.Windows.Forms.SaveFileDialog();
            this.Menu1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_IMG)).BeginInit();
            this.SuspendLayout();
            // 
            // Menu1
            // 
            this.Menu1.BackColor = System.Drawing.Color.White;
            this.Menu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.Menu1.Location = new System.Drawing.Point(0, 0);
            this.Menu1.Name = "Menu1";
            this.Menu1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.Menu1.Size = new System.Drawing.Size(876, 24);
            this.Menu1.TabIndex = 0;
            this.Menu1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.fileToolStripMenuItem.Text = "Arquivo";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.openToolStripMenuItem.Text = "&Abrir";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.saveToolStripMenuItem.Text = "&Salvar";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.exitToolStripMenuItem.Text = "Sa&ir";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // IMG_Path
            // 
            this.IMG_Path.Location = new System.Drawing.Point(79, 19);
            this.IMG_Path.Name = "IMG_Path";
            this.IMG_Path.ReadOnly = true;
            this.IMG_Path.Size = new System.Drawing.Size(327, 25);
            this.IMG_Path.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Arquivo :";
            // 
            // cboRotacionar
            // 
            this.cboRotacionar.FormattingEnabled = true;
            this.cboRotacionar.Items.AddRange(new object[] {
            "180 Flip None",
            "180 Flip X",
            "180 Flip XY",
            "180 Flip Y",
            "270 Flip None",
            "270 Flip X",
            "270 Flip XY",
            "270 Flip Y",
            "90 Flip None",
            "90 Flip X",
            "90 Flip XY",
            "90 Flip Y",
            "None Flip None",
            "None Flip X",
            "None Flip XY",
            "None Flip Y",
            ""});
            this.cboRotacionar.Location = new System.Drawing.Point(500, 18);
            this.cboRotacionar.Name = "cboRotacionar";
            this.cboRotacionar.Size = new System.Drawing.Size(143, 25);
            this.cboRotacionar.TabIndex = 3;
            this.cboRotacionar.SelectedIndexChanged += new System.EventHandler(this.cboRotacionar_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(412, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Rotacionar : ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cboSalvarFormato);
            this.groupBox1.Controls.Add(this.IMG_Path);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cboRotacionar);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(5, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(859, 52);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configurações:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(649, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Salvar no formato : ";
            // 
            // cboSalvarFormato
            // 
            this.cboSalvarFormato.FormattingEnabled = true;
            this.cboSalvarFormato.Items.AddRange(new object[] {
            "JPG",
            "BMP",
            "PNG",
            "GIF"});
            this.cboSalvarFormato.Location = new System.Drawing.Point(779, 18);
            this.cboSalvarFormato.Name = "cboSalvarFormato";
            this.cboSalvarFormato.Size = new System.Drawing.Size(74, 25);
            this.cboSalvarFormato.TabIndex = 5;
            this.cboSalvarFormato.Text = "JPG";
            // 
            // Pic_IMG
            // 
            this.Pic_IMG.BackColor = System.Drawing.Color.White;
            this.Pic_IMG.Location = new System.Drawing.Point(5, 85);
            this.Pic_IMG.Name = "Pic_IMG";
            this.Pic_IMG.Size = new System.Drawing.Size(419, 356);
            this.Pic_IMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_IMG.TabIndex = 6;
            this.Pic_IMG.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(876, 453);
            this.Controls.Add(this.Pic_IMG);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Menu1);
            this.MainMenuStrip = this.Menu1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rotacionar Imagens";
            this.Menu1.ResumeLayout(false);
            this.Menu1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_IMG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog OFD1;
        private System.Windows.Forms.TextBox IMG_Path;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboRotacionar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox Pic_IMG;
        private System.Windows.Forms.SaveFileDialog SFD1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboSalvarFormato;
    }
}

