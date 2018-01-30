using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioPDF1
{
    public partial class Form1 : Form
    {
        Int32 i, j, aux;//prieba de comentario GitHub
        //variables i y j se inicializan en los for por lo tanto aqui no le damos valor
        //creamos la variable i para mover el array y coger la primera pos
        //la variable j la usaremos apra mover el array e ir comparando la pos del array[i] con las pos del array[j]
        //aux sera una variable auxiliar donde guardaremos un valor del array para luego guardarlo en la siguiente pos correspondiente
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Int32[] array = { 12, 18, 6, 42, 44, 52, 67, 94 };//creamos un array con los valores dados
            printArray(lb_array, array);//llamaos a una funcion para imprimir el array

            Classificacio(array);
            printArray(lb_res, array);
        }
        private void Classificacio(Int32[] array)
        {
            for (i = 0; i < array.Length; i++)
            {
                for (j = i; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        aux = array[i];
                        array[i] = array[j];
                        array[j] = aux;
                    }
                }
            }
        }
        public void printArray(Label lb, Int32[] array)
        {
            for (i = 0; i < array.Length; i++)
            {
                lb.Text += array[i].ToString() + "  ";
            }
        }
    }
}
