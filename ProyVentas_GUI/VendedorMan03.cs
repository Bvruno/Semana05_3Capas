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
    public partial class VendedorMan03 : Form
    {
        VendedorBE objVendedorBE = new VendedorBE();
        VendedorBL objVendedorBL = new VendedorBL();
        public VendedorMan03()
        {
            InitializeComponent();
        }
        // Propiedad para identificar el codigo  del vendedor a actualizar
        private String mvarcodigo;
        public String Codigo
        {
            get { return mvarcodigo; }
            set { mvarcodigo = value; }
        }

        private void VendedorMan03_Load(object sender, EventArgs e)
        {
            try
            {
                //Codifique
                objVendedorBE = objVendedorBL.ConsultarVendedor(this.Codigo);

                //Mostramos los datos...
                txtnom.Text = objVendedorBE.Nom_Ven;
                txtape.Text = objVendedorBE.Ape_Ven;
                txtsue.Text = objVendedorBE.Sue_Ven.ToString();
                dtpFecIng.Value = objVendedorBE.Fec_ing;

                if (objVendedorBE.Tip_Ven == "1")
                {
                    optest.Checked = true;
                }
                else
                {
                    optcon.Checked = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            
            try
            {
                //Codifique
                //asignamos los valores
                objVendedorBE.Cod_Ven = this.Codigo;
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

                if (objVendedorBL.ActualizarVendedor(objVendedorBE) == true)
                {
                    this.Close();
                }
                else
                {
                    throw new Exception("No se inserto el registro, verifique");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido el error: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
