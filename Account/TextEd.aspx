<%@ Page Title="Text Editor" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="TextEd.aspx.cs" Inherits="Account_MembersOnly" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" Runat="Server">
    <hgroup class="title">
        <h1><%: Title %>.</h1>
        <h2>Server-side text editor</h2>
    </hgroup>
    <br /> 
    <p>Editable textbox</p>
    <p>
        Font Size:&nbsp&nbsp
        <asp:Button ID="btnF8" runat="server" OnClick="btnF8_Click" Text="8" />
        <asp:Button ID="btnF10" runat="server" OnClick="btnF10_Click" Text="10" />
        <asp:Button ID="btnF12" runat="server" OnClick="btnF12_Click" Text="12" />
        <asp:Button ID="btnf14" runat="server" OnClick="btnf14_Click" Text="14" />
        <asp:Button ID="btnF16" runat="server" OnClick="btnF16_Click" Text="16" />
        <asp:Button ID="btnF18" runat="server" OnClick="btnF18_Click" Text="18" />
        <asp:Button ID="btnF20" runat="server" OnClick="btnF20_Click" Text="20" />
    </p>
    <p>
        Font Color:
        <asp:Button ID="btnCRed" runat="server" OnClick="btnColor_Click" Text="Red" />
        <asp:Button ID="btnCGreen" runat="server" OnClick="btnCGreen_Click" Text="Green" />
        <asp:Button ID="btnCBlue" runat="server" OnClick="btnCBlue_Click" Text="Blue" />
        <asp:Button ID="btnCYellow" runat="server" OnClick="btnCYellow_Click" Text="Yellow" />
        <asp:Button ID="btnCBlack" runat="server" OnClick="btnCBlack_Click" Text="Black" />
    </p>
    <p>
        &nbsp;Font Style: <asp:Button ID="btnUnderline" runat="server" OnClick="btnUnderline_Click" Text="Underline" />
        <asp:Button ID="btnBold" runat="server" OnClick="btnBold_Click" Text="Bold" />
        <asp:Button ID="btnItalic" runat="server" OnClick="btnItalic_Click" Text="Italic" />
        <asp:Button ID="btnStrike" runat="server" OnClick="btnStrike_Click" Text="Strikeout" />
    </p>
    <p>
        Font Name:
        <asp:Button ID="btnArial" runat="server" OnClick="btnArial_Click" Text="Arial" />
        <asp:Button ID="btnTimes" runat="server" OnClick="btnTimes_Click" Text="TimesNR" />
        <asp:Button ID="btnCalibri" runat="server" OnClick="btnCalibri_Click" Text="Calibri" />
        <asp:Button ID="btnGeorgia" runat="server" OnClick="btnGeorgia_Click" Text="Georgia" />
        <asp:Button ID="btnCourier" runat="server" OnClick="btnCourier_Click" Text="Courier" />
    </p>
    <p>
        <asp:TextBox ID="textBox1" runat="server" Height="135px" TextMode="MultiLine" Width="420px" ToolTip="Enter your text here" OnTextChanged="textBox1_TextChanged"></asp:TextBox>
    </p>
</asp:Content>

