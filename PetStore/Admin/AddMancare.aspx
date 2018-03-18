<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddMancare.aspx.cs" Inherits="PetStore.Admin.AddMancare" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <div class="col-md-6">
            <h3>Adauga Mancare:</h3>
                <table>        
                    <tr>
                        <td><asp:Label ID="LabelAddDenumire" runat="server">Denumire:</asp:Label></td>
                        <td>
                            <asp:TextBox ID="AddDenumire" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" Text="* Denumire required." ControlToValidate="AddDenumire" SetFocusOnError="true" Display="Dynamic"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td><asp:Label ID="LabelAddProducator" runat="server">Producator:</asp:Label></td>
                        <td>
                            <asp:DropDownList ID="DropDownAddProducator" runat="server" 
                                ItemType="PetStore.Models.Producator" 
                                SelectMethod="GetProducator" DataTextField="Nume" 
                                DataValueField="ProducatorID" >
                            </asp:DropDownList>
                        </td>
                    </tr>
                     <tr>
                        <td><asp:Label ID="LabelAddNumeAnimal" runat="server">Nume Animal:</asp:Label></td>
                        <td>
                            <asp:TextBox ID="AddNumeAnimal" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" Text="* Nume Animal required." ControlToValidate="AddNumeAnimal" SetFocusOnError="true" Display="Dynamic"></asp:RequiredFieldValidator>                
                        </td>
                    </tr>
                     <tr>
                        <td><asp:Label ID="LabelAddVarstaAnimal" runat="server">Varsta Animal:</asp:Label></td>
                        <td>
                            <asp:TextBox ID="AddVarstaAnimal" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" Text="* Varsta Animal required." ControlToValidate="AddVarstaAnimal" SetFocusOnError="true" Display="Dynamic"></asp:RequiredFieldValidator>                
                        </td>
                    </tr>
                    <tr>
                        <td><asp:Label ID="LabelAddAmbalaj" runat="server">Ambalaj:</asp:Label></td>
                        <td>
                            <asp:DropDownList ID="DropDownAddAmbalaj" runat="server" 
                                ItemType="PetStore.Models.Ambalaj" 
                                SelectMethod="GetAmbalaj" DataTextField="Tip" 
                                DataValueField="AmbalajID" >
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td><asp:Label ID="LabelAddGramaj" runat="server">Gramaj:</asp:Label></td>
                        <td>
                            <asp:TextBox ID="AddGramaj" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" Text="* Gramaj required." ControlToValidate="AddGramaj" SetFocusOnError="true" Display="Dynamic"></asp:RequiredFieldValidator>                
                        </td>
                    </tr>
                    <tr>
                        <td><asp:Label ID="LabelAddStoc" runat="server">Stoc:</asp:Label></td>
                        <td>
                            <asp:TextBox ID="AddStoc" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" Text="* Stoc required." ControlToValidate="AddStoc" SetFocusOnError="true" Display="Dynamic"></asp:RequiredFieldValidator>                
                        </td>
                    </tr>
                    <tr>
                        <td><asp:Label ID="LabelAddPretAchizitie" runat="server">Pret Achizitie:</asp:Label></td>
                        <td>
                            <asp:TextBox ID="AddPretAchizitie" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" Text="* Pret achizitie required." ControlToValidate="AddPretAchizitie" SetFocusOnError="true" Display="Dynamic"></asp:RequiredFieldValidator>                
                        </td>
                    </tr>
                    <tr>
                        <td><asp:Label ID="LabelAddPretVanzare" runat="server">Pret Vanzare:</asp:Label></td>
                        <td>
                            <asp:TextBox ID="AddPretVanzare" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" Text="* Pret vanzare required." ControlToValidate="AddPretVanzare" SetFocusOnError="true" Display="Dynamic"></asp:RequiredFieldValidator>                
                        </td>
                    </tr>
                    <tr>
                        <td><asp:Label ID="LabelAddDataExpirare" runat="server">Data Expirare:</asp:Label></td>
                        <td>
                            <asp:TextBox ID="AddDataExpirare" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" Text="* Data Expirare required." ControlToValidate="AddDataExpirare" SetFocusOnError="true" Display="Dynamic"></asp:RequiredFieldValidator>                
                        </td>
                    </tr>
                    <tr>
                        <td><asp:Label ID="LabelAddImagePath" runat="server">Image File:</asp:Label></td>
                        <td>
                            <asp:FileUpload ID="AddImagePath" runat="server" />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" Text="* Image path required." ControlToValidate="AddImagePath" SetFocusOnError="true" Display="Dynamic"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                </table>
            <p></p>
            <p></p>
            <asp:Button ID="AddMancareButton" runat="server" Text="Add Mancare" OnClick="AddMancareButton_Click"  CausesValidation="true" CssClass="btn btn-success"/>
            <asp:Label ID="LabelAddStatus" runat="server" Text=""></asp:Label>
            <p></p>
        </div>
        <div class="col-md-6">
            <h3>Sterge mancare:</h3>
                <table>
                    <tr>
                        <td><asp:Label ID="LabelRemoveMancare" runat="server">Mancare:</asp:Label></td>
                        <td><asp:DropDownList ID="DropDownRemoveMancare" runat="server" ItemType="PetStore.Models.Mancare" 
                                SelectMethod="GetMancare" AppendDataBoundItems="true" 
                                DataTextField="Denumire" DataValueField="MancareID" >
                            </asp:DropDownList>
                        </td>
                    </tr>
                </table>
                <p></p>
                <asp:Button ID="RemoveMancareButton" runat="server" Text="Remove Mancare" OnClick="RemoveMancareButton_Click" CausesValidation="false" CssClass="btn btn-danger"/>
                <asp:Label ID="LabelRemoveStatus" runat="server" Text=""></asp:Label>
        </div>
    </div>   
</asp:Content>
