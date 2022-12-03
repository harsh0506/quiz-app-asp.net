<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Test.aspx.cs" Inherits="test.Test" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="padding: 0px; margin: 0px; background-position: center center; font-family: 'Eras Demi ITC'; font-style: normal; background-color: #2B2E39; color: #FFFFFF; line-height: normal; vertical-align: middle; text-align: center; text-indent: 10px; word-spacing: normal;">
            test page
            <br />
            <asp:Label ID="Label1" runat="server" Font-Names="Bahnschrift" Font-Size="XX-Large" ForeColor="White"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label13" runat="server" BorderStyle="None" Font-Size="18pt"></asp:Label>
            <br />
            <br />
            <asp:Repeater ID="Repeater1" runat="server">

                <ItemTemplate>
                    QUESTION:
                   
                     <asp:Label runat="server" Text='<%# Eval("QUESTION") %>' ID="QUESTIONLabel"></asp:Label>
                    
                    <br />
                    A:
                     <asp:RadioButton ID="Radio1" runat="server" GroupName="option" Text='<%# Eval("A") %>' />
                    <br />
                    C:
                     <asp:RadioButton ID="Radio2" runat="server" GroupName="option" Text='<%# Eval("C") %>' />
                    <br />
                    D:
                     <asp:RadioButton ID="Radio3" runat="server" GroupName="option" Text='<%# Eval("D") %>' />
                    <br />
                    B:
                     <asp:RadioButton ID="Radio4" runat="server" GroupName="option" Text='<%# Eval("B") %>' />
                    <br />
                    <br />
                    <asp:Label ID="label3" runat="server" Text="right ans is" Visible="true" />
                    <asp:Label ID="label12" runat="server" Text='<%# Eval("ANS") %>' Visible="true" />
                    <br />
                    <asp:Label ID="Label2" runat="server" Text="Label" Visible="true"></asp:Label>

                    <br />
                </ItemTemplate>

            </asp:Repeater>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="submit test" BackColor="#3E4553" BorderStyle="None" Font-Size="20pt" ForeColor="White" Height="40px" UseSubmitBehavior="False" Width="200px" />
            <br />
            <br />
            
            <br />
        </div>
    </form>
</body>
</html>
