using System;
using System.Web;
using System.Web.Security;
using DotNetOpenAuth.AspNet;
using Microsoft.AspNet.Membership.OpenAuth;

public partial class Account_RegisterExternalLogin : System.Web.UI.Page
{
    protected string ProviderName
    {
        get { return (string)ViewState["ProviderName"] ?? String.Empty; }
        private set { ViewState["ProviderName"] = value; }
    }

    protected string ProviderDisplayName
    {
        get { return (string)ViewState["ProviderDisplayName"] ?? String.Empty; }
        private set { ViewState["ProviderDisplayName"] = value; }
    }

    protected string ProviderUserId
    {
        get { return (string)ViewState["ProviderUserId"] ?? String.Empty; }
        private set { ViewState["ProviderUserId"] = value; }
    }

    protected string ProviderUserName
    {
        get { return (string)ViewState["ProviderUserName"] ?? String.Empty; }
        private set { ViewState["ProviderUserName"] = value; }
    }

    protected void Page_Load()
    {
        if (!IsPostBack)
        {
            ProcessProviderResult();
        }
    }

    protected void logIn_Click(object sender, EventArgs e)
    {
        CreateAndLoginUser();
    }

    protected void cancel_Click(object sender, EventArgs e)
    {
        RedirectToReturnUrl();
    }

    private void ProcessProviderResult()
    {
        // Proceseaza raspunsul de la un auth provider din request
        ProviderName = OpenAuth.GetProviderNameFromCurrentRequest();

        if (String.IsNullOrEmpty(ProviderName))
        {
            Response.Redirect(FormsAuthentication.LoginUrl);
        }

        ProviderDisplayName = OpenAuth.GetProviderDisplayName(ProviderName);

        // Construieste URL-ul de redirect pt o verificare OpenAuth (facebook/google/etc)
        var redirectUrl = "~/Account/RegisterExternalLogin.aspx";
        var returnUrl = Request.QueryString["ReturnUrl"];
        if (!String.IsNullOrEmpty(returnUrl))
        {
            redirectUrl += "?ReturnUrl=" + HttpUtility.UrlEncode(returnUrl);
        }

        // verifica OpenAuth
        var authResult = OpenAuth.VerifyAuthentication(redirectUrl);
        if (!authResult.IsSuccessful)
        {
            Title = "External login failed";
            userNameForm.Visible = false;
            
            ModelState.AddModelError("Provider", String.Format("External login {0} failed.", ProviderDisplayName));
            
           
            Trace.Warn("OpenAuth", String.Format("There was an error verifying authentication with {0})", ProviderDisplayName), authResult.Error);
            return;
        }

        // Userul s-a logat cu serviciul extern. verificam daca exista deja local.
        
        if (OpenAuth.Login(authResult.Provider, authResult.ProviderUserId, createPersistentCookie: false))
        {
            RedirectToReturnUrl();
        }

        // Salvam informatiile de la provider
        ProviderName = authResult.Provider;
        ProviderUserId = authResult.ProviderUserId;
        ProviderUserName = authResult.UserName;

        Form.Action = ResolveUrl(redirectUrl);

        if (User.Identity.IsAuthenticated)
        {
            // Userul este deja autentifiat, adaugam login-ul extern si redirectionam 
            OpenAuth.AddAccountToExistingUser(ProviderName, ProviderUserId, ProviderUserName, User.Identity.Name);
            RedirectToReturnUrl();
        }
        else
        {
            //User nou, cerem nume
            userName.Text = authResult.UserName;
        }
    }

    private void CreateAndLoginUser() //cream userul si logam
    {
        if (!IsValid)
        {
            return;
        }

        var createResult = OpenAuth.CreateUser(ProviderName, ProviderUserId, ProviderUserName, userName.Text);
        if (!createResult.IsSuccessful)
        {
            
                ModelState.AddModelError("UserName", createResult.ErrorMessage);
                
        }
        else
        {
            // User creat 
            if (OpenAuth.Login(ProviderName, ProviderUserId, createPersistentCookie: false))
            {
                RedirectToReturnUrl();
            }
        }
    }

    private void RedirectToReturnUrl()
    {
        var returnUrl = Request.QueryString["ReturnUrl"];
        if (!String.IsNullOrEmpty(returnUrl) && OpenAuth.IsLocalUrl(returnUrl))
        {
            Response.Redirect(returnUrl);
        }
        else
        {
            Response.Redirect("~/");
        }
    }
}