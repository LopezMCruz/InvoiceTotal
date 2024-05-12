using System.Drawing.Printing;

namespace InvoiceTotal;

public partial class Form1 : Form
{
    private Button? btnCalculate;
    private Button? btnExit;
    private Panel? buttonPanel;

    private TextBox? txtSubtotal;
    private TextBox? txtDiscountPercent;
    private TextBox? txtDiscountAmount;
    private TextBox? txtTotal;
    public Form1()
    {
        InitializeComponent();
        InitializeUI();
    }

    private void InitializeUI()
    {
        // create main panel here
        TableLayoutPanel mainPanel = new TableLayoutPanel();
        mainPanel.Dock = DockStyle.Fill;
        this.Controls.Add(mainPanel);

        buttonPanel = new Panel();
        buttonPanel.Dock = DockStyle.Bottom;
        buttonPanel.Height = 50;
        this.Controls.Add(buttonPanel);

        TableLayoutPanel buttonLayout = new TableLayoutPanel();
        buttonLayout.Dock = DockStyle.Fill;
        buttonLayout.ColumnCount = 2;
        buttonLayout.RowCount = 1;
        buttonLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        buttonLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent,50F));
        buttonPanel.Controls.Add(buttonLayout);

        AddControl(mainPanel, CreateLabel("&Subtotal"), 0, 0);
        AddControl(mainPanel, CreateLabel("&Discount Percent"), 0, 1);
        AddControl(mainPanel, CreateLabel("&Discount Amount"), 0, 2);
        AddControl(mainPanel, CreateLabel("&Total"), 0, 3);
        AddControl(mainPanel, CreateTextBox(false, "txtSubtotal"), 1, 0);
        AddControl(mainPanel, CreateTextBox(true,"txtDiscountPercent"),1,1 );
        AddControl(mainPanel, CreateTextBox(true,"txtDiscountAmount"),1,2 );
        AddControl(mainPanel, CreateTextBox(true,"txtTotal"),1,3);

        btnCalculate = CreateButton("btnCalculate", "&Calculate");
        btnExit = CreateButton("btnExit","&Exit");

        buttonLayout.Controls.Add(btnCalculate, 0, 0);
        buttonLayout.Controls.Add(btnExit, 1 , 0);
        
    }

    private Label CreateLabel(string text)
    {
        return new Label
        {
            Text = text,
            TextAlign = ContentAlignment.TopLeft,
            Dock = DockStyle.Fill,
            AutoSize = true
        };
    }

    private Button CreateButton(string text, string name)
    {
        Button button = new Button();
        button.Text = text;
        button.Name = name;
        button.UseVisualStyleBackColor = true;

        button.Padding = new Padding(5);
        button.Margin = new Padding(4);
        button.Font = new Font("Arial", 10, FontStyle.Bold);
        button.Dock = DockStyle.Fill;

        return button;
    }

    private TextBox CreateTextBox(bool readOnly, string name)
    {
        return new TextBox
        {
            ReadOnly = readOnly,
            Name = name,
            Dock = DockStyle.Fill
        };
    }

    private void AddControl(TableLayoutPanel panel, Control control, int column, int row)
    {
        panel.Controls.Add(control, column, row);
    }

    private void AttachEventHandlers()
    {
        Console.Write("DO THIS LATER");
        //btnCalculate.Click += Calculate_Click;
        //btnExit.Click += Exit_Click;
    }

    private void Exit_Click(object? sender, EventArgs e)
    {
        this.Close();
    }

    private void Calculate_Click(object? sender, EventArgs e)
        {
            if (decimal.TryParse(txtSubtotal?.Text, out decimal subtotal))
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

                txtDiscountPercent!.Text = (discountPercent * 100).ToString("0.00") + "%";
                txtDiscountAmount!.Text = discountAmount.ToString("C");
                txtTotal!.Text = total.ToString("C");
            }
            else
            {
                MessageBox.Show("Please enter a valid input.");
            }
        }
}
