namespace CalculosGeometricos;

public partial class Form1 : Form
{
    ComboBox cmbFiguras;
    ComboBox cmbCalculos;
    Button btnCalcular;
    TextBox txtResultado;
    Label lblCampo1;
    Label lblCampo2;
    Label lblCampo3;
    TextBox txtCampo1;
    TextBox txtCampo2;
    TextBox txtCampo3;
    public Form1()
    {
        InitializeComponent();
        inicializarComponentes();
    }
    public void inicializarComponentes()
    {
        this.Size = new Size(300, 310);

        Label lblfigura = new Label();
        lblfigura.Text = "Figura";
        lblfigura.Location = new Point(13, 13);
        lblfigura.Size = new Size(50, 20);
        this.Controls.Add(lblfigura);

        cmbFiguras = new ComboBox();
        cmbFiguras.Items.Add("Cuadrado");
        cmbFiguras.Items.Add("Rectangulo");
        cmbFiguras.Items.Add("Triangulo");
        cmbFiguras.Items.Add("Rombo");
        cmbFiguras.Size = new Size(110, 23);
        cmbFiguras.Location = new Point(13, 40);
        this.Controls.Add(cmbFiguras);

        Label lblCalculo = new Label();
        lblCalculo.Text = "Calculo";
        lblCalculo.AutoSize = true;
        lblCalculo.Location = new Point(150, 15);
        this.Controls.Add(lblCalculo);

        cmbCalculos = new ComboBox();
        cmbCalculos.Items.Add("Area");
        cmbCalculos.Items.Add("Perimetro");
        cmbFiguras.Size = new Size(110, 23);
        cmbCalculos.Location = new Point(151, 40);
        this.Controls.Add(cmbCalculos);

        btnCalcular = new Button();
        btnCalcular.Text = "Calcular";
        btnCalcular.AutoSize = true;
        btnCalcular.Location = new Point(151, 190);
        this.Controls.Add(btnCalcular);

        Label lblResultado = new Label();
        lblResultado.Text = "Resultado";
        lblResultado.AutoSize = true;
        lblResultado.Location = new Point(15, 230);
        this.Controls.Add(lblResultado);

        txtResultado = new TextBox();
        txtResultado.Size = new Size(100, 30);
        txtResultado.Location = new Point(90, 230);
        this.Controls.Add (txtResultado);

        //asignar eventos a combobox
        cmbFiguras.SelectedIndexChanged += new EventHandler(cmb_SelectedIndexChange);
        cmbCalculos.SelectedIndexChanged += new EventHandler(cmb_SelectedIndexChange);

        //valores de campos genericos

        //Profe esta parte la tuve que modificar de como esta en el video porque me daba error y se hacia una interrupcion
        lblCampo1 = new Label();
        lblCampo1.Text = "";
        lblCampo1.AutoSize = true;
        lblCampo1.Location = new Point(15, 80);
        this.Controls.Add(lblCampo1);
        lblCampo2 = new Label();
        lblCampo2.Text = "";
        lblCampo2.AutoSize = true;
        lblCampo2.Location = new Point(15, 110);
        this.Controls.Add(lblCampo2);
        lblCampo3 = new Label();
        lblCampo3.Text = "";
        lblCampo3.AutoSize = true;
        lblCampo3.Location = new Point(15, 140);
        this.Controls.Add(lblCampo3);

        txtCampo1 = new TextBox();
        txtCampo1.Size = new Size(80, 20);
        txtCampo1.Location = new Point(100, 80);
        lblCampo1.Visible = false;
        txtCampo1.Visible = false;
        this.Controls.Add(txtCampo1);
        txtCampo2 = new TextBox();
        txtCampo2.Size = new Size(80, 20);
        txtCampo2.Location = new Point(100, 110);
        lblCampo2.Visible = false;
        txtCampo2.Visible = false;
        this.Controls.Add(txtCampo2);
        txtCampo3 = new TextBox();
        txtCampo3.Size = new Size(80, 20);
        txtCampo3.Location = new Point(100, 140);
        lblCampo3.Visible = false;
        txtCampo3.Visible = false;
        this.Controls.Add(txtCampo3);

        //evento click al boton
        btnCalcular.Click += new EventHandler(btnCalcular_Click);
    }

    private void cmb_SelectedIndexChange(object sender, EventArgs e)
    {
        if (this.cmbCalculos.SelectedIndex != -1 && this.cmbFiguras.SelectedIndex != -1)
        {
            switch (this.cmbFiguras.SelectedItem)
            {
                case "Cuadrado":
                    if(this.cmbCalculos.SelectedItem == "Perimetro")
                    {
                        lblCampo1.Text = "Lado";
                        lblCampo1.Visible = true;
                        txtCampo1.Visible = true;
                    }
                    else
                    {
                        lblCampo1.Text = "Lado";
                        lblCampo1.Visible = true;
                        txtCampo1.Visible = true;
                    }
                    break;
                case "Triangulo":
                    if (this.cmbCalculos.SelectedItem == "Perimetro")
                    {
                        lblCampo1.Text = "Lado a";
                        lblCampo1.Visible = true;
                        txtCampo1.Visible = true;
                        lblCampo2.Text = "Lado b";
                        lblCampo2.Visible = true;
                        txtCampo2.Visible = true;
                        lblCampo3.Text = "Lado c";
                        lblCampo3.Visible = true;
                        txtCampo3.Visible = true;
                    }
                    else 
                    {
                        lblCampo1.Text = "Base b";
                        lblCampo1.Visible = true;
                        txtCampo1.Visible = true;
                        lblCampo2.Text = "Altura h";
                        lblCampo2.Visible = true;
                        txtCampo2.Visible = true;
                    }
                    break;
                case "Rectangulo":
                    if (this.cmbCalculos.SelectedItem == "Perimetro")
                    {
                        lblCampo1.Text = "Lado a";
                        lblCampo1.Visible = true;
                        txtCampo1.Visible = true;
                        lblCampo2.Text = "Lado b";
                        lblCampo2.Visible = true;
                        txtCampo2.Visible = true;
                    }
                    else
                    {
                        lblCampo1.Text = "Lado a";
                        lblCampo1.Visible = true;
                        txtCampo1.Visible = true;
                        lblCampo2.Text = "Lado b";
                        lblCampo2.Visible = true;
                        txtCampo2.Visible = true;
                    }
                    break;
                case "Rombo":
                    if (this.cmbCalculos.SelectedItem == "Perimetro")
                    {
                        lblCampo1.Text = "Lado";
                        lblCampo1.Visible = true;
                        txtCampo1.Visible = true;
                    }
                    else
                    {
                        lblCampo1.Text = "D mayor";
                        lblCampo1.Visible = true;
                        txtCampo1.Visible = true;
                        lblCampo2.Text = "d menor";
                        lblCampo2.Visible = true;
                        txtCampo2.Visible = true;
                    }
                    break;
                default:
                    break;
            }
        }
    }

    private void btnCalcular_Click(object sender, EventArgs e)
    {
        if (this.cmbCalculos.SelectedIndex != -1 && this.cmbFiguras.SelectedIndex != -1)
        {
            switch (this.cmbFiguras.SelectedItem)
            {
                case "Cuadrado":
                    if (this.cmbCalculos.SelectedItem == "Perimetro")
                    {
                        double lado = double.Parse(txtCampo1.Text);
                        double resultado = 4 * lado;
                        txtResultado.Text = resultado.ToString();
                    }
                    else
                    {
                        double lado = double.Parse(txtCampo1.Text);
                        double resultado = lado * lado;
                        txtResultado.Text = resultado.ToString();
                    }
                    break;
                case "Triangulo":
                    if (this.cmbCalculos.SelectedItem == "Perimetro")
                    {
                        double a = double.Parse(txtCampo1.Text);
                        double b = double.Parse(txtCampo2.Text);
                        double c = double.Parse(txtCampo3.Text);
                        double resultado = a + b + c;
                        txtResultado.Text = resultado.ToString();
                    }
                    else
                    {
                        double b = double.Parse(txtCampo1.Text);
                        double h = double.Parse(txtCampo2.Text);
                        double resultado = (b * h) / 2;
                        txtResultado.Text = resultado.ToString();
                    }
                    break;
                case "Rectangulo":
                    if (this.cmbCalculos.SelectedItem == "Perimetro")
                    {
                        double a = double.Parse(txtCampo1.Text);
                        double b = double.Parse(txtCampo2.Text);
                        double resultado = 2 * a + 2 * b;
                        txtResultado.Text = resultado.ToString();
                    }
                    else
                    {
                        double a = double.Parse(txtCampo1.Text);
                        double b = double.Parse(txtCampo2.Text);
                        double resultado = a * b;
                        txtResultado.Text = resultado.ToString();
                    }
                    break;
                case "Rombo":
                    if (this.cmbCalculos.SelectedItem == "Perimetro")
                    {
                        double lado = double.Parse(txtCampo1.Text);
                        double resultado = 4 * lado;
                        txtResultado.Text = resultado.ToString();
                    }
                    else
                    {
                        double D = double.Parse(txtCampo1.Text);
                        double d = double.Parse(txtCampo2.Text);
                        double resultado = (D * d) / 2;
                        txtResultado.Text = resultado.ToString();
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
