namespace _02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Numberbutton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text += button.Text;
        }

        private void changebutton_Click(object sender, EventArgs e)
        {
            var input = double.Parse(textBox1.Text);
            double output = 0;
            if (radioButton1.Checked)
            {
                output = 9.0 / 5.0 * input + 32;
                label1.Text = $"結果：{input}℃={output}℉";
            }
            else if (radioButton2.Checked)
            {
                output = (input - 32) * 5.0 / 9.0;
                label1.Text = $"結果：{input}℉={output}℃";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            radioButton1.Checked = true;
            label1.Text = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains("."))
            {
                textBox1.Text += ".";
            }
        }
    }
}
