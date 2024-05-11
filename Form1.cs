namespace InvoiceTotal;

public partial class Form1 : Form
{
    private TextBox txtSubtotal = new TextBox();
    private TextBox txtTotal = new TextBox();
    private TextBox txtDiscountAmount = new TextBox();

    private TextBox txtDiscountPercent = new TextBox();
    public Form1()
    {
        InitializeComponent();

        TableLayoutPanel panel = new TableLayoutPanel();
        panel.Dock = DockStyle.Fill;
        panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20));
        panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80));
        panel.RowStyles.Add(new RowStyle(SizeType.AutoSize));

        txtSubtotal.Name = "txtSubTotal";
        txtSubtotal.Dock = DockStyle.Fill;

        Label subtotalLabel = new Label();
        subtotalLabel.Text = "&Subtotal";
        subtotalLabel.TextAlign = ContentAlignment.TopLeft;
        subtotalLabel.Dock = DockStyle.Fill;
        subtotalLabel.AutoSize = true;


        txtDiscountPercent.ReadOnly = true;
        txtDiscountPercent.Name = "txtDiscountPercent";
        txtDiscountPercent.Dock = DockStyle.Fill;

        Label discountPercentLabel = new Label();
        discountPercentLabel.Text = "&Discount Percent";
        discountPercentLabel.TextAlign = ContentAlignment.TopLeft;
        discountPercentLabel.Dock = DockStyle.Fill;
        discountPercentLabel.AutoSize = true;


        txtDiscountAmount.ReadOnly = true;
        txtDiscountAmount.Name = "txtDiscountAmount";
        txtDiscountAmount.Dock = DockStyle.Fill;

        Label discountAmountLabel = new Label();
        discountAmountLabel.Text = "&Discount Amount";
        discountAmountLabel.TextAlign = ContentAlignment.TopLeft;
        discountAmountLabel.Dock = DockStyle.Fill;
        discountAmountLabel.AutoSize = true;


        txtTotal.ReadOnly = true;
        txtTotal.Name = "txtTotal";
        txtTotal.Dock = DockStyle.Fill;

        Label totalLabel = new Label();
        totalLabel.Text = "&Total";
        totalLabel.TextAlign = ContentAlignment.TopLeft;
        totalLabel.Dock = DockStyle.Fill;
        totalLabel.AutoSize = true;

        Button calculate = new Button();
        calculate.Name = "btnCalculate";
        calculate.Text = "&Calculate";
        calculate.Dock = DockStyle.Fill;
        calculate.Click += Calculate_Click;

        Button exit = new Button();
        exit.Name = "btnExit";
        exit.Text = "&Exit";
        exit.Dock = DockStyle.Fill;
        exit.Click += Exit_Click;



        void Calculate_Click(object? sender, EventArgs e)
        {
            if (decimal.TryParse(txtSubtotal.Text, out decimal subtotal))
            {
                decimal discountPercent = 0m;

                if (subtotal >= 500)
                {
                    discountPercent = .2m;
                }
                else if (subtotal < 500 && subtotal >= 350)
                {
                    discountPercent = .15m;
                }
                else if (subtotal < 350 & subtotal >= 200)
                {
                    discountPercent = .1m;
                }
                else
                {
                    discountPercent = 0m;
                }

                decimal discountAmount = subtotal * discountPercent;
                decimal total = subtotal - discountAmount;

                txtDiscountPercent.Text = (discountPercent * 100).ToString("0.00") + "%";
                txtDiscountAmount.Text = discountAmount.ToString("C");
                txtTotal.Text = total.ToString("C");
            }
            else
            {
                MessageBox.Show("Please enter a valid input.");
            }
        }
        panel.Controls.Add(subtotalLabel, 0, 0);
        panel.Controls.Add(txtSubtotal, 1, 0);
        panel.Controls.Add(discountPercentLabel, 0, 1);
        panel.Controls.Add(txtDiscountPercent, 1, 1);
        panel.Controls.Add(discountAmountLabel, 0, 2);
        panel.Controls.Add(txtDiscountAmount, 1, 2);
        panel.Controls.Add(totalLabel, 0, 3);
        panel.Controls.Add(txtTotal, 1, 3);
        panel.Controls.Add(calculate, 0, 4);
        panel.Controls.Add(exit, 1, 4);


        this.Controls.Add(panel);
    }

    private void Exit_Click(object? sender, EventArgs e)
    {
        this.Close();
    }

}
