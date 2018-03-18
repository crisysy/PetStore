<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="StocPerProducator.aspx.cs" Inherits="PetStore.Admin.StocPerProducator" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <asp:ValidationSummary ShowModelStateErrors="true" runat="server" />
    <asp:GridView runat="server" ID="producatorGrid"
        ItemType="PetStore.Models.Producator" DataKeyNames="ProducatorID" 
        SelectMethod="StocPerProducatorGrid_GetData"
        AutoGenerateColumns="false">
        <Columns>
            <asp:DynamicField DataField="Nume" />            
            <asp:TemplateField HeaderText="Total Produse">
              <ItemTemplate>
                <asp:Label Text="<%# Item.Mancare.Sum(m=>m.Stoc) %>" 
                    runat="server" />
              </ItemTemplate>
            </asp:TemplateField>   
        </Columns>
    </asp:GridView>
</asp:Content>
