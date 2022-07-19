<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginForm.aspx.cs" Inherits="ASP.NetDay24Assignment.LoginForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td><label>EmailId</label></td>
                    <td>
                        <asp:TextBox ID="TxtEmailId" runat="server"></asp:TextBox></td>
                </tr>
                <tr><td><label>Password
                        </label></td>
                    <td>
                        <asp:TextBox ID="TxtPassword" runat="server" ></asp:TextBox></td>
                </tr>
                <tr><td>
                    <asp:Button ID="BtnLogIn" runat="server" Text="LogIn" OnClick="Button1_Click" />
                    </td></tr>
                <tr>
                    <td>
                        <asp:Label ID="LblMessage" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
