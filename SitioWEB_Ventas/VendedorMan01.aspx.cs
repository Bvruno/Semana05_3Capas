using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyVentas_BE;
using ProyVentas_BL;

public partial class VendedorMan01 : System.Web.UI.Page
{
    VendedorBL objVendedorBL = new VendedorBL();
    VendedorBE objVendedorBE = new VendedorBE();
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (Page.IsPostBack == false)
                EnlazarDatos();
        }catch(Exception ex)
        {
            lblMensaje.Text = ex.Message;
            mpeMensaje.Show();
        }
    }

    public void EnlazarDatos()
    {
        grvDatos.DataSource = objVendedorBL.ListarVendedor();
        grvDatos.DataBind();
    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnNuevo_Click(object sender, EventArgs e)
    {
        lblError.Text = "";
        txtNom.Text = "";
        txtApe.Text = "";
        txtFecIng.Text = "";
        txtSue.Text = "";
        cboTipo.SelectedValue = "0";

        mpInsertar.Show();
    }

    protected void btnGravar_Click(object sender, EventArgs e)
    {
        try
        {
            //LLENAMOS LOS DATOS
            objVendedorBE.Ape_Ven = txtApe.Text.Trim();
            objVendedorBE.Nom_Ven = txtNom.Text.Trim();
            objVendedorBE.Fec_ing = Convert.ToDateTime(txtFecIng.Text.Trim());
            objVendedorBE.Sue_Ven = Convert.ToSingle(txtSue.Text.Trim());
            if(cboTipo.SelectedValue == "0")
            {
                throw new Exception("Debe seleccionar un tipo");

            }objVendedorBE.Tip_Ven = cboTipo.SelectedValue.ToString();
            if (objVendedorBL.InsertarVendedor(objVendedorBE) == true)
            {
                EnlazarDatos();
            }
            else
            {
                throw new Exception("No se inserto registro. Contacte con IT.");
            }
        }
        catch(Exception ex)
        {
            lblError.Text = ex.Message;
            mpInsertar.Show();
        }
    }

    protected void grvDatos_RowCommand(object sender, GridViewCommandEventArgs e)
    {

    }
}