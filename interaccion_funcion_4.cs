using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace desarrollo_actual
{
    public partial class interaccion_funcion_4 : Form
    {
        public interaccion_funcion_4()
        {
            InitializeComponent();
        }


        private void dgvsopa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int tamaño = 10; // tamaño de la sopa
            dataGridView1.ColumnCount = tamaño;
            dataGridView1.RowCount = tamaño;

            for (int i = 0; i < tamaño; i++)
            {
                dataGridView1.Columns[i].Width = 30;
                dataGridView1.Rows[i].Height = 30;
            }

            // Rellenar con letras aleatorias
            Random rnd = new Random();
            for (int fila = 0; fila < tamaño; fila++)
            {
                for (int col = 0; col < tamaño; col++)
                {
                    char letra = (char)rnd.Next('A', 'Z' + 1);
                    dataGridView1[col, fila].Value = letra;
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void interaccion_funcion_4_Load(object sender, EventArgs e)
        {

        }
    }
}
