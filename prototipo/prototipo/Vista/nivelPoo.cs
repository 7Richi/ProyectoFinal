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
            Button[,] boton = new Button[10, 10];
            string[] words = { "CICLOS", "ATRIBUTOS", "CLASE", "SHARP", "VARIABLE", "STRING", "FUNCIONES", "HERENCIA", "SECUENCIALES", "ARREGLOS", "PRIVADA", "PUBLICA", "MAIN", "USING", "STATIC" };

            //words[0] = "Datos";
            //words[1] = "Base";
            //words[2] = "Programacion";
            for (int i = 0; i < 10; i++)
            {//INICIO DE UN FOR
                for (int j = 0; j < 10; j++)
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
            for (int cont = 0; cont < words[0].Length; cont++)
            {//INICIO DE FOR PARA MOSTRAR UNA PALABRA EN ARREGLOS
                string word = words[0];
                boton[0, cont].Text = word[cont].ToString();
            }//FIN DEL FOR
        }

        private void nivelPoo_Load(object sender, EventArgs e)
        {

        }
    }
}
