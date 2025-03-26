using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIA1_24_marzo_10_JeffersonGranados
{
    public partial class form4 : Form
    {
        private int[] vector1;
        private int[] vector2;
        public form4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            vector1 = new int[3];
            for (int i = 0; i < 3; i++)
            {
                vector1[i] = Convert.ToInt32(Interaction.InputBox("Digite un valor"));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form5 form = new form5();
            form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            vector2 = new int[3];
            for (int i = 0; i < 3; i++)
            {
                vector2[i] = Convert.ToInt32(Interaction.InputBox("Digite un valor"));
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i=0; i <3; i++)
            {
                int suma = vector1[i] + vector2[i];
                dataGridView1.Rows.Add(vector1[i], vector2[i], suma);
            }
        }
    }
}
