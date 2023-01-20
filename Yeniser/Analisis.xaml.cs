using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Yeniser
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Analisis : ContentPage
    {
        string Guion = "0.00";
        string Pollito = "1.59";
        string SeisOz = "2.13";
        string Pinta = "3.94";
        string Pizza = "6.44";
        string Once8 = "2.49";
        string Once12 = "3.94";
        Double Cantidad, Peso, Resultado;
        public Analisis()
        {
            InitializeComponent();
            //Inicializar los Picker de los Empaques..
            Empaque1.Items.Add("-");
            Empaque1.Items.Add("4.4 Oz");
            Empaque1.Items.Add("6 Oz");
            Empaque1.Items.Add("1 Pt");
            Empaque1.Items.Add("18 Oz");
            Empaque1.Items.Add("11x8");
            Empaque1.Items.Add("11x12");
            Empaque2.Items.Add("-");
            Empaque2.Items.Add("4.4 Oz");
            Empaque2.Items.Add("6 Oz");
            Empaque2.Items.Add("1 Pt");
            Empaque2.Items.Add("18 Oz");
            Empaque2.Items.Add("11x8");
            Empaque2.Items.Add("11x12");
            Empaque3.Items.Add("-");
            Empaque3.Items.Add("4.4 Oz");
            Empaque3.Items.Add("6 Oz");
            Empaque3.Items.Add("1 Pt");
            Empaque3.Items.Add("18 Oz");
            Empaque3.Items.Add("11x8");
            Empaque3.Items.Add("11x12");
            Empaque4.Items.Add("-");
            Empaque4.Items.Add("4.4 Oz");
            Empaque4.Items.Add("6 Oz");
            Empaque4.Items.Add("1 Pt");
            Empaque4.Items.Add("18 Oz");
            Empaque4.Items.Add("11x8");
            Empaque4.Items.Add("11x12");
            Cosechadores.Focus();
        }
        private void Cosechadores_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Cosechadores.Text != "0" && Cosechadores.Text !="")
            {
                Suma_Primeras();
            }
            else
            {
                DisplayAlert("Ingresa un Dato valido", "Error al Ingresar el dato:", "Ok");
                Cosechadores.Text = "";
                Cosechadores.Focus();
            }
        }

        private void Proceso_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Proceso.Text != "0" && Proceso.Text != "")
            {
                Suma_Primeras();
            }
            else
            {
                DisplayAlert("Ingresa un Dato valido", "Error al Ingresar el dato:", "Ok");
                Proceso.Text = "";
                Proceso.Focus();
            }
        }
        public void Variable1()
        {
            Cantidad = Convert.ToDouble(Cantidad1.Text);
            Peso = Convert.ToDouble(Peso1.Text);
            Resultado = Cantidad * Peso;
        }
        public void Variable2()
        {
            Cantidad = Convert.ToDouble(Cantidad2.Text);
            Peso = Convert.ToDouble(Peso2.Text);
            Resultado = Cantidad * Peso;
        }
        public void Variable3()
        {
            Cantidad = Convert.ToDouble(Cantidad3.Text);
            Peso = Convert.ToDouble(Peso3.Text);
            Resultado = Cantidad * Peso;
        }
        public void Variable4()
        {
            Cantidad = Convert.ToDouble(Cantidad4.Text);
            Peso = Convert.ToDouble(Peso4.Text);
            Resultado = Cantidad * Peso;
        }
        private void Suma_Primeras()
        {
            Double Num1 = Convert.ToDouble(Primera1.Text);
            Double Num2 = Convert.ToDouble(Primera2.Text);
            Double Num3 = Convert.ToDouble(Primera3.Text);
            Double Num4 = Convert.ToDouble(Primera4.Text);
            Double Res = Num1 + Num2 + Num3 + Num4;
            Double Procesos = Convert.ToDouble(Proceso.Text);
            Double Res_Pro = Res + Procesos;
            Double Person = Convert.ToDouble(Cosechadores.Text);
            Double Cosech = Res / Person;
            Double Porcentaje = (Procesos/Res_Pro) * 100;

            Fruta_Primera.Text = Math.Round(Res, 3).ToString() + " Kg";
            Fruta_Total.Text = Math.Round(Res_Pro, 3).ToString() + " Kg";
            kg_persona.Text = Math.Round(Cosech, 3).ToString() + " Kg";
            Porcentaje_Proceso.Text = Math.Round(Porcentaje, 2).ToString() + " %";
            //Pendiente escribir el Precio y la formula..
        }
        private void Empaque_Uno()
        {
            switch (Empaque1.SelectedItem)
            {
                case "-":
                    Peso1.Text = Guion;
                    Cantidad1.Text = "0";
                    Primera1.Text = Guion;
                    break;
                case "4.4 Oz":
                    Peso1.Text = Pollito;
                    Variable1();
                    if (Cantidad1.Text != "" && Cantidad1.Text != "0")
                    {
                        Primera1.Text = Math.Round(Resultado, 2).ToString();
                    }
                    break;
                case "6 Oz":
                    Peso1.Text = SeisOz;
                    Variable1();
                    if (Cantidad1.Text != "" && Cantidad1.Text != "0")
                    {
                        Primera1.Text = Math.Round(Resultado, 2).ToString();
                    }
                    break;
                case "1 Pt":
                    Peso1.Text = Pinta;
                    Variable1();
                    if (Cantidad1.Text != "" && Cantidad1.Text != "0")
                    {
                        Primera1.Text = Math.Round(Resultado, 2).ToString();
                    }
                    break;
                case "18 Oz":
                    Peso1.Text = Pizza;
                    Variable1();
                    if (Cantidad1.Text != "" && Cantidad1.Text != "0")
                    {
                        Primera1.Text = Math.Round(Resultado, 2).ToString();
                    }
                    break;
                case "11x8":
                    Peso1.Text = Once8;
                    Variable1();
                    if (Cantidad1.Text != "" && Cantidad1.Text != "0")
                    {
                        Primera1.Text = Math.Round(Resultado, 2).ToString();
                    }
                    break;
                case "11x12":
                    Peso1.Text = Once12;
                    Variable1();
                    if (Cantidad1.Text != "" && Cantidad1.Text != "0")
                    {
                        Primera1.Text = Math.Round(Resultado, 2).ToString();
                    }
                    break;
            }
            Suma_Primeras();
        }
        private void Empaque_Dos()
        {
            switch (Empaque2.SelectedItem)
            {
                case "-":
                    Peso2.Text = Guion;
                    Cantidad2.Text = "0";
                    Primera2.Text = Guion;
                    break;
                case "4.4 Oz":
                    Peso2.Text = Pollito;
                    Variable2();
                    if (Cantidad2.Text != "" && Cantidad2.Text != "0")
                    {
                        Primera2.Text = Math.Round(Resultado, 2).ToString();
                    }
                    break;
                case "6 Oz":
                    Peso2.Text = SeisOz;
                    Variable2();
                    if (Cantidad2.Text != "" && Cantidad2.Text != "0")
                    {
                        Primera2.Text = Math.Round(Resultado, 2).ToString();
                    }
                    break;
                case "1 Pt":
                    Peso2.Text = Pinta;
                    Variable2();
                    if (Cantidad2.Text != "" && Cantidad2.Text != "0")
                    {
                        Primera2.Text = Math.Round(Resultado, 2).ToString();
                    }
                    break;
                case "18 Oz":
                    Peso2.Text = Pizza;
                    Variable2();
                    if (Cantidad2.Text != "" && Cantidad2.Text != "0")
                    {
                        Primera2.Text = Math.Round(Resultado, 2).ToString();
                    }
                    break;
                case "11x8":
                    Peso2.Text = Once8;
                    Variable2();
                    if (Cantidad2.Text != "" && Cantidad2.Text != "0")
                    {
                        Primera2.Text = Math.Round(Resultado, 2).ToString();
                    }
                    break;
                case "11x12":
                    Peso2.Text = Once12;
                    Variable2();
                    if (Cantidad2.Text != "" && Cantidad2.Text != "0")
                    {
                        Primera2.Text = Math.Round(Resultado, 2).ToString();
                    }
                    break;
            }
            Suma_Primeras();
        }
        private void Empaque_Tres()
        {
            switch (Empaque3.SelectedItem)
            {
                case "-":
                    Peso3.Text = Guion;
                    Cantidad3.Text = "0";
                    Primera3.Text = Guion;
                    break;
                case "4.4 Oz":
                    Peso3.Text = Pollito;
                    Variable3();
                    if (Cantidad3.Text != "" && Cantidad3.Text != "0")
                    {
                        Primera3.Text = Math.Round(Resultado, 2).ToString();
                    }
                    break;
                case "6 Oz":
                    Peso3.Text = SeisOz;
                    Variable3();
                    if (Cantidad3.Text != "" && Cantidad3.Text != "0")
                    {
                        Primera3.Text = Math.Round(Resultado, 2).ToString();
                    }
                    break;
                case "1 Pt":
                    Peso3.Text = Pinta;
                    Variable3();
                    if (Cantidad3.Text != "" && Cantidad3.Text != "0")
                    {
                        Primera3.Text = Math.Round(Resultado, 2).ToString();
                    }
                    break;
                case "18 Oz":
                    Peso3.Text = Pizza;
                    Variable3();
                    if (Cantidad3.Text != "" && Cantidad3.Text != "0")
                    {
                        Primera3.Text = Math.Round(Resultado, 2).ToString();
                    }
                    break;
                case "11x8":
                    Peso3.Text = Once8;
                    Variable3();
                    if (Cantidad3.Text != "" && Cantidad3.Text != "0")
                    {
                        Primera3.Text = Math.Round(Resultado, 2).ToString();
                    }
                    break;
                case "11x12":
                    Peso3.Text = Once12;
                    Variable3();
                    if (Cantidad3.Text != "" && Cantidad3.Text != "0")
                    {
                        Primera3.Text = Math.Round(Resultado, 2).ToString();
                    }
                    break;
            }
            Suma_Primeras();
        }
        private void Empaque_Cuatro()
        {
            switch (Empaque4.SelectedItem)
            {
                case "-":
                    Peso4.Text = Guion;
                    Cantidad4.Text = "0";
                    Primera4.Text = Guion;
                    break;
                case "4.4 Oz":
                    Peso4.Text = Pollito;
                    Variable4();
                    if (Cantidad4.Text != "" && Cantidad4.Text != "0")
                    {
                        Primera4.Text = Math.Round(Resultado, 2).ToString();
                    }
                    break;
                case "6 Oz":
                    Peso4.Text = SeisOz;
                    Variable4();
                    if (Cantidad4.Text != "" && Cantidad4.Text != "0")
                    {
                        Primera4.Text = Math.Round(Resultado, 2).ToString();
                    }
                    break;
                case "1 Pt":
                    Peso4.Text = Pinta;
                    Variable4();
                    if (Cantidad4.Text != "" && Cantidad4.Text != "0")
                    {
                        Primera4.Text = Math.Round(Resultado, 2).ToString();
                    }
                    break;
                case "18 Oz":
                    Peso4.Text = Pizza;
                    Variable4();
                    if (Cantidad4.Text != "" && Cantidad4.Text != "0")
                    {
                        Primera4.Text = Math.Round(Resultado, 2).ToString();
                    }
                    break;
                case "11x8":
                    Peso4.Text = Once8;
                    Variable4();
                    if (Cantidad4.Text != "" && Cantidad4.Text != "0")
                    {
                        Primera4.Text = Math.Round(Resultado, 2).ToString();
                    }
                    break;
                case "11x12":
                    Peso4.Text = Once12;
                    Variable4();
                    if (Cantidad4.Text != "" && Cantidad4.Text != "0")
                    {
                        Primera4.Text = Math.Round(Resultado, 2).ToString();
                    }
                    break;
            }
            Suma_Primeras();
        }
        private void Empaque1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Empaque_Uno();
        }

        private void Empaque2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Empaque_Dos();
        }
        private void Empaque3_SelectedIndexChanged(object sender, EventArgs e)
        {
            Empaque_Tres();
        }

        private void Empaque4_SelectedIndexChanged(object sender, EventArgs e)
        {
            Empaque_Cuatro();
        }


        private void Cantidad1_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Cantidad1.Text != "")
            {
                Empaque_Uno();
            }
            if (Cantidad1.Text == "" || Cantidad1.Text == "0")
            {
                Primera1.Text = "0.00";
                Suma_Primeras();
            }
            
        }

        private void Cantidad2_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Cantidad2.Text != "")
            {
                Empaque_Dos();
            }
            if (Cantidad2.Text == "" || Cantidad2.Text == "0")
            {
                Primera2.Text = "0.00";
                Suma_Primeras();
            }
        }

        private void Cantidad3_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Cantidad3.Text != "")
            {
                Empaque_Tres();
            }
            if (Cantidad3.Text == "" || Cantidad3.Text == "0")
            {
                Primera3.Text = "0.00";
                Suma_Primeras();
            }
        }

        private void Cantidad4_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Cantidad4.Text != "")
            {
                Empaque_Cuatro();
            }
            if (Cantidad4.Text == "" || Cantidad4.Text == "0")
            {
                Primera4.Text = "0.00";
                Suma_Primeras();
            }
        }
        private void Cantidad1_Focused(object sender, FocusEventArgs e)
        {
            if (Cantidad1.Text == "0")
            {
                Cantidad1.Text = "";
            }
        }
        private void Cantidad2_Focused(object sender, FocusEventArgs e)
        {
            if (Cantidad2.Text == "0")
            {
                Cantidad2.Text = "";
            }
        }

        private void Cantidad3_Focused(object sender, FocusEventArgs e)
        {
            if (Cantidad3.Text == "0")
            {
                Cantidad3.Text = "";
            }
        }

        private void Cantidad4_Focused(object sender, FocusEventArgs e)
        {
            if (Cantidad4.Text == "0")
            {
                Cantidad4.Text = "";
            }
        }

        // Cambiar de Focus de Empaques: borra el numero igual a cero.

        private void Cosechadores_Unfocused(object sender, FocusEventArgs e)
        {
            Proceso.Focus();
        }
    }
}