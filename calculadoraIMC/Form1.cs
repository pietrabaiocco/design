namespace calculadoraIMC
{
    public partial class Form1 : Form
    {
        public float peso, altura; // Variáveis usadas para o calculo do IMC.

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbl5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl3_Click(object sender, EventArgs e)
        {

        }

        private void AddNumber(object sender, EventArgs e)
        { 
            // evento_Click: o teclado funciona por meio dessa função, acionando uma função e mostrando da TextBox.

            if (txtpeso.BackColor == Color.Gold) // txt.BackColor: digita de acordo com a cor do fundo da TextBox.
            {
                txtpeso.Text += ((Button)sender).Text; // txt.Text += ((Button)sender).Text: mostra o texto do botão selecionado.
            }
            else if (txtaltura.BackColor == Color.Gold) // txt.BackColor: digita de acordo com a cor do fundo da TextBox.
            {
                txtaltura.Text += ((Button)sender).Text; // txt.Text += ((Button)sender).Text: mostra o texto do botão selecionado.
            }
        }

        private void txtaltura_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpeso_Enter(object sender, EventArgs e)
        {
            // Altera a BackColor da TextBox de acordo com a escolha do usuário.
            txtpeso.BackColor = Color.Gold;
            txtaltura.BackColor = Color.White;
        }

        private void txtaltura_Enter(object sender, EventArgs e)
        {
            // Altera a BackColor da TextBox de acordo com a escolha do usuário.
            txtaltura.BackColor = Color.Gold;
            txtpeso.BackColor = Color.White;
        }

        private void AddComma(object sender, EventArgs e)
        {
            // evento_Click: o teclado funciona por meio dessa função, acionando uma função e mostrando da TextBox.

            if (txtpeso.BackColor == Color.Gold) // Verifica a BackColor.
            {
                if (!txtpeso.Text.Contains(",")) // !txt.Text.Contains(","): analisa se já foi digitado uma vírgula. Caso positivo, fica impossibilitado de digitar uma segunda.
                {
                    txtpeso.Text += ((Button)sender).Text; // txt.Text += ((Button)sender).Text: adiciona a vírgula.
                }
            }
            else if (txtaltura.BackColor == Color.Gold)
            {
                if (!txtaltura.Text.Contains(","))
                {
                    txtaltura.Text += ((Button)sender).Text;
                }
            }
        }

        private void btndel_Click(object sender, EventArgs e)
        { 
            // evento_Click: o teclado funciona por meio dessa função, acionando uma função e mostrando da TextBox.
         
            if (txtpeso.BackColor == Color.Gold) // BackColor: restringe a funcionalidade do txt.ResetText apenas para a cor determinada (backcolor == Color.Gold).
            {
                txtpeso.ResetText(); // ResetText: função realizada ao acionar o evento_Click (apaga o texto digitado na TextBox indicada).
            }
            else if (txtaltura.BackColor == Color.Gold)
            {
                txtaltura.ResetText();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private float GetAltura()
        {
            return altura;
        }

        private void btnIMC_Click(object sender, EventArgs e, float altura)
        {
            // evento_Click: o teclado funciona por meio dessa função, acionando uma função e mostrando da TextBox.

            if (String.IsNullOrWhiteSpace(txtpeso.Text)) // String.IsNullOrWhiteSpace(txt.Text): verifica se a TextBox está preenchida.
            {
                MessageBox.Show("O campo 'Peso' não pode ficar vazio.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // MessageBox.Show: caso a TextBox esteja vazia, uma MessageBox aparece na tela do usuário.
                // MessageBoxButtons: adiciona botões a MessageBox.
                // MessageBoxIcon.Warning: adiciona ícone de aviso a MessageBox.
            }
            else if (String.IsNullOrWhiteSpace(txtaltura.Text))
            {
                MessageBox.Show("O campo 'Altura' não pode ficar vazio.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            peso = float.Parse(txtpeso.Text); // float.Parse(txt.Text): converte o conteúdo da TextBox para variável float.
            altura = float.Parse(txtaltura.Text);
            float total = peso / (altura * altura); // Realiza a operação.
            txtimc.Text = total.ToString(); // txtimc.Text: exibe o resultado do IMC no campo 'txtimc'.
            string situacao = string.Empty; // string.Empty: armazena a situação do IMC.

            if (total < 19.1) // Verifica se o IMC é menor que 19.1.
            {
                situacao = "Abaixo do peso"; // Indica a situação.
                lblSituacao.BackColor = Color.White; // Define a BackColor como branca.
                lblSituacao.ForeColor = Color.DarkBlue; // Define a ForeColor como azul escuro.
                lblSituacao.Text = situacao.ToString(); // Exibe a situação no Label.
            }
            else if (total >= 19.1 && total <= 25.8) // Verifica se o IMC está entre 19.1 e 25.8.
            {
                situacao = "Peso normal"; // Indica a situação.
                lblSituacao.BackColor = Color.White; // Define a BackColor como branca.
                lblSituacao.ForeColor = Color.DarkGreen; // Define a ForeColor como verde escuro.
                lblSituacao.Text = situacao.ToString(); // Exibe a situação no Label.
            }
            else if (total >= 25.8 && total <= 32.3) // Verifica se o IMC está entre 25.8 e 32.3.
            {
                situacao = "Acima do peso"; // Indica a situação.
                lblSituacao.BackColor = Color.White; // Define a BackColor como branca.
                lblSituacao.ForeColor = Color.DarkOrange; // Define a ForeColor como laranja escuro.
                lblSituacao.Text = situacao.ToString(); // Exibe a situação no Label.
            }
            else if (total >= 32.3) // Verifica se o IMC é maior ou igual a 32.3.
            {
                situacao = "Obeso"; // Indica a situação.
                lblSituacao.BackColor = Color.White; // Define a BackColor como branca.
                lblSituacao.ForeColor = Color.DarkRed; // Define a ForeColor como vermelho escuro.
                lblSituacao.Text = situacao.ToString(); // Exibe a situação no Label.
            }
        }

        private void txtimc_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblSituacao_Click(object sender, EventArgs e)
        {

        }
    }
}
