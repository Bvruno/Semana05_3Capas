using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using  ProyVentas_BL;

namespace ProyVentas_GUI
{
    public partial class VendedorMan01 : Form
    {

        VendedorBL objVendedorBL = new VendedorBL();
       
        public VendedorMan01()
        {
            InitializeComponent();
        }

        public void CargarDatos()
        {            
            dtgVendedor.DataSource = objVendedorBL.ListarVendedor();
        }

        private void VendedorMan01_Load(object sender, EventArgs e)
        {
            try
            {
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                //Codifique
                VendedorMan02 frm2 = new VendedorMan02();
                frm2.ShowDialog();
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : "  + ex.Message );
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                //Codifique
                VendedorMan03 frm3 = new VendedorMan03();
                String strCod = dtgVendedor.CurrentRow.Cells[0].Value.ToString();
                frm3.Codigo = strCod;
                frm3.ShowDialog();
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : "  + ex.Message );
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                //Codifique
                DialogResult vrpta;
                vrpta = MessageBox.Show("Esta seguro de eliminar el registro?", "Confirmar", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (vrpta == DialogResult.Yes)
                {
                    String strcod = dtgVendedor.CurrentRow.Cells[0].Value.ToString();
                    if (objVendedorBL.EliminarVendedor(strcod) == true)
                    {
                        CargarDatos();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : "  + ex.Message );
            }
            
        }
    }
}
