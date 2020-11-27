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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tabela_de_FilmesDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'tabela_de_FilmesDataSet.Table'. Você pode movê-la ou removê-la conforme necessário.
            this.tableTableAdapter.Fill(this.tabela_de_FilmesDataSet.Table);
            button1.Enabled = false;
            textBox1.Enabled = Enabled;
            maskedTextBox1.Enabled = false;
            maskedTextBox2.Enabled = false;
            maskedTextBox3.Enabled = false;
            maskedTextBox4.Enabled = false;
        }

        private void nome_do_FilmeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nome_do_FilmeLabel_Click(object sender, EventArgs e)
        {

        }

        private void horárioLabel_Click(object sender, EventArgs e)
        {

        }

        private void horárioTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void salaLabel_Click(object sender, EventArgs e)
        {

        }

        private void salaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void preço_do_IngressoLabel_Click(object sender, EventArgs e)
        {

        }

        private void preço_do_IngressoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aguarde", "Espere", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show("Compra finalizada","Finalizado",MessageBoxButtons.OK, MessageBoxIcon.Information);  
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            maskedTextBox1.Enabled = Enabled;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            maskedTextBox2.Enabled = true;
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            maskedTextBox3.Enabled = true;
        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            maskedTextBox4.Enabled = true;
        }

        private void maskedTextBox4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            button1.Enabled = true;
        }
    }
}
