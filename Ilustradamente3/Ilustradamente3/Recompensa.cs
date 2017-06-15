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
    public partial class Recompensa : Form
    {
        public Recompensa()
        {
            InitializeComponent();
        }
        string v1, v2, v3, v4, v5, v6;
      
       

        private void button1_Click(object sender, EventArgs e)
        {
            Mostrar recompensasalvar = new Mostrar(v1, v2, v3, v4, v5, v6, textBox1.Text);
            recompensasalvar.Show();
            this.Close();
            

        } 
       
        public Recompensa(string lembrança, string R1, string R2, string R3, string R4, string R5)
        {
            InitializeComponent();
            v1= lembrança;
           v2= R1;
            v3= R2;
            v4= R3;
            v5= R4;
            v6= R5;
            
            
        }

  

        private void Recompensa_Load(object sender, EventArgs e)
        {
            
        }
    }
}
