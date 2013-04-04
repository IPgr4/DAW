using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Calculator : System.Web.UI.Page
{
    //definim variabilele folosite cele doua numere, operatia si un control pt butonul de decimal.
    static decimal num1, num2, result;  
    static char op;
    static bool activ = false;
    protected void Page_Load(object sender, EventArgs e)
    {
          
    }
    protected void btn7_Click(object sender, EventArgs e) //controllerul tastei 7
    {
        if ((txtBox.Text == "+") || (txtBox.Text == "-") || (txtBox.Text == "*") || (txtBox.Text == "/"))
        {
            txtBox.Text = "";
            txtBox.Text = txtBox.Text + btn7.Text;
        }
        else
        {
            txtBox.Text = txtBox.Text + btn7.Text;
        }
    }
    protected void btn8_Click(object sender, EventArgs e) //controllerul tastei 8
    {
        if ((txtBox.Text == "+") || (txtBox.Text == "-") || (txtBox.Text == "*") || (txtBox.Text == "/"))
        {
            txtBox.Text = "";
            txtBox.Text = txtBox.Text + btn8.Text;
        }
        else
        {
            txtBox.Text = txtBox.Text + btn8.Text;
        }
    }
    protected void btn9_Click(object sender, EventArgs e) //controllerul tastei 9
    {
        if ((txtBox.Text == "+") || (txtBox.Text == "-") || (txtBox.Text == "*") || (txtBox.Text == "/"))
        {
            txtBox.Text = "";
            txtBox.Text = txtBox.Text + btn9.Text;
        }
        else
        {
            txtBox.Text = txtBox.Text + btn9.Text;
        }
    }
    protected void btnMul_Click(object sender, EventArgs e)  //controllerul tastei * (inmultire)
    {
        num1 = decimal.Parse(txtBox.Text);
        txtBox.Text = "";
        op = '*';
        txtBox.Text += op;
    }
    protected void btn4_Click(object sender, EventArgs e) //controllerul tastei 4
    {
        if ((txtBox.Text == "+") || (txtBox.Text == "-") || (txtBox.Text == "*") || (txtBox.Text == "/"))
        {
            txtBox.Text = "";
            txtBox.Text = txtBox.Text + btn4.Text;
        }
        else
        {
            txtBox.Text = txtBox.Text + btn4.Text;
        }
    }
    protected void btn5_Click(object sender, EventArgs e) //controllerul tastei 5
    {
        if ((txtBox.Text == "+") || (txtBox.Text == "-") || (txtBox.Text == "*") || (txtBox.Text == "/"))
        {
            txtBox.Text = "";
            txtBox.Text = txtBox.Text + btn5.Text;
        }
        else
        {
            txtBox.Text = txtBox.Text + btn5.Text;
        }
    }
    protected void btn6_Click(object sender, EventArgs e) //controllerul tastei 6
    {
        if ((txtBox.Text == "+") || (txtBox.Text == "-") || (txtBox.Text == "*") || (txtBox.Text == "/"))
        {
            txtBox.Text = "";
            txtBox.Text = txtBox.Text + btn6.Text;
        }
        else
        {
            txtBox.Text = txtBox.Text + btn6.Text;
        }
    }
    protected void btnMinus_Click(object sender, EventArgs e) //controllerul tastei - (minus)
    {
        num1 = decimal.Parse(txtBox.Text);
        txtBox.Text = "";
        op = '-';
        txtBox.Text += op;
    }
    protected void btn1_Click(object sender, EventArgs e) //controllerul tastei 1
    {
        if ((txtBox.Text == "+") || (txtBox.Text == "-") || (txtBox.Text == "*") || (txtBox.Text == "/"))
        {
            txtBox.Text = "";
            txtBox.Text = txtBox.Text + btn1.Text;
        }
        else
        {
            txtBox.Text = txtBox.Text + btn1.Text;
        }
    }
    protected void btn2_Click(object sender, EventArgs e) //controllerul tastei 2
    {
        if ((txtBox.Text == "+") || (txtBox.Text == "-") || (txtBox.Text == "*") || (txtBox.Text == "/"))
        {
            txtBox.Text = "";
            txtBox.Text = txtBox.Text + btn2.Text;
        }
        else
        {
            txtBox.Text = txtBox.Text + btn2.Text;
        }
    }
    protected void btn3_Click(object sender, EventArgs e) //controllerul tastei 3
    {
        if ((txtBox.Text == "+") || (txtBox.Text == "-") || (txtBox.Text == "*") || (txtBox.Text == "/"))
        {
            txtBox.Text = "";
            txtBox.Text = txtBox.Text + btn3.Text;
        }
        else
        {
            txtBox.Text = txtBox.Text + btn3.Text;
        }
    }
    protected void btnPlus_Click(object sender, EventArgs e) //controllerul tastei + (plus)
    {
        num1 = decimal.Parse(txtBox.Text);
        txtBox.Text = "";
        op = '+';
        txtBox.Text += op;
    }
    protected void btn0_Click(object sender, EventArgs e) //controllerul tastei 0
    {
        if ((txtBox.Text == "+") || (txtBox.Text == "-") || (txtBox.Text == "*") || (txtBox.Text == "/"))
        {
            txtBox.Text = "";
            txtBox.Text = txtBox.Text + btn0.Text;
        }
        else
        {
            txtBox.Text = txtBox.Text + btn0.Text;
        }
    }
    protected void btnDecimal_Click(object sender, EventArgs e) //controllerul tastei . (decimal)
    {
        if (!activ)
        {
            txtBox.Text += ".";
            activ = true;
        }
    }
    protected void btnEquals_Click(object sender, EventArgs e) //controllerul tastei = (egal)
    {
        num2 = decimal.Parse(txtBox.Text);
        txtBox.Text = "";
        if(op=='/')
          {
          result = num1 / num2;
          txtBox.Text += result;
          num1 = result;
          }
         else 
            if (op == '+')
            {
            result = num1 + num2;
            txtBox.Text += result;
            num1 = result;
            }
            else 
                if (op == '-')
                   {
                   result = num1 - num2;
                   txtBox.Text += result;
                   num1 = result;
                   }
                 else
                  {
                  result = num1 * num2;
                  txtBox.Text += result;
                  num1 = result;
                  }
    }

    protected void txtBox_TextChanged(object sender, EventArgs e) //controllerul display-ului text
    {

    }
    protected void btnClear_Click(object sender, EventArgs e) //controllerul tastei Clear
    {
        txtBox.Text = null;
    }
    protected void btnDiv_Click(object sender, EventArgs e) //controllerul tastei / (impartire)
    {
        num1 = decimal.Parse(txtBox.Text);
        txtBox.Text = "";
        op = '/';
        txtBox.Text += op;
    }
}