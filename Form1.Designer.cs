namespace filtrar_input
{
    partial class Window_text_filter
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.botao_retirar_tracos_e_pontos = new System.Windows.Forms.Button();
            this.botao_colocar_em_modo_titulo = new System.Windows.Forms.Button();
            this.botao_visitar_git = new System.Windows.Forms.Button();
            this.label_mensagem_direcionamento = new System.Windows.Forms.Label();
            this.line_edit_texto = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // botao_retirar_tracos_e_pontos
            // 
            this.botao_retirar_tracos_e_pontos.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.botao_retirar_tracos_e_pontos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao_retirar_tracos_e_pontos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.botao_retirar_tracos_e_pontos.Location = new System.Drawing.Point(23, 68);
            this.botao_retirar_tracos_e_pontos.MinimumSize = new System.Drawing.Size(296, 0);
            this.botao_retirar_tracos_e_pontos.Name = "botao_retirar_tracos_e_pontos";
            this.botao_retirar_tracos_e_pontos.Size = new System.Drawing.Size(296, 49);
            this.botao_retirar_tracos_e_pontos.TabIndex = 0;
            this.botao_retirar_tracos_e_pontos.Text = "Retirar \'.\'  \'-\' e \',\' ";
            this.botao_retirar_tracos_e_pontos.UseVisualStyleBackColor = false;
            this.botao_retirar_tracos_e_pontos.Click += new System.EventHandler(this.botao_retirar_tracos_e_pontos_Click);
            // 
            // botao_colocar_em_modo_titulo
            // 
            this.botao_colocar_em_modo_titulo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.botao_colocar_em_modo_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao_colocar_em_modo_titulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.botao_colocar_em_modo_titulo.Location = new System.Drawing.Point(23, 13);
            this.botao_colocar_em_modo_titulo.MinimumSize = new System.Drawing.Size(296, 0);
            this.botao_colocar_em_modo_titulo.Name = "botao_colocar_em_modo_titulo";
            this.botao_colocar_em_modo_titulo.Size = new System.Drawing.Size(296, 49);
            this.botao_colocar_em_modo_titulo.TabIndex = 1;
            this.botao_colocar_em_modo_titulo.Text = "Colocar em modo titulo";
            this.botao_colocar_em_modo_titulo.UseVisualStyleBackColor = false;
            this.botao_colocar_em_modo_titulo.Click += new System.EventHandler(this.botao_colocar_em_modo_titulo_Click);
            // 
            // botao_visitar_git
            // 
            this.botao_visitar_git.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.botao_visitar_git.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao_visitar_git.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.botao_visitar_git.Image = global::filtrar_input.Properties.Resources.github;
            this.botao_visitar_git.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botao_visitar_git.Location = new System.Drawing.Point(23, 134);
            this.botao_visitar_git.MinimumSize = new System.Drawing.Size(296, 0);
            this.botao_visitar_git.Name = "botao_visitar_git";
            this.botao_visitar_git.Size = new System.Drawing.Size(296, 56);
            this.botao_visitar_git.TabIndex = 2;
            this.botao_visitar_git.Text = "Visite Meu Github";
            this.botao_visitar_git.UseVisualStyleBackColor = false;
            this.botao_visitar_git.Click += new System.EventHandler(this.botao_visitar_git_Click);
            // 
            // label_mensagem_direcionamento
            // 
            this.label_mensagem_direcionamento.AutoSize = true;
            this.label_mensagem_direcionamento.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label_mensagem_direcionamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_mensagem_direcionamento.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_mensagem_direcionamento.Location = new System.Drawing.Point(23, 14);
            this.label_mensagem_direcionamento.MinimumSize = new System.Drawing.Size(296, 0);
            this.label_mensagem_direcionamento.Name = "label_mensagem_direcionamento";
            this.label_mensagem_direcionamento.Size = new System.Drawing.Size(296, 20);
            this.label_mensagem_direcionamento.TabIndex = 3;
            this.label_mensagem_direcionamento.Text = "Coloque o texto a ser filtrado";
            this.label_mensagem_direcionamento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_mensagem_direcionamento.Click += new System.EventHandler(this.label1_Click);
            // 
            // line_edit_texto
            // 
            this.line_edit_texto.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.line_edit_texto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.line_edit_texto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.line_edit_texto.Location = new System.Drawing.Point(23, 50);
            this.line_edit_texto.MinimumSize = new System.Drawing.Size(200, 4);
            this.line_edit_texto.Name = "line_edit_texto";
            this.line_edit_texto.Size = new System.Drawing.Size(296, 26);
            this.line_edit_texto.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 330);
            this.panel1.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.botao_colocar_em_modo_titulo);
            this.panel3.Controls.Add(this.botao_visitar_git);
            this.panel3.Controls.Add(this.botao_retirar_tracos_e_pontos);
            this.panel3.Location = new System.Drawing.Point(12, 109);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(336, 209);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label_mensagem_direcionamento);
            this.panel2.Controls.Add(this.line_edit_texto);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(336, 91);
            this.panel2.TabIndex = 0;
            // 
            // Window_text_filter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 330);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(379, 369);
            this.MinimumSize = new System.Drawing.Size(379, 369);
            this.Name = "Window_text_filter";
            this.Text = "Filtrar Texto";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botao_retirar_tracos_e_pontos;
        private System.Windows.Forms.Button botao_colocar_em_modo_titulo;
        private System.Windows.Forms.Button botao_visitar_git;
        private System.Windows.Forms.Label label_mensagem_direcionamento;
        private System.Windows.Forms.TextBox line_edit_texto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
    }
}

