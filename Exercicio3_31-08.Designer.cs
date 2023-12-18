namespace Exercicio3_31_08
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_diagonal = new System.Windows.Forms.Label();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.txt_diagonal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quadrado";
            // 
            // lbl_diagonal
            // 
            this.lbl_diagonal.AutoSize = true;
            this.lbl_diagonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_diagonal.Location = new System.Drawing.Point(17, 94);
            this.lbl_diagonal.Name = "lbl_diagonal";
            this.lbl_diagonal.Size = new System.Drawing.Size(68, 17);
            this.lbl_diagonal.TabIndex = 1;
            this.lbl_diagonal.Text = "Diagonal:";
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(78, 152);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(75, 23);
            this.btn_calcular.TabIndex = 2;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // txt_diagonal
            // 
            this.txt_diagonal.Location = new System.Drawing.Point(91, 93);
            this.txt_diagonal.Name = "txt_diagonal";
            this.txt_diagonal.Size = new System.Drawing.Size(100, 20);
            this.txt_diagonal.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 233);
            this.Controls.Add(this.txt_diagonal);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.lbl_diagonal);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_diagonal;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.TextBox txt_diagonal;
    }
}

