using System;
namespace TicTacToe2
{
	public class Player
	{
		public string Name { get; set; }
		public char Marker { get; set; }
    }

	//public class Cell
	//{
 //       public int Row { get; }
 //       public int Column { get; }
	//	public char Marker { get; set; }

	//	public Cell(int row, int col)
	//	{
	//		Column = col;
	//		Row = row;
	//	}
	//}

	//public class Grid
	//{
	//	public List<Cell> Cells { get; private set; }

	//	public Grid()
	//	{
	//		CreateGrid(3, 3);
	//	}

	//	private void CreateGrid(int rows, int cols)
	//	{
	//		Cells = new List<Cell>();
	//		for (int r = 0; r < rows; r++) {
	//			for (int c = 0; c < cols; c++)
	//			{
	//				Console.ReadLine(Cells);
	//			}
	//		}
	//	}
	//}
}

