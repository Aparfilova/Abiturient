<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ExecuteQuery.aspx.cs" 
    Inherits="IIS.Abiturient.ExecuteQuery" %>

<asp:Content ID ="Content1" ContentPlaceHolderID="PageTitlePlaceholder" runat="server">
</asp:Content>
<asp:Content ID ="Content2" ContentPlaceHolderID="AddToHeadPlaceholder" runat="server">
</asp:Content>
<asp:Content ID ="Content3" ContentPlaceHolderID="ContentPlaceholder1" runat="server">
<asp:Button runat="server" ID="ButtonQuery" OnClick="ButtonQuery_OnClick" /> 
<asp:Label runat="server" ID="QueryResultLabel"></asp:Label>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="PageTitlePlaceholder0" runat="server">
</asp:Content>
