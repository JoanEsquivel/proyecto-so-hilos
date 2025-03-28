using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_so_hilos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /******************************************Atributos**********************************/

        public double[] Array_Number = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
        public string[] Array_Par;
        public string[] Array_Impar;
        public string[] Array_Tabla = new string[10];
        public double Numero;

        Thread Obj_T1; //Hilos pares
        Thread Obj_T2; //Hilos impares

        Cla_Utilidad Obj_Utilidad = new Cla_Utilidad();
        Mutex Obj_Mut = new Mutex();

        DataTable DT_Numeros = new DataTable();
        DataTable DT_Impares = new DataTable();
        DataTable DT_Tabla = new DataTable();
        DataTable DT_Pares = new DataTable();

        /******************************************Métodos/Funciones**********************************/

        void Pares()
        {
            int Indice_Par = 0;
            for (int i = 0; i < Array_Number.Length; i++)
            {
                Numero = Array_Number[i];
                txtNumeros.Invoke(new Action(() =>
                {
                    txtNumeros.Text = Numero.ToString();
                }));

                if (Es_Par(Numero))
                {
                    System.Console.WriteLine("Par Numero {0}", Numero);
                    txtTipo.Invoke(new Action(() =>
                    {
                        txtTipo.Text = "Par";
                    }));

                    Array_Par[Indice_Par] = Calcular_Potencia(Numero, 2);
                    CalcularTabla();
                    Indice_Par++;
                }

                txtHilo.Invoke(new Action(() =>
                {
                    txtHilo.Text = Obj_T1.ManagedThreadId.ToString();
                }));

                Thread.Sleep(1000);
            }

            Llenar_Data_Grid(Array_Par, DT_Pares, "POTENCIA", true, null);

            dgPares.Invoke(new Action(() =>
            {
                dgPares.DataSource = DT_Pares;
                dgPares.Refresh();
            }));

            Obj_Utilidad.Mensaje("Proceso Pares Terminado Con Éxito");
        }

        bool Es_Par(double PNumero)
        {
            return PNumero % 2 == 0;
        }

        void Impares()
        {
            int Indice_Impar = 0;
            // Lista de números para los que calculamos el factorial
            List<int> numerosParaFactorial = new List<int> { 1, 3, 5, 6, 8, 10, 12, 14, 16, 18 };

            for (int i = 0; i < Array_Number.Length; i++)
            {
                txtNumeros.Invoke(new Action(() =>
                {
                    txtNumeros.Text = Array_Number[i].ToString();
                }));

                if (numerosParaFactorial.Contains((int)Array_Number[i]))
                {
                    txtTipo.Invoke(new Action(() =>
                    {
                        txtTipo.Text = "Impar";
                    }));

                    Array_Impar[Indice_Impar] = Calcular_Factorial(Array_Number[i]);
                    Indice_Impar++;
                }

                txtHilo.Invoke(new Action(() =>
                {
                    txtHilo.Text = Obj_T2.ManagedThreadId.ToString();
                }));

                CalcularTabla();
                Thread.Sleep(1000);
            }

            // Llenar el DataGrid con los resultados de los factoriales
            Llenar_Data_Grid(Array_Impar, DT_Impares, "FACTORIAL", true, null);

            dgImpares.Invoke(new Action(() =>
            {
                dgImpares.DataSource = DT_Impares;
            }));

            Obj_Utilidad.Mensaje("Proceso Impares Terminado Con Éxito");
        }


        private string Calcular_Potencia(double PNumero, int PPotencia)
        {
            return string.Format("{0:000D2} ^ 2 = {1:000D3}", PNumero.ToString().PadLeft(2), Math.Pow(PNumero, PPotencia).ToString().PadLeft(3));
        }

        private string Calcular_Factorial(double PNumero)
        {
            // Lista de números para los que se debe calcular el factorial
            List<int> numerosParaFactorial = new List<int> { 1, 3, 5, 6, 8, 10, 12, 14, 16, 18 };

            // Convierte el número de tipo double a entero para la comparación
            int numeroEntero = (int)PNumero;

            // Verifica si el número es un número entero y si está en la lista
            if (PNumero != numeroEntero || !numerosParaFactorial.Contains(numeroEntero))
            {
                return string.Empty; // Si el número no es entero o no está en la lista, no devuelve nada.
            }

            // Calcula el factorial solo para los números permitidos
            long factorial = 1;
            for (int i = 1; i <= numeroEntero; i++)
            {
                factorial *= i;
            }

            // Devolver el formato correcto del resultado
            return string.Format("{0}! = {1:#,0}", numeroEntero, factorial);
        }






        private void Llenar_Data_Grid(string[] PArreglo, DataTable PData_Table, string Nom_Columna, bool Limpiar_Columna, double[] ANumber)
        {
            DataRow fila = null;
            DataColumn DCNumeros = new DataColumn(Nom_Columna);

            if (Limpiar_Columna)
                PData_Table.Columns.Clear();

            PData_Table.Columns.Add(DCNumeros);

            if (Limpiar_Columna)
                PData_Table.Rows.Clear();

            int? limite = PArreglo != null ? PArreglo.Length : ANumber.Length;

            for (int i = 0; i < limite; i++)
            {
                fila = PData_Table.NewRow();

                if (PArreglo != null)
                    fila[DCNumeros] = PArreglo[i];
                else
                    fila[DCNumeros] = ANumber[i];

                PData_Table.Rows.Add(fila);
            }
        }

        void CalcularTabla()
        {
            for (int i = 0; i < 10; i++)
            {
                Array_Tabla[i] = string.Format("{0,-2:00} * {1,-2:00} = {2,-3:000}", Numero, (i + 1), (Numero * (i + 1)));

                System.Console.WriteLine(string.Format("{0,2}", Numero) + " * " +
                                         string.Format("{0,2}", (i + 1)) + " = " +
                                         string.Format("{0,3}", (Numero * (i + 1))));
            }

            dgTablas.Invoke(new Action(() =>
            {
                Llenar_Data_Grid(Array_Tabla, DT_Tabla, "TABLA DEL 20", true, null);
                dgTablas.DataSource = DT_Tabla;
            }));
        }

        /******************************************Eventos**********************************/
        private void btnEjecutar_Click_1(object sender, EventArgs e)
        {
            Array_Par = new string[Array_Number.Length / 2];
            Array_Impar = new string[Array_Number.Length / 2];

            Llenar_Data_Grid(null, DT_Numeros, "NUMERO", true, Array_Number);
            dgNumeros.Invoke(new Action(() =>
            {
                dgNumeros.DataSource = DT_Numeros;
            }));

            Obj_T1 = new Thread(new ThreadStart(Pares));
            Obj_T2 = new Thread(new ThreadStart(Impares));

            if (!Obj_T1.IsAlive)
                Obj_T1.Start();
            else
            {
                Obj_Utilidad.Mensaje("El hilo pares ya se está ejecutando con el ID: " + Obj_T1.ManagedThreadId);
            }

            if (!Obj_T2.IsAlive)
                Obj_T2.Start();
            else
            {
                Obj_Utilidad.Mensaje("El hilo impares ya se está ejecutando con el ID: " + Obj_T2.ManagedThreadId);
            }

            txtHilo.Invoke(new Action(() =>
            {
                txtHilo.Text = Obj_T1.ThreadState.ToString() + Obj_T2.ThreadState.ToString();
            }));
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

