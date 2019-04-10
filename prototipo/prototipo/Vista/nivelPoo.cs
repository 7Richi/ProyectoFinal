using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prototipo.Vista
{
    public partial class nivelPoo : Form
    {
        public nivelPoo()
        {
            InitializeComponent();
            Button[,] boton = new Button[15, 15];
            string[] words = { "CICLOS", "ATRIBUTOS", "CLASE", "SHARP", "VARIABLE",
                "STRING", "NOICNUF", "HERENCIA", "SECUENCIALES", "ARREGLOS", "PRIVADA",
                "PUBLICA", "NIAM", "USING", "STATIC" };
            Random alea = new Random();
            string[] letras = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            //words[0] = "Datos";
            //words[1] = "Base";
            //words[2] = "Programacion";
            for (int i = 0; i < 15; i++)
            {//INICIO DE UN FOR
                for (int j = 0; j < 15; j++)
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
            for (int cont = 0; cont < words[14].Length; cont++)
            {//INICIO DE FOR PARA MOSTRAR UNA PALABRA EN ARREGLOS
                string word = words[14];
                boton[2, cont + 7].Text = word[cont].ToString();
            }//FIN DEL FOR

            for (int cont = 0; cont < words[3].Length; cont++)
            {//INICIO DE FOR PARA MOSTRAR UNA PALABRA EN ARREGLOS
                string word = words[3];
                boton[4, cont + 4].Text = word[cont].ToString();
            }//FIN DEL FOR

            for (int cont = 0; cont < words[6].Length; cont++)
            {//INICIO DE FOR PARA MOSTRAR UNA PALABRA EN ARREGLOS
                string word = words[6];
                boton[8, cont + 7].Text = word[cont].ToString();
            }//FIN DEL FOR

            for (int cont = 0; cont < words[12].Length; cont++)
            {//INICIO DE FOR PARA MOSTRAR UNA PALABRA EN ARREGLOS
                string word = words[12];
                boton[10, cont + 2].Text = word[cont].ToString();
            }//FIN DEL FOR

            for (int cont = 0; cont < words[9].Length; cont++)
            {//INICIO DE FOR PARA MOSTRAR UNA PALABRA EN ARREGLOS
                string word = words[9];
                boton[10, cont + 6].Text = word[cont].ToString();
            }//FIN DEL FOR

            for (int cont = 0; cont < words[11].Length; cont++)
            {//INICIO DE FOR PARA MOSTRAR UNA PALABRA EN ARREGLOS
                string word = words[11];
                boton[12, cont + 4].Text = word[cont].ToString();
            }//FIN DEL FOR




            for (int i = 0; i < 15; i++)
            {//INICIO DE UN FOR
                for (int j = 0; j < 15; j++)
                {//INICIO DE UN FOR DENTRO DE OTRO
                    if (boton[i, j].Text.Equals("")) {
                        int aleatorio = alea.Next(25);
                        string caracter = letras[aleatorio];
                        boton[i, j].BackColor = Color.White;
                        boton[i, j].Text = caracter;//String.Format("{0},{1}", i, j);
                    }
                }//FIN DE CICLO FOR DENTRO DE
                }//FIN DE FOR



        }

        private void nivelPoo_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
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
