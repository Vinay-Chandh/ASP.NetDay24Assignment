<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="ASP.NetDay24Assignment.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Welcome</h1>
            <p>
                <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataKeyNames="vEmailId" DataSourceID="SqlDataSource1">
                    <Columns>
                        <asp:BoundField DataField="vFirstName" HeaderText="vFirstName" SortExpression="vFirstName" />
                        <asp:BoundField DataField="vLastName" HeaderText="vLastName" SortExpression="vLastName" />
                        <asp:BoundField DataField="dBirthDate" HeaderText="dBirthDate" SortExpression="dBirthDate" />
                        <asp:BoundField DataField="cGender" HeaderText="cGender" SortExpression="cGender" />
                        <asp:BoundField DataField="vEmailId" HeaderText="vEmailId" ReadOnly="True" SortExpression="vEmailId" />
                        <asp:BoundField DataField="vPassword" HeaderText="vPassword" SortExpression="vPassword" />
                    </Columns>
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:HRConnectionString2 %>" SelectCommand="SELECT * FROM [Registration]"></asp:SqlDataSource>
            </p>
            
            <asp:Button ID="BtnSignOut" runat="server" Text="SignOut" OnClick="BtnSignOut_Click" />
        </div>
    </form>
</body>
</html>
