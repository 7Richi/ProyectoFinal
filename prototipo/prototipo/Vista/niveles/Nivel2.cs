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
    public partial class Nivel2 : Form
    {
        Random letras = new Random();
        int segundos;
        int minutos;
        public Nivel2()
        {
            InitializeComponent();

            pic11.Visible = false;
            pic12.Visible = false;
            pic13.Visible = false;
            pic14.Visible = false;
            pic15.Visible = false;
            pic16.Visible = false;
            pic17.Visible = false;
            pic18.Visible = false;
            pic19.Visible = false;
            pic20.Visible = false;
            pic21.Visible = false;
            pic22.Visible = false;

            SigNivelFinal.Visible = false;
            TablaN2.RowCount = 12;
            TablaN2.ColumnCount = 12;
            timer1.Interval = 1000;
            timer1.Start();


            TablaN2.ColumnHeadersVisible = true;

            for (int i = 0; i < TablaN2.RowCount; i++)
            {
                for (int j = 0; j < TablaN2.ColumnCount; j++)
                {
                    TablaN2[j, i].Value = Convert.ToChar(letras.Next(65, 90));
                    inicializarPalabras();
                }
            }
        }


        public void inicializarPalabras()
        {

            TablaN2[0, 0].Value = "R";
            TablaN2[1, 0].Value = "O";
            TablaN2[2, 0].Value = "U";
            TablaN2[3, 0].Value = "T";
            TablaN2[4, 0].Value = "E";
            TablaN2[5, 0].Value = "R";

            TablaN2[2, 6].Value = "C";
            TablaN2[3, 6].Value = "I";
            TablaN2[4, 6].Value = "S";
            TablaN2[5, 6].Value = "C";
            TablaN2[6, 6].Value = "O";

            TablaN2[4, 7].Value = "S";
            TablaN2[5, 7].Value = "W";
            TablaN2[6, 7].Value = "I";
            TablaN2[7, 7].Value = "T";
            TablaN2[8, 7].Value = "C";
            TablaN2[9, 7].Value = "H";

            TablaN2[0, 10].Value = "S";
            TablaN2[0, 9].Value = "E";
            TablaN2[0, 8].Value = "R";
            TablaN2[0, 7].Value = "V";
            TablaN2[0, 6].Value = "I";
            TablaN2[0, 5].Value = "D";
            TablaN2[0, 4].Value = "O";
            TablaN2[0, 3].Value = "R";

            TablaN2[3, 5].Value = "P";
            TablaN2[3, 6].Value = "I";
            TablaN2[3, 7].Value = "N";
            TablaN2[3, 8].Value = "G";

            TablaN2[11, 1].Value = "S";
            TablaN2[11, 2].Value = "U";
            TablaN2[11, 3].Value = "C";
            TablaN2[11, 4].Value = "C";
            TablaN2[11, 5].Value = "E";
            TablaN2[11, 6].Value = "S";
            TablaN2[11, 7].Value = "S";
            TablaN2[11, 8].Value = "F";
            TablaN2[11, 9].Value = "U";
            TablaN2[11, 10].Value = "L";

            TablaN2[11, 4].Value = "C";
            TablaN2[10, 4].Value = "L";
            TablaN2[9, 4].Value = "O";
            TablaN2[8, 4].Value = "C";
            TablaN2[7, 4].Value = "K";
            TablaN2[6, 4].Value = "R";
            TablaN2[5, 4].Value = "A";
            TablaN2[4, 4].Value = "T";
            TablaN2[3, 4].Value = "E";

            TablaN2[0, 2].Value = "D";
            TablaN2[1, 3].Value = "H";
            TablaN2[2, 4].Value = "C";
            TablaN2[3, 5].Value = "P";

            TablaN2[11, 1].Value = "S";
            TablaN2[10, 1].Value = "U";
            TablaN2[9, 1].Value = "B";
            TablaN2[8, 1].Value = "R";
            TablaN2[7, 1].Value = "E";
            TablaN2[6, 1].Value = "D";

            TablaN2[6, 9].Value = "C";
            TablaN2[5, 9].Value = "O";
            TablaN2[4, 9].Value = "N";
            TablaN2[3, 9].Value = "S";
            TablaN2[2, 9].Value = "O";
            TablaN2[1, 9].Value = "L";
            TablaN2[0, 9].Value = "E";

            TablaN2[9, 3].Value = "H";
            TablaN2[9, 4].Value = "O";
            TablaN2[9, 5].Value = "S";
            TablaN2[9, 6].Value = "T";

            TablaN2[3, 11].Value = "M";
            TablaN2[4, 11].Value = "A";
            TablaN2[5, 11].Value = "S";
            TablaN2[6, 11].Value = "C";
            TablaN2[7, 11].Value = "A";
            TablaN2[8, 11].Value = "R";
            TablaN2[9, 11].Value = "A";

        }

        private void Color_click(object sender, EventArgs e)
        {
            TablaN2.CurrentCell.Style.BackColor = Color.Aqua;
            validacion();
            JuegoTerminado();
        }

        private void RegresarColor_doble_click(object sender, EventArgs e)
        {
            TablaN2.CurrentCell.Style.BackColor = Color.White;
        }


        public void validacion() {
            if (
                TablaN2[0, 0].Style.BackColor == Color.Aqua && 
                TablaN2[1, 0].Style.BackColor == Color.Aqua && 
                TablaN2[2, 0].Style.BackColor == Color.Aqua &&
                TablaN2[3, 0].Style.BackColor == Color.Aqua &&
                TablaN2[4, 0].Style.BackColor == Color.Aqua &&
                TablaN2[5, 0].Style.BackColor == Color.Aqua)
                {

                pic11.Visible = true;
            }

            if (
                TablaN2[2, 6].Style.BackColor == Color.Aqua &&
                TablaN2[3, 6].Style.BackColor == Color.Aqua &&
                TablaN2[4, 6].Style.BackColor == Color.Aqua &&
                TablaN2[5, 6].Style.BackColor == Color.Aqua &&
                TablaN2[6, 6].Style.BackColor == Color.Aqua)
            {

                pic12.Visible = true;
            }

            if (
                TablaN2[4, 7].Style.BackColor == Color.Aqua &&
                TablaN2[5, 7].Style.BackColor == Color.Aqua &&
                TablaN2[7, 7].Style.BackColor == Color.Aqua &&
                TablaN2[8, 7].Style.BackColor == Color.Aqua &&
                TablaN2[9, 7].Style.BackColor == Color.Aqua)
            {

                pic13.Visible = true;
            }

            if (
                TablaN2[0, 10].Style.BackColor == Color.Aqua &&
                TablaN2[0, 9].Style.BackColor == Color.Aqua &&
                TablaN2[0, 8].Style.BackColor == Color.Aqua &&
                TablaN2[0, 7].Style.BackColor == Color.Aqua &&
                TablaN2[0, 6].Style.BackColor == Color.Aqua &&
                TablaN2[0, 5].Style.BackColor == Color.Aqua &&
                TablaN2[0, 5].Style.BackColor == Color.Aqua &&
                TablaN2[0, 3].Style.BackColor == Color.Aqua)
            {

                pic14.Visible = true;
            }

            if (
                TablaN2[3, 5].Style.BackColor == Color.Aqua &&
                TablaN2[3, 6].Style.BackColor == Color.Aqua &&
                TablaN2[3, 7].Style.BackColor == Color.Aqua &&
                TablaN2[3, 8].Style.BackColor == Color.Aqua )
            {

                pic15.Visible = true;
            }

            if (
                TablaN2[11, 1].Style.BackColor == Color.Aqua &&
                TablaN2[11, 2].Style.BackColor == Color.Aqua &&
                TablaN2[11, 3].Style.BackColor == Color.Aqua &&
                TablaN2[11, 4].Style.BackColor == Color.Aqua &&
                TablaN2[11, 5].Style.BackColor == Color.Aqua &&
                TablaN2[11, 6].Style.BackColor == Color.Aqua &&
                TablaN2[11, 7].Style.BackColor == Color.Aqua &&
                TablaN2[11, 8].Style.BackColor == Color.Aqua &&
                TablaN2[11, 9].Style.BackColor == Color.Aqua &&
                TablaN2[11, 10].Style.BackColor == Color.Aqua)
            {

                pic16.Visible = true;
            }

            if (
                TablaN2[11, 4].Style.BackColor == Color.Aqua &&
                TablaN2[10, 4].Style.BackColor == Color.Aqua &&
                TablaN2[9, 4].Style.BackColor == Color.Aqua &&
                TablaN2[8, 4].Style.BackColor == Color.Aqua &&
                TablaN2[7, 4].Style.BackColor == Color.Aqua &&
                TablaN2[6, 4].Style.BackColor == Color.Aqua &&
                TablaN2[5, 4].Style.BackColor == Color.Aqua &&
                TablaN2[4, 4].Style.BackColor == Color.Aqua &&
                TablaN2[3, 4].Style.BackColor == Color.Aqua)
            {

                pic17.Visible = true;
            }

            if (
                TablaN2[0, 2].Style.BackColor == Color.Aqua &&
                TablaN2[1, 3].Style.BackColor == Color.Aqua &&
                TablaN2[2, 4].Style.BackColor == Color.Aqua &&
                TablaN2[3, 5].Style.BackColor == Color.Aqua)
            {

                pic18.Visible = true;
            }

            if (
                TablaN2[11, 1].Style.BackColor == Color.Aqua &&
                TablaN2[10, 1].Style.BackColor == Color.Aqua &&
                TablaN2[9, 1].Style.BackColor == Color.Aqua &&
                TablaN2[8, 1].Style.BackColor == Color.Aqua &&
                TablaN2[7, 1].Style.BackColor == Color.Aqua &&
                TablaN2[6, 1].Style.BackColor == Color.Aqua)
            {

                pic19.Visible = true;
            }

            if (
                TablaN2[6, 9].Style.BackColor == Color.Aqua &&
                TablaN2[5, 9].Style.BackColor == Color.Aqua &&
                TablaN2[4, 9].Style.BackColor == Color.Aqua &&
                TablaN2[3, 9].Style.BackColor == Color.Aqua &&
                TablaN2[2, 9].Style.BackColor == Color.Aqua &&
                TablaN2[1, 9].Style.BackColor == Color.Aqua &&
                TablaN2[0, 9].Style.BackColor == Color.Aqua)
            {

                pic20.Visible = true;
            }

            if (
                TablaN2[9, 3].Style.BackColor == Color.Aqua &&
                TablaN2[9, 4].Style.BackColor == Color.Aqua &&
                TablaN2[9, 5].Style.BackColor == Color.Aqua &&
                TablaN2[9, 6].Style.BackColor == Color.Aqua
                )
            {

                pic21.Visible = true;
            }

            if (
                TablaN2[3, 11].Style.BackColor == Color.Aqua &&
                TablaN2[4, 11].Style.BackColor == Color.Aqua &&
                TablaN2[5, 11].Style.BackColor == Color.Aqua &&
                TablaN2[6, 11].Style.BackColor == Color.Aqua &&
                TablaN2[7, 11].Style.BackColor == Color.Aqua &&
                TablaN2[8, 11].Style.BackColor == Color.Aqua &&
                TablaN2[9, 11].Style.BackColor == Color.Aqua 
                )
            {

                pic22.Visible = true;
            }

        }

        public void JuegoTerminado() {

            if (pic11.Visible&&pic12.Visible&&pic13.Visible&& pic14.Visible && pic15.Visible&&pic16.Visible 
                && pic17.Visible && pic18.Visible && pic19.Visible && pic20.Visible && pic21.Visible && pic22.Visible) {
                timer1.Stop();
                MessageBox.Show("FELICIDADES!!\nHas encontrado todas las palabras en un tiempo de " + Tiempo.Text + " minutos"+
                           "\n¿Estás listo para el último desafío?");

                SigNivelFinal.Visible = true;
            }
        }

        private void SigNivelFinal_Click(object sender, EventArgs e)
        {
            Nivel3 op = new Nivel3();
            op.Visible = true;
            Visible = false;
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            formaMenu inicio = new formaMenu();
            inicio.Show();
            this.Hide();
        }
    }
}
