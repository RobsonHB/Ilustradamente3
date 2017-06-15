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
    public partial class Mostrar : Form
    {
    

        public Mostrar()
        {
            InitializeComponent();
        }
       
        public Mostrar(string lembrança, string R1, string R2, string R3, string R4, string R5, string rec)
        {
            InitializeComponent();
            label8.Text = lembrança;
            label2.Text = R1;
            label3.Text = R2;
            label4.Text = R3;
            label5.Text = R4;
           label6.Text = R5;
            label10.Text = rec;
           
        }

       

        private void label8_Click(object sender, EventArgs e)
        {
            
        }

        private void Mostrar_Load(object sender, EventArgs e)
        {
            
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
