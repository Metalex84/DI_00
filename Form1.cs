using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_user.Text.Length == 0)
            {
                MessageBox.Show("Introduzca un nombre", "ERROR");
            }
            else if (txt_passw.Text.Length == 0)
            {
                MessageBox.Show("Introduzca una contraseña", "ERROR");
            }
            else
            {
                Bienvenida bienvenida = new Bienvenida(txt_user.Text, dateTimePicker1.Value.Year);
                bienvenida.Show();
                this.Hide();
            }

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_user.Clear();
            txt_passw.Clear();
        }

        private void txt_passw_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txt_passw.UseSystemPasswordChar = !checkBox1.Checked;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
