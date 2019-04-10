using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prototipo.Vista;

namespace prototipo.Vista
{
    public partial class nivelRedes : Form
    {
        public nivelRedes()
        {
            InitializeComponent();
            Button[,] boton = new Button[12, 12];
            string[] words = { "ROUTER", "CISCO", "SWITCH", "SERVIDOR", "PING", "SUCCESSFUL",
                "ETARKCOLC", "HOSTNAME", "DERBUS", "ELOSNOC", "HOST", "ARACSAM" };
            Random alea = new Random();
            string[] letras = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };

            for (int i = 0; i < 12; i++)
            {//INICIO DE UN FOR
                for (int j = 0; j < 12; j++)
                {//INICIO DE UN FOR DENTRO DE OTRO
                    boton[i, j] = new Button();
                    boton[i, j].Width = 25;
                    boton[i, j].Height = 25;
                    boton[i, j].Text = "";//String.Format("{0},{1}", i, j);
                    boton[i, j].Top = i * 25;
                    boton[i, j].Left = j * 25;
                    this.Controls.Add(boton[i, j]);
                }//FIN DE CICLO FOR DENTRO DE

            }//FIN DE FOR
            for (int cont = 0; cont < words[8].Length; cont++)
            {//INICIO DE FOR PARA MOSTRAR UNA PALABRA EN ARREGLOS
                string word = words[8];
                boton[1, cont + 6].Text = word[cont].ToString();
            }//FIN DEL FOR

            for (int cont = 0; cont < words[6].Length; cont++)
            {//INICIO DE FOR PARA MOSTRAR UNA PALABRA EN ARREGLOS
                string word = words[6];
                boton[4, cont + 3].Text = word[cont].ToString();
            }//FIN DEL FOR

            for (int cont = 0; cont < words[1].Length; cont++)
            {//INICIO DE FOR PARA MOSTRAR UNA PALABRA EN ARREGLOS
                string word = words[1];
                boton[6, cont + 2].Text = word[cont].ToString();
            }//FIN DEL FOR

            for (int cont = 0; cont < words[2].Length; cont++)
            {//INICIO DE FOR PARA MOSTRAR UNA PALABRA EN ARREGLOS
                string word = words[2];
                boton[7, cont + 4].Text = word[cont].ToString();
            }//FIN DEL FOR

            for (int cont = 0; cont < words[9].Length; cont++)
            {//INICIO DE FOR PARA MOSTRAR UNA PALABRA EN ARREGLOS
                string word = words[9];
                boton[9, cont ].Text = word[cont].ToString();
            }//FIN DEL FOR

            for (int cont = 0; cont < words[11].Length; cont++)
            {//INICIO DE FOR PARA MOSTRAR UNA PALABRA EN ARREGLOS
                string word = words[11];
                boton[10, cont + 3].Text = word[cont].ToString();
            }//FIN DEL FOR

            for (int i = 0; i < 12; i++)
            {//INICIO DE UN FOR
                for (int j = 0; j < 12; j++)
                {//INICIO DE UN FOR DENTRO DE OTRO
                    if (boton[i, j].Text.Equals(""))
                    {
                        int aleatorio = alea.Next(25);
                        string caracter = letras[aleatorio];
                        boton[i, j].BackColor = Color.White;
                        boton[i, j].Text = caracter;//String.Format("{0},{1}", i, j);
                    }
                }//FIN DE CICLO FOR DENTRO DE
            }//FIN DE FOR

        }

        private void nivelRedes_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            formaMenu inicio = new formaMenu();
            inicio.Show();
            this.Hide();
        }
    }
}
