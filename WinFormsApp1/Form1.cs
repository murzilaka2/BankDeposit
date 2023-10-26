namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            int period = int.Parse(groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(e => e.Checked).Tag.ToString());
            decimal sum = numericUpDown1.Value;
            decimal rate = numericUpDown2.Value;

            decimal result = sum * (rate / 100);
            ResultTextBox.Text = $"{sum + result} гривен.";
        }
    }
}