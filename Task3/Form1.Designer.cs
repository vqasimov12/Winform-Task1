namespace Task3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Az = new PictureBox();
            button = new Button();
            label1 = new Label();
            Timer = new TextBox();
            Eng = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Az).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Eng).BeginInit();
            SuspendLayout();
            // 
            // Az
            // 
            Az.Image = (Image)resources.GetObject("Az.Image");
            Az.Location = new Point(62, 109);
            Az.Name = "Az";
            Az.Size = new Size(615, 329);
            Az.SizeMode = PictureBoxSizeMode.StretchImage;
            Az.TabIndex = 0;
            Az.TabStop = false;
            // 
            // button
            // 
            button.BackColor = Color.Aqua;
            button.FlatStyle = FlatStyle.Popup;
            button.Location = new Point(62, 52);
            button.Name = "button";
            button.Size = new Size(94, 29);
            button.TabIndex = 1;
            button.Text = "Baku";
            button.UseVisualStyleBackColor = false;
            button.Click += button_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(368, 61);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 2;
            label1.Text = "Time";
            // 
            // Timer
            // 
            Timer.Location = new Point(440, 58);
            Timer.Name = "Timer";
            Timer.Size = new Size(162, 27);
            Timer.TabIndex = 3;
            // 
            // Eng
            // 
            Eng.Image = (Image)resources.GetObject("Eng.Image");
            Eng.Location = new Point(62, 109);
            Eng.Name = "Eng";
            Eng.Size = new Size(615, 329);
            Eng.SizeMode = PictureBoxSizeMode.StretchImage;
            Eng.TabIndex = 4;
            Eng.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Eng);
            Controls.Add(Timer);
            Controls.Add(label1);
            Controls.Add(button);
            Controls.Add(Az);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)Az).EndInit();
            ((System.ComponentModel.ISupportInitialize)Eng).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Az;
        private Button button;
        private Label label1;
        private TextBox Timer;
        private PictureBox Eng;
    }
}