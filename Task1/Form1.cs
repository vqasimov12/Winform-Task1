namespace Task1;

public partial class Form1 : Form
{
    int begin_x;
    int begin_y;
    int stop_x;
    int stop_y;
    int size_x;
    int size_y;
    int count = 0;
    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_MouseDown(object sender, MouseEventArgs e)
    {
        begin_x = e.X;
        begin_y = e.Y;
    }

    private void Form1_MouseUp(object sender, MouseEventArgs e)
    {
        stop_x = e.X;
        stop_y = e.Y;
        size_x = (stop_x > begin_x ? stop_x - begin_x : begin_x - stop_x);
        size_y = (stop_y > begin_y ? stop_y - begin_y : begin_y - stop_y);
        //size_x = size_x < 10 ? 10 : size_x;
        //size_y = size_y < 10 ? 10 : size_y;
        if (size_x < 10 || size_y < 10)
        {
            MessageBox.Show("Size can not be less than 10", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        Label label = new Label();
        Size size = new(size_x, size_y);
        label.Size = size;
        label.BackColor = Color.Red;
        label.Text = $"Label {++count}";
        label.Location = new Point(stop_x > begin_x ? begin_x : stop_x, stop_y > begin_y ? begin_y : stop_y);
        label.DoubleClick += LabelDoubleClick;
        label.MouseClick += LabelMouseClick;
        label.TextAlign = ContentAlignment.MiddleCenter;
        Controls.Add(label);
    }
    private void LabelDoubleClick(object? sender, EventArgs? e)
    {
        if (sender is Label l)
            l.Visible = false;
    }

    private void LabelMouseClick(object? sender, EventArgs e)
    {
        if (e is MouseEventArgs mouseEventArgs && mouseEventArgs.Button == MouseButtons.Right)
        {
            MessageBox.Show($"X: {(stop_x > begin_x ? begin_x : stop_x)}\nY: " +
                $"{(stop_y > begin_y ? begin_y : stop_y)}\nSize: {size_x} x {size_y}", "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else 
            LabelDoubleClick(sender, null);
    }



}