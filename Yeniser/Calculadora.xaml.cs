using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Yeniser
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Calculadora : ContentPage
    {
        bool haypunto = false, haypunto2 = false;
        public Calculadora()
        {
            InitializeComponent();
        }
        private void Operaciones()
        {
            string Operacion = Operacional.Text;
            switch (Operacion)
            {
                case " + ":
                    if (Primer_Numero.Text != "" && Segundo_Numero.Text != "")
                    {
                        double Num1 = Convert.ToDouble(Primer_Numero.Text);
                        double Num2 = Convert.ToDouble(Segundo_Numero.Text);
                        double Res = Num1 + Num2;
                        Resultado.Text = Math.Round(Res,5).ToString();
                    }
                    else if (Segundo_Numero.Text =="")
                    {
                        Resultado.Text = Primer_Numero.Text;
                    }
                    break;
                case " - ":
                    if (Primer_Numero.Text != "" && Segundo_Numero.Text != "")
                    {
                        double Num1 = Convert.ToDouble(Primer_Numero.Text);
                        double Num2 = Convert.ToDouble(Segundo_Numero.Text);
                        double Res = Num1 - Num2;
                        Resultado.Text = Math.Round(Res, 5).ToString();
                    }
                    else if (Segundo_Numero.Text == "")
                    {
                        Resultado.Text = Primer_Numero.Text;
                    }
                    break;
                case " x ":
                    if (Primer_Numero.Text != "" && Segundo_Numero.Text != "")
                    {
                        double Num1 = Convert.ToDouble(Primer_Numero.Text);
                        double Num2 = Convert.ToDouble(Segundo_Numero.Text);
                        double Res = Num1 * Num2;
                        Resultado.Text = Math.Round(Res, 5).ToString();
                    }
                    else if (Segundo_Numero.Text == "")
                    {
                        Resultado.Text = Primer_Numero.Text;
                    }
                    break;
                case " / ":
                    if (Primer_Numero.Text != "" && Segundo_Numero.Text != "")
                    {
                        double Num1 = Convert.ToDouble(Primer_Numero.Text);
                        double Num2 = Convert.ToDouble(Segundo_Numero.Text);
                        double Res = Num1 / Num2;
                        Resultado.Text = Math.Round(Res, 5).ToString();
                    }
                    else if (Segundo_Numero.Text == "")
                    {
                        Resultado.Text = Primer_Numero.Text;
                    }
                    break;
                case " % ":
                    if (Primer_Numero.Text != "" && Segundo_Numero.Text != "")
                    {
                        double Num1 = Convert.ToDouble(Primer_Numero.Text);
                        double Num2 = Convert.ToDouble(Segundo_Numero.Text);
                        double Res = Num1 * Num2;
                        Resultado.Text = Math.Round(Res, 5).ToString();

                    }
                    else if (Segundo_Numero.Text == "")
                    {
                        Resultado.Text = Primer_Numero.Text;
                    }
                    break;

            }
        }
        private void ResetPunto()
        {
            haypunto = false; haypunto2 = false;
        }
        ///Operacionales de la Aritmetica
        private void Button_Sumar(object sender, EventArgs e)
        {
            Operacional.Text = " + ";
            if (Primer_Numero.Text !="" && Segundo_Numero.Text !="" && Resultado.Text != "")
            {
                Primer_Numero.Text = Resultado.Text;
                Operacional.Text = " + ";
                Segundo_Numero.Text ="";
                Resultado.Text = "";
            }
            ResetPunto();
        }
        private void Button_Restar(object sender, EventArgs e)
        {
            Operacional.Text = " - ";
            if (Primer_Numero.Text != "" && Segundo_Numero.Text != "" && Resultado.Text != "")
            {
                Primer_Numero.Text = Resultado.Text;
                Operacional.Text = " - ";
                Segundo_Numero.Text = "";
                Resultado.Text = "";
            }
            ResetPunto();
        }

        private void Button_Multiplicar(object sender, EventArgs e)
        {
            Operacional.Text = " x ";
            if (Primer_Numero.Text != "" && Segundo_Numero.Text != "" && Resultado.Text != "")
            {
                Primer_Numero.Text = Resultado.Text;
                Operacional.Text = " x ";
                Segundo_Numero.Text = "";
                Resultado.Text = "";
            }
            ResetPunto();
        }

        private void Button_Dividir(object sender, EventArgs e)
        {
            Operacional.Text = " / ";
            if (Primer_Numero.Text != "" && Segundo_Numero.Text != "" && Resultado.Text != "")
            {
                Primer_Numero.Text = Resultado.Text;
                Operacional.Text = " / ";
                Segundo_Numero.Text = "";
                Resultado.Text = "";
            }
            ResetPunto();
        }
        //Otros Botones extras
        private void Button_AC(object sender, EventArgs e)
        {
            Primer_Numero.Text = "";
            Segundo_Numero.Text = "";
            Operacional.Text = "";
            Resultado.Text = "0";
            haypunto = false;
            haypunto2 = false;
        }
        private void Button_Porcentaje(object sender, EventArgs e)
        {
            if (Primer_Numero.Text !="" && Segundo_Numero.Text =="" && Resultado.Text == "0" )
            {
                Decimal Num1 = Convert.ToDecimal(Primer_Numero.Text);
                Decimal Resulta = Num1 / 100;
                Primer_Numero.Text = Resulta.ToString();
                Operacional.Text = " % ";
            }
            else if (Primer_Numero.Text != "" && Segundo_Numero.Text != "" && Resultado.Text !="" )
            {
                Decimal Num1 = Convert.ToDecimal(Resultado.Text);
                Decimal Resulta = Num1 / 100;
                Primer_Numero.Text = Resulta.ToString();
                Segundo_Numero.Text = "";
                Resultado.Text = "";
                Operacional.Text = " % ";
            }
            Operaciones();
            ResetPunto();
        }
        private void Button_Punto(object sender, EventArgs e)
        {

            if (Primer_Numero.Text != "" && Segundo_Numero.Text =="")
            {
                if (!haypunto)
                {
                    Primer_Numero.Text = Primer_Numero.Text + ".";
                    haypunto = true;
                }
                
            }
            if (Primer_Numero.Text!="" && Segundo_Numero.Text != "")
            {
                if (!haypunto2)
                {
                    Segundo_Numero.Text = Segundo_Numero.Text + ".";
                    haypunto2 = true;
                }

            }


        }
        private void Button_Eliminar(object sender, EventArgs e)
        {
            if (Primer_Numero.Text != "" && Operacional.Text == "")
            {
                Primer_Numero.Text = Primer_Numero.Text.Substring(0, Primer_Numero.Text.Length - 1);
            }
            else if (Primer_Numero.Text !="" && Segundo_Numero.Text != "")
            {
                Segundo_Numero.Text = Segundo_Numero.Text.Substring(0, Segundo_Numero.Text.Length - 1);
            }
            else if (Operacional.Text !="" && Segundo_Numero.Text == "")
            {
                Operacional.Text = "";
            }
            Operaciones();
            if (Primer_Numero.Text == "")
            {
                Resultado.Text = "0";
            }
            
        }
        private void Button_Igual(object sender, EventArgs e)
        {
            Operaciones();
            ResetPunto();
        }


        //Numeros Naturales
        private void NumeroZero(object sender, EventArgs e)
        {
            if (Primer_Numero.Text != "0")
            {
                if (Primer_Numero.Text == "" || Operacional.Text == "")
                {
                    Primer_Numero.Text = Primer_Numero.Text + "0";
                }
                if (Segundo_Numero.Text != "0")
                {
                    if (Operacional.Text != "")
                    {
                            Segundo_Numero.Text = Segundo_Numero.Text + "0";
                    }
                }
                Operaciones();
            }
        }
        private void Numero1(object sender, EventArgs e)
        {
            if (Primer_Numero.Text == "0")
            {
                Primer_Numero.Text = "1";
            }
            else
            {
                if (Primer_Numero.Text == "" || Operacional.Text == "")
                {
                    Primer_Numero.Text = Primer_Numero.Text + "1";
                }
                if (Segundo_Numero.Text == "0")
                {
                    Segundo_Numero.Text = "1";
                }
                else if (Segundo_Numero.Text != "0")
                {
                    if (Operacional.Text != "")
                    {
                        Segundo_Numero.Text = Segundo_Numero.Text + "1";
                    }
                }
                Operaciones();
            }
        }
        private void Numero2(object sender, EventArgs e)
        {
            if (Primer_Numero.Text == "0")
            {
                Primer_Numero.Text = "2";
            }
            else
            {
                if (Primer_Numero.Text == "" || Operacional.Text == "")
                {
                    Primer_Numero.Text = Primer_Numero.Text + "2";
                }
                if (Segundo_Numero.Text == "0")
                {
                    Segundo_Numero.Text = "2";
                }
                else if (Segundo_Numero.Text != "0")
                {
                    if (Operacional.Text != "")
                    {
                        Segundo_Numero.Text = Segundo_Numero.Text + "2";
                    }
                }
                Operaciones();
            }
        }
        private void Numero3(object sender, EventArgs e)
        {
            if (Primer_Numero.Text == "0")
            {
                Primer_Numero.Text = "3";
            }
            else
            {
                if (Primer_Numero.Text == "" || Operacional.Text == "")
                {
                    Primer_Numero.Text = Primer_Numero.Text + "3";
                }
                if (Segundo_Numero.Text == "0")
                {
                    Segundo_Numero.Text = "3";
                }
                else if (Segundo_Numero.Text != "0")
                {
                    if (Operacional.Text != "")
                    {
                        Segundo_Numero.Text = Segundo_Numero.Text + "3";
                    }
                }
                Operaciones();
            }
        }
        private void Numero4(object sender, EventArgs e)
        {
            if (Primer_Numero.Text == "0")
            {
                Primer_Numero.Text = "4";
            }
            else
            {
                if (Primer_Numero.Text == "" || Operacional.Text == "")
                {
                    Primer_Numero.Text = Primer_Numero.Text + "4";
                }
                if (Segundo_Numero.Text == "0")
                {
                    Segundo_Numero.Text = "4";
                }
                else if (Segundo_Numero.Text != "0")
                {
                    if (Operacional.Text != "")
                    {
                        Segundo_Numero.Text = Segundo_Numero.Text + "4";
                    }
                }
                Operaciones();
            }
        }
        private void Numero5(object sender, EventArgs e)
        {
            if (Primer_Numero.Text == "0")
            {
                Primer_Numero.Text = "5";
            }
            else
            {
                if (Primer_Numero.Text == "" || Operacional.Text == "")
                {
                    Primer_Numero.Text = Primer_Numero.Text + "5";
                }
                if (Segundo_Numero.Text == "0")
                {
                    Segundo_Numero.Text = "5";
                }
                else if (Segundo_Numero.Text != "0")
                {
                    if (Operacional.Text != "")
                    {
                        Segundo_Numero.Text = Segundo_Numero.Text + "5";
                    }
                }
                Operaciones();
            }
        }
        private void Numero6(object sender, EventArgs e)
        {
            if (Primer_Numero.Text == "0")
            {
                Primer_Numero.Text = "6";
            }
            else
            {
                if (Primer_Numero.Text == "" || Operacional.Text == "")
                {
                    Primer_Numero.Text = Primer_Numero.Text + "6";
                }
                if (Segundo_Numero.Text == "0")
                {
                    Segundo_Numero.Text = "6";
                }
                else if (Segundo_Numero.Text != "0")
                {
                    if (Operacional.Text != "")
                    {
                        Segundo_Numero.Text = Segundo_Numero.Text + "6";
                    }
                }
                Operaciones();
            }
        }
        private void Numero7(object sender, EventArgs e)
        {
            if (Primer_Numero.Text == "0")
            {
                Primer_Numero.Text = "7";
            }
            else
            {
                if (Primer_Numero.Text == "" || Operacional.Text == "")
                {
                    Primer_Numero.Text = Primer_Numero.Text + "7";
                }
                if (Segundo_Numero.Text == "0")
                {
                    Segundo_Numero.Text = "7";
                }
                else if (Segundo_Numero.Text != "0")
                {
                    if (Operacional.Text != "")
                    {
                        Segundo_Numero.Text = Segundo_Numero.Text + "7";
                    }
                }
                Operaciones();
            }
        }

        private void Numero8(object sender, EventArgs e)
        {
            if (Primer_Numero.Text == "0")
            {
                Primer_Numero.Text = "8";
            }
            else
            {
                if (Primer_Numero.Text == "" || Operacional.Text == "")
                {
                    Primer_Numero.Text = Primer_Numero.Text + "8";
                }
                if (Segundo_Numero.Text == "0")
                {
                    Segundo_Numero.Text = "8";
                }
                else if (Segundo_Numero.Text != "0")
                {
                    if (Operacional.Text != "")
                    {
                        Segundo_Numero.Text = Segundo_Numero.Text + "8";
                    }
                }
                Operaciones();
            }
        }
        private void Numero9(object sender, EventArgs e)
        {
            if (Primer_Numero.Text == "0")
            {
                Primer_Numero.Text = "9";
            }
            else
            {
                if (Primer_Numero.Text == "" || Operacional.Text == "")
                {
                    Primer_Numero.Text = Primer_Numero.Text + "9";
                }
                if (Segundo_Numero.Text == "0")
                {
                    Segundo_Numero.Text = "9";
                }
                else if (Segundo_Numero.Text != "0")
                {
                    if (Operacional.Text != "")
                    {
                        Segundo_Numero.Text = Segundo_Numero.Text + "9";
                    }
                }
                Operaciones();
            }
        }
    }
}