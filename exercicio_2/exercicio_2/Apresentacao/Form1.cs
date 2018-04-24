using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio_2
{
    public partial class Form1 : Form 
    {
        public String tipo;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Modelo.Controle controle;

            if(rdbCF.Checked)
            {
                controle = new Modelo.Controle("CF", txtTemperatura.Text);
            }
            else
            {
                controle = new Modelo.Controle("FC", txtTemperatura.Text);
            }

            if (controle.mensagem.Equals(""))
            {
                lblResultado.Text = controle.resposta;
            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }

        }
    }
}
