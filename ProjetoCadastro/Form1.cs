using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCadastro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      



        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var fornecedor = new Fornecedor();

            if (txtNomeFornecedor.Text != string.Empty)
            {

                fornecedor.NomeFornecedor = txtNomeFornecedor.Text;

            }
            else
            {
                MessageBox.Show("Digite o nome do Fornecedor");
                return;
            }

            if (txtEndereco.Text != string.Empty)
            {
                fornecedor.Endereco = txtEndereco.Text;


            }
            else
            {
                MessageBox.Show("Digite o Endereço");
                return;

            }

            if (txtNomeContato.Text != string.Empty)
            {
                fornecedor.NomeContato = txtNomeContato.Text;

            }
            else
            {
                MessageBox.Show("Digite o nome do Contato");
                return;

            }


            if (txtTelefone.Text != string.Empty)
            {
                fornecedor.Telefone = txtTelefone.Text;

            }
            else
            {
                MessageBox.Show("Digite o Telefone");
                return;

            }



            List<Fornecedor> ListaFornecedores = new List<Fornecedor>();
            ListaFornecedores.Add((fornecedor));

            dgvFornecedor.DataSource = ListaFornecedores;
            
        }

   

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtNomeFornecedor.Clear();
            txtEndereco.Clear();
            txtNomeContato.Clear();
            txtTelefone.Clear();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
