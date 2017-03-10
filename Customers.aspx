<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Customers.aspx.cs" Inherits="_Default" %>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">

    <!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head >
    <title></title>
    <style type="text/css">
       

        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            color: #00FF00;
        }
        #form1 {
            font-weight: 700;
            background-color: #999999;
        }
        .newStyle1 {
            font-size: x-large;
        }
        .newStyle2 {
            font-size: large;
        }
        .auto-style3 {
            font-size: large;
            font-weight: normal;
        }
        .auto-style4 {
            font-weight: normal;
            height: 23px;
            width: 354px;
        }
        .auto-style5 {
            height: 23px;
        }
        .auto-style6 {
            width: 354px;
        }
        .auto-style7 {
            width: 354px;
            font-weight: normal;
        }
        .auto-style8 {
            font-size: large;
            color: #99FFCC;
        }
        </style>
</head>
<body>
   
        <span class="auto-style2">&nbsp;</span><span class="auto-style8">
        <br />
&nbsp; SportsPro - Sports management software for sports enthusiast</span><br />
        <br />
        <span class="newStyle1">&nbsp;Customer&nbsp; - </span><span class="auto-style3">Search and view customer contact information</span><br />
        <table class="auto-style1">
            <tr>
                <td class="auto-style4">&nbsp;&nbsp; Select a customer :
                    <asp:DropDownList ID="ddlCustomerNames" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="Name" DataValueField="CustomerID" Height="32px" Width="213px">
                    </asp:DropDownList>
                </td>
                <td class="auto-style5">
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Customers]"></asp:SqlDataSource>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7">&nbsp;&nbsp; Address :
                    <asp:Label ID="lblAddress" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
                    <asp:Label ID="lblCity" runat="server"></asp:Label>
&nbsp;,
                    <asp:Label ID="lblState" runat="server"></asp:Label>
&nbsp;<asp:Label ID="lblZipCode" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7">&nbsp;&nbsp; Phone: <asp:Label ID="lblPhone" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7">&nbsp;&nbsp; Email :
                    <asp:Label ID="lblEmail" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6">
&nbsp;&nbsp;&nbsp;&nbsp;
                    </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6">&nbsp;&nbsp;
                    <asp:Button ID="Button1" runat="server" Text="Add to Contact List" Width="149px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Display Contact List" Width="160px" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
   
</body>
    

</html>


</asp:Content>

