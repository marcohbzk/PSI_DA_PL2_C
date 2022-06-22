
namespace da_pl2_projeto
{
    partial class FormularioGestaoClientes
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
            this.btnRegistarCliente = new System.Windows.Forms.Button();
            this.btnApagarCliente = new System.Windows.Forms.Button();
            this.btnEditarCliente = new System.Windows.Forms.Button();
            this.dataGridViewClientes = new System.Windows.Forms.DataGridView();
            this.labelNomeCliente = new System.Windows.Forms.Label();
            this.labelNifCliente = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxNomeCliente = new System.Windows.Forms.TextBox();
            this.textBoxNifCliente = new System.Windows.Forms.TextBox();
            this.textBoxTelefoneCliente = new System.Windows.Forms.TextBox();
            this.textBoxRuaCliente = new System.Windows.Forms.TextBox();
            this.textBoxCidadeCliente = new System.Windows.Forms.TextBox();
            this.textBoxCodPostalCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPaisCliente = new System.Windows.Forms.TextBox();
            this.textBoxTotalGastoCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegistarCliente
            // 
            this.btnRegistarCliente.Location = new System.Drawing.Point(11, 325);
            this.btnRegistarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistarCliente.Name = "btnRegistarCliente";
            this.btnRegistarCliente.Size = new System.Drawing.Size(89, 30);
            this.btnRegistarCliente.TabIndex = 0;
            this.btnRegistarCliente.Text = "Registar Cliente";
            this.btnRegistarCliente.UseVisualStyleBackColor = true;
            this.btnRegistarCliente.Click += new System.EventHandler(this.btnRegistarCliente_Click);
            // 
            // btnApagarCliente
            // 
            this.btnApagarCliente.Location = new System.Drawing.Point(197, 325);
            this.btnApagarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btnApagarCliente.Name = "btnApagarCliente";
            this.btnApagarCliente.Size = new System.Drawing.Size(89, 30);
            this.btnApagarCliente.TabIndex = 1;
            this.btnApagarCliente.Text = "Apagar Cliente";
            this.btnApagarCliente.UseVisualStyleBackColor = true;
            this.btnApagarCliente.Click += new System.EventHandler(this.btnApagarCliente_Click);
            // 
            // btnEditarCliente
            // 
            this.btnEditarCliente.Location = new System.Drawing.Point(104, 325);
            this.btnEditarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditarCliente.Name = "btnEditarCliente";
            this.btnEditarCliente.Size = new System.Drawing.Size(89, 30);
            this.btnEditarCliente.TabIndex = 2;
            this.btnEditarCliente.Text = "Update Cliente";
            this.btnEditarCliente.UseVisualStyleBackColor = true;
            this.btnEditarCliente.Click += new System.EventHandler(this.btnEditarCliente_Click);
            // 
            // dataGridViewClientes
            // 
            this.dataGridViewClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClientes.Location = new System.Drawing.Point(295, 12);
            this.dataGridViewClientes.MultiSelect = false;
            this.dataGridViewClientes.Name = "dataGridViewClientes";
            this.dataGridViewClientes.ReadOnly = true;
            this.dataGridViewClientes.RowHeadersWidth = 51;
            this.dataGridViewClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewClientes.Size = new System.Drawing.Size(293, 342);
            this.dataGridViewClientes.TabIndex = 3;
            this.dataGridViewClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewClientes_CellClick);
            // 
            // labelNomeCliente
            // 
            this.labelNomeCliente.AutoSize = true;
            this.labelNomeCliente.Location = new System.Drawing.Point(12, 28);
            this.labelNomeCliente.Name = "labelNomeCliente";
            this.labelNomeCliente.Size = new System.Drawing.Size(38, 13);
            this.labelNomeCliente.TabIndex = 4;
            this.labelNomeCliente.Text = "Nome:";
            // 
            // labelNifCliente
            // 
            this.labelNifCliente.AutoSize = true;
            this.labelNifCliente.Location = new System.Drawing.Point(12, 54);
            this.labelNifCliente.Name = "labelNifCliente";
            this.labelNifCliente.Size = new System.Drawing.Size(27, 13);
            this.labelNifCliente.TabIndex = 5;
            this.labelNifCliente.Text = "NIF:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Telefone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Rua:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cidade:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Cod. Postal:";
            // 
            // textBoxNomeCliente
            // 
            this.textBoxNomeCliente.Location = new System.Drawing.Point(104, 21);
            this.textBoxNomeCliente.Name = "textBoxNomeCliente";
            this.textBoxNomeCliente.Size = new System.Drawing.Size(185, 20);
            this.textBoxNomeCliente.TabIndex = 10;
            // 
            // textBoxNifCliente
            // 
            this.textBoxNifCliente.Location = new System.Drawing.Point(104, 47);
            this.textBoxNifCliente.Name = "textBoxNifCliente";
            this.textBoxNifCliente.Size = new System.Drawing.Size(185, 20);
            this.textBoxNifCliente.TabIndex = 11;
            // 
            // textBoxTelefoneCliente
            // 
            this.textBoxTelefoneCliente.Location = new System.Drawing.Point(104, 73);
            this.textBoxTelefoneCliente.Name = "textBoxTelefoneCliente";
            this.textBoxTelefoneCliente.Size = new System.Drawing.Size(185, 20);
            this.textBoxTelefoneCliente.TabIndex = 12;
            // 
            // textBoxRuaCliente
            // 
            this.textBoxRuaCliente.Location = new System.Drawing.Point(104, 99);
            this.textBoxRuaCliente.Name = "textBoxRuaCliente";
            this.textBoxRuaCliente.Size = new System.Drawing.Size(185, 20);
            this.textBoxRuaCliente.TabIndex = 13;
            // 
            // textBoxCidadeCliente
            // 
            this.textBoxCidadeCliente.Location = new System.Drawing.Point(104, 125);
            this.textBoxCidadeCliente.Name = "textBoxCidadeCliente";
            this.textBoxCidadeCliente.Size = new System.Drawing.Size(185, 20);
            this.textBoxCidadeCliente.TabIndex = 14;
            // 
            // textBoxCodPostalCliente
            // 
            this.textBoxCodPostalCliente.Location = new System.Drawing.Point(104, 151);
            this.textBoxCodPostalCliente.Name = "textBoxCodPostalCliente";
            this.textBoxCodPostalCliente.Size = new System.Drawing.Size(185, 20);
            this.textBoxCodPostalCliente.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "País:";
            // 
            // textBoxPaisCliente
            // 
            this.textBoxPaisCliente.Location = new System.Drawing.Point(104, 177);
            this.textBoxPaisCliente.Name = "textBoxPaisCliente";
            this.textBoxPaisCliente.Size = new System.Drawing.Size(185, 20);
            this.textBoxPaisCliente.TabIndex = 17;
            // 
            // textBoxTotalGastoCliente
            // 
            this.textBoxTotalGastoCliente.Location = new System.Drawing.Point(104, 203);
            this.textBoxTotalGastoCliente.Name = "textBoxTotalGastoCliente";
            this.textBoxTotalGastoCliente.Size = new System.Drawing.Size(185, 20);
            this.textBoxTotalGastoCliente.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Total Gasto:";
            // 
            // FormularioGestaoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxTotalGastoCliente);
            this.Controls.Add(this.textBoxPaisCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCodPostalCliente);
            this.Controls.Add(this.textBoxCidadeCliente);
            this.Controls.Add(this.textBoxRuaCliente);
            this.Controls.Add(this.textBoxTelefoneCliente);
            this.Controls.Add(this.textBoxNifCliente);
            this.Controls.Add(this.textBoxNomeCliente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelNifCliente);
            this.Controls.Add(this.labelNomeCliente);
            this.Controls.Add(this.dataGridViewClientes);
            this.Controls.Add(this.btnEditarCliente);
            this.Controls.Add(this.btnApagarCliente);
            this.Controls.Add(this.btnRegistarCliente);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormularioGestaoClientes";
            this.Text = "FormularioGestaoClientes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormularioGestaoClientes_FormClosing);
            this.Load += new System.EventHandler(this.FormularioGestaoClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegistarCliente;
        private System.Windows.Forms.Button btnApagarCliente;
        private System.Windows.Forms.Button btnEditarCliente;
        private System.Windows.Forms.DataGridView dataGridViewClientes;
        private System.Windows.Forms.Label labelNomeCliente;
        private System.Windows.Forms.Label labelNifCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxNomeCliente;
        private System.Windows.Forms.TextBox textBoxNifCliente;
        private System.Windows.Forms.TextBox textBoxTelefoneCliente;
        private System.Windows.Forms.TextBox textBoxRuaCliente;
        private System.Windows.Forms.TextBox textBoxCidadeCliente;
        private System.Windows.Forms.TextBox textBoxCodPostalCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPaisCliente;
        private System.Windows.Forms.TextBox textBoxTotalGastoCliente;
        private System.Windows.Forms.Label label2;
    }
}