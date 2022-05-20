using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        int valor;
        double num1;
        double num2;
        double resultado;
        string operacion;

        public Form1()
        {
            InitializeComponent();
            valor = 0;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            valor = valor * 10 + Convert.ToInt32(((Button)sender).Text);
            Pantalla.Text = valor.ToString();
        }

        private void btnsuma_Click(object sender, EventArgs e)
        {
            operacion = "+";
            valor = 0;
            num1 = double.Parse(Pantalla.Text);
            Pantalla.Clear();
        }

        private void btnresta_Click(object sender, EventArgs e)
        {
            operacion = "-";
            valor = 0;
            num1 = double.Parse(Pantalla.Text);
            Pantalla.Clear();
        }

        private void btnmultiplicacion_Click(object sender, EventArgs e)
        {
            operacion = "*";
            valor = 0;
            num1 = double.Parse(Pantalla.Text);
            Pantalla.Clear();
        }

        private void btndivision_Click(object sender, EventArgs e)
        {
            operacion = "/";
            valor = 0;
            num1 = double.Parse(Pantalla.Text);
            Pantalla.Clear();
        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            num2 = double.Parse(Pantalla.Text);
            switch (operacion)
            {
                case "+":
                    resultado = num1 + num2;
                    Pantalla.Text = resultado.ToString();
                    valor = 0;
                    break;
                case "-":
                    resultado = num1 - num2;
                    Pantalla.Text = resultado.ToString();
                    valor = 0;
                    break;
                case "*":
                    resultado = num1 * num2;
                    Pantalla.Text = resultado.ToString();
                    valor = 0;
                    break;
                case "/":
                    resultado = num1 / num2;
                    Pantalla.Text = resultado.ToString();
                    valor = 0;
                    break;
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            valor = 0;
            Pantalla.Clear();
        }
    }
}
