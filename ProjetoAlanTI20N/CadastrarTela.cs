using clienteTI20N;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjetoAlanTI20N
{
    public partial class CadastrarTela : Form
    {
        DAO bd;
        public CadastrarTela()
        {
            InitializeComponent();
            bd = new DAO();
        }//Fim do metodo construtor

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cpf_TextChanged(object sender, EventArgs e)
        {

        }//Fim do CPF

        private void Nome_TextChanged(object sender, EventArgs e)
        {

        }//Fim do Nome

        private void telefone_TextChanged(object sender, EventArgs e)
        {

        }//Fim do Telefone

        private void endereco_TextChanged(object sender, EventArgs e)
        {

        }//Fim do Endereço

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //Coletar os dados do banco
                long cpf = Convert.ToInt64(textBox1.Text);
                string nome = textBox2.Text;
                string telefone = textBox3.Text;
                string endereco = textBox4.Text;
                //Cadastrar
                MessageBox.Show(bd.Inserir(cpf, nome, telefone, endereco));//Insere dados no BD
                                                                           //Limpar a tela
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo deu errado!\n\n" + ex);
            }
        }//Fim do Botão Cadastrar

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }//Fim do Botão Voltar
    }
}
