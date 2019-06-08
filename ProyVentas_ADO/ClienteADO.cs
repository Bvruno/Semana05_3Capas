using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ProyVentas_BE;

namespace ProyVentas_ADO
{
    public class ClienteADO
    {
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        public DataTable ListarCliente()
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarCliente";

                SqlDataAdapter ada;
                ada = new SqlDataAdapter(cmd);

                DataSet dts = new DataSet();
                ada.Fill(dts, "Clientes");

                return dts.Tables["Clientes"];
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
