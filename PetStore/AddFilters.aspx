<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddFilters.aspx.cs" Inherits="PetStore.AddFilters" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-md-3"><h3><b>Producator</b></h3>
            <asp:DropDownList ID="DropDownFilterProducator" runat="server" 
                                ItemType="PetStore.Models.Producator" 
                                SelectMethod="FilterProducator" DataTextField="Nume" 
                                DataValueField="ProducatorID" >
            </asp:DropDownList>
        </div>
        <div class="col-md-3"><h3><b>Ambalaj</b></h3>
            <asp:DropDownList ID="DropDownFilterAmbalaj" runat="server" 
                                ItemType="PetStore.Models.Ambalaj" 
                                SelectMethod="FilterAmbalaj" DataTextField="Tip" 
                                DataValueField="AmbalajID" >
            </asp:DropDownList>
        </div>
        <div class="col-md-3"><h3><b>Nume animal</b></h3>
             <asp:TextBox ID="AddNumeAnimal" runat="server"></asp:TextBox>
            <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" Text="* Nume Animal required." ControlToValidate="AddNumeAnimal" SetFocusOnError="true" Display="Dynamic"></asp:RequiredFieldValidator>                --%>
        </div>
        <div class="col-md-3"><h3><b>Varsta animal</b></h3>
            <asp:TextBox ID="AddVarstaAnimal" runat="server"></asp:TextBox>
            <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" Text="* Varsta Animal required." ControlToValidate="AddVarstaAnimal" SetFocusOnError="true" Display="Dynamic"></asp:RequiredFieldValidator>                --%>
        </div>
    </div>
            <asp:Button ID="ApplyFiltersButton" runat="server" Text="Aplica Filtre" OnClick="ApplyFiltersButtonButton_Click"  CausesValidation="true" CssClass="btn btn-info"/>
</asp:Content>
