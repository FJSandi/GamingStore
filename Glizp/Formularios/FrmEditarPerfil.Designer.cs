namespace Glizp.Formularios
{
    partial class FrmEditarPerfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditarPerfil));
            this.TittleBar = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BtnClose = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.TxtContrasenna2 = new System.Windows.Forms.TextBox();
            this.TxtContrasenna1 = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtNombreReal = new System.Windows.Forms.TextBox();
            this.TxtNombreUsuario = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnSubirImagen = new System.Windows.Forms.Button();
            this.PbFotoPerfil = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnVer = new System.Windows.Forms.Button();
            this.BtnVer1 = new System.Windows.Forms.Button();
            this.TittleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbFotoPerfil)).BeginInit();
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
            this.TittleBar.Size = new System.Drawing.Size(436, 50);
            this.TittleBar.TabIndex = 16;
            this.TittleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TittleBar_MouseDown);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Glizp.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(167, 12);
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
            this.BtnClose.Location = new System.Drawing.Point(417, 0);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(19, 18);
            this.BtnClose.TabIndex = 10;
            this.BtnClose.TabStop = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(56, 389);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 16);
            this.label5.TabIndex = 28;
            this.label5.Text = "Repetir contraseña";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(56, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "Contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(56, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "E-mail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(55, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "Nombre de usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(55, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Nombre real";
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(170)))), ((int)(((byte)(65)))));
            this.BtnActualizar.FlatAppearance.BorderSize = 0;
            this.BtnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnActualizar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActualizar.ForeColor = System.Drawing.Color.White;
            this.BtnActualizar.Location = new System.Drawing.Point(47, 661);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(336, 51);
            this.BtnActualizar.TabIndex = 23;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = false;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // TxtContrasenna2
            // 
            this.TxtContrasenna2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.TxtContrasenna2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtContrasenna2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtContrasenna2.ForeColor = System.Drawing.Color.White;
            this.TxtContrasenna2.Location = new System.Drawing.Point(56, 405);
            this.TxtContrasenna2.Name = "TxtContrasenna2";
            this.TxtContrasenna2.Size = new System.Drawing.Size(306, 24);
            this.TxtContrasenna2.TabIndex = 22;
            this.TxtContrasenna2.UseSystemPasswordChar = true;
            // 
            // TxtContrasenna1
            // 
            this.TxtContrasenna1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.TxtContrasenna1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtContrasenna1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtContrasenna1.ForeColor = System.Drawing.Color.White;
            this.TxtContrasenna1.Location = new System.Drawing.Point(56, 353);
            this.TxtContrasenna1.Name = "TxtContrasenna1";
            this.TxtContrasenna1.Size = new System.Drawing.Size(306, 24);
            this.TxtContrasenna1.TabIndex = 21;
            this.TxtContrasenna1.UseSystemPasswordChar = true;
            // 
            // TxtEmail
            // 
            this.TxtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.TxtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtEmail.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmail.ForeColor = System.Drawing.Color.White;
            this.TxtEmail.Location = new System.Drawing.Point(56, 294);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(339, 24);
            this.TxtEmail.TabIndex = 20;
            // 
            // TxtNombreReal
            // 
            this.TxtNombreReal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.TxtNombreReal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtNombreReal.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombreReal.ForeColor = System.Drawing.Color.White;
            this.TxtNombreReal.Location = new System.Drawing.Point(55, 239);
            this.TxtNombreReal.Name = "TxtNombreReal";
            this.TxtNombreReal.Size = new System.Drawing.Size(339, 24);
            this.TxtNombreReal.TabIndex = 19;
            // 
            // TxtNombreUsuario
            // 
            this.TxtNombreUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.TxtNombreUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtNombreUsuario.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombreUsuario.ForeColor = System.Drawing.Color.White;
            this.TxtNombreUsuario.Location = new System.Drawing.Point(56, 178);
            this.TxtNombreUsuario.Name = "TxtNombreUsuario";
            this.TxtNombreUsuario.Size = new System.Drawing.Size(339, 24);
            this.TxtNombreUsuario.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 754);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(436, 15);
            this.panel1.TabIndex = 17;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(159)))), ((int)(((byte)(230)))));
            this.BtnCancelar.FlatAppearance.BorderSize = 0;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.Location = new System.Drawing.Point(147, 718);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(141, 36);
            this.BtnCancelar.TabIndex = 29;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(173, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 16);
            this.label6.TabIndex = 31;
            this.label6.Text = "Actualizar datos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(164, 446);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 16);
            this.label7.TabIndex = 33;
            this.label7.Text = "Imagen de perfil";
            // 
            // BtnSubirImagen
            // 
            this.BtnSubirImagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.BtnSubirImagen.FlatAppearance.BorderSize = 0;
            this.BtnSubirImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSubirImagen.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSubirImagen.ForeColor = System.Drawing.Color.White;
            this.BtnSubirImagen.Location = new System.Drawing.Point(44, 616);
            this.BtnSubirImagen.Name = "BtnSubirImagen";
            this.BtnSubirImagen.Size = new System.Drawing.Size(339, 25);
            this.BtnSubirImagen.TabIndex = 48;
            this.BtnSubirImagen.Text = "Subir imagen";
            this.BtnSubirImagen.UseVisualStyleBackColor = false;
            this.BtnSubirImagen.Click += new System.EventHandler(this.BtnSubirImagen_Click);
            // 
            // PbFotoPerfil
            // 
            this.PbFotoPerfil.Location = new System.Drawing.Point(119, 475);
            this.PbFotoPerfil.Name = "PbFotoPerfil";
            this.PbFotoPerfil.Size = new System.Drawing.Size(182, 122);
            this.PbFotoPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbFotoPerfil.TabIndex = 32;
            this.PbFotoPerfil.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Glizp.Properties.Resources.edit_property_256;
            this.pictureBox1.Location = new System.Drawing.Point(156, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // BtnVer
            // 
            this.BtnVer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnVer.BackgroundImage")));
            this.BtnVer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnVer.FlatAppearance.BorderSize = 0;
            this.BtnVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVer.Location = new System.Drawing.Point(368, 352);
            this.BtnVer.Name = "BtnVer";
            this.BtnVer.Size = new System.Drawing.Size(27, 25);
            this.BtnVer.TabIndex = 49;
            this.BtnVer.Text = "button1";
            this.BtnVer.UseVisualStyleBackColor = true;
            this.BtnVer.Click += new System.EventHandler(this.BtnVer_Click);
            // 
            // BtnVer1
            // 
            this.BtnVer1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnVer1.BackgroundImage")));
            this.BtnVer1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnVer1.FlatAppearance.BorderSize = 0;
            this.BtnVer1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVer1.Location = new System.Drawing.Point(368, 404);
            this.BtnVer1.Name = "BtnVer1";
            this.BtnVer1.Size = new System.Drawing.Size(27, 25);
            this.BtnVer1.TabIndex = 50;
            this.BtnVer1.Text = "button1";
            this.BtnVer1.UseVisualStyleBackColor = true;
            this.BtnVer1.Click += new System.EventHandler(this.BtnVer1_Click);
            // 
            // FrmEditarPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(60)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(453, 594);
            this.Controls.Add(this.BtnVer1);
            this.Controls.Add(this.BtnVer);
            this.Controls.Add(this.BtnSubirImagen);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.PbFotoPerfil);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.TittleBar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.TxtContrasenna2);
            this.Controls.Add(this.TxtContrasenna1);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.TxtNombreReal);
            this.Controls.Add(this.TxtNombreUsuario);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEditarPerfil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Perfil";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmEditarPerfil_FormClosed);
            this.Load += new System.EventHandler(this.FrmEditarPerfil_Load);
            this.TittleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbFotoPerfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TittleBar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox BtnClose;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.TextBox TxtContrasenna2;
        private System.Windows.Forms.TextBox TxtContrasenna1;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtNombreReal;
        private System.Windows.Forms.TextBox TxtNombreUsuario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox PbFotoPerfil;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnSubirImagen;
        private System.Windows.Forms.Button BtnVer;
        private System.Windows.Forms.Button BtnVer1;
    }
}