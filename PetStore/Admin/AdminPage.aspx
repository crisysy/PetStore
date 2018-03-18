<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AdminPage.aspx.cs" Inherits="PetStore.Admin.AdminPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="col-md-4"><h3><b>Actions</b></h3>
        <div class="row">
            <asp:Button ID="ApplyDiscountExpirationDateID" runat="server" Text="Aplica reducere pentru expirare data" CssClass="btn btn-success" OnClick="ApplyDiscountExpirationDateBtn_Click" />
        </div>
        <div class="row">
            <asp:Button ID="ApplyDiscountStocGrateranimal" runat="server" Text="Aplica reducere pentru stoc peste medie" CssClass="btn btn-success" OnClick="ApplyDiscountStocGrateranimalBtn_Click" />
        </div>
        <div class="row">
            <asp:Button ID="AddProducatorID" runat="server" Text="Adauga/Sterge Producator" CssClass="btn btn-success" OnClick="AddProducatorBtn_Click" />
        </div>
        <div class="row">
            <asp:Button ID="AddAmbalajID" runat="server" Text="Adauga/Sterge Ambalaj" CssClass="btn btn-success" OnClick="AddAmbalajBtn_Click" />
        </div>
        <div class="row">
            <asp:Button ID="AddMancareID" runat="server" Text="Adauga/Sterge Mancare" CssClass="btn btn-success" OnClick="AddMancareBtn_Click" />
        </div>
        <div class="row">
            <asp:Button ID="AddAnimalID" runat="server" Text="Adauga/Sterge Animal" CssClass="btn btn-success" OnClick="AddAnimalBtn_Click" />
        </div>
        <div class="row">
            <asp:Button ID="AddIngredientID" runat="server" Text="Adauga/Sterge Ingredient" CssClass="btn btn-success" OnClick="AddIngredientBtn_Click" />
        </div>
        
        
    </div>
    <div class="col-md-4"><h3><b>Information</b></h3>
        <div class="col-md-4">
            <div class="row">
                <asp:Button ID="LowerThanFive" runat="server" Text="Stoc < 5" CssClass="btn btn-info" OnClick="LowerThanFiveBtn_Click" />
            </div>
            <div class="row">
                <asp:Button ID="MaxStocProducer1" runat="server" Text="Producatorul cu cel mai multe produse" CssClass="btn btn-info" OnClick="MaxStocProdBtn_Click" />
            </div>  
            <div class="row">
                <asp:Button ID="GridViewIngredienteCompozitie" runat="server" Text="Ingrediente per Compozitie" CssClass="btn btn-info" OnClick="GridViewIngredienteCompozitieBtn_Click" />
            </div> 
            <div class="row">
                <asp:Button ID="GridViewStocPerProducator" runat="server" Text="Produse per Producator" CssClass="btn btn-info" OnClick="GridViewStocPerProducatorBtn_Click" />
            </div>
        </div>   

    </div>
    <div class="col-md-4"><h3><b>GridView&Update</b></h3>
        <div class="row">
                <asp:Button ID="GridViewMancare" runat="server" Text="Tabel Mancare" CssClass="btn btn-warning" OnClick="GridViewMancareBtn_Click" />
        </div>
        <div class="row">
                <asp:Button ID="GridViewProducator" runat="server" Text="Tabel Producatori" CssClass="btn btn-warning" OnClick="GridViewProducatorBtn_Click" />
        </div>
    </div>
          
</asp:Content>
