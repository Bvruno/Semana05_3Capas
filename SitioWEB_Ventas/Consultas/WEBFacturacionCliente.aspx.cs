using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyVentas_BL;

public partial class Consultas_WEBFacturacionCliente : System.Web.UI.Page
{
    ClienteBL objClienteBL = new ClienteBL();
    FacturaBL objfacturaBL = new FacturaBL();
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (Page.IsPostBack == false)
            { 
                cboCliente.DataSource = objClienteBL.ListarCiente();
                cboCliente.DataValueField = "cod_cli";
                cboCliente.DataTextField = "raz_soc_cli";
                cboCliente.DataBind();

                txtFI.Text = DateTime.Now.Date.ToShortDateString();
                txtFF.Text = DateTime.Now.Date.ToShortDateString();

                String codcli = cboCliente.SelectedValue.ToString();
                DateTime fi = Convert.ToDateTime(txtFI.Text.Trim());
                DateTime ff = Convert.ToDateTime(txtFF.Text.Trim());

                grvFacturas.DataSource = objfacturaBL.ListarFacturaCienteFecha(codcli, fi, ff);
                grvFacturas.DataBind();

                if (grvFacturas.Rows.Count == 0)
                {
                    throw new Exception("No existen facturas en el periodo seleccionado");
                }
            }
        }
        catch (Exception ex)
        {
            lblMensaje.Text = ex.Message;
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            lblMensaje.Text = "";
            String codcli = cboCliente.SelectedValue.ToString();
            DateTime fi = Convert.ToDateTime(txtFI.Text.Trim());
            DateTime ff = Convert.ToDateTime(txtFF.Text.Trim());

            grvFacturas.DataSource = objfacturaBL.ListarFacturaCienteFecha(codcli, fi, ff);
            grvFacturas.DataBind();

            if(grvFacturas.Rows.Count == 0)
            {
                throw new Exception("No existen facturas en el periodo seleccionado");
            }
        }
        catch(Exception ex)
        {
            lblMensaje.Text = ex.Message;
        }
    }
}