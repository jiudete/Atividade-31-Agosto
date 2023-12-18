namespace Exercicio6_31_08
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
            this.txt_cotacao = new System.Windows.Forms.TextBox();
            this.txt_dolar = new System.Windows.Forms.TextBox();
            this.lbl_cotacao = new System.Windows.Forms.Label();
            this.lbl_dolar = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_converter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_cotacao
            // 
            this.txt_cotacao.Location = new System.Drawing.Point(167, 112);
            this.txt_cotacao.Name = "txt_cotacao";
            this.txt_cotacao.Size = new System.Drawing.Size(118, 20);
            this.txt_cotacao.TabIndex = 0;
            // 
            // txt_dolar
            // 
            this.txt_dolar.Location = new System.Drawing.Point(144, 162);
            this.txt_dolar.Name = "txt_dolar";
            this.txt_dolar.Size = new System.Drawing.Size(141, 20);
            this.txt_dolar.TabIndex = 1;
            // 
            // lbl_cotacao
            // 
            this.lbl_cotacao.AutoSize = true;
            this.lbl_cotacao.Location = new System.Drawing.Point(68, 115);
            this.lbl_cotacao.Name = "lbl_cotacao";
            this.lbl_cotacao.Size = new System.Drawing.Size(93, 13);
            this.lbl_cotacao.TabIndex = 2;
            this.lbl_cotacao.Text = "Cotação do Dolar:";
            // 
            // lbl_dolar
            // 
            this.lbl_dolar.AutoSize = true;
            this.lbl_dolar.Location = new System.Drawing.Point(68, 165);
            this.lbl_dolar.Name = "lbl_dolar";
            this.lbl_dolar.Size = new System.Drawing.Size(70, 13);
            this.lbl_dolar.TabIndex = 3;
            this.lbl_dolar.Text = "Quant. Dolar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 46);
            this.label3.TabIndex = 4;
            this.label3.Text = "Conversão";
            // 
            // btn_converter
            // 
            this.btn_converter.Location = new System.Drawing.Point(144, 212);
            this.btn_converter.Name = "btn_converter";
            this.btn_converter.Size = new System.Drawing.Size(75, 23);
            this.btn_converter.TabIndex = 5;
            this.btn_converter.Text = "Converter";
            this.btn_converter.UseVisualStyleBackColor = true;
            this.btn_converter.Click += new System.EventHandler(this.btn_converter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 270);
            this.Controls.Add(this.btn_converter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_dolar);
            this.Controls.Add(this.lbl_cotacao);
            this.Controls.Add(this.txt_dolar);
            this.Controls.Add(this.txt_cotacao);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_cotacao;
        private System.Windows.Forms.TextBox txt_dolar;
        private System.Windows.Forms.Label lbl_cotacao;
        private System.Windows.Forms.Label lbl_dolar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_converter;
    }
}

