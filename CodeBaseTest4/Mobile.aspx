<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Mobile.aspx.cs" Inherits="CodeBaseTest4.Mobile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
   <form id="form1" runat="server">
<div>
</div>
Select Any Mobiles: 
<br/>
       <asp:DropDownList ID="DropDownList1" runat="server" Height="30px" Width="220px" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
</asp:DropDownList>
<asp:Image ID="Image1" runat="server" Height="290px" style="margin-left: 25px; margin-top: 34px" Width="443px" ImageUrl="~/Images/iphone.jfif" />
<p>
The Price of this Mobiles : <asp:Button ID="Price" runat="server" OnClick="Button1_Click1" style="margin-left: 40px" Text="Price" Width="119px" />
</p>
<p>
<asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged1" style="margin-top: 0px" Width="140px"></asp:TextBox>
</p>
</form>
</body>
</html>
