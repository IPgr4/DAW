using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.IO;
using System.Drawing.Imaging;
using System.Drawing;
public partial class Concerte : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

           
protected void durTB_TextChanged(object sender, EventArgs e)
{

}
protected void dataTB_TextChanged(object sender, EventArgs e)
{

}
protected void locTB_TextChanged(object sender, EventArgs e)
{

}
protected void idLocTB_TextChanged(object sender, EventArgs e)
{

}
protected void intTB_TextChanged(object sender, EventArgs e)
{

}
protected void denTB_TextChanged(object sender, EventArgs e)
{

}
protected void tipTB_TextChanged(object sender, EventArgs e)
{

}
protected void btnAdauga_Click(object sender, EventArgs e)
{

    String strConnString = "Data Source=(localdb)\v11.0;Initial Catalog=Concerte;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;AttachDBFilename=|DataDirectory|Concerte.mdf";
    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings[strConnString]);
    string strQuery = "INSERT into Spectacol (IDTip, Denumire, Interpret, IdLoc, Locatia, Data, Durata) VALUES (@IDTip, @Denumire, @Interpret, @IdLoc, @Locatia, @Data, @Durata)";
    SqlCommand cmd = new SqlCommand(strQuery, con);
    cmd.Parameters.Add("@IDTip", SqlDbType.Int).Value = tipTB.Text;
    cmd.Parameters.Add("@Denumire", SqlDbType.VarChar).Value = denTB.Text;
    cmd.Parameters.Add("@Interpret", SqlDbType.VarChar).Value = intTB.Text;
    cmd.Parameters.Add("@IdLoc", SqlDbType.Int).Value = idLocTB.Text;
    cmd.Parameters.Add("@Locatia", SqlDbType.VarChar).Value = locTB.Text;
    cmd.Parameters.Add("@Data", SqlDbType.Date).Value = dataTB.Text;
    cmd.Parameters.Add("@Durata", SqlDbType.Int).Value = durTB.Text;
    
    try
    {
        con.Open();
        cmd.ExecuteNonQuery();
        lblMessage.ForeColor = System.Drawing.Color.Green;
        lblMessage.Text = "File Uploaded Successfully";
        
    }
    catch (Exception ex)
    {
        Response.Write(ex.Message);
        
    }
    finally
    {
        con.Close();
        con.Dispose();
    }
}
}