namespace SistemaFiguraGeometrica
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            comboBox1 = new ComboBox();
            btnCalcular = new Button();
            button2 = new Button();
            button1 = new Button();
            lblArea = new Label();
            lblPerimetro = new Label();
            pictureBox1 = new PictureBox();
            lblValor = new Label();
            txtValor = new TextBox();
            lblBase = new Label();
            txtBase = new TextBox();
            lblAltura = new Label();
            txtAltura = new TextBox();
            lblLado1 = new Label();
            txtLado1 = new TextBox();
            lblLado2 = new Label();
            txtLado2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Location = new Point(30, 20);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(150, 23);
            comboBox1.TabIndex = 0;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(12, 201);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(100, 30);
            btnCalcular.TabIndex = 11;
            btnCalcular.Text = "Calcular Área";
            btnCalcular.Click += Area_Click;
            // 
            // button2
            // 
            button2.Location = new Point(130, 201);
            button2.Name = "button2";
            button2.Size = new Size(164, 30);
            button2.TabIndex = 12;
            button2.Text = "Calcular Perímetro";
            button2.Click += Perimetro_Click;
            // 
            // button1
            // 
            button1.Location = new Point(222, 284);
            button1.Name = "button1";
            button1.Size = new Size(80, 30);
            button1.TabIndex = 13;
            button1.Text = "Limpar";
            button1.Click += Limpar_Click;
            // 
            // lblArea
            // 
            lblArea.Location = new Point(30, 247);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(200, 23);
            lblArea.TabIndex = 14;
            lblArea.Text = "Área:";
            // 
            // lblPerimetro
            // 
            lblPerimetro.Location = new Point(30, 283);
            lblPerimetro.Name = "lblPerimetro";
            lblPerimetro.Size = new Size(200, 23);
            lblPerimetro.TabIndex = 15;
            lblPerimetro.Text = "Perímetro:";
            lblPerimetro.Click += lblPerimetro_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(336, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(250, 250);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            pictureBox1.Paint += pictureBox1_Paint;
            // 
            // lblValor
            // 
            lblValor.Location = new Point(30, 60);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(100, 23);
            lblValor.TabIndex = 1;
            lblValor.Text = "Valor:";
            // 
            // txtValor
            // 
            txtValor.Location = new Point(130, 60);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(100, 23);
            txtValor.TabIndex = 2;
            // 
            // lblBase
            // 
            lblBase.Location = new Point(30, 60);
            lblBase.Name = "lblBase";
            lblBase.Size = new Size(100, 23);
            lblBase.TabIndex = 3;
            lblBase.Text = "Base:";
            // 
            // txtBase
            // 
            txtBase.Location = new Point(130, 60);
            txtBase.Name = "txtBase";
            txtBase.Size = new Size(100, 23);
            txtBase.TabIndex = 4;
            // 
            // lblAltura
            // 
            lblAltura.Location = new Point(30, 90);
            lblAltura.Name = "lblAltura";
            lblAltura.Size = new Size(100, 23);
            lblAltura.TabIndex = 5;
            lblAltura.Text = "Altura:";
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(130, 90);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(100, 23);
            txtAltura.TabIndex = 6;
            // 
            // lblLado1
            // 
            lblLado1.Location = new Point(30, 120);
            lblLado1.Name = "lblLado1";
            lblLado1.Size = new Size(100, 23);
            lblLado1.TabIndex = 7;
            lblLado1.Text = "Lado 1:";
            // 
            // txtLado1
            // 
            txtLado1.Location = new Point(130, 120);
            txtLado1.Name = "txtLado1";
            txtLado1.Size = new Size(100, 23);
            txtLado1.TabIndex = 8;
            // 
            // lblLado2
            // 
            lblLado2.Location = new Point(30, 150);
            lblLado2.Name = "lblLado2";
            lblLado2.Size = new Size(100, 23);
            lblLado2.TabIndex = 9;
            lblLado2.Text = "Lado 2:";
            // 
            // txtLado2
            // 
            txtLado2.Location = new Point(130, 150);
            txtLado2.Name = "txtLado2";
            txtLado2.Size = new Size(100, 23);
            txtLado2.TabIndex = 10;
            // 
            // Form1
            // 
            ClientSize = new Size(689, 326);
            Controls.Add(comboBox1);
            Controls.Add(lblValor);
            Controls.Add(txtValor);
            Controls.Add(lblBase);
            Controls.Add(txtBase);
            Controls.Add(lblAltura);
            Controls.Add(txtAltura);
            Controls.Add(lblLado1);
            Controls.Add(txtLado1);
            Controls.Add(lblLado2);
            Controls.Add(txtLado2);
            Controls.Add(btnCalcular);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lblArea);
            Controls.Add(lblPerimetro);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Sistema Figura Geométrica";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private ComboBox comboBox1;
        private TextBox txtValor;
        private Button btnCalcular;
        private Label lblArea;
        private Label lblPerimetro;
        private Button button1;
        private Button button2;

        private Label lblValor;
        private Label lblBase;
        private Label lblAltura;
        private Label lblLado1;
        private Label lblLado2;

        private TextBox txtBase;
        private TextBox txtAltura;
        private TextBox txtLado1;
        private TextBox txtLado2;
    }
}
