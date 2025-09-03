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
        // Matriz para almacenar los datos de impuestos
        private readonly object[,] tablaImpuestos = new object[,]
        {
            {1, 0.01, 500.00, 1.5, 0},
            {2, 500.01, 1000.00, 1.5, 3},
            {3, 1000.01, 2000.00, 3.0, 3},
            {4, 2000.01, 3000.00, 6.0, 3},
            {5, 3000.01, 6000.00, 9.0, 2},
            {6, 6000.01, 8000.00, 12.0, 2},
            {7, 8000.01, 18000.00, 15.0, 2},
            {8, 18000.01, 30000.00, 39.0, 2},
            {9, 30000.01, 60000.00, 63.0, 1},
            {10, 60000.01, 100000.00, 93.0, 0.8},
            {11, 100000.01, 200000.00, 125.0, 0.7},
            {12, 200000.01, 300000.00, 195.0, 0.6},
            {13, 300000.01, 400000.00, 255.0, 0.45},
            {14, 400000.01, 500000.00, 300.0, 0.4},
            {15, 500000.01, 1000000.00, 340.0, 0.3},
            {16, 1000000.01, 99999999.00, 490.0, 0.18}
        };

        // Matriz para factores de conversión
        private readonly double[,] factoresConversion = new double[,]
        {// Pie2,    Vara2,    Yarda2,   Metro2,   Tarea,    Manzana,  Hectarea  
    {1,0.1309, 0.1111, 0.0929,0.000212, 0.0000133, 0.00000929},    // Desde Pie Cuadrado
    {7.64, 1, 0.85, 0.71, 0.00162,  0.000101,  0.000071},      // Desde Vara Cuadrada
    {9, 1.176, 1, 0.8361, 0.00191,  0.000119,  0.00008361},    // Desde Yarda Cuadrada
    {10.76, 1.408,  1.196, 1,  0.002286, 0.000143,  0.0001},   // Desde Metro Cuadrado
    {4704, 615.38,  523.81,  437.5, 1, 0.0625, 0.04375},       // Desde Tarea
    {75264, 9846.15,  8403.36,  6988,  16, 1, 0.6988},        // Desde Manzana
    {107639, 14084.51, 11959.9, 10000, 22.857,  1.431,     1} // Desde Hectárea
};
        public Form1()
        {
            InitializeComponent();
            InicializarComponentes();
        }

        private void InicializarComponentes()
        {

            cmbUnidadOrigen.Items.AddRange(new string[] { "Pie Cuadrado", "Vara Cuadrada", "Yarda Cuadrada", "Metro Cuadrado", "Tarea", "Manzana", "Hectárea" });
            cmbUnidadDestino.Items.AddRange(new string[] { "Pie Cuadrado", "Vara Cuadrada", "Yarda Cuadrada", "Metro Cuadrado", "Tarea", "Manzana", "Hectárea" });

            cmbUnidadOrigen.SelectedIndex = 0;
            cmbUnidadDestino.SelectedIndex = 3;
        }


        private double CalcularImpuesto(double monto)
        {
            for (int i = 0; i < tablaImpuestos.GetLength(0); i++)
            {
                double desde = Convert.ToDouble(tablaImpuestos[i, 1]);
                double hasta = Convert.ToDouble(tablaImpuestos[i, 2]);
                double precio = Convert.ToDouble(tablaImpuestos[i, 3]);
                double adicional = Convert.ToDouble(tablaImpuestos[i, 4]);

                if (monto >= desde && monto <= hasta)
                {
                    double excedente = monto - desde;
                    double montoAdicional = (excedente / 1000) * adicional;
                    return precio + montoAdicional;
                }
            }
            return 0;
        }

        // Función para convertir áreas
        private double ConvertirArea(double valor, int unidadOrigen, int unidadDestino)
        {
            if (unidadOrigen >= 0 && unidadOrigen < 7 && unidadDestino >= 0 && unidadDestino < 7)
            {
                return valor * factoresConversion[unidadOrigen, unidadDestino];
            }
            return 0;
        }

        private void btnCalcularImpuesto_Click(object sender, EventArgs e)
        {
            try
            {
                double monto = double.Parse(txtMontoActividad.Text);
                double impuesto = CalcularImpuesto(monto);
                lblResultadoImpuesto.Text = $"Impuesto a pagar: ${impuesto:F2}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Por favor ingrese un monto válido: " + ex.Message);
            }
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            try
            {
                double valor = double.Parse(txtValorConvertir.Text);
                int origen = cmbUnidadOrigen.SelectedIndex;
                int destino = cmbUnidadDestino.SelectedIndex;

                double resultado = ConvertirArea(valor, origen, destino);
                lblResultadoConversion.Text = $"{valor} {cmbUnidadOrigen.Text} = {resultado:F4} {cmbUnidadDestino.Text}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Por favor ingrese un valor válido: " + ex.Message);
            }
        }
    }
}