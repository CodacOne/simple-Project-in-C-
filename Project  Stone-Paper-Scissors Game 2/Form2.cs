using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project__Stone_Paper_Scissors_Game_2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        public enum enPlayer
        {
            Player,
            Computer,

        }

        public enum GameChoice
        {
            Stone = 0,
            Paper = 1,
            Scissors = 2
        }


        //////////////////////////
        stGameStatus GameStatus;
        //////////////////////////

        struct stGameStatus
        {
            
            public short PlayerCount;
            public short ComputerCount;
            public short RoundCount;
        }

        //////////////////////////

        enum enWinner
        {
            Player,
            Computer,
            Draw,

        }

        private static readonly Random _random = new Random();
        //////////////////////////
        ///
        public static GameChoice GetComputerChoice()
        {
            return (GameChoice)_random.Next(0, 3);
        }


        /// </Dtermine Who Winner >
        /// <param name="btn"></param>
        /// //////////////////////////
        private string DetermineWinner(GameChoice ComputerChoice, GameChoice playerChoice)
        {
            if (ComputerChoice == playerChoice)
            {

                return "Draw";
            }


            switch (playerChoice)
            {


                case GameChoice.Stone:
                    {
                        return (ComputerChoice == GameChoice.Scissors) ? "Player" : "Computer";
                    }

                case GameChoice.Scissors:
                    {
                        return (ComputerChoice == GameChoice.Paper) ? "Player" : "Computer";

                    }

                case GameChoice.Paper:
                    {
                        return (ComputerChoice == GameChoice.Stone) ? "Player" : "Computer";

                    }


                default:

                    return "Wrong Choice";


            }

        }


        ////////////////////////
        private void DeterminrPicBox(GameChoice ComputerChoice, GameChoice playerChoice)
        {
            if (GameChoice.Paper == playerChoice)
            {

                btnPlayer.Image = Properties.Resources.Paper;

            }

            if (GameChoice.Paper == ComputerChoice)
            {
                btnComputer.Image = Properties.Resources.Paper;
            }




            if (GameChoice.Scissors == playerChoice)
            {

                btnPlayer.Image = Properties.Resources.scissors1;


            }

            if (GameChoice.Scissors == ComputerChoice)
            {
                btnComputer.Image = Properties.Resources.scissors1;
            }



            if (GameChoice.Stone == playerChoice)
            {

                btnPlayer.Image = Properties.Resources.Stone;

            }

            if (GameChoice.Stone == ComputerChoice)
            {
                btnComputer.Image = Properties.Resources.Stone;
            }

        }

        //////////////////////////
        private void EndGame()
        {
            btnComputer.Enabled = false;
            btnPlayer.Enabled = false;
            btnPlayer.Image = Properties.Resources.question_mark_96;
            btnComputer.Image = Properties.Resources.question_mark_96;

            btnStone.Enabled = false;
            btnSccssior.Enabled = false;
            btnPaper.Enabled = false;

            if (GameStatus.PlayerCount > GameStatus.ComputerCount)
            {
                lblResultGame.Text = "Player";
            }

          else  if (GameStatus.PlayerCount < GameStatus.ComputerCount)
            {
                lblResultGame.Text = "Computer";
            }
            else
            {
                lblResultGame.Text = "Draw";

            }
        }

        //////////////////////////

        private void printCountWinForEachPlayer(string ResultRound)
        {

            if (ResultRound == "Player")
            {

                GameStatus.PlayerCount++;
                lblPlayerResult.Text = GameStatus.PlayerCount.ToString();
            }

            if (ResultRound == "Computer")
            {
                GameStatus.ComputerCount++;
                lblComputerResult.Text = GameStatus.ComputerCount.ToString();
            }

        }

        //////////////////////////




        private void ReStartGame()
        {
            lblRound.Text = 0.ToString();
            lblComputerResult.Text = 0.ToString();
            lblPlayerResult.Text = 0.ToString();
            btnPlayer.Enabled = true;
            btnComputer.Enabled = true;
            textBox1.Clear();
            lblResultGame.Text = "In Progress";
            GameStatus.RoundCount = 0;
            GameStatus.ComputerCount = 0;
            GameStatus.PlayerCount = 0;

            btnStone.Enabled = true;
            btnSccssior.Enabled = true;
            btnPaper.Enabled = true;

        }


            //////////////////////////
            private void StartGame(Button btn)
        {
            string result = "";
            int number=0 ;
            bool IsValid = false;
           
           if (!int.TryParse(textBox1.Text, out number))
            {

                textBox1.Focus();
          MessageBox.Show("Enter a positive Number In TextBox", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
               
            }

           else
            {
                IsValid = true;

            }
     

            if ((GameStatus.RoundCount == number || GameStatus.RoundCount > number) && number != 0)
            {
                EndGame();
                return;
            }

            if(IsValid==true)
            {
                GameStatus.RoundCount++;

                lblRound.Text = GameStatus.RoundCount.ToString();

                GameChoice ComputerChoice = GetComputerChoice();

                string playerChoiceStr = Convert.ToString(btn.Tag);

                if (Enum.TryParse(playerChoiceStr, out GameChoice playerChoice))
                    {

                    result = DetermineWinner(ComputerChoice, playerChoice);

                    printCountWinForEachPlayer(result);

                    DeterminrPicBox(ComputerChoice, playerChoice);


                   }

            }
    
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            StartGame((Button)sender);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            StartGame((Button)sender);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            StartGame((Button)sender);
        }

        private void PicBoxPlayer_Click(object sender, EventArgs e)
        {

        }

        private void BtnPlayer_Click(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_Validating(object sender, CancelEventArgs e)
        {
            //if (!int.TryParse(textBox1.Text, out int number) || number <= 0)
            //{
            //    MessageBox.Show("Please Enter a Valid Number (Greater than 0)", "Error");
            //    textBox1.Focus();
            //    textBox1.SelectAll();
            //    e.Cancel = true; // يمنع إغلاق النافذة أو الانتقال لعنصر آخر
            //}
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            ReStartGame();
        }
    }
}
