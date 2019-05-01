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
using prototipo.Clases;

namespace prototipo.Vista
{
    public partial class formaPersona : Form
    {
        public Persona pers = new Persona();
        public formaPersona()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            formaMenu a = new formaMenu();
            a.Show();
            this.Hide();

            pers.nombre = (textname + "");
            pers.id = (textno + "");
            pers.genero = (textg + "");
            pers.id = (textno + "");
            pers.edad = (texteda + "");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void formaPersona_Load(object sender, EventArgs e)
        {

        }

        private void textname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
