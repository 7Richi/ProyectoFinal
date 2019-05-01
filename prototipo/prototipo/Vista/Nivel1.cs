using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Diagnostics;
using SopaDeLetras;


namespace SopaDeLetras
{
    public partial class Nivel1 : Form
    {
        Random letras = new Random();
         int segundos;
         int   minutos;
        public Nivel1()
        {
            InitializeComponent();
           pic1.Visible = false;
            pic2.Visible = false;
            pic3.Visible = false;
            pic4.Visible = false;
            pic5.Visible = false;
            pic6.Visible = false;
            pic7.Visible = false;
            pic8.Visible = false;
            pic9.Visible = false;
            pic10.Visible = false;
            SigNivel.Visible = false;
            Tabla.RowCount = 10;
            Tabla.ColumnCount = 10;
            timer1.Interval = 1000;
            timer1.Start();


            Tabla.ColumnHeadersVisible = true;

            for (int i = 0; i < Tabla.RowCount; i++)
            {
                for (int j = 0; j < Tabla.ColumnCount; j++)
                {
                    Tabla[j, i].Value = Convert.ToChar(letras.Next(65, 90));
                    inicializarPalabras();
                }
            }
           

        }


        private void Color_click(object sender, EventArgs e)
        {
            Tabla.CurrentCell.Style.BackColor = Color.Red;
            validacion();
            JuegoTerminado();
        }

        private void RegresarColor_Doclick(object sender, EventArgs e)
        {
           Tabla.CurrentCell.Style.BackColor = Color.White;
        }
       
        public void inicializarPalabras()
        {
            Tabla[1,0].Value = "E";
            Tabla[2,1].Value = "N";
            Tabla[3,2].Value = "T";
            Tabla[4,3].Value = "I";
            Tabla[5,4].Value = "D";
            Tabla[6,5].Value = "A";
            Tabla[7,6].Value = "D";

            Tabla[1, 8].Value = "A";
            Tabla[2, 8].Value = "T";
            Tabla[3, 8].Value = "R";
            Tabla[4, 8].Value = "I";
            Tabla[5, 8].Value = "B";
            Tabla[6, 8].Value = "U";
            Tabla[7, 8].Value = "T";
            Tabla[8, 8].Value = "O";

            Tabla[9, 7].Value = "L";
            Tabla[8, 7].Value = "L";
            Tabla[7, 7].Value = "A";
            Tabla[6, 7].Value = "V";
            Tabla[5, 7].Value = "E";

            Tabla[2, 3].Value = "P";
            Tabla[3, 3].Value = "R";
            Tabla[4, 3].Value = "I";
            Tabla[5, 3].Value = "M";
            Tabla[6, 3].Value = "A";
            Tabla[7, 3].Value = "R";
            Tabla[8, 3].Value = "I";
            Tabla[9, 3].Value = "A";

            Tabla[9, 1].Value = 'F';
            Tabla[8, 2].Value = 'O';
            Tabla[7, 3].Value = 'R';
            Tabla[6, 4].Value = 'A';
            Tabla[5, 5].Value = 'N';
            Tabla[4, 6].Value = 'E';
            Tabla[3, 7].Value = 'A';

            Tabla[2, 9].Value = "R";
            Tabla[3, 9].Value = "E";
            Tabla[4, 9].Value = "L";
            Tabla[5, 9].Value = "A";
            Tabla[6, 9].Value = "C";
            Tabla[7, 9].Value = "I";
            Tabla[8, 9].Value = "O";
            Tabla[9, 9].Value = "N";

            Tabla[7, 5].Value = "S";
            Tabla[8, 6].Value = "Q";
            Tabla[9, 7].Value = "L";

            Tabla[0, 9].Value = "S";
            Tabla[0, 8].Value = "C";
            Tabla[0, 7].Value = "R";
            Tabla[0, 6].Value = "I";
            Tabla[0, 5].Value = "P";
            Tabla[0, 4].Value = "T";

            Tabla[0, 0].Value = "S";
            Tabla[1, 0].Value = "E";
            Tabla[2, 0].Value = "C";
            Tabla[3, 0].Value = "C";
            Tabla[4, 0].Value = "A";

            Tabla[0,4].Value = "T";
            Tabla[1,4].Value = "A";
            Tabla[2,4].Value = "B";
            Tabla[3,4].Value = "L";
            Tabla[4,4].Value = "A";            
        }




        public void validacion()
        {
            // Verifico en la tabla si las palabra esta iluminada si es asi entonces hago visible la palomita 

            if (Tabla[1,0].Style.BackColor == Color.Red &&
                Tabla[2,1].Style.BackColor == Color.Red &&
                Tabla[3,2].Style.BackColor == Color.Red &&
                Tabla[4,3].Style.BackColor == Color.Red &&
                Tabla[5,4].Style.BackColor == Color.Red &&
                Tabla[6,5].Style.BackColor == Color.Red &&
                Tabla[7,6].Style.BackColor == Color.Red 
             )

            {

                pic1.Visible = true;
            }

            if (Tabla[1, 8].Style.BackColor == Color.Red &&
                Tabla[2, 8].Style.BackColor == Color.Red &&
                Tabla[3, 8].Style.BackColor == Color.Red &&
                Tabla[4, 8].Style.BackColor == Color.Red &&
                Tabla[5, 8].Style.BackColor == Color.Red &&
                Tabla[6, 8].Style.BackColor == Color.Red &&
                Tabla[7, 8].Style.BackColor == Color.Red &&
                Tabla[8, 8].Style.BackColor == Color.Red
             )

             {

                pic2.Visible = true;
            }

            if (Tabla[9, 7].Style.BackColor == Color.Red &&
                Tabla[8, 7].Style.BackColor == Color.Red &&
                Tabla[7, 7].Style.BackColor == Color.Red &&
                Tabla[6, 7].Style.BackColor == Color.Red &&
                Tabla[5, 7].Style.BackColor == Color.Red
             )

            {

                pic3.Visible = true;
            }

            if (Tabla[2, 3].Style.BackColor == Color.Red &&
                Tabla[3, 3].Style.BackColor == Color.Red &&
                Tabla[4, 3].Style.BackColor == Color.Red &&
                Tabla[5, 3].Style.BackColor == Color.Red &&
                Tabla[6, 3].Style.BackColor == Color.Red &&
                Tabla[7, 3].Style.BackColor == Color.Red &&
                Tabla[8, 3].Style.BackColor == Color.Red &&
                Tabla[9, 3].Style.BackColor == Color.Red
             )

            {

                pic4.Visible = true;
            }

            if (Tabla[9, 1].Style.BackColor == Color.Red &&
                Tabla[8, 2].Style.BackColor == Color.Red &&
                Tabla[7, 3].Style.BackColor == Color.Red &&
                Tabla[6, 4].Style.BackColor == Color.Red &&
                Tabla[5, 5].Style.BackColor == Color.Red &&
                Tabla[4, 6].Style.BackColor == Color.Red &&
                Tabla[3, 7].Style.BackColor == Color.Red
             )

            {

                pic5.Visible = true;
            }

            if (Tabla[2, 9].Style.BackColor == Color.Red &&
                Tabla[3, 9].Style.BackColor == Color.Red &&
                Tabla[4, 9].Style.BackColor == Color.Red &&
                Tabla[5, 9].Style.BackColor == Color.Red &&
                Tabla[6, 9].Style.BackColor == Color.Red &&
                Tabla[7, 9].Style.BackColor == Color.Red &&
                Tabla[8, 9].Style.BackColor == Color.Red &&
                Tabla[9, 9].Style.BackColor == Color.Red
             )

            {

                pic6.Visible = true;
            }

            if (Tabla[7, 5].Style.BackColor == Color.Red &&
                Tabla[8, 6].Style.BackColor == Color.Red &&
                Tabla[9, 7].Style.BackColor == Color.Red 
                )

            {

                pic7.Visible = true;
            }

            if (Tabla[0, 9].Style.BackColor == Color.Red &&
                Tabla[0, 8].Style.BackColor == Color.Red &&
                Tabla[0, 7].Style.BackColor == Color.Red &&
                Tabla[0, 6].Style.BackColor == Color.Red &&
                Tabla[0, 5].Style.BackColor == Color.Red &&
                Tabla[0, 4].Style.BackColor == Color.Red 
             )

            {

                pic8.Visible = true;
            }

            if (Tabla[0,0].Style.BackColor == Color.Red &&
                Tabla[1,0].Style.BackColor == Color.Red &&
                Tabla[2,0].Style.BackColor == Color.Red &&
                Tabla[3,0].Style.BackColor == Color.Red &&
                Tabla[4,0].Style.BackColor == Color.Red 
             )

            {

                pic9.Visible = true;
            }

            if (Tabla[0, 4].Style.BackColor == Color.Red &&
                Tabla[1, 4].Style.BackColor == Color.Red &&
                Tabla[2, 4].Style.BackColor == Color.Red &&
                Tabla[3, 4].Style.BackColor == Color.Red &&
                Tabla[4, 4].Style.BackColor == Color.Red
             )

            {

                pic10.Visible = true;
            }
        }


        public void JuegoTerminado() {

            if (pic1.Visible && pic2.Visible && pic3.Visible && pic4.Visible && pic5.Visible 
                && pic6.Visible && pic7.Visible && pic8.Visible && pic9.Visible && pic10.Visible) {
                timer1.Stop();
                MessageBox.Show("Felicidades!\nHas encontrado todas las palabras en un tiempo de " + Tiempo.Text + " minutos" );
                
                SigNivel.Visible = true;
            }
          }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Tiempo.Visible = true;

            segundos += 1;
            string seg = segundos.ToString();
            if (segundos<10) { seg = "0" + segundos.ToString(); }
   
            if (segundos == 59) {

                minutos += 1;
                segundos = 0;
            }
           
            Tiempo.Text = minutos.ToString() + ":" + seg.ToString();
        }

        private void SigNivel_Click(object sender, EventArgs e)
        {
            Nivel2 llamarN2 = new Nivel2();
            llamarN2.Visible = true;
            Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 inicio = new Form1();
            inicio.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
