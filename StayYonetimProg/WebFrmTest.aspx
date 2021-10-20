<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFrmTest.aspx.cs" Inherits="StayYonetimProg.WebFrmTest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:CheckBoxList ID="chkKirsatiyeListesi" runat="server" 
                AutoPostBack ="True"
                OnSelectedIndexChanged="chkKirsatiyeListesi_SelectedIndexChanged">
            </asp:CheckBoxList>
            <br />
            <asp:Label ID="lblBilgi" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
