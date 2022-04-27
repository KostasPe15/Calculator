<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>ΑΡΙΘΜΟΜΗΧΑΝΗ</h1>
        Αριθμός Α:
        <asp:TextBox ID="TextBox1" runat="server" Width="54px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="+" />
&nbsp;<asp:Button ID="btnSubtract" runat="server" OnClick="btnSubtract_Click" Text="-" />
&nbsp;<asp:Button ID="btnMultiply" runat="server" OnClick="btnMultiply_Click" Text="x" />
&nbsp;<asp:Button ID="btnDivide" runat="server" OnClick="btnDivide_Click" Text="/" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" Text="Καθάρισμα" />
        <br />
        <br />
        Αριθμός Β: <asp:TextBox ID="TextBox2" runat="server" Width="53px"></asp:TextBox>
        <br />
        <br />
        Αποτέλεσμα:
        <asp:Label ID="Label1" runat="server"></asp:Label>
        <br />
    </form>
</body>
</html>
