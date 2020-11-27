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
using System.Data.SqlClient;
using System.Data.Sql;

namespace TrabalhoFinal2._0
{
    public partial class LoginCadastro : Form
    {
        public LoginCadastro()
        {
            InitializeComponent();
        }

        private void LoginCadastro_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'projetoLoginDataSet.Logins'. Você pode movê-la ou removê-la conforme necessário.
            this.loginsTableAdapter.Fill(this.projetoLoginDataSet.Logins);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 cadastro = new Form4();
            cadastro.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.acessar(txbLogin.Text,txbSenha.Text);
            if (controle.mensagem.Equals(""))
            {
                if (controle.tem)
                {
                    MessageBox.Show("Conectado com sucesso", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form2 Usuário = new Form2();
                    Usuário.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Login Não encontrado", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }
        }

        private void loginsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.loginsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.projetoLoginDataSet);

        }
    }
}
