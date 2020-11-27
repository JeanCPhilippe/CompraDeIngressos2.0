using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoFinal2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tabela_de_FilmesDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'tabela_de_FilmesDataSet.Table'. Você pode movê-la ou removê-la conforme necessário.
            this.tableTableAdapter.Fill(this.tabela_de_FilmesDataSet.Table);
            bindingNavigatorAddNewItem.Enabled = false;
            bindingNavigatorDeleteItem.Enabled = false;
            tableBindingNavigatorSaveItem.Enabled = false;
            nome_do_FilmeTextBox.Enabled = false;
            salaTextBox.Enabled = false;
            horárioTextBox.Enabled = false;
            preço_do_IngressoTextBox.Enabled = false;
            cadeirasTextBox.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "RQFXNAA")
            {
                bindingNavigatorAddNewItem.Enabled = true;
                bindingNavigatorDeleteItem.Enabled = true;
                nome_do_FilmeTextBox.Enabled = true;
                salaTextBox.Enabled = true;
                horárioTextBox.Enabled = true;
                preço_do_IngressoTextBox.Enabled = true;
                cadeirasTextBox.Enabled = true;
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            tableBindingNavigatorSaveItem.Enabled = true;
        }

        private void tableDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
