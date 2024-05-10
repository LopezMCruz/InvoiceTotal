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
        subtotalLabel.TextAlign = ContentAlignment.TopRight;
        subtotalLabel.Dock = DockStyle.Fill;
        subtotalLabel.AutoSize = true;

        TextBox discountPercent = new TextBox();
        discountPercent.ReadOnly = true;
        discountPercent.Name = "txtDiscountPercent";
        discountPercent.Dock = DockStyle.Fill;

        Label discountPercentLabel = new Label();
        discountPercentLabel.Text = "&Discount Percent";
        discountPercentLabel.TextAlign = ContentAlignment.TopRight;
        discountPercentLabel.Dock = DockStyle.Fill;
        discountPercentLabel.AutoSize = true;


        panel.Controls.Add(subtotalLabel, 0, 0);
        panel.Controls.Add(textBox, 1, 0);
        panel.Controls.Add(discountPercentLabel, 0, 1);
        panel.Controls.Add(discountPercent, 1, 1);

        this.Controls.Add(panel);
    }

}
