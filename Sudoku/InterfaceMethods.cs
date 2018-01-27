using System;
using System.Drawing;
using System.Windows.Forms;

//
// This part of class contains all of the custom methods
// that are not focused on creating new forms/dialogboxes.
//

namespace Sudoku
{
    partial class MainWindow
    {
        // variable used to show total count of boards while setting the board manually
        static int countBoards;
        public static int CountBoards
        {
            get { return countBoards; }
        }

        // selected board's index
        int selectedBoard;

        // variable used to count the total playtime
        int fullTime = 0;

        // closes the game when clicked
        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        // fills a button of board with a number when clicked/increments the number on a button
        private void fill_sudoku_button(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.Text == null || btn.Text == "" || btn.Text == "9")
                btn.Text = "1";
            else
                btn.Text = Convert.ToString(Convert.ToInt16(btn.Text) + 1);
        }

        // set random board
        private void randomBoardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // start/restart the timer
            timer1.Stop();
            fullTime = 0;
            timer1.Start();
            timer1.Enabled = true;
            stopWatchLabel.Text = "Time: 00:00:00";

            // get random board from the boards list
            Random ran = new Random();
            int listNumber = ran.Next(1, boardList.Count + 1);
            selectedBoard = listNumber;

            // set board number visible for user
            boardNumberScreen.Text = "Board number: " + listNumber;

            // set the board on the buttons
            printSelectedBoard(listNumber - 1);

            // enable button82 so user can check the board
            this.button82.Enabled = true;
        }

        // input board number
        private void selectABoardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int listNumber = 0;
            // change the board if clicked OK
            if (InputNumberBox("Select a number", "Please enter the board number:", ref listNumber) == DialogResult.OK)
            {
                // start/restart the timer
                timer1.Stop();
                fullTime = 0;
                timer1.Start();
                timer1.Enabled = true;
                stopWatchLabel.Text = "Time: 00:00:00";
                selectedBoard = listNumber;

                // set board number visible for user
                boardNumberScreen.Text = "Board number: " + listNumber;

                // set the board on the buttons
                printSelectedBoard(listNumber - 1);

                // enable button82 so user can check the board
                this.button82.Enabled = true;
            }
        }

        // set the board on the buttons
        private void printSelectedBoard(int boardIndex)
        {
            int buttonIndex = 1;
            int fieldIndex;
            foreach (Button but in buttonList)
            {
                fieldIndex = 1;

                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        if (buttonIndex == fieldIndex)
                        {
                            if (boardList[boardIndex][i, j].ToString() == "0")
                            {
                                but.Enabled = true;
                                but.Text = null;
                                but.BackColor = Color.White;
                            }
                            else
                            {
                                but.Enabled = false;
                                but.Text = boardList[boardIndex][i, j].ToString();
                                but.BackColor = Color.LightGray;
                            }
                        }
                        fieldIndex++;
                    }
                }
                buttonIndex++;
            }
        }

        // timer method
        private void timer1_Tick(object sender, EventArgs e)
        {
            fullTime++;

            int hours, minutes, seconds;
            hours = fullTime / 3600;
            minutes = (fullTime / 60) % 60;
            seconds = fullTime % 60;

            this.stopWatchLabel.Text = string.Format("Time: {0:00}:{1:00}:{2:00}", hours, minutes, seconds);
        }
    }
}