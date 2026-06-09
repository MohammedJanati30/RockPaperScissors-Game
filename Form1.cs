using RPS_Game.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPS_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public enum enGameChoice { Stone = 1, Paper = 2, Scissors = 3 };
        public enum enWinner { Player1 = 1, Computer = 2, Draw = 3 };
        public struct stGameResults
        {
            public short Player1WinTimes,
                         ComputerWinTimes,
                         DrawTimes,
                         Count;
        }
        public struct stRoundInfo
        {
            public short RoundNumber;
            public enGameChoice Player1Choice;
            public enGameChoice ComputerChoice;
            public enWinner Winner;
            public string WinnerName;
        };

        public stRoundInfo RoundInfo = new stRoundInfo();
        public stGameResults WinsTime = new stGameResults();
        static Random rnd = new Random();

        static int RandomNumber(int From, int To)
        {
            return rnd.Next(From, To + 1);
        }
        public void UpdateUIPlayerChoice(stRoundInfo RoundInfo)
        {
            if (RoundInfo.Player1Choice==enGameChoice.Scissors)
            {
                PlayerChoice.BackgroundImage= Resources.scissors;
            }
            if (RoundInfo.Player1Choice==enGameChoice.Paper)
            {
                PlayerChoice.BackgroundImage= Resources.paper;
            }
            if (RoundInfo.Player1Choice==enGameChoice.Stone)
            {
                PlayerChoice.BackgroundImage= Resources.Rock_Imoge;
            }
        }
        public void UpdateUIComputerChoice(stRoundInfo RoundInfo)
        {
            if (RoundInfo.ComputerChoice==enGameChoice.Scissors)
            {
                PcChoice.BackgroundImage= Resources.scissors;
            }
            if (RoundInfo.ComputerChoice==enGameChoice.Paper)
            {
                PcChoice.BackgroundImage= Resources.paper;
            }
            if (RoundInfo.ComputerChoice==enGameChoice.Stone)
            {
                PcChoice.BackgroundImage= Resources.Rock_Imoge;
            }
        }
        void DisplayResultsAtLable(stGameResults WinsTime)
        {
            textBoxPlayerWins.Text=WinsTime.Player1WinTimes.ToString();
            textBoxDrawTime.Text=WinsTime.DrawTimes.ToString();
           textBoxPcWins.Text =WinsTime.ComputerWinTimes.ToString();
        }
        enGameChoice GetComputerChoice()
        {
            return (enGameChoice)RandomNumber(1, 3);
        }
        enWinner WhoWonTheRound(stRoundInfo RoundInfo)
        {
            if (RoundInfo.Player1Choice == RoundInfo.ComputerChoice)
                return enWinner.Draw;

            switch (RoundInfo.Player1Choice)
            {
                case enGameChoice.Stone:
                    return (RoundInfo.ComputerChoice == enGameChoice.Paper)
                        ? enWinner.Computer
                        : enWinner.Player1;

                case enGameChoice.Paper:
                    return (RoundInfo.ComputerChoice == enGameChoice.Scissors)
                        ? enWinner.Computer
                        : enWinner.Player1;

                case enGameChoice.Scissors:
                    return (RoundInfo.ComputerChoice == enGameChoice.Stone)
                        ? enWinner.Computer
                        : enWinner.Player1;
            }

            return enWinner.Draw;
        }
        enWinner WhoWonTheGame(stGameResults CountWin)
        {
            if (CountWin.Player1WinTimes > CountWin.ComputerWinTimes)
                return enWinner.Player1;
            else if (CountWin.ComputerWinTimes > CountWin.Player1WinTimes)
                return enWinner.Computer;
            else
                return enWinner.Draw;
        }
        public void WinnerNamee(enWinner Winner)
        {
            tbhowWonGame.Visible = true;
            switch (Winner)
            {
                case enWinner.Player1:
                    tbhowWonGame.BackColor= Color.Green;
                    tbhowWonGame.Text= "Player Wins ".ToString();
                    break;

                case enWinner.Computer:
                    tbhowWonGame.BackColor= Color.Red;

                    tbhowWonGame.Text= "Computer Wins  ".ToString();
                    break;

                default:
                    tbhowWonGame.BackColor= Color.Yellow;

                    tbhowWonGame.Text= "Draw:(No Winner in the Game)".ToString();
                    break;

            }
        }

        bool IsRoundNotNull()
        {
            return HowManyRound.Value >0;
        }

        public void LogicOfGame()
        {
            RoundInfo.ComputerChoice = GetComputerChoice();

            RoundInfo.Winner = WhoWonTheRound(RoundInfo);

            UpdateUIPlayerChoice(RoundInfo);
            UpdateUIComputerChoice(RoundInfo);

            if (RoundInfo.Winner == enWinner.Player1)
                WinsTime.Player1WinTimes++;

            else if (RoundInfo.Winner == enWinner.Computer)
                WinsTime.ComputerWinTimes++;

            else
                WinsTime.DrawTimes++;

            WinsTime.Count++;

            DisplayResultsAtLable(WinsTime);
        }
        void PLayAgin()
        {
            enWinner FinalWinner = WhoWonTheGame(WinsTime);
            WinnerNamee(FinalWinner);
            DialogResult result = MessageBox.Show(
                "Do you want to play again?",
                "Play Again",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                panelMenue.Visible= true;
                ReastGAme();
            }
            else
            {
                Application.Exit();
            }
        }

        public void StartGame()
        {
           

            LogicOfGame();

            if (WinsTime.Count >= HowManyRound.Value)
            {
                PLayAgin();
            }
        }

        void ReastGAme()
        {
            ShowGame.Visible= false;
            // Reset Results
            WinsTime = new stGameResults();

            // Reset Round Info
            RoundInfo = new stRoundInfo();

            // Reset Labels
            textBoxPlayerWins.Text = "0";
            textBoxPcWins.Text = "0";
            textBoxDrawTime.Text = "0";

            // Reset Winner TextBox
            tbhowWonGame.Text = "";
            tbhowWonGame.Visible = false;

            // Reset Images
            PlayerChoice.BackgroundImage = null;
            PcChoice.BackgroundImage = null;

            // Reset Number Of Rounds
            HowManyRound.Value = 0;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ReastGAme();
        }

        private void Paper_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void Scissor_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void Rock_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RoundInfo.Player1Choice = enGameChoice.Paper;
            StartGame();
        }

        private void btScissor_Click(object sender, EventArgs e)
        {
            RoundInfo.Player1Choice = enGameChoice.Scissors;
            StartGame();
        }

        private void btRock_Click(object sender, EventArgs e)
        {
            RoundInfo.Player1Choice = enGameChoice.Stone;
            StartGame();
        }

        private void btstartgame_Click(object sender, EventArgs e)
        {
            if (!IsRoundNotNull())
            {
                MessageBox.Show("Please Enter Number Of Rounds");
                return;
            }
            ShowGame.Visible= true;
            panelMenue.Visible= false;
        }
    }
}
