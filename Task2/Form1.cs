namespace Task2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            if (sender is Label label)
            {
                Random random = new Random();
                int a = random.Next(ClientSize.Width - label1.Width);
                int b = random.Next(ClientSize.Height - label1.Height);
                label.Location = Point.Add(new Point(a, b), (Size)label1.Location);
            }
        }

    }
}