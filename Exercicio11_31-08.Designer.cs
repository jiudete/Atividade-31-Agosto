namespace Exercicio11_31_08
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
            this.btn_calcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_lado1 = new System.Windows.Forms.Label();
            this.lbl_lado2 = new System.Windows.Forms.Label();
            this.lbl_lado3 = new System.Windows.Forms.Label();
            this.txt_lado1 = new System.Windows.Forms.TextBox();
            this.txt_lado2 = new System.Windows.Forms.TextBox();
            this.txt_lado3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(148, 258);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(75, 23);
            this.btn_calcular.TabIndex = 0;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 9);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(195, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Triângulo";
            // 
            // lbl_lado1
            // 
            this.lbl_lado1.AutoSize = true;
            this.lbl_lado1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lado1.Location = new System.Drawing.Point(62, 94);
            this.lbl_lado1.Name = "lbl_lado1";
            this.lbl_lado1.Size = new System.Drawing.Size(56, 17);
            this.lbl_lado1.TabIndex = 2;
            this.lbl_lado1.Text = "Lado 1:";
            // 
            // lbl_lado2
            // 
            this.lbl_lado2.AutoSize = true;
            this.lbl_lado2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lado2.Location = new System.Drawing.Point(62, 146);
            this.lbl_lado2.Name = "lbl_lado2";
            this.lbl_lado2.Size = new System.Drawing.Size(56, 17);
            this.lbl_lado2.TabIndex = 3;
            this.lbl_lado2.Text = "Lado 2:";
            // 
            // lbl_lado3
            // 
            this.lbl_lado3.AutoSize = true;
            this.lbl_lado3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lado3.Location = new System.Drawing.Point(62, 202);
            this.lbl_lado3.Name = "lbl_lado3";
            this.lbl_lado3.Size = new System.Drawing.Size(56, 17);
            this.lbl_lado3.TabIndex = 4;
            this.lbl_lado3.Text = "Lado 3:";
            // 
            // txt_lado1
            // 
            this.txt_lado1.Location = new System.Drawing.Point(124, 93);
            this.txt_lado1.Name = "txt_lado1";
            this.txt_lado1.Size = new System.Drawing.Size(172, 20);
            this.txt_lado1.TabIndex = 5;
            // 
            // txt_lado2
            // 
            this.txt_lado2.Location = new System.Drawing.Point(124, 145);
            this.txt_lado2.Name = "txt_lado2";
            this.txt_lado2.Size = new System.Drawing.Size(172, 20);
            this.txt_lado2.TabIndex = 6;
            // 
            // txt_lado3
            // 
            this.txt_lado3.Location = new System.Drawing.Point(124, 201);
            this.txt_lado3.Name = "txt_lado3";
            this.txt_lado3.Size = new System.Drawing.Size(172, 20);
            this.txt_lado3.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 323);
            this.Controls.Add(this.txt_lado3);
            this.Controls.Add(this.txt_lado2);
            this.Controls.Add(this.txt_lado1);
            this.Controls.Add(this.lbl_lado3);
            this.Controls.Add(this.lbl_lado2);
            this.Controls.Add(this.lbl_lado1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_calcular);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_lado1;
        private System.Windows.Forms.Label lbl_lado2;
        private System.Windows.Forms.Label lbl_lado3;
        private System.Windows.Forms.TextBox txt_lado1;
        private System.Windows.Forms.TextBox txt_lado2;
        private System.Windows.Forms.TextBox txt_lado3;
    }
}

