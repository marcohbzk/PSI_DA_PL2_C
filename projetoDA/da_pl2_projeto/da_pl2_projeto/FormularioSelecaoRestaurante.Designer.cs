﻿
namespace da_pl2_projeto
{
    partial class FormularioSelecaoRestaurante
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
            this.button1 = new System.Windows.Forms.Button();
            this.listBoxSelecionarRestaurante = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(129, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 62);
            this.button1.TabIndex = 0;
            this.button1.Text = "Selecionar:";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBoxSelecionarRestaurante
            // 
            this.listBoxSelecionarRestaurante.FormattingEnabled = true;
            this.listBoxSelecionarRestaurante.ItemHeight = 16;
            this.listBoxSelecionarRestaurante.Location = new System.Drawing.Point(391, 69);
            this.listBoxSelecionarRestaurante.Name = "listBoxSelecionarRestaurante";
            this.listBoxSelecionarRestaurante.Size = new System.Drawing.Size(299, 292);
            this.listBoxSelecionarRestaurante.TabIndex = 1;
            this.listBoxSelecionarRestaurante.SelectedIndexChanged += new System.EventHandler(this.listBoxSelecionarRestaurante_SelectedIndexChanged);
            // 
            // FormularioSelecaoRestaurante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxSelecionarRestaurante);
            this.Controls.Add(this.button1);
            this.Name = "FormularioSelecaoRestaurante";
            this.Text = "FormularioSelecaoRestaurante";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormularioSelecaoRestaurante_FormClosing);
            this.Load += new System.EventHandler(this.FormularioSelecaoRestaurante_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBoxSelecionarRestaurante;
    }
}