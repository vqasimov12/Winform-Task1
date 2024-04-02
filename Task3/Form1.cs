using System.Security.Cryptography.Xml;

namespace Task3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            System.Windows.Forms.Timer timer = new();
            timer.Interval = 1000;
            timer.Tick += timeIntervat;
            timer.Start();
            Eng.Visible = false;
            button.Text = "London";
        }
        public void timeIntervat(object? sender, EventArgs? e)
        {
            if (button.Text == "London")
                Timer.Text = DateTime.Now.ToString();
            else
                Timer.Text = DateTime.Now.AddHours(-3).ToString();

        }
        private void button_Click(object sender, EventArgs e)
        {
            if (button.Text == "London")
            {
                button.Text = "Baku";
                Az.Visible = false;
                Eng.Visible = true;
            }

            else
            {
                button.Text = "London";
                Az.Visible = true;
                Eng.Visible = false;

            }


        }
    }
}