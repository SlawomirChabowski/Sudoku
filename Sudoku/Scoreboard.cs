using System;
using System.IO;
using System.Windows.Forms;

//
// The following view is used to show the scoreboard
//

namespace Sudoku
{
    public partial class Scoreboard : Form
    {
        public Scoreboard()
        {
            InitializeComponent();

            // read the scores
            string[] scores = File.ReadAllLines(Environment.ExpandEnvironmentVariables("%AppData%") + @"/Sudoku/scores.csv");

            // insert the scores into the DataGrididView
            string[] temp;
            foreach(String score in scores)
            {
                // cut a record into 4 pieces of strings in a temporary table
                temp = score.Split(';');

                // put the information from temp onto the DataGridView
                DataGridViewRow row = (DataGridViewRow)scoreTable.Rows[0].Clone();
                try
                {
                    row.Cells[0].Value = temp[0];
                    row.Cells[1].Value = temp[1];
                    row.Cells[2].Value = temp[3];
                    row.Cells[3].Value = temp[2];
                    scoreTable.Rows.Add(row);
                } 
                catch(IndexOutOfRangeException e) {}
            }
        }
    }
}
