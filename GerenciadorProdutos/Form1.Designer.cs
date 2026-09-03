namespace GerenciadorProdutos
{
    partial class Form1
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
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_precoNome = new System.Windows.Forms.TextBox();
            this.cmb_Tipo = new System.Windows.Forms.ComboBox();
            this.txt_atributoEspecifico = new System.Windows.Forms.TextBox();
            this.lbl_atributo = new System.Windows.Forms.Label();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(69, 94);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(100, 20);
            this.txt_nome.TabIndex = 0;
            // 
            // txt_precoNome
            // 
            this.txt_precoNome.Location = new System.Drawing.Point(326, 94);
            this.txt_precoNome.Name = "txt_precoNome";
            this.txt_precoNome.Size = new System.Drawing.Size(100, 20);
            this.txt_precoNome.TabIndex = 1;
            // 
            // cmb_Tipo
            // 
            this.cmb_Tipo.FormattingEnabled = true;
            this.cmb_Tipo.Items.AddRange(new object[] {
            "Físico",
            "Digital"});
            this.cmb_Tipo.Location = new System.Drawing.Point(247, 208);
            this.cmb_Tipo.Name = "cmb_Tipo";
            this.cmb_Tipo.Size = new System.Drawing.Size(121, 21);
            this.cmb_Tipo.TabIndex = 2;
            // 
            // txt_atributoEspecifico
            // 
            this.txt_atributoEspecifico.Location = new System.Drawing.Point(532, 94);
            this.txt_atributoEspecifico.Name = "txt_atributoEspecifico";
            this.txt_atributoEspecifico.Size = new System.Drawing.Size(100, 20);
            this.txt_atributoEspecifico.TabIndex = 3;
            // 
            // lbl_atributo
            // 
            this.lbl_atributo.AutoSize = true;
            this.lbl_atributo.Location = new System.Drawing.Point(400, 216);
            this.lbl_atributo.Name = "lbl_atributo";
            this.lbl_atributo.Size = new System.Drawing.Size(35, 13);
            this.lbl_atributo.TabIndex = 4;
            this.lbl_atributo.Text = "label1";
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(339, 256);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(75, 23);
            this.btn_salvar.TabIndex = 5;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.lbl_atributo);
            this.Controls.Add(this.txt_atributoEspecifico);
            this.Controls.Add(this.cmb_Tipo);
            this.Controls.Add(this.txt_precoNome);
            this.Controls.Add(this.txt_nome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_precoNome;
        private System.Windows.Forms.ComboBox cmb_Tipo;
        private System.Windows.Forms.TextBox txt_atributoEspecifico;
        private System.Windows.Forms.Label lbl_atributo;
        private System.Windows.Forms.Button btn_salvar;
    }
}

