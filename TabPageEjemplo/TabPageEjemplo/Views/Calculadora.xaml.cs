using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TabPageEjemplo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Calculadora : ContentPage
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        public string Operador { get; set; }

        private void clic7(object sender, EventArgs e)
        {
            double valorActual = double.Parse(inputs.Text);

            if (valorActual == 0.0 || Operador == "=")
            {
                inputs.Text = "7";
            }
            else {

                inputs.Text = inputs.Text + "7";
            }
        }

        private void clic8(object sender, EventArgs e)
        {
            double valorActual = double.Parse(inputs.Text);

            if (valorActual == 0.0 || Operador == "=")
            {
                inputs.Text = "8";
            }
            else
            {

                inputs.Text = inputs.Text + "8";
            }
        }

        private void clic9(object sender, EventArgs e)
        {
            double valorActual = double.Parse(inputs.Text);

            if (valorActual == 0.0 || Operador == "=")
            {
                inputs.Text = "9";
            }
            else
            {

                inputs.Text = inputs.Text + "9";
            }
        }

       

        private void clicNumero(object sender, EventArgs e)
        {
            Button tmp = (Button)sender;
            string tmpValText = tmp.Text;

            double valorActual = double.Parse(inputs.Text);

            if (valorActual == 0.0 || Operador == "=")
            {
                inputs.Text = tmpValText;
            }
            else
            {

                inputs.Text = inputs.Text + tmpValText;
            }
        }

        private void accionLimpiar(object sender, EventArgs e)
        {
            inputs.Text = "0";
        }

        private void clicX(object sender, EventArgs e)
        {

            valorAnterior.Text = inputs.Text;
            inputs.Text = "0";
            Operador = "x";
        }

        private void clicIgual(object sender, EventArgs e)
        {
            double resultadoFinal = 0;

            if (Operador == "x") {
                resultadoFinal = double.Parse(valorAnterior.Text) * double.Parse(inputs.Text);
                valorAnterior.Text = valorAnterior.Text + " x " + inputs.Text;
                inputs.Text = resultadoFinal.ToString();
                Operador = "=";
            }
            

        }
    }
}