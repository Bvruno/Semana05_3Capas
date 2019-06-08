using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ProyVentas_ADO;

namespace ProyVentas_BL
{
    public class FacturaBL
    {
        FacturaADO objFacturaADO = new FacturaADO();

        public DataTable ListarFacturaCienteFecha(String codCli, DateTime fecIni, DateTime fecFin)
        {
            return objFacturaADO.ListarFacturasClienteFechas(codCli, fecIni, fecFin);
        }
    }
}
