using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraWindowsForm
{
    public partial class Calculadora : Form
    {
        double primernum = 0, segundonum = 0 ;
        string operador;
        public Calculadora()
        {
            InitializeComponent();
        }

        Sumar Suma = new Sumar();
        Restar Resta = new Restar();
        Multiplicacion Multiplica = new Multiplicacion();
        Division Divide = new Division();

        private void boton7_Click(object sender, EventArgs e)
        {
            textBoxmostrar.Text = textBoxmostrar.Text + "7";

        }

        private void boton_suma_Click(object sender, EventArgs e)
        {
            operador = "+";
            primernum = double.Parse(textBoxmostrar.Text);
            textBoxmostrar.Clear();
        }

        private void boton_backspace_Click(object sender, EventArgs e)
        {
            if (textBoxmostrar.Text.Length == 1)
                textBoxmostrar.Text = "";
            else
                textBoxmostrar.Text = textBoxmostrar.Text.Substring(0, textBoxmostrar.Text.Length - 1);
        }

        private void boton1_Click(object sender, EventArgs e)
        {
            textBoxmostrar.Text = textBoxmostrar.Text + "1";

        }

        private void boton2_Click(object sender, EventArgs e)
        {
            textBoxmostrar.Text = textBoxmostrar.Text + "2";
        }

        private void boton3_Click(object sender, EventArgs e)
        {
            textBoxmostrar.Text = textBoxmostrar.Text + "3";
        }

        private void boton4_Click(object sender, EventArgs e)
        {
            textBoxmostrar.Text = textBoxmostrar.Text + "4";
        }

        private void boton5_Click(object sender, EventArgs e)
        {
            textBoxmostrar.Text = textBoxmostrar.Text + "5";
        }

        private void boton6_Click(object sender, EventArgs e)
        {
            textBoxmostrar.Text = textBoxmostrar.Text + "6";
        }

        private void boton8_Click(object sender, EventArgs e)
        {
            textBoxmostrar.Text = textBoxmostrar.Text + "8";
        }

        private void boton9_Click(object sender, EventArgs e)
        {
            textBoxmostrar.Text = textBoxmostrar.Text + "9";
        }

        private void boton0_Click(object sender, EventArgs e)
        {
            textBoxmostrar.Text = textBoxmostrar.Text + "0";
        }
        //Aqui puse una coma y no un punto porque con el punto no funcionaba bien el ejercicio
        //y mirando la calculadora de windows 8.1 que esta contiene una coma y eso puse y funciono :u
        private void boton_punto_Click(object sender, EventArgs e)
        {
            textBoxmostrar.Text = textBoxmostrar.Text + ",";
            
        }

        private void boton_multi_Click(object sender, EventArgs e)
        {
            operador = "*";
            primernum = double.Parse(textBoxmostrar.Text);
            textBoxmostrar.Clear();
        }

        private void boton_resta_Click(object sender, EventArgs e)
        {
            operador = "-";
            primernum = double.Parse(textBoxmostrar.Text);
            textBoxmostrar.Clear();
        }

        private void boton_dividir_Click(object sender, EventArgs e)
        {
            operador = "/";
            primernum = double.Parse(textBoxmostrar.Text);
            textBoxmostrar.Clear();
        }

        private void boton_resultado_Click(object sender, EventArgs e)
        {
            segundonum = double.Parse(textBoxmostrar.Text);

            double Sumar;
            double Restar;
            double Multiplicar;
            double Dividir;

            switch (operador)
            {
                case "+":
                    Sumar = Suma.MetodoSumar((primernum), (segundonum));
                    textBoxmostrar.Text = Sumar.ToString();
                    break;
                case "-":
                    Restar = Resta.MetodoRestar((primernum), (segundonum));
                    textBoxmostrar.Text = Restar.ToString();
                    break;
                case "*":
                    Multiplicar = Multiplica.MetodoMultiplicar((primernum), (segundonum));
                    textBoxmostrar.Text = Multiplicar.ToString();
                    break;
                case "/":
                    Dividir = Divide.MetodoDividir((primernum), (segundonum));
                    textBoxmostrar.Text = Dividir.ToString();
                    break;
                default:
                    break;
            }
        }

        private void boton_clean_Click(object sender, EventArgs e)
        {
            textBoxmostrar.Clear();
        }

        private void textBoxmostrar_TextChanged(object sender, EventArgs e)
        {

        }

        private void Calculadora_Load(object sender, EventArgs e)
        {

        }
    }
}
