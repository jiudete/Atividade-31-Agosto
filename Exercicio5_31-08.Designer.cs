namespace Exercicio5_31_08
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
            this.btn_converter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_milha = new System.Windows.Forms.Label();
            this.txt_milha = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_converter
            // 
            this.btn_converter.Location = new System.Drawing.Point(126, 171);
            this.btn_converter.Name = "btn_converter";
            this.btn_converter.Size = new System.Drawing.Size(75, 23);
            this.btn_converter.TabIndex = 0;
            this.btn_converter.Text = "Converter";
            this.btn_converter.UseVisualStyleBackColor = true;
            this.btn_converter.Click += new System.EventHandler(this.btn_converter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Conversor";
            // 
            // lbl_milha
            // 
            this.lbl_milha.AutoSize = true;
            this.lbl_milha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_milha.Location = new System.Drawing.Point(68, 110);
            this.lbl_milha.Name = "lbl_milha";
            this.lbl_milha.Size = new System.Drawing.Size(52, 17);
            this.lbl_milha.TabIndex = 2;
            this.lbl_milha.Text = "Milhas:";
            // 
            // txt_milha
            // 
            this.txt_milha.Location = new System.Drawing.Point(126, 109);
            this.txt_milha.Name = "txt_milha";
            this.txt_milha.Size = new System.Drawing.Size(150, 20);
            this.txt_milha.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 232);
            this.Controls.Add(this.txt_milha);
            this.Controls.Add(this.lbl_milha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_converter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_converter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_milha;
        private System.Windows.Forms.TextBox txt_milha;
    }
}

