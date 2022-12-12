using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace TEST_GAME_1
{
    public class ChessBoard
    {
        #region Properties
        private Panel Chess;
        private List<Player> player;
        public List<Player> Player { get => player; set => player = value; }
        public int CurenPl { get => curenPl; set => curenPl = value; }
        public TextBox NamePlayer1 { get => NamePlayer; set => NamePlayer = value; }
        public PictureBox PicPlayer1 { get => PicPlayer; set => PicPlayer = value; }
        public List<List<Button>> Listone { get => listone; set => listone = value; }
        
        public int A { get => a; set => a = value; }

        private int a;
        private int curenPl;
        
        private TextBox NamePlayer;
        private PictureBox PicPlayer;
        private List<List<Button>> listone;
        #endregion
        #region Initialize
        public ChessBoard(Panel Chess, TextBox NamePlayer, PictureBox PicPlayer)
        {
            this.Chess = Chess;
            this.NamePlayer = NamePlayer;
            this.PicPlayer = PicPlayer;
            this.Player = new List<Player>()
            {
                new Player("Nguoi choi thu nhat", Image.FromFile(Application.StartupPath + "\\Resources\\xx.jpg")),
                new Player("Nguoi choi thu hai", Image.FromFile(Application.StartupPath + "\\Resources\\X.jpg"))
            };
            CurenPl = 0;
            
            A = 1;
        }

        #endregion
        #region methods
        public void DrawChessBoard()
        {
            A = 1;
            Chess.Enabled = true;
            Chess.Controls.Clear();
            Listone = new List<List<Button>>();
            Button one = new Button { Width = 0, Height = 0, Location = new Point(0, 0) };
            for (int i = 0; i < text.chess_hight; i++)
            {
                listone.Add(new List<Button>());
                for (int j = 0; j < text.chess_width; j++)
                {
                    Button a = new Button()
                    {
                        Width = text.width,
                        Height = text.hight,
                        Location = new Point(one.Location.X + one.Width, one.Location.Y),
                        BackgroundImageLayout = ImageLayout.Stretch,
                        Tag=i.ToString()
                    };
                    a.Click += A_Click;
                    Chess.Controls.Add(a);
                    listone[i].Add(a);
                    one = a;
                    
                }
                one.Location = new Point(0, one.Location.Y + text.hight);
                one.Width = 0;
                one.Height = 0;
            }
        }

        public void DrawChessBoard2()
        {
            A = 2;
            Chess.Enabled = true;
            Chess.Controls.Clear();
            Listone = new List<List<Button>>();
            Button one = new Button { Width = 0, Height = 0, Location = new Point(0, 0) };
            for (int i = 0; i < text.chess_hight; i++)
            {
                listone.Add(new List<Button>());
                for (int j = 0; j < text.chess_width; j++)
                {
                    Button b = new Button()
                    {
                        Width = text.width,
                        Height = text.hight,
                        Location = new Point(one.Location.X + one.Width, one.Location.Y),
                        BackgroundImageLayout = ImageLayout.Stretch,
                        Tag = i.ToString()
                    };
                    b.Click += B_Click;
                    Chess.Controls.Add(b);
                    listone[i].Add(b);
                    one = b;

                }
                one.Location = new Point(0, one.Location.Y + text.hight);
                one.Width = 0;
                one.Height = 0;
            }
        }
        private void B_Click(object sender, EventArgs e)
        {
            Button a = sender as Button;
            if (a.BackgroundImage != null)
                return;
            a.BackgroundImage = player[CurenPl].Pic;
            NamePlayer.Text = "Nguoi Choi";
            PicPlayer.Image = Player[CurenPl].Pic;
            if (isEnd(a))
            {

                EndGame();
                Thread.Sleep(500);
                DrawChessBoard2();
                return;
            }
            
            
            RanDomClick();
        }

        private void A_Click(object sender, EventArgs e)
        {
            Button a = sender as Button;
            if (a.BackgroundImage != null)
                return;
            a.BackgroundImage = player[CurenPl].Pic;
            CurenPl = CurenPl == 1 ? 0 : 1;
            NamePlayer.Text = Player[CurenPl].Name;
            PicPlayer.Image = Player[CurenPl].Pic;
            
            if (isEnd(a))
            {
                EndGame();
                Thread.Sleep(1000);
                DrawChessBoard();

            }
        }
        
        private Point getPoint(Button a)
        {
            
            int y = Convert.ToInt32(a.Tag);
            int x = listone[y].IndexOf(a);
            Point point = new Point(x,y);
            return point;
        }
        private void EndGame()
        {
                MessageBox.Show("Game da ket thuc");
            
        }
        private bool isEnd(Button a)
        {
            return End_doc(a) || End_ngang(a) || End_cheo1(a) || End_cheo2(a);
        }
        
        private bool End_doc(Button a)
        {
            Point point = getPoint(a);
            int count_top = 0;
            int count_bottom = 0;
            for(int i = point.Y; i >= 0; i--)
            {
                if (listone[i][point.X].BackgroundImage == a.BackgroundImage)
                {
                    count_top++;
                }
                else
                {
                    break;
                }
            }
            for(int i = point.Y + 1; i < text.chess_hight; i++)
            {
                if( listone[i][point.X].BackgroundImage == a.BackgroundImage)
                {
                    count_bottom++;
                }
                else
                {
                    break;
                }
            }
            return count_bottom + count_top >= 5;
        }
        private bool End_ngang(Button a)
        {
            Point point = getPoint(a);
            int count_left = 0;
            int count_right = 0;
            for (int i = point.X; i >= 0; i--)
            {
                if (listone[point.Y][i].BackgroundImage == a.BackgroundImage)
                {
                    count_left++;
                }
                else
                {
                    break;
                }
            }
            for (int i = point.X + 1; i < text.chess_width; i++)
            {
                if (listone[point.Y][i].BackgroundImage == a.BackgroundImage)
                {
                    count_right++;
                }
                else
                {
                    break;
                }
            }
            return count_left + count_right >= 5;
        }
    
        private bool End_cheo1(Button a)
        {
            Point point = getPoint(a);
            int count_left = 0;
            int count_right = 0;
            for (int i = 0; i <= point.X ; i++)
            {
                if (point.X - i < 0 || point.Y - i < 0)
                {
                    break;
                }
                if (listone[point.Y - i][point.X - i].BackgroundImage == a.BackgroundImage)
                {
                    count_left++;
                }
                else
                {
                    break;
                }
            }
            for (int i = 1; i < text.chess_width-point.X+1; i++)
                
            {
                if (point.X + i >= text.chess_width || point.Y + i >= text.chess_hight)
                {
                    break;
                }
                if (listone[point.Y+i][point.X+i].BackgroundImage == a.BackgroundImage)
                {
                    count_right++;
                }
                else
                {
                    break;
                }
            }
            return count_left + count_right >= 5;
        }
        private bool End_cheo2(Button a)
        {
            Point point = getPoint(a);
            int count_left = 0;
            int count_right = 0;
            for (int i = 0; i <= point.Y; i++)
            {
                if (point.X + i >= text.chess_width || point.Y - i <0)
                {
                    break;
                }
                if (listone[point.Y -i][point.X +i].BackgroundImage == a.BackgroundImage)
                {
                    count_left++;
                }
                else
                {
                    break;
                }
            }
            for (int i = 1; i < text.chess_width - point.X-1; i++)

            {
                if (point.X - i < 0 || point.Y + i >= text.chess_hight)
                {
                    break;
                }
                if (listone[point.Y +i][point.X -i].BackgroundImage == a.BackgroundImage)
                {
                    count_right++;
                }
                else
                {
                    break;
                }
            }
            return count_left + count_right >= 5;
        }
        public void NewGame2()
        {
            DrawChessBoard2();
        }
        public void NewGame()
        {
            DrawChessBoard();
        }
        public void RanDomClick()
        {
            var rand = new Random();
            int x = rand.Next(0, text.chess_hight);
            int y = rand.Next(0, text.chess_width);
            if(listone[x][y].BackgroundImage != null)
            {
                RanDomClick();
                
            }
            else
            {
                Button a = listone[x][y];
                listone[x][y].BackgroundImage = Image.FromFile(Application.StartupPath + "\\Resources\\X.jpg");
                if (isEnd(a))
                {

                    EndGame();
                    Thread.Sleep(1000);
                    DrawChessBoard2();
                }
            }
        }
      
    }
    #endregion

}
