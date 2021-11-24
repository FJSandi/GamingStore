using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using BusinessLogic;

namespace BussinessLogic
{
    public class Biblioteca
    {
        public int IDBiblioteca { get; set; }
        public int IDJuego { set; get; }

        public string Nombre { get; set; }
        public int IDUsuario { set; get; }

        public DateTime Fecha_Adquirido { get; set; }

        public BusinessLogic.Conexion MiCon = new BusinessLogic.Conexion();

        public DataTable Listar()
        {
            DataTable R = new DataTable();

            MiCon.Parameters.Clear();
            MiCon.Parameters.Add(new SqlParameter("@IDUser",this.IDUsuario));
            R = MiCon.Get("SP_Biblioteca_Listar");

            return R;
        }

        public bool Agregar()
        {
            bool R = false;
            int RegistrosAfectados = 0;
            MiCon.Parameters.Clear();

            MiCon.Parameters.Add(new SqlParameter("@IDJuego", this.IDJuego));
            MiCon.Parameters.Add(new SqlParameter("@IDUsuario", this.IDUsuario));

            RegistrosAfectados = MiCon.Put("SP_Biblioteca_Agregar");

            if (RegistrosAfectados > 0)
            {
                R = true;
            }

            return R;
        }
    }
}
