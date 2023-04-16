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
    public partial class Cinema : Form
    {
        private Form1 form1;
        public Cinema(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void Cinema_Load(object sender, EventArgs e)
        {
            PictureBox picture = new PictureBox();
            picture.Location = new Point(28, 10);
            picture.Size = new Size(100, 120);
            picture.SizeMode = PictureBoxSizeMode.StretchImage;
            picture.Image = Image.FromFile("C:\\UC Student\\Semester 2\\Application Development\\THA_W7_Ros_Diana\\THA_W7_Ros_Diana\\Poster\\Dragon.JPG");
            this.Controls.Add(picture);

            Label label = new Label();
            label.Text = "Dragon";
            label.Location = new Point(55, 135);
            label.AutoSize = true;
            this.Controls.Add(label);

            Button button = new Button();
            button.Location = new Point(35, 150);
            button.Size = new Size(90, 20);
            button.Text = "Check Movie";
            button.Click += button_Click;
            this.Controls.Add(button);

            PictureBox picture2 = new PictureBox();
            picture2.Location = new Point(160, 10);
            picture2.Size = new Size(100, 120);
            picture2.SizeMode = PictureBoxSizeMode.StretchImage;
            picture2.Image = Image.FromFile("C:\\UC Student\\Semester 2\\Application Development\\THA_W7_Ros_Diana\\THA_W7_Ros_Diana\\Poster\\Home.JPG");
            this.Controls.Add(picture2);

            Label label2 = new Label();
            label2.Text = "Home";
            label2.Location = new Point(190, 135);
            label2.AutoSize = true;
            this.Controls.Add(label2);

            Button button2 = new Button();
            button2.Location = new Point(166, 150);
            button2.Size = new Size(90, 20);
            button2.Text = "Check Movie";
            button2.Click += button2_Click;
            this.Controls.Add(button2);

            PictureBox picture3 = new PictureBox();
            picture3.Location = new Point(290, 10);
            picture3.Size = new Size(100, 120);
            picture3.SizeMode = PictureBoxSizeMode.StretchImage;
            picture3.Image = Image.FromFile("C:\\UC Student\\Semester 2\\Application Development\\THA_W7_Ros_Diana\\THA_W7_Ros_Diana\\Poster\\Ecanto.JPG");
            this.Controls.Add(picture3);

            Label label3 = new Label();
            label3.Text = "Ecanto";
            label3.Location = new Point(320, 135);
            label3.AutoSize = true;
            this.Controls.Add(label3);

            Button button3 = new Button();
            button3.Location = new Point(300,150);
            button3.Size = new Size(90, 20);
            button3.Text = "Check Movie";
            button3.Click += button3_Click;
            this.Controls.Add(button3);

            PictureBox picture4 = new PictureBox();
            picture4.Location = new Point(420, 10);
            picture4.Size = new Size(100, 120);
            picture4.SizeMode = PictureBoxSizeMode.StretchImage;
            picture4.Image = Image.FromFile("C:\\UC Student\\Semester 2\\Application Development\\THA_W7_Ros_Diana\\THA_W7_Ros_Diana\\Poster\\NCT.JPG");
            this.Controls.Add(picture4);

            Label label4 = new Label();
            label4.Text = "NCT Dream";
            label4.Location = new Point(440, 135);
            label4.AutoSize = true;
            this.Controls.Add(label4);

            Button button4 = new Button();
            button4.Location = new Point(430, 150);
            button4.Size = new Size(90, 20);
            button4.Text = "Check Movie";
            button4.Click += button4_Click;
            this.Controls.Add(button4);

            PictureBox picture5 = new PictureBox();
            picture5.Location = new Point(28, 190);
            picture5.Size = new Size(100, 120);
            picture5.SizeMode = PictureBoxSizeMode.StretchImage;
            picture5.Image = Image.FromFile("C:\\UC Student\\Semester 2\\Application Development\\THA_W7_Ros_Diana\\THA_W7_Ros_Diana\\Poster\\Minion.JPG");
            this.Controls.Add(picture5);

            Label label5 = new Label();
            label5.Text = "Minion";
            label5.Location = new Point(57, 320);
            label5.AutoSize = true;
            this.Controls.Add(label5);

            Button button5 = new Button();
            button5.Location = new Point(35, 335);
            button5.Size = new Size(90, 20);
            button5.Text = "Check Movie";
            button5.Click += button5_Click;
            this.Controls.Add(button5);

            PictureBox picture6 = new PictureBox();
            picture6.Location = new Point(160, 190);
            picture6.Size = new Size(100, 120);
            picture6.SizeMode = PictureBoxSizeMode.StretchImage;
            picture6.Image = Image.FromFile("C:\\UC Student\\Semester 2\\Application Development\\THA_Week7_Ros_Diana\\THA_Week7_Ros_Diana\\Poster\\insideout.JPG");
            this.Controls.Add(picture6);

            Label label6 = new Label();
            label6.Text = "Inside Out";
            label6.Location = new Point(180, 320);
            label6.AutoSize = true;
            this.Controls.Add(label6);

            Button button6 = new Button();
            button6.Location = new Point(170, 335);
            button6.Size = new Size(80, 20);
            button6.Text = "Check Movie";
            button6.Click += button6_Click;
            this.Controls.Add(button6);

            PictureBox picture7 = new PictureBox();
            picture7.Location = new Point(290, 190);
            picture7.Size = new Size(100, 120);
            picture7.SizeMode = PictureBoxSizeMode.StretchImage;
            picture7.Image = Image.FromFile("C:\\UC Student\\Semester 2\\Application Development\\THA_Week7_Ros_Diana\\THA_Week7_Ros_Diana\\Poster\\Mario.JPG");
            this.Controls.Add(picture7);

            Label label7 = new Label();
            label7.Text = "Mario";
            label7.Location = new Point(325, 320);
            label7.AutoSize = true;
            this.Controls.Add(label7);

            Button button7 = new Button();
            button7.Location = new Point(300, 335);
            button7.Size = new Size(80, 20);
            button7.Text = "Check Movie";
            button7.Click += button7_Click;
            this.Controls.Add(button7);

            PictureBox picture8 = new PictureBox();
            picture8.Location = new Point(420, 190);
            picture8.Size = new Size(100, 120);
            picture8.SizeMode = PictureBoxSizeMode.StretchImage;
            picture8.Image = Image.FromFile("C:\\UC Student\\Semester 2\\Application Development\\THA_Week7_Ros_Diana\\THA_Week7_Ros_Diana\\Poster\\Shaun the Ship.JPG");
            this.Controls.Add(picture8);

            Label label8 = new Label();
            label8.Text = "Shaun the Sheep";
            label8.Location = new Point(425, 320);
            label8.AutoSize = true;
            this.Controls.Add(label8);

            Button button8 = new Button();
            button8.Location = new Point(430, 335);
            button8.Size = new Size(80, 20);
            button8.Text = "Check Movie";
            button8.Click += button8_Click;
            this.Controls.Add(button8);
        }
        private void button_Click(object sender, EventArgs e)
        {
            
            form1.showdragon();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            form1.showhome();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            form1.showecanto();
        }

        private void button4_Click(object sender, EventArgs e)
        {

           form1.showeNCTDream();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            form1.showminion();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            form1.showminsaid();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            form1.showmario();
        }

        private void button8_Click(object sender, EventArgs e)
        {

            form1.showship();
        }
    }
}
