using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Conexion
    {

        String CnnString { get; set; }

        public List<SqlParameter> Parameters = new List<SqlParameter>();

        public DataTable Get(String SPName, bool CargarEsquema = false)
        {
            DataTable Retorno = new DataTable();

            using (SqlConnection MyCnn = new SqlConnection(CnnString))
            {
                SqlCommand MyComando = new SqlCommand(SPName, MyCnn);
                MyComando.CommandType = CommandType.StoredProcedure;
                if (Parameters != null && Parameters.Count > 0)
                {
                    foreach (SqlParameter item in Parameters)
                    {
                        MyComando.Parameters.Add(item);
                    }
                }
                SqlDataAdapter MyAdaptador = new SqlDataAdapter(MyComando);

                MyAdaptador.Fill(Retorno);

                if (CargarEsquema)
                {
                    MyAdaptador.FillSchema(Retorno, SchemaType.Source);
                }
            }
            return Retorno;
        }

        public int Put(String SPName)
        {
            int Retorno = 0;

            using (SqlConnection MyCnn = new SqlConnection(CnnString))

            {
                SqlCommand MyComando = new SqlCommand(SPName, MyCnn);
                MyComando.CommandType = CommandType.StoredProcedure;

                if (Parameters != null && Parameters.Count > 0)
                {
                    foreach (SqlParameter item in Parameters)
                    {
                        MyComando.Parameters.Add(item);
                    }
                }

                MyCnn.Open();

                //Si el comando a ejecutar en un DML (update, Insert o delete) 
                //establecer SET NOCOUNT OFF; en el SP 

                Retorno = MyComando.ExecuteNonQuery();
            }

            return Retorno;
        }

        public Object GetScalar(String SPName)
        {
            Object Retorno = null;
            using (SqlConnection MyCnn = new SqlConnection(CnnString))

            {
                SqlCommand MyComando = new SqlCommand(SPName, MyCnn);
                MyComando.CommandType = CommandType.StoredProcedure;

                if (Parameters != null && Parameters.Count > 0)
                {
                    foreach (SqlParameter item in Parameters)
                    {
                        MyComando.Parameters.Add(item);
                    }
                }
                MyCnn.Open();

                Retorno = MyComando.ExecuteScalar();
            }

            return Retorno;
        }

        public Conexion()
        {

            this.Parameters = new List<SqlParameter>();
            this.CnnString = BussinessLogic.Properties.Settings.Default.CadenaConexion;
        }

    }
}
