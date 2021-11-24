using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Glizp.Formularios
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(TxtContrasenna.Text.Trim()) && !string.IsNullOrEmpty(TxtNombreUsuario.Text.Trim()))
            {
                BussinessLogic.Usuario MiUsuario = new BussinessLogic.Usuario();

                MiUsuario.NombreUsuario = TxtNombreUsuario.Text.Trim();
                MiUsuario.Pass = TxtContrasenna.Text.Trim();

                DataTable DatosUsuario = new DataTable();
                DatosUsuario = MiUsuario.ValidarLogin();

                if (DatosUsuario.Rows.Count > 0)
                {
                    this.Hide();

                    foreach (DataRow fila in DatosUsuario.Rows)
                    {
                        Global.ObjetosGlobales.UsuarioGlobal.NombreUsuario = fila["NombreUsuario"].ToString();
                        Global.ObjetosGlobales.UsuarioGlobal.IDUsuario = Convert.ToInt32(fila["IDUsuario"]);
                        Global.ObjetosGlobales.UsuarioGlobal.Email = fila["Email"].ToString();
                        Global.ObjetosGlobales.UsuarioGlobal.Nombre = fila["Nombre"].ToString();
                        Global.ObjetosGlobales.UsuarioGlobal.EsAdmin = Convert.ToBoolean(fila["EsAdmin"]);
                        Global.ObjetosGlobales.UsuarioGlobal.Avatar = (byte[])fila["Avatar"];

                        //Carga del avatar predeterminado o el de la bd
                        if (Global.ObjetosGlobales.UsuarioGlobal.Avatar.SequenceEqual(Encoding.ASCII.GetBytes("0000001")))
                        {
                            Global.ObjetosGlobales.UsuarioGlobal.Avatar = Global.ObjetosGlobales.AvatarBytes;
                        }
                        
                    }
                    Formularios.FrmPrincipal Principal = new Formularios.FrmPrincipal();
                    Principal.Show();
                }
                else
                {
                    MessageBox.Show("Datos incorrectos","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnRegistro_Click(object sender, EventArgs e)
        {
            this.Hide();
            Formularios.FrmRegistro Registro = new Formularios.FrmRegistro();
            Registro.Show();

        }

        private void TitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Global.ObjetosGlobales.ReleaseCapture();
                Global.ObjetosGlobales.SendMessage(Handle, Global.ObjetosGlobales.WM_NCLBUTTONDOWN, Global.ObjetosGlobales.HT_CAPTION, 0);
            }
        }

        private void BtnVer_Click(object sender, EventArgs e)
        {
            if (TxtContrasenna.UseSystemPasswordChar)
            {
                BtnVer.BackgroundImage = Image.FromFile(@"Imagenes\Ocultar.png");
                TxtContrasenna.UseSystemPasswordChar = false;
            }
            else
            {
                BtnVer.BackgroundImage = Image.FromFile(@"Imagenes\Mostrar.png");
                TxtContrasenna.UseSystemPasswordChar = true;
            }
        }
    }
}
