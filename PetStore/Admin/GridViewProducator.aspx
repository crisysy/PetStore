<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GridViewProducator.aspx.cs" Inherits="PetStore.Admin.GridViewProducator" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:ValidationSummary ShowModelStateErrors="true" runat="server" />
    <asp:GridView runat="server" ID="producatorGrid"
        ItemType="PetStore.Models.Producator" DataKeyNames="ProducatorID" 
        SelectMethod="ProducatorGrid_GetData"
        UpdateMethod="ProducatorGrid_UpdateItem"
        AutoGenerateEditButton="true"
        AutoGenerateColumns="false">
        <Columns>
            <asp:DynamicField DataField="Nume" />
            <asp:DynamicField DataField="Adresa" />
            <asp:DynamicField DataField="Telefon" />                              
        </Columns>
    </asp:GridView>
</asp:Content>
