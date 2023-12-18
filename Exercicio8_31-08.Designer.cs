namespace Exercicio7_31_08
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
            this.lbl_numero1 = new System.Windows.Forms.Label();
            this.lbl_numero2 = new System.Windows.Forms.Label();
            this.txt_numero1 = new System.Windows.Forms.TextBox();
            this.txt_numero2 = new System.Windows.Forms.TextBox();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Maior";
            // 
            // lbl_numero1
            // 
            this.lbl_numero1.AutoSize = true;
            this.lbl_numero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numero1.Location = new System.Drawing.Point(50, 103);
            this.lbl_numero1.Name = "lbl_numero1";
            this.lbl_numero1.Size = new System.Drawing.Size(74, 17);
            this.lbl_numero1.TabIndex = 1;
            this.lbl_numero1.Text = "Numero 1:";
            // 
            // lbl_numero2
            // 
            this.lbl_numero2.AutoSize = true;
            this.lbl_numero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numero2.Location = new System.Drawing.Point(50, 142);
            this.lbl_numero2.Name = "lbl_numero2";
            this.lbl_numero2.Size = new System.Drawing.Size(74, 17);
            this.lbl_numero2.TabIndex = 2;
            this.lbl_numero2.Text = "Numero 2:";
            // 
            // txt_numero1
            // 
            this.txt_numero1.Location = new System.Drawing.Point(130, 102);
            this.txt_numero1.Name = "txt_numero1";
            this.txt_numero1.Size = new System.Drawing.Size(134, 20);
            this.txt_numero1.TabIndex = 3;
            // 
            // txt_numero2
            // 
            this.txt_numero2.Location = new System.Drawing.Point(130, 141);
            this.txt_numero2.Name = "txt_numero2";
            this.txt_numero2.Size = new System.Drawing.Size(134, 20);
            this.txt_numero2.TabIndex = 4;
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.Location = new System.Drawing.Point(130, 196);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(75, 23);
            this.btn_confirmar.TabIndex = 5;
            this.btn_confirmar.Text = "Confirmar";
            this.btn_confirmar.UseVisualStyleBackColor = true;
            this.btn_confirmar.Click += new System.EventHandler(this.btn_confirmar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 256);
            this.Controls.Add(this.btn_confirmar);
            this.Controls.Add(this.txt_numero2);
            this.Controls.Add(this.txt_numero1);
            this.Controls.Add(this.lbl_numero2);
            this.Controls.Add(this.lbl_numero1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_numero1;
        private System.Windows.Forms.Label lbl_numero2;
        private System.Windows.Forms.TextBox txt_numero1;
        private System.Windows.Forms.TextBox txt_numero2;
        private System.Windows.Forms.Button btn_confirmar;
    }
}

