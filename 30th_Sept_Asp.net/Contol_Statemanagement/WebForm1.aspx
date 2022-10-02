<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="contol_statemangement.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:Label ID="userid" runat="server" Text="User ID"></asp:Label>
            <asp:TextBox ID="txtUserid" runat="server"></asp:TextBox>
            <asp:Label ID="Label1" runat="server" Text="" OnDataBinding="submitbtn_Click"> </asp:Label>
            <br />
            <asp:Label ID="password" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="Txtpassword" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <asp:Button ID="submitbtn" runat="server" OnClick="submitbtn_Click" Text="Submit" />

        </div>
    </form>
</body>
</html>
