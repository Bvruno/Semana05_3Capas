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

    public void Limpiar()
    {
        lblError.Text = "";
        txtNom.Text = "";
        txtApe.Text = "";
        txtFecIng.Text = "";
        txtSue.Text = "";
        cboTipo.SelectedValue = "0";
    }

    protected void btnNuevo_Click(object sender, EventArgs e)
    {

        Limpiar();
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
            }
            objVendedorBE.Tip_Ven = cboTipo.SelectedValue.ToString();
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
        if (e.CommandName == "Eliminar")
        {
            try
            {
                int rowIndex = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = grvDatos.Rows[rowIndex];
                String strcod = row.Cells[1].Text;
                if (objVendedorBL.EliminarVendedor(strcod) == true)
                {
                    EnlazarDatos();
                }
                else
                {
                    throw new Exception("No se elimino el registro. Contacte con IT.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error"+ex);
            }
        }

        if (e.CommandName == "Editar")
        {
            try
            {
                int rowIndex = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = grvDatos.Rows[rowIndex];
                String cod = row.Cells[1].Text;
                String ape = row.Cells[2].Text;
                String nom = row.Cells[3].Text;
                String fec = row.Cells[5].Text;
                String sue = row.Cells[4].Text;
                String tip = row.Cells[6].Text;

                lblError.Text = "";
                lblCod2.Text = cod;
                txtNom2.Text = ape;
                txtApe2.Text = nom;
                txtFecIng2.Text = fec;
                txtSue2.Text = sue;
                cboTipo2.Text = tip;

                mpActualizar.Show();
            }
            catch (Exception ex)
            {
                throw new Exception("Error" + ex);
            }
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {

    }

    protected void btnActualizar_Click(object sender, EventArgs e)
    {

        try
        {
            objVendedorBE.Cod_Ven = lblCod2.Text.Trim();
            objVendedorBE.Ape_Ven = txtApe2.Text.Trim();
            objVendedorBE.Nom_Ven = txtNom2.Text.Trim();
            objVendedorBE.Fec_ing = Convert.ToDateTime(txtFecIng2.Text.Trim());
            objVendedorBE.Sue_Ven = Convert.ToSingle(txtSue2.Text.Trim());
            if (cboTipo2.SelectedValue == "0")
            {
                throw new Exception("Debe seleccionar un tipo");
            }
            objVendedorBE.Tip_Ven = cboTipo2.SelectedValue.ToString();

            if (objVendedorBL.ActualizarVendedor(objVendedorBE) == true)
            {
                EnlazarDatos();
                Limpiar();
            }
            else
            {
                throw new Exception("No se inserto registro. Contacte con IT.");
            }
        }
        catch (Exception ex)
        {
            lblError.Text = ex.Message;
            mpActualizar.Show();
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Limpiar();
    }
}
