
using System;
using System.Globalization;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double peso;
            double altura;
            double imc;

            // Validar e converter o peso
            bool pesoValido = double.TryParse(
                txtPeso.Text.Trim().Replace(',', '.'),
                NumberStyles.Float,
                CultureInfo.InvariantCulture,
                out peso);

            // Validar e converter a altura
            bool alturaValida = double.TryParse(
                txtAltura.Text.Trim().Replace(',', '.'),
                NumberStyles.Float,
                CultureInfo.InvariantCulture,
                out altura);

            // Verificar se os valores são numéricos
            if (!pesoValido || !alturaValida)
            {
                MessageBox.Show(
                    "Por favor, introduza valores numéricos válidos.",
                    "Dados inválidos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // Verificar se os valores são positivos
            if (peso <= 0 || altura <= 0)
            {
                MessageBox.Show(
                    "O peso e a altura devem ser maiores que zero.",
                    "Valores inválidos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // Calcular o IMC
            imc = peso / (altura * altura);

            string classificacao;

            // Classificar o resultado
            if (imc < 18.5)
            {
                classificacao = "Abaixo do peso";
            }
            else if (imc < 25)
            {
                classificacao = "Peso normal";
            }
            else if (imc < 30)
            {
                classificacao = "Sobrepeso";
            }
            else
            {
                classificacao = "Obesidade";
            }

            // Apresentar o resultado
            lblResultado.Text =
                "IMC: " + imc.ToString("F2",
                CultureInfo.GetCultureInfo("pt-PT")) +
                "\nClassificação: " + classificacao;
        }
    }
}
