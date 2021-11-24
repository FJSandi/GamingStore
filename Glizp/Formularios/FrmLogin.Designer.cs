namespace Glizp.Formularios
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.TitleBar = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BtnClose = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtNombreUsuario = new System.Windows.Forms.TextBox();
            this.TxtContrasenna = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.BtnRegistro = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnVer = new System.Windows.Forms.Button();
            this.TitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleBar
            // 
            this.TitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.TitleBar.Controls.Add(this.pictureBox2);
            this.TitleBar.Controls.Add(this.BtnClose);
            this.TitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleBar.Location = new System.Drawing.Point(0, 0);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.Size = new System.Drawing.Size(414, 50);
            this.TitleBar.TabIndex = 0;
            this.TitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseDown);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Glizp.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(159, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(112, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // BtnClose
            // 
            this.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClose.Image = global::Glizp.Properties.Resources.Close_Icon;
            this.BtnClose.Location = new System.Drawing.Point(383, 12);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(19, 18);
            this.BtnClose.TabIndex = 2;
            this.BtnClose.TabStop = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 521);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(414, 15);
            this.panel1.TabIndex = 1;
            // 
            // TxtNombreUsuario
            // 
            this.TxtNombreUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.TxtNombreUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtNombreUsuario.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombreUsuario.ForeColor = System.Drawing.Color.White;
            this.TxtNombreUsuario.Location = new System.Drawing.Point(42, 229);
            this.TxtNombreUsuario.Name = "TxtNombreUsuario";
            this.TxtNombreUsuario.Size = new System.Drawing.Size(339, 24);
            this.TxtNombreUsuario.TabIndex = 2;
            // 
            // TxtContrasenna
            // 
            this.TxtContrasenna.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.TxtContrasenna.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtContrasenna.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtContrasenna.ForeColor = System.Drawing.Color.White;
            this.TxtContrasenna.Location = new System.Drawing.Point(42, 290);
            this.TxtContrasenna.Name = "TxtContrasenna";
            this.TxtContrasenna.Size = new System.Drawing.Size(306, 24);
            this.TxtContrasenna.TabIndex = 3;
            this.TxtContrasenna.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(42, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre de usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(42, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Contraseña";
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(159)))), ((int)(((byte)(230)))));
            this.BtnLogin.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnLogin.FlatAppearance.BorderSize = 0;
            this.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.ForeColor = System.Drawing.Color.White;
            this.BtnLogin.Location = new System.Drawing.Point(45, 349);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(336, 51);
            this.BtnLogin.TabIndex = 6;
            this.BtnLogin.Text = "Iniciar sesión";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(156, 502);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(123, 16);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Olvidé la contraseña";
            // 
            // BtnRegistro
            // 
            this.BtnRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(170)))), ((int)(((byte)(65)))));
            this.BtnRegistro.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnRegistro.FlatAppearance.BorderSize = 0;
            this.BtnRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegistro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistro.ForeColor = System.Drawing.Color.White;
            this.BtnRegistro.Location = new System.Drawing.Point(159, 416);
            this.BtnRegistro.Name = "BtnRegistro";
            this.BtnRegistro.Size = new System.Drawing.Size(123, 41);
            this.BtnRegistro.TabIndex = 8;
            this.BtnRegistro.Text = "Registro";
            this.BtnRegistro.UseVisualStyleBackColor = false;
            this.BtnRegistro.Click += new System.EventHandler(this.BtnRegistro_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Glizp.Properties.Resources.group_xxl;
            this.pictureBox1.Location = new System.Drawing.Point(113, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // BtnVer
            // 
            this.BtnVer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnVer.BackgroundImage")));
            this.BtnVer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnVer.FlatAppearance.BorderSize = 0;
            this.BtnVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVer.Location = new System.Drawing.Point(354, 289);
            this.BtnVer.Name = "BtnVer";
            this.BtnVer.Size = new System.Drawing.Size(27, 25);
            this.BtnVer.TabIndex = 17;
            this.BtnVer.Text = "button1";
            this.BtnVer.UseVisualStyleBackColor = true;
            this.BtnVer.Click += new System.EventHandler(this.BtnVer_Click);
            // 
            // FrmLogin
            // 
            this.AcceptButton = this.BtnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(60)))), ((int)(((byte)(65)))));
            this.CancelButton = this.BtnRegistro;
            this.ClientSize = new System.Drawing.Size(414, 536);
            this.Controls.Add(this.BtnVer);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnRegistro);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtContrasenna);
            this.Controls.Add(this.TxtNombreUsuario);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLogin";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogin";
            this.TitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TitleBar;
        private System.Windows.Forms.PictureBox BtnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TxtNombreUsuario;
        private System.Windows.Forms.TextBox TxtContrasenna;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button BtnRegistro;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button BtnVer;
    }
}