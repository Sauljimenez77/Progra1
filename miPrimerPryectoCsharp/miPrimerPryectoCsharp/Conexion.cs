using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace miPrimerPryectoCsharp
{
    internal class Conexion
    {
        SqlConnection objConexion = new SqlConnection();
        SqlCommand objComando = new SqlCommand(); //Ejecutar SQL en la BD. Lectura, Actualizacion, Eliminacion, Insercion.
        SqlDataAdapter objAdaptador = new SqlDataAdapter(); //un puente entre la BD y la aplicacion.
        DataSet objDs = new DataSet(); //Es una representacion de la arquitectura de la BD en memoria.

        public Conexion()
        { //Constructor. inicializador de los atributos
            String cadenaConexion = "";
            objConexion.ConnectionString = cadenaConexion;
            objConexion.Open(); //Abrir la conexion a la BD
        }
        public DataSet obtenerDatos()
        {
            objDs.Clear(); //Limpiar el DataSet
            objComando.Connection = objConexion; //Establecer la conexion para ejecutar los comandos.

            objAdaptador.SelectCommand = objComando; //Establecer el comando de seleccion

            objComando.CommandText = "SELECT * FROM alumnos";
            objAdaptador.Fill(objDs, "alumnos");//Tomando los datos de la BD y llenando el DataSet

            return objDs;
        }
    }
}
