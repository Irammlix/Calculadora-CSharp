using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraBasica
{
    public enum Operacion
    {
        NoDefinida = 0,
        Suma = 1,
        Resta = 2,
        Division = 3,
        Multiplicacion = 4,
        Modulo = 5
    }

    public partial class FormCalculadora : Form
    {
        private double valor1 = 0;
        private double valor2 = 0;
        private Operacion operador = Operacion.NoDefinida;
        private bool numeroLeido = false;
        private bool resultadoMostrado = false;

        public FormCalculadora()
        {
            InitializeComponent();
        }
        private void Reiniciar()
        {
            valor1 = 0;
            valor2 = 0;
            operador = Operacion.NoDefinida;
            numeroLeido = false;
            tbCajaResultado.Text = "0";
            lblHistorial.Text = "";
            resultadoMostrado = false;
        }
        private void LimpiarEstadoResultado()
        {
            resultadoMostrado = false;
            numeroLeido = false;
        }

        // METODO DE ENTRADA
        private void EscribirNumero(string numero)
        {
            if (resultadoMostrado)
            {
                tbCajaResultado.Text = numero;
                lblHistorial.Text = "";
                LimpiarEstadoResultado();
                return;
            }

            if (tbCajaResultado.Text == "0")
            {
                tbCajaResultado.Text = numero;
            }
            else
            {
                tbCajaResultado.Text += numero;
            }

            numeroLeido = true;
        }

        // =====================================================
        // MÉTODOS DE OPERACIONES
        // =====================================================
        private string ObtenerSimboloOperador()
        {
            switch (operador)
            {
                case Operacion.Suma:
                    return "+";
                case Operacion.Resta:
                    return "-";
                case Operacion.Multiplicacion:
                    return "x";
                case Operacion.Division:
                    return "/";
                case Operacion.Modulo:
                    return "%";
                default:
                    return "";
            }
        }
        private double EjecutarOperacion()
        {
            double resultado = 0;

            switch (operador)
            {
                case Operacion.Suma:
                    resultado = valor1 + valor2;
                    break;

                case Operacion.Resta:
                    resultado = valor1 - valor2;
                    break;

                case Operacion.Multiplicacion:
                    resultado = valor1 * valor2;
                    break;

                case Operacion.Division:
                    if (valor2 == 0)
                    {
                        MessageBox.Show("Error: No se puede dividir entre 0.", "División por cero",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Reiniciar();
                        return 0;
                    }
                    resultado = valor1 / valor2;
                    break;

                case Operacion.Modulo:
                    if (valor2 == 0)
                    {
                        MessageBox.Show("Error: No se puede calcular módulo con 0.", "Módulo por cero",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Reiniciar();
                        return 0;
                    }
                    resultado = valor1 % valor2;
                    break;
            }

            return resultado;
        }

        private void ObtenerValor(Operacion op)
        {
            if (resultadoMostrado)
            {
                valor1 = Convert.ToDouble(tbCajaResultado.Text);
                operador = op;
                string simbolo = ObtenerSimboloOperador();
                lblHistorial.Text = valor1 + "  " + simbolo + "  ";
                tbCajaResultado.Text = "0";
                LimpiarEstadoResultado();
                return;
            }
            if (!numeroLeido && operador != Operacion.NoDefinida)
            {
                operador = op;
                string simbolo = ObtenerSimboloOperador();
                lblHistorial.Text = valor1 + "  " + simbolo + "  ";
                return;
            }

            valor1 = Convert.ToDouble(tbCajaResultado.Text);
            operador = op;
            string simb = ObtenerSimboloOperador();
            lblHistorial.Text = valor1 + "  " + simb + "  ";
            tbCajaResultado.Text = "0";
            numeroLeido = false;
        }
        private void btnN0_Click(object sender, EventArgs e)
        {
            if (resultadoMostrado)
            {
                tbCajaResultado.Text = "0";
                lblHistorial.Text = "";
                LimpiarEstadoResultado();
                return;
            }

            if (tbCajaResultado.Text != "0")
            {
                tbCajaResultado.Text += "0";
                numeroLeido = true;
            }
        }

        // =====================================================
        // EVENTOS DE NÚMEROS
        // =====================================================
        private void btnN1_Click(object sender, EventArgs e)
        {
            EscribirNumero("1");
        }

        private void btnN2_Click(object sender, EventArgs e)
        {
            EscribirNumero("2");
        }

        private void btnN3_Click(object sender, EventArgs e)
        {
            EscribirNumero("3");
        }

        private void btnN4_Click(object sender, EventArgs e)
        {
            EscribirNumero("4");
        }

        private void btnN5_Click(object sender, EventArgs e)
        {
            EscribirNumero("5");
        }

        private void btnN6_Click(object sender, EventArgs e)
        {
            EscribirNumero("6");
        }

        private void btnN7_Click(object sender, EventArgs e)
        {
            EscribirNumero("7");
        }

        private void btnN8_Click(object sender, EventArgs e)
        {
            EscribirNumero("8");
        }

        private void btnN9_Click(object sender, EventArgs e)
        {
            EscribirNumero("9");
        }

        // =====================================================
        // EVENTOS DE OPERACIONES
        // =====================================================
        private void btnSumar_Click(object sender, EventArgs e)
        {
            ObtenerValor(Operacion.Suma);
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            ObtenerValor(Operacion.Resta);
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            ObtenerValor(Operacion.Multiplicacion);
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            ObtenerValor(Operacion.Division);
        }

        private void btnModulo_Click(object sender, EventArgs e)
        {
            ObtenerValor(Operacion.Modulo);
        }

        //Importantes
        private void btnPunto_Click(object sender, EventArgs e)
        {
            if (resultadoMostrado)
            {
                tbCajaResultado.Text = "0.";
                LimpiarEstadoResultado();
                numeroLeido = true;
                return;
            }

            if (!tbCajaResultado.Text.Contains("."))
            {
                tbCajaResultado.Text += ".";
                numeroLeido = true;
            }
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            if (operador == Operacion.NoDefinida)
            {
                return;
            }

            if (numeroLeido)
            {
                valor2 = Convert.ToDouble(tbCajaResultado.Text);
                lblHistorial.Text += valor2 + " =";
                double resultado = EjecutarOperacion();
                valor1 = resultado;
                tbCajaResultado.Text = resultado.ToString();
                numeroLeido = false;
                resultadoMostrado = true;
            }

            else
            {
                string simbolo = ObtenerSimboloOperador();
                lblHistorial.Text = valor1.ToString() + " " + simbolo + " " + valor2.ToString() + " =";
                double resultado = EjecutarOperacion();
                valor1 = resultado;
                tbCajaResultado.Text = resultado.ToString();
                resultadoMostrado = true;
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            Reiniciar();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (resultadoMostrado)
            {
                lblHistorial.Text = "";
                return;
            }

            if (tbCajaResultado.Text.Length > 1)
            {
                string textoActual = tbCajaResultado.Text;
                string textoNuevo = textoActual.Substring(0, textoActual.Length - 1);

                if (textoNuevo == "-")
                {
                    tbCajaResultado.Text = "0";
                }
                else
                {
                    tbCajaResultado.Text = textoNuevo;
                }
            }
            else
            {
                tbCajaResultado.Text = "0";
            }
        }
    }
}
