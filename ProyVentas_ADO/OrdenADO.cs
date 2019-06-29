using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using ProyVentas_BE;

namespace ProyVentas_ADO
{
   public  class OrdenADO
    {
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
       
           // Metodo para la demo de la semana10 (transacciones)
       public String RegistrarOrden(OrdenBE objOrdenBE)
       {
           try
           {
               cnx.ConnectionString = MiConexion.GetCnx();
               
               cmd.Connection = cnx;
               cmd.CommandType = CommandType.StoredProcedure;
               cmd.CommandText = "usp_RegistrarOCompra";
                cmd.Parameters.Clear();
               cmd.Parameters.Add(new SqlParameter("@vfecoco", objOrdenBE.FecOco));
               cmd.Parameters.Add(new SqlParameter("@vcodprv", objOrdenBE.CodPrv));
               cmd.Parameters.Add(new SqlParameter("@vfecate", objOrdenBE.FecAte));
               cmd.Parameters.Add(new SqlParameter("@vestoco", objOrdenBE.EstOco));
               cmd.Parameters.Add(new SqlParameter("@vnumoco", SqlDbType.Char, 5));
               cmd.Parameters["@vnumoco"].Direction = ParameterDirection.Output;
               cmd.Parameters.Add(new SqlParameter("@detalles", SqlDbType.Structured));
               cmd.Parameters["@detalles"].Value = objOrdenBE.DetallesOC;
               cnx.Open();
               cmd.ExecuteNonQuery();
               return cmd.Parameters["@vnumoco"].Value.ToString ();
           }
           catch (Exception ex)
           {
               return String.Empty;
           }
           finally
           {
               if (cnx.State == ConnectionState.Open)
               {
                   cnx.Close();
               }
           }

       }
       public DataTable ConsultarOrdenesProveedor(String strcodprv)
       {
           DataSet dts = new DataSet();
           try
           {
               cnx.ConnectionString = MiConexion.GetCnx();
               cmd.Connection = cnx;
               cmd.CommandType = CommandType.StoredProcedure;
               cmd.CommandText = "usp_ConsultarOrdenesProveedor";
               cmd.Parameters.Add(new SqlParameter("@cod_prv", SqlDbType.Char, 4));
               cmd.Parameters["@cod_prv"].Value = strcodprv;
               SqlDataAdapter miada = default(SqlDataAdapter);
               miada = new SqlDataAdapter(cmd);
               miada.Fill(dts, "OrdenesProveedor");
           }
           catch (SqlException ex)
           {
               throw new Exception(ex.Message);
           }
           finally
           {
               cmd.Parameters.Clear();
           }
           return dts.Tables["OrdenesProveedor"];
       }
      

    }
}
