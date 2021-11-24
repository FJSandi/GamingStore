using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Glizp.Formularios
{
    public partial class FrmBiblioteca : Form
    {
        string NombreProceso = "";
        public string ID;
        public DataTable BibliotecaUsuario = new DataTable();
        public BussinessLogic.Biblioteca MiBiblioteca = new BussinessLogic.Biblioteca();

        public FrmBiblioteca()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Formularios.FrmPrincipal principal = new Formularios.FrmPrincipal();
            principal.Show();
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

        private void BarraEstado_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Global.ObjetosGlobales.ReleaseCapture();
                Global.ObjetosGlobales.SendMessage(Handle, Global.ObjetosGlobales.WM_NCLBUTTONDOWN, Global.ObjetosGlobales.HT_CAPTION, 0);
            }
        }



        private void LimpiarObjetos()
        {
            BibliotecaUsuario = new DataTable();
            MiBiblioteca = new BussinessLogic.Biblioteca();
        }

        private void CargarInfoBarra()
        {
            if (Global.ObjetosGlobales.UsuarioGlobal.EsAdmin)
            {

                LblAdmin.Visible = true;
            }

            LblUsername.Text = Global.ObjetosGlobales.UsuarioGlobal.NombreUsuario;

            PbAvatar.Image = Image.FromStream(new MemoryStream(Global.ObjetosGlobales.UsuarioGlobal.Avatar));
        }


        private void FrmBiblioteca_Load(object sender, EventArgs e)
        {
            CargarInfoBarra();
            MiBiblioteca.IDUsuario = Global.ObjetosGlobales.UsuarioGlobal.IDUsuario;
            BibliotecaUsuario = MiBiblioteca.Listar();
            DgvBiblioteca.DataSource = BibliotecaUsuario;

        }

        private void DgvBiblioteca_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DgvBiblioteca_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DgvBiblioteca.SelectedRows[0].Selected = false;
        }

        private void DgvBiblioteca_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = DgvBiblioteca.SelectedCells[0].Value.ToString();
            foreach (BussinessLogic.Juego j in Global.ObjetosGlobales.Juegos)
            {
                if (j.IDJuego == Convert.ToInt32(ID))
                {
                    PbJuego.Image = Image.FromStream(new MemoryStream(j.ImagenPrincipal));
                    LblTitulo.Text = j.Nombre;
                    TxtDescripcion.Text = j.Descripcion;
                }
            }
        }

        private void LblAdmin_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminForms.AdminPrincipal MiAdminPrincipal = new AdminForms.AdminPrincipal();
            MiAdminPrincipal.Show();
        }

        private void PbAvatar_Click(object sender, EventArgs e)
        {
            this.Close();
            Formularios.Perfil Perfil = new Formularios.Perfil();
            Perfil.Show();
        }

        private void LanzarJuego()
        {
            tmrProceso.Enabled = true;
            string UbicacionJuego = "";

            foreach (BussinessLogic.Juego j in Global.ObjetosGlobales.Juegos)
            {
                if (j.IDJuego == Convert.ToInt32(ID))
                {
                    UbicacionJuego = string.Format(@"C:\Glizp\{0}\{0}", j.Nombre);
                    NombreProceso = j.Nombre;
                }
            }
            try
            {
                Process.Start(UbicacionJuego);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw;
            }


        }

        private void BtnJugar_Click(object sender, EventArgs e)
        {
            LanzarJuego();

        }


        private bool ProcesoCorriendo()
        {
            bool R = false;

            Process[] pnombre = Process.GetProcesses();


            for (int i = 0; i < pnombre.Length; i++)
            {
                if (pnombre[i].ProcessName.Contains(NombreProceso))
                {
                    R = true;
                    break;
                }
            }
            return R;
        }

        private void tmrProceso_Tick(object sender, EventArgs e)
        {

            if (ProcesoCorriendo())
            {
                BtnJugar.Text = "JUGANDO";
                BtnJugar.Enabled = false;
                BtnJugar.BackColor = System.Drawing.Color.DarkGray;
            }
            else
            {
                BtnJugar.Text = "▶️ JUGAR";
                BtnJugar.Enabled = true;
                BtnJugar.BackColor = System.Drawing.Color.FromArgb(255, 128, 0);
            }

        }
    }
}
