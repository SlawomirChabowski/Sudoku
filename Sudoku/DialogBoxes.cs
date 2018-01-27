using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

//
// The following partial class contains all of the dialog boxes
// that was used in the program.
//

namespace Sudoku
{
    partial class MainWindow
    {
        // creates the dialog box to input the board number
        public static DialogResult InputNumberBox(string title, string promptText, ref int value)
        {
            Form form = new Form();
            Label label = new Label();
            NumericUpDown numericUpDown = new NumericUpDown();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = title;
            label.Text = promptText;
            numericUpDown.Text = "1";

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            numericUpDown.Maximum = CountBoards;
            numericUpDown.Minimum = 1;
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);
            numericUpDown.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            label.AutoSize = true;
            numericUpDown.Anchor = numericUpDown.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, numericUpDown, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();
            value = (int)numericUpDown.Value;
            return dialogResult;
        }

        // creates the dialog box to input a nickname
        public static DialogResult InputStringBox(string title, string promptText, ref string value)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();

            form.Text = title;
            label.Text = promptText;

            buttonOk.Text = "OK";
            buttonOk.DialogResult = DialogResult.OK;

            label.SetBounds(9, 20, 372, 13);
            textBox.SetBounds(12, 36, 295, 20);
            buttonOk.SetBounds(309, 35, 75, 22);

            textBox.MaxLength = 20;

            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 80);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;

            DialogResult dialogResult = form.ShowDialog();
            value = textBox.Text;
            return dialogResult;
        }

        private void aboutAuthorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string msg = "Created by Sławomir Chabowski\n\n" +
                "Email address: slawomir.chabowski@gmail.com\n" +
                "Github: github.com/SlawomirChabowski";
            MessageBox.Show(msg, "About author", MessageBoxButtons.OK);
        }

        private void rulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string msg = "Sudoku is a number placing puzzle based on a 9x9 grid with several given numbers. " +
                "The object is to place the numbers 1 to 9 in the empty squares so that each row, each column " +
                "and each 3x3 box contains the same number only once.\n\n" +
                "To start a new game you must draw or select a board, then you'll be able to click on some of buttons " +
                "below - when you finish the board you can check it by clicking a button on the bottom of the application.";
            MessageBox.Show(msg, "How to play", MessageBoxButtons.OK);
        }

        // show scoreboard
        private void scoreboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = Environment.ExpandEnvironmentVariables("%AppData%") + @"/Sudoku";
            if (!Directory.Exists(path) || !File.Exists(path + "/scores.csv") || new FileInfo(path + "/scores.csv").Length < 30)
            {
                MessageBox.Show("There are not any records on the scoreboard.\n" +
                    "Why don't you try to make some? :-)", "The scoreboard is empty", MessageBoxButtons.OK);
            }
            else
            {
                // show scoreboard window
                Scoreboard scoreboard = new Scoreboard();
                scoreboard.ShowDialog();
            }
        }
    }
}