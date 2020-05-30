<%@ Page Title="" Language="C#" MasterPageFile="~/masterPage.Master" AutoEventWireup="true" CodeBehind="Calculadora.aspx.cs" Inherits="Calculadora.Calculadora" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    <br />
    <script src="js/validar.js"></script>
    </p>
    <div class="mx-auto" style="width: 16rem;">
        <asp:TextBox class="form-control" ID="txtCalculadora" runat="server" onkeypress="return isNumberKey(event)" onpast="return false"></asp:TextBox>
        <asp:TextBox class="form-control" ID="txtCalculadora2" runat="server" onkeypress="return isNumberKey(event)" onpast="return false"></asp:TextBox>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:Button class="btn btn-primary" style="width: 60px" ID="btnSumar" runat="server" Text="+" OnClick="btnSumar_Click" />
        <asp:Button class="btn btn-primary" style="width: 60px" ID="btnRestar" runat="server" Text="-" OnClick="btnRestar_Click" />
        <asp:Button class="btn btn-primary" style="width: 60px" ID="btnMultiplicar" runat="server" Text="*" OnClick="btnMultiplicar_Click" />
        <asp:Button class="btn btn-primary" style="width: 60px" ID="btnDividir" runat="server" Text="/" OnClick="btnDividir_Click" />
        <asp:TextBox class="form-control" ID="txtResultado" runat="server" onkeypress="return isNumberKey(event)" onpast="return false"></asp:TextBox>
        <asp:Button class="btn btn-primary" ID="btnLogResultados" runat="server" OnClick="btnLogResultados_Click" Text="Ir a Resultados" Width="250px" />
        <br />
     </div>
    
</asp:Content>
