<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SurveyComplete.aspx.cs" Inherits="SurveyComplete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        body {
         margin: auto;
         width: 60%;
         border: 5px solid #1f1f1f;   
        }
        #footer {
           border-top: 3px solid #1a1a1a;
        }

        .auto-style4 {
            color: #00CC00;
        }
        .auto-style5 {
            color: #000000;
        }
        .auto-style6 {
            font-size: x-large;
        }
        .auto-style7 {
            width: 100%;
        }
        .auto-style8 {
            width: 593px;
        }
        .auto-style9 {
            width: 593px;
            color: #99FFCC;
        }
        #form1 {
            background-color: #999999;
        }
        .auto-style10 {
            color: #99FFCC;
            font-size: large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style4">
    
        <span class="auto-style10">&nbsp;&nbsp;
    
        SportsPro - Sports management software for sports enthusiast</span><br />
        <br />
        <span class="auto-style5"><strong><span class="auto-style6">&nbsp; Survey Complete</span></strong> -
        <asp:Label ID="lblDesc" runat="server" style="font-weight: 700"></asp:Label>
        </span>
    
    </div>
        <table class="auto-style7">
            <tr>
                <td class="auto-style9">&nbsp;&nbsp; Thank you for your feedback.</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style9">&nbsp;&nbsp; 
                    <asp:Label ID="lblContact" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style8">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style8">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style8">
                    &nbsp;&nbsp;
                    <asp:Button ID="Button1" runat="server" Text="Return to Survey" Width="161px" OnClick="Button1_Click" />
                    <br />
                    <br />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
    <div id="footer"  style="background-color: #999966">
            <strong>&copy;2016 - COMP2139- SportsPro</strong>
    </div>
</body>
    

</html>
