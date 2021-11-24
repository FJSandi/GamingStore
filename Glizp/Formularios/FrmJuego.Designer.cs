namespace Glizp.Formularios
{
    partial class FrmJuego
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
            this.BarraEstado = new System.Windows.Forms.Panel();
            this.LblAdmin = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BtnClose = new System.Windows.Forms.PictureBox();
            this.LblUsername = new System.Windows.Forms.Label();
            this.LblBiblioteca = new System.Windows.Forms.Label();
            this.lblTienda = new System.Windows.Forms.Label();
            this.LblInicio = new System.Windows.Forms.Label();
            this.PbAvatar = new System.Windows.Forms.PictureBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtRequisitos = new System.Windows.Forms.TextBox();
            this.BtnDescargar = new System.Windows.Forms.Button();
            this.WbTrailer = new System.Windows.Forms.WebBrowser();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtComentario = new System.Windows.Forms.TextBox();
            this.BtnEnviar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PbImagen = new System.Windows.Forms.PictureBox();
            this.BarraEstado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraEstado
            // 
            this.BarraEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.BarraEstado.Controls.Add(this.LblAdmin);
            this.BarraEstado.Controls.Add(this.pictureBox2);
            this.BarraEstado.Controls.Add(this.BtnClose);
            this.BarraEstado.Controls.Add(this.LblUsername);
            this.BarraEstado.Controls.Add(this.LblBiblioteca);
            this.BarraEstado.Controls.Add(this.lblTienda);
            this.BarraEstado.Controls.Add(this.LblInicio);
            this.BarraEstado.Controls.Add(this.PbAvatar);
            this.BarraEstado.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraEstado.Location = new System.Drawing.Point(0, 0);
            this.BarraEstado.Name = "BarraEstado";
            this.BarraEstado.Size = new System.Drawing.Size(792, 73);
            this.BarraEstado.TabIndex = 1;
            this.BarraEstado.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraEstado_MouseDown);
            // 
            // LblAdmin
            // 
            this.LblAdmin.AutoSize = true;
            this.LblAdmin.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAdmin.ForeColor = System.Drawing.Color.White;
            this.LblAdmin.Location = new System.Drawing.Point(147, 12);
            this.LblAdmin.Name = "LblAdmin";
            this.LblAdmin.Size = new System.Drawing.Size(42, 16);
            this.LblAdmin.TabIndex = 15;
            this.LblAdmin.Text = "Admin";
            this.LblAdmin.Visible = false;
            this.LblAdmin.Click += new System.EventHandler(this.LblAdmin_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Glizp.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(129, 50);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // BtnClose
            // 
            this.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClose.Image = global::Glizp.Properties.Resources.Close_Icon;
            this.BtnClose.Location = new System.Drawing.Point(793, 3);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(17, 18);
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
            // LblBiblioteca
            // 
            this.LblBiblioteca.AutoSize = true;
            this.LblBiblioteca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblBiblioteca.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBiblioteca.ForeColor = System.Drawing.Color.White;
            this.LblBiblioteca.Location = new System.Drawing.Point(569, 22);
            this.LblBiblioteca.Name = "LblBiblioteca";
            this.LblBiblioteca.Size = new System.Drawing.Size(110, 24);
            this.LblBiblioteca.TabIndex = 3;
            this.LblBiblioteca.Text = "Biblioteca";
            // 
            // lblTienda
            // 
            this.lblTienda.AutoSize = true;
            this.lblTienda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTienda.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTienda.ForeColor = System.Drawing.Color.White;
            this.lblTienda.Location = new System.Drawing.Point(487, 22);
            this.lblTienda.Name = "lblTienda";
            this.lblTienda.Size = new System.Drawing.Size(0, 25);
            this.lblTienda.TabIndex = 2;
            // 
            // LblInicio
            // 
            this.LblInicio.AutoSize = true;
            this.LblInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblInicio.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInicio.ForeColor = System.Drawing.Color.White;
            this.LblInicio.Location = new System.Drawing.Point(501, 22);
            this.LblInicio.Name = "LblInicio";
            this.LblInicio.Size = new System.Drawing.Size(62, 24);
            this.LblInicio.TabIndex = 1;
            this.LblInicio.Text = "Inicio";
            // 
            // PbAvatar
            // 
            this.PbAvatar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbAvatar.Location = new System.Drawing.Point(696, 12);
            this.PbAvatar.Name = "PbAvatar";
            this.PbAvatar.Size = new System.Drawing.Size(64, 34);
            this.PbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbAvatar.TabIndex = 0;
            this.PbAvatar.TabStop = false;
            this.PbAvatar.Click += new System.EventHandler(this.PbAvatar_Click);
            // 
            // TxtNombre
            // 
            this.TxtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.TxtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtNombre.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TxtNombre.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TxtNombre.Location = new System.Drawing.Point(115, 437);
            this.TxtNombre.Multiline = true;
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.ReadOnly = true;
            this.TxtNombre.Size = new System.Drawing.Size(510, 47);
            this.TxtNombre.TabIndex = 11;
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.TxtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtDescripcion.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TxtDescripcion.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDescripcion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TxtDescripcion.Location = new System.Drawing.Point(115, 490);
            this.TxtDescripcion.Multiline = true;
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.ReadOnly = true;
            this.TxtDescripcion.Size = new System.Drawing.Size(675, 168);
            this.TxtDescripcion.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(6, 661);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "REQUISITOS DEL SISTEMA";
            // 
            // TxtRequisitos
            // 
            this.TxtRequisitos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.TxtRequisitos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtRequisitos.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TxtRequisitos.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRequisitos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TxtRequisitos.Location = new System.Drawing.Point(9, 687);
            this.TxtRequisitos.Multiline = true;
            this.TxtRequisitos.Name = "TxtRequisitos";
            this.TxtRequisitos.ReadOnly = true;
            this.TxtRequisitos.Size = new System.Drawing.Size(781, 146);
            this.TxtRequisitos.TabIndex = 15;
            // 
            // BtnDescargar
            // 
            this.BtnDescargar.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnDescargar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDescargar.FlatAppearance.BorderSize = 0;
            this.BtnDescargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDescargar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDescargar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnDescargar.Location = new System.Drawing.Point(631, 437);
            this.BtnDescargar.Name = "BtnDescargar";
            this.BtnDescargar.Size = new System.Drawing.Size(159, 47);
            this.BtnDescargar.TabIndex = 16;
            this.BtnDescargar.Text = "DESCARGAR";
            this.BtnDescargar.UseVisualStyleBackColor = false;
            this.BtnDescargar.Click += new System.EventHandler(this.BtnDescargar_Click);
            // 
            // WbTrailer
            // 
            this.WbTrailer.Location = new System.Drawing.Point(115, 79);
            this.WbTrailer.MinimumSize = new System.Drawing.Size(100, 100);
            this.WbTrailer.Name = "WbTrailer";
            this.WbTrailer.Size = new System.Drawing.Size(675, 352);
            this.WbTrailer.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(11, 850);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "AGREGAR  COMENTARIO";
            // 
            // TxtComentario
            // 
            this.TxtComentario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.TxtComentario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtComentario.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtComentario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TxtComentario.Location = new System.Drawing.Point(14, 877);
            this.TxtComentario.Multiline = true;
            this.TxtComentario.Name = "TxtComentario";
            this.TxtComentario.Size = new System.Drawing.Size(776, 106);
            this.TxtComentario.TabIndex = 23;
            this.TxtComentario.MouseLeave += new System.EventHandler(this.TxtComentario_MouseLeave);
            // 
            // BtnEnviar
            // 
            this.BtnEnviar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BtnEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEnviar.Enabled = false;
            this.BtnEnviar.FlatAppearance.BorderSize = 0;
            this.BtnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEnviar.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEnviar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnEnviar.Location = new System.Drawing.Point(9, 1002);
            this.BtnEnviar.Name = "BtnEnviar";
            this.BtnEnviar.Size = new System.Drawing.Size(97, 35);
            this.BtnEnviar.TabIndex = 24;
            this.BtnEnviar.Text = "Enviar";
            this.BtnEnviar.UseVisualStyleBackColor = false;
            this.BtnEnviar.Click += new System.EventHandler(this.BtnEnviar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 1037);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(792, 25);
            this.panel2.TabIndex = 8;
            // 
            // PbImagen
            // 
            this.PbImagen.Location = new System.Drawing.Point(9, 437);
            this.PbImagen.Name = "PbImagen";
            this.PbImagen.Size = new System.Drawing.Size(100, 109);
            this.PbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbImagen.TabIndex = 10;
            this.PbImagen.TabStop = false;
            // 
            // FrmJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(60)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(809, 772);
            this.Controls.Add(this.BtnEnviar);
            this.Controls.Add(this.TxtComentario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.WbTrailer);
            this.Controls.Add(this.BtnDescargar);
            this.Controls.Add(this.TxtRequisitos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtDescripcion);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.PbImagen);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.BarraEstado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmJuego";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Glizp";
            this.Load += new System.EventHandler(this.FrmJuego_Load);
            this.BarraEstado.ResumeLayout(false);
            this.BarraEstado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel BarraEstado;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox BtnClose;
        private System.Windows.Forms.Label LblUsername;
        private System.Windows.Forms.Label LblBiblioteca;
        private System.Windows.Forms.Label lblTienda;
        private System.Windows.Forms.Label LblInicio;
        private System.Windows.Forms.PictureBox PbAvatar;
        private System.Windows.Forms.PictureBox PbImagen;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtRequisitos;
        private System.Windows.Forms.Button BtnDescargar;
        private System.Windows.Forms.WebBrowser WbTrailer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtComentario;
        private System.Windows.Forms.Button BtnEnviar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LblAdmin;
    }
}