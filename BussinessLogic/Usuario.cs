using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BussinessLogic
{
    public class Usuario
    {
        public int IDUsuario { set; get; }
        public string Nombre { set; get; }
        public string NombreUsuario { set; get; }
        public string Pass { set; get; }
        public string Email { set; get; }
        public byte[] Avatar { set; get; }
        public bool EsAdmin { set; get; }

        public BusinessLogic.Conexion MiCon;

        public DataTable ValidarLogin()
        {
            DataTable Validado = new DataTable();

            MiCon.Parameters.Clear();

            MiCon.Parameters.Add(new SqlParameter("@UserName", this.NombreUsuario));
            MiCon.Parameters.Add(new SqlParameter("@Pass", this.Pass));

            Validado = MiCon.Get("SP_Usuario_Validar");

            return Validado;

        }

        public bool Modificar()
        {
            bool R = false;

            int RegistrosAfectadosPorUpdate = 0;

            MiCon.Parameters.Clear();

            MiCon.Parameters.Add(new SqlParameter("@IDUser", this.IDUsuario));
            MiCon.Parameters.Add(new SqlParameter("@Nombre", this.Nombre == null ? DBNull.Value : (object)this.Nombre));
            MiCon.Parameters.Add(new SqlParameter("@UserName", this.NombreUsuario == null ? DBNull.Value : (object)this.NombreUsuario));
            MiCon.Parameters.Add(new SqlParameter("@Pass", this.Pass == null ? DBNull.Value : (object)this.Pass));
            MiCon.Parameters.Add(new SqlParameter("@Email", this.Email == null ? DBNull.Value : (object)this.Email));
            MiCon.Parameters.Add(new SqlParameter("@EsAdmin", this.EsAdmin));
            MiCon.Parameters.Add(new SqlParameter("@Avatar",this.Avatar));

            RegistrosAfectadosPorUpdate = MiCon.Put("SP_Usuario_Modificar");

            if (RegistrosAfectadosPorUpdate > 0)
            {
                R = true;
            }

            return R;
        }

        public bool Agregar()
        {
            int RegistrosAfectados = 0;
            
            bool R = false;

            MiCon.Parameters.Clear();

            MiCon.Parameters.Add(new SqlParameter("@UserName", this.NombreUsuario));
            MiCon.Parameters.Add(new SqlParameter("@Nombre", this.Nombre));
            MiCon.Parameters.Add(new SqlParameter("@Pass", this.Pass));
            MiCon.Parameters.Add(new SqlParameter("@Email", this.Email));
            MiCon.Parameters.Add(new SqlParameter("@EsAdmin", this.EsAdmin));

            RegistrosAfectados = MiCon.Put("SP_Usuario_Agregar");

            if (RegistrosAfectados > 0)
            {
                R = true;
            }


            return R;
        }

        public bool Eliminar()
        {
            bool R = false;

            int CantidadRegistrosAfectadosPorUpdate = 0;

            MiCon.Parameters.Clear();

            MiCon.Parameters.Add(new SqlParameter("@NombreUsuario", this.NombreUsuario));

            CantidadRegistrosAfectadosPorUpdate = MiCon.Put("SP_Usuario_Eliminar");

            if (CantidadRegistrosAfectadosPorUpdate > 0)
            {
                R = true;
            }

            return R;
        }

        public bool ConsultarPorEmail()
        {

            DataTable Resultado = new DataTable();

            MiCon.Parameters.Clear();

            MiCon.Parameters.Add(new SqlParameter("@Email", this.Email));

            Resultado = MiCon.Get("SP_Usuario_ConsultarPorEmail");

            if (Resultado.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ConsultarPorNombreUsuario()
        {
            bool R = false;


            DataTable Resultado = new DataTable();

            MiCon.Parameters.Clear();

            MiCon.Parameters.Add(new SqlParameter("@NombreUsuario", this.NombreUsuario));

            Resultado = MiCon.Get("SP_Usuario_ConsultarPorUsuario");

            if (Resultado.Rows.Count > 0)
            {
                R = true;
            }

            return R;
        }


        public bool ConsultarPorUsuario()
        {

            DataTable Resultado = new DataTable();

            MiCon.Parameters.Clear();

            MiCon.Parameters.Add(new SqlParameter("@UserName", this.NombreUsuario));

            Resultado = MiCon.Get("SP_Usuario_ConsultarPorUsuario");

            if (Resultado.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public DataTable Listar(int eleccion,string Busqueda = "")
        {

            DataTable R = new DataTable();

            MiCon.Parameters.Clear();

            MiCon.Parameters.Add(new SqlParameter("@Filtro", eleccion));
            MiCon.Parameters.Add(new SqlParameter("@Busqueda", Busqueda));

            R = MiCon.Get("SP_Usuario_Listar");

            return R;
        }

        public DataTable ValidarIngreso()
        {
            DataTable Resultado = new DataTable();

            MiCon.Parameters.Clear();

            MiCon.Parameters.Add(new SqlParameter("@NombreUsuario", this.NombreUsuario));

            string PasswordEncriptado = Encriptador.Encriptar(this.Pass);

            MiCon.Parameters.Add(new SqlParameter("@Pass", PasswordEncriptado));

            Resultado = MiCon.Get("SP_Usuario_Validar");

            return Resultado;
        }


        public Usuario()
        {
            this.MiCon = new BusinessLogic.Conexion();
        }
    }
}
