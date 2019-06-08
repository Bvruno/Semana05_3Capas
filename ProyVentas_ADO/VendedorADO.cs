using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data; //SE VA A EMPLETAR DataSet
using System.Data.SqlClient;//PORQUE SE VA A EMPLEAR SqlConnection, SqlCommand, SqlDataAdapter, SqlDataReader
using ProyVentas_BE;
 
namespace ProyVentas_ADO
{
    public class VendedorADO
    {
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;
        Boolean blnexito = false;

        public Boolean  InsertarVendedor(VendedorBE  objVendedorBE)
        {
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_InsertarVendedor";
            //Agregamos parametros 
            try
            {
                //Codifique
                //agregamos PARAMETROS
                cmd.Parameters.AddWithValue("@vnom", objVendedorBE.Nom_Ven);
                cmd.Parameters.AddWithValue("@vape", objVendedorBE.Ape_Ven);
                cmd.Parameters.AddWithValue("@vsue", objVendedorBE.Sue_Ven);
                cmd.Parameters.AddWithValue("@vfec", objVendedorBE.Fec_ing);
                cmd.Parameters.AddWithValue("@vtip", objVendedorBE.Tip_Ven);

                cnx.Open();//abrimos coneccion

                cmd.ExecuteNonQuery();
                blnexito = true;
            }
            catch (SqlException x)
            {
                blnexito = false;
                throw new Exception(x.Message);
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
                // No olvidarse!!!!!!
                cmd.Parameters.Clear();
            }
            return blnexito;

        }
        public Boolean ActualizarVendedor(VendedorBE objVendedorBE)
        {
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ActualizarVendedor";
            //Agregamos parametros 
            try
            {
                //Codifique
                //agregamos PARAMETROS
                cmd.Parameters.AddWithValue("@vcod", objVendedorBE.Cod_Ven);
                cmd.Parameters.AddWithValue("@vnom", objVendedorBE.Nom_Ven);
                cmd.Parameters.AddWithValue("@vape", objVendedorBE.Ape_Ven);
                cmd.Parameters.AddWithValue("@vsue", objVendedorBE.Sue_Ven);
                cmd.Parameters.AddWithValue("@vfec", objVendedorBE.Fec_ing);
                cmd.Parameters.AddWithValue("@vtip", objVendedorBE.Tip_Ven);

                cnx.Open();//abrimos coneccion

                cmd.ExecuteNonQuery();
                blnexito = true;
            }
            catch (SqlException x)
            {
                blnexito = false;
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
                // No olvidarse!!!!!!
                cmd.Parameters.Clear();
            }
            return blnexito;

        }
        public Boolean EliminarVendedor(String strcod)
        {
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_EliminarVendedor";
            //Agregamos parametros 
            try
            {
                //Codifique
                //agregamos PARAMETROS
                cmd.Parameters.AddWithValue("@vcod", strcod);
                cnx.Open();
                cmd.ExecuteNonQuery();
                blnexito = true;
            }
            catch (SqlException x)
            {
                blnexito = false;
                throw new Exception(x.Message);
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
                // No olvidarse!!!!!!
                cmd.Parameters.Clear();
            }
            return blnexito;

        }
        public VendedorBE ConsultarVendedor(string strcod)
        {
            VendedorBE objVendedorBE = new VendedorBE();
            try
            {
                //Codifique
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ConsultarVendedor";
                cmd.Parameters.AddWithValue("@vcod", strcod);

                cnx.Open();
                dtr = cmd.ExecuteReader();

                if (dtr.HasRows == true)
                {
                    dtr.Read();
                    objVendedorBE.Cod_Ven = dtr["cod_ven"].ToString();
                    objVendedorBE.Nom_Ven = dtr["nom_ven"].ToString();
                    objVendedorBE.Ape_Ven = dtr["ape_ven"].ToString();
                    objVendedorBE.Sue_Ven = Convert.ToSingle(dtr["sue_ven"]); //convertir a single para moneda
                    objVendedorBE.Fec_ing = Convert.ToDateTime(dtr["fec_ing"]);//convertir a datetime para fecha
                    objVendedorBE.Tip_Ven = dtr["tip_ven"].ToString();
                }
                dtr.Close();
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
            return objVendedorBE;
        }
        public DataTable ListarVendedor()
        {
            DataSet dts = new DataSet();
            try
            {
                //Codifique
                SqlDataAdapter ada;
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarVendedor";

                ada = new SqlDataAdapter(cmd);
                ada.Fill(dts,"Vendedor");
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return dts.Tables["Vendedor"];
        }
        public DataTable ListarNombresVendedor()
        {
            DataSet dts = new DataSet();
            try
            {
                //Codifique
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return dts.Tables["NombresVendedor"];


        }
    }
}
