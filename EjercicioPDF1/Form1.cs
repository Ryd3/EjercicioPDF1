﻿using System;
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
        Int32 i, j, numAux;//prieba de comentario GitHuba
        //variables i y j se inicializan en los for por lo tanto aqui no le damos valor
        //creamos la variable i para mover el array y coger la primera pos
        //la variable j la usaremos apra mover el array e ir comparando la pos del array[i] con las pos del array[j]
        //numAux sera una variable numAuxiliar donde guardaremos un valor del array para luego guardarlo en la siguiente pos correspondiente
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Clock inici= currentTime();
            //Int32[] array = { 12, 18, 6, 42, 44, 52, 67, 94 };//creamos un array con los valores dados
            Int32[] array = { 12, 18, 6, 42, 44 };//array con 5 valores
            //Int32[] array = { 12, 18, 6, 42, 44, 52, 67, 94, 1, 2, 3 };//array con 10 valores
            //Int32[] array = { 12, 18, 6, 42, 44, 52, 67, 94, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 543, 23, 54, 66, 12, 69, 7, 89, 23, 12 };//array con 20 valores
            printArray(lb_array, array);//llamaos a una funcion para imprimir el array

            Ordenacion(array);//llamamos al metodo que va a ordenar el array
            printArray(lb_res, array);
        }
        private void Ordenacion(Int32[] array)
        {
            for (i = 0; i < array.Length; i++)
            {
                for (j = i; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        numAux = array[i];
                        array[i] = array[j];
                        array[j] = numAux;
                    }
                }
            }
        }
        public void printArray(Label lb, Int32[] array)//en esta funcion con un for imprimimos todas las pos disponibles del array convirtiendoas a string
        {
            for (i = 0; i < array.Length; i++)
            {
                lb.Text += array[i].ToString() + "  ";
            }
        }
    }
}
