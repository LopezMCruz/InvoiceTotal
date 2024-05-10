namespace InvoiceTotal;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        TextBox textBox = new TextBox();
        Label subtotalLabel = new Label();
        
        textBox.Name = "txtSubTotal";
        textBox.TabIndex = 1;
        
        subtotalLabel.Text = "&Subtotal";
        subtotalLabel.TextAlign = ContentAlignment.MiddleLeft;
        subtotalLabel.TabIndex = 0;
        this.Controls.Add(textBox);
        this.Controls.Add(subtotalLabel);
    }

}
