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
    public partial class FormularioCriarPedido : Form
    {
        GereRestauranteContainer GereRestauranteContainer = new GereRestauranteContainer();
        public FormularioCriarPedido()
        {
            InitializeComponent();
        }

        private void FormularioCriarPedido_Load(object sender, EventArgs e)
        {
            LerDados();
        }

        private void btnRegistarMenu_Click(object sender, EventArgs e)
        {
            Pedido tempPedido = new Pedido();
            Restaurante restaurante = GereRestauranteContainer.Restaurantes.Find(FormularioPrincipal.idRest.Id);
            

            tempPedido.RestauranteId = FormularioPrincipal.idRest.Id;
          
            GereRestauranteContainer.PedidoSet.Add(tempPedido);

            GereRestauranteContainer.SaveChanges();
            LerDados();
        }

        private void LerDados()
        {
            List<Pedido> pedidos = new List<Pedido>();
            Pedido tempPedido = new Pedido();
            try
            {
                //Percorre todas as pessoas na base de dados
                foreach (Pedido pedido in GereRestauranteContainer.PedidoSet.ToList())
                {
                    pedidos.Add(pedido);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            dataGridViewPedidos.DataSource = pedidos; //Muda a datasource para a lista

            //TAMANHO DAS COLUNAS AUTOMATICAMENTE
            // Escolhe o tamanho da coluna indicada. Podes usar .AllCells ou .Fill
            dataGridViewPedidos.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewPedidos.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewPedidos.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewPedidos.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            // Depois da DataGrid calcular a largura da columa podemos então guardar a largura de cada coluna
            for (int i = 0; i <= dataGridViewPedidos.Columns.Count - 1; i++)
            {
                // Guardar a largura das colunas na variável:
                int colw = dataGridViewPedidos.Columns[i].Width;

                // Remover AutoSizing:
                dataGridViewPedidos.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

                // Alterar a largura para o valor do AutoSize:
                dataGridViewPedidos.Columns[i].Width = colw;
            }
        }
    }
}
