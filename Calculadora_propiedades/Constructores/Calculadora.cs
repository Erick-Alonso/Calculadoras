using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_propiedades
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        int cont = 0;
        double can1, can2;
        string op, resu;

        public void lim()
        {
            TxtCantidad.Clear();
            TxtCantidad.Focus();
        }

        public void asgintxt(string num)
        {
            if (cont != 0)
            {
                txthistorial.Text = "";
            }
            TxtCantidad.Text+= num; cont = 0;
        }
        void asigop(string op)
        {
            cont = 0;

            if (TxtCantidad.Text.Length >= 1)
            {
                can1 = double.Parse(TxtCantidad.Text);
                this.op = op;

                if (can1 == 0 && op == "√")
                {
                    MessageBox.Show("Favor de ingresar un valor valido"); cont++;
                }

                if (cont == 0)
                {
                    if (op == "√")
                    {
                        txthistorial.Text = "√" + TxtCantidad.Text + " ";
                    }
                    else
                    {
                        txthistorial.Text = TxtCantidad.Text + " " + op + " ";
                    }
                }

                lim();
            }
            else
            {
                lim();
            }
        }
        private void BtnIgual_Click(object sender, EventArgs e)
        {
            cont++;
            resu = TxtCantidad.Text;

            if (TxtCantidad.Text.Length >= 1)
            {
               can2 = double.Parse(TxtCantidad.Text);

                if (cont == 1)
                {
                    txthistorial.Text += can2.ToString() + " =";
                }
            }
            else
            {
                lim();
            }

            switch (op)
            {
                case "+":
                    Class_op op = new Class_op(); op.can11 = can1; op.can22 = can2;
                    resu = op.suma().ToString();
                    break;

                case "-":
                    Class_resta re = new Class_resta(); re.can11 = can1; re.can22 = can2;
                    resu = re.resta().ToString();
                    break;

                case "*":
                    Class_multiplicar mu = new Class_multiplicar(); mu.can11 = can1; mu.can22 = can2;
                    resu = mu.multiplicar().ToString();
                    break;

                case "/":
                    Class_dividir di = new Class_dividir(); di.can11 = can1; di.can22 = can2;
                    resu = di.dividir().ToString();
                    break;

                case "√":
                    Class_raiz ra = new Class_raiz(); ra.can11 = can1; ra.can22 = can2;
                    resu = ra.raiz().ToString();
                    break;

                default: break;
            }
            op = "";  TxtCantidad.Text = resu;
        }

        private void Btnlimpiar_Click(object sender, EventArgs e)
        {
            lim(); txthistorial.Text="";
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            if (TxtCantidad.Text.Length >= 1)
            {
                TxtCantidad.Text = TxtCantidad.Text.Substring(0, TxtCantidad.Text.Length - 1);
            }
            else
            {
                lim();
            }
        }


        private void BtnMas_Click(object sender, EventArgs e)
        {
            asigop("+");
        }

        private void Btnmenos_Click(object sender, EventArgs e)
        {
            asigop("-");
        }
        private void BtnMultiplicar_Click(object sender, EventArgs e)
        {
            asigop("*");
        }

        private void BtnDividir_Click(object sender, EventArgs e)
        {
            asigop("/");
        }

        private void BtnRaiz_Click(object sender, EventArgs e)
        {
            asigop("√");
        }


        private void Btn1_Click(object sender, EventArgs e)
        {
            asgintxt("1");
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            asgintxt("2");
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            asgintxt("3");
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            asgintxt("4");
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            asgintxt("5");
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            asgintxt("6");
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            asgintxt("7");
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            asgintxt("8");
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            asgintxt("9");
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            asgintxt("0");
        }

        private void BtmDecimal_Click(object sender, EventArgs e)
        {
            if (TxtCantidad.Text.Length >= 1)
            {
                asgintxt(".");
            }
            else
            {
                lim();
            }
        }
    }
}
