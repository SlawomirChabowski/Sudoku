namespace Sudoku
{
    partial class Scoreboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.scoreTable = new System.Windows.Forms.DataGridView();
            this.scoreDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scoreName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scoreBoardNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scoreTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.scoreTable)).BeginInit();
            this.SuspendLayout();
            // 
            // scoreTable
            // 
            this.scoreTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scoreTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.scoreDate,
            this.scoreName,
            this.scoreBoardNumber,
            this.scoreTime});
            this.scoreTable.Location = new System.Drawing.Point(13, 13);
            this.scoreTable.Name = "scoreTable";
            this.scoreTable.Size = new System.Drawing.Size(459, 236);
            this.scoreTable.TabIndex = 0;
            // 
            // scoreDate
            // 
            this.scoreDate.HeaderText = "Date";
            this.scoreDate.Name = "scoreDate";
            this.scoreDate.ReadOnly = true;
            this.scoreDate.Width = 90;
            // 
            // scoreName
            // 
            this.scoreName.HeaderText = "Name";
            this.scoreName.Name = "scoreName";
            this.scoreName.ReadOnly = true;
            // 
            // scoreBoardNumber
            // 
            this.scoreBoardNumber.HeaderText = "Board number";
            this.scoreBoardNumber.Name = "scoreBoardNumber";
            this.scoreBoardNumber.ReadOnly = true;
            // 
            // scoreTime
            // 
            this.scoreTime.HeaderText = "Time";
            this.scoreTime.Name = "scoreTime";
            this.scoreTime.ReadOnly = true;
            // 
            // Scoreboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.scoreTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Scoreboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Scoreboard";
            ((System.ComponentModel.ISupportInitialize)(this.scoreTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView scoreTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn scoreDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn scoreName;
        private System.Windows.Forms.DataGridViewTextBoxColumn scoreBoardNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn scoreTime;
    }
}