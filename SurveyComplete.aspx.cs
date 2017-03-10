using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SurveyComplete : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            ListBox selIncident = (ListBox)PreviousPage.FindControl("lbSurvey");
            CheckBox contact = (CheckBox) PreviousPage.FindControl("cbContact");
            bool a = contact.Checked;
            string desc = selIncident.SelectedItem.Text;
            lblDesc.Text = desc;
            if (a == true)
            {
                lblContact.Text = "You wished to be contacted and a customer service representative will contact you within 24 hours.";
            }
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Server.Transfer("Survey.aspx");
    }
}