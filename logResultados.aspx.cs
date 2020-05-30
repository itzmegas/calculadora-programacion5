using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Calculadora
{
    public partial class logResultados : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "Suma: "+ Convert.ToString(Session["suma"]);
            Label2.Text = "Resta: " + Convert.ToString(Session["resta"]);
            Label3.Text = "Multiplicación: " + Convert.ToString(Session["multiplicacion"]);
            Label4.Text = "División: " + Convert.ToString(Session["division"]);
        }

    }
}