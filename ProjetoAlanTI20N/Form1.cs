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
    public partial class Form1 : Form
    {
        CadastrarTela cad;
        ConsultarTela con;
        Atualizar atu;
        Excluir exc;
        public Form1()
        {
            InitializeComponent();
            cad = new CadastrarTela();
            atu = new Atualizar();
            exc = new Excluir();
        }

        private void cadastrar_Click(object sender, EventArgs e)
        {
            cad.ShowDialog();
        }//FIm do Botão Cadastrar

        private void atualizar_Click(object sender, EventArgs e)
        {
            atu.ShowDialog();
        }//Fim do botão Atualizar

        private void cnsultar_Click(object sender, EventArgs e)
        {
            con = new ConsultarTela();//Consultar ATUALIZADAS!
            con.ShowDialog();
            
        }//Fim do Botão Consultar

        private void excluir_Click(object sender, EventArgs e)
        {
            exc.ShowDialog();
        }//Fim do botão excluir
    }
}
