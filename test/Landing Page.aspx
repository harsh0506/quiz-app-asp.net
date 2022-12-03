<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Landing Page.aspx.cs" Inherits="test.Landing_Page" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        @import url('https://fonts.googleapis.com/css2?family=Merriweather+Sans:ital,wght@1,500&display=swap');
        @import url('https://fonts.googleapis.com/css2?family=Poppins:wght@200&display=swap');
        @import url('https://fonts.googleapis.com/css2?family=Poppins&display=swap');

        * {
            padding: 0;
            margin: 0;
        }

        #topnav {
            width: 100%;
            position: fixed;
            top: 0;
            left: 0;
            background-color: #1a2e35;
            font-family: Arial, sans-serif;
            font-size: 15px;
            height: 4rem;
        }

        .nav-link {
            display: inline-block;
            width: 100px;
            height: 55px;
            color: White;
            text-align: center;
            line-height: 55px;
            text-decoration: none;
        }

        #logo {
            width: 120px;
            background-color: #ff735c;
            font-weight: bold;
            height: 4rem;
            text-align: center;
            align-items: center;
            justify-content: center;
            display: flex;
        }

        #about {
            position: absolute;
            top: 9%;
            right: 2%;
        }

        #about2 {
            position: absolute;
            top: 9%;
            right: 11%;
        }

        .parag {
            width: 500px;
            text-align: left;
            height: 160px;
            padding-left: 60px
        }

        .auto-style1 {
            text-align: left;
        }
    </style>
</head>
<body>
    <nav id="topnav">
        <li id="logo" class="nav-link" style="width: 200px">Quiz Application </li>

        <asp:HyperLink ID="about2" class="nav-link" NavigateUrl="~/Login.aspx" runat="server">Create Quiz</asp:HyperLink>
        <asp:HyperLink ID="about" class="nav-link" NavigateUrl="~/SignIn.aspx" runat="server">Attempt Quiz</asp:HyperLink>
    </nav>

    <div style="width: 100%; padding-top: 50px; height: 650px; display: flex; flex-direction: row">

        <div style="padding: 25px; width: 45rem; height: 41rem; align-items: center; justify-content: center; display: flex; flex-direction: column;">
            <h1 class="" style="width: 500px; text-align: left;color: #1a2e35; line-height: 1.2; font-family: 'Poppins', sans-serif; font-size: 70px;">Quizes makes your brain sharp</h1>
            <asp:Label ID="Label1" Width="500px" Font-Size="25px" Style="font-family: 'Poppins', sans-serif; " runat="server" Text="Any.do is an award-winning app used by millions of people to stay organized and get more done." Height="75px"></asp:Label>
        </div>

        <div style="width: 40%; height: 41rem; align-items: center; justify-content: center; display: flex; flex-direction: column;">
            <asp:Image ID="Image1" runat="server" ImageUrl="~/img1.jpg" ImageAlign="Right" Height="82%" Width="87%" />
        </div>
    </div>

</body>
</html>
