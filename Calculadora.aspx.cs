using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Calculadora
{
    public partial class Calculadora : System.Web.UI.Page
    {
        Calculadora_Clase _calculadora;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Visible = false;
        }

        protected void btnSumar_Click(object sender, EventArgs e)
        {
            _calculadora = new Calculadora_Clase();
            if (txtCalculadora.Text == "" || txtCalculadora2.Text == "")
            {
                Label1.Text = "Debe ingresar un número en ambos cuadros";
                Label1.Visible = true;
            }
            else
            {   
                _calculadora.numero1 = Convert.ToDouble(txtCalculadora.Text);
                Session["numero1"] = txtCalculadora.Text;
                _calculadora.numero2 = Convert.ToDouble(txtCalculadora2.Text);
                Session["numero2"] = txtCalculadora2.Text;
                txtResultado.Text = Convert.ToString(_calculadora.Suma());
                Session["suma"] = txtResultado.Text;
                txtCalculadora.Text = "";
                txtCalculadora2.Text = "";
            }
        }

        protected void btnRestar_Click(object sender, EventArgs e)
        {
            _calculadora = new Calculadora_Clase();

            if (txtCalculadora.Text == "" || txtCalculadora2.Text == "")
            {
                Label1.Text = "Debe ingresar un número en ambos cuadros";
                Label1.Visible = true;
            }
            else
            {
                _calculadora.numero1 = Convert.ToDouble(txtCalculadora.Text);
                Session["numero1"] = txtCalculadora.Text;
                _calculadora.numero2 = Convert.ToDouble(txtCalculadora2.Text);
                Session["numero2"] = txtCalculadora2.Text;
                txtResultado.Text = Convert.ToString(_calculadora.Resta());
                Session["resta"] = txtResultado.Text;
                txtCalculadora.Text = "";
                txtCalculadora2.Text = "";
            }
        }

        protected void btnMultiplicar_Click(object sender, EventArgs e)
        {
            _calculadora = new Calculadora_Clase();

            if (txtCalculadora.Text == "" || txtCalculadora2.Text == "")
            {
                Label1.Text = "Debe ingresar un número en ambos cuadros";
                Label1.Visible = true;
            }
            else
            {
                _calculadora.numero1 = Convert.ToDouble(txtCalculadora.Text);
                Session["numero1"] = txtCalculadora.Text;
                _calculadora.numero2 = Convert.ToDouble(txtCalculadora2.Text);
                Session["numero2"] = txtCalculadora2.Text;
                txtResultado.Text = Convert.ToString(_calculadora.Multiplicacion());
                Session["multiplicacion"] = txtResultado.Text;
                txtCalculadora.Text = "";
                txtCalculadora2.Text = "";
            }
        }

        protected void btnDividir_Click(object sender, EventArgs e)
        {
            _calculadora = new Calculadora_Clase();

            if (txtCalculadora.Text == "" || txtCalculadora2.Text == "")
            {
                Label1.Text = "Debe ingresar un número en ambos cuadros";
                Label1.Visible = true;
            }
            else { 
                _calculadora.numero1 = Convert.ToDouble(txtCalculadora.Text);
                Session["numero1"] = txtCalculadora.Text;
                _calculadora.numero2 = Convert.ToDouble(txtCalculadora2.Text);
                Session["numero2"] = txtCalculadora2.Text;
                txtResultado.Text = Convert.ToString(_calculadora.Division());
                txtCalculadora.Text = "";
                txtCalculadora2.Text = "";
                if (txtResultado.Text == "∞")
                {
                    txtResultado.Text = "No se puede dividir por 0";
                }
                Session["division"] = txtResultado.Text;
            }
        }

        protected void btnLogResultados_Click(object sender, EventArgs e)
        {
            Response.Redirect("logResultados.aspx");
        }
    }
}
