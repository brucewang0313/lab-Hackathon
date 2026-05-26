namespace _04
{
    public partial class Form1 : Form
    {
        private List<int> randomNumbers = new List<int>();
        public Form1()
        {
            InitializeComponent();
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            textBox1.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            textBox1.Enabled = true;
            listBox1.Items.Clear();
            textBox1.Text = "";
            var numbers = Enumerable.Range(0, 10);
            randomNumbers = numbers.OrderBy(x => Guid.NewGuid())
                                       .Take(4)
                                       .ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"答案是{string.Join("", randomNumbers)}");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if ((int.TryParse(textBox1.Text, out int n) && textBox1.Text.Length == 4))
            {
                List<int> userNumbers = textBox1.Text.Select(c => (int)char.GetNumericValue(c)).ToList();

                int a = 0;
                int b = 0;

                for (int i = 0; i < 4; i++)
                {
                    if (userNumbers[i] == randomNumbers[i])
                    {
                        a++;
                    }
                    else if (randomNumbers.Contains(userNumbers[i]))
                    {
                        b++;
                    }
                }

                if (a == 4)
                {
                    listBox1.Items.Insert(0, $"你猜的 {textBox1.Text} ：{a}A{b}B");
                    MessageBox.Show($"答案就是 {textBox1.Text} ");

                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    textBox1.Enabled = false;
                    textBox1.Text = "";
                }
                else
                {
                    listBox1.Items.Insert(0, $"你猜的 {textBox1.Text} ：{a}A{b}B");
                    textBox1.Text = "";
                }
            }
            else
            {
                MessageBox.Show("請輸入四位數字:)");
                textBox1.Text = "";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            textBox1.Enabled = false;
            listBox1.Items.Clear();
            textBox1.Text = "";
            var numbers = Enumerable.Range(0, 10);
            randomNumbers = numbers.OrderBy(x => Guid.NewGuid())
                                       .Take(4)
                                       .ToList();
        }
    }
}
