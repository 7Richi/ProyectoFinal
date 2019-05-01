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

namespace Prototip.Vista.Niveles
{
    public partial class Nivel3 : Form
    {
        Random letras = new Random();
        int segundos;
        int minutos;
        public Nivel3()
        {
            InitializeComponent();
            p1.Visible = false;
            p2.Visible = false;
            p3.Visible = false;
            p4.Visible = false;
            p5.Visible = false;
            p6.Visible = false;
            p7.Visible = false;
            p8.Visible = false;
            p9.Visible = false;
            p10.Visible = false;
            p11.Visible = false;
            p13.Visible = false;
            p14.Visible = false;
            p15.Visible = false;

            terminar.Visible = false;

            TablaN3.RowCount = 15;
            TablaN3.ColumnCount = 15;

            timer1.Interval = 1000;
            timer1.Start();


            TablaN3.ColumnHeadersVisible = true;

            for (int i = 0; i < TablaN3.RowCount; i++)
            {
                for (int j = 0; j < TablaN3.ColumnCount; j++)
                {
                    TablaN3[j, i].Value = Convert.ToChar(letras.Next(65, 90));
                   inicializarPalabras();
                }
            }
        }


        public void inicializarPalabras() {

            TablaN3[8, 9].Value = "C";
            TablaN3[9, 8].Value = "I";
            TablaN3[10, 7].Value = "C";
            TablaN3[11, 6].Value = "L";
            TablaN3[12, 5].Value = "O";
            TablaN3[13, 4].Value = "S";

            TablaN3[9, 2].Value = "A";
            TablaN3[8, 3].Value = "T";
            TablaN3[7, 4].Value = "R";
            TablaN3[6, 5].Value = "I";
            TablaN3[5, 6].Value = "B";
            TablaN3[4, 7].Value = "U";
            TablaN3[3, 8].Value = "T";
            TablaN3[2, 9].Value = "O";

            TablaN3[6, 8].Value = "C";
            TablaN3[6, 9].Value = "L";
            TablaN3[6, 10].Value = "A";
            TablaN3[6, 11].Value = "S";
            TablaN3[6, 12].Value = "E";

            TablaN3[4, 4].Value = "S";
            TablaN3[5, 4].Value = "H";
            TablaN3[6, 4].Value = "A";
            TablaN3[7, 4].Value = "R";
            TablaN3[8, 4].Value = "P";

            TablaN3[0, 14].Value = "V";
            TablaN3[1, 14].Value = "A";
            TablaN3[2, 14].Value = "R";
            TablaN3[3, 14].Value = "I";
            TablaN3[4, 14].Value = "A";
            TablaN3[5, 14].Value = "B";
            TablaN3[6, 14].Value = "L";
            TablaN3[7, 14].Value = "E";

            TablaN3[7, 1].Value = "S";
            TablaN3[8, 2].Value = "T";
            TablaN3[9, 3].Value = "R";
            TablaN3[10, 4].Value = "I";
            TablaN3[11, 5].Value = "N";
            TablaN3[12, 6].Value = "G";

            TablaN3[13, 8].Value = "F";
            TablaN3[12, 8].Value = "U";
            TablaN3[11, 8].Value = "N";
            TablaN3[10, 8].Value = "C";
            TablaN3[9, 8].Value = "I";
            TablaN3[8, 8].Value = "O";
            TablaN3[7, 8].Value = "N";

            TablaN3[5, 12].Value = "H";
            TablaN3[6, 12].Value = "E";
            TablaN3[7, 12].Value = "R";
            TablaN3[8, 12].Value = "E";
            TablaN3[9, 12].Value = "N";
            TablaN3[10, 12].Value = "C";
            TablaN3[11, 12].Value = "I";
            TablaN3[12, 12].Value = "A";

            TablaN3[1, 7].Value = "S";
            TablaN3[2, 7].Value = "E";
            TablaN3[3, 7].Value = "C";
            TablaN3[4, 7].Value = "U";
            TablaN3[5, 7].Value = "E";
            TablaN3[6, 7].Value = "N";
            TablaN3[7, 7].Value = "C";
            TablaN3[8, 7].Value = "I";
            TablaN3[9, 7].Value = "A";

            TablaN3[6, 10].Value = "A";
            TablaN3[7, 10].Value = "R";
            TablaN3[8, 10].Value = "R";
            TablaN3[9, 10].Value = "E";
            TablaN3[10, 10].Value = "G";
            TablaN3[11, 10].Value = "L";
            TablaN3[12, 10].Value = "O";
            TablaN3[13, 10].Value = "S";

            TablaN3[7, 11].Value = "M";
            TablaN3[6, 10].Value = "A";
            TablaN3[5, 9].Value = "I";
            TablaN3[4, 8].Value = "N";


            TablaN3[14, 0].Value = "U";
            TablaN3[14, 1].Value = "S";
            TablaN3[14, 2].Value = "I";
            TablaN3[14, 3].Value = "N";
            TablaN3[14, 4].Value = "G";

            TablaN3[7, 2].Value = "S";
            TablaN3[8, 2].Value = "T";
            TablaN3[9, 2].Value = "A";
            TablaN3[10, 2].Value = "T";
            TablaN3[11, 2].Value = "I";
            TablaN3[12, 2].Value = "C";

            TablaN3[8, 0].Value = "B";
            TablaN3[9, 1].Value = "U";
            TablaN3[10, 2].Value = "T";
            TablaN3[11, 3].Value = "T";
            TablaN3[12, 4].Value = "O";
            TablaN3[13, 5].Value = "N";

        }

        private void Color_click(object sender, EventArgs e)
        {
            TablaN3.CurrentCell.Style.BackColor = Color.Pink;
            validacion();
            JuegoTerminado();
        }

        public void validacion()
        {
            if (TablaN3[8, 9].Style.BackColor == Color.Pink && 
                TablaN3[9, 8].Style.BackColor == Color.Pink && 
                TablaN3[10, 7].Style.BackColor == Color.Pink &&
                TablaN3[11, 6].Style.BackColor == Color.Pink &&
                TablaN3[12, 5].Style.BackColor == Color.Pink &&
                TablaN3[13, 4].Style.BackColor == Color.Pink)
            {

                p1.Visible = true;

            }

            if (TablaN3[9, 2].Style.BackColor == Color.Pink &&
                TablaN3[8, 3].Style.BackColor == Color.Pink &&
                TablaN3[7, 4].Style.BackColor == Color.Pink &&
                TablaN3[6, 5].Style.BackColor == Color.Pink &&
                TablaN3[5, 6].Style.BackColor == Color.Pink &&
                TablaN3[4, 7].Style.BackColor == Color.Pink &&
                TablaN3[3, 8].Style.BackColor == Color.Pink &&
                TablaN3[2, 9].Style.BackColor == Color.Pink)
            {

                p2.Visible = true;

            }

            if (TablaN3[6, 8].Style.BackColor == Color.Pink &&
                TablaN3[6, 9].Style.BackColor == Color.Pink &&
                TablaN3[6, 10].Style.BackColor == Color.Pink &&
                TablaN3[6, 11].Style.BackColor == Color.Pink &&
                TablaN3[6, 12].Style.BackColor == Color.Pink)
            {

                p3.Visible = true;

            }

            if (TablaN3[4, 4].Style.BackColor == Color.Pink &&
                TablaN3[5, 4].Style.BackColor == Color.Pink &&
                TablaN3[6, 4].Style.BackColor == Color.Pink &&
                TablaN3[7, 4].Style.BackColor == Color.Pink &&
                TablaN3[8, 4].Style.BackColor == Color.Pink)
            {

                p4.Visible = true;

            }

            if (TablaN3[0, 14].Style.BackColor == Color.Pink &&
                TablaN3[1, 14].Style.BackColor == Color.Pink &&
                TablaN3[2, 14].Style.BackColor == Color.Pink &&
                TablaN3[3, 14].Style.BackColor == Color.Pink &&
                TablaN3[4, 14].Style.BackColor == Color.Pink &&
                TablaN3[5, 14].Style.BackColor == Color.Pink &&
                TablaN3[6, 14].Style.BackColor == Color.Pink &&
                TablaN3[7, 14].Style.BackColor == Color.Pink)
            {

                p5.Visible = true;

            }

            if (TablaN3[7, 1].Style.BackColor == Color.Pink &&
                TablaN3[8, 2].Style.BackColor == Color.Pink &&
                TablaN3[9, 3].Style.BackColor == Color.Pink &&
                TablaN3[10, 4].Style.BackColor == Color.Pink &&
                TablaN3[11, 5].Style.BackColor == Color.Pink &&
                TablaN3[12, 6].Style.BackColor == Color.Pink)
            {

                p6.Visible = true;

            }

            if (TablaN3[13, 8].Style.BackColor == Color.Pink &&
                TablaN3[12, 8].Style.BackColor == Color.Pink &&
                TablaN3[11, 8].Style.BackColor == Color.Pink &&
                TablaN3[10, 8].Style.BackColor == Color.Pink &&
                TablaN3[9, 8].Style.BackColor == Color.Pink &&
                TablaN3[8, 8].Style.BackColor == Color.Pink &&
                TablaN3[7, 8].Style.BackColor == Color.Pink)
            {

                p7.Visible = true;

            }

            if (TablaN3[5, 12].Style.BackColor == Color.Pink &&
                TablaN3[6, 12].Style.BackColor == Color.Pink &&
                TablaN3[7, 12].Style.BackColor == Color.Pink &&
                TablaN3[8, 12].Style.BackColor == Color.Pink &&
                TablaN3[9, 12].Style.BackColor == Color.Pink &&
                TablaN3[10, 12].Style.BackColor == Color.Pink &&
                TablaN3[11, 12].Style.BackColor == Color.Pink &&
                TablaN3[12, 12].Style.BackColor == Color.Pink)
            {

                p8.Visible = true;

            }

            if (TablaN3[1, 7].Style.BackColor == Color.Pink &&
                TablaN3[2, 7].Style.BackColor == Color.Pink &&
                TablaN3[3, 7].Style.BackColor == Color.Pink &&
                TablaN3[4, 7].Style.BackColor == Color.Pink &&
                TablaN3[5, 7].Style.BackColor == Color.Pink &&
                TablaN3[6, 7].Style.BackColor == Color.Pink &&
                TablaN3[7, 7].Style.BackColor == Color.Pink &&
                TablaN3[8, 7].Style.BackColor == Color.Pink &&
                TablaN3[9, 7].Style.BackColor == Color.Pink)
            {

                p9.Visible = true;

            }

            if (TablaN3[6, 10].Style.BackColor == Color.Pink &&
                TablaN3[7, 10].Style.BackColor == Color.Pink &&
                TablaN3[8, 10].Style.BackColor == Color.Pink &&
                TablaN3[9, 10].Style.BackColor == Color.Pink &&
                TablaN3[10, 10].Style.BackColor == Color.Pink &&
                TablaN3[11, 10].Style.BackColor == Color.Pink &&
                TablaN3[12, 10].Style.BackColor == Color.Pink &&
                TablaN3[13, 10].Style.BackColor == Color.Pink)
            {

                p10.Visible = true;

            }

            if (TablaN3[7, 11].Style.BackColor == Color.Pink &&
                TablaN3[6, 10].Style.BackColor == Color.Pink &&
                TablaN3[5, 9].Style.BackColor == Color.Pink &&
                TablaN3[4, 8].Style.BackColor == Color.Pink)
            {

                p11.Visible = true;

            }

            

            if (TablaN3[14, 0].Style.BackColor == Color.Pink &&
                TablaN3[14, 1].Style.BackColor == Color.Pink &&
                TablaN3[14, 2].Style.BackColor == Color.Pink &&
                TablaN3[14, 3].Style.BackColor == Color.Pink &&
                TablaN3[14, 4].Style.BackColor == Color.Pink)
            {

                p13.Visible = true;

            }

            if (TablaN3[7, 2].Style.BackColor == Color.Pink &&
                TablaN3[8, 2].Style.BackColor == Color.Pink &&
                TablaN3[9, 2].Style.BackColor == Color.Pink &&
                TablaN3[10, 2].Style.BackColor == Color.Pink &&
                TablaN3[11, 2].Style.BackColor == Color.Pink &&
                TablaN3[12, 2].Style.BackColor == Color.Pink)
            {

                p14.Visible = true;

            }

            if (TablaN3[8, 0].Style.BackColor == Color.Pink &&
                TablaN3[9, 1].Style.BackColor == Color.Pink &&
                TablaN3[10, 2].Style.BackColor == Color.Pink &&
                TablaN3[11, 3].Style.BackColor == Color.Pink &&
                TablaN3[12, 4].Style.BackColor == Color.Pink &&
                TablaN3[13, 5].Style.BackColor == Color.Pink )
            {

                p15.Visible = true;

            }

        }
        

        public void JuegoTerminado()
        {

            if (p1.Visible && p2.Visible && p3.Visible && p4.Visible && p5.Visible && p6.Visible & p7.Visible & p8.Visible
                & p9.Visible & p10.Visible & p11.Visible & p15.Visible & p13.Visible
                & p14.Visible )
            {
                timer1.Stop();
                MessageBox.Show("¡¡FELICIDADES HAS TERMINADO EL JUEGO!!\nHas encontrado todas las palabras en un tiempo de " + Tiempo.Text+ " minutos");
                terminar.Visible = true;
            }
        }

        private void Regresar_color_click(object sender, EventArgs e)
        {
            TablaN3.CurrentCell.Style.BackColor = Color.White;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Tiempo.Visible = true;

            segundos += 1;
            string seg = segundos.ToString();
            if (segundos < 10) { seg = "0" + segundos.ToString(); }

            if (segundos == 59)
            {

                minutos += 1;
                segundos = 0;
            }

            Tiempo.Text = minutos.ToString() + ":" + seg.ToString();
        }

        private void terminar_Click(object sender, EventArgs e)
        {
          
            this.Close();
           

        }

        private void N3PIC6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            formaMenu inicio = new formaMenu();
            inicio.Show();
            this.Hide();
        }
    }
}

