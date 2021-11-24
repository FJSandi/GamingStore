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
    public partial class Perfil : Form
    {

        public DataTable InventarioUsuario = new DataTable();
        public BussinessLogic.Biblioteca MiBiblioteca = new BussinessLogic.Biblioteca();

        public Perfil()
        {
            InitializeComponent();
        }

        private void LblRealName_Click(object sender, EventArgs e)
        {

        }

        private void Perfil_Load(object sender, EventArgs e)
        {
            LimpiarObjetos();

            if (Global.ObjetosGlobales.UsuarioGlobal.EsAdmin)
            {

                LblAdmin.Visible = true;
            }

            CargarInfoUsuario();
        }

        private void CargarInfoUsuario()
        {
            LblUsername.Text = Global.ObjetosGlobales.UsuarioGlobal.NombreUsuario;
            PbAvatar.Image = Image.FromStream(new MemoryStream(Global.ObjetosGlobales.UsuarioGlobal.Avatar));
            PbAvatarPerfil.Image = Image.FromStream(new MemoryStream(Global.ObjetosGlobales.UsuarioGlobal.Avatar));



            LblUsername.Text = Global.ObjetosGlobales.UsuarioGlobal.NombreUsuario;
            //Este lbl es el del perfil
            LblNombreUsuario.Text = Global.ObjetosGlobales.UsuarioGlobal.NombreUsuario;
            LblID.Text += Convert.ToString(Global.ObjetosGlobales.UsuarioGlobal.IDUsuario);
            LblRealName.Text = Global.ObjetosGlobales.UsuarioGlobal.Nombre;
            MiBiblioteca.IDUsuario = Global.ObjetosGlobales.UsuarioGlobal.IDUsuario;

            InventarioUsuario = MiBiblioteca.Listar();
            DgvInventarioJuego.DataSource = InventarioUsuario;


        }

        private void LimpiarObjetos()
        {
            InventarioUsuario = new DataTable();
            MiBiblioteca = new BussinessLogic.Biblioteca();
        }

        private void LblUsername_Click(object sender, EventArgs e)
        {

        }

        private void BarraEstado_MouseDown(object sender, MouseEventArgs e)
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
            Formularios.FrmPrincipal Principal = new Formularios.FrmPrincipal();
            Principal.Show();
        }

        private void BtnEditarPerfil_Click(object sender, EventArgs e)
        {
            this.Close();
            Formularios.FrmEditarPerfil EditarPerfil = new Formularios.FrmEditarPerfil();
            EditarPerfil.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
            Formularios.FrmPrincipal MiPrincipal = new Formularios.FrmPrincipal();
            MiPrincipal.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
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

        private void LblAdmin_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminForms.AdminPrincipal MiAdminPrincipal = new AdminForms.AdminPrincipal();
            MiAdminPrincipal.Show();
        }
    }
}
