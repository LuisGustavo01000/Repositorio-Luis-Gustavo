using System;
using System.Drawing;
using System.Windows.Forms;
using FormasGeometricas;

namespace SistemaFiguraGeometrica
{
    public partial class Form1 : Form
    {
        private Forma formaSelecionada;

        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(new string[] { "Quadrado", "Círculo", "Triangulo", "Retangulo", "Hexagono", "Octagono", "Pentagono" });
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            comboBox1.SelectedIndex = 0;
        }

        private void Area_Click(object sender, EventArgs e)
        {
            string forma = comboBox1.SelectedItem.ToString();

            switch (forma)
            {
                case "Quadrado":
                    if (double.TryParse(txtValor.Text, out double lado))
                    {
                        formaSelecionada = new Quadrado(lado);
                    }
                    else
                    {
                        MessageBox.Show("Insira um valor válido para o lado!");
                        return;
                    }
                    break;

                case "Círculo":
                    if (double.TryParse(txtValor.Text, out double raio))
                    {
                        formaSelecionada = new Circulo(raio);
                    }
                    else
                    {
                        MessageBox.Show("Insira um valor válido para o raio!");
                        return;
                    }
                    break;

                case "Triangulo":
                    if (!double.TryParse(txtBase.Text, out double baseT) ||
                        !double.TryParse(txtAltura.Text, out double alturaT) ||
                        !double.TryParse(txtLado1.Text, out double lado1) ||
                        !double.TryParse(txtLado2.Text, out double lado2))
                    {
                        MessageBox.Show("Insira todos os valores do triângulo corretamente!");
                        return;
                    }
                    formaSelecionada = new Triangulo(baseT, alturaT, lado1, lado2);
                    break;

                case "Retangulo":
                    if (!double.TryParse(txtBase.Text, out double baseR) ||
                        !double.TryParse(txtAltura.Text, out double alturaR))
                    {
                        MessageBox.Show("Insira todos os valores do retângulo corretamente!");
                        return;
                    }
                    formaSelecionada = new Retangulo(baseR, alturaR);
                    break;
                case "Hexagono":
                    if (!double.TryParse(txtValor.Text, out double ladoHex))
                    {
                        MessageBox.Show("Insira todos os valores do hexágono corretamente!");
                        return;
                    }
                    formaSelecionada = new Hexagono(ladoHex);
                    break;
                case "Octagono":
                    if (!double.TryParse(txtValor.Text, out double ladooct))
                    {
                        MessageBox.Show("Insira todos os valores do octágono corretamente!");
                        return;
                    }
                    formaSelecionada = new Octagono(ladooct);
                    break;
                case "Pentagono":
                    if (!double.TryParse(txtValor.Text, out double ladoPent))
                    {
                        MessageBox.Show("Insira todos os valores do pentágono corretamente!");
                        return;
                    }
                    formaSelecionada = new Pentagono(ladoPent);
                    break;
            }


            if (formaSelecionada != null)
            {
                double area = formaSelecionada.CalcularArea();
                lblArea.Text = $"Área: {area:F2}";
                pictureBox1.Invalidate();
            }
        }
        private void Perimetro_Click(object sender, EventArgs e)
        {
            string forma = comboBox1.SelectedItem.ToString();

            switch (forma)
            {
                case "Quadrado":
                    if (double.TryParse(txtValor.Text, out double lado))
                    {
                        formaSelecionada = new Quadrado(lado);
                    }
                    else
                    {
                        MessageBox.Show("Insira um valor válido para o lado!");
                        return;
                    }
                    break;

                case "Círculo":
                    if (double.TryParse(txtValor.Text, out double raio))
                    {
                        formaSelecionada = new Circulo(raio);
                    }
                    else
                    {
                        MessageBox.Show("Insira um valor válido para o raio!");
                        return;
                    }
                    break;

                case "Triangulo":
                    if (!double.TryParse(txtBase.Text, out double baseT) ||
                        !double.TryParse(txtAltura.Text, out double alturaT) ||
                        !double.TryParse(txtLado1.Text, out double lado1) ||
                        !double.TryParse(txtLado2.Text, out double lado2))
                    {
                        MessageBox.Show("Insira todos os valores do triângulo corretamente!");
                        return;
                    }
                    formaSelecionada = new Triangulo(baseT, alturaT, lado1, lado2);
                    break;

                case "Retangulo":
                    if (!double.TryParse(txtBase.Text, out double largura) ||
                        !double.TryParse(txtAltura.Text, out double altura))
                    {
                        MessageBox.Show("Insira todos os valores do triângulo corretamente!");
                        return;
                    }
                    formaSelecionada = new Retangulo(largura, altura);
                    break;
                case "Hexagono":
                    if (!double.TryParse(txtValor.Text, out double ladoHex))
                    {
                        MessageBox.Show("Insira todos os valores do hexágono corretamente!");
                        return;
                    }
                    break;
                case "Octagono":
                    if (!double.TryParse(txtValor.Text, out double ladooct))
                    {
                        MessageBox.Show("Insira todos os valores do octágono corretamente!");
                        return;
                    }
                    break;
                case "Pentagono":
                    if (!double.TryParse(txtValor.Text, out double ladoPent))
                    {
                        MessageBox.Show("Insira todos os valores do pentágono corretamente!");
                        return;
                    }
                    break;
            }

            double perimetro = formaSelecionada.CalcularPerimetro();
            lblPerimetro.Text = $"Perímetro: {perimetro:F2}";
            pictureBox1.Invalidate();
        }

        private void Limpar_Click(object sender, EventArgs e)
        {
            txtValor.Clear();
            txtBase.Clear();
            txtAltura.Clear();
            txtLado1.Clear();
            txtLado2.Clear();
            lblArea.Text = "";
            lblPerimetro.Text = "";
            formaSelecionada = null;
            comboBox1.SelectedIndex = 0;
            pictureBox1.Invalidate();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (formaSelecionada == null) return;

            Graphics g = e.Graphics;
            Pen caneta = new Pen(Color.Black, 2);

            switch (formaSelecionada)
            {
                case Quadrado quadrado:
                    int lado = (int)(quadrado.Lado * 10);
                    int x = (pictureBox1.Width - lado) / 2;
                    int y = (pictureBox1.Height - lado) / 2;
                    g.DrawRectangle(caneta, x, y, lado, lado);
                    break;

                case Circulo circulo:
                    int raio = (int)(circulo.Raio * 10);
                    int cx = (pictureBox1.Width - raio * 2) / 2;
                    int cy = (pictureBox1.Height - raio * 2) / 2;
                    g.DrawEllipse(caneta, cx, cy, raio * 2, raio * 2);
                    break;

                case Triangulo triangulo:
                    int basePx = (int)(triangulo.BaseTriangulo * 10);
                    int alturaPx = (int)(triangulo.Altura * 10);

                    Point[] pontos = new Point[3];
                    int startX = (pictureBox1.Width - basePx) / 2;
                    int startY = (pictureBox1.Height + alturaPx) / 2;

                    pontos[0] = new Point(startX, startY);
                    pontos[1] = new Point(startX + basePx, startY);
                    pontos[2] = new Point(startX + basePx / 2, startY - alturaPx);

                    g.DrawPolygon(caneta, pontos);
                    break;

                case Retangulo retangulo:
                    int baseR = (int)(retangulo.Largura * 10);
                    int alturaR = (int)(retangulo.Altura * 10);
                    int xR = (pictureBox1.Width - baseR) / 2;
                    int yR = (pictureBox1.Height - alturaR) / 2;
                    g.DrawRectangle(caneta, xR, yR, baseR, alturaR);
                    break;
                case Hexagono hexagono:
                    int ladoHex = (int)(hexagono.LadoHex * 10);
                    Point[] hexPontos = new Point[6];
                    for (int i = 0; i < 6; i++)
                    {
                        double angulo = Math.PI / 3 * i;
                        int xHex = (int)(pictureBox1.Width / 2 + ladoHex * Math.Cos(angulo));
                        int yHex = (int)(pictureBox1.Height / 2 + ladoHex * Math.Sin(angulo));
                        hexPontos[i] = new Point(xHex, yHex);
                    }
                    g.DrawPolygon(caneta, hexPontos);
                    break;

                case Octagono octagono:
                    int ladooct = (int)(octagono.LadoOct * 10);
                    Point[] octPontos = new Point[8];
                    for (int i = 0; i < 8; i++)
                    {
                        double angulo = Math.PI / 4 * i;
                        int xOct = (int)(pictureBox1.Width / 2 + ladooct * Math.Cos(angulo));
                        int yOct = (int)(pictureBox1.Height / 2 + ladooct * Math.Sin(angulo));
                        octPontos[i] = new Point(xOct, yOct);
                    }
                    g.DrawPolygon(caneta, octPontos);
                    break;
                case Pentagono pentagono:
                    int ladoPent = (int)(pentagono.LadoPent * 10);
                    Point[] pentPontos = new Point[5];
                    for (int i = 0; i < 5; i++)
                    {
                        double angulo = 2 * Math.PI / 5 * i - Math.PI / 2;
                        int xPent = (int)(pictureBox1.Width / 2 + ladoPent * Math.Cos(angulo));
                        int yPent = (int)(pictureBox1.Height / 2 + ladoPent * Math.Sin(angulo));
                        pentPontos[i] = new Point(xPent, yPent);
                    }
                    g.DrawPolygon(caneta, pentPontos);
                    break;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string forma = comboBox1.SelectedItem.ToString();

            // Oculta todos
            lblValor.Visible = txtValor.Visible = false;
            lblBase.Visible = txtBase.Visible = false;
            lblAltura.Visible = txtAltura.Visible = false;
            lblLado1.Visible = txtLado1.Visible = false;
            lblLado2.Visible = txtLado2.Visible = false;

            if (forma == "Quadrado" || forma == "Círculo")
            {
                lblValor.Visible = txtValor.Visible = true;
                lblValor.Text = forma == "Quadrado" ? "Lado:" : "Raio:";
            }
            else if (forma == "Triangulo")
            {
                lblBase.Visible = txtBase.Visible = true;
                lblAltura.Visible = txtAltura.Visible = true;
                lblLado1.Visible = txtLado1.Visible = true;
                lblLado2.Visible = txtLado2.Visible = true;
            }
            else if (forma == "Retangulo")
            {
                lblBase.Visible = txtBase.Visible = true;
                lblAltura.Visible = txtAltura.Visible = true;
            }
            else if (forma == "Hexagono")
            {
                lblValor.Visible = txtValor.Visible = true;
                lblValor.Text = "Lado:";
            }
            else if (forma == "Octagono")
            {
                lblValor.Visible = txtValor.Visible = true;
                lblValor.Text = "Lado:";
            }
            else if (forma == "Pentagono")
            {
                lblValor.Visible = txtValor.Visible = true;
                lblValor.Text = "Lado:";
            }
        }

        private void lblPerimetro_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
