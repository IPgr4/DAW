<%@ Page Title="Concert" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Concerte.aspx.cs" Inherits="Concerte" %>

<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" Runat="Server">
      <hgroup class="title">
        <h1><%: Title %>.</h1>
        <h2>Pagina Concerte.<br />
            <br />
            Tip:<asp:TextBox ID="tipTB" runat="server" OnTextChanged="tipTB_TextChanged"></asp:TextBox>
            <br />
            Denumire:<asp:TextBox ID="denTB" runat="server" OnTextChanged="denTB_TextChanged"></asp:TextBox>
            <br />
            Interpret:<asp:TextBox ID="intTB" runat="server" OnTextChanged="intTB_TextChanged"></asp:TextBox>
            <br />
            IdLoc:<asp:TextBox ID="idLocTB" runat="server" OnTextChanged="idLocTB_TextChanged"></asp:TextBox>
            <br />
            Locatie:<asp:TextBox ID="locTB" runat="server" OnTextChanged="locTB_TextChanged"></asp:TextBox>
            <br />
            Data:<asp:TextBox ID="dataTB" runat="server" OnTextChanged="dataTB_TextChanged"></asp:TextBox>
            <br />
            Durata:<asp:TextBox ID="durTB" runat="server" OnTextChanged="durTB_TextChanged"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnAdauga" runat="server" OnClick="btnAdauga_Click" Text="Adauga" />
            <asp:Label ID="lblMessage" runat="server" Text="" Font-Names = "Arial"></asp:Label>
            <br />
            <br />
            <br />
          </h2>
    </hgroup>
</asp:Content>

