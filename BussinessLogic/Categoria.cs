using System.Data;
using System.Data.SqlClient;
using BusinessLogic;
using System;

namespace BussinessLogic
{
    public class Categoria
    {

        public Conexion MiCon = new Conexion();

        public int IDCategoria { set; get; }
        public string Nombre { set; get; }
        public string Descripcion { set; get; }

        public bool Agregar()
        {
            bool R = false;

            int RegistrosAgregados = 0;

            MiCon.Parameters.Clear();

            MiCon.Parameters.Add(new SqlParameter("@Nombre", this.Nombre));
            MiCon.Parameters.Add(new SqlParameter("@Descripcion", this.Descripcion));

            RegistrosAgregados = MiCon.Put("SP_Categoria_Agregar");

            if (RegistrosAgregados > 1)
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

            MiCon.Parameters.Add(new SqlParameter("@NombreCategoria", this.Nombre));

            CantidadRegistrosAfectadosPorUpdate = MiCon.Put("SP_Categoria_Eliminar");

            if (CantidadRegistrosAfectadosPorUpdate > 0)
            {
                R = true;
            }

            return R;
        }

        public bool Modificar()
        {
            bool R = false;

            int RegistrosAfectadosPorUpdate = 0;

            MiCon.Parameters.Clear();

            MiCon.Parameters.Add(new SqlParameter("@IDCategoria", this.IDCategoria));
            MiCon.Parameters.Add(new SqlParameter("@Nombre", this.Nombre == null ? DBNull.Value : (object)this.Nombre));
            MiCon.Parameters.Add(new SqlParameter("@Descripcion", this.Descripcion == null ? DBNull.Value : (object)this.Descripcion));

            RegistrosAfectadosPorUpdate = MiCon.Put("SP_Categoria_Modificar");

            if (RegistrosAfectadosPorUpdate > 0)
            {
                R = true;
            }

            return R;
        }

        public bool ConsultarPorNombreCategoria()
        {
            bool R = false;

            DataTable Resultado = new DataTable();

            MiCon.Parameters.Clear();

            MiCon.Parameters.Add(new SqlParameter("@NombreCategoria", this.Nombre));

            Resultado = MiCon.Get("SP_Categoria_ConsultarPorNombreCategoria");

            if (Resultado.Rows.Count > 0)
            {
                R = true;
            }

            return R;
        }

        public DataTable Listar()
        {
            DataTable R = new DataTable();

            MiCon.Parameters.Clear();

            R = MiCon.Get("SP_Categoria_Listar");

            return R;
        }

        public Categoria()
        {
            this.MiCon = new BusinessLogic.Conexion();
        }


    }

   
}
