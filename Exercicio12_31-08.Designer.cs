namespace Exercicio12_31_08
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
            this.txt_cat1 = new System.Windows.Forms.TextBox();
            this.txt_cat2 = new System.Windows.Forms.TextBox();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_cat1 = new System.Windows.Forms.Label();
            this.lbl_cat2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_cat1
            // 
            this.txt_cat1.Location = new System.Drawing.Point(135, 104);
            this.txt_cat1.Name = "txt_cat1";
            this.txt_cat1.Size = new System.Drawing.Size(119, 20);
            this.txt_cat1.TabIndex = 0;
            // 
            // txt_cat2
            // 
            this.txt_cat2.Location = new System.Drawing.Point(135, 158);
            this.txt_cat2.Name = "txt_cat2";
            this.txt_cat2.Size = new System.Drawing.Size(119, 20);
            this.txt_cat2.TabIndex = 1;
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(125, 219);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(75, 23);
            this.btn_calcular.TabIndex = 2;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "Triângulo";
            // 
            // lbl_cat1
            // 
            this.lbl_cat1.AutoSize = true;
            this.lbl_cat1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cat1.Location = new System.Drawing.Point(64, 105);
            this.lbl_cat1.Name = "lbl_cat1";
            this.lbl_cat1.Size = new System.Drawing.Size(65, 17);
            this.lbl_cat1.TabIndex = 4;
            this.lbl_cat1.Text = "Cateto 1:";
            // 
            // lbl_cat2
            // 
            this.lbl_cat2.AutoSize = true;
            this.lbl_cat2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cat2.Location = new System.Drawing.Point(64, 159);
            this.lbl_cat2.Name = "lbl_cat2";
            this.lbl_cat2.Size = new System.Drawing.Size(65, 17);
            this.lbl_cat2.TabIndex = 5;
            this.lbl_cat2.Text = "Cateto 2:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 284);
            this.Controls.Add(this.lbl_cat2);
            this.Controls.Add(this.lbl_cat1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.txt_cat2);
            this.Controls.Add(this.txt_cat1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_cat1;
        private System.Windows.Forms.TextBox txt_cat2;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_cat1;
        private System.Windows.Forms.Label lbl_cat2;
    }
}

