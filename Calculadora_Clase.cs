using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Calculadora
{
    public class Calculadora_Clase
    {
        public double numero1 { get; set; }
        public double numero2 { get; set; }
        
        public double Suma()
        {
            return numero1 + numero2;
        }
        public double Resta()
        {
            return numero1 - numero2;
        }
        public double Multiplicacion()
        {
            return numero1 * numero2;
        }
        public double Division()
        {
            try
            {
                return numero1 / numero2;
            }
            catch (DivideByZeroException e)
            {
                return Convert.ToDouble(e);
            }
        }
    }
}