namespace Glizp.Formularios
{
    partial class FrmRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistro));
            this.TittleBar = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BtnClose = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtNombreUsuario = new System.Windows.Forms.TextBox();
            this.TxtNombreReal = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtContrasenna1 = new System.Windows.Forms.TextBox();
            this.TxtContrasenna2 = new System.Windows.Forms.TextBox();
            this.BtnRegistrarse = new System.Windows.Forms.Button();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.TittleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TittleBar
            // 
            this.TittleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.TittleBar.Controls.Add(this.pictureBox2);
            this.TittleBar.Controls.Add(this.BtnClose);
            this.TittleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TittleBar.Location = new System.Drawing.Point(0, 0);
            this.TittleBar.Name = "TittleBar";
            this.TittleBar.Size = new System.Drawing.Size(448, 50);
            this.TittleBar.TabIndex = 0;
            this.TittleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TittleBar_MouseDown);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Glizp.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(187, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(112, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // BtnClose
            // 
            this.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClose.Image = global::Glizp.Properties.Resources.Close_Icon;
            this.BtnClose.Location = new System.Drawing.Point(417, 12);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(19, 18);
            this.BtnClose.TabIndex = 10;
            this.BtnClose.TabStop = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 558);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(448, 15);
            this.panel1.TabIndex = 1;
            // 
            // TxtNombreUsuario
            // 
            this.TxtNombreUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.TxtNombreUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtNombreUsuario.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombreUsuario.ForeColor = System.Drawing.Color.White;
            this.TxtNombreUsuario.Location = new System.Drawing.Point(56, 152);
            this.TxtNombreUsuario.Name = "TxtNombreUsuario";
            this.TxtNombreUsuario.Size = new System.Drawing.Size(339, 24);
            this.TxtNombreUsuario.TabIndex = 3;
            this.TxtNombreUsuario.Leave += new System.EventHandler(this.TxtNombreUsuario_Leave);
            // 
            // TxtNombreReal
            // 
            this.TxtNombreReal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.TxtNombreReal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtNombreReal.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombreReal.ForeColor = System.Drawing.Color.White;
            this.TxtNombreReal.Location = new System.Drawing.Point(55, 213);
            this.TxtNombreReal.Name = "TxtNombreReal";
            this.TxtNombreReal.Size = new System.Drawing.Size(339, 24);
            this.TxtNombreReal.TabIndex = 4;
            // 
            // TxtEmail
            // 
            this.TxtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.TxtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtEmail.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmail.ForeColor = System.Drawing.Color.White;
            this.TxtEmail.Location = new System.Drawing.Point(56, 268);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(339, 24);
            this.TxtEmail.TabIndex = 5;
            this.TxtEmail.Leave += new System.EventHandler(this.TxtEmail_Leave);
            // 
            // TxtContrasenna1
            // 
            this.TxtContrasenna1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.TxtContrasenna1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtContrasenna1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtContrasenna1.ForeColor = System.Drawing.Color.White;
            this.TxtContrasenna1.Location = new System.Drawing.Point(56, 327);
            this.TxtContrasenna1.Name = "TxtContrasenna1";
            this.TxtContrasenna1.Size = new System.Drawing.Size(305, 24);
            this.TxtContrasenna1.TabIndex = 6;
            this.TxtContrasenna1.UseSystemPasswordChar = true;
            // 
            // TxtContrasenna2
            // 
            this.TxtContrasenna2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.TxtContrasenna2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtContrasenna2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtContrasenna2.ForeColor = System.Drawing.Color.White;
            this.TxtContrasenna2.Location = new System.Drawing.Point(56, 379);
            this.TxtContrasenna2.Name = "TxtContrasenna2";
            this.TxtContrasenna2.Size = new System.Drawing.Size(305, 24);
            this.TxtContrasenna2.TabIndex = 7;
            this.TxtContrasenna2.UseSystemPasswordChar = true;
            // 
            // BtnRegistrarse
            // 
            this.BtnRegistrarse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(170)))), ((int)(((byte)(65)))));
            this.BtnRegistrarse.FlatAppearance.BorderSize = 0;
            this.BtnRegistrarse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegistrarse.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistrarse.ForeColor = System.Drawing.Color.White;
            this.BtnRegistrarse.Location = new System.Drawing.Point(58, 430);
            this.BtnRegistrarse.Name = "BtnRegistrarse";
            this.BtnRegistrarse.Size = new System.Drawing.Size(336, 51);
            this.BtnRegistrarse.TabIndex = 8;
            this.BtnRegistrarse.Text = "Registrarse";
            this.BtnRegistrarse.UseVisualStyleBackColor = false;
            this.BtnRegistrarse.Click += new System.EventHandler(this.BtnRegistrarse_Click);
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(159)))), ((int)(((byte)(230)))));
            this.BtnLogin.FlatAppearance.BorderSize = 0;
            this.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.ForeColor = System.Drawing.Color.White;
            this.BtnLogin.Location = new System.Drawing.Point(158, 502);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(141, 36);
            this.BtnLogin.TabIndex = 9;
            this.BtnLogin.Text = "Iniciar sesión";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(55, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nombre real";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(55, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nombre de usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(56, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "E-mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(56, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Contraseña";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(56, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Repetir contraseña";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Glizp.Properties.Resources.group_xxl;
            this.pictureBox1.Location = new System.Drawing.Point(158, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(367, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 25);
            this.button1.TabIndex = 16;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(367, 378);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(27, 25);
            this.button2.TabIndex = 17;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(60)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(448, 573);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.BtnRegistrarse);
            this.Controls.Add(this.TxtContrasenna2);
            this.Controls.Add(this.TxtContrasenna1);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.TxtNombreReal);
            this.Controls.Add(this.TxtNombreUsuario);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TittleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRegistro";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmRegistro_FormClosed);
            this.TittleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TittleBar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TxtNombreUsuario;
        private System.Windows.Forms.TextBox TxtNombreReal;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtContrasenna1;
        private System.Windows.Forms.TextBox TxtContrasenna2;
        private System.Windows.Forms.Button BtnRegistrarse;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.PictureBox BtnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}