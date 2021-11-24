namespace Glizp.AdminForms
{
    partial class AdminPrincipal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblAdmin = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BtnClose = new System.Windows.Forms.PictureBox();
            this.LblUsername = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnAdministrarUsuario = new System.Windows.Forms.Button();
            this.BtnAdministrarCategoria = new System.Windows.Forms.Button();
            this.BtnAdministrarJuego = new System.Windows.Forms.Button();
            this.BtnAdministrarResenna = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnAdministrarBiblioteca = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.panel1.Controls.Add(this.LblAdmin);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.BtnClose);
            this.panel1.Controls.Add(this.LblUsername);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(825, 73);
            this.panel1.TabIndex = 2;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // LblAdmin
            // 
            this.LblAdmin.AutoSize = true;
            this.LblAdmin.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAdmin.ForeColor = System.Drawing.Color.White;
            this.LblAdmin.Location = new System.Drawing.Point(147, 12);
            this.LblAdmin.Name = "LblAdmin";
            this.LblAdmin.Size = new System.Drawing.Size(136, 16);
            this.LblAdmin.TabIndex = 14;
            this.LblAdmin.Text = "Estas en el panel admin";
            this.LblAdmin.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::Glizp.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(129, 50);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClose.Image = global::Glizp.Properties.Resources.Close_Icon;
            this.BtnClose.Location = new System.Drawing.Point(806, 0);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(19, 18);
            this.BtnClose.TabIndex = 5;
            this.BtnClose.TabStop = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // LblUsername
            // 
            this.LblUsername.AutoSize = true;
            this.LblUsername.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsername.ForeColor = System.Drawing.Color.White;
            this.LblUsername.Location = new System.Drawing.Point(693, 49);
            this.LblUsername.Name = "LblUsername";
            this.LblUsername.Size = new System.Drawing.Size(67, 16);
            this.LblUsername.TabIndex = 4;
            this.LblUsername.Text = "USERNAME";
            this.LblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblUsername.Click += new System.EventHandler(this.LblUsername_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(569, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Biblioteca";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(501, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inicio";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(696, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 34);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // BtnAdministrarUsuario
            // 
            this.BtnAdministrarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(159)))), ((int)(((byte)(230)))));
            this.BtnAdministrarUsuario.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnAdministrarUsuario.FlatAppearance.BorderSize = 0;
            this.BtnAdministrarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdministrarUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdministrarUsuario.ForeColor = System.Drawing.Color.White;
            this.BtnAdministrarUsuario.Location = new System.Drawing.Point(53, 316);
            this.BtnAdministrarUsuario.Name = "BtnAdministrarUsuario";
            this.BtnAdministrarUsuario.Size = new System.Drawing.Size(336, 51);
            this.BtnAdministrarUsuario.TabIndex = 7;
            this.BtnAdministrarUsuario.Text = "Administrar Usuario";
            this.BtnAdministrarUsuario.UseVisualStyleBackColor = false;
            this.BtnAdministrarUsuario.Click += new System.EventHandler(this.BtnAdministrarUsuario_Click);
            // 
            // BtnAdministrarCategoria
            // 
            this.BtnAdministrarCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(159)))), ((int)(((byte)(230)))));
            this.BtnAdministrarCategoria.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnAdministrarCategoria.FlatAppearance.BorderSize = 0;
            this.BtnAdministrarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdministrarCategoria.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdministrarCategoria.ForeColor = System.Drawing.Color.White;
            this.BtnAdministrarCategoria.Location = new System.Drawing.Point(53, 406);
            this.BtnAdministrarCategoria.Name = "BtnAdministrarCategoria";
            this.BtnAdministrarCategoria.Size = new System.Drawing.Size(336, 51);
            this.BtnAdministrarCategoria.TabIndex = 8;
            this.BtnAdministrarCategoria.Text = "Administrar Categoria";
            this.BtnAdministrarCategoria.UseVisualStyleBackColor = false;
            this.BtnAdministrarCategoria.Click += new System.EventHandler(this.BtnAdministrarCategoria_Click);
            // 
            // BtnAdministrarJuego
            // 
            this.BtnAdministrarJuego.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(159)))), ((int)(((byte)(230)))));
            this.BtnAdministrarJuego.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnAdministrarJuego.FlatAppearance.BorderSize = 0;
            this.BtnAdministrarJuego.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdministrarJuego.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdministrarJuego.ForeColor = System.Drawing.Color.White;
            this.BtnAdministrarJuego.Location = new System.Drawing.Point(446, 316);
            this.BtnAdministrarJuego.Name = "BtnAdministrarJuego";
            this.BtnAdministrarJuego.Size = new System.Drawing.Size(336, 51);
            this.BtnAdministrarJuego.TabIndex = 9;
            this.BtnAdministrarJuego.Text = "Administrar Juego";
            this.BtnAdministrarJuego.UseVisualStyleBackColor = false;
            this.BtnAdministrarJuego.Click += new System.EventHandler(this.BtnAdministrarJuego_Click);
            // 
            // BtnAdministrarResenna
            // 
            this.BtnAdministrarResenna.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(159)))), ((int)(((byte)(230)))));
            this.BtnAdministrarResenna.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnAdministrarResenna.FlatAppearance.BorderSize = 0;
            this.BtnAdministrarResenna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdministrarResenna.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdministrarResenna.ForeColor = System.Drawing.Color.White;
            this.BtnAdministrarResenna.Location = new System.Drawing.Point(247, 482);
            this.BtnAdministrarResenna.Name = "BtnAdministrarResenna";
            this.BtnAdministrarResenna.Size = new System.Drawing.Size(336, 51);
            this.BtnAdministrarResenna.TabIndex = 10;
            this.BtnAdministrarResenna.Text = "Administrar Reseña";
            this.BtnAdministrarResenna.UseVisualStyleBackColor = false;
            this.BtnAdministrarResenna.Click += new System.EventHandler(this.BtnAdministrarResenna_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 645);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(825, 25);
            this.panel2.TabIndex = 12;
            // 
            // BtnAdministrarBiblioteca
            // 
            this.BtnAdministrarBiblioteca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(159)))), ((int)(((byte)(230)))));
            this.BtnAdministrarBiblioteca.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnAdministrarBiblioteca.FlatAppearance.BorderSize = 0;
            this.BtnAdministrarBiblioteca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdministrarBiblioteca.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdministrarBiblioteca.ForeColor = System.Drawing.Color.White;
            this.BtnAdministrarBiblioteca.Location = new System.Drawing.Point(446, 406);
            this.BtnAdministrarBiblioteca.Name = "BtnAdministrarBiblioteca";
            this.BtnAdministrarBiblioteca.Size = new System.Drawing.Size(336, 51);
            this.BtnAdministrarBiblioteca.TabIndex = 13;
            this.BtnAdministrarBiblioteca.Text = "Administrar Biblioteca";
            this.BtnAdministrarBiblioteca.UseVisualStyleBackColor = false;
            this.BtnAdministrarBiblioteca.Click += new System.EventHandler(this.BtnAdministrarBiblioteca_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(170)))), ((int)(((byte)(65)))));
            this.BtnCancelar.FlatAppearance.BorderSize = 0;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.Location = new System.Drawing.Point(328, 555);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(163, 51);
            this.BtnCancelar.TabIndex = 14;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Glizp.Properties.Resources.conference_call_xxl;
            this.pictureBox3.Location = new System.Drawing.Point(296, 79);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(271, 222);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // AdminPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(60)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(825, 670);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAdministrarBiblioteca);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.BtnAdministrarResenna);
            this.Controls.Add(this.BtnAdministrarJuego);
            this.Controls.Add(this.BtnAdministrarCategoria);
            this.Controls.Add(this.BtnAdministrarUsuario);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPrincipal";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox BtnClose;
        private System.Windows.Forms.Label LblUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnAdministrarUsuario;
        private System.Windows.Forms.Button BtnAdministrarCategoria;
        private System.Windows.Forms.Button BtnAdministrarJuego;
        private System.Windows.Forms.Button BtnAdministrarResenna;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnAdministrarBiblioteca;
        private System.Windows.Forms.Label LblAdmin;
        private System.Windows.Forms.Button BtnCancelar;
    }
}