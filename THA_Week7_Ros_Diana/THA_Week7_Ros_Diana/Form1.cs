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
   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

           
        }
         public Panel panel1 = new Panel();
        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Location = new Point(0, 44);
            panel1.Size = new Size(943, 611);
            this.Controls.Add(panel1);
        }

        public void showdragon()
        {
            Dragon form3 = new Dragon(this);
            form3.TopLevel = false;
            form3.AutoScroll = true;
            form3.AutoSize = true;
            panel1.Controls.Clear();
            panel1.Controls.Add(form3);
            form3.Show();
        }

        public void showhome()
        {
            Home home = new Home(this);
            home.TopLevel = false;
            home.AutoScroll = true;
            home.AutoSize = true;
            panel1.Controls.Clear();
            panel1.Controls.Add(home);
            home.Show();
        }

        public void backshow()
        {
            Cinema cin = new Cinema(this);
            cin.TopLevel = false;
            cin.AutoScroll = true;
            cin.AutoSize = true;
            panel1.Controls.Clear();
            panel1.Controls.Add(cin);
            cin.Show();
        }
        public void showecanto()
        {
            Ecanto ecanto = new Ecanto(this);
            ecanto.TopLevel = false;
            ecanto.AutoScroll = true;
            ecanto.AutoSize = true;
            panel1.Controls.Clear();
            panel1.Controls.Add(ecanto);
            ecanto.Show();
        }

        public void showeNCTDream()
        {
            dream dream = new dream(this);
            dream.TopLevel = false;
            dream.AutoScroll = true;
            dream.AutoSize = true;
            panel1.Controls.Clear();
            panel1.Controls.Add(dream);
            dream.Show();

        }

        public void showminion()
        {
            minion minion = new minion(this);
            minion.TopLevel = false;
            minion.AutoScroll = true;
            minion.AutoSize = true;
            panel1.Controls.Clear();
            panel1.Controls.Add(minion);
            minion.Show();

        }

        public void showminsaid()
        {
            insaid insaid = new insaid(this);
            insaid.TopLevel = false;
            insaid.AutoScroll = true;
            insaid.AutoSize = true;
            panel1.Controls.Clear();
            panel1.Controls.Add(insaid);
            insaid.Show();

        }

        public void showmario()
        {
            Mario mario = new Mario(this);
            mario.TopLevel = false;
            mario.AutoScroll = true;
            mario.AutoSize = true;
            panel1.Controls.Clear();
            panel1.Controls.Add(mario);
            mario.Show();

        }

        public void showship()
        {
            ship _ship = new ship(this);
            _ship.TopLevel = false;
            _ship.AutoScroll = true;
            _ship.AutoSize = true;
            panel1.Controls.Clear();
            panel1.Controls.Add(_ship);
            _ship.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Cinema cinema = new Cinema(this);
            cinema.TopLevel = false;
            cinema.AutoScroll = true;
            panel1.Controls.Add(cinema);
            cinema.AutoSize = true;
            cinema.Show();
        }

       
    }
}
