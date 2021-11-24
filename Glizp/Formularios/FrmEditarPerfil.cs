using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Glizp.Formularios
{
    public partial class FrmEditarPerfil : Form
    {
        BussinessLogic.Usuario MiUsuario = new BussinessLogic.Usuario();
        public byte[] NuevoAvatar = null;
        public FrmEditarPerfil()
        {
            InitializeComponent();
        }

        private void BtnSubirImagen_Click(object sender, EventArgs e)
        {
            String imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;

                    PbFotoPerfil.ImageLocation = imageLocation;

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error al subir la imagen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }


        private void ResetearObjetos()
        {
            MiUsuario.Nombre = null;
            MiUsuario.NombreUsuario = null;
            MiUsuario.Email = null;
            MiUsuario.Pass = null;
            MiUsuario.Avatar = Global.ObjetosGlobales.UsuarioGlobal.Avatar;
            MiUsuario.IDUsuario = Global.ObjetosGlobales.UsuarioGlobal.IDUsuario;
            MiUsuario.EsAdmin = Global.ObjetosGlobales.UsuarioGlobal.EsAdmin;
        }


        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            ResetearObjetos();

            if (!string.IsNullOrEmpty(TxtNombreUsuario.Text.Trim()))
            {
                MiUsuario.NombreUsuario = TxtNombreUsuario.Text.Trim();
            }

            if (!string.IsNullOrEmpty(TxtNombreReal.Text.Trim()))
            {
                MiUsuario.Nombre = TxtNombreReal.Text.Trim();
            }

            if (!string.IsNullOrEmpty(TxtEmail.Text.Trim()))
            {
                MiUsuario.Email = TxtEmail.Text.Trim();
            }

            if (!string.IsNullOrEmpty(TxtContrasenna1.Text.Trim()))
            {
                if (PassIguales(TxtContrasenna1.Text.Trim(), TxtContrasenna2.Text.Trim()))
                {
                    MiUsuario.Pass = TxtContrasenna1.Text.Trim();
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (PbFotoPerfil.Image != null)
            {
                MemoryStream ms = new MemoryStream();
                PbFotoPerfil.Image.Save(ms, PbFotoPerfil.Image.RawFormat);
                NuevoAvatar = ms.GetBuffer();
                ms.Close();
                MiUsuario.Avatar = NuevoAvatar;
            }

            if (MiUsuario.Modificar())
            {
                Global.ObjetosGlobales.UsuarioGlobal.NombreUsuario = MiUsuario.NombreUsuario;
                Global.ObjetosGlobales.UsuarioGlobal.Email = MiUsuario.Email;
                Global.ObjetosGlobales.UsuarioGlobal.Nombre = MiUsuario.Nombre;
                Global.ObjetosGlobales.UsuarioGlobal.Avatar = MiUsuario.Avatar;
                MessageBox.Show("Perfil actualizado correctamente","Exito",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al actualizar datos, por favor intente de nuevo", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool PassIguales(string contra1, string contra2)
        {
            if (contra1 == contra2)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TittleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Global.ObjetosGlobales.ReleaseCapture();
                Global.ObjetosGlobales.SendMessage(Handle, Global.ObjetosGlobales.WM_NCLBUTTONDOWN, Global.ObjetosGlobales.HT_CAPTION, 0);
            }
        }

        private void FrmEditarPerfil_Load(object sender, EventArgs e)
        {
            this.ActiveControl = BtnClose;
            TxtNombreUsuario.Text = Global.ObjetosGlobales.UsuarioGlobal.NombreUsuario;
            TxtNombreReal.Text = Global.ObjetosGlobales.UsuarioGlobal.Nombre;
            TxtEmail.Text = Global.ObjetosGlobales.UsuarioGlobal.Email;
            PbFotoPerfil.Image = Image.FromStream(new MemoryStream(Global.ObjetosGlobales.UsuarioGlobal.Avatar));

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmEditarPerfil_FormClosed(object sender, FormClosedEventArgs e)
        {
            Formularios.Perfil PerfilUsuario = new Formularios.Perfil();
            PerfilUsuario.Show();
        }

        private void BtnVer_Click(object sender, EventArgs e)
        {
            if (TxtContrasenna1.UseSystemPasswordChar)
            {
                BtnVer.BackgroundImage = Image.FromFile(@"Imagenes\Ocultar.png");
                TxtContrasenna1.UseSystemPasswordChar = false;
            }
            else
            {
                BtnVer.BackgroundImage = Image.FromFile(@"Imagenes\Mostrar.png");
                TxtContrasenna1.UseSystemPasswordChar = true;
            }
        }

        private void BtnVer1_Click(object sender, EventArgs e)
        {
            if (TxtContrasenna2.UseSystemPasswordChar)
            {
                BtnVer1.BackgroundImage = Image.FromFile(@"Imagenes\Ocultar.png");
                TxtContrasenna2.UseSystemPasswordChar = false;
            }
            else
            {
                BtnVer1.BackgroundImage = Image.FromFile(@"Imagenes\Mostrar.png");
                TxtContrasenna2.UseSystemPasswordChar = true;
            }
        }
    }
}
