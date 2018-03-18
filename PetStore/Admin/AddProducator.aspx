<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddProducator.aspx.cs" Inherits="PetStore.Admin.AddProducator" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <div class="col-md-6">
            <h3>Adauga Producator:</h3>
                <table>        
                    <tr>
                        <td><asp:Label ID="LabelAddNume" runat="server">Nume:</asp:Label></td>
                        <td>
                            <asp:TextBox ID="AddNume" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" Text="* Producer name required." ControlToValidate="AddNume" SetFocusOnError="true" Display="Dynamic"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td><asp:Label ID="LabelAddAdresa" runat="server">Adresa:</asp:Label></td>
                        <td>
                            <asp:TextBox ID="AddAdresa" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" Text="* Address required." ControlToValidate="AddAdresa" SetFocusOnError="true" Display="Dynamic"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td><asp:Label ID="LabelAddTelefon" runat="server">Telefon:</asp:Label></td>
                        <td>
                            <asp:TextBox ID="AddTelefon" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" Text="* Phone Number required." ControlToValidate="AddTelefon" SetFocusOnError="true" Display="Dynamic"></asp:RequiredFieldValidator>
                
                        </td>
                    </tr>
        
                </table>
            <p></p>
            <p></p>
            <asp:Button ID="AddProducerButton" runat="server" Text="Add Producer" OnClick="AddProducerButton_Click"  CausesValidation="true" CssClass="btn btn-success"/>
            <asp:Label ID="LabelAddStatus" runat="server" Text=""></asp:Label>
            <p></p>
        </div>
        <div class="col-md-6">
            <h3>Sterge producator:</h3>
                <table>
                    <tr>
                        <td><asp:Label ID="LabelRemoveProducer" runat="server">Producer:</asp:Label></td>
                        <td><asp:DropDownList ID="DropDownRemoveProducer" runat="server" ItemType="PetStore.Models.Producator" 
                                SelectMethod="GetProducers" AppendDataBoundItems="true" 
                                DataTextField="Nume" DataValueField="ProducatorID" >
                            </asp:DropDownList>
                        </td>
                    </tr>
                </table>
                <p></p>
                <asp:Button ID="RemoveProducerButton" runat="server" Text="Remove Producer" OnClick="RemoveProducerButton_Click" CausesValidation="false" CssClass="btn btn-danger"/>
                <asp:Label ID="LabelRemoveStatus" runat="server" Text=""></asp:Label>
        </div>
    </div>   
</asp:Content>
