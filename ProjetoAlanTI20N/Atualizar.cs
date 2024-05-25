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

namespace ProjetoAlanTI20N
{
    public partial class Atualizar : Form
    {
        DAO bd;
        public Atualizar()
        {
            InitializeComponent();
            bd = new DAO();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }//Fim do CPF

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }//Fim do Campo

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }//Fim do dado/Informação

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Coletar os dados
                long cpf = Convert.ToInt64(textBox3.Text);
                string campo = textBox1.Text;
                string dado = textBox2.Text;
                //Atualizar os dados
                MessageBox.Show(bd.Atualizar(cpf, "pessoa", campo, dado));
                //Limpar os campos
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo deu errado!\n\n" + ex);
            }
        }//Fim do Botão Atualizar
    }//Fim do Projeto
}//Fim da Classe
