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
    public partial class AdministrarCategoria : Form
    {
        public BussinessLogic.Categoria MiCategoria = new BussinessLogic.Categoria();
        public DataTable ListaCategorias = new DataTable();


        public AdministrarCategoria()
        {
            InitializeComponent();
        }

        private void LimpiarVariablesLocales()
        {
            MiCategoria = new BussinessLogic.Categoria();
            ListaCategorias = new DataTable();
        }

        private void TxtTrailer_TextChanged(object sender, EventArgs e)
        {

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

        private void EstablecerFondoBlancoTextos()
        {
            TxtNombreCategoria.BackColor = Color.White;
            TxtDescripcion.BackColor = Color.White;
        }

        private bool ValidarCamposFormulario()
        {

            bool R = false;
            EstablecerFondoBlancoTextos();

            if (!string.IsNullOrEmpty(TxtNombreCategoria.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtDescripcion.Text.Trim()))
            {
                R = true;
            }
            else
            {
                MessageBox.Show("ERROR: Faltan datos requeridos", "Error de validación", MessageBoxButtons.OK);

                if (string.IsNullOrEmpty(TxtNombreCategoria.Text.Trim()))
                {
                    TxtNombreCategoria.Focus();
                    TxtNombreCategoria.BackColor = Color.Coral;
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
           
            TxtNombreCategoria.Clear();
            TxtDescripcion.Clear();

        }

        private void CargarCategorias()
        {
            ListaCategorias = MiCategoria.Listar();

            DgvListaCategoria.DataSource = ListaCategorias;
        }

        private void AgregarCategoria()

        {

            if (ValidarCamposFormulario())
            {

                    MiCategoria.Nombre = TxtNombreCategoria.Text.Trim();
                    MiCategoria.Descripcion = TxtDescripcion.Text.Trim();


                    bool NombreCategoriaExiste;

                    NombreCategoriaExiste = MiCategoria.ConsultarPorNombreCategoria();


                    //se debe hacer una triple validación en negativo
                    //para proceder con el agregar()
                    if (NombreCategoriaExiste == false)
                    {
                        //tengo permiso para proceder con Agregar()

                        if (MiCategoria.Agregar())
                        {
                            MessageBox.Show("Categoria agregada correctamente!", ":)", MessageBoxButtons.OK);

                            LimpiarDatosForm();
                            LimpiarVariablesLocales();
                            LimpiarCategoria();
                            CargarCategorias();

                        }
                    }
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            AgregarCategoria();
        }

        private bool ValidarCamposFormularioModicarCategoria()
        {
            bool R = false;

            if (!string.IsNullOrEmpty(TxtNombreCategoria.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtDescripcion.Text.Trim()))
            {
                R = true;
            }
            else
            {
                //vamos a ayudar al usuario e indicarle cuál campo hace falta
                MessageBox.Show("ERROR: Faltan datos requeridos!", "Error de validación", MessageBoxButtons.OK);

                if (string.IsNullOrEmpty(TxtNombreCategoria.Text.Trim()))
                {
                    TxtNombreCategoria.Focus();
                    TxtNombreCategoria.BackColor = Color.Coral;
                }
                if (string.IsNullOrEmpty(TxtDescripcion.Text.Trim()))
                {
                    TxtDescripcion.Focus();
                    TxtDescripcion.BackColor = Color.Coral;
                }
            }

            return R;
        }
        private void LimpiarCategoria()
        {
            MiCategoria = new BussinessLogic.Categoria();


        }

        private void ModificarCategoriaActual()
        {

            if (ValidarCamposFormularioModicarCategoria())
            {

                    //Lleno los atributos de el objeto categoria
                    MiCategoria.Nombre = TxtNombreCategoria.Text.Trim();
                    MiCategoria.Descripcion = TxtDescripcion.Text.Trim();

                    //Opcionales

                    if (MiCategoria.Modificar())
                    {
                        MessageBox.Show("Categoria modificada correctamente!", ":)", MessageBoxButtons.OK);

                        LimpiarDatosForm();
                        LimpiarVariablesLocales();
                        LimpiarCategoria();

                        CargarCategorias();


                    }

                }
            }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
                ModificarCategoriaActual();
            
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtNombreCategoria.Text.Trim()) &&
                Global.ObjetosGlobales.CategoriaGlobal.Nombre != TxtNombreCategoria.Text.Trim())
            {
                DialogResult Respuesta;

                string MsgPregunta = string.Format("¿Está seguro de eliminar la categoria {0} ?", TxtNombreCategoria.Text.Trim());

                Respuesta = MessageBox.Show(MsgPregunta, "???", MessageBoxButtons.YesNo);

                if (Respuesta == DialogResult.Yes)
                {
                    LimpiarCategoria();

                    MiCategoria.Nombre = TxtNombreCategoria.Text.Trim();

                    if (MiCategoria.Eliminar())
                    {
                        MessageBox.Show("Categoria eliminada correctamente", ":)", MessageBoxButtons.OK);

                        LimpiarDatosForm();
                        LimpiarVariablesLocales();
                        LimpiarCategoria();
                        CargarCategorias();

                    }

                }

            }
        }

        private void ActualizarCategoriaActual()
        {
            //Este caso es diferente al agregar ya que tenemos dos opciones
            //de modificación:
            //1. Si el password quedó en blanco, NO se modifica la contraseña
            //en la base de datos. 
            //2. Si se escribe contraseña, se debe evaluar que sea la misma
            //y se debe actualizar el campo a nivel de base datos

            if (ValidarCamposFormularioModicarCategoria())
            {

                    //Lleno los atributos de el objeto usuario

                    MiCategoria.Nombre = TxtNombreCategoria.Text.Trim();
                    MiCategoria.Descripcion = TxtDescripcion.Text.Trim();


                    if (MiCategoria.Modificar())
                    {
                        MessageBox.Show("Categoria modificada correctamente", ":)", MessageBoxButtons.OK);

                        LimpiarDatosForm();
                        LimpiarVariablesLocales();
                        LimpiarCategoria();
                        CargarCategorias();

                    

                }
            }

        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarCategoriaActual();
        }

        private void AdministrarCategoria_Load(object sender, EventArgs e)
        {

        }
    }
}


