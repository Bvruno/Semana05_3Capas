using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyVentas_BL;

namespace ProyVentas_GUI
{
    public partial class frmConsFarturasCliente : Form
    {
        public frmConsFarturasCliente()
        {
            InitializeComponent();
        }

        private void frmConsFarturasCliente_Load(object sender, EventArgs e)
        {
            try
            {
                ClienteBL objCienteBL = new ClienteBL();
                cboCliente.DataSource = objCienteBL.ListarCiente();
                cboCliente.ValueMember = "cod_cli";
                cboCliente.DisplayMember = "raz_soc_cli";
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                FacturaBL objfacturaBL = new FacturaBL();

                String codCli = cboCliente.SelectedValue.ToString();
                DateTime fecIni = dtpFecIni.Value.Date;
                DateTime fecFin = dtpFecFin.Value.Date;

                dtgFacturas.DataSource = objfacturaBL.ListarFacturaCienteFecha(codCli, fecIni, fecFin);

                if(dtgFacturas.Rows.Count == 0)
                {
                    MessageBox.Show("No existen facturas para el cliente en el periodo seleccionado");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
