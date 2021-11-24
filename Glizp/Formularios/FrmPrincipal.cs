using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using BussinessLogic;
using System.IO;

namespace Glizp.Formularios
{
    public partial class FrmPrincipal : Form
    {

        public Image Principal;
        public Image Izquierda;
        public Image Derecha;

        public int j = 3;
        public int contador = 1;
        public Juego JuegoPublico = new Juego();

        public List<Juego> TopJuegos = new List<Juego>();

        public PictureBox[] Pbs = new PictureBox[8];
        public Label[] Lbls = new Label[8];

        public FrmPrincipal()
        {
            InitializeComponent();
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ImagenAnterior()
        {
            Principal = PcbPrincipal.Image;
            Izquierda = PcbIzquierda.Image;
            Derecha = PcbDerecha.Image;

            PcbPrincipal.Image = Izquierda;
            PcbDerecha.Image = Principal;

            for (j = this.j; j >= 0; j--)
            {
                Image imagen = Image.FromStream(new MemoryStream(TopJuegos[j-4].ImagenPrincipal));
                    PcbIzquierda.Image = imagen;
                    if (j <= 4)
                    {
                        BtnSiguiente.Enabled = true;
                        BtnAnterior.Enabled = false;
                        //j = 0;
                    }
                    else
                    {
                        BtnSiguiente.Enabled = true;
                        BtnAnterior.Enabled = true;
                        
                    }
                j--;
                    break;
                
                

            }



        }

        private void SiguenteImagen()
        {
            Izquierda = PcbIzquierda.Image;
            Derecha = PcbDerecha.Image;
            Principal = PcbPrincipal.Image;

            PcbPrincipal.Image = Derecha;
            PcbIzquierda.Image = Principal;

            for (j = this.j; j < TopJuegos.Count; j++)
            {
                Image imagen = Image.FromStream(new MemoryStream(TopJuegos[j].ImagenPrincipal));
                    PcbDerecha.Image = imagen;
                    if (j == TopJuegos.Count - 1)
                    {
                        BtnSiguiente.Enabled = false;
                        BtnAnterior.Enabled = true;
                        //j = 0;
                    }
                    else
                    {
                        BtnSiguiente.Enabled = true;
                        BtnAnterior.Enabled = true;
                    }
                    j++;
                    break;
                
               // else
                //{
                 // PcbDerecha.Image = null;
                //}
                
            }

            //PcbPrincipal.ImageLocation = String.Format(@"Imagenes\{0}.jpg",NumeroImagen);
            //NumeroImagen++;
            
        }

        private void Zoom(PictureBox pb, bool Hover = false)
        {
            if (Hover)
            {
                pb.BringToFront();
                pb.Width += 20;
                //pb.Height += 10;

                if (pb.Name == "PcbPrincipal")
                {
                    pb.Location = new Point(238, 89);
                }

                if (pb.Name == "PcbDerecha")
                {
                    pb.Location = new Point(573, 107);
                }

            }
            else
            {
                //width 230 h 128
                if (pb.Name == "PcbPrincipal")
                {
                    pb.Height = 150;
                    pb.Width = 329;
                    pb.Location = new Point(248, 89);
                }
                else
                {
                    pb.Height = 128;
                    pb.Width = 230;

                    if (pb.Name == "PcbDerecha")
                    {
                        pb.Location = new Point(583, 107);
                    }

                }
            }
        }

        private void MostrarBotones()
        {
            BtnAnterior.BringToFront();
            BtnSiguiente.BringToFront();
        }
        private void PcbPrincipal_MouseLeave(object sender, EventArgs e)
        {

            Zoom(PcbPrincipal);
            MostrarBotones();
        }

        private void PcbPrincipal_MouseEnter(object sender, EventArgs e)
        {
            Zoom(PcbPrincipal, true);
            MostrarBotones();
        }

        private void PcbIzquierda_MouseEnter(object sender, EventArgs e)
        {
            Zoom(PcbIzquierda, true);
            MostrarBotones();
        }

        private void PcbIzquierda_MouseLeave(object sender, EventArgs e)
        {
            Zoom(PcbIzquierda);
            MostrarBotones();
        }

        private void PcbDerecha_MouseEnter(object sender, EventArgs e)
        {
            Zoom(PcbDerecha, true);
            MostrarBotones();
        }

        private void PcbDerecha_MouseLeave(object sender, EventArgs e)
        {
            Zoom(PcbDerecha);
            MostrarBotones();
        }

        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
            SiguenteImagen();
        }

        private void CargarJuegos(string busqueda = "")
        {
            int i = 0;
            DataTable ListaJuegos = new DataTable();
            ListaJuegos = JuegoPublico.Listar(busqueda,2);

            if (ListaJuegos.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron juegos con la busqueda especificada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Global.ObjetosGlobales.Juegos = new List<Juego>();
                foreach (DataRow fila in ListaJuegos.Rows)
                {
                    Juego MiJuego = new Juego();
                    MiJuego.IDJuego = Convert.ToInt32(fila["IDJuego"]);
                    MiJuego.Nombre = fila["Nombre"].ToString();
                    MiJuego.Descripcion = fila["Descripcion"].ToString();
                    MiJuego.Trailer = fila["Trailer"].ToString();
                    MiJuego.ImagenPrincipal = (byte[])fila["ImagenPrincipal"];
                    MiJuego.Precio = Convert.ToSingle(fila["Precio"]);
                    MiJuego.Fecha_Agregado = Convert.ToDateTime(fila["Fecha_Agregado"]);
                    MiJuego.Requisitos = fila["Requisitos"].ToString();
                    MiJuego.Url = fila["URL"].ToString();

                    Global.ObjetosGlobales.Juegos.Add(MiJuego);
                    i++;
                }
            }
            
        }

        private void MostrarJuegos(int contador,bool anterior = false)
        {
            int longitud = contador * 8;
            int i = longitud - 8;
            int pb = 0;

            if (longitud > Global.ObjetosGlobales.Juegos.Count)
            {
                longitud = Global.ObjetosGlobales.Juegos.Count;
            }

            for (i = i; i < longitud; i++)
            {
                Pbs[pb].Image = Image.FromStream(new MemoryStream(Global.ObjetosGlobales.Juegos[i].ImagenPrincipal));
                Lbls[pb].Text = Global.ObjetosGlobales.Juegos[i].Nombre;
                pb++;
                if (i == longitud - 1)
                {
                    if (anterior)
                    {
                        for (pb = 0; pb < Pbs.Length; pb++)
                        {
                            Pbs[pb].Enabled = true;

                        }

                    }
                    else
                    {
                        for (pb = pb; pb < Pbs.Length; pb++)
                        {
                            Pbs[pb].Enabled = false;
                            Pbs[pb].Image = null;
                            Lbls[pb].Text = "";

                        }
                    }
                }
            }

            if (longitud >= Global.ObjetosGlobales.Juegos.Count)
            {
                lblSiguiente.Enabled = false;
            }
            else
            {
                lblSiguiente.Enabled = true;
            }

            if (contador > 1)
            {
                lblAnterior.Enabled = true;
            }
            else
            {
                lblAnterior.Enabled = false;
            }
            //MessageBox.Show("" + Juegos.Count, "Info", MessageBoxButtons.OK);
        }


        private void PaginaSiguiente()
        {
            contador++;
            //MessageBox.Show(contador+"","Info",MessageBoxButtons.OK);
            MostrarJuegos(contador);

        }

        private void PaginaAnterior()
        {
            contador--;
            MostrarJuegos(contador,true);

        }


        private void ClickJuegoTop(PictureBox pb)
        {
            for (int i = 0; i < TopJuegos.Count; i++)
            {
                byte[] imagen = (byte[])(new ImageConverter()).ConvertTo(pb.Image,typeof(byte[]));
                Image ImagenEnLista = Image.FromStream(new MemoryStream(TopJuegos[i].ImagenPrincipal));
                byte[] ImagenBytes = (byte[])(new ImageConverter()).ConvertTo(ImagenEnLista, typeof(byte[]));

                if (imagen.SequenceEqual(ImagenBytes))
                {
                    FrmJuego NuevoForm = new FrmJuego();
                    NuevoForm.CargarInfo(TopJuegos[i].Nombre, ImagenBytes, TopJuegos[i].Trailer, TopJuegos[i].Descripcion, TopJuegos[i].IDJuego, TopJuegos[i].Requisitos,TopJuegos[i].Url);
                    this.Hide();
                    NuevoForm.Show();
                    //MessageBox.Show("Juego: " + TopJuegos[i].Nombre,"Info",MessageBoxButtons.OK);
                }
            }
        }

        private void ClickJuego(PictureBox pb)
        {
            for (int i = 0; i < Global.ObjetosGlobales.Juegos.Count; i++)
            {
                byte[] imagen = (byte[])(new ImageConverter()).ConvertTo(pb.Image, typeof(byte[]));
                Image ImagenEnLista = Image.FromStream(new MemoryStream(Global.ObjetosGlobales.Juegos[i].ImagenPrincipal));
                byte[] ImagenBytes = (byte[])(new ImageConverter()).ConvertTo(ImagenEnLista, typeof(byte[]));

                if (imagen.SequenceEqual(ImagenBytes))
                {
                    FrmJuego NuevoForm = new FrmJuego();
                    NuevoForm.CargarInfo(Global.ObjetosGlobales.Juegos[i].Nombre,ImagenBytes, Global.ObjetosGlobales.Juegos[i].Trailer, Global.ObjetosGlobales.Juegos[i].Descripcion, Global.ObjetosGlobales.Juegos[i].IDJuego, Global.ObjetosGlobales.Juegos[i].Requisitos, Global.ObjetosGlobales.Juegos[i].Url);
                    this.Hide();
                    NuevoForm.Show();
                    //MessageBox.Show("Juego: " + Juegos[i].Nombre, "Info", MessageBoxButtons.OK);
                }
            }
        }

        private void CargarTopJuegos()
        {
            int i = 0;

            foreach (DataRow fila in JuegoPublico.Listar("",1).Rows)
            {
                Juego MiJuego = new Juego();
                MiJuego.IDJuego = Convert.ToInt32(fila["IDJuego"]);
                MiJuego.Nombre = fila["Nombre"].ToString();
                MiJuego.Descripcion = fila["Descripcion"].ToString();
                MiJuego.Trailer = fila["Trailer"].ToString();
                MiJuego.ImagenPrincipal = (byte[])fila["ImagenPrincipal"];
                MiJuego.Precio = Convert.ToSingle(fila["Precio"]);
                MiJuego.Fecha_Agregado = Convert.ToDateTime(fila["Fecha_Agregado"]);
                MiJuego.Requisitos = fila["Requisitos"].ToString();
                MiJuego.Url = fila["URL"].ToString();

                TopJuegos.Add(MiJuego);
                //MemoryStream ms = new MemoryStream(MiJuego.ImagenPrincipal);
                //Imagenes[i] = Image.FromStream(ms);
                i++;
            }
            //MessageBox.Show("Cargados: " + TopJuegos.Count + " registros", "Informacion",MessageBoxButtons.OK);
            Izquierda = Image.FromStream(new MemoryStream(TopJuegos[0].ImagenPrincipal));
            Principal = Image.FromStream(new MemoryStream(TopJuegos[1].ImagenPrincipal));
            Derecha = Image.FromStream(new MemoryStream(TopJuegos[2].ImagenPrincipal));

            PcbPrincipal.Image = Principal;
            PcbDerecha.Image = Derecha;
            PcbIzquierda.Image = Izquierda;

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

        private void FrmPrincipal_Load_1(object sender, EventArgs e)
        {
            CargarInfoBarra();
            Pbs[0] = Pb0;
            Pbs[1] = Pb1;
            Pbs[2] = Pb2;
            Pbs[3] = Pb3;
            Pbs[4] = Pb4;
            Pbs[5] = Pb5;
            Pbs[6] = Pb6;
            Pbs[7] = Pb7;

            Lbls[0] = lbl0;
            Lbls[1] = lbl1;
            Lbls[2] = lbl2;
            Lbls[3] = lbl3;
            Lbls[4] = lbl4;
            Lbls[5] = lbl5;
            Lbls[6] = lbl6;
            Lbls[7] = lbl7;

            CargarTopJuegos();
            TrmTopJuegos.Enabled = true;
            CargarJuegos();
            MostrarJuegos(1);
        }

        private void BtnAnterior_Click(object sender, EventArgs e)
        {
            ImagenAnterior();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            while (j < TopJuegos.Count)
            {
                SiguenteImagen();
                break;
            }

        }

        private void PcbIzquierda_Click(object sender, EventArgs e)
        {
            ClickJuegoTop(PcbIzquierda);
        }

        private void PcbPrincipal_Click(object sender, EventArgs e)
        {
            ClickJuegoTop(PcbPrincipal);
        }

        private void PcbDerecha_Click(object sender, EventArgs e)
        {
            ClickJuegoTop(PcbDerecha);
        }

        private void Pb1_Click(object sender, EventArgs e)
        {
            ClickJuego(Pb0);
        }

        private void Pb2_Click(object sender, EventArgs e)
        {
            ClickJuego(Pb1);
        }

        private void Pb3_Click(object sender, EventArgs e)
        {
            ClickJuego(Pb2);
        }

        private void Pb4_Click(object sender, EventArgs e)
        {
            ClickJuego(Pb3);
        }

        private void Pb5_Click(object sender, EventArgs e)
        {
            ClickJuego(Pb4);
        }

        private void Pb6_Click(object sender, EventArgs e)
        {
            ClickJuego(Pb5);
        }

        private void Pb7_Click(object sender, EventArgs e)
        {
            ClickJuego(Pb6);

        }

        private void Pb8_Click(object sender, EventArgs e)
        {
            ClickJuego(Pb7);
        }

        private void lblSiguiente_Click(object sender, EventArgs e)
        {
            PaginaSiguiente();
        }

        private void lblAnterior_Click(object sender, EventArgs e)
        {
            PaginaAnterior();
        }


        private void LblAdmin_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminForms.AdminPrincipal MiAdminPrincipal = new AdminForms.AdminPrincipal();
            MiAdminPrincipal.Show();
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
            Formularios.Perfil Perfil = new Formularios.Perfil();
            Perfil.Show();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtBuscar.Text.Trim()))
            {
                CargarJuegos(TxtBuscar.Text.Trim());
            }
            else
            {
                CargarJuegos();

            }
            MostrarJuegos(contador);
        }

        private void LblBiblioteca_Click(object sender, EventArgs e)
        {
            this.Close();
            Formularios.FrmBiblioteca MiBilioteca = new Formularios.FrmBiblioteca();
            MiBilioteca.Show();
        }

    }
}
