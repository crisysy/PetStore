<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MaxStocProd.aspx.cs" Inherits="PetStore.Admin.MaxStocProd" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:ListView ID="MaxStocProducatorID"  
                ItemType="PetStore.Models.Producator" 
                runat="server"
                SelectMethod="MaxStocProducator" >
                <ItemTemplate>
                    <h3>Producatorul cu cele mai multe produse din magazinul online este momentan:</h3>
                    <h2><b style="font-size: large; font-style: normal">
                        
                        <%#: Item.Nume %>
                        </a>
                    </b></h2>
                </ItemTemplate>
            </asp:ListView>
</asp:Content>
