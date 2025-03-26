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
    public partial class form5 : Form
    {
        private int[,] matriz1;
        private int[,] matriz2;
        public form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            matriz1 = new int[3, 4];
            for (int f = 0; f < 3; f++)
            {
                for (int c = 0; c < 4; c++)
                {
                    matriz1[f, c] = Convert.ToInt32(Interaction.InputBox("Digite un numero:"));
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            matriz2 = new int[3, 4];
            for (int f = 0; f < 3; f++)
            {
                for (int c = 0; c < 4; c++)
                {
                    matriz2[f, c] = Convert.ToInt32(Interaction.InputBox("Digite un numero:"));
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int f=0; f<3; f++)
            {
                for (int c=0; c<4; c++)
                {
                    int multi = matriz1[f, c] * matriz2[f, c];
                    dataGridView1.Rows.Add(matriz1[f, c], matriz2[f, c], multi);
                }
            }
        }
    }
}
