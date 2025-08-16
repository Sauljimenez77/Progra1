using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miPrimerPryectoCsharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

       

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            Double num1, num2, respuesta;
            num1 = Double.Parse(txtnum1.Text);

            num2 = double.Parse(txtnum2.Text);

            respuesta = num1 + num2;

            lblrespuesta.Text = "Respuesta:" + respuesta;
        }

        private void btncantidad_Click(object sender, EventArgs e)
        {
            double num1, num2, respuesta = 0;
            num1 = Double.Parse(txtnum1.Text);
            num2 = Double.Parse(txtnum2.Text);
            if (optSuma.Checked)
            {
                respuesta = num1 + num2;
            }

            if (optResta.Checked)
            {
                respuesta = num1 - num2;
            }

            if (optMultiplicacion.Checked)
            {
                respuesta = num1 * num2;
            }

            if (optDivision.Checked)
            {
                respuesta = num1 / num2;
            }

            if (optExponente.Checked)
            {
                respuesta = Math.Pow(num1, num2);
            }


            if (optPorcentaje.Checked)
            {
                respuesta = num1 % num2;
            }
            if (optFactorial.Checked) {
                int factorial = (int)num1;
                for (int i = (int)num1 - 1; i>1; i--) {
                    factorial *= i;
                }
                respuesta = factorial;    
            }
            lblrespuesta.Text = "Respuesta: " + respuesta;
            if (optPrimo.Checked) {
                int i = 1, acum = 0;
                while (i <= num1 && acum < 3) {
                    if (num1 % i == 0) {
                        acum++; //acum = acum + 1;
                    }
                    i++;
                }
                if (acum <= 2) {
                    lblrespuesta.Text = "Respuesta:" + num1 + " Es primo";
                } else {
                    lblrespuesta.Text = "Respuesta:"+ num1 + " No es primo";
                }         
            
            
            
            }



            
            //Porcentaje
            //Factorial. 5! = 5x4x3x3x1=120
            //Modulo

            

        }

        private void btnCalcularopciones_Click(object sender, EventArgs e)
        {
            double num1, num2, respuesta = 0;
            num1 = double.Parse(txtnum1.Text);
            num2 = double.Parse(txtnum2.Text);
            switch (cboOpciones.SelectedIndex)
            {
                case 0:
                    respuesta = num1 + num2;
                    break;
                case 1:
                    respuesta = num1 - num2;
                    break;
                case 2:
                    respuesta = num1 * num2;
                    break;
                case 3:
                    respuesta = Math.Pow(num1, num2);
                    break;

                case 4:
                    respuesta = num1 % num2;
                    break;
                 
            }
            lblrespuesta.Text = "Respuesta: " + respuesta;
        }
    }
}
