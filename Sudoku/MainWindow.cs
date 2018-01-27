using System;
using System.Collections.Generic;
using System.Windows.Forms;

//
// Showing the main window.
//

namespace Sudoku
{
    public partial class MainWindow : Form
    {
        public List<Button> buttonList;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            countBoards = boardList.Count;

            // list of all buttons
            buttonList = new List<Button>();
            buttonList.Add(this.button1);
            buttonList.Add(this.button2);
            buttonList.Add(this.button3);
            buttonList.Add(this.button4);
            buttonList.Add(this.button5);
            buttonList.Add(this.button6);
            buttonList.Add(this.button7);
            buttonList.Add(this.button8);
            buttonList.Add(this.button9);
            buttonList.Add(this.button10);
            buttonList.Add(this.button11);
            buttonList.Add(this.button12);
            buttonList.Add(this.button13);
            buttonList.Add(this.button14);
            buttonList.Add(this.button15);
            buttonList.Add(this.button16);
            buttonList.Add(this.button17);
            buttonList.Add(this.button18);
            buttonList.Add(this.button19);
            buttonList.Add(this.button20);
            buttonList.Add(this.button21);
            buttonList.Add(this.button22);
            buttonList.Add(this.button23);
            buttonList.Add(this.button24);
            buttonList.Add(this.button25);
            buttonList.Add(this.button26);
            buttonList.Add(this.button27);
            buttonList.Add(this.button28);
            buttonList.Add(this.button29);
            buttonList.Add(this.button30);
            buttonList.Add(this.button31);
            buttonList.Add(this.button32);
            buttonList.Add(this.button33);
            buttonList.Add(this.button34);
            buttonList.Add(this.button35);
            buttonList.Add(this.button36);
            buttonList.Add(this.button37);
            buttonList.Add(this.button38);
            buttonList.Add(this.button39);
            buttonList.Add(this.button40);
            buttonList.Add(this.button41);
            buttonList.Add(this.button42);
            buttonList.Add(this.button43);
            buttonList.Add(this.button44);
            buttonList.Add(this.button45);
            buttonList.Add(this.button46);
            buttonList.Add(this.button47);
            buttonList.Add(this.button48);
            buttonList.Add(this.button49);
            buttonList.Add(this.button50);
            buttonList.Add(this.button51);
            buttonList.Add(this.button52);
            buttonList.Add(this.button53);
            buttonList.Add(this.button54);
            buttonList.Add(this.button55);
            buttonList.Add(this.button56);
            buttonList.Add(this.button57);
            buttonList.Add(this.button58);
            buttonList.Add(this.button59);
            buttonList.Add(this.button60);
            buttonList.Add(this.button61);
            buttonList.Add(this.button62);
            buttonList.Add(this.button63);
            buttonList.Add(this.button64);
            buttonList.Add(this.button65);
            buttonList.Add(this.button66);
            buttonList.Add(this.button67);
            buttonList.Add(this.button68);
            buttonList.Add(this.button69);
            buttonList.Add(this.button70);
            buttonList.Add(this.button71);
            buttonList.Add(this.button72);
            buttonList.Add(this.button73);
            buttonList.Add(this.button74);
            buttonList.Add(this.button75);
            buttonList.Add(this.button76);
            buttonList.Add(this.button77);
            buttonList.Add(this.button78);
            buttonList.Add(this.button79);
            buttonList.Add(this.button80);
            buttonList.Add(this.button81);

            foreach (Button but in buttonList)
            {
                // disable all of the buttons
                but.Text = null;
                but.Enabled = false;

                // set font size
                // but.Font = new Font(but.Font.FontFamily, 24);

                // add onclick event
                but.Click += new EventHandler(fill_sudoku_button);
            }

            // disable button82 so user cannot check the empty board
            this.button82.Enabled = false;
        }
    }
}