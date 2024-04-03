namespace lab_8_c_
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private async void btnGenerate_Click(object sender, EventArgs e)
        {
            if(!int.TryParse(txtNumber.Text, out int number))
            {
                MessageBox.Show("Invalid input.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                lbFibonacci.Items.Clear();
                await Task.Run(() =>
                {
                    for (int i = 0; i < number; i++)
                    {
                        // Calculate and add Fibonacci numbers to the ListBox
                        int fibonacciNumber = FibonacciNumbers(i);
                        UpdateUI(fibonacciNumber);
                    }
                });


            }
        }

        public int FibonacciNumbers(int number)
        {
            if (number <= 1)
                return 1;
            return FibonacciNumbers(number - 1) + FibonacciNumbers(number - 2);
        }

        private void UpdateUI(int number)
        {
            // Invoke ListBox update on UI thread
            if (lbFibonacci.InvokeRequired)
            {
                lbFibonacci.Invoke(new MethodInvoker(delegate { lbFibonacci.Items.Add(number.ToString()); }));
            }
            else
            {
                lbFibonacci.Items.Add(number.ToString());
            }
        }
    }
}