using System;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using Capa_Datos;

namespace Capa_Presentacion
{
    public partial class login : Form

    {
        private Conectar datos = new Conectar();


        public login()
        {
            InitializeComponent();
            this.BackColor = Color.LimeGreen;
            this.TransparencyKey = Color.LimeGreen;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            singup llamar = new singup();
            llamar.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Estudiante alumno = new Estudiante();
            alumno.Show();
            this.Hide();
            MessageBox.Show("Sesion iniciada por estudiante sastifactoriamente");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            entidades profesor = new entidades();
            profesor.Show();
            this.Hide();
            MessageBox.Show("Sesion iniciada por profesor sastifactoriamente");
        }
        //Director
        private void button2_Click_1(object sender, EventArgs e)
        {
            Director director = new Director();
            director.Show();
            this.Hide();
            MessageBox.Show("Sesion iniciada por director sastifactoriamente");

        }

        private void txtusuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
