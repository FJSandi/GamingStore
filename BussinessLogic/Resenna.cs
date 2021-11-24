using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogic
{
    public class Resenna
    {
    public int IDResenna{ set; get; }
    public int IDJ { set; get; }
    public string Usuario { set; get; }
    public int IDUsuario { set; get; }
    public string Comentario { set; get; }
    public bool Editado { set; get; }

        public BusinessLogic.Conexion MiCon = new BusinessLogic.Conexion();

        public bool Agregar()
        {
            int RegistrosAfectados = 0;
            bool R = false;

            MiCon.Parameters.Clear();

            MiCon.Parameters.Add(new SqlParameter("@IDUsuario", this.IDUsuario));
            MiCon.Parameters.Add(new SqlParameter("@IDJuego", this.IDJ));
            MiCon.Parameters.Add(new SqlParameter("@Comentario", this.Comentario));

            RegistrosAfectados = MiCon.Put("SP_Resenna_Agregar");

            if (RegistrosAfectados > 0)
            {
                R = true;
            }


            return R;
        }

        public bool Eliminar()
        {
            bool R = false;
            MiCon.Parameters.Clear();
            int RegistrosEliminados = 0;

            MiCon.Parameters.Add(new SqlParameter("@IDResenna", this.IDResenna));

            RegistrosEliminados = MiCon.Put("SP_Resenna_Eliminar");

            if (RegistrosEliminados > 0)
            {
                R = true;
            }


            return R;
        }

        public bool Modificar()
        {
            bool R = false;

            MiCon.Parameters.Clear();
            int RegistrosAfectados = 0;

            MiCon.Parameters.Add(new SqlParameter("@IDResenna", this.IDResenna));
            MiCon.Parameters.Add(new SqlParameter("@ComModificado",this.Comentario));

            RegistrosAfectados = MiCon.Put("SP_Resenna_Modificar");

            if (RegistrosAfectados > 0)
            {
                R = true;
            }

            return R;
        }

        public DataTable Listar(int IDJuego)
        {
            DataTable R = new DataTable();
            MiCon.Parameters.Clear();
            MiCon.Parameters.Add(new SqlParameter("@IDJuego", IDJuego));
            R = MiCon.Get("SP_Resenna_Listar");

            return R;
        }
    }
}
