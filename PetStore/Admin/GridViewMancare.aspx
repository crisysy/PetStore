<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GridViewMancare.aspx.cs" Inherits="PetStore.Admin.GridViewMancare" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:ValidationSummary ShowModelStateErrors="true" runat="server" />
    <asp:GridView runat="server" ID="mancareGrid"
        ItemType="PetStore.Models.Mancare" DataKeyNames="MancareID" 
        SelectMethod="MancareGrid_GetData"
        UpdateMethod="MancareGrid_UpdateItem"
        AutoGenerateEditButton="true"
        AutoGenerateColumns="false">
        <Columns>
            <asp:DynamicField DataField="Denumire" />
            <asp:DynamicField DataField="ProducatorID" />
            <asp:DynamicField DataField="AnimalID" />
            <asp:DynamicField DataField="AmbalajID" />   
            <asp:DynamicField DataField="Gramaj" />         
            <asp:DynamicField DataField="Stoc" />         
            <asp:DynamicField DataField="PretAchizitie" />         
            <asp:DynamicField DataField="PretVanzare" />         
            <asp:DynamicField DataField="DataExpirare" />         
            <asp:DynamicField DataField="ImagePath" />                        
        </Columns>
    </asp:GridView>
</asp:Content>
