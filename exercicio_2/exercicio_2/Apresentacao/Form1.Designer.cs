namespace exercicio_2
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
            this.lblTemperatura = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.plnComponents = new System.Windows.Forms.Panel();
            this.lblResultado = new System.Windows.Forms.Label();
            this.rdbCF = new System.Windows.Forms.RadioButton();
            this.rdbFC = new System.Windows.Forms.RadioButton();
            this.txtTemperatura = new System.Windows.Forms.TextBox();
            this.plnComponents.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTemperatura
            // 
            this.lblTemperatura.AutoSize = true;
            this.lblTemperatura.Location = new System.Drawing.Point(22, 32);
            this.lblTemperatura.Name = "lblTemperatura";
            this.lblTemperatura.Size = new System.Drawing.Size(100, 13);
            this.lblTemperatura.TabIndex = 0;
            this.lblTemperatura.Text = "Insira a temperatura";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(25, 236);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(200, 23);
            this.btnCalcular.TabIndex = 1;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // plnComponents
            // 
            this.plnComponents.Controls.Add(this.rdbFC);
            this.plnComponents.Controls.Add(this.rdbCF);
            this.plnComponents.Location = new System.Drawing.Point(25, 125);
            this.plnComponents.Name = "plnComponents";
            this.plnComponents.Size = new System.Drawing.Size(200, 82);
            this.plnComponents.TabIndex = 2;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(22, 283);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(52, 13);
            this.lblResultado.TabIndex = 3;
            this.lblResultado.Text = "Resposta";
            // 
            // rdbCF
            // 
            this.rdbCF.AutoSize = true;
            this.rdbCF.Checked = true;
            this.rdbCF.Location = new System.Drawing.Point(20, 13);
            this.rdbCF.Name = "rdbCF";
            this.rdbCF.Size = new System.Drawing.Size(117, 17);
            this.rdbCF.TabIndex = 0;
            this.rdbCF.TabStop = true;
            this.rdbCF.Text = "Celsius - Fahrenheit";
            this.rdbCF.UseVisualStyleBackColor = true;
            // 
            // rdbFC
            // 
            this.rdbFC.AutoSize = true;
            this.rdbFC.Location = new System.Drawing.Point(20, 46);
            this.rdbFC.Name = "rdbFC";
            this.rdbFC.Size = new System.Drawing.Size(117, 17);
            this.rdbFC.TabIndex = 1;
            this.rdbFC.TabStop = true;
            this.rdbFC.Text = "Fahrenheit - Celsius";
            this.rdbFC.UseVisualStyleBackColor = true;
            // 
            // txtTemperatura
            // 
            this.txtTemperatura.Location = new System.Drawing.Point(25, 75);
            this.txtTemperatura.Name = "txtTemperatura";
            this.txtTemperatura.Size = new System.Drawing.Size(100, 20);
            this.txtTemperatura.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 321);
            this.Controls.Add(this.txtTemperatura);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.plnComponents);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblTemperatura);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Conversor de temperatura";
            this.plnComponents.ResumeLayout(false);
            this.plnComponents.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTemperatura;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Panel plnComponents;
        private System.Windows.Forms.RadioButton rdbFC;
        private System.Windows.Forms.RadioButton rdbCF;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtTemperatura;
    }
}

