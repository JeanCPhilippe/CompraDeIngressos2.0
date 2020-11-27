using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabalhoFinal2._0.Modelo;

namespace TrabalhoFinal2._0
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controle cad = new Controle();
            String mensagem = cad.cadastrar(txbEmail.Text, txbSenha.Text, txbConfSenha.Text);
            if (cad.tem)
            {
                MessageBox.Show(mensagem,"Cadastro",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(cad.mensagem);
            }
        }
    }
}
