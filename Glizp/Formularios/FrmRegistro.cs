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
    public partial class FrmRegistro : Form
    {
        public BussinessLogic.Usuario MiUsuario = new BussinessLogic.Usuario();
        public FrmRegistro()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnRegistrarse_Click(object sender, EventArgs e)
        {
            //Image AvatarDefault = Image.FromFile(@"Imagenes\defaultuser.png");
            //byte[] AvatarBytes = (byte[])(new ImageConverter()).ConvertTo(AvatarDefault, typeof(byte[]));

            if (!string.IsNullOrEmpty(TxtNombreUsuario.Text.Trim()) && !string.IsNullOrEmpty(TxtNombreReal.Text.Trim())
                && !string.IsNullOrEmpty(TxtEmail.Text.Trim()) && !string.IsNullOrEmpty(TxtContrasenna1.Text.Trim())
                && !string.IsNullOrEmpty(TxtContrasenna2.Text.Trim()))
            {

                if (PassIguales(TxtContrasenna1.Text.Trim(), TxtContrasenna2.Text.Trim()))
                {
                    MiUsuario.NombreUsuario = TxtNombreUsuario.Text.Trim();
                    MiUsuario.Nombre = TxtNombreReal.Text.Trim();
                    MiUsuario.Pass = TxtContrasenna1.Text.Trim();
                    MiUsuario.Email = TxtEmail.Text.Trim();
                    MiUsuario.EsAdmin = false;


                    if (MiUsuario.Agregar())
                    {
                        //Exito
                        MessageBox.Show("Usuario registrado satisfactoriamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();

                    }

                }

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

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmRegistro_FormClosed(object sender, FormClosedEventArgs e)
        {
            Global.ObjetosGlobales.FormularioLogin.Show();
        }

        private void TittleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Global.ObjetosGlobales.ReleaseCapture();
                Global.ObjetosGlobales.SendMessage(Handle, Global.ObjetosGlobales.WM_NCLBUTTONDOWN, Global.ObjetosGlobales.HT_CAPTION, 0);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TxtContrasenna1.UseSystemPasswordChar)
            {
                button1.BackgroundImage = Image.FromFile(@"Imagenes\Ocultar.png");
                TxtContrasenna1.UseSystemPasswordChar = false;
            }
            else
            {
                button1.BackgroundImage = Image.FromFile(@"Imagenes\Mostrar.png");
                TxtContrasenna1.UseSystemPasswordChar = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (TxtContrasenna2.UseSystemPasswordChar)
            {
                button2.BackgroundImage = Image.FromFile(@"Imagenes\Ocultar.png");
                TxtContrasenna2.UseSystemPasswordChar = false;
            }
            else
            {
                button2.BackgroundImage = Image.FromFile(@"Imagenes\Mostrar.png");
                TxtContrasenna2.UseSystemPasswordChar = true;
            }

        }

        private void TxtEmail_Leave(object sender, EventArgs e)
        {
            MiUsuario = new BussinessLogic.Usuario();
            MiUsuario.Email = TxtEmail.Text.Trim();
            if (MiUsuario.ConsultarPorEmail())
            {
                MessageBox.Show("El correo ingresado ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtEmail.Focus();
            }
        }

        private void TxtNombreUsuario_Leave(object sender, EventArgs e)
        {
            MiUsuario = new BussinessLogic.Usuario();
            MiUsuario.NombreUsuario = TxtNombreUsuario.Text.Trim();
            if (MiUsuario.ConsultarPorUsuario())
            {
                MessageBox.Show("El nombre de usuario ingresado ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtNombreUsuario.Focus();
            }
        }
    }
}
