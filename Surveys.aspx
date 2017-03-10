<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Surveys.aspx.cs" Inherits="_Default" %>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" >
    <title></title>
    <style type="text/css">
        

        .auto-style2 {
            color: #99FFCC;
            font-size: large;
        }
        .newStyle1 {
            font-size: x-large;
        }
        .auto-style3 {
            font-size: large;
            font-weight: normal;
        }
        .auto-style4 {
            width: 100%;
        }
        .auto-style5 {
            font-size: medium;
            font-weight: normal;
        }
        .auto-style10 {
            width: 227px;
            height: 44px;
        }
        .auto-style15 {
            width: 113px;
            height: 44px;
        }
        .auto-style16 {
            width: 113px;
        }
        .auto-style19 {
            width: 176px;
        }
        .auto-style20 {
            width: 227px;
        }
        #form1 {
            background-color: #999999;
        }
    </style>
</head>
<body>
    
        <span class="auto-style2">&nbsp;&nbsp; SportsPro - Sports management software for sports enthusiast</span><br />
        <br />
        <br />
        <span class="newStyle1"><strong>&nbsp;&nbsp; Survey</strong>&nbsp; - </span><span class="auto-style3">Collect feedback from customers<br />
        <br />
        <br />
        &nbsp;&nbsp;
        Enter your customer ID:
        <asp:TextBox ID="txtBoxSurvey" name="txtBoxSurvey" runat="server"></asp:TextBox>
&nbsp;<asp:Button ID="btnIncident" runat="server" Text="Get Incidents" Width="109px" OnClick="btnIncident_Click" />
        <br />
        &nbsp;&nbsp;
        <asp:Label ID="lblincident" runat="server" ForeColor="Red"></asp:Label>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtBoxSurvey" Display="Dynamic" ErrorMessage="CustomerID is required" ForeColor="Red"></asp:RequiredFieldValidator>
        <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtBoxSurvey" Display="Dynamic" ErrorMessage="CustomerID From 1000-1200" ForeColor="Red" MaximumValue="1200" MinimumValue="1000" Type="Integer"></asp:RangeValidator>
&nbsp;<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT IncidentID, CustomerID, ProductCode, TechID, DateOpened, DateClosed, Title, Description, ResolutionNotes FROM Incidents WHERE (CustomerID LIKE @CustomerID)">
            <SelectParameters>
                <asp:ControlParameter ControlID="txtBoxSurvey" Name="CustomerID" PropertyName="Text" Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>
        &nbsp;&nbsp;
        <br />
        &nbsp;&nbsp;&nbsp; Select Incedent:<br />
        &nbsp;&nbsp;
        <asp:ListBox ID="lbSurvey" runat="server" Height="96px" Width="419px" Enabled="False" >
            <asp:ListItem Enabled="False">--Select an Incident--</asp:ListItem>
        </asp:ListBox>
        <br />
        <br />
        </span><span class="auto-style5"><strong>&nbsp;&nbsp; Please Rate this incident by the following categories:</strong></span><table class="auto-style4">
            <tr>
                <td class="auto-style10">&nbsp;&nbsp; Response Time:</td>
                <td class="auto-style15">
                    <asp:RadioButtonList ID="rblResponseTime" runat="server" RepeatDirection="Horizontal" Width="634px" Enabled="False">
                        <asp:ListItem>Not Satisfied</asp:ListItem>
                        <asp:ListItem>Somewhat Satisfied</asp:ListItem>
                        <asp:ListItem>Satisfied</asp:ListItem>
                        <asp:ListItem>Completely Satisfied</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td class="auto-style20">&nbsp;</td>
                <td class="auto-style16">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style20">&nbsp;&nbsp; Technician Efficiency:</td>
                <td class="auto-style16">
                    <asp:RadioButtonList ID="rblTechnicianEff" runat="server" RepeatDirection="Horizontal" Width="634px" Enabled="False">
                        <asp:ListItem>Not Satisfied</asp:ListItem>
                        <asp:ListItem>Somewhat Satisfied</asp:ListItem>
                        <asp:ListItem>Satisfied</asp:ListItem>
                        <asp:ListItem>Completely Satisfied</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td class="auto-style20">&nbsp;</td>
                <td class="auto-style16">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style20">&nbsp;&nbsp; Problem resolution:</td>
                <td class="auto-style16">
                    <asp:RadioButtonList ID="rblProblemResolution" runat="server" RepeatDirection="Horizontal" Width="634px" Enabled="False">
                        <asp:ListItem>Not Satisfied</asp:ListItem>
                        <asp:ListItem>Somewhat Satisfied</asp:ListItem>
                        <asp:ListItem>Satisfied</asp:ListItem>
                        <asp:ListItem>Completely Satisfied</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td class="auto-style20">&nbsp;</td>
                <td class="auto-style16">&nbsp;</td>
            </tr>
        </table>
        <table class="auto-style4">
            <tr>
                <td class="auto-style19">&nbsp;</td>
                <td rowspan="3">
                    <asp:TextBox ID="txtboxComments" runat="server" Rows="5" TextMode="MultiLine" Width="265px" Enabled="False"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style19">&nbsp;&nbsp; Additional Comments</td>
            </tr>
            <tr>
                <td class="auto-style19">&nbsp;</td>
            </tr>
        </table>
        <br />
&nbsp;<asp:CheckBox ID="cbContact" runat="server" Enabled="False" />
        Please Contact me to discuss this incident<br />
        <asp:RadioButtonList ID="rblContactList" runat="server" Enabled="False" RepeatDirection="Horizontal">
            <asp:ListItem>Contact by Email</asp:ListItem>
            <asp:ListItem>Contact by Phone</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        &nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Text="Submit" OnClick="Button2_Click" Width="125px" />
        <br />
        <br />
        <br />
   
</body>
    

</html>
</asp:Content>

