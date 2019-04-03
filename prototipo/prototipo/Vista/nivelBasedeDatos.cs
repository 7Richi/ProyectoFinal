using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prototipo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Button[,] boton = new Button[10, 10];
            string[] words = { "Ciclos", "Atributos", "Clase", "Sharp", "Privadas", "Publicas", "RAM", "Forms", "Diagrama", "Arreglos" };
           
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)

                {

                    boton[i, j] = new Button();
                    boton[i, j].Width = 40;
                    boton[i, j].Height = 20;
                    boton[i, j].Text = "";//String.Format("{0},{1}", i, j);
                    boton[i, j].Top = i * 20;
                    boton[i, j].Left = j * 40;
                    this.Controls.Add(boton[i, j]);
                }

            }
            for (int cont=0;cont<words[0].Length;cont++)
            {
                string word = words[0];
                boton[0, cont].Text = word[cont].ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
