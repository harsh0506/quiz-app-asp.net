<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Add.aspx.cs" Inherits="test.Add" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .inputs {
            margin: 5px;
            border-radius: 9px;
            height: 2rem;
            text-align: center;
            border: none;
            columns: 2;
        }
    </style>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.6.1/jquery.min.js" integrity="sha512-aVKKRRi/Q/YV+4mjoKBsE4x3H+BkegoM/em46NNlCqNTmUYADjBbeNefNxYV7giUp0VxICtqdrbqU7iVaeZNXA==" crossorigin="anonymous" referrerpolicy="no-referrer"></script>
    <script>
        function show(str) {
            document.getElementById('nameoftest').style.display = 'none';
            document.getElementById('question').style.display = 'flex';
        }
        function show2(sign) {
            document.getElementById('nameoftest').style.display = 'flex';
            document.getElementById('question').style.display = 'none';
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">

        <input type="radio" name="r1" id="e1" onchange="show2()" />&nbsp;just create a text name&nbsp;&nbsp;&nbsp;
        <input type="radio" checked="checked" name="r1" onchange="show(this.value)" />&nbsp;input the values
        <div style="background-position: center center; display: flex; flex-direction: column; justify-content: center; align-items: center; padding: 0px; margin: 0px; font-family: 'Eras Demi ITC'; font-size: medium; font-weight: 400; font-style: normal; font-variant: normal; line-height: normal; vertical-align: middle; text-align: center; text-indent: inherit; word-spacing: 5em; background-color: white; color: #FFFFFF; position: absolute; z-index: 2; width: 100%; height: 100%;">

            <asp:HyperLink ID="HyperLink1" runat="server" Font-Size="20pt" BorderStyle="None" ForeColor="#2A474F" NavigateUrl="~/ChooseTest.aspx">choose test</asp:HyperLink>

            <br />
            <br />
            <br />

            <div id="nameoftest" style="display: flex; position: absolute; justify-content: center; align-items: center; width: 60%; background-color: #385A64; height: 22%; border-radius: 10px;">
                <asp:TextBox ID="TextBox1" runat="server" BorderStyle="None" Font-Size="20pt" Height="40px" Width="200px"></asp:TextBox>
                <asp:Button ID="Button1" runat="server" Text="create tabel" OnClick="Button1_Click" BackColor="#2A474F" BorderStyle="None" ForeColor="White" Height="41px" />
                <br />
                <asp:Label ID="Label1" runat="server"></asp:Label>
            </div>
            <br />



            <br />

            <div id="question" style="display: flex; flex-direction: column; justify-content: center; align-items: center; width: 60%; background-color: #385A64; height: 56%; border-radius: 10px;">

                <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="NameOfTest" DataValueField="NameOfTest" BackColor="#3E4553" Font-Size="Large" Width="150px" ForeColor="White" Height="50px">
                </asp:DropDownList>
                <asp:Button ID="Button2" runat="server" Style="color: White; background-color: #3E4553; border-style: None; height: 41px; width: 13%; background: #2a474f;"
                    OnClick="Button2_Click" Text="Button" BorderStyle="None" ForeColor="White" Height="41px" />
                <br />
                <asp:Label ID="Label8" runat="server"></asp:Label>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [NameOfTest] FROM [NameOfTest]"></asp:SqlDataSource>



                <asp:TextBox ID="TextBox2" Style="width: 40%; text-align: center; height: 8%; border-radius: 9px; border: none; columns: 2;"
                    placeholder="question" runat="server"></asp:TextBox>
                <br />

                <div style="display: flex; flex-direction: row; justify-content: center; align-items: center;">
                    <asp:TextBox CssClass="inputs" ID="TextBox3" placeholder="option a" runat="server"></asp:TextBox>
                    <asp:TextBox CssClass="inputs" ID="TextBox4" placeholder="option a" runat="server"></asp:TextBox>
                </div>

                <div style="display: flex; flex-direction: row; justify-content: center; align-items: center;">
                    <asp:TextBox CssClass="inputs" ID="TextBox5" placeholder="option a" runat="server"></asp:TextBox>
                    <asp:TextBox CssClass="inputs" ID="TextBox6" placeholder="option a" runat="server"></asp:TextBox>
                </div>

                <br />
                <asp:TextBox ID="TextBox7" CssClass="inputs" placeholder="answer here" runat="server"></asp:TextBox>
                <br />

                <asp:Button ID="Button3" runat="server" Text="add the question" OnClick="Button3_Click" />

            </div>
        </div>

    </form>
</body>
</html>
