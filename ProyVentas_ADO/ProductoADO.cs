using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using ProyVentas_BE;

namespace ProyVentas_ADO
{
     public class ProductoADO
    {
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;

        DataView dtv; 
        
        public DataTable ListarProducto()
        {
            DataSet dts = new DataSet();
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarProducto";
                SqlDataAdapter miada ;
                miada = new SqlDataAdapter(cmd);
                miada.Fill(dts, "Productos");
                //// Se consolida la vista en base a la tabla Productos
                dtv = dts.Tables["Productos"].DefaultView;
                dtv.Sort = "cod_pro";
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return dts.Tables["Productos"];
        }
        public DataView FiltrarProducto(String strcriterio)
        {
            try
            {
                //Creamos el filtrado
                dtv.RowFilter = "des_pro like '%" + strcriterio + "%'";
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return dtv;
        }
        public DataView OrdenarProducto(String strcriterio)
        {
            try
            {
                //Definimos el ordenamiento
                if (strcriterio == "1")
                {
                    dtv.Sort = "cod_pro";
                }
                else if (strcriterio == "2")
                {
                    dtv.Sort = "des_pro";
                }
                else if (strcriterio == "3")
                {
                    dtv.Sort = "pre_pro";
                }
                else if (strcriterio == "4")
                {
                    dtv.Sort = "stk_act";
                }
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return dtv;
        }

        public ProductoBE ConsultarProducto(String strCodigo)
        {
            ProductoBE objProductoBE = new ProductoBE();
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ConsultarProducto";
                //Agregamos el parametro para el SP
                cmd.Parameters.Add(new SqlParameter("@vcod", SqlDbType.Char, 4));
                cmd.Parameters["@vcod"].Value = strCodigo;
                cnx.Open();
                dtr = cmd.ExecuteReader();
                if (dtr.HasRows == true)
                {
                    dtr.Read();

                    objProductoBE.Cod_Pro = dtr.GetValue(dtr.GetOrdinal("cod_pro")).ToString();
                    objProductoBE.Des_Pro = dtr.GetValue(dtr.GetOrdinal("Des_Pro")).ToString();
                    objProductoBE.Pre_Pro = Convert.ToSingle(dtr.GetValue(dtr.GetOrdinal("Pre_Pro")).ToString());
                    objProductoBE.Stk_Act = Convert.ToInt16(dtr.GetValue(dtr.GetOrdinal("Stk_Act")).ToString());
                    objProductoBE.Stk_Min = Convert.ToInt16(dtr.GetValue(dtr.GetOrdinal("Stk_Min")).ToString());
                    objProductoBE.Uni_Med = dtr.GetValue(dtr.GetOrdinal("Uni_Med")).ToString();
                    objProductoBE.Lin_Pro = dtr.GetValue(dtr.GetOrdinal("Lin_Pro")).ToString();
                    objProductoBE.Importado = Convert.ToBoolean(dtr.GetValue(dtr.GetOrdinal("Importado")).ToString());

                    dtr.Close();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
                cmd.Parameters.Clear();
            }
            return objProductoBE;
        }

    }
}
