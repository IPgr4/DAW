using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class Account_MembersOnly : System.Web.UI.Page
{
    static bool bold = false, italic = false, underl = false, strike= false;
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    //controllerul  cutiei text
    protected void textBox1_TextChanged(object sender, EventArgs e)
    {

    }
    //controllerul butonului de underline
    protected void btnUnderline_Click(object sender, EventArgs e)
    {
        if (!underl)
        {
            textBox1.Font.Underline = true;
            underl = true;
        }
        else
        {
            textBox1.Font.Underline = false;
            underl = false;
        }
    }
    //controllerul butonului de bold
    protected void btnBold_Click(object sender, EventArgs e)
    {
        if (!bold)
        {
            textBox1.Font.Bold = true;
            bold = true;
        }
        else
        {
            textBox1.Font.Bold = false;
            bold = false;
        }
    }
    //controllerul butonului de italic
    protected void btnItalic_Click(object sender, EventArgs e)
    {
        if (!italic)
        {
            textBox1.Font.Italic = true;
            italic = true;
        }
        else
        {
            textBox1.Font.Italic = false;
            italic = false;
        }
    }

    //controllerul butonului de text taiat
    protected void btnStrike_Click(object sender, EventArgs e)
    {
        if (!strike)
        {
            textBox1.Font.Strikeout = true;
            strike = true;
        }
        else
        {
            textBox1.Font.Strikeout = false;
            strike = false;
        }
    }

    //controllerul butonului de font size 8
    protected void btnF8_Click(object sender, EventArgs e)
    {
        textBox1.Font.Size = 8;
    }
    //controllerul butonului de font size 10
    protected void btnF10_Click(object sender, EventArgs e)
    {
        textBox1.Font.Size = 10;
    }
    //controllerul butonului de font size 12
    protected void btnF12_Click(object sender, EventArgs e)
    {
        textBox1.Font.Size = 12;
    }//controllerul butonului de font size 14
    protected void btnf14_Click(object sender, EventArgs e)
    {
        textBox1.Font.Size = 14;
    }
    //controllerul butonului de font size 16
    protected void btnF16_Click(object sender, EventArgs e)
    {
        textBox1.Font.Size = 16;
    }
    //controllerul butonului de font size 18
    protected void btnF18_Click(object sender, EventArgs e)
    {
        textBox1.Font.Size = 18;
    }
    //controllerul butonului de font size 20
    protected void btnF20_Click(object sender, EventArgs e)
    {
        textBox1.Font.Size = 20;
    }
    //controllerele butoanelor pentru modificarea culorii textului
    protected void btnColor_Click(object sender, EventArgs e)
    {
        textBox1.ForeColor = System.Drawing.Color.Red;
    }
    protected void btnCGreen_Click(object sender, EventArgs e)
    {
        textBox1.ForeColor = System.Drawing.Color.Green;
    }
    protected void btnCBlue_Click(object sender, EventArgs e)
    {
        textBox1.ForeColor = System.Drawing.Color.Blue;
    }
    protected void btnCYellow_Click(object sender, EventArgs e)
    {
        textBox1.ForeColor = System.Drawing.Color.Yellow;
    }
    protected void btnCBlack_Click(object sender, EventArgs e)
    {
        textBox1.ForeColor = System.Drawing.Color.Black;
    }
    //controllerul butoanelor pentru modificarea fontului
    protected void btnArial_Click(object sender, EventArgs e)
    {
        textBox1.Font.Name = "Arial";
    }
    protected void btnTimes_Click(object sender, EventArgs e)
    {
        textBox1.Font.Name = "Times New Roman";
    }
    protected void btnCalibri_Click(object sender, EventArgs e)
    {
        textBox1.Font.Name = "Calibri";
    }
    protected void btnGeorgia_Click(object sender, EventArgs e)
    {
        textBox1.Font.Name = "Georgia";
    }
    protected void btnCourier_Click(object sender, EventArgs e)
    {
        textBox1.Font.Name = "Courier";
    }
}