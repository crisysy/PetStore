<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddFilterIngredient.aspx.cs" Inherits="PetStore.AddFilterIngredient" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-md-3"><h3><b>Ingredient</b></h3>
            <asp:DropDownList ID="DropDownFilterIngredient" runat="server" 
                                ItemType="PetStore.Models.Ingredient" 
                                SelectMethod="FilterIngredient" DataTextField="Nume" 
                                DataValueField="IngredientID" >
            </asp:DropDownList>
        </div>       
       
    </div>
            <asp:Button ID="ApplyFiltersIngredientButton" runat="server" Text="Aplica Filtru dupa Ingredient" OnClick="ApplyFiltersIngredientButton_Click"  CausesValidation="true" CssClass="btn btn-info"/>
</asp:Content>
