<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChooseTest.aspx.cs" Inherits="test.ChooseTest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            left: -2px;
            top: 6px;
            width: 100%;
            height: 100%;
            overflow: hidden;
            visibility: visible;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1" style="font-family: 'Eras Demi ITC';font-size: xx-large; font-style: normal; font-variant: normal; line-height: normal; vertical-align: middle; text-align: center; text-indent: 10px; white-space: normal; background-color: #2A474F; color: #FFFFFF; background-repeat: no-repeat; background-position: center center; padding: 5px; margin: 5px; display: inline-block; font-weight: 400;">
            choose one test&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="NameOfTest" DataValueField="NameOfTest" BackColor="#385A64" Font-Size="Large" ForeColor="White" Height="50px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Width="150px"></asp:DropDownList>
            <br />
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [NameOfTest] FROM [NameOfTest]"></asp:SqlDataSource>

            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="go to the text" BackColor="#385A64" BorderStyle="None" Font-Size="17pt" ForeColor="White" Height="60px" Width="260px" stule=" border-radius:20px; " BorderColor="Black" ValidateRequestMode="Disabled"/>

            <br />
            <br />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Want to create Your own test " Font-Size="26pt"></asp:Label>
            <asp:HyperLink ID="HyperLink1" runat="server" Font-Size="26pt" NavigateUrl="~/Add.aspx" BorderStyle="None" ForeColor="White">click</asp:HyperLink>

        </div>
    </form>
</body>
</html>
