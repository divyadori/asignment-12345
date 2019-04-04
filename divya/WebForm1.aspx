<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="divya.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    
    <form id="form1" runat="server">
        <div>
             <asp:TextBox ID="txt1" runat="server"></asp:TextBox>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txt1" ErrorMessage="enter valid number" ForeColor="Red" ValidationExpression="[0-9]">*</asp:RegularExpressionValidator>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txt1" ErrorMessage="only numbers are allowed" ForeColor="Red">*</asp:RequiredFieldValidator>
        <br />
        <asp:TextBox ID="txt2" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txt2" ErrorMessage="enter valid number" ForeColor="Red">*</asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txt2" ErrorMessage="only numbers are allowed" ForeColor="Red" ValidationExpression="[0-9]">*</asp:RegularExpressionValidator>
        <br />
        <asp:Button ID="btnadd" runat="server" OnClick="btnadd_Click" Text="+" />
        <asp:Button ID="btnsub" runat="server" Text="-" OnClick="btnsub_Click1" />
        <asp:Button ID="btnmul" runat="server" Text="*" OnClick="btnmul_Click1" style="width: 19px" />
        <asp:Button ID="btndiv" runat="server" Text="/" OnClick="btndiv_Click1" />
        <br />
        <asp:Label ID="lblresult" runat="server" Text="result"></asp:Label>
        </div>
    </form>
</body>
</html>
