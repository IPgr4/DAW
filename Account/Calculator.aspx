<%@ Page Title="Calculator" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Calculator.aspx.cs" Inherits="Calculator" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" Runat="Server">
    <hgroup class="title">
        <h1><%: Title %>.</h1>
        <h2>My Calculator</h2>
    </hgroup>
    <br />
    <br />
    <asp:TextBox ID="txtBox" runat="server" Height="22px" OnTextChanged="txtBox_TextChanged" ReadOnly="True" Width="174px"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="btn7" runat="server" OnClick="btn7_Click" Text="7" Width="34px" />
&nbsp;<asp:Button ID="btn8" runat="server" OnClick="btn8_Click" Text="8" Width="34px" />
&nbsp;<asp:Button ID="btn9" runat="server" OnClick="btn9_Click" Text="9" Width="34px" />
&nbsp;<asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" Text="Cl" Width="34px" />
    <br />
    <asp:Button ID="btn4" runat="server" OnClick="btn4_Click" Text="4" Width="34px" />
&nbsp;<asp:Button ID="btn5" runat="server" OnClick="btn5_Click" Text="5" Width="34px" />
&nbsp;<asp:Button ID="btn6" runat="server" OnClick="btn6_Click" Text="6" Width="34px" />
&nbsp;<asp:Button ID="btnMul" runat="server" OnClick="btnMul_Click" Text="X" Width="34px" />
    <br />
    <asp:Button ID="btn1" runat="server" OnClick="btn1_Click" Text="1" Width="34px" />
&nbsp;<asp:Button ID="btn2" runat="server" OnClick="btn2_Click" Text="2" Width="34px" />
&nbsp;<asp:Button ID="btn3" runat="server" OnClick="btn3_Click" Text="3" Width="34px" />
&nbsp;<asp:Button ID="btnMinus" runat="server" OnClick="btnMinus_Click" Text="-" Width="35px" />
    <br />
    <asp:Button ID="btn0" runat="server" OnClick="btn0_Click" Text="0" Width="34px" />
&nbsp;<asp:Button ID="btnDecimal" runat="server" OnClick="btnDecimal_Click" Text="." Width="34px" />
&nbsp;<asp:Button ID="btnEquals" runat="server" OnClick="btnEquals_Click" Text="=" Width="34px" />
    &nbsp;<asp:Button ID="btnPlus" runat="server" OnClick="btnPlus_Click" Text="+" Width="34px" />
    &nbsp;<asp:Button ID="btnDiv" runat="server" OnClick="btnDiv_Click" Text="/" Width="34px" />
    <br />
&nbsp;
</asp:Content>

