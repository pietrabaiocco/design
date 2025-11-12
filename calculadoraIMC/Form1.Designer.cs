namespace calculadoraIMC
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            lblSituacao = new Label();
            lblIMC = new Label();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            lbl7 = new Label();
            lbl6 = new Label();
            txtimc = new TextBox();
            txtaltura = new TextBox();
            txtpeso = new TextBox();
            lbl5 = new Label();
            lbl4 = new Label();
            lbl3 = new Label();
            lbl2 = new Label();
            lbl1 = new Label();
            panel2 = new Panel();
            btn1 = new Button();
            btn3 = new Button();
            btn8 = new Button();
            btnIMC = new Button();
            btndel = new Button();
            btn0 = new Button();
            btnvirgula = new Button();
            btn2 = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btn9 = new Button();
            btn7 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblSituacao);
            panel1.Controls.Add(lblIMC);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lbl7);
            panel1.Controls.Add(lbl6);
            panel1.Controls.Add(txtimc);
            panel1.Controls.Add(txtaltura);
            panel1.Controls.Add(txtpeso);
            panel1.Controls.Add(lbl5);
            panel1.Controls.Add(lbl4);
            panel1.Controls.Add(lbl3);
            panel1.Controls.Add(lbl2);
            panel1.Controls.Add(lbl1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(317, 209);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // lblSituacao
            // 
            lblSituacao.AutoSize = true;
            lblSituacao.BackColor = Color.Gold;
            lblSituacao.Font = new Font("Verdana", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblSituacao.ForeColor = SystemColors.ControlText;
            lblSituacao.Location = new Point(168, 183);
            lblSituacao.Name = "lblSituacao";
            lblSituacao.Size = new Size(0, 20);
            lblSituacao.TabIndex = 14;
            lblSituacao.Click += lblSituacao_Click;
            // 
            // lblIMC
            // 
            lblIMC.AutoSize = true;
            lblIMC.BackColor = Color.White;
            lblIMC.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblIMC.ForeColor = Color.Black;
            lblIMC.Location = new Point(186, 146);
            lblIMC.Name = "lblIMC";
            lblIMC.Size = new Size(0, 18);
            lblIMC.TabIndex = 13;
            lblIMC.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(24, 177);
            label1.Name = "label1";
            label1.Size = new Size(113, 25);
            label1.TabIndex = 12;
            label1.Text = "Situação";
            label1.Click += label1_Click_1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.height;
            pictureBox2.Location = new Point(21, 97);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(39, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = Properties.Resources.scale;
            pictureBox1.Location = new Point(21, 54);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(39, 39);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // lbl7
            // 
            lbl7.AutoSize = true;
            lbl7.Font = new Font("Verdana", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbl7.ForeColor = Color.DimGray;
            lbl7.Location = new Point(274, 99);
            lbl7.Name = "lbl7";
            lbl7.Size = new Size(30, 23);
            lbl7.TabIndex = 9;
            lbl7.Text = "m";
            // 
            // lbl6
            // 
            lbl6.AutoSize = true;
            lbl6.Font = new Font("Verdana", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbl6.ForeColor = Color.DimGray;
            lbl6.Location = new Point(274, 57);
            lbl6.Name = "lbl6";
            lbl6.Size = new Size(36, 23);
            lbl6.TabIndex = 8;
            lbl6.Text = "kg";
            // 
            // txtimc
            // 
            txtimc.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtimc.Location = new Point(168, 141);
            txtimc.Name = "txtimc";
            txtimc.Size = new Size(100, 27);
            txtimc.TabIndex = 7;
            txtimc.TextChanged += txtimc_TextChanged;
            // 
            // txtaltura
            // 
            txtaltura.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtaltura.ForeColor = Color.Black;
            txtaltura.Location = new Point(168, 99);
            txtaltura.Name = "txtaltura";
            txtaltura.Size = new Size(100, 27);
            txtaltura.TabIndex = 6;
            txtaltura.TextChanged += txtaltura_TextChanged;
            txtaltura.Enter += txtaltura_Enter;
            // 
            // txtpeso
            // 
            txtpeso.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtpeso.ForeColor = Color.Black;
            txtpeso.Location = new Point(168, 57);
            txtpeso.Name = "txtpeso";
            txtpeso.Size = new Size(100, 27);
            txtpeso.TabIndex = 5;
            txtpeso.TextChanged += txt1_TextChanged;
            txtpeso.Enter += txtpeso_Enter;
            // 
            // lbl5
            // 
            lbl5.AutoSize = true;
            lbl5.Font = new Font("Verdana", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbl5.ForeColor = Color.DimGray;
            lbl5.Location = new Point(110, 141);
            lbl5.Name = "lbl5";
            lbl5.Size = new Size(52, 23);
            lbl5.TabIndex = 4;
            lbl5.Text = "IMC";
            lbl5.Click += lbl5_Click;
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.Font = new Font("Verdana", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbl4.ForeColor = Color.DimGray;
            lbl4.Location = new Point(85, 103);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(77, 23);
            lbl4.TabIndex = 3;
            lbl4.Text = "Altura";
            lbl4.Click += label1_Click;
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Font = new Font("Verdana", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbl3.ForeColor = Color.DimGray;
            lbl3.ImageAlign = ContentAlignment.MiddleLeft;
            lbl3.Location = new Point(101, 61);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(61, 23);
            lbl3.TabIndex = 2;
            lbl3.Text = "Peso";
            lbl3.Click += lbl3_Click;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.BackColor = Color.Gold;
            lbl2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbl2.ForeColor = Color.DimGray;
            lbl2.Location = new Point(60, 21);
            lbl2.Name = "lbl2";
            lbl2.RightToLeft = RightToLeft.Yes;
            lbl2.Size = new Size(199, 21);
            lbl2.TabIndex = 1;
            lbl2.Text = "Informe seu Peso e Altura";
            lbl2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Verdana", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbl1.Location = new Point(64, 0);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(185, 25);
            lbl1.TabIndex = 0;
            lbl1.Text = "Cálculo de IMC";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(btn1);
            panel2.Controls.Add(btn3);
            panel2.Controls.Add(btn8);
            panel2.Controls.Add(btnIMC);
            panel2.Controls.Add(btndel);
            panel2.Controls.Add(btn0);
            panel2.Controls.Add(btnvirgula);
            panel2.Controls.Add(btn2);
            panel2.Controls.Add(btn6);
            panel2.Controls.Add(btn5);
            panel2.Controls.Add(btn4);
            panel2.Controls.Add(btn9);
            panel2.Controls.Add(btn7);
            panel2.Location = new Point(12, 227);
            panel2.Name = "panel2";
            panel2.Size = new Size(317, 282);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // btn1
            // 
            btn1.BackColor = Color.Gold;
            btn1.FlatStyle = FlatStyle.Flat;
            btn1.Font = new Font("Verdana", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn1.ForeColor = Color.Black;
            btn1.Location = new Point(20, 112);
            btn1.Name = "btn1";
            btn1.Size = new Size(88, 42);
            btn1.TabIndex = 16;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += AddNumber;
            // 
            // btn3
            // 
            btn3.BackColor = Color.Gold;
            btn3.FlatStyle = FlatStyle.Flat;
            btn3.Font = new Font("Verdana", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn3.ForeColor = Color.Black;
            btn3.Location = new Point(210, 112);
            btn3.Name = "btn3";
            btn3.Size = new Size(88, 42);
            btn3.TabIndex = 15;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += AddNumber;
            // 
            // btn8
            // 
            btn8.BackColor = Color.Gold;
            btn8.FlatStyle = FlatStyle.Flat;
            btn8.Font = new Font("Verdana", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn8.ForeColor = Color.Black;
            btn8.Location = new Point(114, 16);
            btn8.Name = "btn8";
            btn8.Size = new Size(86, 42);
            btn8.TabIndex = 14;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += AddNumber;
            // 
            // btnIMC
            // 
            btnIMC.BackColor = Color.Gold;
            btnIMC.FlatStyle = FlatStyle.Flat;
            btnIMC.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnIMC.ForeColor = Color.Black;
            btnIMC.Location = new Point(20, 208);
            btnIMC.Name = "btnIMC";
            btnIMC.Size = new Size(278, 62);
            btnIMC.TabIndex = 12;
            btnIMC.Text = "Calcular Índice de Massa Corporal";
            btnIMC.UseVisualStyleBackColor = false;
            btnIMC.Click += btnIMC_Click;
            // 
            // btndel
            // 
            btndel.BackColor = Color.Gold;
            btndel.FlatStyle = FlatStyle.Flat;
            btndel.Font = new Font("Verdana", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btndel.ForeColor = Color.Black;
            btndel.Location = new Point(210, 160);
            btndel.Name = "btndel";
            btndel.Size = new Size(88, 42);
            btndel.TabIndex = 11;
            btndel.Text = "del";
            btndel.UseVisualStyleBackColor = false;
            btndel.Click += btndel_Click;
            // 
            // btn0
            // 
            btn0.BackColor = Color.Gold;
            btn0.FlatStyle = FlatStyle.Flat;
            btn0.Font = new Font("Verdana", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn0.ForeColor = Color.Black;
            btn0.Location = new Point(116, 160);
            btn0.Name = "btn0";
            btn0.Size = new Size(86, 42);
            btn0.TabIndex = 10;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += AddNumber;
            // 
            // btnvirgula
            // 
            btnvirgula.BackColor = Color.Gold;
            btnvirgula.FlatStyle = FlatStyle.Flat;
            btnvirgula.Font = new Font("Verdana", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnvirgula.ForeColor = Color.Black;
            btnvirgula.ImageAlign = ContentAlignment.TopCenter;
            btnvirgula.Location = new Point(20, 160);
            btnvirgula.Name = "btnvirgula";
            btnvirgula.Size = new Size(88, 42);
            btnvirgula.TabIndex = 9;
            btnvirgula.Text = ",";
            btnvirgula.UseVisualStyleBackColor = false;
            btnvirgula.Click += AddComma;
            // 
            // btn2
            // 
            btn2.BackColor = Color.Gold;
            btn2.FlatStyle = FlatStyle.Flat;
            btn2.Font = new Font("Verdana", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn2.ForeColor = Color.Black;
            btn2.Location = new Point(116, 112);
            btn2.Name = "btn2";
            btn2.Size = new Size(86, 42);
            btn2.TabIndex = 7;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += AddNumber;
            // 
            // btn6
            // 
            btn6.BackColor = Color.Gold;
            btn6.FlatStyle = FlatStyle.Flat;
            btn6.Font = new Font("Verdana", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn6.ForeColor = Color.Black;
            btn6.Location = new Point(210, 64);
            btn6.Name = "btn6";
            btn6.Size = new Size(88, 42);
            btn6.TabIndex = 5;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += AddNumber;
            // 
            // btn5
            // 
            btn5.BackColor = Color.Gold;
            btn5.FlatStyle = FlatStyle.Flat;
            btn5.Font = new Font("Verdana", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn5.ForeColor = Color.Black;
            btn5.Location = new Point(116, 64);
            btn5.Name = "btn5";
            btn5.Size = new Size(86, 42);
            btn5.TabIndex = 4;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += AddNumber;
            // 
            // btn4
            // 
            btn4.BackColor = Color.Gold;
            btn4.FlatStyle = FlatStyle.Flat;
            btn4.Font = new Font("Verdana", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn4.ForeColor = Color.Black;
            btn4.Location = new Point(20, 64);
            btn4.Name = "btn4";
            btn4.Size = new Size(88, 42);
            btn4.TabIndex = 3;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += AddNumber;
            // 
            // btn9
            // 
            btn9.BackColor = Color.Gold;
            btn9.FlatStyle = FlatStyle.Flat;
            btn9.Font = new Font("Verdana", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn9.ForeColor = Color.Black;
            btn9.Location = new Point(210, 16);
            btn9.Name = "btn9";
            btn9.Size = new Size(88, 42);
            btn9.TabIndex = 2;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += AddNumber;
            // 
            // btn7
            // 
            btn7.BackColor = Color.Gold;
            btn7.FlatStyle = FlatStyle.Flat;
            btn7.Font = new Font("Verdana", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn7.ForeColor = Color.Black;
            btn7.Location = new Point(20, 16);
            btn7.Name = "btn7";
            btn7.Size = new Size(88, 42);
            btn7.TabIndex = 0;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += AddNumber;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gold;
            ClientSize = new Size(344, 521);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "IMC";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label lbl1;
        private Label lbl2;
        private Label lbl3;
        private Label lbl5;
        private Label lbl4;
        private TextBox txtimc;
        private TextBox txtaltura;
        private TextBox txtpeso;
        private PictureBox pictureBox1;
        private Label lbl7;
        private Label lbl6;
        private Label label1;
        private PictureBox pictureBox2;
        private Button btn2;
        private Button btnIMC;
        private Button btndel;
        private Button btn0;
        private Button btn9;
        private Button btn7;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btn8;
        private Button btn3;
        private Button btn1;
        private Button btnvirgula;
        private Label lblIMC;
        private Label lblSituacao;
    }
}