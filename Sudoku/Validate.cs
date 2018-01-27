using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

//
// The following file contains all of the methods used to
// validate the completed board.
//

namespace Sudoku
{
    partial class MainWindow
    {

        // check the board
        private void checkTheBoard(object sender, EventArgs e)
        {
            bool isValidate = true;

            foreach (Button but in buttonList)
                if (but.Text == null || but.Text == "")
                {
                    MessageBox.Show("The board is not completed yet!", "Board not completed", MessageBoxButtons.OK);
                    isValidate = false;
                    break;
                }

            if (isValidate)
            {
                // rewrite text from the buttons into a table
                int buttonIndex = 1;
                int fieldIndex;
                int[,] results = new int[9, 9];
                foreach (Button but in buttonList)
                {
                    fieldIndex = 1;

                    for (int i = 0; i < 9; i++)
                    {
                        for (int j = 0; j < 9; j++)
                        {
                            if (buttonIndex == fieldIndex)
                            {
                                results[i, j] = Convert.ToInt16(but.Text);
                            }
                            fieldIndex++;
                        }
                    }
                    buttonIndex++;
                }

                // check completed board
                for (int i = 0; i < 9; i++)
                {
                    if (isValidate)
                    {
                        if (!checkRow(results, i))
                        {
                            isValidate = false;
                            break;
                        }
                        else if (!checkColumn(results, i))
                        {
                            isValidate = false;
                            break;
                        }
                        else if (!checkField(results, i))
                        {
                            isValidate = false;
                            break;
                        }
                    }
                }

                if (isValidate)
                {
                    timer1.Enabled = false;
                    DialogResult result = MessageBox.Show("You completed the whole board properly!\n" +
                        "Do you wish to save your score?", "Congratulations", MessageBoxButtons.YesNo);
                    if(result == DialogResult.Yes)
                    {
                        // ask user to enter the nickname
                        string inputNickname = null;
                        if (InputStringBox("Enter a nickname", "Please enter your nickname:", ref inputNickname) == DialogResult.OK)
                        {
                            // disable button82 to prevent user from saving
                            // the score many times
                            this.button82.Enabled = false;

                            // prepare the text and path
                            string scoresContent = (DateTime.Now.ToString("dd'/'MM'/'yyyy HH:mm:ss") + ";" + inputNickname
                                +  ";" + this.stopWatchLabel.Text.Substring(6, 8) + ";" + selectedBoard);
                            string path = Environment.ExpandEnvironmentVariables("%AppData%") + @"/Sudoku";

                            // save the text to the file
                            if(!Directory.Exists(path))
                            {
                                Directory.CreateDirectory(path);
                            }
                            using (StreamWriter sw = File.AppendText(path + "/scores.csv"))
                            {
                                sw.WriteLine(scoresContent);
                            }
                        }
                    }
                } else
                {
                    MessageBox.Show("You still have many errors on your board.", "Board is not properly filled", MessageBoxButtons.OK);
                }
            }
        }

        // checking the row
        bool checkRow(int[,] sudoku, int number)
        {

            bool isValidate = true;
            HashSet<int> hs = new HashSet<int>();
            for (int i = 0; i < 9; i++)
            {
                if (!hs.Add(sudoku[i, number]))
                {
                    isValidate = false;
                    break;
                }
            }
            return isValidate;
        }

        // checking the column
        bool checkColumn(int[,] sudoku, int number)
        {

            bool isValidate = true;
            HashSet<int> hs = new HashSet<int>();
            for (int i = 0; i < 9; i++)
            {
                if (!hs.Add(sudoku[number, i]))
                {
                    isValidate = false;
                    break;
                }
            }
            return isValidate;
        }

        // checking the whole field
        bool checkField(int[,] sudoku, int number)
        {

            int i = 0, j = 0;
            switch (number)
            {
                case 1:
                    i = 0;
                    j = 0;
                    break;
                case 2:
                    i = 0;
                    j = 3;
                    break;
                case 3:
                    i = 0;
                    j = 6;
                    break;
                case 4:
                    i = 3;
                    j = 0;
                    break;
                case 5:
                    i = 3;
                    j = 3;
                    break;
                case 6:
                    i = 3;
                    j = 6;
                    break;
                case 7:
                    i = 6;
                    j = 0;
                    break;
                case 8:
                    i = 6;
                    j = 3;
                    break;
                case 9:
                    i = 6;
                    j = 6;
                    break;
            }

            bool isValidate = true;
            HashSet<int> hs = new HashSet<int>();
            {
                for (int a = i; a < i + 3; a++)
                {
                    for (int b = j; b < j + 3; b++)
                    {
                        if (!hs.Add(sudoku[a, b]))
                        {
                            isValidate = false;
                            goto Finish;
                        }
                    }
                }
            }

            Finish:
            return isValidate;
        }
    }
}