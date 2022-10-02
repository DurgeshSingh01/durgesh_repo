<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="contol_statemangement.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Hey welcome....<br />
            <asp:Label ID="lblfirst" runat="server" Text="First Name"></asp:Label>
            <asp:TextBox ID="txtfirst" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblsecond" runat="server" Text="Last Name"></asp:Label>
            <asp:TextBox ID="txtlast" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lbldob" runat="server" Text="Date of Birth"></asp:Label>
            <asp:TextBox ID="txtdob" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblcity" runat="server" Text="City"></asp:Label>
            <asp:TextBox ID="txtcity" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblstate" runat="server" Text="State"></asp:Label>
            <asp:TextBox ID="txtstate" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnsubmit" runat="server" OnClick="btnsubmit_Click" Text="Submit" />
&nbsp;
            <asp:Button ID="btnreset" runat="server" Text="Reset" />
        </div>
    </form>
</body>
</html>
