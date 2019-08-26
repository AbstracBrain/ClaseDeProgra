using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();//Cierra forumulario
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (Usuario.Text == "juancho" && Password.Text == "123tamarindo")
            {
                MessageBox.Show("Bienvenido");
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
                Usuario.Text = "";
                Password.Text = "";
                Usuario.Focus();
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
