namespace Kapsülleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Ev home = new Ev();
            home.FİYAT = 1000000;
            home.TUR = "Villa";

            label4.Text = home.FİYAT.ToString();
            label5.Text = home.TUR;
        }
    }
}
