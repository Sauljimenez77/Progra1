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
    public partial class alumnos : Form
    {
        

        public alumnos()
        {
            InitializeComponent();
        }
        Conexion objconexion = new Conexion();
        DataSet objDs = new DataSet();
        DataTable objDt = new DataTable();

        public int posicion = 0;
        public string accion = "nuevo";

        private void alumnos_Load_1(object sender, EventArgs e)
        {

        }
    }
}