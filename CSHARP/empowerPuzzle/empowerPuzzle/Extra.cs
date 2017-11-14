using System;

namespace empowerPuzzle
{
	public class Extra
	{
		public Extra ()
		{
		}
	}
}


/*
			// Rows:
Console.WriteLine ("Rows: ");
for (i = 0; i < rowLen; i++) {
	tempWord = "";
	for (j = 0; j < colLen; j++) {
		tempWord += puzzle [i, j];
		Console.WriteLine (tempWord);
		retVal = Puzzle.IsWord (tempWord);
		if (retVal == true) {
			wordCount += 1;
		}
	}	
}
Console.WriteLine ("Wordcount: " + wordCount);

// Rows Reverse:
Console.WriteLine ("Rows Reversed: ");
for (i = rowLen - 1; i >= 0; i--) {
	tempWord = "";
	for (j = colLen - 1; j >= 0; j--) {
		tempWord += puzzle [i, j];
		Console.WriteLine (tempWord);
		retVal = Puzzle.IsWord (tempWord);
		if (retVal == true) {
			wordCount += 1;
		}
	}	
}
Console.WriteLine ("Wordcount: " + wordCount);

// Columns:
Console.WriteLine ("Columns: ");
for (i = 0; i < colLen; i++) {
	tempWord = "";
	for (j = 0; j < rowLen; j++) {
		tempWord += puzzle [j, i];
		Console.WriteLine (tempWord);
		retVal = Puzzle.IsWord (tempWord);
		if (retVal == true) {
			wordCount += 1;
		}
	}
}
Console.WriteLine ("Wordcount: " + wordCount);

// Columns Reverse:
Console.WriteLine ("Columns Reverseed: ");
for (i = colLen - 1; i >= 0; i--) {
	tempWord = "";
	for (j = rowLen - 1; j >= 0; j--) {
		tempWord += puzzle [j, i];
		Console.WriteLine (tempWord);
		retVal = Puzzle.IsWord (tempWord);
		if (retVal == true) {
			wordCount += 1;
		}
	}
}
Console.WriteLine ("Wordcount: " + wordCount);

// Diagonally:
Console.WriteLine ("Diagonally: ");
for (i = 0; i < colLen; i++) {
	tempWord = "";
	for (j = 0; j < rowLen; j++) {
		tempWord += puzzle [j, i];
		Console.WriteLine (tempWord);
		retVal = Puzzle.IsWord (tempWord);
		if (retVal == true) {
			wordCount += 1;
		}
	}
}
Console.WriteLine ("Wordcount: " + wordCount);
*/



/*
 * using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//
///**
// * CrosswordPuzzle.PuzzleSolver
// * Complete this program by filling out the findWords method.
// */
//
//namespace CrosswordPuzzle
//{
//	static class PuzzleSolver
//	{
//		public static string[] DICTIONARY = {"OX","CAT","TOY","AT","DOG","CATAPULT","T"};
//
//		public static int FindWords(char[,] puzzle) {
//			System.Console.WriteLine("rows: " + puzzle.GetLength(0));
//			System.Console.WriteLine("columns: " + puzzle.GetLength(1));
//			int rows = puzzle.GetLength(0);
//			int cols = puzzle.GetLength(0);
//			//transposeSystem.Console.
//			char[,] transposedArray = new char[cols, rows];
//			for (int y = 0; y < puzzle.GetLength(1); y += 1) {
//				for (int x = 0; x < puzzle.GetLength(0); x += 1) {
//					transposedArray[y,x] = puzzle[x,y];
//				}
//			}
//			System.Console.WriteLine("2new columns: " + transposedArray[0,0] + transposedArray[0,1] + transposedArray[0,2]);
//			//
//
//			//build possible permutations
//			//for (int i = 0; i<=9; i++) {
//			//    System.Console.WriteLine(i);
//			//}
//			//loop and count occurences
//			return 0;
//		}
//
//		static bool IsWord(string testWord) {
//			if (DICTIONARY.Contains(testWord)) {
//				return true;
//			} else {
//				return false;
//			}
//		}
//
//		static void Main(string[] args) {
//			char[,] puzzle = new char[,] {
//				{'C','A','T'},
//				{'X','Z','Z'},
//				{'Y','O','T'},
//				{'C','B','Z'}
//			};
//			System.Console.WriteLine("Output: " + FindWords(puzzle));
//			Console.Read();
//		}
//	}
//}


