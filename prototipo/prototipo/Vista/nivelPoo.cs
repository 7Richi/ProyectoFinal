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
            string[] words = {"Ciclos","Atributos","Clase","Sharp","Privadas","Publicas","RAM", "Forms", "Diagrama","Arreglos" };
            
            //words[0] = "Datos";
            //words[1] = "Base";
            //words[2] = "Programacion";
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
        }

        private void nivelPoo_Load(object sender, EventArgs e)
        {

        }
    }
}
