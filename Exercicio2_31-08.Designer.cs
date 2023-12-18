namespace Exercicio2_31_08
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
            this.txt_aresta = new System.Windows.Forms.TextBox();
            this.lbl_quadrado = new System.Windows.Forms.Label();
            this.lbl_aresta = new System.Windows.Forms.Label();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_aresta
            // 
            this.txt_aresta.Location = new System.Drawing.Point(88, 98);
            this.txt_aresta.Name = "txt_aresta";
            this.txt_aresta.Size = new System.Drawing.Size(100, 20);
            this.txt_aresta.TabIndex = 0;
            // 
            // lbl_quadrado
            // 
            this.lbl_quadrado.AutoSize = true;
            this.lbl_quadrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quadrado.Location = new System.Drawing.Point(24, 9);
            this.lbl_quadrado.Name = "lbl_quadrado";
            this.lbl_quadrado.Size = new System.Drawing.Size(205, 46);
            this.lbl_quadrado.TabIndex = 1;
            this.lbl_quadrado.Text = "Quadrado";
            // 
            // lbl_aresta
            // 
            this.lbl_aresta.AutoSize = true;
            this.lbl_aresta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_aresta.Location = new System.Drawing.Point(29, 99);
            this.lbl_aresta.Name = "lbl_aresta";
            this.lbl_aresta.Size = new System.Drawing.Size(53, 17);
            this.lbl_aresta.TabIndex = 2;
            this.lbl_aresta.Text = "Aresta:";
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(88, 155);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(75, 23);
            this.btn_calcular.TabIndex = 3;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 228);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.lbl_aresta);
            this.Controls.Add(this.lbl_quadrado);
            this.Controls.Add(this.txt_aresta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_aresta;
        private System.Windows.Forms.Label lbl_quadrado;
        private System.Windows.Forms.Label lbl_aresta;
        private System.Windows.Forms.Button btn_calcular;
    }
}

