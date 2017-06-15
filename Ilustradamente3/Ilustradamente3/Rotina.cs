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
    public partial class Rotina : Form
    {
        public Rotina()
        {
            InitializeComponent();
        }
        public Rotina(string Valor)
        {
            InitializeComponent();
            label8.Text = "O que te ajuda a lembrar desta rotina: ";
            label2.Text = Valor ;




        }


        private void Rotina_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Recompensa recompensaentrar = new Recompensa(label2.Text, textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
         recompensaentrar.Show();
            this.Close();
            
     
        }
    }
}
