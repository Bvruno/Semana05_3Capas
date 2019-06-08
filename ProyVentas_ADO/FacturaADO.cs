using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace ProyVentas_ADO
{
    public class FacturaADO
    {
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        public DataTable ListarFacturasClienteFechas(String codCli,DateTime fecIni,DateTime fecFin)
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarFacturasClienteFechas";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codcli", codCli);
                cmd.Parameters.AddWithValue("@fecini", fecIni);
                cmd.Parameters.AddWithValue("@fecfin", fecFin);

                SqlDataAdapter ada;
                ada = new SqlDataAdapter(cmd);

                DataSet dts = new DataSet();
                ada.Fill(dts, "FacturasCliente");

                return dts.Tables["facturasCliente"];
            }
            catch(SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
