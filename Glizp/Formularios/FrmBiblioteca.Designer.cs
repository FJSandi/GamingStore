namespace Glizp.Formularios
{
    partial class FrmBiblioteca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBiblioteca));
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BarraEstado = new System.Windows.Forms.Panel();
            this.LblAdmin = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BtnClose = new System.Windows.Forms.PictureBox();
            this.LblUsername = new System.Windows.Forms.Label();
            this.PbAvatar = new System.Windows.Forms.PictureBox();
            this.DgvBiblioteca = new System.Windows.Forms.DataGridView();
            this.CIDJuego = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CFecha_Adquirido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PbJuego = new System.Windows.Forms.PictureBox();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnJugar = new System.Windows.Forms.Button();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.tmrProceso = new System.Windows.Forms.Timer(this.components);
            this.BarraEstado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBiblioteca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbJuego)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(569, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Biblioteca";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(501, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inicio";
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
            this.BarraEstado.Size = new System.Drawing.Size(820, 73);
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
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // BtnClose
            // 
            this.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClose.Image = global::Glizp.Properties.Resources.Close_Icon;
            this.BtnClose.Location = new System.Drawing.Point(801, 0);
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
            // PbAvatar
            // 
            this.PbAvatar.Location = new System.Drawing.Point(696, 12);
            this.PbAvatar.Name = "PbAvatar";
            this.PbAvatar.Size = new System.Drawing.Size(64, 34);
            this.PbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbAvatar.TabIndex = 0;
            this.PbAvatar.TabStop = false;
            this.PbAvatar.Click += new System.EventHandler(this.PbAvatar_Click);
            // 
            // DgvBiblioteca
            // 
            this.DgvBiblioteca.AllowUserToAddRows = false;
            this.DgvBiblioteca.AllowUserToDeleteRows = false;
            this.DgvBiblioteca.AllowUserToResizeColumns = false;
            this.DgvBiblioteca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvBiblioteca.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CIDJuego,
            this.CNombre,
            this.CFecha_Adquirido});
            this.DgvBiblioteca.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.DgvBiblioteca.Location = new System.Drawing.Point(0, 70);
            this.DgvBiblioteca.MultiSelect = false;
            this.DgvBiblioteca.Name = "DgvBiblioteca";
            this.DgvBiblioteca.ReadOnly = true;
            this.DgvBiblioteca.RowHeadersVisible = false;
            this.DgvBiblioteca.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvBiblioteca.Size = new System.Drawing.Size(257, 487);
            this.DgvBiblioteca.TabIndex = 2;
            this.DgvBiblioteca.VirtualMode = true;
            this.DgvBiblioteca.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvBiblioteca_CellClick);
            this.DgvBiblioteca.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DgvBiblioteca_DataBindingComplete);
            // 
            // CIDJuego
            // 
            this.CIDJuego.DataPropertyName = "IDJuego";
            this.CIDJuego.HeaderText = "Codigo";
            this.CIDJuego.Name = "CIDJuego";
            this.CIDJuego.ReadOnly = true;
            this.CIDJuego.Width = 80;
            // 
            // CNombre
            // 
            this.CNombre.DataPropertyName = "Nombre";
            this.CNombre.HeaderText = "Nombre";
            this.CNombre.Name = "CNombre";
            this.CNombre.ReadOnly = true;
            this.CNombre.Width = 80;
            // 
            // CFecha_Adquirido
            // 
            this.CFecha_Adquirido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CFecha_Adquirido.DataPropertyName = "Fecha_Adquirido";
            this.CFecha_Adquirido.HeaderText = "Fecha Adquirido";
            this.CFecha_Adquirido.Name = "CFecha_Adquirido";
            this.CFecha_Adquirido.ReadOnly = true;
            // 
            // PbJuego
            // 
            this.PbJuego.Image = ((System.Drawing.Image)(resources.GetObject("PbJuego.Image")));
            this.PbJuego.Location = new System.Drawing.Point(393, 91);
            this.PbJuego.Name = "PbJuego";
            this.PbJuego.Size = new System.Drawing.Size(257, 120);
            this.PbJuego.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbJuego.TabIndex = 54;
            this.PbJuego.TabStop = false;
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.Color.White;
            this.LblTitulo.Location = new System.Drawing.Point(389, 225);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(163, 24);
            this.LblTitulo.TabIndex = 55;
            this.LblTitulo.Text = "Titulo del juego";
            this.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 553);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(820, 41);
            this.panel1.TabIndex = 56;
            // 
            // BtnJugar
            // 
            this.BtnJugar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnJugar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnJugar.FlatAppearance.BorderSize = 0;
            this.BtnJugar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnJugar.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnJugar.ForeColor = System.Drawing.Color.White;
            this.BtnJugar.Location = new System.Drawing.Point(674, 472);
            this.BtnJugar.Name = "BtnJugar";
            this.BtnJugar.Size = new System.Drawing.Size(141, 75);
            this.BtnJugar.TabIndex = 57;
            this.BtnJugar.Text = "▶️ JUGAR";
            this.BtnJugar.UseVisualStyleBackColor = false;
            this.BtnJugar.Click += new System.EventHandler(this.BtnJugar_Click);
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.TxtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtDescripcion.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDescripcion.ForeColor = System.Drawing.SystemColors.Window;
            this.TxtDescripcion.Location = new System.Drawing.Point(263, 273);
            this.TxtDescripcion.Multiline = true;
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.ReadOnly = true;
            this.TxtDescripcion.Size = new System.Drawing.Size(545, 177);
            this.TxtDescripcion.TabIndex = 58;
            // 
            // FrmBiblioteca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(60)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(820, 594);
            this.Controls.Add(this.TxtDescripcion);
            this.Controls.Add(this.BtnJugar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.PbJuego);
            this.Controls.Add(this.DgvBiblioteca);
            this.Controls.Add(this.BarraEstado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBiblioteca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBiblioteca";
            this.Load += new System.EventHandler(this.FrmBiblioteca_Load);
            this.BarraEstado.ResumeLayout(false);
            this.BarraEstado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBiblioteca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbJuego)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel BarraEstado;
        private System.Windows.Forms.PictureBox BtnClose;
        private System.Windows.Forms.Label LblUsername;
        private System.Windows.Forms.PictureBox PbAvatar;
        private System.Windows.Forms.DataGridView DgvBiblioteca;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label LblAdmin;
        private System.Windows.Forms.PictureBox PbJuego;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnJugar;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIDJuego;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CFecha_Adquirido;
        private System.Windows.Forms.Timer tmrProceso;
    }
}