<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddAnimal.aspx.cs" Inherits="PetStore.Admin.AddAnimal" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <div class="col-md-6">
            <h3>Adauga Animal:</h3>
                <table>        
                    <tr>
                        <td><asp:Label ID="LabelAddNume" runat="server">Nume:</asp:Label></td>
                        <td>
                            <asp:TextBox ID="AddNume" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" Text="* Nume required." ControlToValidate="AddNume" SetFocusOnError="true" Display="Dynamic"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td><asp:Label ID="LabelAddVarsta" runat="server">Varsta:</asp:Label></td>
                        <td>
                            <asp:TextBox ID="AddVarsta" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" Text="* Varsta required." ControlToValidate="AddVarsta" SetFocusOnError="true" Display="Dynamic"></asp:RequiredFieldValidator>
                        </td>              
                </table>
            <p></p>
            <p></p>
            <asp:Button ID="AddAnimalButton" runat="server" Text="Add Animal" OnClick="AddAnimalButton_Click"  CausesValidation="true" CssClass="btn btn-success"/>
            <asp:Label ID="LabelAddStatus" runat="server" Text=""></asp:Label>
            <p></p>
        </div>
        <div class="col-md-6">
            <h3>Sterge animal:</h3>
                <table>
                    <tr>
                        <td><asp:Label ID="LabelStergeNumeAnimal" runat="server">Nume Animal:</asp:Label></td>
                        <td>
                            <asp:TextBox ID="StergeNumeAnimal" runat="server"></asp:TextBox>                            
                        </td>
                    </tr>
                     <tr>
                        <td><asp:Label ID="LabelStergeVarstaAnimal" runat="server">Varsta Animal:</asp:Label></td>
                        <td>
                            <asp:TextBox ID="StergeVarstaAnimal" runat="server"></asp:TextBox>                            
                        </td>
                    </tr>
                </table>
                <p></p>
                <asp:Button ID="RemoveAnimalButton" runat="server" Text="Remove Animal" OnClick="RemoveAnimalButton_Click" CausesValidation="false" CssClass="btn btn-danger"/>
                <asp:Label ID="LabelRemoveStatus" runat="server" Text=""></asp:Label>
        </div>
    </div>   
</asp:Content>
