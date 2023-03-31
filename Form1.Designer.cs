namespace AppCalculadoraDiversa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalculadoraFinanceira = new System.Windows.Forms.Button();
            this.btnCalcularDesconto = new System.Windows.Forms.Button();
            this.btnCalcularRaizes = new System.Windows.Forms.Button();
            this.btnSimularSalario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(452, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu Principal";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCalculadoraFinanceira
            // 
            this.btnCalculadoraFinanceira.BackColor = System.Drawing.SystemColors.Menu;
            this.btnCalculadoraFinanceira.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculadoraFinanceira.Location = new System.Drawing.Point(28, 140);
            this.btnCalculadoraFinanceira.Name = "btnCalculadoraFinanceira";
            this.btnCalculadoraFinanceira.Size = new System.Drawing.Size(221, 54);
            this.btnCalculadoraFinanceira.TabIndex = 1;
            this.btnCalculadoraFinanceira.Text = "Calculadora Financeira";
            this.btnCalculadoraFinanceira.UseVisualStyleBackColor = false;
            this.btnCalculadoraFinanceira.Click += new System.EventHandler(this.btnCalculadoraFinanceira_Click);
            // 
            // btnCalcularDesconto
            // 
            this.btnCalcularDesconto.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnCalcularDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularDesconto.Location = new System.Drawing.Point(28, 311);
            this.btnCalcularDesconto.Name = "btnCalcularDesconto";
            this.btnCalcularDesconto.Size = new System.Drawing.Size(221, 54);
            this.btnCalcularDesconto.TabIndex = 2;
            this.btnCalcularDesconto.Text = "Calcular Desconto";
            this.btnCalcularDesconto.UseVisualStyleBackColor = false;
            this.btnCalcularDesconto.Click += new System.EventHandler(this.btnCalcularDesconto_Click);
            // 
            // btnCalcularRaizes
            // 
            this.btnCalcularRaizes.BackColor = System.Drawing.SystemColors.Menu;
            this.btnCalcularRaizes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularRaizes.Location = new System.Drawing.Point(348, 140);
            this.btnCalcularRaizes.Name = "btnCalcularRaizes";
            this.btnCalcularRaizes.Size = new System.Drawing.Size(221, 54);
            this.btnCalcularRaizes.TabIndex = 3;
            this.btnCalcularRaizes.Text = "Calcular Raizes";
            this.btnCalcularRaizes.UseVisualStyleBackColor = false;
            this.btnCalcularRaizes.Click += new System.EventHandler(this.btnCalcularRaizes_Click);
            // 
            // btnSimularSalario
            // 
            this.btnSimularSalario.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnSimularSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimularSalario.Location = new System.Drawing.Point(348, 311);
            this.btnSimularSalario.Name = "btnSimularSalario";
            this.btnSimularSalario.Size = new System.Drawing.Size(221, 54);
            this.btnSimularSalario.TabIndex = 4;
            this.btnSimularSalario.Text = "Simular Salário";
            this.btnSimularSalario.UseVisualStyleBackColor = false;
            this.btnSimularSalario.Click += new System.EventHandler(this.btnSimularSalario_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(598, 418);
            this.Controls.Add(this.btnSimularSalario);
            this.Controls.Add(this.btnCalcularRaizes);
            this.Controls.Add(this.btnCalcularDesconto);
            this.Controls.Add(this.btnCalculadoraFinanceira);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Menu Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalculadoraFinanceira;
        private System.Windows.Forms.Button btnCalcularDesconto;
        private System.Windows.Forms.Button btnCalcularRaizes;
        private System.Windows.Forms.Button btnSimularSalario;
    }
}

