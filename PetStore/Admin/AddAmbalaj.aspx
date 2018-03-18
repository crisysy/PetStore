<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddAmbalaj.aspx.cs" Inherits="PetStore.Admin.AddAmbalaj" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <div class="col-md-6">
            <h3>Adauga Ambalaj:</h3>
                <table>        
                    <tr>
                        <td><asp:Label ID="LabelAddTip" runat="server">Tip Ambalaj:</asp:Label></td>
                        <td>
                            <asp:TextBox ID="AddTip" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" Text="* Type required." ControlToValidate="AddTip" SetFocusOnError="true" Display="Dynamic"></asp:RequiredFieldValidator>
                        </td>
                    </tr>                    
                </table>
            <p></p>
            <p></p>
            <asp:Button ID="AddAmbalajButton" runat="server" Text="Add Ambalaj" OnClick="AddAmbalajButton_Click"  CausesValidation="true" CssClass="btn btn-success"/>
            <asp:Label ID="LabelAddStatus" runat="server" Text=""></asp:Label>
            <p></p>
        </div>
        <div class="col-md-6">
            <h3>Sterge ambalaj:</h3>
                <table>
                    <tr>
                        <td><asp:Label ID="LabelRemoveAmbalaj" runat="server">Ambalaj:</asp:Label></td>
                        <td><asp:DropDownList ID="DropDownRemoveAmbalaj" runat="server" ItemType="PetStore.Models.Ambalaj" 
                                SelectMethod="GetAmbalaj" AppendDataBoundItems="true" 
                                DataTextField="Tip" DataValueField="AmbalajID" >
                            </asp:DropDownList>
                        </td>
                    </tr>
                </table>
                <p></p>
                <asp:Button ID="RemoveAmbalajButton" runat="server" Text="Remove Ambalaj" OnClick="RemoveAmbalajButton_Click" CausesValidation="false" CssClass="btn btn-danger"/>
                <asp:Label ID="LabelRemoveStatus" runat="server" Text=""></asp:Label>
        </div>
    </div>   
</asp:Content>
