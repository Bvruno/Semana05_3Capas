using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using ProyVentas_BE;
namespace ProyVentas_ADO
{
    public class ProveedorADO
    {
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;
        Boolean blnexito = false;

        DataView dtv;
      
        
        // Metodos de mantenimiento
        public Boolean InsertarProveedor(ProveedorBE objProveedorBE)
        {
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_InsertarProveedor";
            //Agregamos parametros 
            try
            {
                cmd.Parameters.Add(new SqlParameter("@vraz", SqlDbType.VarChar, 25));
                cmd.Parameters["@vraz"].Value = objProveedorBE.Raz_soc_prv;
                cmd.Parameters.Add(new SqlParameter("@vdir", SqlDbType.VarChar, 25));
                cmd.Parameters["@vdir"].Value = objProveedorBE.Dir_prv;
                cmd.Parameters.Add(new SqlParameter("@vtel", SqlDbType.Char,10));
                cmd.Parameters["@vtel"].Value = objProveedorBE.Tel_prv;
                cmd.Parameters.Add(new SqlParameter("@vdis", SqlDbType.Char,3));
                cmd.Parameters["@vdis"].Value = objProveedorBE.Cod_dis;
                cmd.Parameters.Add(new SqlParameter("@vrep", SqlDbType.VarChar, 25));
                cmd.Parameters["@vrep"].Value = objProveedorBE.Rep_ven;
                cnx.Open();
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
                cmd.Parameters.Clear();
            }
            return blnexito;

        }
        public Boolean ActualizarProveedor(ProveedorBE objProveedorBE)
        {
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ActualizarProveedor";
            //Agregamos parametros 
            try
            {
                cmd.Parameters.Add(new SqlParameter("@vcod", SqlDbType.Char, 4));
                cmd.Parameters["@vcod"].Value = objProveedorBE.Cod_prv;

                cmd.Parameters.Add(new SqlParameter("@vraz", SqlDbType.VarChar, 25));
                cmd.Parameters["@vraz"].Value = objProveedorBE.Raz_soc_prv;
                cmd.Parameters.Add(new SqlParameter("@vdir", SqlDbType.VarChar, 25));
                cmd.Parameters["@vdir"].Value = objProveedorBE.Dir_prv;
                cmd.Parameters.Add(new SqlParameter("@vtel", SqlDbType.Char, 10));
                cmd.Parameters["@vtel"].Value = objProveedorBE.Tel_prv;
                cmd.Parameters.Add(new SqlParameter("@vdis", SqlDbType.Char, 3));
                cmd.Parameters["@vdis"].Value = objProveedorBE.Cod_dis;
                cmd.Parameters.Add(new SqlParameter("@vrep", SqlDbType.VarChar, 25));
                cmd.Parameters["@vrep"].Value = objProveedorBE.Rep_ven;
                cnx.Open();
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
                cmd.Parameters.Clear();
            }
            return blnexito;

        }

        public Boolean EliminarProveedor(String strcod)
        {
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_EliminarProveedor";
            //Agregamos parametros 
            try
            {
                cmd.Parameters.Add(new SqlParameter("@vcod", SqlDbType.Char, 4));
                cmd.Parameters["@vcod"].Value = strcod;
                cnx.Open();
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
                cmd.Parameters.Clear();
            }
            return blnexito;

        }

        public ProveedorBE ConsultarProveedor(String strcod)
        {
            ProveedorBE objProveedorBE = new ProveedorBE();
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ConsultarProveedor";
               //Agregamos parametro
                cmd.Parameters.Add(new SqlParameter("@vcod", SqlDbType.Char, 4));
                cmd.Parameters["@vcod"].Value = strcod;
                cnx.Open();
                dtr = cmd.ExecuteReader();
                if (dtr.HasRows == true)
                {
                    dtr.Read();
                   
                    objProveedorBE.Cod_prv = dtr.GetValue(dtr.GetOrdinal("Cod_prv")).ToString();
                    objProveedorBE.Raz_soc_prv = dtr.GetValue(dtr.GetOrdinal("Raz_soc_prv")).ToString();
                    objProveedorBE.Dir_prv = dtr.GetValue(dtr.GetOrdinal("Dir_prv")).ToString();
                    objProveedorBE.Tel_prv = dtr.GetValue(dtr.GetOrdinal("Tel_prv")).ToString ();
                    objProveedorBE.Cod_dis =dtr.GetValue(dtr.GetOrdinal("Cod_dis")).ToString ();
                    objProveedorBE.Rep_ven = dtr.GetValue(dtr.GetOrdinal("Rep_ven")).ToString();
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
            return objProveedorBE;
        }

        public DataTable ListarProveedor()
        {
            DataSet dts = new DataSet();
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarProveedor";
                SqlDataAdapter miada;
                miada = new SqlDataAdapter(cmd);
                miada.Fill(dts, "Proveedores");
                dtv = dts.Tables["Proveedores"].DefaultView;
           }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return dts.Tables["Proveedores"];
        }

        public DataView FiltrarProveedor(String strCriterio)
        {
            try
            {
                dtv.RowFilter = "raz_soc_prv like '%" + strCriterio + "%'";

            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return dtv;
       
        }

        public DataTable ConsultarProveedoresProducto(String strcodpro)
        {
            DataSet dts = new DataSet();
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ConsultarProveedoresProducto";
                cmd.Parameters.Add(new SqlParameter("@cod_pro", SqlDbType.Char, 4));
                cmd.Parameters["@cod_pro"].Value = strcodpro;
                SqlDataAdapter miada = default(SqlDataAdapter);
                miada = new SqlDataAdapter(cmd);
                miada.Fill(dts, "ProveedoresProducto");
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cmd.Parameters.Clear();
            }
            return dts.Tables["ProveedoresProducto"];
        }
    }
}
