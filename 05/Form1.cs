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
            string zodiac = "";

            switch (month)
            {
                case 1: zodiac = (day <= 19) ? "摩羯座" : "水瓶座"; break;
                case 2: zodiac = (day <= 18) ? "水瓶座" : "雙魚座"; break;
                case 3: zodiac = (day <= 20) ? "雙魚座" : "牡羊座"; break;
                case 4: zodiac = (day <= 19) ? "牡羊座" : "金牛座"; break;
                case 5: zodiac = (day <= 20) ? "金牛座" : "雙子座"; break;
                case 6: zodiac = (day <= 21) ? "雙子座" : "巨蟹座"; break;
                case 7: zodiac = (day <= 22) ? "巨蟹座" : "獅子座"; break;
                case 8: zodiac = (day <= 22) ? "獅子座" : "處女座"; break;
                case 9: zodiac = (day <= 22) ? "處女座" : "天秤座"; break;
                case 10: zodiac = (day <= 23) ? "天秤座" : "天蠍座"; break;
                case 11: zodiac = (day <= 21) ? "天蠍座" : "射手座"; break;
                case 12: zodiac = (day <= 21) ? "射手座" : "摩羯座"; break;
            }

            label3.Text = $"你的星座是{zodiac}";

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

            label3.Text += ($"\n你的生命靈數{sum}：");

            string filePath = "生命靈數.txt";

            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath, System.Text.Encoding.UTF8);

                bool isInConstellationBlock = false;
                string fortuneResult = "找不到對應的運勢分析。"; // 找不到的話

                foreach (string line in lines)
                {
                    if (line.Contains("【") && line.Contains(zodiac))
                    {
                        isInConstellationBlock = true; 
                        continue; // 跳過標題 看下一行
                    }

                    if (line.Contains("【") && !line.Contains(zodiac) && isInConstellationBlock)
                    {
                        break;
                    }

                    if (isInConstellationBlock && line.Contains($"生命靈數{sum}："))
                    {
                        fortuneResult = line.Replace($"生命靈數{sum}：", "").Trim();
                        break; 
                    }
                }

                label3.Text += $"{fortuneResult}";
            }
            else
            {
                label3.Text += "(找不到生命靈數檔案";
            }
        }
    }
}
