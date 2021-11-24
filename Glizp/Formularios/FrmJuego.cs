using BussinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Glizp.Formularios
{
    public partial class FrmJuego : Form
    {
        public WebClient wc = new WebClient();
        public int contador = 0;
        public Biblioteca MiBiblioteca = new Biblioteca();
        public List<Resenna> Resennas = new List<Resenna>();
        public string Url = "";
        public int IDJuego;
        public Resenna MiResenna = new Resenna();
        public List<TextBox> Comentarios = new List<TextBox>();

        public string url;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public FrmJuego()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void DescargarJuego()
        {
            string destino = "";

            foreach (Juego j in Global.ObjetosGlobales.Juegos)
            {
                if (j.IDJuego == IDJuego)
                {
                    destino = string.Format(@"C:\Glizp\{0}.zip", j.Nombre);
                }
            }

            wc.DownloadFileCompleted += new AsyncCompletedEventHandler(FileDownloadComplete);
            Uri enlace = new Uri(Url);
            wc.DownloadFileAsync(enlace, destino);
        }

        private void FileDownloadComplete(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Juego descargado correctamente!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CargarComentarios()
        {
            Resennas.Clear();

            foreach (DataRow fila in MiResenna.Listar(IDJuego).Rows)
            {
                Resenna Res = new Resenna();

                Res.IDResenna = Convert.ToInt32(fila["IDResenna"]);
                Res.IDUsuario = Convert.ToInt32(fila["IDUsuario"]);
                Res.IDJ = Convert.ToInt32(IDJuego);
                Res.Usuario = fila["NombreUsuario"].ToString();
                Res.Comentario = fila["Comentario"].ToString();
                Res.Editado = Convert.ToBoolean(fila["Editado"]);

                Resennas.Add(Res);
            }


        }

        private void MostrarComentarios()
        {
            CargarComentarios();
            MiBiblioteca = new Biblioteca();
            Comentarios.Clear();
            string Editado = "";
            int xlbl = 14;
            int ylbl = 1047;

            int xbtn1 = 700;
            int ybtn1 = 1071;

            int xbtn2 = 700;
            int ybtn2 = 1105;

            int xcom = 17;
            int ycom = 1071;

            for (int i = 0; i < Resennas.Count; i++)
            {

                if (Resennas[i].Editado)
                {
                    Editado = " (editado)";
                }

                if (i > 0)
                {
                    ylbl += 160;

                    ycom += 160;

                    ybtn1 += 160;

                    ybtn2 += 160;
                }
                //MessageBox.Show("usuario:" + Resennas[i].Usuario + "/n" + "comentario: " + Resennas[i].Comentario ,"Info",MessageBoxButtons.OK);

                this.Controls.Add(new Label
                {
                    Text = Resennas[i].Usuario + Editado,
                    Location = new Point(xlbl, ylbl),
                    Size = new Size(170, 20),
                    Name = "usuario" + Resennas[i].IDResenna,
                    ForeColor = System.Drawing.Color.White,
                    Font = new Font("Arial", 10, FontStyle.Regular)


                }
                );

                Button BtnModificar = new Button();
                BtnModificar.Text = "Modificar";
                BtnModificar.Size = new Size(90, 30);
                BtnModificar.Location = new Point(xbtn1, ybtn1);
                BtnModificar.Name = "BtnModificar-" + Resennas[i].IDResenna.ToString();
                BtnModificar.Click += new EventHandler(this.button_click);
                BtnModificar.BackColor = System.Drawing.Color.OrangeRed;
                BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                BtnModificar.FlatAppearance.BorderSize = 0;
                BtnModificar.ForeColor = System.Drawing.Color.White;
                BtnModificar.Cursor = System.Windows.Forms.Cursors.Hand;


                Button BtnEliminar = new Button();
                BtnEliminar.Text = "Eliminar";
                BtnEliminar.Size = new Size(90, 30);
                BtnEliminar.Location = new Point(xbtn2, ybtn2);
                BtnEliminar.Name = "BtnEliminar-" + Resennas[i].IDResenna.ToString();
                BtnEliminar.Click += new EventHandler(this.button_click);
                BtnEliminar.BackColor = System.Drawing.Color.Red;
                BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                BtnEliminar.FlatAppearance.BorderSize = 0;
                BtnEliminar.ForeColor = System.Drawing.Color.White;
                BtnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;


                if (Resennas[i].IDUsuario == Global.ObjetosGlobales.UsuarioGlobal.IDUsuario)
                {
                    this.Controls.Add(BtnModificar);
                    this.Controls.Add(BtnEliminar);
                }


                TextBox tb = new TextBox();
                tb.Multiline = true;
                tb.Text = Resennas[i].Comentario;
                tb.Size = new Size(677, 106);
                tb.Location = new Point(xcom, ycom);
                tb.Name = "comentario" + Resennas[i].IDResenna;
                tb.BackColor = System.Drawing.Color.FromArgb(51, 50, 55);
                tb.ForeColor = System.Drawing.Color.White;
                tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
                tb.ReadOnly = true;
                tb.Cursor = System.Windows.Forms.Cursors.Arrow;
                tb.Font = new Font("Arial", 8, FontStyle.Regular);
                this.Controls.Add(new Label
                {
                    Text = " ",
                    Name = "separador" + i.ToString(),
                    Visible = true,
                    Enabled = true,
                    Location = new Point(xcom, ycom + 110)
                });

                Comentarios.Add(tb);
                this.Controls.Add(tb);
                Editado = "";
            }
        }

        public void CargarInfo(string Nombre, byte[] imagen, string trailer, string descripcion, int ID, string req, string url1)
        {

            IDJuego = ID;
            TxtNombre.Text = Nombre;
            PbImagen.Image = Image.FromStream(new System.IO.MemoryStream(imagen));
            url = trailer;
            TxtDescripcion.Text = descripcion;
            TxtRequisitos.Text = req;
            Url = url1;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Formularios.FrmPrincipal pri = new Formularios.FrmPrincipal();
            pri.Show();
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

        private void FrmJuego_Load(object sender, EventArgs e)
        {
            string embed = "<html><head>" +
        "<meta http-equiv=\"X-UA-Compatible\" content=\"IE=Edge\"/>" +
        "</head><body style=\"background-color:#3E3C41;\">" +
        "<iframe width=\"560\" height=\"315\" src=\"{0}\"" +
        "frameborder = \"0\" allow = \"autoplay; encrypted-media\" allowfullscreen></iframe>" +
        "</body></html>";

            WbTrailer.DocumentText = string.Format(embed, url);
            CargarInfoBarra();

            MostrarComentarios();
            JuegoAdquirido();

            this.ActiveControl = BtnClose;
        }


        private void JuegoAdquirido()
        {
            MiBiblioteca = new Biblioteca();
            MiBiblioteca.IDUsuario = Global.ObjetosGlobales.UsuarioGlobal.IDUsuario;
            MiBiblioteca.IDJuego = IDJuego;

            foreach (DataRow fila in MiBiblioteca.Listar().Rows)
            {
                if (Convert.ToInt32(fila["IDJuego"]) == IDJuego)
                {
                    BtnDescargar.Enabled = false;
                    BtnDescargar.BackColor = System.Drawing.Color.DarkGray;
                    BtnDescargar.Text = "YA LO TIENES";
                }
            }

        }


        private void LblUsername_Click(object sender, EventArgs e)
        {
            LblUsername.Text = Global.ObjetosGlobales.UsuarioGlobal.NombreUsuario;


            if (Global.ObjetosGlobales.UsuarioGlobal.EsAdmin)
            {
                LblAdmin.Visible = true;
            }
        }

        private void LblAdmin_Click(object sender, EventArgs e)
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

        private void PbAvatar_Click(object sender, EventArgs e)
        {
            this.Close();
            Formularios.Perfil Perfil = new Formularios.Perfil();
            Perfil.Show();
        }

        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtComentario.Text.Trim().ToString()))
            {
                MiResenna = new BussinessLogic.Resenna();
                MiResenna.IDUsuario = Global.ObjetosGlobales.UsuarioGlobal.IDUsuario;
                MiResenna.IDJ = IDJuego;
                MiResenna.Comentario = TxtComentario.Text.Trim().ToString();

                if (MiResenna.Agregar())
                {
                    MessageBox.Show("Comentario agregado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarComentarios();
                    MostrarComentarios();
                }
                else
                {
                    MessageBox.Show("Error al agregar comentario intente de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LimpiarComentarios()
        {
            TxtComentario.Text = "";
            foreach (Control c in this.Controls)
            {
                if (c is Label)
                {
                    if (((Label)c).Name.Contains("usuario") || ((Label)c).Name.Contains("separador"))
                    {
                        this.Controls.Remove(c);
                        LimpiarComentarios();
                    }
                }
                else if (c is TextBox)
                {
                    if (((TextBox)c).Name.Contains("comentario"))
                    {
                        this.Controls.Remove(c);
                        LimpiarComentarios();
                    }
                }
                else if (c is Button)
                {
                    if (((Button)c).Name.Contains("Eliminar") || ((Button)c).Name.Contains("Modificar"))
                    {
                        this.Controls.Remove(c);
                        LimpiarComentarios();
                    }
                }
            }
        }

        private void TxtComentario_MouseLeave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtComentario.Text.Trim().ToString()))
            {
                BtnEnviar.Enabled = true;
                BtnEnviar.BackColor = System.Drawing.Color.Green;
            }
            else
            {
                BtnEnviar.Enabled = false;
                BtnEnviar.BackColor = System.Drawing.Color.DarkGray;
            }
        }

        private void button_click(object sender, EventArgs e)
        {
            MiResenna = new BussinessLogic.Resenna();

            string MiNuevoCom = "";
            Button btn = sender as Button;
            string[] separador = { "-" };
            string[] lista = btn.Name.Split(separador, 2, StringSplitOptions.RemoveEmptyEntries);
            int ID = Convert.ToInt32(lista[1]);
            MiResenna.IDResenna = ID;

            if (btn.Name.Contains("Modificar"))
            {
                for (int i = 0; i < Comentarios.Count; i++)
                {
                    if (Comentarios[i].Name == "comentario" + ID && contador < 3)
                    {
                        Comentarios[i].ReadOnly = false;
                        Comentarios[i].Focus();
                        MiNuevoCom = Comentarios[i].Text.Trim();
                        contador++;
                        break;
                    }
                }
                if (contador == 2)
                {
                    MiResenna.Comentario = MiNuevoCom;
                    if (MiResenna.Modificar())
                    {
                        contador = 0;
                        MessageBox.Show("Comentario actualizado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarComentarios();
                        MostrarComentarios();
                        this.ActiveControl = BtnClose;
                    }
                }

                btn.Text = "Aceptar";
                btn.BackColor = System.Drawing.Color.Green;

            }
            else
            {
                DialogResult respuesta = MessageBox.Show("Seguro que desea eliminar el comentario?", "Confirmar", MessageBoxButtons.YesNo);
                if (respuesta == DialogResult.Yes)
                {
                    if (MiResenna.Eliminar())
                    {
                        MessageBox.Show("Comentario eliminado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarComentarios();
                        MostrarComentarios();
                        this.ActiveControl = BtnClose;
                    }
                }
            }

        }

        private void BtnDescargar_Click(object sender, EventArgs e)
        {
            string origen = "";

            foreach (Juego j in Global.ObjetosGlobales.Juegos)
            {
                if (j.IDJuego == IDJuego)
                {
                    origen = string.Format(@"C:\Glizp\{0}.zip", j.Nombre);
                }
            }

            MiBiblioteca = new Biblioteca();
            MiBiblioteca.IDUsuario = Global.ObjetosGlobales.UsuarioGlobal.IDUsuario;
            MiBiblioteca.IDJuego = IDJuego;
            MiBiblioteca.Agregar();
            JuegoAdquirido();
            DescargarJuego();
            ExtraerFichero(origen);
        }

        private void ExtraerFichero(string origen)
        {
            string destino = "";

            foreach (Juego j in Global.ObjetosGlobales.Juegos)
            {
                if (j.IDJuego == IDJuego)
                {
                    destino = string.Format(@"C:\Glizp\{0}", j.Nombre);
                }
            }

            try
            {
                ZipFile.ExtractToDirectory(origen, destino);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw;
            }
        }


    }

}
