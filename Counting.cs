using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearnMath
{
    public partial class Counting : Form
    {
        private List<PictureBox> gamepic = new List<PictureBox>();
        List<PictureBox> picend = new List<PictureBox>();
        private List<Point> points = new List<Point>();
        private int count = 0, Bad_Click=0,Good_Click=0,Sum_Click=0;
        private float Grade=0;
        int randd;
        Random rnd = new Random();

        public Counting()
        {
            InitializeComponent();
        }

        private void picload()
        {
            LeftPanel.Controls.Clear();
            RightPanel.Controls.Clear();
            for (int i = 1; i <= 4; i++)
            {
                PictureBox pic = new PictureBox();
                PictureBox pic1 = new PictureBox();
              //  pic.BackgroundImage = Image.FromFile(@"C:\Users\shlomo.DESKTOP-UAUDQDV\Desktop\picture\" + i + ".jpg");
                pic.Width = RightPanel.Width;
                pic.Height = RightPanel.Height;
                pic.Location = new Point(0, 0);
                pic.Visible = true;
             //   pic1.BackgroundImage = Image.FromFile(@"C:\Users\shlomo.DESKTOP-UAUDQDV\Desktop\picture\digitpic\" + i + ".jpg");
                pic1.Width = 100;
                pic1.Height = 100;
                gamepic.Add(pic1);
            }
        }

        private void Start_game_Click(object sender, EventArgs e)
        {
            {
                LeftPanel.Controls.Clear();
                count = 0;
                pointload();
                int randd = rnd.Next(1, 7);
                int rnnd = rnd.Next(0, 4);
                RightPanel.Controls.Clear();
                int x = 20, y = 10;
                for (int j = 1; j <= randd; j++)
                {
                    PictureBox pb1 = new PictureBox();
                    pb1.Location = new System.Drawing.Point(x, y);
                    pb1.Tag = j;
                    pb1.Visible = true;
                    pb1.BackgroundImage = gamepic[rnnd].BackgroundImage;
                    pb1.BackColor = Color.Black;
                    pb1.Size = new System.Drawing.Size(50, 50);
                    LeftPanel.Controls.Add(pb1);
                    x += (20 + pb1.Width);
                    count++;
                    if (count == 2)
                    {
                        x = 20;
                        y += 60;
                        count = 0;
                    }
                }
                buttonselect(randd);
            }
        }

        private void buttonselect(int randd)
        {
            int random=rnd.Next(0,3);
            num1.Text = randd + "";
            num1.Location = points[random];
            points.RemoveAt(random);
            num2.Location = points[0];
            num2.Text = rnd.Next(1, randd) + "";
            num3.Location = points[1];
            num3.Text = rnd.Next(randd+1, 10) + "";
            num1.Visible = true;
            num2.Visible = true;
            num3.Visible = true;
            points.RemoveRange(0, points.Count);

        }

        private void Counting_Load(object sender, EventArgs e)
        {
          picload();        
        }

        private void pointload()
        {
            Point po = new Point(270,434);
            int x=270;
            points.Add(po);

            for (int i =0; i <=1; i++)
            {
                x += 50;
                Point po2 = new Point(x,po.Y);
                points.Add(po2);
            }
        }

        private void next_targil(object sender, EventArgs e)
        {
            base.OnLoad(e);
            RightPanel.Visible = false;
            RightPanel.Controls.Clear();

        }

        private void num1_Click(object sender, EventArgs e)
        {
            Good_Click++;
            PictureBox showpic = new PictureBox();
            showpic.Location = new System.Drawing.Point(0, 0);
            showpic.Size = new System.Drawing.Size(400, 400);
  //          showpic.Image = Image.FromFile(@"C:\Users\shlomo.DESKTOP-UAUDQDV\Desktop\picture\test1.gif");
            RightPanel.Controls.Add(showpic);
         //   RightPanel.BackgroundImage = Image.FromFile(@"C:\Users\shlomo.DESKTOP-UAUDQDV\Desktop\picture\test1.gif");
            RightPanel.Visible = true;
            new_game_time.Enabled = true;
            
        }

        private void num2_Click(object sender, EventArgs e)
        {
            Bad_Click++;
           // RightPanel.BackgroundImage = Image.FromFile(@"C:\Users\shlomo.DESKTOP-UAUDQDV\Desktop\picture\wrong1.png");
            RightPanel.Visible = true;
            new_game_time.Enabled = true;
        }

        private void num3_Click(object sender, EventArgs e)
        {
            Bad_Click++;
            //RightPanel.BackgroundImage = Image.FromFile(@"C:\Users\shlomo.DESKTOP-UAUDQDV\Desktop\picture\wrong1.png");
            RightPanel.Visible = true;
        }

        private void new_game_time_Tick(object sender, EventArgs e)
        {
            refresh_game();       
            Start_game_Click(sender, e);
        }

        private void refresh_game()
        {
            new_game_time.Enabled = false;
            //base.OnLoad(e);
            RightPanel.Visible = false;
            RightPanel.Controls.Clear();
        }

        private void Return_Count_Button_Click(object sender, EventArgs e)
        {
            Sum_Click = Bad_Click + Good_Click;
            Grade=(float)Good_Click/Sum_Click;
            //שאילתא
            this.Hide();
            StudentForm form1 = new StudentForm(-1);
            form1.Show();
        }

    }
}
