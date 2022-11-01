using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraFR
{
    public partial class Calculadora : Form
    {
        double primero;
        double segundo;
        string operador;
        public Calculadora()
        {
            InitializeComponent();
        }

        CLASES.ClsSuma obj = new CLASES.ClsSuma();
        CLASES.ClsResta obj2 = new CLASES.ClsResta();
        CLASES.Clsmultiplicacion obj3 = new CLASES.Clsmultiplicacion();
        CLASES.ClsDivicion obj4 = new CLASES.ClsDivicion();
        private void botonN0_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "0";
        }

        private void botonN1_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "1";
        }

        private void botonN2_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "2";
        }

        private void botonN3_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "3";
        }

        private void botonN4_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "4";
        }

        private void botonN5_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "5";
        }

        private void botonN6_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "6";
        }

        private void botonN7_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "7";
        }

        private void botonN8_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "8";
        }

        private void botonN9_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "9";
        }

        private void botonpunto_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + ".";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void botonsuma_Click(object sender, EventArgs e)
        {
            operador = "+";
            primero = double.Parse(tbxScreen.Text);
            tbxScreen.Clear();
        }

        private void botonrestar_Click(object sender, EventArgs e)
        {
            operador = "-";
            primero = double.Parse(tbxScreen.Text);
            tbxScreen.Clear();
        }

        private void botonmultiplicacion_Click(object sender, EventArgs e)
        {
            operador = "*";
            primero = double.Parse(tbxScreen.Text);
            tbxScreen.Clear();
        }

        private void botondividir_Click(object sender, EventArgs e)
        {
            operador = "/";
            primero = double.Parse(tbxScreen.Text);
            tbxScreen.Clear();
        }

        private void botonigual_Click(object sender, EventArgs e)
        {

        }
    }
}
