````c#
<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div aria-sort="descending">
    
        
    
        <asp:CheckBox ID="CheckBox1" runat="server" Text="Java" />
        <br />
        <asp:CheckBox ID="CheckBox2" runat="server" Text="C" />
        <br />
        <asp:CheckBox ID="CheckBox3" runat="server" Text="C#" />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="height: 21px" Text="Button" />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server"></asp:Label>
        <br />
        <br />
        <asp:RadioButton ID="RadioButton1" runat="server" GroupName="A" Text="Male" />
        <br />
        <asp:RadioButton ID="RadioButton2" runat="server" GroupName="A" Text="Female" />
        <br />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" />
        <br />
        <br />
        <asp:Label ID="Label2" runat="server"></asp:Label>
    
        
    
    </div>
    </form>
</body>
</html>
`````
