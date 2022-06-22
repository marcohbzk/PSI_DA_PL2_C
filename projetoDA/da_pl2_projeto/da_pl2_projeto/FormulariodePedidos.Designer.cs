
namespace da_pl2_projeto
{
    partial class FormulariodePedidos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewClientes = new System.Windows.Forms.DataGridView();
            this.labelCliente = new System.Windows.Forms.Label();
            this.labelTrabalhadores = new System.Windows.Forms.Label();
            this.listBoxItensMenu = new System.Windows.Forms.ListBox();
            this.listBoxItensPedido = new System.Windows.Forms.ListBox();
            this.labelRestaurante = new System.Windows.Forms.Label();
            this.labelPedido = new System.Windows.Forms.Label();
            this.listBoxPedidosEmProcessamento = new System.Windows.Forms.ListBox();
            this.labelEmProcess = new System.Windows.Forms.Label();
            this.listBoxPedidosAPagar = new System.Windows.Forms.ListBox();
            this.labelPedidosAPagar = new System.Windows.Forms.Label();
            this.labelMetodosPagamento = new System.Windows.Forms.Label();
            this.comboBoxMetodoPagamento = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAdicionarValor = new System.Windows.Forms.Button();
            this.listBoxPedidos = new System.Windows.Forms.ListBox();
            this.btnCancelarPedido = new System.Windows.Forms.Button();
            this.btnFinalizarPedido = new System.Windows.Forms.Button();
            this.btnAdicionarItemPedido = new System.Windows.Forms.Button();
            this.btnConcluirPedido = new System.Windows.Forms.Button();
            this.btnRemoverMetodo = new System.Windows.Forms.Button();
            this.btnCriarPedido = new System.Windows.Forms.Button();
            this.dataGridViewTrabalhadores = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrabalhadores)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewClientes
            // 
            this.dataGridViewClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClientes.Location = new System.Drawing.Point(26, 25);
            this.dataGridViewClientes.Name = "dataGridViewClientes";
            this.dataGridViewClientes.RowHeadersWidth = 51;
            this.dataGridViewClientes.Size = new System.Drawing.Size(290, 228);
            this.dataGridViewClientes.TabIndex = 0;
            // 
            // labelCliente
            // 
            this.labelCliente.AutoSize = true;
            this.labelCliente.Location = new System.Drawing.Point(23, 9);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(47, 13);
            this.labelCliente.TabIndex = 1;
            this.labelCliente.Text = "Clientes:";
            // 
            // labelTrabalhadores
            // 
            this.labelTrabalhadores.AutoSize = true;
            this.labelTrabalhadores.Location = new System.Drawing.Point(23, 257);
            this.labelTrabalhadores.Name = "labelTrabalhadores";
            this.labelTrabalhadores.Size = new System.Drawing.Size(78, 13);
            this.labelTrabalhadores.TabIndex = 2;
            this.labelTrabalhadores.Text = "Trabalhadores:";
            // 
            // listBoxItensMenu
            // 
            this.listBoxItensMenu.FormattingEnabled = true;
            this.listBoxItensMenu.Location = new System.Drawing.Point(356, 25);
            this.listBoxItensMenu.Name = "listBoxItensMenu";
            this.listBoxItensMenu.Size = new System.Drawing.Size(290, 199);
            this.listBoxItensMenu.TabIndex = 4;
            // 
            // listBoxItensPedido
            // 
            this.listBoxItensPedido.FormattingEnabled = true;
            this.listBoxItensPedido.Location = new System.Drawing.Point(356, 275);
            this.listBoxItensPedido.Name = "listBoxItensPedido";
            this.listBoxItensPedido.Size = new System.Drawing.Size(290, 199);
            this.listBoxItensPedido.TabIndex = 5;
            // 
            // labelRestaurante
            // 
            this.labelRestaurante.AutoSize = true;
            this.labelRestaurante.Location = new System.Drawing.Point(353, 9);
            this.labelRestaurante.Name = "labelRestaurante";
            this.labelRestaurante.Size = new System.Drawing.Size(113, 13);
            this.labelRestaurante.TabIndex = 6;
            this.labelRestaurante.Text = "Menu do Restaurante:";
            // 
            // labelPedido
            // 
            this.labelPedido.AutoSize = true;
            this.labelPedido.Location = new System.Drawing.Point(353, 257);
            this.labelPedido.Name = "labelPedido";
            this.labelPedido.Size = new System.Drawing.Size(43, 13);
            this.labelPedido.TabIndex = 7;
            this.labelPedido.Text = "Pedido:";
            // 
            // listBoxPedidosEmProcessamento
            // 
            this.listBoxPedidosEmProcessamento.FormattingEnabled = true;
            this.listBoxPedidosEmProcessamento.Location = new System.Drawing.Point(689, 25);
            this.listBoxPedidosEmProcessamento.Name = "listBoxPedidosEmProcessamento";
            this.listBoxPedidosEmProcessamento.Size = new System.Drawing.Size(290, 420);
            this.listBoxPedidosEmProcessamento.TabIndex = 8;
            // 
            // labelEmProcess
            // 
            this.labelEmProcess.AutoSize = true;
            this.labelEmProcess.Location = new System.Drawing.Point(686, 9);
            this.labelEmProcess.Name = "labelEmProcess";
            this.labelEmProcess.Size = new System.Drawing.Size(142, 13);
            this.labelEmProcess.TabIndex = 9;
            this.labelEmProcess.Text = "Pedidos Em Processamento:";
            // 
            // listBoxPedidosAPagar
            // 
            this.listBoxPedidosAPagar.FormattingEnabled = true;
            this.listBoxPedidosAPagar.Location = new System.Drawing.Point(1049, 25);
            this.listBoxPedidosAPagar.Name = "listBoxPedidosAPagar";
            this.listBoxPedidosAPagar.Size = new System.Drawing.Size(290, 173);
            this.listBoxPedidosAPagar.TabIndex = 10;
            // 
            // labelPedidosAPagar
            // 
            this.labelPedidosAPagar.AutoSize = true;
            this.labelPedidosAPagar.Location = new System.Drawing.Point(1046, 9);
            this.labelPedidosAPagar.Name = "labelPedidosAPagar";
            this.labelPedidosAPagar.Size = new System.Drawing.Size(88, 13);
            this.labelPedidosAPagar.TabIndex = 11;
            this.labelPedidosAPagar.Text = "Pedidos a Pagar:";
            // 
            // labelMetodosPagamento
            // 
            this.labelMetodosPagamento.AutoSize = true;
            this.labelMetodosPagamento.Location = new System.Drawing.Point(1046, 201);
            this.labelMetodosPagamento.Name = "labelMetodosPagamento";
            this.labelMetodosPagamento.Size = new System.Drawing.Size(118, 13);
            this.labelMetodosPagamento.TabIndex = 12;
            this.labelMetodosPagamento.Text = "Método de Pagamento:";
            // 
            // comboBoxMetodoPagamento
            // 
            this.comboBoxMetodoPagamento.DisplayMember = "Paypal";
            this.comboBoxMetodoPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMetodoPagamento.FormattingEnabled = true;
            this.comboBoxMetodoPagamento.Items.AddRange(new object[] {
            "Paypal",
            "MBWay",
            "Cartão Almoço",
            "Cartão de Crédito",
            "Cartão de Débito"});
            this.comboBoxMetodoPagamento.Location = new System.Drawing.Point(1049, 217);
            this.comboBoxMetodoPagamento.Name = "comboBoxMetodoPagamento";
            this.comboBoxMetodoPagamento.Size = new System.Drawing.Size(290, 21);
            this.comboBoxMetodoPagamento.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1184, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Montante a Pagar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1288, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "<valor> €";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1049, 257);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(290, 20);
            this.textBox1.TabIndex = 16;
            // 
            // btnAdicionarValor
            // 
            this.btnAdicionarValor.Location = new System.Drawing.Point(1047, 299);
            this.btnAdicionarValor.Name = "btnAdicionarValor";
            this.btnAdicionarValor.Size = new System.Drawing.Size(292, 23);
            this.btnAdicionarValor.TabIndex = 17;
            this.btnAdicionarValor.Text = "Adicionar Valor";
            this.btnAdicionarValor.UseVisualStyleBackColor = true;
            // 
            // listBoxPedidos
            // 
            this.listBoxPedidos.FormattingEnabled = true;
            this.listBoxPedidos.Location = new System.Drawing.Point(1049, 337);
            this.listBoxPedidos.Name = "listBoxPedidos";
            this.listBoxPedidos.Size = new System.Drawing.Size(290, 108);
            this.listBoxPedidos.TabIndex = 18;
            // 
            // btnCancelarPedido
            // 
            this.btnCancelarPedido.Location = new System.Drawing.Point(689, 451);
            this.btnCancelarPedido.Name = "btnCancelarPedido";
            this.btnCancelarPedido.Size = new System.Drawing.Size(290, 23);
            this.btnCancelarPedido.TabIndex = 19;
            this.btnCancelarPedido.Text = "Cancelar Pedido";
            this.btnCancelarPedido.UseVisualStyleBackColor = true;
            this.btnCancelarPedido.Click += new System.EventHandler(this.btnCancelarPedido_Click);
            // 
            // btnFinalizarPedido
            // 
            this.btnFinalizarPedido.Location = new System.Drawing.Point(689, 480);
            this.btnFinalizarPedido.Name = "btnFinalizarPedido";
            this.btnFinalizarPedido.Size = new System.Drawing.Size(290, 23);
            this.btnFinalizarPedido.TabIndex = 20;
            this.btnFinalizarPedido.Text = "Finalizar Pedido";
            this.btnFinalizarPedido.UseVisualStyleBackColor = true;
            // 
            // btnAdicionarItemPedido
            // 
            this.btnAdicionarItemPedido.Location = new System.Drawing.Point(356, 230);
            this.btnAdicionarItemPedido.Name = "btnAdicionarItemPedido";
            this.btnAdicionarItemPedido.Size = new System.Drawing.Size(290, 23);
            this.btnAdicionarItemPedido.TabIndex = 21;
            this.btnAdicionarItemPedido.Text = "Adicionar Item";
            this.btnAdicionarItemPedido.UseVisualStyleBackColor = true;
            this.btnAdicionarItemPedido.Click += new System.EventHandler(this.btnAdicionarItemPedido_Click);
            // 
            // btnConcluirPedido
            // 
            this.btnConcluirPedido.Location = new System.Drawing.Point(1047, 451);
            this.btnConcluirPedido.Name = "btnConcluirPedido";
            this.btnConcluirPedido.Size = new System.Drawing.Size(292, 23);
            this.btnConcluirPedido.TabIndex = 22;
            this.btnConcluirPedido.Text = "Concluir";
            this.btnConcluirPedido.UseVisualStyleBackColor = true;
            // 
            // btnRemoverMetodo
            // 
            this.btnRemoverMetodo.Location = new System.Drawing.Point(1047, 480);
            this.btnRemoverMetodo.Name = "btnRemoverMetodo";
            this.btnRemoverMetodo.Size = new System.Drawing.Size(292, 23);
            this.btnRemoverMetodo.TabIndex = 23;
            this.btnRemoverMetodo.Text = "Remover Metodo";
            this.btnRemoverMetodo.UseVisualStyleBackColor = true;
            // 
            // btnCriarPedido
            // 
            this.btnCriarPedido.Location = new System.Drawing.Point(356, 480);
            this.btnCriarPedido.Name = "btnCriarPedido";
            this.btnCriarPedido.Size = new System.Drawing.Size(290, 23);
            this.btnCriarPedido.TabIndex = 24;
            this.btnCriarPedido.Text = "Criar Pedido";
            this.btnCriarPedido.UseVisualStyleBackColor = true;
            this.btnCriarPedido.Click += new System.EventHandler(this.btnCriarPedido_Click);
            // 
            // dataGridViewTrabalhadores
            // 
            this.dataGridViewTrabalhadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTrabalhadores.Location = new System.Drawing.Point(26, 275);
            this.dataGridViewTrabalhadores.Name = "dataGridViewTrabalhadores";
            this.dataGridViewTrabalhadores.RowHeadersWidth = 51;
            this.dataGridViewTrabalhadores.Size = new System.Drawing.Size(290, 228);
            this.dataGridViewTrabalhadores.TabIndex = 25;
            // 
            // FormulariodePedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 511);
            this.Controls.Add(this.dataGridViewTrabalhadores);
            this.Controls.Add(this.btnCriarPedido);
            this.Controls.Add(this.btnRemoverMetodo);
            this.Controls.Add(this.btnConcluirPedido);
            this.Controls.Add(this.btnAdicionarItemPedido);
            this.Controls.Add(this.btnFinalizarPedido);
            this.Controls.Add(this.btnCancelarPedido);
            this.Controls.Add(this.listBoxPedidos);
            this.Controls.Add(this.btnAdicionarValor);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxMetodoPagamento);
            this.Controls.Add(this.labelMetodosPagamento);
            this.Controls.Add(this.labelPedidosAPagar);
            this.Controls.Add(this.listBoxPedidosAPagar);
            this.Controls.Add(this.labelEmProcess);
            this.Controls.Add(this.listBoxPedidosEmProcessamento);
            this.Controls.Add(this.labelPedido);
            this.Controls.Add(this.labelRestaurante);
            this.Controls.Add(this.listBoxItensPedido);
            this.Controls.Add(this.listBoxItensMenu);
            this.Controls.Add(this.labelTrabalhadores);
            this.Controls.Add(this.labelCliente);
            this.Controls.Add(this.dataGridViewClientes);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormulariodePedidos";
            this.Text = "FormulariodePedidos ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormulariodePedidos_FormClosing);
            this.Load += new System.EventHandler(this.FormulariodePedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrabalhadores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewClientes;
        private System.Windows.Forms.Label labelCliente;
        private System.Windows.Forms.Label labelTrabalhadores;
        private System.Windows.Forms.ListBox listBoxItensMenu;
        private System.Windows.Forms.ListBox listBoxItensPedido;
        private System.Windows.Forms.Label labelRestaurante;
        private System.Windows.Forms.Label labelPedido;
        private System.Windows.Forms.ListBox listBoxPedidosEmProcessamento;
        private System.Windows.Forms.Label labelEmProcess;
        private System.Windows.Forms.ListBox listBoxPedidosAPagar;
        private System.Windows.Forms.Label labelPedidosAPagar;
        private System.Windows.Forms.Label labelMetodosPagamento;
        private System.Windows.Forms.ComboBox comboBoxMetodoPagamento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnAdicionarValor;
        private System.Windows.Forms.ListBox listBoxPedidos;
        private System.Windows.Forms.Button btnCancelarPedido;
        private System.Windows.Forms.Button btnFinalizarPedido;
        private System.Windows.Forms.Button btnAdicionarItemPedido;
        private System.Windows.Forms.Button btnConcluirPedido;
        private System.Windows.Forms.Button btnRemoverMetodo;
        private System.Windows.Forms.Button btnCriarPedido;
        private System.Windows.Forms.DataGridView dataGridViewTrabalhadores;
    }
}