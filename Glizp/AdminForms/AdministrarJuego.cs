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
    public partial class AdministrarJuego : Form
    {
        public BussinessLogic.Juego MiJuego = new BussinessLogic.Juego();

        public DataTable ListaJuegos = new DataTable();

        public AdministrarJuego()
        {
            InitializeComponent();
        }

        private void BtnSubirImagen_Click(object sender, EventArgs e)
        {
            String imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*|";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;

                    PbImagenPrincipal.ImageLocation = imageLocation;

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error al subir la imagen","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }
        private void CargarJuegos(string busqueda = "")
        {
            DataTable temp = new DataTable();
            ListaJuegos = MiJuego.Listar(busqueda);

                temp = MiJuego.Listar(busqueda, 3);

                if (temp.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron juegos con los datos especificados", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    ListaJuegos = temp;
                }

            DgvListaJuegos.DataSource = ListaJuegos;
        }

        private void LimpiarVariablesLocales()
        {
            MiJuego = new BussinessLogic.Juego();
            ListaJuegos = new DataTable();
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
            AdminForms.AdminPrincipal MiAdminPrincipal = new AdminForms.AdminPrincipal();
            MiAdminPrincipal.Show();

        }

        private void AdministrarJuego_Load(object sender, EventArgs e)
        {
            LimpiarVariablesLocales();

            CargarJuegos();
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminForms.AdminPrincipal MiAdminPrincipal = new AdminForms.AdminPrincipal();
            MiAdminPrincipal.Show();

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

        private void ClbListaCategorias_MouseClick(object sender, MouseEventArgs e)
        {
   
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtNombre.Text.Trim()) &&
               Global.ObjetosGlobales.JuegoGlobal.Nombre != TxtNombre.Text.Trim())
            {
                DialogResult Respuesta;

                string MsgPregunta = string.Format("¿Está seguro de eliminar el juego {0} ?", TxtNombre.Text.Trim());

                Respuesta = MessageBox.Show(MsgPregunta, "???", MessageBoxButtons.YesNo);

                if (Respuesta == DialogResult.Yes)
                {
                    //hasta acá aseguramos que el usuario está seguro de lo que quiere hacer

                    LimpiarVariablesLocales();

                    MiJuego.Nombre = TxtNombre.Text.Trim();

                    if (MiJuego.Eliminar())
                    {
                        MessageBox.Show("Juego eliminado correctamente", ":)", MessageBoxButtons.OK);

                        LimpiarDatosForm();
                        LimpiarVariablesLocales();
                        CargarJuegos();

                    }

                }

            }
        }

        private void EstablecerFondoBlancoTextos()
        {
            TxtNombre.BackColor = Color.White;
            TxtDescripcion.BackColor = Color.White;
            TxtTrailer.BackColor = Color.White;
            TxtPrecio.BackColor = Color.White;
            TxtRequisitos.BackColor = Color.White;

        }

        private bool ValidarCamposFormulario()
        {

            bool R = false;
            EstablecerFondoBlancoTextos();

            if (!string.IsNullOrEmpty(TxtNombre.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtDescripcion.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtTrailer.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtPrecio.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtRequisitos.Text.Trim())
                )
            {
                R = true;
            }
            else
            {
                MessageBox.Show("ERROR: Faltan datos requeridos", "Error de validación", MessageBoxButtons.OK);

                if (string.IsNullOrEmpty(TxtNombre.Text.Trim()))
                {
                    TxtNombre.Focus();
                    TxtNombre.BackColor = Color.Coral;
                }

                if (string.IsNullOrEmpty(TxtDescripcion.Text.Trim()))
                {
                    TxtDescripcion.Focus();
                    TxtDescripcion.BackColor = Color.Coral;
                }

            }

            return R;
        }

        private void LimpiarDatosForm()
        {
        
            TxtNombre.Clear();
            TxtDescripcion.Clear();
            TxtTrailer.Clear();
            TxtPrecio.Clear();

        }



        private void AgregarJuego()

        {

            if (ValidarCamposFormulario())
            {

                MiJuego.Nombre = TxtNombre.Text.Trim();
                MiJuego.Descripcion = TxtDescripcion.Text.Trim();
                MiJuego.Trailer = TxtTrailer.Text.Trim();
                MiJuego.Precio = float.Parse(TxtPrecio.Text.Trim());


                bool NombreJuegoExiste;

                NombreJuegoExiste = MiJuego.ConsultarPorNombreJuego();

                if (NombreJuegoExiste == false)
                {

                    if (MiJuego.Agregar())
                    {
                        MessageBox.Show("Juego agregado correctamente!", ":)", MessageBoxButtons.OK);

                        LimpiarDatosForm();
                        LimpiarVariablesLocales();
                        CargarJuegos();

                    }
                }
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            AgregarJuego();
        }

        private void ResetearObjetos()
        {
            MiJuego.Nombre = null;
            MiJuego.Descripcion = null;
            MiJuego.Trailer = null;
            MiJuego.Precio = 0;
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
                ResetearObjetos();

                if (MiJuego.Modificar())
                {
                    Global.ObjetosGlobales.JuegoGlobal.Nombre = MiJuego.Nombre;
                    Global.ObjetosGlobales.JuegoGlobal.Descripcion = MiJuego.Descripcion;
                    Global.ObjetosGlobales.JuegoGlobal.Trailer = MiJuego.Trailer;
                    Global.ObjetosGlobales.JuegoGlobal.Precio = MiJuego.Precio;
                    Global.ObjetosGlobales.JuegoGlobal.Requisitos = MiJuego.Requisitos;
                    Global.ObjetosGlobales.JuegoGlobal.Url = MiJuego.Url;

                    Global.ObjetosGlobales.JuegoGlobal.ImagenPrincipal = Encoding.ASCII.GetBytes("0000001");
                    MessageBox.Show("Juego actualizado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al actualizar datos, por favor intente de nuevo", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void LimpiarJuego()
        {
            MiJuego = new BussinessLogic.Juego();


        }
        private bool ValidarCamposFormularioModicarJuego()
        {
            bool R = false;

            if (!string.IsNullOrEmpty(TxtNombre.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtDescripcion.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtTrailer.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtPrecio.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtURL.Text.Trim())




                )
            {
                R = true;
            }
            else
            {
                //vamos a ayudar al usuario e indicarle cuál campo hace falta
                MessageBox.Show("ERROR: Faltan datos requeridos!", "Error de validación", MessageBoxButtons.OK);

                if (string.IsNullOrEmpty(TxtNombre.Text.Trim()))
                {
                    TxtNombre.Focus();
                    TxtNombre.BackColor = Color.Coral;
                }
                if (string.IsNullOrEmpty(TxtDescripcion.Text.Trim()))
                {
                    TxtDescripcion.Focus();
                    TxtDescripcion.BackColor = Color.Coral;
                }

                if (string.IsNullOrEmpty(TxtTrailer.Text.Trim()))
                {
                    TxtTrailer.Focus();
                    TxtTrailer.BackColor = Color.Coral;
                }

                if (string.IsNullOrEmpty(TxtPrecio.Text.Trim()))
                {
                    TxtPrecio.Focus();
                    TxtPrecio.BackColor = Color.Coral;
                }

                if (string.IsNullOrEmpty(TxtURL.Text.Trim()))
                {
                    TxtURL.Focus();
                    TxtURL.BackColor = Color.Coral;
                }

            }

            return R;
        }

        private void ActualizarJuegoActual()
        {

            if (ValidarCamposFormularioModicarJuego())
            {

                MiJuego.Nombre = TxtNombre.Text.Trim();
                MiJuego.Descripcion = TxtDescripcion.Text.Trim();


                if (MiJuego.Modificar())
                {
                    MessageBox.Show("Juego modificada correctamente!", ":)", MessageBoxButtons.OK);

                    LimpiarDatosForm();
                    LimpiarVariablesLocales();
                    LimpiarJuego();
                    CargarJuegos();



                }
            }

        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarJuegoActual();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            CargarJuegos(TxtBuscar.Text);

        }
    }
}
