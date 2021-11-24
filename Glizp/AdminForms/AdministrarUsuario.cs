using System;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Glizp.AdminForms
{
    public partial class AdministrarUsuario : Form
    {
        public BussinessLogic.Usuario MiUsuario = new BussinessLogic.Usuario();

        public byte[] NuevoAvatar = null;

        public DataTable ListaUsuarios = new DataTable();

        private void AdministrarUsuario_Load(object sender, EventArgs e)
        {
            LimpiarVariablesLocales();

            CargarUsuarios();


        }
        private void LimpiarVariablesLocales()
        {
            MiUsuario = new BussinessLogic.Usuario();
            ListaUsuarios = new DataTable();
        }

        public AdministrarUsuario()
        {
            InitializeComponent();
        }

        private void CargarUsuarios(bool bandera = false)
        {
            DataTable temp = new DataTable();
            ListaUsuarios = MiUsuario.Listar(3);

            if (bandera)
            {
                temp = MiUsuario.Listar(2,TxtBuscar.Text);

                if (temp.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron usuarios con los datos especificados","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                else
                {
                    ListaUsuarios = temp;
                }
            }
            

            DgvListaUsuarios.DataSource = ListaUsuarios;
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
            Formularios.Perfil Perfil = new Formularios.Perfil();
            Perfil.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            Formularios.FrmPrincipal MiPrincipal = new Formularios.FrmPrincipal();
            MiPrincipal.Show();
        }

        private void LimpiarDatosForm()
        {
            CbEsAdmin.Checked = false;
            TxtNombreUsuario.Clear();
            TxtNombreReal.Clear();
            TxtEmail.Clear();
            TxtContrasenna1.Clear();
            TxtContrasenna2.Clear();

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(TxtNombreUsuario.Text.Trim()) &&
                Global.ObjetosGlobales.UsuarioGlobal.NombreUsuario != TxtNombreUsuario.Text.Trim() &&
                Global.ObjetosGlobales.UsuarioGlobal.EsAdmin)
            {
                DialogResult Respuesta;

                string MsgPregunta = string.Format("¿Está seguro de eliminar el usuario {0} ?", TxtNombreUsuario.Text.Trim());

                Respuesta = MessageBox.Show(MsgPregunta, "???", MessageBoxButtons.YesNo);

                if (Respuesta == DialogResult.Yes)
                {
                    //hasta acá aseguramos que el usuario está seguro de lo que quiere hacer

                    LimpiarVariablesLocales();

                    MiUsuario.NombreUsuario = TxtNombreUsuario.Text.Trim();

                    if (MiUsuario.Eliminar())
                    {
                        MessageBox.Show("Usuario eliminado correctamente", ":)", MessageBoxButtons.OK);

                        LimpiarDatosForm();
                        LimpiarVariablesLocales();
                        CargarUsuarios();

                    }

                }

            }

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminForms.AdminPrincipal MiAdminPrincipal = new AdminForms.AdminPrincipal();
            MiAdminPrincipal.Show();
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


        private void EstablecerFondoBlancoTextos()
        {
            TxtNombreReal.BackColor = Color.White;
            TxtNombreUsuario.BackColor = Color.White;
            TxtEmail.BackColor = Color.White;
            TxtContrasenna1.BackColor = Color.White;
            TxtContrasenna2.BackColor = Color.White;
        }

        private bool ValidarCamposFormulario()
        {

            bool R = false;
            EstablecerFondoBlancoTextos();

            if (!string.IsNullOrEmpty(TxtNombreReal.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtNombreUsuario.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtEmail.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtContrasenna1.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtContrasenna2.Text.Trim()))
            {
                R = true;
            }
            else
            {
                MessageBox.Show("Debe llenar todos los campos", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);

                if (string.IsNullOrEmpty(TxtNombreReal.Text.Trim()))
                {
                    TxtNombreReal.Focus();
                    TxtNombreReal.BackColor = Color.Coral;
                }
                if (string.IsNullOrEmpty(TxtNombreUsuario.Text.Trim()))
                {
                    TxtNombreUsuario.Focus();
                    TxtNombreUsuario.BackColor = Color.Coral;
                }
                if (string.IsNullOrEmpty(TxtEmail.Text.Trim()))
                {
                    TxtEmail.Focus();
                    TxtEmail.BackColor = Color.Coral;
                }
                if (string.IsNullOrEmpty(TxtContrasenna1.Text.Trim()))
                {
                    TxtContrasenna1.Focus();
                    TxtContrasenna1.BackColor = Color.Coral;
                }
                if (string.IsNullOrEmpty(TxtContrasenna2.Text.Trim()))
                {
                    TxtContrasenna2.Focus();
                    TxtContrasenna2.BackColor = Color.Coral;
                }
            }

            return R;
        }

        private void AgregarUsuario()

        {
            //Lo primero que haremos será crear un objeto
            //de tipo Usuario.
            //Luego validamos los datos requisito del Formulario
            //(que en este caso particular son todos).
            //Luego procedemos a realizar las validaciones puntuales
            //explicadas en el diagrama de casos de uso expandido:
            //ConsultarPorNombre, porEmail, porCedula.
            //y el caso que todas la validaciones sean NEGATIVAS
            //procedemos con el método Agregar.


            //validamos que se hayan digitado los datos en todos los campos
            if (ValidarCamposFormulario())
            {
                //si llegamos a este punto cada campo tiene algo escrito
                //se procede a validar los password
                if (PassIguales(TxtContrasenna1.Text.Trim(), TxtContrasenna2.Text.Trim()))
                {
                    //Llegados a este punto aseguramos que las contraseñas
                    //son las mismas 

                    //se puede proceder con las validaciones internas de la 
                    //clase Usuario previas al agregar()

                    //Se debe agregar la información respectivo  los atributos del obj
                    MiUsuario.Nombre = TxtNombreReal.Text.Trim();
                    MiUsuario.NombreUsuario = TxtNombreUsuario.Text.Trim();
                    MiUsuario.Email = TxtEmail.Text.Trim();
                    MiUsuario.Pass = TxtContrasenna1.Text.Trim();
                    MiUsuario.EsAdmin = CbEsAdmin.Checked;

                    bool NombreUsuarioExiste;
                    bool EmailExiste;

                    NombreUsuarioExiste = MiUsuario.ConsultarPorNombreUsuario();
                    EmailExiste = MiUsuario.ConsultarPorEmail();

                    //se debe hacer una triple validación en negativo
                    //para proceder con el agregar()
                    if (NombreUsuarioExiste == false && EmailExiste == false)
                    {
                        //tengo permiso para proceder con Agregar()

                        if (MiUsuario.Agregar())
                        {
                            MessageBox.Show("Usuario agregado correctamente!", ":)", MessageBoxButtons.OK);

                            LimpiarDatosForm();
                            LimpiarVariablesLocales();
                            CargarUsuarios();

                        }

                    }

                }

            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            AgregarUsuario();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Global.ObjetosGlobales.ReleaseCapture();
                Global.ObjetosGlobales.SendMessage(Handle, Global.ObjetosGlobales.WM_NCLBUTTONDOWN, Global.ObjetosGlobales.HT_CAPTION, 0);
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

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            {
                ResetearObjetos();

                if (!string.IsNullOrEmpty(TxtContrasenna1.Text.Trim()) && !string.IsNullOrEmpty(TxtContrasenna2.Text.Trim()))
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

                    if (MiUsuario.Modificar())
                    {
                        Global.ObjetosGlobales.UsuarioGlobal.NombreUsuario = MiUsuario.NombreUsuario;
                        Global.ObjetosGlobales.UsuarioGlobal.Email = MiUsuario.Email;
                        Global.ObjetosGlobales.UsuarioGlobal.Nombre = MiUsuario.Nombre;
                        Global.ObjetosGlobales.UsuarioGlobal.Avatar = Encoding.ASCII.GetBytes("0000001");
                        MessageBox.Show("Perfil actualizado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar datos, por favor intente de nuevo", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

        }

        private void BtnVer_Click_1(object sender, EventArgs e)
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

        private void BtnVer1_Click_1(object sender, EventArgs e)
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

        private void DgvListaUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvListaUsuarios.Rows.Count > 0 &&
                DgvListaUsuarios.SelectedRows.Count == 1)
            {

                LimpiarVariablesLocales();
                LimpiarDatosForm();

                //Primero se alimentan los valores en los atributos del objeto de usuario local
                DataGridViewRow FilaActual = DgvListaUsuarios.SelectedRows[0];

                TxtNombreUsuario.Text = Convert.ToString(FilaActual.Cells["CNombreUsuario"].Value);
                TxtNombreReal.Text = Convert.ToString(FilaActual.Cells["CNombre"].Value);
                TxtEmail.Text = Convert.ToString(FilaActual.Cells["CEmail"].Value);
                CbEsAdmin.Checked = Convert.ToBoolean(FilaActual.Cells["CEsAdmin"].Value);
            }
        }

        private void DgvListaUsuarios_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DgvListaUsuarios.ClearSelection();
        }

        private void LimpiarUsuario()
        {
            MiUsuario = new BussinessLogic.Usuario();


        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            LimpiarVariablesLocales();

            CargarUsuarios(true);
        }
        private bool ValidarCamposFormularioModicarUsuario()
        {
            bool R = false;

            if (!string.IsNullOrEmpty(TxtNombreReal.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtNombreUsuario.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtEmail.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtContrasenna1.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtContrasenna2.Text.Trim()) 
                )
            {
                R = true;
            }
            else
            {
                //vamos a ayudar al usuario e indicarle cuál campo hace falta
                MessageBox.Show("ERROR: Faltan datos requeridos!", "Error de validación", MessageBoxButtons.OK);

                if (string.IsNullOrEmpty(TxtNombreReal.Text.Trim()))
                {
                    TxtNombreReal.Focus();
                    TxtNombreReal.BackColor = Color.Coral;
                }
                if (string.IsNullOrEmpty(TxtNombreUsuario.Text.Trim()))
                {
                    TxtNombreUsuario.Focus();
                    TxtNombreUsuario.BackColor = Color.Coral;
                }
                if (string.IsNullOrEmpty(TxtEmail.Text.Trim()))
                {
                    TxtEmail.Focus();
                    TxtEmail.BackColor = Color.Coral;
                }
                if (string.IsNullOrEmpty(TxtContrasenna1.Text.Trim()))
                {
                    TxtContrasenna1.Focus();
                    TxtContrasenna1.BackColor = Color.Coral;
                }
                if (string.IsNullOrEmpty(TxtContrasenna2.Text.Trim()))
                {
                    TxtContrasenna2.Focus();
                    TxtContrasenna2.BackColor = Color.Coral;
                }
            }

            return R;
        }

        private void ActualizarUsuarioActual()
        {

            if (ValidarCamposFormularioModicarUsuario())
            {

                MiUsuario.Nombre = TxtNombreReal.Text.Trim();
                MiUsuario.NombreUsuario = TxtNombreUsuario.Text.Trim();
                MiUsuario.Email = TxtEmail.Text.Trim();
                MiUsuario.Pass = TxtContrasenna1.Text.Trim();


                if (MiUsuario.Modificar())
                {
                    MessageBox.Show("Usuario modificada correctamente!", ":)", MessageBoxButtons.OK);

                    LimpiarDatosForm();
                    LimpiarVariablesLocales();
                    LimpiarUsuario();
                    CargarUsuarios();



                }
            }

        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarUsuarioActual();
        }

    }
}
