using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THA_Week7_Ros_Diana
{
    public partial class Dragon : Form
    {
        Panel panel2 = new Panel();
        List<Button> buttonlistjam10 = new List<Button>();
        List<Button> buttonlistjam12 = new List<Button>();
        List<Button> buttonlistjam14 = new List<Button>();
        Random seatrandom = new Random();
        Label save = new Label();
        int b = 0;
        int c = 0;
        int pilih = 0;
        int tambah = 0;
        int nyoba = 0;

        private Form1 form1;
        public Dragon(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void waktukursi_Load(object sender, EventArgs e)
        {
           
            Label movie1 = new Label();
            movie1.AutoSize = true;
            movie1.Location = new Point(80, 70);
            movie1.Size = new Size(300, 300);
            movie1.Text = "Dragon";
            Font = new Font("Arial", 16, FontStyle.Bold);
            Controls.Add(movie1);

            save.AutoSize = true;
            save.Location = new Point(300, 350);
            save.Size = new Size(300, 300);
            save.Text = "Seat Choose ";
            Controls.Add(save);

            PictureBox picture = new PictureBox();
            picture.Location = new Point(40, 104);
            picture.Size = new Size(170, 230);
            picture.SizeMode = PictureBoxSizeMode.StretchImage;
            picture.Image = Image.FromFile("C:\\UC Student\\Semester 2\\Application Development\\THA_W7_Ros_Diana\\THA_W7_Ros_Diana\\Poster\\Dragon.JPG");
            this.Controls.Add(picture);

            Button jam1 = new Button();
            jam1.Location = new Point(10, 350);
            jam1.Size = new Size(74, 29);
            jam1.Text = "10.00";
            jam1.UseVisualStyleBackColor = false;
            Controls.Add(jam1);
            jam1.Click += Jam10_Click;

            Button jam2 = new Button();
            jam2.Location = new Point(100, 350);
            jam2.Size = new Size(74, 29);
            jam2.Text = "12.00";
            jam2.UseVisualStyleBackColor = false;
            Controls.Add(jam2);
            jam2.Click += Jam12_Click;

            Button jam3 = new Button();
            jam3.Location = new Point(190, 350);
            jam3.Size = new Size(74, 29);
            jam3.Text = "14.00";
            jam3.UseVisualStyleBackColor = false;
            Controls.Add(jam3);
            jam3.Click += Jam14_Click;

            Button back = new Button();
            back.Location = new Point(19, 15);
            back.Size = new Size(84, 34);
            back.BackColor = Color.LightSlateGray;
            back.Text = "Back";
            back.UseVisualStyleBackColor = false;
            Controls.Add(back);
            back.Click += back_Click;

            panel2.Location = new Point(250, 10);
            panel2.Size = new Size(280, 290);
            Controls.Add(panel2);

            Button reset = new Button();
            reset.Location = new Point(300, 300);
            reset.Size = new Size(84, 34);
            reset.BackColor = Color.LightSlateGray;
            reset.Text = "OK";
            reset.UseVisualStyleBackColor = false;
            Controls.Add(reset);
            reset.Click += oke_Click;

            Button oke = new Button();
            oke.Location = new Point(400, 300);
            oke.Size = new Size(84, 34);
            oke.BackColor = Color.LightSlateGray;
            oke.Text = "Reset";
            oke.UseVisualStyleBackColor = false;
            Controls.Add(oke);
            oke.Click += reset_Click;

            panel2.Controls.Clear();
            for (int i = 0; i < 10; i++)
            {
                for (int a = 0; a < 10; a++)
                {
                    Button button3 = new Button();
                    button3.Tag = "(" + a.ToString() + "," + i.ToString() + ") ";
                    button3.Size = new Size(27, 27);
                    button3.Location = new Point(4 + b, 8 + c);
                    button3.BackColor = Color.MediumSeaGreen;
                    button3.Click += Button3_Click;
                    buttonlistjam14.Add(button3);
                    tambah++;
                    b += 27;
                }
                b = 0;
                c += 27;
            }

            for (int i = 0; i < 70; i++)
            {
                int acak = seatrandom.Next(0, 100);
                buttonlistjam14[acak].BackColor = Color.Red;
                buttonlistjam14[acak].Enabled = false;
            }

            b = 0;
            c = 0;
            panel2.Controls.Clear();
            for (int i = 0; i < 10; i++)
            {
                for (int a = 0; a < 10; a++)
                {
                    Button button2 = new Button();
                    button2.Tag = "(" + a.ToString() + "," + i.ToString() + ") ";
                    button2.Size = new Size(27, 27);
                    button2.Location = new Point(4 + b, 8 + c);
                    button2.BackColor = Color.MediumSeaGreen;
                    button2.Click += Button2_Click;
                    buttonlistjam12.Add(button2);
                    tambah++;
                    b += 27;
                }
                b = 0;
                c += 27;
            }

            for (int i = 0; i < 70; i++)
            {
                int acak = seatrandom.Next(0, 100);
                buttonlistjam12[acak].BackColor = Color.Red;
                buttonlistjam12[acak].Enabled = false;
            }

            b = 0;
            c = 0;
            panel2.Controls.Clear();
            for (int i = 0; i < 10; i++)
            {
                for (int a = 0; a < 10; a++)
                {
                    Button button1 = new Button();
                    button1.Tag = "(" + a.ToString() + "," + i.ToString() + ") ";
                    button1.Size = new Size(27, 27);
                    button1.Location = new Point(4 + b, 8 + c);
                    button1.BackColor = Color.MediumSeaGreen;
                    button1.Click += Button1_Click;
                    buttonlistjam10.Add(button1);
                    tambah++;
                    b += 27;
                }
                b = 0;
                c += 27;
            }

            for (int i = 0; i < 70; i++)
            {
                int acak = seatrandom.Next(0, 100);
                buttonlistjam10[acak].BackColor = Color.Red;
                buttonlistjam10[acak].Enabled = false;
            }

        }

        private void reset_Click(object sender, EventArgs e)
        {
            if (nyoba == 1)
            {
                foreach (Button button in buttonlistjam10)
                {
                    if (button.BackColor == Color.YellowGreen)
                    {
                        button.BackColor = Color.MediumSeaGreen;

                    }
                    if (button.BackColor == Color.Red)
                    {

                        button.BackColor = Color.MediumSeaGreen;
                        button.Enabled = true;
                        save.Text = "Seat Choose : ";
                    }
                }
            }

            if (nyoba == 2)
            {
                foreach (Button button in buttonlistjam12)
                {
                    if (button.BackColor == Color.YellowGreen)
                    {
                        button.BackColor = Color.MediumSeaGreen;

                    }
                    if (button.BackColor == Color.Red)
                    {

                        button.BackColor = Color.MediumSeaGreen;
                        button.Enabled = true;
                        save.Text = "Seat Choose : ";
                    }
                }
            }

            if (nyoba == 3)
            {
                foreach (Button button in buttonlistjam14)
                {
                    if (button.BackColor == Color.YellowGreen)
                    {
                        button.BackColor = Color.MediumSeaGreen;

                    }
                    if (button.BackColor == Color.Red)
                    {

                        button.BackColor = Color.MediumSeaGreen;
                        button.Enabled = true;
                        save.Text = "Seat Choose : ";
                    }
                }
            }
            else
            {
                MessageBox.Show("Pilih jam tayang dulu");
            }

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();

            foreach (Button seat in buttonlistjam14)
            {
                panel2.Controls.Add(seat);
            }
            Button button = sender as Button;
            if (button.BackColor == Color.MediumSeaGreen)
            {
                button.BackColor = Color.YellowGreen;
                save.Text += button.Tag.ToString();
            }
           
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();

            foreach (Button seat in buttonlistjam12)
            {
                panel2.Controls.Add(seat);
            }
            Button button = sender as Button;
            if (button.BackColor == Color.MediumSeaGreen)
            {
                button.BackColor = Color.YellowGreen;
                save.Text += button.Tag.ToString();
            }
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();

            foreach (Button seat in buttonlistjam10)
            {
                panel2.Controls.Add(seat);
            }
            Button button = sender as Button;
            if (button.BackColor == Color.MediumSeaGreen)
            {
                button.BackColor = Color.YellowGreen;
                save.Text += button.Tag.ToString();
            }
            
        }



        private void oke_Click(object sender, EventArgs e)
        {
            if (pilih == 1)
            {
                foreach (Button button in buttonlistjam10)
                {
                    if (button.BackColor == Color.YellowGreen)
                    {
                        button.BackColor = Color.Red;
                        button.Enabled = false;
                    }
                }
            }
            if (pilih == 2)
            {
                foreach (Button button in buttonlistjam12)
                {
                    if (button.BackColor == Color.YellowGreen)
                    {
                        button.BackColor = Color.Red;
                        button.Enabled = false;
                    }
                }
            }
            if (pilih == 3)
            {
                foreach (Button button in buttonlistjam14)
                {
                    if (button.BackColor == Color.YellowGreen)
                    {
                        button.BackColor = Color.Red;
                        button.Enabled = false;
                    }
                }
            }
            else
            {
                MessageBox.Show("Pilih jam tayang dulu");
            }
        }

        private void Jam14_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            pilih = 3;
            nyoba = 3;
            foreach (Button seat in buttonlistjam14)
            {
                panel2.Controls.Add(seat);
                save.Text = "Seat Choose : ";
            }
        }
        private void Jam12_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            pilih = 2;
            nyoba = 2;
            foreach (Button seat in buttonlistjam12)
            {
                panel2.Controls.Add(seat);
                save.Text = "Seat Choose : ";
            }
        }

        private void Jam10_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            pilih = 1;
            nyoba = 1;
            foreach (Button seat in buttonlistjam10)
            {
                panel2.Controls.Add(seat);
                save.Text = "Seat Choose : ";
            }

        }

        private void back_Click(object sender, EventArgs e)
        {
           form1.backshow();
        }
    }
}
