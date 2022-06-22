using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace da_pl2_projeto
{
    public partial class FormulariodePedidos : Form
    {
        GereRestauranteContainer GereRestauranteContainer = new GereRestauranteContainer();
        public FormulariodePedidos()
        {
            InitializeComponent();
        }

        private void FormulariodePedidos_Load(object sender, EventArgs e)
        {
            listBoxItensMenu.DataSource = GereRestauranteContainer.ItensMenu.ToList<ItemMenu>();

            List<Pedido> listaPedidos = GereRestauranteContainer.PedidoSet.ToList<Pedido>();


            IEnumerable<Pedido> PedidosAndando = from pedido in listaPedidos
                                                 where pedido.Estado.EstadoInt == 2
                                                 where pedido.RestauranteId == FormularioInicial.idRest.Id
                                                 select pedido;

            foreach (Pedido pedido in PedidosAndando)
            {
                listBoxPedidosAPagar.Items.Add(pedido);
            }

            List<Pedido> listaPedidos2 = GereRestauranteContainer.PedidoSet.ToList<Pedido>();


            IEnumerable<Pedido> PedidosAndando2 = from pedido in listaPedidos2
                                                  where pedido.Estado.EstadoInt == 1
                                                  where pedido.RestauranteId == FormularioInicial.idRest.Id
                                                  select pedido;

            foreach (Pedido pedido in PedidosAndando2)
            {
                listBoxPedidosEmProcessamento.Items.Add(pedido);
            }

            LerDados();
        }

        private void btnCriarPedido_Click(object sender, EventArgs e)
        {
            Pedido tempPedido = new Pedido();
            Estado tempEstado = new Estado();

            Restaurante restaurante = GereRestauranteContainer.Restaurantes.Find(FormularioInicial.idRest.Id);
           

            tempPedido.RestauranteId = FormularioInicial.idRest.Id;
            tempPedido.Restaurante = restaurante;

            if(GetSelectedTrabalhador() == null)
            {
                MessageBox.Show("Nao selecionou nenhum trabalhador");
            }
            else
            {
                tempPedido.Trabalhador = GetSelectedTrabalhador();
            }

            if (GetSelectedCliente() == null)
            {
                MessageBox.Show("Nao selecionou nenhum Cliente");
            }
            else
            {
                tempPedido.Cliente = GetSelectedCliente();
            }

            if (listBoxItensPedido.Items == null)
            {
                MessageBox.Show("Nao selecionou nenhum item do menu");
            }
            else
            {
                foreach (ItemMenu item in listBoxItensPedido.Items)
                {
                    tempPedido.ItemMenu.Add(item);
                }

                tempEstado.EstadoInt = 1;
                
                tempPedido.Estado = tempEstado;
                tempEstado.Pedido.Add(tempPedido);

                GereRestauranteContainer.PedidoSet.Add(tempPedido);
                GereRestauranteContainer.Estados.Add(tempEstado);

                GereRestauranteContainer.SaveChanges();
                LerDados();

                List<Pedido> listaPedidos2 = GereRestauranteContainer.PedidoSet.ToList<Pedido>();
                IEnumerable<Pedido> PedidosAndando2 = from pedido in listaPedidos2
                                                      where pedido.Estado.EstadoInt == 1
                                                      where pedido.RestauranteId == FormularioInicial.idRest.Id
                                                      select pedido;

                foreach (Pedido pedido in PedidosAndando2)
                {
                    if (listBoxPedidosEmProcessamento.Items.Contains(pedido))
                    {
                        //
                    }
                    else
                    {
                        listBoxPedidosEmProcessamento.Items.Add(pedido);
                    }

                }
            }
        }

        private void LerDados()
        {
            List<Pessoa> trabalhadores = new List<Pessoa>();
            List<Pessoa> clientes = new List<Pessoa>();

            Trabalhador tempTrabalhador = new Trabalhador();

            try
            {
                //Percorre todos os pedidos na base de dados
                foreach (Pessoa pessoa in GereRestauranteContainer.Pessoas.ToList())
                {
                    if (pessoa is Trabalhador) //Se a pessoa for um trabalhador adiciona-a à lista
                    {
                        tempTrabalhador = (Trabalhador)pessoa;
                        if (tempTrabalhador.RestauranteId == FormularioInicial.idRest.Id)
                        {
                            trabalhadores.Add(pessoa as Trabalhador);
                        }
                    }
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

            dataGridViewTrabalhadores.DataSource = trabalhadores; //Muda a datasource para a lista

            //TAMANHO DAS COLUNAS AUTOMATICAMENTE
            // Escolhe o tamanho da coluna indicada. Podes usar .AllCells ou .Fill
            dataGridViewTrabalhadores.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTrabalhadores.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTrabalhadores.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTrabalhadores.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            // Depois da DataGrid calcular a largura da columa podemos então guardar a largura de cada coluna
            for (int i = 0; i <= dataGridViewTrabalhadores.Columns.Count - 1; i++)
            {
                // Guardar a largura das colunas na variável:
                int colw = dataGridViewTrabalhadores.Columns[i].Width;

                // Remover AutoSizing:
                dataGridViewTrabalhadores.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

                // Alterar a largura para o valor do AutoSize:
                dataGridViewTrabalhadores.Columns[i].Width = colw;
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
        private Trabalhador GetSelectedTrabalhador()
        {
            int row = dataGridViewTrabalhadores.SelectedCells[0].RowIndex;
            int id = (int)dataGridViewTrabalhadores.Rows[row].Cells["id"].Value;
            Trabalhador dataTrabalhador = GereRestauranteContainer.Pessoas.First(c => c.Id == id) as Trabalhador;

            return dataTrabalhador;
        }
        private Cliente GetSelectedCliente()
        {
            int row = dataGridViewClientes.SelectedCells[0].RowIndex;
            int id = (int)dataGridViewClientes.Rows[row].Cells["id"].Value;
            Cliente dataCliente = GereRestauranteContainer.Pessoas.First(c => c.Id == id) as Cliente;

            return dataCliente;
        }

        private void btnAdicionarItemPedido_Click(object sender, EventArgs e)
        {
            var temp = listBoxItensMenu.SelectedItem;
            if(temp == null)
            {
                MessageBox.Show("Nao selecionou nenhum item do menu");
            }
            else
            {
                listBoxItensPedido.Items.Add(temp);
            }
        }

        private void btnCancelarPedido_Click(object sender, EventArgs e)
        {

        }

        private void FormulariodePedidos_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            FormularioInicial fi = new FormularioInicial();
            fi.Show();
        }

        private void btnFinalizarPedido_Click(object sender, EventArgs e)
        {
            Pedido pedido = (Pedido)listBoxPedidosEmProcessamento.SelectedItem;

            if(listBoxPedidosEmProcessamento.SelectedItem == null)
            {
                MessageBox.Show("Tem de selecionar um pedido");
            }
            else
            {
                pedido.Estado.EstadoInt = 2;
                GereRestauranteContainer.SaveChanges();
                var temp = listBoxPedidosEmProcessamento.SelectedItem;
                listBoxPedidosAPagar.Items.Add(temp);
            }    
        }

        private void comboBoxMetodoPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdicionarValor_Click(object sender, EventArgs e)
        {
            Pagamento pagamento = new Pagamento();
            MetodoPagamento metodo = new MetodoPagamento();
            Pedido pedido = (Pedido)listBoxPedidosAPagar.SelectedItem;

            if(listBoxPedidosAPagar.SelectedItem == null)
            {
                MessageBox.Show("Tem de selecionar um pedido");
            }
            else
            {
                pedido.Estado.EstadoInt = 3;

                if (comboBoxMetodoPagamento.SelectedItem == null)
                {
                    MessageBox.Show("Tem de selecionar um metodo de pagamento");
                }
                else
                {
                    metodo.MetodoDePagamento = comboBoxMetodoPagamento.SelectedItem.ToString();
                    metodo.Ativo = true;

                    pagamento.Pedido = pedido;
                    pagamento.MetodoPagamento = metodo;
                    

                    if(textBox1.Text == null || textBox1.Text == "")
                    {
                        MessageBox.Show("Tem de adicionar um valor ao pagamento");
                    }
                    else
                    {
                        pagamento.Valor = Convert.ToInt32(textBox1.Text);
                        pedido.ValorTotal = Convert.ToInt32(textBox1.Text);
                        metodo.Pagamento.Add(pagamento);
                        pedido.Pagamento.Add(pagamento);
                     
                        GereRestauranteContainer.Pagamentos.Add(pagamento);
                        GereRestauranteContainer.MetodosPagamento.Add(metodo);

                        GereRestauranteContainer.SaveChanges();

                        var temp = listBoxPedidosAPagar.SelectedItem;
                        listBoxPedidos.Items.Add(temp);
                    }
                }
            }
        }

        private void btnConcluirPedido_Click(object sender, EventArgs e)
        {
            if(listBoxPedidos.SelectedItem == null)
            {
                MessageBox.Show("Tem de selecionar um pedido");
            }
            else
            {
                Pedido pedido = (Pedido)listBoxPedidos.SelectedItem;
                pedido.Estado.EstadoInt = 4;
                GereRestauranteContainer.SaveChanges();
                this.Close();
            }      
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBoxPedidos.SelectedItem == null)
            {
                MessageBox.Show("Tem de selecionar um pedido");
            }
            else
            {
                Pedido pedido = (Pedido)listBoxPedidos.SelectedItem;
                var txt = " Pedido Nº " + pedido.Id + Environment.NewLine + " Cliente: " + pedido.Cliente.ToString() + Environment.NewLine + " Menu: " + pedido.ItemMenu.ToString() + Environment.NewLine + " Metodo de pagamento: " + pedido.Pagamento.ToString() + Environment.NewLine + " Restaurante: " + pedido.Restaurante.ToString() + Environment.NewLine + " Trabalhador: " + pedido.Trabalhador.ToString() + Environment.NewLine + " Valor Total: " + pedido.ValorTotal.ToString();
                ficheiros(txt);

                this.Close();
            }
        }

        public static void ficheiros(string txt)
        {
            string path = @"Pedido.txt";
            File.WriteAllText(path, txt + Environment.NewLine, Encoding.UTF8);
        }
        
    }
}
