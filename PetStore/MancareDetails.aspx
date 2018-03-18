<%@ Page Title="Product Details" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MancareDetails.aspx.cs" Inherits="PetStore.MancareDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:FormView ID="productDetail" runat="server" ItemType="PetStore.Models.Mancare" SelectMethod ="GetMancare" RenderOuterTable="false">
        <ItemTemplate>
            <div>
                <h1><%#:Item.Denumire %></h1>
            </div>
            <br />
            <table>
                <tr>
                    <td>
                        <img src="/Content/<%#:Item.ImagePath %>" style="border:solid; height:300px" alt="<%#:Item.Denumire %>"/>
                    </td>
                    <td>&nbsp;</td>  
                    <td style="vertical-align: top; text-align:left;">
                        <b>Descriere: <%#:Item.Denumire%></b>
                        <br />
                        <%--<%#:Item.AnimalID %><%#:Item.AmbalajID %>
                        <br />--%>
                        <b>Gramaj: <%#:Item.Gramaj %></b>
                        <br />
                        <b>Stoc: <%#:Item.Stoc %></b>
                        <br />
                        <b>Data Expirare: <%#:Item.DataExpirare %></b>
                        <br />
                        <span><b>Pret:</b>&nbsp;<%#: String.Format("{0:c}", Item.PretVanzare) %></span>
                        <br />
                        <span><b>Cod mancare:</b>&nbsp;<%#:Item.MancareID %></span>
                    </td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:FormView>
    <div class="row"><h3>Informatii suplimentare</h3>
        <div class="col-md-3">
            <asp:FormView ID="ambalajdetails" runat="server" ItemType="PetStore.Models.Ambalaj" SelectMethod="GetAmbalaj" RenderOuterTable="false">
                <ItemTemplate>
                    <div>
                        <table>
                            <b>Ambalaj: <%#: Item.Tip %></b>
                        </table>
                    </div>
                </ItemTemplate>
            </asp:FormView>
        </div>
        <div class="col-md-3">
            <asp:FormView ID="animaledetails" runat="server" ItemType="PetStore.Models.Animal" SelectMethod="GetAnimal" RenderOuterTable="false">
                <ItemTemplate>
                    <div>
                        <table>
                            <b>Tip Animal:</b> <%#: Item.Nume %>
                            <br />
                            <b>Varsta Animal:</b><%#: Item.Varsta %>
                        </table>
                    </div>
                </ItemTemplate>
            </asp:FormView>
        </div>
        <div class="col-md-3">
            <asp:FormView ID="producatordetails" runat="server" ItemType="PetStore.Models.Producator" SelectMethod="GetProducatorDetails" RenderOuterTable="false">
                <ItemTemplate>
                    <div>
                        <table>
                            <b>Nume Producator:</b> <%#: Item.Nume %>
                            <br />
                            <b>Adresa Producator:</b><%#: Item.Adresa %>
                            <br />
                            <b>Telefon Producator:</b><%#: Item.Telefon %>
                        </table>
                    </div>
                </ItemTemplate>
            </asp:FormView>
        </div>
        <div class="col-md-3"><b>Ingrediente:</b>
            <asp:ListView ID="ingredienteDetails" runat="server" ItemType="PetStore.Models.Ingredient" SelectMethod="GetIngrediente" RenderOuterTable="false">
                <ItemTemplate>
                    <div>
                        <table>
                             <%#: Item.Nume %>
                            <br />                            
                        </table>
                    </div>
                </ItemTemplate>
            </asp:ListView>
        </div>
        
    </div>    
</asp:Content>

