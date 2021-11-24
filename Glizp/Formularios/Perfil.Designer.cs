namespace Glizp.Formularios
{
    partial class Perfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Perfil));
            this.BarraEstado = new System.Windows.Forms.Panel();
            this.LblAdmin = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BtnClose = new System.Windows.Forms.PictureBox();
            this.LblUsername = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PbAvatar = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PbAvatarPerfil = new System.Windows.Forms.PictureBox();
            this.BtnEditarPerfil = new System.Windows.Forms.Button();
            this.LblID = new System.Windows.Forms.Label();
            this.LblInventario = new System.Windows.Forms.Label();
            this.DgvInventarioJuego = new System.Windows.Forms.DataGridView();
            this.CIDJuego = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CFecha_Adquirido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblRealName = new System.Windows.Forms.Label();
            this.LblNombreUsuario = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BarraEstado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbAvatar)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbAvatarPerfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvInventarioJuego)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraEstado
            // 
            this.BarraEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.BarraEstado.Controls.Add(this.LblAdmin);
            this.BarraEstado.Controls.Add(this.pictureBox2);
            this.BarraEstado.Controls.Add(this.BtnClose);
            this.BarraEstado.Controls.Add(this.LblUsername);
            this.BarraEstado.Controls.Add(this.label3);
            this.BarraEstado.Controls.Add(this.label1);
            this.BarraEstado.Controls.Add(this.PbAvatar);
            this.BarraEstado.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraEstado.Location = new System.Drawing.Point(0, 0);
            this.BarraEstado.Name = "BarraEstado";
            this.BarraEstado.Size = new System.Drawing.Size(802, 73);
            this.BarraEstado.TabIndex = 2;
            this.BarraEstado.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraEstado_MouseDown);
            // 
            // LblAdmin
            // 
            this.LblAdmin.AutoSize = true;
            this.LblAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblAdmin.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAdmin.ForeColor = System.Drawing.Color.White;
            this.LblAdmin.Location = new System.Drawing.Point(147, 12);
            this.LblAdmin.Name = "LblAdmin";
            this.LblAdmin.Size = new System.Drawing.Size(42, 16);
            this.LblAdmin.TabIndex = 8;
            this.LblAdmin.Text = "Admin";
            this.LblAdmin.Visible = false;
            this.LblAdmin.Click += new System.EventHandler(this.LblAdmin_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::Glizp.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(129, 50);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClose.Image = global::Glizp.Properties.Resources.Close_Icon;
            this.BtnClose.Location = new System.Drawing.Point(785, 0);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(19, 18);
            this.BtnClose.TabIndex = 5;
            this.BtnClose.TabStop = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // LblUsername
            // 
            this.LblUsername.AutoSize = true;
            this.LblUsername.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblUsername.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsername.ForeColor = System.Drawing.Color.White;
            this.LblUsername.Location = new System.Drawing.Point(708, 49);
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
            // PbAvatar
            // 
            this.PbAvatar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbAvatar.Location = new System.Drawing.Point(696, 12);
            this.PbAvatar.Name = "PbAvatar";
            this.PbAvatar.Size = new System.Drawing.Size(64, 34);
            this.PbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbAvatar.TabIndex = 0;
            this.PbAvatar.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.panel2.Controls.Add(this.PbAvatarPerfil);
            this.panel2.Controls.Add(this.BtnEditarPerfil);
            this.panel2.Controls.Add(this.LblID);
            this.panel2.Controls.Add(this.LblInventario);
            this.panel2.Controls.Add(this.DgvInventarioJuego);
            this.panel2.Controls.Add(this.LblRealName);
            this.panel2.Controls.Add(this.LblNombreUsuario);
            this.panel2.Location = new System.Drawing.Point(44, 122);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(716, 537);
            this.panel2.TabIndex = 4;
            // 
            // PbAvatarPerfil
            // 
            this.PbAvatarPerfil.Location = new System.Drawing.Point(18, 9);
            this.PbAvatarPerfil.Name = "PbAvatarPerfil";
            this.PbAvatarPerfil.Size = new System.Drawing.Size(209, 138);
            this.PbAvatarPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbAvatarPerfil.TabIndex = 10;
            this.PbAvatarPerfil.TabStop = false;
            // 
            // BtnEditarPerfil
            // 
            this.BtnEditarPerfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnEditarPerfil.FlatAppearance.BorderSize = 0;
            this.BtnEditarPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditarPerfil.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditarPerfil.ForeColor = System.Drawing.Color.White;
            this.BtnEditarPerfil.Location = new System.Drawing.Point(578, 60);
            this.BtnEditarPerfil.Name = "BtnEditarPerfil";
            this.BtnEditarPerfil.Size = new System.Drawing.Size(122, 52);
            this.BtnEditarPerfil.TabIndex = 9;
            this.BtnEditarPerfil.Text = "✏️ Editar Perfil";
            this.BtnEditarPerfil.UseVisualStyleBackColor = false;
            this.BtnEditarPerfil.Click += new System.EventHandler(this.BtnEditarPerfil_Click);
            // 
            // LblID
            // 
            this.LblID.AutoSize = true;
            this.LblID.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblID.ForeColor = System.Drawing.Color.White;
            this.LblID.Location = new System.Drawing.Point(574, 16);
            this.LblID.Name = "LblID";
            this.LblID.Size = new System.Drawing.Size(43, 28);
            this.LblID.TabIndex = 8;
            this.LblID.Text = "ID:";
            // 
            // LblInventario
            // 
            this.LblInventario.AutoSize = true;
            this.LblInventario.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInventario.ForeColor = System.Drawing.Color.White;
            this.LblInventario.Location = new System.Drawing.Point(14, 204);
            this.LblInventario.Name = "LblInventario";
            this.LblInventario.Size = new System.Drawing.Size(261, 24);
            this.LblInventario.TabIndex = 7;
            this.LblInventario.Text = "📋 Inventario del jugador";
            // 
            // DgvInventarioJuego
            // 
            this.DgvInventarioJuego.AllowUserToAddRows = false;
            this.DgvInventarioJuego.AllowUserToDeleteRows = false;
            this.DgvInventarioJuego.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.DgvInventarioJuego.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvInventarioJuego.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CIDJuego,
            this.CNombre,
            this.CFecha_Adquirido});
            this.DgvInventarioJuego.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.DgvInventarioJuego.Location = new System.Drawing.Point(18, 231);
            this.DgvInventarioJuego.MultiSelect = false;
            this.DgvInventarioJuego.Name = "DgvInventarioJuego";
            this.DgvInventarioJuego.ReadOnly = true;
            this.DgvInventarioJuego.RowHeadersVisible = false;
            this.DgvInventarioJuego.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvInventarioJuego.Size = new System.Drawing.Size(682, 287);
            this.DgvInventarioJuego.TabIndex = 6;
            this.DgvInventarioJuego.VirtualMode = true;
            // 
            // CIDJuego
            // 
            this.CIDJuego.DataPropertyName = "IDJuego";
            this.CIDJuego.HeaderText = "Codigo";
            this.CIDJuego.Name = "CIDJuego";
            this.CIDJuego.ReadOnly = true;
            // 
            // CNombre
            // 
            this.CNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CNombre.DataPropertyName = "Nombre";
            this.CNombre.HeaderText = "Nombre";
            this.CNombre.Name = "CNombre";
            this.CNombre.ReadOnly = true;
            this.CNombre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // CFecha_Adquirido
            // 
            this.CFecha_Adquirido.DataPropertyName = "Fecha_Adquirido";
            this.CFecha_Adquirido.HeaderText = "Fecha Adquirido";
            this.CFecha_Adquirido.Name = "CFecha_Adquirido";
            this.CFecha_Adquirido.ReadOnly = true;
            // 
            // LblRealName
            // 
            this.LblRealName.AutoSize = true;
            this.LblRealName.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRealName.ForeColor = System.Drawing.Color.White;
            this.LblRealName.Location = new System.Drawing.Point(237, 60);
            this.LblRealName.Name = "LblRealName";
            this.LblRealName.Size = new System.Drawing.Size(111, 22);
            this.LblRealName.TabIndex = 5;
            this.LblRealName.Text = "Real Name";
            this.LblRealName.Click += new System.EventHandler(this.LblRealName_Click);
            // 
            // LblNombreUsuario
            // 
            this.LblNombreUsuario.AutoSize = true;
            this.LblNombreUsuario.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombreUsuario.ForeColor = System.Drawing.Color.White;
            this.LblNombreUsuario.Location = new System.Drawing.Point(233, 16);
            this.LblNombreUsuario.Name = "LblNombreUsuario";
            this.LblNombreUsuario.Size = new System.Drawing.Size(199, 44);
            this.LblNombreUsuario.TabIndex = 4;
            this.LblNombreUsuario.Text = "username";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 696);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 24);
            this.panel1.TabIndex = 5;
            // 
            // Perfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(60)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(802, 720);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.BarraEstado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Perfil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Perfil";
            this.Load += new System.EventHandler(this.Perfil_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraEstado_MouseDown);
            this.BarraEstado.ResumeLayout(false);
            this.BarraEstado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbAvatar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbAvatarPerfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvInventarioJuego)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BarraEstado;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox BtnClose;
        private System.Windows.Forms.Label LblUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PbAvatar;
        private System.Windows.Forms.PictureBox UserImage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LblRealName;
        private System.Windows.Forms.Label LblNombreUsuario;
        private System.Windows.Forms.Label LblID;
        private System.Windows.Forms.Label LblInventario;
        private System.Windows.Forms.DataGridView DgvInventarioJuego;
        private System.Windows.Forms.Label LblAdmin;
        private System.Windows.Forms.Button BtnEditarPerfil;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox PbAvatarPerfil;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIDJuego;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CFecha_Adquirido;
    }
}