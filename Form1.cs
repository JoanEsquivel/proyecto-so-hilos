using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_so_hilos
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        // Variables para calcular potencia
        public double[] Array_Number = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
        public string[] Array_Par;
        Thread Obj_T1;
        DataTable DT_Pares = new DataTable();

        // Posibles variables a usar para el resto del trabajo basado en el video. En caso de no usarlas, por favor eliminarlas.
        public string[] Array_Impar;
        public string[] Array_Tabla = new string[10];
        public double Numero;
        Cla_Utilidad Obj_Utilidad = new Cla_Utilidad();
        Thread Obj_T2; 
        Mutex Obj_Mut = new Mutex();
        DataTable DT_Numeros = new DataTable();
        DataTable DT_Impares = new DataTable();
        DataTable DT_Tabla = new DataTable();

        // ----------------------------------------------------------------------------------------
        //Funciones para calcular pares
        void Pares()
        {
            // Instrucción:"DataGrid de Números Pares: Al finalizar la ejecución del Hilo, que procesa los números pares,
            // deberá desplegar la lista de la elevación al cuadrado, de los números pares, de la lista indicada.
            int Indice_Par = 0;
            // Itera sobre el array
            for (int i = 0; i < Array_Number.Length; i++)
            {
                Numero = Array_Number[i];

                //Confirma si el número es par
                if (Es_Par(Numero))
                {
                    // Se calcula la potencia
                    Array_Par[Indice_Par] = Calcular_Potencia(Numero, 2);
                    Indice_Par++;
                }
            }

            // Se invoca al datagrid y se le asigna una acción para llenarlo con los parametros adecuados
            Dgv_Pares.Invoke(new Action(() =>
            {
                Llenar_Data_Grid(Array_Par, DT_Pares, "colPotencia", true, null);
                Dgv_Pares.DataSource = DT_Pares;
                Dgv_Pares.Refresh();
            }));

            // Se muestra un cuadro de dialogo confirmando que el proceso termino con éxito.
            Obj_Utilidad.Mensaje("Proceso Pares Terminado Con Éxito");
        }
        bool Es_Par(double PNumero)
        {
            return PNumero % 2 == 0;
        }
        private string Calcular_Potencia(double PNumero, int PPotencia)
        {
            return string.Format("{0} ^ 2 = {1}",
                         PNumero,
                         Math.Pow(PNumero, PPotencia));
        }

        // ----------------------------------------------------------------------------------------
        // Función genérica que llena los data grids
        private void Llenar_Data_Grid(string[] PArreglo, DataTable PData_Table, string Nom_Columna, bool Limpiar_Columna, double[] PArreglo_Num)
        {
            DataColumn DC_Numeros = new DataColumn(Nom_Columna);
            if (Limpiar_Columna) PData_Table.Columns.Clear();
            PData_Table.Columns.Add(DC_Numeros);
            if (Limpiar_Columna) PData_Table.Rows.Clear();

            for (int i = 0; i < PArreglo.Length; i++)
            {
                DataRow Fila = PData_Table.NewRow();
                Fila[DC_Numeros] = PArreglo[i];
                PData_Table.Rows.Add(Fila);
            }
        }

        // ----------------------------------------------------------------------------------
        // Función que ejecuta el llenado de los data grids con el botón ejecutar en el UI
        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            //Se instancia la variable que contendrá los numeros pares
            Array_Par = new string[Array_Number.Length / 2];

            //Se crea un nuevo hilo para procesar los números pares
            Obj_T1 = new Thread(new ThreadStart(Pares));
            if (!Obj_T1.IsAlive) Obj_T1.Start();
        }
    }
}
