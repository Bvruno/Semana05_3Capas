using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProyVentas_BE;
using ProyVentas_BL;

namespace ProyVentas_GUI
{
    public partial class VendedorMan02 : Form
    {
        VendedorBL  objVendedorBL = new VendedorBL();
        VendedorBE objVendedorBE = new VendedorBE();

        public VendedorMan02()
        {
            InitializeComponent();
        }
        private void btnGrabar_Click(object sender, EventArgs e)
        {
           try
            {
                //Codifique
                //asignamos los valores
                objVendedorBE.Nom_Ven = txtnom.Text.Trim();
                objVendedorBE.Ape_Ven = txtape.Text.Trim();
                objVendedorBE.Sue_Ven = Convert.ToSingle(txtsue.Text.Trim());
                objVendedorBE.Fec_ing = dtpFecIng.Value.Date;
                if (optest.Checked == true)
                {
                    objVendedorBE.Tip_Ven = "1";
                }
                else
                {
                    objVendedorBE.Tip_Ven = "2";
                }

                if (objVendedorBL.InsertarVendedor(objVendedorBE) == true)
                {
                    this.Close();
                }
                else
                {
                    throw new Exception("No se inserto el registro, verifique");
                }
            }
           catch ( Exception ex)
            {
           MessageBox .Show ("Se ha producido el error: " + ex.Message );
           }

         }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
