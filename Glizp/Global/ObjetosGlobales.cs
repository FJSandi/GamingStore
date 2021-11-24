using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Glizp.Global
{
    static class ObjetosGlobales
    {
        public static Image AvatarDefault = Image.FromFile(@"Imagenes\defaultuser.png");
        public static byte[] AvatarBytes = (byte[])(new ImageConverter()).ConvertTo(AvatarDefault, typeof(byte[]));

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public static BussinessLogic.Usuario UsuarioGlobal = new BussinessLogic.Usuario();

        public static BussinessLogic.Categoria CategoriaGlobal = new BussinessLogic.Categoria();












        public static AdminForms.AdministrarUsuario AdministrarUsuario = new AdminForms.AdministrarUsuario();

        public static BussinessLogic.Juego JuegoGlobal = new BussinessLogic.Juego();
        public static List<BussinessLogic.Juego> Juegos = new List<BussinessLogic.Juego>();

        public static Formularios.FrmLogin FormularioLogin = new Formularios.FrmLogin();
        public static Formularios.FrmPrincipal FrmPrincipalGlobal = new Formularios.FrmPrincipal();
        public static Formularios.FrmJuego FrmJuegoGlobal = new Formularios.FrmJuego();
        public static Formularios.Perfil PerfilGlobal = new Formularios.Perfil();
        public static Formularios.FrmEditarPerfil EdiarPerfilGlobal = new Formularios.FrmEditarPerfil();



    }
}
