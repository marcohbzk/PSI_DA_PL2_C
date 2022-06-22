using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace da_pl2_projeto
{
    public partial class FormularioGestaoClientes : Form
    {
        GereRestauranteContainer GereRestauranteContainer = new GereRestauranteContainer();
        public FormularioGestaoClientes()
        {
            InitializeComponent();
        }

        //Voltar ao menu principal
        private void FormularioGestaoClientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            FormularioInicial fp = new FormularioInicial();
            fp.Show();
        }

        private void btnRegistarCliente_Click(object sender, EventArgs e)
        {
            Morada tempMorada = new Morada();
            Cliente tempCliente = new Cliente();

            tempCliente.Nome = textBoxNomeCliente.Text;
            tempCliente.NumContribuinte = Convert.ToInt32(textBoxNifCliente.Text);
            tempCliente.Telemovel = Convert.ToInt32(textBoxTelefoneCliente.Text);
            tempMorada.Rua = textBoxRuaCliente.Text;
            tempMorada.Cidade = textBoxCidadeCliente.Text;
            tempMorada.CodPostal = textBoxCodPostalCliente.Text;
            tempMorada.Pais = textBoxPaisCliente.Text;
            tempCliente.TotalGasto = Convert.ToDecimal(textBoxTotalGastoCliente.Text);
            tempCliente.Morada = tempMorada;

            //Adiciona o cliente e a morada à base de dados e atualiza a DataGridView
            GereRestauranteContainer.Moradas.Add(tempMorada);
            GereRestauranteContainer.Pessoas.Add(tempCliente);
            GereRestauranteContainer.SaveChanges();
            LerDados();
        }

        private void btnApagarCliente_Click(object sender, EventArgs e)
        {
            Cliente userdata = GetSelectedClient();

            GereRestauranteContainer.Pessoas.Remove(userdata);

            GereRestauranteContainer.SaveChanges();
            LerDados();
        }
        private Cliente GetSelectedClient()
        {
            int row = dataGridViewClientes.SelectedCells[0].RowIndex;
            int id = (int)dataGridViewClientes.Rows[row].Cells["id"].Value;
            Cliente data = GereRestauranteContainer.Pessoas.First(c => c.Id == id) as Cliente;

            return data;
        }

        //Assim que o formulário abrir vai gerar os dados de sessões anteriores
        private void FormularioGestaoClientes_Load(object sender, EventArgs e)
        {
            LerDados();
        }

        private void LerDados()
        {         
            List<Pessoa> clientes = new List<Pessoa>();
            try
            {
                //Percorre todas as pessoas na base de dados
                foreach (Pessoa pessoa in GereRestauranteContainer.Pessoas.ToList())
                {
                    if (pessoa is Cliente) //Se a pessoa for um cliente adiciona-a à lista
                    {
                        clientes.Add(pessoa);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            dataGridViewClientes.DataSource = clientes; //Muda a datasource para a lista

            //TAMANHO DAS COLUNAS AUTOMATICAMENTE

            // Escolhe o tamanho da coluna indicada. Podes usar .AllCells ou .Fill
            dataGridViewClientes.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewClientes.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewClientes.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewClientes.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            // Depois da DataGrid calcular a largura da columa podemos então guardar a largura de cada coluna
            for (int i = 0; i <= dataGridViewClientes.Columns.Count - 1; i++)
            {
                // Guardar a largura das colunas na variável:
                int colw = dataGridViewClientes.Columns[i].Width;

                // Remover AutoSizing:
                dataGridViewClientes.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

                // Alterar a largura para o valor do AutoSize:
                dataGridViewClientes.Columns[i].Width = colw;
            }
        }

        private void dataGridViewClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {

        }
    }
}
