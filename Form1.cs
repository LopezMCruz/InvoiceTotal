namespace InvoiceTotal;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();

        TableLayoutPanel panel = new TableLayoutPanel();
        panel.Dock = DockStyle.Fill;
        panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20));
        panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80));
        panel.RowStyles.Add(new RowStyle(SizeType.AutoSize));

        TextBox textBox = new TextBox();
        textBox.Name = "txtSubTotal";
        textBox.Dock = DockStyle.Fill;

        Label subtotalLabel = new Label();
        subtotalLabel.Text = "&Subtotal";
        subtotalLabel.TextAlign = ContentAlignment.TopLeft;
        subtotalLabel.Dock = DockStyle.Fill;
        subtotalLabel.AutoSize = true;

        TextBox discountPercent = new TextBox();
        discountPercent.ReadOnly = true;
        discountPercent.Name = "txtDiscountPercent";
        discountPercent.Dock = DockStyle.Fill;

        Label discountPercentLabel = new Label();
        discountPercentLabel.Text = "&Discount Percent";
        discountPercentLabel.TextAlign = ContentAlignment.TopLeft;
        discountPercentLabel.Dock = DockStyle.Fill;
        discountPercentLabel.AutoSize = true;

        TextBox discountAmount = new TextBox();
        discountAmount.ReadOnly = true;
        discountAmount.Name = "txtDiscountAmount";
        discountAmount.Dock = DockStyle.Fill;

        Label discountAmountLabel = new Label();
        discountAmountLabel.Text = "&Discount Amount";
        discountAmountLabel.TextAlign = ContentAlignment.TopLeft;
        discountAmountLabel.Dock = DockStyle.Fill;
        discountAmountLabel.AutoSize = true;

        TextBox total = new TextBox();
        total.ReadOnly = true;
        total.Name = "txtTotal";
        total.Dock = DockStyle.Fill;

        Label totalLabel = new Label();
        totalLabel.Text = "&Total";
        totalLabel.TextAlign = ContentAlignment.TopLeft;
        totalLabel.Dock = DockStyle.Fill;
        totalLabel.AutoSize = true;

        Button calculate = new Button();
        calculate.Name = "btnCalculate";
        calculate.Text = "&Calculate";
        calculate.Dock = DockStyle.Fill;

        Button exit = new Button();
        exit.Name = "btnExit";
        exit.Text = "&Exit";
        exit.Dock = DockStyle.Fill;


        panel.Controls.Add(subtotalLabel, 0, 0);
        panel.Controls.Add(textBox, 1, 0);
        panel.Controls.Add(discountPercentLabel, 0, 1);
        panel.Controls.Add(discountPercent, 1, 1);
        panel.Controls.Add(discountAmountLabel, 0, 2);
        panel.Controls.Add(discountAmount, 1, 2);
        panel.Controls.Add(totalLabel, 0, 3);
        panel.Controls.Add(total, 1, 3);
        panel.Controls.Add(calculate,0,4);
        panel.Controls.Add(exit,1,4);

        


        this.Controls.Add(panel);
    }

}
