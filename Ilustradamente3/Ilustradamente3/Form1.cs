using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ilustradamente3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Deixa deixaentrar = new Deixa();
            deixaentrar.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rotina rotinaentrar = new Rotina();
            rotinaentrar.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Recompensa recompensaentrar = new Recompensa();
            recompensaentrar.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
       private void comoFuncionaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Funciona funcionaentrar = new Funciona();
            funcionaentrar.Show();
        }

        private void quemÉOCriadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("CHARLES DUHIGG");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Mostrar mostrarentrar = new Mostrar();
            mostrarentrar.Show();
        }
    }
}
