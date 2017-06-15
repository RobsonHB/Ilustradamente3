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
    public partial class Funciona : Form
    {
        public Funciona()
        {
            InitializeComponent();
        }

        private void funciona_Load(object sender, EventArgs e)
        {
            textBox1.Text = "O poder do Hábito Mudar um hábito é um processo muito difícil para a maioria das pessoas, porque exige muita dedicação e disciplina. Quantas promessas de final de ano são feitas e não são cumpridas.  E quantos promessas são feitas para ser iniciada na próxima segunda feira… Temos hábitos cotidianos que passam quase despercebidos, pois são padrões de comportamentos repetidos por anos e anos como: tomar banho, escovar os dentes, se alimentar, etc. Então, através da repetição deste comportamentos, os hábitos são assimilados criando um processo de aprendizado e internalizando o conceito. Essas ações inconscientes são repetidas automaticamente com o tempo, porque o cérebro está sempre procurando maneiras de poupar esforços. Portanto, compreender porque o hábito e realizado e saber qual a sua finalidade, é um grande passo para ser alterado através da repetição de uma outra ação.";
            textBox2.Text = "A partir desta descoberta Duhigg chegou à conclusão sobre o “Loop do Hábito”, que é a forma como um hábito se insere e funciona. Começa com uma Deixa: estímulo que manda o cérebro entrar em modo automático, e indica qual hábito deve ser usado.Leva a uma Rotina: que é a forma como executamos a deixa. Recompensa: que ajuda o cérebro, a saber, se vale à pena memorizar este loop para o futuro.";
        }
    }
}
