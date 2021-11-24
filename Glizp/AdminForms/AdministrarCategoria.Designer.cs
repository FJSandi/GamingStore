namespace Glizp.AdminForms
{
    partial class AdministrarCategoria
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.TxtNombreUsuario = new System.Windows.Forms.TextBox();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.TxtNombreCategoria = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.LblDescripcion = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.DgvListaCategoria = new System.Windows.Forms.DataGridView();
            this.CIDCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnRegresar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaCategoria)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(827, 73);
            this.panel1.TabIndex = 1;
            // 
            // LblAdmin
            // 
            this.LblAdmin.AutoSize = true;
            this.LblAdmin.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAdmin.ForeColor = System.Drawing.Color.White;
            this.LblAdmin.Location = new System.Drawing.Point(147, 12);
            this.LblAdmin.Name = "LblAdmin";
            this.LblAdmin.Size = new System.Drawing.Size(41, 15);
            this.LblAdmin.TabIndex = 15;
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
            this.BtnClose.Location = new System.Drawing.Point(826, 3);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(19, 18);
            this.BtnClose.TabIndex = 5;
            this.BtnClose.TabStop = false;
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
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.panel2.Controls.Add(this.BtnCancelar);
            this.panel2.Controls.Add(this.TxtNombreUsuario);
            this.panel2.Controls.Add(this.BtnActualizar);
            this.panel2.Controls.Add(this.BtnModificar);
            this.panel2.Controls.Add(this.BtnEliminar);
            this.panel2.Controls.Add(this.BtnAgregar);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.TxtDescripcion);
            this.panel2.Controls.Add(this.TxtNombreCategoria);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.LblDescripcion);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.DgvListaCategoria);
            this.panel2.Controls.Add(this.BtnRegresar);
            this.panel2.Location = new System.Drawing.Point(12, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(813, 926);
            this.panel2.TabIndex = 2;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(159)))), ((int)(((byte)(230)))));
            this.BtnCancelar.FlatAppearance.BorderSize = 0;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.Location = new System.Drawing.Point(318, 863);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(115, 51);
            this.BtnCancelar.TabIndex = 68;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // TxtNombreUsuario
            // 
            this.TxtNombreUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.TxtNombreUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtNombreUsuario.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombreUsuario.ForeColor = System.Drawing.Color.White;
            this.TxtNombreUsuario.Location = new System.Drawing.Point(232, 196);
            this.TxtNombreUsuario.Name = "TxtNombreUsuario";
            this.TxtNombreUsuario.Size = new System.Drawing.Size(339, 24);
            this.TxtNombreUsuario.TabIndex = 67;
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.BtnActualizar.FlatAppearance.BorderSize = 0;
            this.BtnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnActualizar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActualizar.ForeColor = System.Drawing.Color.White;
            this.BtnActualizar.Location = new System.Drawing.Point(399, 793);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(336, 51);
            this.BtnActualizar.TabIndex = 66;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = false;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(159)))), ((int)(((byte)(230)))));
            this.BtnModificar.FlatAppearance.BorderSize = 0;
            this.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificar.ForeColor = System.Drawing.Color.White;
            this.BtnModificar.Location = new System.Drawing.Point(399, 725);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(336, 51);
            this.BtnModificar.TabIndex = 65;
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
            this.BtnEliminar.Location = new System.Drawing.Point(21, 793);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(336, 51);
            this.BtnEliminar.TabIndex = 64;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.BtnAgregar.FlatAppearance.BorderSize = 0;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.ForeColor = System.Drawing.Color.White;
            this.BtnAgregar.Location = new System.Drawing.Point(21, 725);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(336, 51);
            this.BtnAgregar.TabIndex = 63;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(225, 450);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(338, 21);
            this.label11.TabIndex = 62;
            this.label11.Text = "Informacion de la categoria seleccionada";
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.TxtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtDescripcion.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDescripcion.ForeColor = System.Drawing.Color.White;
            this.TxtDescripcion.Location = new System.Drawing.Point(230, 565);
            this.TxtDescripcion.Multiline = true;
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(339, 116);
            this.TxtDescripcion.TabIndex = 61;
            this.TxtDescripcion.TextChanged += new System.EventHandler(this.TxtTrailer_TextChanged);
            // 
            // TxtNombreCategoria
            // 
            this.TxtNombreCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.TxtNombreCategoria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtNombreCategoria.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombreCategoria.ForeColor = System.Drawing.Color.White;
            this.TxtNombreCategoria.Location = new System.Drawing.Point(229, 510);
            this.TxtNombreCategoria.Name = "TxtNombreCategoria";
            this.TxtNombreCategoria.Size = new System.Drawing.Size(339, 24);
            this.TxtNombreCategoria.TabIndex = 57;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(230, 549);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 16);
            this.label8.TabIndex = 60;
            this.label8.Text = "Descripcion";
            // 
            // LblDescripcion
            // 
            this.LblDescripcion.AutoSize = true;
            this.LblDescripcion.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescripcion.ForeColor = System.Drawing.Color.White;
            this.LblDescripcion.Location = new System.Drawing.Point(229, 494);
            this.LblDescripcion.Name = "LblDescripcion";
            this.LblDescripcion.Size = new System.Drawing.Size(138, 16);
            this.LblDescripcion.TabIndex = 58;
            this.LblDescripcion.Text = "Nombre de la categoria";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(299, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 21);
            this.label4.TabIndex = 55;
            this.label4.Text = "Administrar categorias";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Glizp.Properties.Resources.info_xxl;
            this.pictureBox3.Location = new System.Drawing.Point(281, 27);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(219, 121);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 54;
            this.pictureBox3.TabStop = false;
            // 
            // DgvListaCategoria
            // 
            this.DgvListaCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListaCategoria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CIDCategoria,
            this.CNombre,
            this.CDescripcion});
            this.DgvListaCategoria.Location = new System.Drawing.Point(19, 226);
            this.DgvListaCategoria.Name = "DgvListaCategoria";
            this.DgvListaCategoria.Size = new System.Drawing.Size(766, 208);
            this.DgvListaCategoria.TabIndex = 53;
            // 
            // CIDCategoria
            // 
            this.CIDCategoria.HeaderText = "IDCategoria";
            this.CIDCategoria.Name = "CIDCategoria";
            this.CIDCategoria.ReadOnly = true;
            // 
            // CNombre
            // 
            this.CNombre.HeaderText = "Nombre";
            this.CNombre.Name = "CNombre";
            this.CNombre.ReadOnly = true;
            // 
            // CDescripcion
            // 
            this.CDescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CDescripcion.HeaderText = "Descripcion";
            this.CDescripcion.Name = "CDescripcion";
            this.CDescripcion.ReadOnly = true;
            // 
            // BtnRegresar
            // 
            this.BtnRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(159)))), ((int)(((byte)(230)))));
            this.BtnRegresar.FlatAppearance.BorderSize = 0;
            this.BtnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegresar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegresar.ForeColor = System.Drawing.Color.White;
            this.BtnRegresar.Location = new System.Drawing.Point(19, 16);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(82, 38);
            this.BtnRegresar.TabIndex = 52;
            this.BtnRegresar.Text = "← Regresar";
            this.BtnRegresar.UseVisualStyleBackColor = false;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // AdministrarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(60)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(844, 730);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdministrarCategoria";
            this.Text = "AdministrarCategoria";
            this.Load += new System.EventHandler(this.AdministrarCategoria_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaCategoria)).EndInit();
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnRegresar;
        private System.Windows.Forms.DataGridView DgvListaCategoria;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.TextBox TxtNombreCategoria;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LblDescripcion;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.TextBox TxtNombreUsuario;
        private System.Windows.Forms.Label LblAdmin;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIDCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDescripcion;
    }
}