<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="WeatherApp.Main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        html, body{
            padding:0;
            margin:0;
            font-family:Arial;
        }
        *{
            box-sizing:border-box;
        }
        .container{
            margin-top:20px;
            padding:10px;
            font-size:20px;
            background:#e0e0e0;
            border-radius:15px;
        }
        .row{
            width:100%;
            display:flex;
        }
        .column-align{
            flex-direction:column;
        }
        .column{
            width:50%;
            display:flex;
        }
        .first{
            align-items:center;
            position:relative;
        }
        .other-temp{
            position:absolute;
            bottom:10px;
        }
        h1{
            font-size:40px;
            margin:0;
            padding:0;
        }
        h2{
            padding:0;
            margin:0;
        }

        .app{
            margin: 50px auto 0 auto;
            min-width:700px;
            max-width:800px;
        }
        #textbox{
            width:100%;
            margin-right:10px;
            font-size:30px;
            border-radius:5px;
        }
        #afiseaza_vremea{
            width:30%;
            font-size:20px;
            border-radius:5px;
            outline:none;
        }
        .top{
            display:flex;
            justify-content: space-between;
        }

    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="app">
            <div class="top">
                <asp:TextBox runat="server" ID="textbox"></asp:TextBox>
                <asp:Button runat="server" ID="afiseaza_vremea" Text="Afiseaza vremea" OnClick="afiseaza_vremea_Click"/>
            </div>
            <div class="container" runat="server" id="container">
                <div class="row column-align">
                    <h2><label runat="server" id="lbl_oras"></label></h2>
                    <label runat="server" id="lbl_vreme"></label>
                    <label runat="server" id="rez"></label>
                </div>
                <div class="row">
                    <div class="column first">
                        <asp:Image runat="server" ID="img_icon_vreme"/>
                        <div class="column-align">
                            <h1><label runat="server" id="lbl_temp"></label></h1>
                            <div class="other-temp">
                               <label runat="server" id="lbl_max_temp"></label>
                               <label runat="server" id="lbl_min_temp"></label>
                            </div>
                        </div>
                    </div>
                    <div class="column column-align"><br />
                        <label runat="server" id="lbl_innorat"></label>
                        <label runat="server" id="lbl_umiditate"></label>
                        <label runat="server" id="lbl_vant"></label>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
