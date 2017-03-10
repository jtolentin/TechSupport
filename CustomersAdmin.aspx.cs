using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Drawing;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lblState2.Text = "";
        if (!Page.IsPostBack)
        {
            GridView1.DataBind();
        }
    }
/*
    protected void DetailsView1_ItemUpdated(Object sender, System.Web.UI.WebControls.DetailsViewUpdatedEventArgs e)
    {
        try
        {
            lblState2.Text = "Record Updated Successfully";
            GridView1.DataBind();
        }
        catch (Exception ex)
        {
            lblState2.Text = "A database connection error has occurred" + ex.Message;
        }
    }

    protected void DetailsView1_ItemInserted(object sender, DetailsViewInsertedEventArgs e)
    {
        try
        {
            lblState2.Text = "Record Added Successfully";
            GridView1.DataBind();
        }
        catch (Exception ex)
        {
            lblState2.Text = "A database connection error has occurred" + ex.Message;
        }
    }
    protected void DetailsView1_ItemDeleted(object sender, DetailsViewDeletedEventArgs e)
    {
        try
        {
            lblState2.Text = "Record Deleted Successfully";
            GridView1.DataBind();
        }
        catch (Exception ex)
        {
            lblState2.Text = "A database connection error has occurred" + ex.Message;
        }
    }
    protected void btnSelect_Click(object sender, EventArgs e)
    {
        lblState2.Text = "";
    }
    protected void DetailsView1_ItemDeleting(object sender, DetailsViewDeleteEventArgs e)
    {
        try
        {
            lblState2.Text = "Record Deleted Successfully";
            GridView1.DataBind();
        }
        catch (Exception ex)
        {
            lblState2.Text = "A database connection error has occurred" + ex.Message;
        }
    }
    protected void DetailsView1_ItemInserting(object sender, DetailsViewInsertEventArgs e)
    {
        try
        {
            lblState2.Text = "Record Added Successfully";
            GridView1.DataBind();
        }
        catch (Exception ex)
        {
            lblState2.Text = "A database connection error has occurred" + ex.Message;
        }
    }
    protected void DetailsView1_ItemUpdating(object sender, DetailsViewUpdateEventArgs e)
    {
        try
        {
            lblState2.Text = "Record Updated Successfully";
            GridView1.DataBind();
        }
        catch (Exception ex)
        {
            lblState2.Text = "A database connection error has occurred" + ex.Message;
        }
    }
*/
    protected void DetailsView1_ItemDeleted(object sender, DetailsViewDeletedEventArgs e)
    {
        if (e.Exception != null)
        {
            lblState2.Text = "A database error has occurred. " +
                "Message: " + e.Exception.Message;
            e.ExceptionHandled = true;

        }
        else if (e.AffectedRows == 0)
            lblState2.Text = "An other user may have updated that. Please try again ";
        else
            GridView1.DataBind();
            lblState2.Text = "Record Deleted Successfully";
    }
    protected void DetailsView1_ItemUpdated(object sender, DetailsViewUpdatedEventArgs e)
    {
        if (e.Exception != null)
        {
            lblState2.Text = "A database error has occurred. " +
                "Message: " + e.Exception.Message;
            e.ExceptionHandled = true;
            e.KeepInEditMode = true;
        }
        else if (e.AffectedRows == 0)
            lblState2.Text = "Another user may have updated that. Please try again ";
        else
            GridView1.DataBind();
            lblState2.Text = "Record Updated Successfully";
    }
    protected void DetailsView1_ItemInserted(object sender, DetailsViewInsertedEventArgs e)
    {
        if (e.Exception != null)
        {
            lblState2.Text = "A database error has occurred. " +
                "Message: " + e.Exception.Message;
            e.ExceptionHandled = true;
            e.KeepInInsertMode = true;
        }
        else
            GridView1.DataBind();
            lblState2.Text = "Record Added Successfully";
    }
    protected void btnSelect_Click(object sender, EventArgs e)
    {
        lblState2.Text = "";
    }
    protected void GridView1_RowDeleted(object sender, GridViewDeletedEventArgs e)
    {
        if (e.Exception != null)
        {
            lblState2.Text = "A database error has occurred. " +
                "Message: " + e.Exception.Message;
            e.ExceptionHandled = true;
        }
        else if (e.AffectedRows == 0)
        {
            lblState2.Text = "No rows were deleted.";
        }
        else
            GridView1.DataBind();
            lblState2.Text = "Record Added Successfully";
    }
    protected void GridView1_RowUpdated(object sender, GridViewUpdatedEventArgs e)
    {
        if (e.Exception != null)
        {
            lblState2.Text = "A database error has occurred. " +
                "Message: " + e.Exception.Message;
            e.ExceptionHandled = true;
        }
        else if (e.AffectedRows == 0)
        {
            lblState2.Text = "No rows were updated.";
        }
        else
            GridView1.DataBind();
        lblState2.Text = "Record Added Successfully";
    }
}