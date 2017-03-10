using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class _Default : System.Web.UI.Page
{
    private CustomerData cust;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack) ddlCustomerNames.DataBind();
        cust = getCustomerData();
        // lblName.Text = cust.getName();
        lblAddress.Text = cust.getAddress();
        lblCity.Text = cust.getCity();
        lblState.Text = cust.getState();
        lblZipCode.Text = cust.getZipCode();
        lblPhone.Text = cust.getPhone();
        lblEmail.Text = cust.getEmail();
    }
    private CustomerData getCustomerData()
    {
        DataView customerTable = (DataView)SqlDataSource1.Select(DataSourceSelectArguments.Empty);
        customerTable.RowFilter = "CustomerID ='" + ddlCustomerNames.SelectedValue + "'";
        DataRowView row = (DataRowView)customerTable[0];

        string customerid = row["CustomerID"].ToString();
        string name = row["Name"].ToString();
        string address = row["Address"].ToString();
        string city = row["City"].ToString();
        string state = row["State"].ToString();
        string zipCode = row["ZipCode"].ToString();
        string phone = row["Phone"].ToString();
        string email = row["Email"].ToString();
        this.cust = new CustomerData(customerid, name, address, city, state, zipCode, phone, email);
        return cust;
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        CallListData clist = CallListData.getCallList();
        if (this.cust != null)
        {
            clist.add(this.cust);
            Server.Transfer("ContactList.aspx");
        }
    }
}