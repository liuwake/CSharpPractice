﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication3.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="width: 1800px; height: 20px; background: Aqua; margin: 0 auto;">
            <div style="width: auto; margin: 0 auto; height: auto; text-align: center">
                <asp:Label ID="Label1" runat="server" Text="医疗信息自动化B平台(浏览器端)Demo"></asp:Label>
            </div>
        </div>
        <div style="width: 1800px; margin: 0 auto; height: 800px;">
            <div style="height: 800px; background: #555; width: 600px; float: left">
                <asp:Image ID="Image1" runat="server" Height="800px" Width="600px" />
            </div>
            <div style="height: 800px; background: #555; width: 600px; float: left">
                <asp:Image ID="Image2" runat="server" Height="800px" Width="600px" />
            </div>

            <div style="height: 800px; background: #ccc; width: 600px; float: right">
                <div style="height: 500px; background: #ccc; width: 600px; float: left">

                    <asp:TextBox ID="TextBox1" runat="server" Height="500px" Style="margin-top: 8px" TextMode="MultiLine" Width="600px" Wrap="False"></asp:TextBox>
                    
                </div>
                 <div style="height: 100px; background: #ccc; width: 600px; float: left">
                     <asp:TextBox ID="TextBox2" runat="server" Height="100px" Width="600px" TextMode="MultiLine"></asp:TextBox>
                     </div>
                     <div style="height: 100px; background: #ccc; width: 600px; float: left">
                     <p>
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="OfflineTest" />
                        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="GetHello" />
                        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="GetJson" />
                        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="GetImageScanRaw" />
                        <asp:Button ID="Button5" runat="server" Text="GetImageScanResult" OnClick="Button5_Click" />
                    </p>
                    </div>
            </div>
            
        </div>
    </form>
</body>
</html>