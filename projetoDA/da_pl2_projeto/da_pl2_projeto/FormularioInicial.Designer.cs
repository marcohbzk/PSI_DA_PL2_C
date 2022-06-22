
namespace da_pl2_projeto
{
    partial class FormularioInicial
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
            this.btnSelecaoRestaurantes = new System.Windows.Forms.Button();
            this.btnGestaoClientes = new System.Windows.Forms.Button();
            this.btnGestaoPedidos = new System.Windows.Forms.Button();
            this.btnMenuRestaurantes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSelecaoRestaurantes
            // 
            this.btnSelecaoRestaurantes.Location = new System.Drawing.Point(235, 282);
            this.btnSelecaoRestaurantes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSelecaoRestaurantes.Name = "btnSelecaoRestaurantes";
            this.btnSelecaoRestaurantes.Size = new System.Drawing.Size(139, 123);
            this.btnSelecaoRestaurantes.TabIndex = 1;
            this.btnSelecaoRestaurantes.Text = "Gestao Trabalhadores";
            this.btnSelecaoRestaurantes.UseVisualStyleBackColor = true;
            this.btnSelecaoRestaurantes.Click += new System.EventHandler(this.btnSelecaoRestaurantes_Click);
            // 
            // btnGestaoClientes
            // 
            this.btnGestaoClientes.Location = new System.Drawing.Point(235, 107);
            this.btnGestaoClientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGestaoClientes.Name = "btnGestaoClientes";
            this.btnGestaoClientes.Size = new System.Drawing.Size(139, 123);
            this.btnGestaoClientes.TabIndex = 2;
            this.btnGestaoClientes.Text = "Gestao Clientes";
            this.btnGestaoClientes.UseVisualStyleBackColor = true;
            this.btnGestaoClientes.Click += new System.EventHandler(this.btnGestaoClientes_Click);
            // 
            // btnGestaoPedidos
            // 
            this.btnGestaoPedidos.Location = new System.Drawing.Point(431, 107);
            this.btnGestaoPedidos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGestaoPedidos.Name = "btnGestaoPedidos";
            this.btnGestaoPedidos.Size = new System.Drawing.Size(139, 123);
            this.btnGestaoPedidos.TabIndex = 3;
            this.btnGestaoPedidos.Text = "Gestao Pedidos";
            this.btnGestaoPedidos.UseVisualStyleBackColor = true;
            this.btnGestaoPedidos.Click += new System.EventHandler(this.btnGestaoPedidos_Click);
            // 
            // btnMenuRestaurantes
            // 
            this.btnMenuRestaurantes.Location = new System.Drawing.Point(431, 282);
            this.btnMenuRestaurantes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMenuRestaurantes.Name = "btnMenuRestaurantes";
            this.btnMenuRestaurantes.Size = new System.Drawing.Size(139, 123);
            this.btnMenuRestaurantes.TabIndex = 4;
            this.btnMenuRestaurantes.Text = "Menu Restaurantes";
            this.btnMenuRestaurantes.UseVisualStyleBackColor = true;
            this.btnMenuRestaurantes.Click += new System.EventHandler(this.btnMenuRestaurantes_Click);
            // 
            // FormularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMenuRestaurantes);
            this.Controls.Add(this.btnGestaoPedidos);
            this.Controls.Add(this.btnGestaoClientes);
            this.Controls.Add(this.btnSelecaoRestaurantes);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormularioPrincipal";
            this.Text = "FormularioPrincipal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormularioPrinciapl_FormClosing);
            this.Load += new System.EventHandler(this.FormularioPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSelecaoRestaurantes;
        private System.Windows.Forms.Button btnGestaoClientes;
        private System.Windows.Forms.Button btnGestaoPedidos;
        private System.Windows.Forms.Button btnMenuRestaurantes;
    }
}