
namespace CalcIMC
{
    partial class FrmPrincipal
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
            this.Btn_calcular = new System.Windows.Forms.Button();
            this.Btn_sair = new System.Windows.Forms.Button();
            this.Lbl_peso = new System.Windows.Forms.Label();
            this.Lbl_altura = new System.Windows.Forms.Label();
            this.Lbl_resultado = new System.Windows.Forms.Label();
            this.Lbl_mostar = new System.Windows.Forms.Label();
            this.Txt_peso = new System.Windows.Forms.TextBox();
            this.Txt_altura = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Btn_calcular
            // 
            this.Btn_calcular.Location = new System.Drawing.Point(397, 104);
            this.Btn_calcular.Name = "Btn_calcular";
            this.Btn_calcular.Size = new System.Drawing.Size(106, 23);
            this.Btn_calcular.TabIndex = 0;
            this.Btn_calcular.Text = "Calcular";
            this.Btn_calcular.UseVisualStyleBackColor = true;
            this.Btn_calcular.Click += new System.EventHandler(this.Btn_calcular_Click);
            // 
            // Btn_sair
            // 
            this.Btn_sair.Location = new System.Drawing.Point(455, 198);
            this.Btn_sair.Name = "Btn_sair";
            this.Btn_sair.Size = new System.Drawing.Size(75, 23);
            this.Btn_sair.TabIndex = 1;
            this.Btn_sair.Text = "Sair";
            this.Btn_sair.UseVisualStyleBackColor = true;
            this.Btn_sair.Click += new System.EventHandler(this.Btn_sair_Click);
            // 
            // Lbl_peso
            // 
            this.Lbl_peso.AutoSize = true;
            this.Lbl_peso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_peso.Location = new System.Drawing.Point(98, 35);
            this.Lbl_peso.Name = "Lbl_peso";
            this.Lbl_peso.Size = new System.Drawing.Size(106, 13);
            this.Lbl_peso.TabIndex = 2;
            this.Lbl_peso.Text = "Digite o seu peso";
            // 
            // Lbl_altura
            // 
            this.Lbl_altura.AutoSize = true;
            this.Lbl_altura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_altura.Location = new System.Drawing.Point(98, 114);
            this.Lbl_altura.Name = "Lbl_altura";
            this.Lbl_altura.Size = new System.Drawing.Size(100, 13);
            this.Lbl_altura.TabIndex = 3;
            this.Lbl_altura.Text = "Digite sua altura";
            // 
            // Lbl_resultado
            // 
            this.Lbl_resultado.AutoSize = true;
            this.Lbl_resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_resultado.Location = new System.Drawing.Point(98, 198);
            this.Lbl_resultado.Name = "Lbl_resultado";
            this.Lbl_resultado.Size = new System.Drawing.Size(64, 13);
            this.Lbl_resultado.TabIndex = 4;
            this.Lbl_resultado.Text = "Resultado";
            // 
            // Lbl_mostar
            // 
            this.Lbl_mostar.AutoSize = true;
            this.Lbl_mostar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_mostar.Location = new System.Drawing.Point(119, 228);
            this.Lbl_mostar.Name = "Lbl_mostar";
            this.Lbl_mostar.Size = new System.Drawing.Size(0, 31);
            this.Lbl_mostar.TabIndex = 5;
            // 
            // Txt_peso
            // 
            this.Txt_peso.Location = new System.Drawing.Point(125, 67);
            this.Txt_peso.Name = "Txt_peso";
            this.Txt_peso.Size = new System.Drawing.Size(158, 20);
            this.Txt_peso.TabIndex = 6;
            // 
            // Txt_altura
            // 
            this.Txt_altura.Location = new System.Drawing.Point(125, 145);
            this.Txt_altura.Name = "Txt_altura";
            this.Txt_altura.Size = new System.Drawing.Size(158, 20);
            this.Txt_altura.TabIndex = 7;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 288);
            this.Controls.Add(this.Txt_altura);
            this.Controls.Add(this.Txt_peso);
            this.Controls.Add(this.Lbl_mostar);
            this.Controls.Add(this.Lbl_resultado);
            this.Controls.Add(this.Lbl_altura);
            this.Controls.Add(this.Lbl_peso);
            this.Controls.Add(this.Btn_sair);
            this.Controls.Add(this.Btn_calcular);
            this.Name = "FrmPrincipal";
            this.Text = "Calculadora do IMC";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_calcular;
        private System.Windows.Forms.Button Btn_sair;
        private System.Windows.Forms.Label Lbl_peso;
        private System.Windows.Forms.Label Lbl_altura;
        private System.Windows.Forms.Label Lbl_resultado;
        private System.Windows.Forms.Label Lbl_mostar;
        private System.Windows.Forms.TextBox Txt_peso;
        private System.Windows.Forms.TextBox Txt_altura;
    }
}

