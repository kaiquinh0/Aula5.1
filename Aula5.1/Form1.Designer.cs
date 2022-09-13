namespace Aula5._1
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.boxNome = new System.Windows.Forms.Label();
            this.boxPais = new System.Windows.Forms.Label();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.boxTitulo = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.boxEstado = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(159, 56);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(600, 20);
            this.txtNome.TabIndex = 0;
            this.txtNome.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // boxNome
            // 
            this.boxNome.AutoSize = true;
            this.boxNome.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxNome.Location = new System.Drawing.Point(76, 53);
            this.boxNome.Name = "boxNome";
            this.boxNome.Size = new System.Drawing.Size(63, 23);
            this.boxNome.TabIndex = 1;
            this.boxNome.Text = "NOME";
            // 
            // boxPais
            // 
            this.boxPais.AutoSize = true;
            this.boxPais.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.boxPais.Location = new System.Drawing.Point(76, 97);
            this.boxPais.Name = "boxPais";
            this.boxPais.Size = new System.Drawing.Size(51, 23);
            this.boxPais.TabIndex = 3;
            this.boxPais.Text = "PAÍS";
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(159, 100);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(600, 20);
            this.txtPais.TabIndex = 2;
            this.txtPais.TextChanged += new System.EventHandler(this.txtPais_TextChanged_1);
            // 
            // boxTitulo
            // 
            this.boxTitulo.AutoSize = true;
            this.boxTitulo.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.boxTitulo.Location = new System.Drawing.Point(76, 187);
            this.boxTitulo.Name = "boxTitulo";
            this.boxTitulo.Size = new System.Drawing.Size(77, 23);
            this.boxTitulo.TabIndex = 7;
            this.boxTitulo.Text = "TÍTULO";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(159, 190);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(600, 20);
            this.txtTitulo.TabIndex = 6;
            // 
            // boxEstado
            // 
            this.boxEstado.AutoSize = true;
            this.boxEstado.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.boxEstado.Location = new System.Drawing.Point(76, 142);
            this.boxEstado.Name = "boxEstado";
            this.boxEstado.Size = new System.Drawing.Size(82, 23);
            this.boxEstado.TabIndex = 5;
            this.boxEstado.Text = "ESTADO";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(159, 146);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(600, 20);
            this.txtEstado.TabIndex = 4;
            // 
            // btnGravar
            // 
            this.btnGravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravar.Location = new System.Drawing.Point(287, 253);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(120, 41);
            this.btnGravar.TabIndex = 8;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(458, 253);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(120, 41);
            this.btnPesquisar.TabIndex = 9;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.boxTitulo);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.boxEstado);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.boxPais);
            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.boxNome);
            this.Controls.Add(this.txtNome);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label boxNome;
        private System.Windows.Forms.Label boxPais;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.Label boxTitulo;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label boxEstado;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnPesquisar;
    }
}

