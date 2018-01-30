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
        Int32 i, j, aux;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Int32[] array = { 12, 18, 6, 42, 44, 52, 67, 94 };
            printArray(lb_array, array);

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
