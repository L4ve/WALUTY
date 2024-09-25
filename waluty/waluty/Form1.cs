namespace waluty
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string value = textBox4.Text;

            textBox1.Text = value;
            float number = float.Parse(value);
            if (radioButton4.Checked) {
                textBox1.Text = (number*3.81f).ToString();
                //USD
            }
            if (radioButton1.Checked)
            {
                textBox1.Text = (number * 4.26f).ToString();
                //EURO
            }
            if (radioButton2.Checked)
            {
                textBox1.Text = (number * 24.27f).ToString();
                //RUB
            }
            if (radioButton3.Checked)
            {
                textBox1.Text = (number * 92.76f).ToString();
                //HUF
            }

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            string value = textBox4.Text;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
