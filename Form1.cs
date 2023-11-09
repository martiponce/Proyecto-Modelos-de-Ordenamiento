using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Proyecto_Modelos_de_Ordenamiento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int BubbleIteraciones = 0;
        private int MergeIteraciones = 0;
        private int QuickIteraciones = 0;

        private void btnOrdenar_Click_1(object sender, EventArgs e)
        {
            int opcion = 0;

            if (optBubbleSort.Checked)
            {
                opcion = 1;
            }
            else if (optMergeSort.Checked)
            {
                opcion = 2;
            }
            else if (optQuickSort.Checked)
            {
                opcion = 3;
            }

            switch (opcion)
            {
                case 1: // Bubble
                    {

                        if (int.TryParse(txtLimiteVector.Text, out int limit))
                        {
                            BubbleIteraciones = 0;
                            txtIntercambios.Clear();
                            txtTiempo.Clear();

                            BubbleSort(limit);

                            dgvDatos.Rows.Add("BubbleSort", txtLimiteVector.Text, txtTiempo.Text, txtIntercambios.Text);
                        }
                        else
                        {
                            MessageBox.Show("Ingrese un límite válido.");
                        }

                    }
                    break;
                case 2: // Merge
                    {
                        if (int.TryParse(txtLimiteVector.Text, out int limit))
                        {
                            txtIntercambios.Clear();
                            txtTiempo.Clear();
                            MergeIteraciones = 0;

                            int[] numbers = new int[limit];

                            for (int i = 0; i < limit; i++)
                            {
                                numbers[i] = i + 1;
                            }

                            MezclarArray(numbers);

                            Stopwatch tiempo = new Stopwatch();
                            tiempo.Start();

                            MergeSort(numbers, 0, limit - 1);

                            tiempo.Stop();

                            txtIntercambios.Text = MergeIteraciones.ToString();
                            txtTiempo.Text = tiempo.ElapsedMilliseconds + " ms";

                            dgvDatos.Rows.Add("MergeSort", txtLimiteVector.Text, txtTiempo.Text, txtIntercambios.Text);
                        }
                        else
                        {
                            MessageBox.Show("Ingrese un límite válido.");
                        }

                    }
                    break;
                case 3: // Quick
                    {
                        if (int.TryParse(txtLimiteVector.Text, out int limit))
                        {
                            txtIntercambios.Clear();
                            txtTiempo.Clear();
                            QuickIteraciones = 0;

                            int[] numbers = new int[limit];

                            for (int i = 0; i < limit; i++)
                            {
                                numbers[i] = i + 1;
                            }

                            MezclarArray(numbers);

                            Stopwatch tiempo = new Stopwatch();
                            tiempo.Start();

                            QuickSort(numbers, 0, limit - 1);

                            tiempo.Stop();

                            txtIntercambios.Text = QuickIteraciones.ToString();
                            txtTiempo.Text = tiempo.ElapsedMilliseconds + " ms";

                            dgvDatos.Rows.Add("QuickSort", txtLimiteVector.Text, txtTiempo.Text, txtIntercambios.Text);
                        }
                        else
                        {
                            MessageBox.Show("Ingrese un límite válido.");
                        }
                    }
                    break;
                default:
                    {
                        MessageBox.Show("Selecciona una opción");
                    }
                    break;

            }
        }

        // === Mezclar vector === \\
        private void MezclarArray(int[] arr)
        {
            Random random = new Random();

            for (int i = arr.Length - 1; i > 0; i--)
            {
                int j = random.Next(0, i + 1);
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }

        // === BubbleSort === \\
        private void BubbleSort(int limit)
        {
            int[] vec = new int[limit];

            // Llenar el vector con números del 1 al límite
            for (int i = 0; i < limit; i++)
            {
                vec[i] = i + 1;
            }

            // Mezclar el vector
            MezclarArray(vec);

            Stopwatch tiempo = new Stopwatch();
            tiempo.Start();

            // Algoritmo de ordenamiento de burbuja
            bool cambiado;
            do
            {
                cambiado = false;
                for (int i = 0; i < limit - 1; i++)
                {
                    if (vec[i] > vec[i + 1])
                    {
                        // Intercambiar los elementos
                        int temp = vec[i];
                        vec[i] = vec[i + 1];
                        vec[i + 1] = temp;
                        cambiado = true;
                    }
                    BubbleIteraciones++;
                }
            } while (cambiado);

            tiempo.Stop();

            txtIntercambios.Text = BubbleIteraciones.ToString();
            txtTiempo.Text = tiempo.ElapsedMilliseconds + " ms";
        }

        // === QuickSort === \\
        private void QuickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pivotIndex = ParticionQuick(arr, low, high);

                QuickSort(arr, low, pivotIndex - 1);
                QuickSort(arr, pivotIndex + 1, high);

                QuickIteraciones++;
            }
        }

        // === Partición del vector === \\
        private int ParticionQuick(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            int swapTemp = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = swapTemp;

            return i + 1;
        }

        // === MergeSort === \\
        private void MergeSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;
                MergeSort(arr, left, middle);
                MergeSort(arr, middle + 1, right);
                Fusion(arr, left, middle, right);
                MergeIteraciones++;
            }
        }

        // === Fusioón de los sub-vectores === \\
        private void Fusion(int[] arr, int left, int middle, int right)
        {
            int n1 = middle - left + 1;
            int n2 = right - middle;

            
            int[] L = new int[n1];
            int[] R = new int[n2];

            
            for (int x = 0; x < n1; x++)
            {
                L[x] = arr[left + x];
            }
            for (int z = 0; z < n2; z++)
            {
                R[z] = arr[middle + 1 + z];
            }

            
            int k = left;
            int i = 0, j = 0;

            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }
                k++;
            }

            
            while (i < n1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }

            
            while (j < n2)
            {
                arr[k] = R[j];
                j++;
                k++;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            //vectores con los datos
            string[] series = { "BubbleSort", "MergeSort", "QuickSort" };
            int[] puntos = { BubbleIteraciones,MergeIteraciones,QuickIteraciones};

            chartDatos.Titles.Add("Métodos");

            for (int i = 0; i < series.Length; i++)
            {
                //titulos
                Series series1 = chartDatos.Series.Add(series[i]);  

                //cantidadeds 
                series1.Label = puntos[i].ToString();

                series1.Points.Add(puntos[i]);
            }
        }

        private void chartDatos_Click(object sender, EventArgs e)
        {

        }
    }
}