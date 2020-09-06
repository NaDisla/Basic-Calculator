using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Basic_Calculator
{
    public partial class MainPage : ContentPage
    {
        double firstNumber, secondNumber, resultado, estadoActual = 1;
        string textoNumero, textoOperation;
        public MainPage()
        {
            InitializeComponent();
            txtResultado.Text = "0";
        }

        void NumeroClicked(object sender, EventArgs e)
        {
            Button btnNumero = (Button)sender;
            textoNumero = btnNumero.Text;

            if(txtResultado.Text == "0" || estadoActual == -1)
            {
                if(txtResultado.Text == "0")
                {
                    txtResultado.Text = "";
                }
                if(estadoActual == -1)
                {
                    txtResultado.Text = "";
                    estadoActual = -2;
                }
            }
            txtResultado.Text += textoNumero;
            if (estadoActual == 1)
            { 
                firstNumber = double.Parse(txtResultado.Text);
            }
            else if (estadoActual < 0)
            {
                secondNumber = double.Parse(txtResultado.Text);
            }
        }

        void SelectOperation(object sender, EventArgs e)
        {
            Button btnOperation = (Button)sender;
            textoOperation = btnOperation.Text;
            estadoActual = -1;
        }

        void ResultOperation(object sender, EventArgs e)
        {
            txtResultado.Text = "";

            switch (textoOperation)
            {
                case "+":
                    resultado = firstNumber + secondNumber;
                    txtResultado.Text = resultado.ToString();
                    break;

                case "-":
                    resultado = firstNumber - secondNumber;
                    txtResultado.Text = resultado.ToString();
                    break;

                case "*":
                    resultado = firstNumber * secondNumber;
                    txtResultado.Text = resultado.ToString();
                    break;

                case "÷":
                    resultado = firstNumber / secondNumber;
                    txtResultado.Text = resultado.ToString();
                    break;
            }
        }

        void Clear(object sender, EventArgs e)
        {
            firstNumber = 0;
            secondNumber = 0;
            txtResultado.Text = "0";
        }
    }
}
