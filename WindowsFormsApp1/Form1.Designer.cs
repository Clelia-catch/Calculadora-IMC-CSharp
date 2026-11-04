
namespace WindowsFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblInstrucao;
        private System.Windows.Forms.Label lblDesenvolvedor;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblInstrucao = new System.Windows.Forms.Label();
            this.lblDesenvolvedor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblTitulo.Location = new System.Drawing.Point(100, 35);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(500, 50);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Calculadora de IMC";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPeso
            // 
            this.lblPeso.Font = new System.Drawing.Font("Arial", 12F);
            this.lblPeso.Location = new System.Drawing.Point(110, 125);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(150, 25);
            this.lblPeso.TabIndex = 1;
            this.lblPeso.Text = "Peso (kg):";
            // 
            // lblAltura
            // 
            this.lblAltura.Font = new System.Drawing.Font("Arial", 12F);
            this.lblAltura.Location = new System.Drawing.Point(110, 215);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(150, 25);
            this.lblAltura.TabIndex = 3;
            this.lblAltura.Text = "Altura (m):";
            // 
            // txtPeso
            // 
            this.txtPeso.Font = new System.Drawing.Font("Arial", 12F);
            this.txtPeso.Location = new System.Drawing.Point(110, 155);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(480, 30);
            this.txtPeso.TabIndex = 2;
            this.txtPeso.Text = "33";
            // 
            // txtAltura
            // 
            this.txtAltura.Font = new System.Drawing.Font("Arial", 12F);
            this.txtAltura.Location = new System.Drawing.Point(110, 245);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(480, 30);
            this.txtAltura.TabIndex = 4;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.btnCalcular.ForeColor = System.Drawing.Color.White;
            this.btnCalcular.Location = new System.Drawing.Point(110, 315);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(230, 65);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular IMC";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblResultado.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblResultado.Location = new System.Drawing.Point(365, 315);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(230, 75);
            this.lblResultado.TabIndex = 6;
            this.lblResultado.Text = "Resultado do IMC e classificação aparecerão aqui.";
            // 
            // lblInstrucao
            // 
            this.lblInstrucao.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic);
            this.lblInstrucao.Location = new System.Drawing.Point(110, 395);
            this.lblInstrucao.Name = "lblInstrucao";
            this.lblInstrucao.Size = new System.Drawing.Size(480, 25);
            this.lblInstrucao.TabIndex = 7;
            this.lblInstrucao.Text = "Introduza o peso em kg e a altura em metros.";
            // 
            // lblDesenvolvedor
            // 
            this.lblDesenvolvedor.BackColor = System.Drawing.Color.LightGray;
            this.lblDesenvolvedor.Font = new System.Drawing.Font("Arial", 9F);
            this.lblDesenvolvedor.Location = new System.Drawing.Point(0, 455);
            this.lblDesenvolvedor.Name = "lblDesenvolvedor";
            this.lblDesenvolvedor.Size = new System.Drawing.Size(700, 45);
            this.lblDesenvolvedor.TabIndex = 8;
            this.lblDesenvolvedor.Text = "Desenvolvido por: Clelia Chauque | 2026";
            this.lblDesenvolvedor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblInstrucao);
            this.Controls.Add(this.lblDesenvolvedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de IMC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
