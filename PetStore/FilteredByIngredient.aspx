<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FilteredByIngredient.aspx.cs" Inherits="PetStore.FilteredByIngredient" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
      <asp:ListView ID="productList" runat="server" 
                DataKeyNames="MancareID" GroupItemCount="4"
                ItemType="PetStore.Models.Mancare" SelectMethod="GetMancaruri">
                <EmptyDataTemplate>
                    <table >
                        <tr>
                            <td>Ne cerem scuze. Momentan nu avem niciun produs in stoc pentru aceasta marca.</td>
                        </tr>
                    </table>
                </EmptyDataTemplate>
                <EmptyItemTemplate>
                    <td/>
                </EmptyItemTemplate>
                <GroupTemplate>
                    <tr id="itemPlaceholderContainer" runat="server">
                        <td id="itemPlaceholder" runat="server"></td>
                    </tr>
                </GroupTemplate>
                <ItemTemplate>
                    <td runat="server">
                        <table>
                            <tr>
                                <td>
                                    <a href="MancareDetails.aspx?mancareID=<%#:Item.MancareID%>">
                                        <img src="/Content/<%#:Item.ImagePath%>"
                                            width="100" height="100" style="border: solid" /></a>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <a href="MancareDetails.aspx?mancareID=<%#:Item.MancareID%>">
                                        <span>
                                            <%#:Item.Denumire%>
                                        </span>
                                    </a>
                                    <br />
                                    <span>
                                        <b>Price: </b><%#:String.Format("{0:c}", Item.PretVanzare)%>
                                    </span>
                                    <br />
                                    <a href="/AddToCart.aspx?mancareID=<%#:Item.MancareID %>">               
                                        <span class="ProductListItem">
                                            <b>Add To Cart<b>
                                        </span>           
                                    </a>
                                </td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                            </tr>
                        </table>
                        </p>
                    </td>
                </ItemTemplate>
                <LayoutTemplate>
                    <table style="width:100%;">
                        <tbody>
                            <tr>
                                <td>
                                    <table id="groupPlaceholderContainer" runat="server" style="width:100%">
                                        <tr id="groupPlaceholder"></tr>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td></td>
                            </tr>
                            <tr></tr>
                        </tbody>
                    </table>
                </LayoutTemplate>
            </asp:ListView>
</asp:Content>
