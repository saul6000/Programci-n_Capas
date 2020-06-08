<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Saludos.aspx.cs" Inherits="webTestOperaciones.Inicio.Saludos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            Ingrese tu nombre&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="Txtnombre" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblsaludos" runat="server" Text="lbl[saludos]"></asp:Label>
        </p>
        <p>
            El resultado de la sumatoria es
            <asp:TextBox ID="Txtresultado" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btnMostrar" runat="server" OnClick="btnMostrar_Click" Text="Mostrar" />
        </p>
    </form>
</body>
</html>
