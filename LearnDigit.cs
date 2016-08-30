using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
using System.Drawing.Imaging;

namespace LearnMath
{
    public partial class LearnDigit : Form
    {
        public static int UserId = 0;             
        public static string connectionstr = "";     
        string connetionString = null;
        private List<PictureBox> gamepic = new List<PictureBox>();
         List<PictureBox> picend=new List<PictureBox>();
        string sql = null;
        private int click_count = 0;
        SqlCommand command;
        SqlConnection connection;
        SqlDataReader dataReader;
        private int randd;

        public LearnDigit(int UserID)
        {
            InitializeComponent();
            UserId = UserID;
            connectionstr = "Data Source=TSAHIT-PC;Initial Catalog=LearnMath;Trusted_connection=True;User ID=Tsahi;Password=tt34429324";
            connetionString = connectionstr;
            connection = new SqlConnection(connetionString);       
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
        //start Game
        private void Start_game_Click(object sender, EventArgs e)
        {
            int PlayGameCode=0;
            int GameCode=0;
            int Level = 0;           
            string MarkSize = null;
            string background = null;
            connection.Open();
            sql = "SELECT  top 1 PlayGameCode,GameCode,Level,UserId,MarkSize,background FROM LearnMath.dbo.StudentPlay where UserId= '" + UserId + "' and GameCode='1' ORDER BY PlayGameCode DESC";

            command = new SqlCommand(sql, connection);
            SqlDataAdapter da = new SqlDataAdapter(command);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                PlayGameCode = int.Parse(dataReader.GetValue(0).ToString());
                GameCode = int.Parse(dataReader.GetValue(1).ToString());
                Level = int.Parse(dataReader.GetValue(2).ToString());
                MarkSize = dataReader.GetValue(4).ToString();
                background = dataReader.GetValue(5).ToString();               
            }
            connection.Close();
            MessageBox.Show("נתונים הוטענו התחל לשחק");
            start_play();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentForm form1 = new StudentForm(-1);
            form1.Show();
        }

        private void LearnDigit_Load(object sender, EventArgs e)
        {
            picload();          
        }

        private void picload()
        {
            LeftPanel.Controls.Clear();
            RightPanel.Controls.Clear();
            for (int i = 1; i <=9; i++)
            {
                PictureBox pic = new PictureBox();
                PictureBox pic1 = new PictureBox();
                pic.BackgroundImage = Image.FromFile(@"C:\project_pictures\numbers\" + i + ".jpg");
                pic.Width =RightPanel.Width;
                pic.Height = RightPanel.Height;
                pic.Location = new Point(0,0);
                pic.Visible = true;
                picend.Add(pic);
                pic1.BackgroundImage = Image.FromFile(@"C:\project_pictures\airplan.jpg");
                pic1.Width = 80;
                pic1.Height = 80;
                pic1.SizeMode=PictureBoxSizeMode.Zoom;
                gamepic.Add(pic1);
            }
        }

      //  private void button3_Click(object sender, EventArgs e)
        private void start_play()
        {
            Random rnd=new Random();
            randd= rnd.Next(0, 4);
            RightPanel.Controls.Clear();
            LeftPanel.Controls.Clear();
            int x=0,y=0;
            for (int j = 1; j <=5; j++)
            {
                PictureBox pb1 = new PictureBox();
                pb1.Location = new System.Drawing.Point(x,y);
                pb1.Visible = true;
                pb1.BackgroundImage = gamepic[randd].BackgroundImage;
                pb1.Size = new System.Drawing.Size(80,80);
                pb1.SizeMode = PictureBoxSizeMode.Zoom;
                y += (10 + pb1.Height);
                pb1.Click += pb_Click;
                if (pb1.Bottom >= RightPanel.Height)
                {
                    y = 0;
                    x += (20 + pb1.Width);
                    pb1.Location = new System.Drawing.Point(x, y);
                    RightPanel.Controls.Add(pb1);
                    y += (10 + pb1.Height);
                }
                else RightPanel.Controls.Add(pb1);               
            }                                 
        }

        void pb_Click(object sender, EventArgs e)
        {
            PictureBox _clicked = sender as PictureBox;
            _clicked.Visible = false;
            LeftPanel.Controls.Add(_clicked);
            _clicked.Visible = true;
            click_count++;
            
            if (click_count == 5)
            {
              //  NumPic.Visible = true;
                RightPanel.Controls.Add(picend[1]);
                click_count = 0;
                NextStage.Enabled = true;
            } 
        }

        private void NextStage_Tick(object sender, EventArgs e)
        {
            refresh_game();
            start_play();
        }

        private void refresh_game()
        {
            NextStage.Enabled = false;

        }

    
   
    }
}
