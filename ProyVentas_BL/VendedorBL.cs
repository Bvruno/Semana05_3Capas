using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using ProyVentas_BE;
using ProyVentas_ADO;
namespace ProyVentas_BL
{
    public class VendedorBL
    {
        VendedorADO objVendedorADO = new VendedorADO();
  
        public Boolean InsertarVendedor(VendedorBE objVendedorBE)
        {
            return objVendedorADO.InsertarVendedor(objVendedorBE);
        }
        public Boolean ActualizarVendedor(VendedorBE objVendedorBE)
        {
            return objVendedorADO.ActualizarVendedor(objVendedorBE);
        }
      public Boolean EliminarVendedor(String strcod)
        {
            return objVendedorADO.EliminarVendedor(strcod);
        }
      public VendedorBE ConsultarVendedor(String strcod)
      {
          return objVendedorADO.ConsultarVendedor(strcod);
        }
         public DataTable ListarVendedor()
        {
            return objVendedorADO.ListarVendedor();
        }
         public DataTable ListarNombresVendedor()
         {
             return objVendedorADO.ListarNombresVendedor();
         }
    }
}
