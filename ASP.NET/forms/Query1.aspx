<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Query1.aspx.cs" Inherits="IIS.Abiturient.forms.Query1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitlePlaceholder" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="AddToHeadPlaceholder" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="FlexberryStyles" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Button runat="server" ID="ButtonQuery1" OnClick="ButtonQuery1_OnClick" Text="Топ-10 городов" /> 
    <asp:Label runat="server" ID="QueryLabel1"></asp:Label>

    <asp:Button runat="server" ID="ButtonQuery2" OnClick="ButtonQuery2_OnClick" Text="Топ-1 специальностей" /> 
    <asp:Label runat="server" ID="QueryLabel2"></asp:Label>

    <asp:Button runat="server" ID="ButtonQuery3" OnClick="ButtonQuery3_OnClick" Text="Средний возраст" /> 
    <asp:Label runat="server" ID="QueryLabel3"></asp:Label>

    <asp:Button runat="server" ID="ButtonQuery4" OnClick="ButtonQuery4_OnClick" Text="Год подачи" /> 
    <asp:Label runat="server" ID="QueryLabel4"></asp:Label>

    <asp:Button runat="server" ID="ButtonQuery5" OnClick="ButtonQuery5_OnClick" Text="Приоритет" /> 
    <asp:Label runat="server" ID="QueryLabel5"></asp:Label>

</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="FlexberryScripts" runat="server">
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="ContentPlaceHolder0" runat="server">
</asp:Content>
<asp:Content ID="Content7" ContentPlaceHolderID="FlexberryRawHtml" runat="server">
</asp:Content>
