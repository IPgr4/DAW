using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.IO;

public partial class Account_FileManager : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    override protected void OnLoad(System.EventArgs e) //bind-uieste fiserele pe grid
    {
        base.OnLoad(e);
        if (!IsPostBack)
        {
            GridView1.DataBind();
        }
    }

    protected void Button1_Click(object sender, EventArgs e) //controller-ul butonului de upload
    {
        UploadThisFile(FileUpload1);
        GridView1.DataBind();
    }

    override protected void OnInit(EventArgs e) //
    {
        base.OnInit(e);

        Button1.Click += Button1_Click;
    }

    protected string[] GetUploadList()  // gaseste lista de fisiere din folderul de upload
    {
        string folder = Server.MapPath("/Uploads/");
        string[] files = Directory.GetFiles(folder);
        string[] fileNames = new string[files.Length];
        Array.Sort(files);

        for (int i = 0; i < files.Length; i++)
        {
            fileNames[i] = Path.GetFileName(files[i]);
        }

        return fileNames;
    }

    protected void UploadThisFile(FileUpload upload)  // functia de upload
    {
        if (upload.HasFile)
        {
            string theFileName = Path.Combine(Server.MapPath("/Uploads/"), upload.FileName);
            upload.SaveAs(theFileName);
            labelStatus.Text = "<b>File has been uploaded.</b>";
        }
    }

    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e) // functia de stergere de fisere
    {
        e.Cancel = true;
        string fileName = ((HyperLink)GridView1.Rows[e.RowIndex].FindControl("FileLink")).Text;

        fileName = Path.Combine(Server.MapPath("/Uploads/"), fileName);
        File.Delete(fileName);
        GridView1.DataBind();
    }

}