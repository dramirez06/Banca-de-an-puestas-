using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void golfToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void boxeoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();  
        }

        private void ganaciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
     
        }

        private void ganaciasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form3 Empleados = new Form3();
            Empleados.Show();
        }

        private void gananciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 Balance = new Form4();
            Balance.Show();
        }

        private void basketballToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 Apuestas1 = new Form5();
            Apuestas1.Show();
        }

        private void baseballToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 Apuestas2 = new Form6();
            Apuestas2.Show();
        }

        private void ventaToolStripMenuItem_Click(object sender, EventArgs e)
        {
       
        }

        private void compraToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
