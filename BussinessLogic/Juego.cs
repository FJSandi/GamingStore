using BusinessLogic;
using System;
using System.Data;
using System.Data.SqlClient;


namespace BussinessLogic
{
    public class Juego
    {
        public int IDJuego { set; get; }
        public string Nombre { set; get; }
        public string Descripcion { set; get; }
        public string Trailer { set; get; }
        public byte[] ImagenPrincipal { set; get; }
        public float Precio { set; get; }
        public string Requisitos { set; get; }
        public DateTime Fecha_Agregado { set; get; }
        public string Url { get; set; }

        public Conexion MiCon = new Conexion();



        public bool Agregar()
        {
            bool R = false;

            int RegistrosAgregados = 0;

            MiCon.Parameters.Clear();

            MiCon.Parameters.Add(new SqlParameter("@Nombre",this.Nombre));
            MiCon.Parameters.Add(new SqlParameter("@Descripcion", this.Descripcion));
            MiCon.Parameters.Add(new SqlParameter("@Trailer", this.Trailer));
            MiCon.Parameters.Add(new SqlParameter("@Imagen", this.ImagenPrincipal));

            RegistrosAgregados = MiCon.Put("SP_Juego_Agregar");

            if (RegistrosAgregados > 1)
            {
                R = true;
            }

            return R;

        }

        public bool Eliminar()
        {
            bool R = false;

            return R;

        }

        public bool ConsultarPorID()
        {
            bool R = false;

            return R;

        }

        public DataTable ConsultarPorNombre(string busca)
        {
            DataTable R = new DataTable();

            MiCon.Parameters.Clear();

            MiCon.Parameters.Add(new SqlParameter("@Busqueda",busca));
            MiCon.Get("SP_Juego_ConsultarPorNombre");

            return R;

        }

        public bool ConsultarPorImagen()
        {
            bool R = false;

            return R;

        }

        public bool ConsultarPorNombreJuego()
        {
            bool R = false;


            DataTable Resultado = new DataTable();

            MiCon.Parameters.Clear();

            MiCon.Parameters.Add(new SqlParameter("@Nombre", this.Nombre));

            Resultado = MiCon.Get("SP_Juego_ConsultarPorJuego");

            if (Resultado.Rows.Count > 0)
            {
                R = true;
            }

            return R;
        }

        public DataTable Listar(string busqueda,int top = 0)
        {
            DataTable R = new DataTable();

            MiCon.Parameters.Clear();

            MiCon.Parameters.Add(new SqlParameter("@top", top));

            if (busqueda != "")
            {
                MiCon.Parameters.Add(new SqlParameter("@Busqueda", busqueda));
            }

            R = MiCon.Get("SP_Juego_Listar");

            return R;
        }

        public bool Modificar()
        {
            bool R = false;

            int RegistrosAfectadosPorUpdate = 0;

            MiCon.Parameters.Clear();

            MiCon.Parameters.Add(new SqlParameter("@IDJuego", this.IDJuego));
            MiCon.Parameters.Add(new SqlParameter("@Nombre", this.Nombre == null ? DBNull.Value : (object)this.Nombre));
            MiCon.Parameters.Add(new SqlParameter("@Descripcion", this.Descripcion == null ? DBNull.Value : (object)this.Descripcion));
            MiCon.Parameters.Add(new SqlParameter("@Trailer", this.Trailer == null ? DBNull.Value : (object)this.Trailer));
            MiCon.Parameters.Add(new SqlParameter("@Email", this.Precio == null ? DBNull.Value : (object)this.Precio));
            MiCon.Parameters.Add(new SqlParameter("@URL", this.Url == null ? DBNull.Value : (object)this.Url));
            MiCon.Parameters.Add(new SqlParameter("@ImagenPrincipal", this.ImagenPrincipal));

            RegistrosAfectadosPorUpdate = MiCon.Put("SP_Usuario_Modificar");

            if (RegistrosAfectadosPorUpdate > 0)
            {
                R = true;
            }

            return R;
        }
    }
}
