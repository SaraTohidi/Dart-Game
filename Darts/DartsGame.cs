using Darts.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Darts
{
    public partial class DartsGame : Form
    {
        Dictionary<int, Point> mytarget = new Dictionary<int, Point>()
        {
            { 60, new Point(196,108) },
            { 20, new Point(196,84) },
            { 19, new Point(166,285) },
            { 18, new Point(258,162) },
            { 17, new Point(228,283) },
            { 16, new Point(111,247) },
            { 15, new Point(284,248) },
            { 14, new Point(97,152) },
            { 13, new Point(297,153) },
            { 12, new Point(134,101) },
            { 11, new Point(91,184) },
            { 10, new Point(295,218) },
            { 9, new Point(112,125) },
            { 8, new Point(94,217) },
            { 7, new Point(133,267) },
            { 6, new Point(303,186) },
            { 5, new Point(164,86) },
            { 4, new Point(282,126) },
            { 3, new Point(195,286) },
            { 2, new Point(258,272) },
            { 1, new Point(228,91) }
        };

        PointsCalculator points = new PointsCalculator();
        public String namePlayer1, namePlayer2;
        BadComputerPlayer badPlayer = new BadComputerPlayer();
        MediumComputerPlayer mediumPlayer = new MediumComputerPlayer();
        GoodComputerPlayer goodPlayer = new GoodComputerPlayer();


        private int direction = 1;

        int first_score = 301;
        int second_score = 301;
        int counter = 1;

        public void InitializePlayers(String player1, String player2)
        {
            ResetScore();
            ClearTheBoard();
            counter = 1;

            namePlayer1 = player1;
            namePlayer2 = player2;
        }
        

        public bool CheckForPlayers()
        {
            if (namePlayer1 != null && namePlayer2 != null)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Please select new game!");
                return false;
            }
        }
        public DartsGame()
        {
            this.KeyPreview = true;
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            InitializeComponent();
            AutoScaleMode = AutoScaleMode.None;
            StartPowerMeter();
            
            //target
            board.Controls.Add(target);
            target.BackColor = Color.Transparent;
            target.BringToFront();

            //first P1
            board.Controls.Add(Player1T1);
            Player1T1.BackColor = Color.Transparent;
            Player1T1.BringToFront();

            //second P1
            board.Controls.Add(Player1T2);
            Player1T2.BackColor = Color.Transparent;
            Player1T2.BringToFront();

            //third P1
            board.Controls.Add(Player1T3);
            Player1T3.BackColor = Color.Transparent;
            Player1T3.BringToFront();

            //first P2
            board.Controls.Add(Player2T1);
            Player2T1.BackColor = Color.Transparent;
            Player2T1.BringToFront();

            //second P2
            board.Controls.Add(Player2T2);
            Player2T2.BackColor = Color.Transparent;
            Player2T2.BringToFront();

            //third P2
            board.Controls.Add(Player2T3);
            Player2T3.BackColor = Color.Transparent;
            Player2T3.BringToFront();

            Score1ShowP1.Text = "301";
            Score1ShowP2.Text = "301";
            Player1T1.Parent = board;

            if (File.Exists("../../save.xml"))
            {
                XMLPersistence reader = new XMLPersistence();
                var state = reader.GetState();

                InitializePlayers(state.player1, state.player2);

                this.Player1T1.Location = state.dart1P1Position;
                this.Player1T2.Location = state.dart2P1Position;
                this.Player1T3.Location = state.dart3P1Position;

                this.Player2T1.Location = state.dart1P2Position;
                this.Player2T2.Location = state.dart2P2Position;
                this.Player2T3.Location = state.dart3P2Position;

                first_score = state.scoreP1;
                second_score = state.scoreP2;

                Score1ShowP1.Text = first_score.ToString();
                Score1ShowP2.Text = second_score.ToString();

                if (this.Player1T2.Location.X > 1100)
                {
                    counter = 2;
                }
                else if (this.Player1T3.Location.X > 1100)
                {
                    counter = 3;
                }
                else if (this.Player2T1.Location.X > 1100)
                {
                    counter = 4;
                }
                else if (this.Player2T2.Location.X > 1100)
                {
                    counter = 5;
                }
                else if (this.Player2T3.Location.X > 1100)
                {
                    counter = 6;
                }
            }
        }

        private void StartPowerMeter()
        {
            powerMeter.Minimum = 0;
            powerMeter.Maximum = 100;

            powerTimer.Enabled = true;
        }

        private int EndPowerMeter()
        {
            powerTimer.Enabled = false;

            return powerMeter.Value;
        }

        private void ClearTheBoard()
        {
            Player1T1.Location = new Point(1120, 518);
            Player1T2.Location = new Point(1120, 574);
            Player1T3.Location = new Point(1120, 627);

            Player2T1.Location = new Point(1185, 518);
            Player2T2.Location = new Point(1185, 574);
            Player2T3.Location = new Point(1185, 627);
        }

        private void ResetScore()
        {
            first_score = 301;
            second_score = 301;
            Score1ShowP1.Text = first_score.ToString();
            Score1ShowP2.Text = second_score.ToString();
        }

        private void DartsGame_KeyDown(object sender, KeyEventArgs e)
        {

            if ((e.KeyCode == Keys.Left || e.KeyCode == Keys.A) && this.target.Location.X > 33)
            {
                this.target.Location = new Point(this.target.Location.X - 1,this.target.Location.Y);
            }
            
            if ((e.KeyCode == Keys.Right || e.KeyCode == Keys.D) && this.target.Location.X < 333)
            {
                this.target.Location = new Point(this.target.Location.X + 1,this.target.Location.Y);
            }

            if ((e.KeyCode == Keys.Up || e.KeyCode == Keys.W) && this.target.Location.Y > 33)
            {
                this.target.Location = new Point(this.target.Location.X, this.target.Location.Y - 1);
            }

            if ((e.KeyCode == Keys.Down || e.KeyCode == Keys.S) && this.target.Location.Y < 333)
            {
                this.target.Location = new Point(this.target.Location.X, this.target.Location.Y + 1);
            }
        }
        private void powerTimer_Tick(object sender, EventArgs e)
        {
            if (direction == 1)
            {
                powerMeter.Value++;
            }
            else
            {
                powerMeter.Value--;
            }

            if (powerMeter.Value == powerMeter.Maximum)
            {
                direction = 0;
            }
            else if (powerMeter.Value == powerMeter.Minimum)
            {
                direction = 1;
            }
        }

        private void NewGameButton_Click(object sender, EventArgs e)
        {
            NewGame seconWin = new NewGame(this);
            seconWin.Show();
        }


        private Point SetThrowResult(IComputer computer, int target, PictureBox dart)
        {
            var throwResult = computer.CalculateNewPoint(new Point(mytarget[target].X, mytarget[target].Y));
            dart.Location = new Point(throwResult.X - 11, throwResult.Y - 30);
            return throwResult;
        }

        private int GetSection(PictureBox dart, string playerName, int score)
        {
            Point throwResult = new Point();

            var targetSection = score >= 60 ? 60 : score >= 20 ? 20 : score;

            if (playerName == "Easy Computer")
            {
                throwResult = this.SetThrowResult(badPlayer, targetSection, dart);
            }
            else if (playerName == "Medium Computer")
            {
                throwResult = this.SetThrowResult(mediumPlayer, targetSection, dart);
            }
            else if (playerName == "Hard Computer")
            {
                throwResult = this.SetThrowResult(goodPlayer, targetSection, dart);
            }
            return this.points.CalculateThrow(throwResult.X, throwResult.Y);
        }

        //Constant numbers are the images offset
        //11 and 10 are offsets for dart Image
        // 24 and 22 are offsets for target image
        private void Power_Click(object sender, EventArgs e)
        {

            int section = 0;

            int power = 0;
           
            power = this.EndPowerMeter() - 50;

            if (CheckForPlayers())
            {
                if (counter == 1)
                {
                    if (namePlayer1 == "Human")
                    {
                        this.Player1T1.Location = new Point(this.target.Location.X + 11, this.target.Location.Y - power - 10);
                        section = this.points.CalculateThrow(this.target.Location.X + 24, this.target.Location.Y - power + 22);

                    }
                    else
                    {
                        section = GetSection(this.Player1T1, namePlayer1, first_score);
                    }
                }
                if (counter == 2)
                {
                    if (namePlayer1 == "Human")
                    {
                        this.Player1T2.Location = new Point(this.target.Location.X + 11, this.target.Location.Y - power - 10);
                        section = this.points.CalculateThrow(this.target.Location.X + 24, this.target.Location.Y - power + 22);

                    }
                    else
                    {
                        section = GetSection(this.Player1T2, namePlayer1, first_score);
                    }
                }
                if (counter == 3)
                {
                    if (namePlayer1 == "Human")
                    {
                        this.Player1T3.Location = new Point(this.target.Location.X + 11, this.target.Location.Y - power - 10);
                        section = this.points.CalculateThrow(this.target.Location.X + 24, this.target.Location.Y - power + 22);

                    }
                    else
                    {
                        section = GetSection(this.Player1T3, namePlayer1, first_score);
                    }
                }
                if (counter == 4)
                {
                    if (namePlayer2 == "Human")
                    {
                        this.Player2T1.Location = new Point(this.target.Location.X + 11, this.target.Location.Y - power - 10);
                        section = this.points.CalculateThrow(this.target.Location.X + 24, this.target.Location.Y - power + 22);

                    }
                    else
                    {
                        section = GetSection(this.Player2T1, namePlayer2, second_score);
                    }
                }
                if (counter == 5)
                {
                    if (namePlayer2 == "Human")
                    {
                        this.Player2T2.Location = new Point(this.target.Location.X + 11, this.target.Location.Y - power - 10);
                        section = this.points.CalculateThrow(this.target.Location.X + 24, this.target.Location.Y - power + 22);

                    }
                    else
                    {
                        section = GetSection(this.Player2T2, namePlayer2, second_score);
                    }
                }
                if (counter == 6)
                {
                    if (namePlayer2 == "Human")
                    {
                        this.Player2T3.Location = new Point(this.target.Location.X + 11, this.target.Location.Y - power - 10);
                        section = this.points.CalculateThrow(this.target.Location.X + 24, this.target.Location.Y - power + 22);

                    }
                    else
                    {
                        section = GetSection(this.Player2T3, namePlayer2, second_score);
                    }
                }

                if (0 < counter && counter < 4)
                {

                    first_score = first_score - section;
                    if (first_score == 0)
                    {
                        Score1ShowP1.Text = first_score.ToString();
                        MessageBox.Show("First player WON!");
                        ClearTheBoard();
                        ResetScore();
                        counter = 0;
                    }
                    else if (first_score < 0)
                    {
                        MessageBox.Show("Try again!");
                        counter = 3;
                        first_score = first_score + section;
                        Score1ShowP1.Text = first_score.ToString();
                        StartPowerMeter();
                        ClearTheBoard();
                    }
                    else
                    {
                        Score1ShowP1.Text = first_score.ToString();
                        StartPowerMeter();
                    }
                }
                else
                {

                    second_score = second_score - section;
                    if (second_score == 0)
                    {
                        Score1ShowP2.Text = second_score.ToString();
                        MessageBox.Show("Second player WON!");
                        ClearTheBoard();
                        ResetScore();
                        counter = 0;
                    }
                    else if (second_score < 0)
                    {
                        MessageBox.Show("Try again!");
                        counter = 0;
                        second_score = second_score + section;
                        Score1ShowP2.Text = second_score.ToString();
                        StartPowerMeter();
                        ClearTheBoard();
                    }
                    else
                    {
                        Score1ShowP2.Text = second_score.ToString();
                        StartPowerMeter();
                    }
                }

                XMLPersistence savefile = new XMLPersistence();
                savefile.SaveData(this.Player1T1.Location, Player1T2.Location, this.Player1T3.Location,
                    this.Player2T1.Location, this.Player2T2.Location, this.Player2T3.Location,
                    first_score, second_score, namePlayer1, namePlayer2);

                counter++;
                if (counter > 6)
                {
                    MessageBox.Show("Next turn!");
                    counter = 1;
                    ClearTheBoard();
                }

            }
        }
    }
}
