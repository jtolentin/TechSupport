using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class _Default : System.Web.UI.Page
{
    private Incident surv;
    static String a;
    DataView surveyTable;
    DataRowView row;

    protected void Page_Load(object sender, EventArgs e)
    {
        txtBoxSurvey.Focus();
        lbSurvey.Enabled = false;

    }

    protected void btnIncident_Click(object sender, EventArgs e)
    {
        int cID;
        cID = int.Parse(txtBoxSurvey.Text);
        //surv = getData();
        surveyTable = (DataView)SqlDataSource1.Select(DataSourceSelectArguments.Empty);
        surveyTable.RowFilter = "CustomerID ='" + cID + "'";

        foreach (DataRowView drv in surveyTable)
        {
            //DataRowView row = (DataRowView)surveyTable[drv];
            DataRow row = drv.Row;
            surv = getData(row);

            if (a == "")
            {
                lblincident.Text = "There is no closed incident for this customer";
            }
            else
            {
                lbSurvey.Enabled = true;
                lblincident.Text = "";
                lbSurvey.Items.Add(surv.CustomerIncidentDisplay());
                rblResponseTime.Enabled = true;
                rblTechnicianEff.Enabled = true;
                rblProblemResolution.Enabled = true;
                txtboxComments.Enabled = true;
                cbContact.Enabled = true;
                rblContactList.Enabled = true;
            }
        }
    }

    private Incident getData(DataRow row)
    {
        int incidentid = int.Parse(row["IncidentID"].ToString());
        int customerid = int.Parse(row["CustomerID"].ToString());
        string pcode = row["ProductCode"].ToString();
        int techid = int.Parse(row["TechID"].ToString());
        string dateopen = row["DateOpened"].ToString();
        string dateclose = String.Format("{0:MM/dd/yyyy}", row["DateClosed"]);
        string title = row["Title"].ToString();
        string resolution = row["ResolutionNotes"].ToString();
        a = row["DateClosed"].ToString();
        this.surv = new Incident(incidentid, customerid, pcode, techid, dateopen, dateclose, title, resolution);
        return surv;
    }


    protected void Button2_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            Server.Transfer("SurveyComplete.aspx");
        }
    }
}