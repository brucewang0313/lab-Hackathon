namespace _05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int month = dateTimePicker1.Value.Month;
            int day = dateTimePicker1.Value.Day;

            switch (month)
            {
                case 1:
                    label3.Text = (day <= 19) ? "你的星座是摩羯座" : "你的星座是水瓶座";
                    break;
                case 2:
                    label3.Text = (day <= 18) ? "你的星座是水瓶座" : "你的星座是雙魚座";
                    break;
                case 3:
                    label3.Text = (day <= 20) ? "你的星座是雙魚座" : "你的星座是牡羊座";
                    break;
                case 4:
                    label3.Text = (day <= 19) ? "你的星座是牡羊座" : "你的星座是金牛座";
                    break;
                case 5:
                    label3.Text = (day <= 20) ? "你的星座是金牛座" : "你的星座是雙子座";
                    break;
                case 6:
                    label3.Text = (day <= 21) ? "你的星座是雙子座" : "你的星座是巨蟹座";
                    break;
                case 7:
                    label3.Text = (day <= 22) ? "你的星座是巨蟹座" : "你的星座是獅子座";
                    break;
                case 8:
                    label3.Text = (day <= 22) ? "你的星座是獅子座" : "你的星座是處女座";
                    break;
                case 9:
                    label3.Text = (day <= 22) ? "你的星座是處女座" : "你的星座是天秤座";
                    break;
                case 10:
                    label3.Text = (day <= 23) ? "你的星座是天秤座" : "你的星座是天蠍座";
                    break;
                case 11:
                    label3.Text = (day <= 21) ? "你的星座是天蠍座" : "你的星座是射手座";
                    break;
                case 12:
                    label3.Text = (day <= 21) ? "你的星座是射手座" : "你的星座是摩羯座";
                    break;
            }

            var dateTime = dateTimePicker1.Value.ToString("yyyyMMdd");
            var sum = 0;
            do
            {
                sum = 0;
                foreach (var num in dateTime)
                {
                    sum += int.Parse(num.ToString());
                }
                dateTime = sum.ToString();
            } while (sum > 9);

            label3.Text += ($"\n{sum}");
        }
    }
}
