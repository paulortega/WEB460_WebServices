<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>

        <asp:Label ID="lblNum1" runat="server" Text="1st Number  "></asp:Label>
        &nbsp;
        <asp:TextBox ID="txtNum1" runat="server"></asp:TextBox> <br />
        <asp:Label ID="lblNum2" runat="server" Text="2nd Number "></asp:Label>
        &nbsp;<asp:TextBox ID="txtNum2" runat="server"></asp:TextBox> <br />
        <asp:Label ID="Label1" runat="server" Text="Result: "></asp:Label>
        <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
        <br /><br />
        <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />
        &nbsp;
        <asp:Button ID="btnSubtract" runat="server" Text="Subtract" OnClick="btnSubtract_Click" />
        &nbsp;
        <asp:Button ID="btnMultiply" runat="server" Text="Multiply" OnClick="btnMultiply_Click" />
        &nbsp;
        <asp:Button ID="btnDivide" runat="server" Text="Divide" OnClick="btnDivide_Click" /> <br />

    </div>
    </form>

</body>
</html>
