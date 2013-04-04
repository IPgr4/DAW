<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="About.aspx.cs" Inherits="About" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <hgroup class="title">
        <h1><%: Title %>.</h1>
        <h2>Website description.</h2>
    </hgroup>

    <article>
        <p>        
            This site was created as an example for the Web Application Development course at the University of Bucharest.
        </p>

        <p>        
            The main features and applications of this website can only be accessed by registered users. Feel free to create an account <a href="~/Account/Register.aspx">here</a>
        </p>

        <p>        
            Thank you for testing this website.
        </p>
    </article>

    <aside>
        <h3>Aside Title</h3>
        <p>        
            The website was created with help from the following sites:
        </p>
        <ul>
            <li><a runat="server" href="http://www.w3schools.com/">W3Schools</a></li>
            <li><a runat="server" href="http://msdn.microsoft.com/en-us/library">Microsoft Developer Network Library</a></li>
            <li><a runat="server" href="http://stackoverflow.com/">StackOverflow</a></li>
            <li><a runat="server" href="http://www.codeproject.com/">CodeProject</a></li>
            <li><a runat="server" href="http://www.google.com">Google</a></li>
        </ul>
    </aside>
</asp:Content>