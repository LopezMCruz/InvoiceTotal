namespace InvoiceTotal;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        TextBox textBox = new TextBox();
        textBox.Width = 100;
        this.Controls.Add(textBox);
    }

    private void Button_Click(object? sender, EventArgs e)
    {
        MessageBox.Show("Button clicked!");
    }

}
