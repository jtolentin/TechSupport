using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Data.Sql;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lblState.Text = "";
        if (!Page.IsPostBack)
        {
            lblState.Text = "";
            GridView1.DataBind();
        }

    }

    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        //Bind data to the GridView control.
        GridView1.DataBind();
    }

    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {

        try
        {
            //Set the edit index.
            GridView1.EditIndex = e.NewEditIndex;
            //Bind data to the GridView control.
            GridView1.DataBind();
        }
        catch (Exception ex)
        {
            lblState.Text = "A database connection error has occurred" + ex.Message;
        }
    }

    protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {

        try
        {
            //Reset the edit index.
            GridView1.EditIndex = -1;
            //Bind data to the GridView control.
            GridView1.DataBind();
        }
        catch (Exception ex)
        {
            lblState.Text = "A database connection error has occurred" + ex.Message;
        }
    }

    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {

        try
        {
            //Reset the edit index.
            GridView1.EditIndex = -1;

            //Bind data to the GridView control.
            GridView1.DataBind();
        }
        catch (Exception ex)
        {
            lblState.Text = "A database connection error has occurred" + ex.Message;
        }

    }

    protected void btnAddProduct_Click(object sender, EventArgs e)
    {
        lblState.Text = "";
        SqlDataSource1.InsertParameters["ProductCode"].DefaultValue = txtProductCode.Text;
        SqlDataSource1.InsertParameters["Name"].DefaultValue = txtName.Text;
        SqlDataSource1.InsertParameters["Version"].DefaultValue = txtVersion.Text;
        SqlDataSource1.InsertParameters["ReleaseDate"].DefaultValue = txtReleaseDate.Text;

        try
        {
            SqlDataSource1.Insert();
            lblState.Text = "Record Added Successfully";
            txtProductCode.Text = "";
            txtName.Text = "";
            txtVersion.Text = "";
            txtReleaseDate.Text = "";
        }
        catch (Exception ex)
        {
            lblState.Text = "A database connection error has occurred" + ex.Message;
        }
    }

    protected void GridView1_RowDeleted(object sender, GridViewDeletedEventArgs e)
    {

        try
        {
            lblState.Text = "Record Deleted Successfully";
        }
        catch (Exception ex)
        {
            lblState.Text = "A database connection error has occurred" + ex.Message;
        }

    }
    protected void GridView1_RowUpdated(object sender, GridViewUpdatedEventArgs e)
    {
        try
        {
            lblState.Text = "Record Updated Successfully";
            txtProductCode.Enabled = true;
            txtName.Enabled = true;
            txtVersion.Enabled = true;
            txtReleaseDate.Enabled = true;
            RFValidatorProductCode.Enabled = true;
            RFValidatorName.Enabled = true;
            RFValidatorVersion.Enabled = true;
            RFValidatorReleaseDate.Enabled = true;
            btnAddProduct.Enabled = true;
        }
        catch (Exception ex)
        {
            lblState.Text = "A database connection error has occurred" + ex.Message;
        }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        try
        {
            lblState.Text = "";
            txtProductCode.Enabled = false;
            txtName.Enabled = false;
            txtVersion.Enabled = false;
            txtReleaseDate.Enabled = false;
            RFValidatorProductCode.Enabled = false;
            RFValidatorName.Enabled = false;
            RFValidatorVersion.Enabled = false;
            RFValidatorReleaseDate.Enabled = false;
            btnAddProduct.Enabled = false;
        }
        catch (Exception ex)
        {
            lblState.Text = "A database connection error has occurred" + ex.Message;
        }

    }
    protected void btnUpdate_Click(object sender, EventArgs e)
    {

    }
}