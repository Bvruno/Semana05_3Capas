using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class EjemplosExtensores_DemoModalPopPup : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnCalcular_Click(object sender, EventArgs e)
    {
        try
        {
            Int16 intHoras = Convert.ToInt16(txtHoras.Text.Trim());
            Int16 intTarifa = Convert.ToInt16(txtTarifa.Text.Trim());
            Int16 intTardanzas = Convert.ToInt16(txtTardanzas.Text.Trim());

            // Calculamos

            Single sngMontoHoras = intHoras * intTarifa;
            Single sngMontotardanzas = intTardanzas * (intTarifa * 25 / 100);
            Single sngNeto = sngMontoHoras - sngMontotardanzas;

            //Mostramos

            txtNeto.Text = sngNeto.ToString("##,###.00 soles");

            lblMensaje.Text = "Calculos correctos";
            mpeMensaje.Show();


        }
        catch (Exception ex)
        {
            txtHoras.Text = "";
            txtTardanzas.Text = "";
            txtNeto.Text = "";
             lblMensaje.Text = ex.Message;
            mpeMensaje.Show();

        }
        
     
    }

    protected void btnAceptarTarifa_Click(object sender, EventArgs e)
    {
        try
        {
            lblError.Text = String.Empty;
            if (cboCategoria.SelectedValue == "0")
            {
                throw new Exception("Debe elegir una tarifa");
            }
            else
            {
                txtTarifa.Text = cboCategoria.SelectedValue.ToString();
            }
        }
        catch (Exception ex)
        {
            lblError.Text = ex.Message;
            mpTarifario.Show();
        }
    }

    protected void btnBuscar_Click(object sender, ImageClickEventArgs e)
    {
        lblMensaje.Text = "";
        mpTarifario.Show();
    }
}