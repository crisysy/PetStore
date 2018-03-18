<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddIngredient.aspx.cs" Inherits="PetStore.Admin.AddIngredient" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <div class="col-md-6">
            <h3>Adauga Ingredient:</h3>
                <table>        
                    <tr>
                        <td><asp:Label ID="LabelAddNume" runat="server">Nume ingredient:</asp:Label></td>
                        <td>
                            <asp:TextBox ID="AddNume" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" Text="* Nume required." ControlToValidate="AddNume" SetFocusOnError="true" Display="Dynamic"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td><asp:Label ID="LabelAddCompozitie" runat="server">ID Compozitie:</asp:Label></td>
                        <td>
                            <asp:DropDownList ID="DropDownAddCompozitieID" runat="server" 
                                ItemType="PetStore.Models.Compozitie" 
                                SelectMethod="GetCompozitie" DataTextField="CompozitieID" 
                                DataValueField="CompozitieID" >
                            </asp:DropDownList>
                        </td>
                    </tr>                    
                </table>
            <p></p>
            <p></p>
            <asp:Button ID="AddIngredientButton" runat="server" Text="Add Ingredient" OnClick="AddIngredientButton_Click"  CausesValidation="true" CssClass="btn btn-success"/>
            <asp:Label ID="LabelAddStatus" runat="server" Text=""></asp:Label>
            <p></p>
        </div>
        <div class="col-md-6">
            <h3>Sterge ingredient:</h3>
                <table>
                    <tr>
                        <td><asp:Label ID="LabelRemoveIngredient" runat="server">Ingredient:</asp:Label></td>
                        <td><asp:DropDownList ID="DropDownRemoveIngredient" runat="server" ItemType="PetStore.Models.Ingredient" 
                                SelectMethod="GetIngredient" AppendDataBoundItems="true" 
                                DataTextField="Nume" DataValueField="IngredientID" >
                            </asp:DropDownList>
                        </td>
                    </tr>
                </table>
                <p></p>
                <asp:Button ID="RemoveIngredientButton" runat="server" Text="Remove Ingredient" OnClick="RemoveIngredientButtonButton_Click" CausesValidation="false" CssClass="btn btn-danger"/>
                <asp:Label ID="LabelRemoveStatus" runat="server" Text=""></asp:Label>
        </div>
    </div>   
</asp:Content>
