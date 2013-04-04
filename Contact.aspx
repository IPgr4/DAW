<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Contact.aspx.cs" Inherits="Contact" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <hgroup class="title">
        <h1><%: Title %>.</h1>
        <h2>Need assistence?</h2>
    </hgroup>

    <section class="contact">
        <header>
            <h3>Phone:</h3>
        </header>
        <p>
            <span class="label">Main:</span>
            <span>(+4) 074-024-6715</span>
        </p>
        <p>
            <span class="label">After Hours:</span>
            <span>(+4021) 252-3998</span>
        </p>
    </section>

    <section class="contact">
        <header>
            <h3>Email:</h3>
        </header>
        <p>
            <span class="label">Support:</span>
            <span><a href="mailto:vlad.razvan.marton@gmail.com">Vlad.Razvan.Marton@gmail.com</a></span>
        </p>
        <p>
            <span class="label">Marketing:</span>
            <span><a href="mailto:marton.vlad@gmail.com">Marton.Vlad@gmail.com</a></span>
        </p>
        <p>
            <span class="label">General:</span>
            <span><a href="mailto:marton.vlad@gmail.com">Marton.Vlad@gmail.com</a></span>
        </p>
    </section>

    <section class="contact">
        <header>
            <h3>Address:</h3>
        </header>
        <p>
            Sos. Iancului #6<br />
            Bucuresti, Romania, 021723
        </p>
    </section>
</asp:Content>