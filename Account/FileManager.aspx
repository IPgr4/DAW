<%@ Page Title="File Manager" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="FileManager.aspx.cs" Inherits="Account_FileManager" %>


<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" Runat="Server">
<hgroup class="title">
        <h1><%: Title %> </h1>
    <h2>
        User File Manager
    </h2>
    </hgroup>
<asp:Label ID="labelStatus" runat="server"></asp:Label><br />
<asp:FileUpload ID="FileUpload1" runat="server" /><br />
<asp:Button ID="Button1" runat="server" Text="Upload" OnClick="Button1_Click" /><br /><br />

<asp:GridView ID="GridView1" runat="server" DataSource="<%# GetUploadList() %>" OnRowDeleting="GridView1_RowDeleting" AutoGenerateColumns="False" >
<Columns>
<asp:TemplateField HeaderText="Uploaded File">
<ItemStyle HorizontalAlign="Center" Width="70%" />
<ItemTemplate>
<asp:HyperLink
ID="FileLink" 
NavigateUrl='<%# "~/Uploads/" + Container.DataItem.ToString() %>' 
Text='<%# Container.DataItem.ToString() %>'
runat="server" Target="_blank" />
</ItemTemplate>
</asp:TemplateField>
<asp:TemplateField HeaderText="Delete?">
<ItemStyle HorizontalAlign="Center" Width="30%" />
<ItemTemplate>
<asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Delete"
OnClientClick='return confirm("Are you sure you want to delete this entry?");'
Text="Delete?" />
</ItemTemplate>
</asp:TemplateField>
</Columns>
</asp:GridView>

</asp:Content>

