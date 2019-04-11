using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prototipo.Clases;


namespace prototipo.Vista
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            usuario usuario1 = new usuario();
            usuario usuario2 = new usuario();

            string email = correo.Text.ToString();
            string contrasena = pass.Text.ToString();

            usuario1.E_mail = "richie.gq2000@gmail.com";
            usuario1.Contrasena = "2455";
            usuario2.E_mail = "juansinuel@gmail.com";
            usuario2.Contrasena = "200200";

            if(usuario1.E_mail == email && contrasena ==usuario1.Contrasena || usuario2.E_mail == email && contrasena == usuario2.Contrasena)
            {
                formaPersona n = new formaPersona();
                n.Show();
                this.Hide();
                MessageBox.Show("Bienvenido");
                           }
            else
            {
                MessageBox.Show("Datos incorrectos");
            }
        }
        
        
    }
}
