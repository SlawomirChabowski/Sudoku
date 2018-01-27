# Sudoku
It is a project written in C# to pass the subject at my university.
## How to play
All you have to do is to load the board and clicking enabled buttons to get the value you want to be sent. When you finish the whole board, you can check it with a button.
## Boards details
Boards are not generated in real time.
There are 12 boards built-in the game (the first two are: bad-filled checking board and good-filled checking board) but feel free to add your own boards (file *Boards.cs*).
### Adding boards
Just open the *Boards.cs* file and add a new array to the list. It has to be 9x9 array filled with numbers from 0 to 9 where 0 is clickable button and 1-9 are fixed button values.
### Board example:
```
{
	{ 8, 0, 0, 6, 0, 4, 0, 0, 0 },
	{ 0, 3, 0, 0, 0, 0, 0, 6, 0 },
	{ 0, 0, 6, 0, 5, 3, 8, 2, 0 },
	{ 0, 0, 0, 5, 8, 0, 0, 0, 0 },
	{ 0, 9, 0, 2, 0, 0, 0, 0, 0 },
	{ 1, 0, 0, 0, 0, 0, 9, 5, 0 },
	{ 0, 1, 0, 7, 0, 0, 2, 8, 0 },
	{ 0, 6, 0, 0, 0, 0, 3, 7, 1 },
	{ 3, 8, 0, 0, 0, 0, 0, 9, 0 }
}
```
