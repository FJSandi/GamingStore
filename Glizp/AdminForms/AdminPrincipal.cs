using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Glizp.AdminForms
{
    public partial class AdminPrincipal : Form
    {
        public AdminPrincipal()
        {
            InitializeComponent();
        }

        private void LblUsername_Click(object sender, EventArgs e)
        {
            LblUsername.Text = Global.ObjetosGlobales.UsuarioGlobal.NombreUsuario;


            if (Global.ObjetosGlobales.UsuarioGlobal.EsAdmin)
            {
                LblAdmin.Visible = true;
            }

            this.Close();
            Formularios.Perfil Perfil = new Formularios.Perfil();
            Perfil.Show();
        }


        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            Formularios.FrmPrincipal MiPrincipal = new Formularios.FrmPrincipal();
            MiPrincipal.Show();
        }

        private void BtnAdministrarUsuario_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminForms.AdministrarUsuario AdministrarUsuario = new AdminForms.AdministrarUsuario();
            AdministrarUsuario.Show();
        }

        private void BtnAdministrarCategoria_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminForms.AdministrarCategoria AdministrarCategoria = new AdminForms.AdministrarCategoria();
            AdministrarCategoria.Show();
        }

        private void BtnAdministrarJuego_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminForms.AdministrarJuego AdministrarJuego = new AdminForms.AdministrarJuego();
            AdministrarJuego.Show();
        }

        private void BtnAdministrarBiblioteca_Click(object sender, EventArgs e)
        {

        }

        private void BtnAdministrarResenna_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminForms.AdministrarResenna AdministrarResenna = new AdminForms.AdministrarResenna();
            AdministrarResenna.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            Formularios.Perfil Perfil = new Formularios.Perfil();
            Perfil.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            Formularios.FrmPrincipal MiPrincipal = new Formularios.FrmPrincipal();
            MiPrincipal.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
            Formularios.FrmPrincipal MiPrincipal = new Formularios.FrmPrincipal();
            MiPrincipal.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
            Formularios.FrmPrincipal MiPrincipal = new Formularios.FrmPrincipal();
            MiPrincipal.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
            Formularios.FrmBiblioteca MiBilioteca = new Formularios.FrmBiblioteca();
            MiBilioteca.Show();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Global.ObjetosGlobales.ReleaseCapture();
                Global.ObjetosGlobales.SendMessage(Handle, Global.ObjetosGlobales.WM_NCLBUTTONDOWN, Global.ObjetosGlobales.HT_CAPTION, 0);
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Formularios.FrmPrincipal MiPrincipal = new Formularios.FrmPrincipal();
            MiPrincipal.Show();
        }
    }
}
