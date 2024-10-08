namespace _01_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void buttonNWD_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            labelResult.Text = $"Wynik: {NWD(a, b)}";
        }

        private void buttonNWW_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            labelResult.Text = $"Wynik: {NWW(a, b)}";
        }

        private void buttomBye_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "bye" || textBox2.Text == "bye")
                Close();
        }

        private void dateNow_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DateTime.Now.ToString(@"dd \\ MM \\ yyyy"));
        }

        private void timeNow_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DateTime.Now.ToString("t"));
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public int NWW(int a, int b)
        {
            int temp;
            int iloczyn = a * b;
            while (b > 0)
            {
                temp = b;
                b = a % b;
                a = temp;
            }

            return iloczyn / a;
        }

        public int NWD(int a, int b)
        {
            int temp;

            while (b > 0)
            {
                temp = b;
                b = a % b;
                a = temp;
            }

            return a;
        }

    }
}
