<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Ingredientecompozitie.aspx.cs" Inherits="PetStore.Admin.StocPerProducer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:ValidationSummary ShowModelStateErrors="true" runat="server" />
    <asp:GridView runat="server" ID="producatorGrid"
        ItemType="PetStore.Models.Compozitie" DataKeyNames="CompozitieID" 
        SelectMethod="CompozitieGrid_GetData"
        AutoGenerateColumns="false">
        <Columns>
            <asp:DynamicField DataField="MancareID" />            
            <asp:TemplateField HeaderText="Total Ingrediente">
              <ItemTemplate>
                <asp:Label Text="<%# Item.Ingrediente.Count() %>" 
                    runat="server" />
              </ItemTemplate>
            </asp:TemplateField>   
        </Columns>
    </asp:GridView>
</asp:Content>
