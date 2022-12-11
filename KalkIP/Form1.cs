namespace KalkIP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string czesc1 = textBox1.Text;
            string czesc2 = textBox2.Text;
            string czesc3 = textBox3.Text;
            string czesc4 = textBox4.Text;


            int ip1 = int.Parse(czesc1);
            int Ip2 = int.Parse(czesc2);
            int iP3 = int.Parse(czesc3);
            int IP4 = int.Parse(czesc4);

            if (ip1 < 0 || ip1 > 255 &&
                Ip2 < 0 || Ip2 > 255 &&
                iP3 < 0 || iP3 > 255 &&
                IP4 < 0 || IP4 > 255)
            {
                label3.Text = "zle";
            }else { label3.Text = "Git"; }
            if(ip1 < 127) { label5.Text = "A"; }
            else if (ip1 < 192) { label5.Text = "B"; }
            else if (ip1 < 224) { label5.Text = "C"; }
            else if (ip1 < 240) { label5.Text = "D"; }
            else if (ip1 < 248) { label5.Text = "E"; }
            else if (ip1 < 255) { label5.Text = "F"; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}