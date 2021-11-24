namespace Glizp.AdminForms
{
    partial class AdministrarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministrarUsuario));
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblAdmin = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BtnClose = new System.Windows.Forms.PictureBox();
            this.LblUsername = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.BtnVer1 = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnVer = new System.Windows.Forms.Button();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.CbEsAdmin = new System.Windows.Forms.CheckBox();
            this.BtnSubirImagen = new System.Windows.Forms.Button();
            this.BtnRegresar = new System.Windows.Forms.Button();
            this.DgvListaUsuarios = new System.Windows.Forms.DataGridView();
            this.CIDUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNombreUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEsAdmin = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtNombreReal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtNombreUsuario = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtContrasenna1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtContrasenna2 = new System.Windows.Forms.TextBox();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaUsuarios)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(766, 73);
            this.panel1.TabIndex = 3;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // LblAdmin
            // 
            this.LblAdmin.AutoSize = true;
            this.LblAdmin.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAdmin.ForeColor = System.Drawing.Color.White;
            this.LblAdmin.Location = new System.Drawing.Point(147, 12);
            this.LblAdmin.Name = "LblAdmin";
            this.LblAdmin.Size = new System.Drawing.Size(42, 16);
            this.LblAdmin.TabIndex = 14;
            this.LblAdmin.Text = "Admin";
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
            this.BtnClose.Location = new System.Drawing.Point(769, 3);
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 1347);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(766, 25);
            this.panel2.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.panel3.Controls.Add(this.BtnBuscar);
            this.panel3.Controls.Add(this.BtnVer1);
            this.panel3.Controls.Add(this.BtnCancelar);
            this.panel3.Controls.Add(this.BtnVer);
            this.panel3.Controls.Add(this.TxtBuscar);
            this.panel3.Controls.Add(this.CbEsAdmin);
            this.panel3.Controls.Add(this.BtnSubirImagen);
            this.panel3.Controls.Add(this.BtnRegresar);
            this.panel3.Controls.Add(this.DgvListaUsuarios);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.BtnActualizar);
            this.panel3.Controls.Add(this.BtnModificar);
            this.panel3.Controls.Add(this.BtnEliminar);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.TxtNombreReal);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.TxtNombreUsuario);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.TxtEmail);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.TxtContrasenna1);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.TxtContrasenna2);
            this.panel3.Controls.Add(this.BtnAgregar);
            this.panel3.Location = new System.Drawing.Point(12, 79);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(752, 1268);
            this.panel3.TabIndex = 14;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(159)))), ((int)(((byte)(230)))));
            this.BtnBuscar.FlatAppearance.BorderSize = 0;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.ForeColor = System.Drawing.Color.White;
            this.BtnBuscar.Location = new System.Drawing.Point(567, 219);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(110, 24);
            this.BtnBuscar.TabIndex = 59;
            this.BtnBuscar.Text = "BUSCAR";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // BtnVer1
            // 
            this.BtnVer1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnVer1.BackgroundImage")));
            this.BtnVer1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnVer1.FlatAppearance.BorderSize = 0;
            this.BtnVer1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVer1.Location = new System.Drawing.Point(573, 926);
            this.BtnVer1.Name = "BtnVer1";
            this.BtnVer1.Size = new System.Drawing.Size(27, 25);
            this.BtnVer1.TabIndex = 52;
            this.BtnVer1.Text = "button1";
            this.BtnVer1.UseVisualStyleBackColor = true;
            this.BtnVer1.Click += new System.EventHandler(this.BtnVer1_Click_1);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(159)))), ((int)(((byte)(230)))));
            this.BtnCancelar.FlatAppearance.BorderSize = 0;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.Location = new System.Drawing.Point(312, 1190);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(115, 51);
            this.BtnCancelar.TabIndex = 58;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnVer
            // 
            this.BtnVer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnVer.BackgroundImage")));
            this.BtnVer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnVer.FlatAppearance.BorderSize = 0;
            this.BtnVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVer.Location = new System.Drawing.Point(573, 874);
            this.BtnVer.Name = "BtnVer";
            this.BtnVer.Size = new System.Drawing.Size(27, 25);
            this.BtnVer.TabIndex = 51;
            this.BtnVer.Text = "button1";
            this.BtnVer.UseVisualStyleBackColor = true;
            this.BtnVer.Click += new System.EventHandler(this.BtnVer_Click_1);
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.TxtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBuscar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscar.ForeColor = System.Drawing.Color.White;
            this.TxtBuscar.Location = new System.Drawing.Point(213, 219);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(348, 24);
            this.TxtBuscar.TabIndex = 57;
            // 
            // CbEsAdmin
            // 
            this.CbEsAdmin.AutoSize = true;
            this.CbEsAdmin.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbEsAdmin.ForeColor = System.Drawing.Color.White;
            this.CbEsAdmin.Location = new System.Drawing.Point(308, 1014);
            this.CbEsAdmin.Name = "CbEsAdmin";
            this.CbEsAdmin.Size = new System.Drawing.Size(162, 20);
            this.CbEsAdmin.TabIndex = 56;
            this.CbEsAdmin.Text = "Habilidar permisos admin";
            this.CbEsAdmin.UseVisualStyleBackColor = true;
            // 
            // BtnSubirImagen
            // 
            this.BtnSubirImagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.BtnSubirImagen.FlatAppearance.BorderSize = 0;
            this.BtnSubirImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSubirImagen.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSubirImagen.ForeColor = System.Drawing.Color.White;
            this.BtnSubirImagen.Location = new System.Drawing.Point(223, 976);
            this.BtnSubirImagen.Name = "BtnSubirImagen";
            this.BtnSubirImagen.Size = new System.Drawing.Size(339, 25);
            this.BtnSubirImagen.TabIndex = 55;
            this.BtnSubirImagen.Text = "Eliminar imagen de usuario";
            this.BtnSubirImagen.UseVisualStyleBackColor = false;
            // 
            // BtnRegresar
            // 
            this.BtnRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(159)))), ((int)(((byte)(230)))));
            this.BtnRegresar.FlatAppearance.BorderSize = 0;
            this.BtnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegresar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegresar.ForeColor = System.Drawing.Color.White;
            this.BtnRegresar.Location = new System.Drawing.Point(18, 17);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(82, 38);
            this.BtnRegresar.TabIndex = 52;
            this.BtnRegresar.Text = "← Regresar";
            this.BtnRegresar.UseVisualStyleBackColor = false;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // DgvListaUsuarios
            // 
            this.DgvListaUsuarios.AllowUserToAddRows = false;
            this.DgvListaUsuarios.AllowUserToDeleteRows = false;
            this.DgvListaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListaUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CIDUsuario,
            this.CNombre,
            this.CNombreUsuario,
            this.CEmail,
            this.CEsAdmin});
            this.DgvListaUsuarios.Location = new System.Drawing.Point(18, 264);
            this.DgvListaUsuarios.Name = "DgvListaUsuarios";
            this.DgvListaUsuarios.ReadOnly = true;
            this.DgvListaUsuarios.RowHeadersVisible = false;
            this.DgvListaUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListaUsuarios.Size = new System.Drawing.Size(718, 332);
            this.DgvListaUsuarios.TabIndex = 33;
            this.DgvListaUsuarios.VirtualMode = true;
            this.DgvListaUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListaUsuarios_CellClick);
            this.DgvListaUsuarios.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DgvListaUsuarios_DataBindingComplete);
            // 
            // CIDUsuario
            // 
            this.CIDUsuario.DataPropertyName = "IDUsuario";
            this.CIDUsuario.HeaderText = "ID Usuario";
            this.CIDUsuario.Name = "CIDUsuario";
            this.CIDUsuario.ReadOnly = true;
            // 
            // CNombre
            // 
            this.CNombre.DataPropertyName = "Nombre";
            this.CNombre.HeaderText = "Nombre Real";
            this.CNombre.Name = "CNombre";
            this.CNombre.ReadOnly = true;
            // 
            // CNombreUsuario
            // 
            this.CNombreUsuario.DataPropertyName = "NombreUsuario";
            this.CNombreUsuario.HeaderText = "Nombre de usuario";
            this.CNombreUsuario.Name = "CNombreUsuario";
            this.CNombreUsuario.ReadOnly = true;
            // 
            // CEmail
            // 
            this.CEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CEmail.DataPropertyName = "Email";
            this.CEmail.HeaderText = "Email";
            this.CEmail.Name = "CEmail";
            this.CEmail.ReadOnly = true;
            // 
            // CEsAdmin
            // 
            this.CEsAdmin.DataPropertyName = "EsAdmin";
            this.CEsAdmin.HeaderText = "Es Admin";
            this.CEsAdmin.Name = "CEsAdmin";
            this.CEsAdmin.ReadOnly = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(247, 626);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(299, 21);
            this.label11.TabIndex = 32;
            this.label11.Text = "Informacion del usuario seleccionado";
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.BtnActualizar.FlatAppearance.BorderSize = 0;
            this.BtnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnActualizar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActualizar.ForeColor = System.Drawing.Color.White;
            this.BtnActualizar.Location = new System.Drawing.Point(400, 1127);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(336, 51);
            this.BtnActualizar.TabIndex = 31;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = false;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnModificar.FlatAppearance.BorderSize = 0;
            this.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificar.ForeColor = System.Drawing.Color.White;
            this.BtnModificar.Location = new System.Drawing.Point(400, 1059);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(336, 51);
            this.BtnModificar.TabIndex = 30;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = false;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.BtnEliminar.FlatAppearance.BorderSize = 0;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.Color.White;
            this.BtnEliminar.Location = new System.Drawing.Point(22, 1127);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(336, 51);
            this.BtnEliminar.TabIndex = 29;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(320, 178);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(150, 21);
            this.label10.TabIndex = 28;
            this.label10.Text = "Actualizar Usuario";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Glizp.Properties.Resources.change_user_xxl;
            this.pictureBox3.Location = new System.Drawing.Point(213, 17);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(349, 146);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 27;
            this.pictureBox3.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(223, 911);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 16);
            this.label5.TabIndex = 26;
            this.label5.Text = "Repetir contraseña";
            // 
            // TxtNombreReal
            // 
            this.TxtNombreReal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.TxtNombreReal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtNombreReal.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombreReal.ForeColor = System.Drawing.Color.White;
            this.TxtNombreReal.Location = new System.Drawing.Point(222, 761);
            this.TxtNombreReal.Name = "TxtNombreReal";
            this.TxtNombreReal.Size = new System.Drawing.Size(339, 24);
            this.TxtNombreReal.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(223, 859);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 25;
            this.label6.Text = "Contraseña";
            // 
            // TxtNombreUsuario
            // 
            this.TxtNombreUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.TxtNombreUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtNombreUsuario.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombreUsuario.ForeColor = System.Drawing.Color.White;
            this.TxtNombreUsuario.Location = new System.Drawing.Point(223, 700);
            this.TxtNombreUsuario.Name = "TxtNombreUsuario";
            this.TxtNombreUsuario.Size = new System.Drawing.Size(339, 24);
            this.TxtNombreUsuario.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(223, 800);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 16);
            this.label7.TabIndex = 24;
            this.label7.Text = "E-mail";
            // 
            // TxtEmail
            // 
            this.TxtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.TxtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtEmail.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmail.ForeColor = System.Drawing.Color.White;
            this.TxtEmail.Location = new System.Drawing.Point(223, 816);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(339, 24);
            this.TxtEmail.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(222, 684);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 16);
            this.label8.TabIndex = 23;
            this.label8.Text = "Nombre de usuario";
            // 
            // TxtContrasenna1
            // 
            this.TxtContrasenna1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.TxtContrasenna1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtContrasenna1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtContrasenna1.ForeColor = System.Drawing.Color.White;
            this.TxtContrasenna1.Location = new System.Drawing.Point(223, 875);
            this.TxtContrasenna1.Name = "TxtContrasenna1";
            this.TxtContrasenna1.Size = new System.Drawing.Size(339, 24);
            this.TxtContrasenna1.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(222, 745);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 16);
            this.label9.TabIndex = 22;
            this.label9.Text = "Nombre real";
            // 
            // TxtContrasenna2
            // 
            this.TxtContrasenna2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.TxtContrasenna2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtContrasenna2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtContrasenna2.ForeColor = System.Drawing.Color.White;
            this.TxtContrasenna2.Location = new System.Drawing.Point(223, 927);
            this.TxtContrasenna2.Name = "TxtContrasenna2";
            this.TxtContrasenna2.Size = new System.Drawing.Size(339, 24);
            this.TxtContrasenna2.TabIndex = 20;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.BtnAgregar.FlatAppearance.BorderSize = 0;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.ForeColor = System.Drawing.Color.White;
            this.BtnAgregar.Location = new System.Drawing.Point(22, 1059);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(336, 51);
            this.BtnAgregar.TabIndex = 21;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // AdministrarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(60)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(783, 772);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdministrarUsuario";
            this.Text = "AdministrarUsuario";
            this.Load += new System.EventHandler(this.AdministrarUsuario_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblAdmin;
        private System.Windows.Forms.PictureBox BtnClose;
        private System.Windows.Forms.Label LblUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtNombreReal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtNombreUsuario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtContrasenna1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtContrasenna2;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView DgvListaUsuarios;
        private System.Windows.Forms.Button BtnRegresar;
        private System.Windows.Forms.Button BtnSubirImagen;
        private System.Windows.Forms.CheckBox CbEsAdmin;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnVer1;
        private System.Windows.Forms.Button BtnVer;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIDUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNombreUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEmail;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CEsAdmin;
        private System.Windows.Forms.Button BtnBuscar;
    }
}