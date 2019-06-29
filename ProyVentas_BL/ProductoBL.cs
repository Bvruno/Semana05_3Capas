using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using ProyVentas_ADO;
using ProyVentas_BE;

namespace ProyVentas_BL
{
    public class ProductoBL
    {
        ProductoADO objProductoADO =new ProductoADO();

       public DataTable ListarProducto()
        {
            return objProductoADO.ListarProducto();
        }

       public DataView FiltrarProducto(String strcriterio)
       {
           return objProductoADO.FiltrarProducto(strcriterio);
       
       }
       public DataView OrdenarProducto(String strcriterio)
       {
           return objProductoADO.OrdenarProducto(strcriterio);
       }






       public ProductoBE ConsultarProducto(String strCodigo)
       {
           return objProductoADO.ConsultarProducto(strCodigo);
       }
    }
}
