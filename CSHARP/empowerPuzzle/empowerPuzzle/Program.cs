/*using System;

namespace empowerPuzzle
{

	public static class Puzzle
	{
		public static string[] DICTIONARY = { "OX", "CAT", "TOY", "AT", "DOG", "CATAPULT", "T" };

		static bool IsWord (string testWord)
		{
			foreach (string x in DICTIONARY) {
				if (x.CompareTo (testWord) == 0)
					return true;
			}
			return false;
		}

		public static int FindWords (char[,] puzzle)
		{

			int wordCount = 0;
			int i = 0;
			int j = 0;
			int k = 0;
			int startIdx = 0;
			string tempWord = "";
			string tempWord2 = "";
			var retVal = false;
			var wordAlreadyFound = false;

			var rowLen = puzzle.GetLength (0); // Stores puzzle row length
			var colLen = puzzle.GetLength (1); // Stores puzzle column length

			string[] foundWords = new String[rowLen * colLen];
			string[] foundWords2 = new String[rowLen * colLen];

			// Rows
			foundWords = new String[rowLen * colLen];
			Console.WriteLine ("Rows: ");
			for (i = 0; i < rowLen; i++) {
				tempWord = "";
				for (startIdx = 0; startIdx < colLen; startIdx++) {
					tempWord = "";
					for (j = startIdx; j < colLen; j++) {
						tempWord += puzzle [i, j];
						//Console.WriteLine (tempWord);
						retVal = Puzzle.IsWord (tempWord);
						if (retVal == true) {
							if (foundWords.GetLength (0) > 0) {
								foreach (string x in foundWords) {
									if ((x != null) && (x.CompareTo (tempWord) == 0)) {
										wordAlreadyFound = true;
									}
								}
							}
							if (wordAlreadyFound == false) {
								foundWords [wordCount] = tempWord;
								wordCount += 1;
							}
							wordAlreadyFound = false;
						}
					}	
				}
			}
			Console.WriteLine ("Wordcount: " + wordCount);

			// Rows Reverse
			Console.WriteLine ("Rows Reversed: ");
			for (i = rowLen - 1; i >= 0; i--) {
				tempWord = "";
				for (startIdx = colLen - 1; startIdx >= 0; startIdx--) {
					tempWord = "";
					for (j = startIdx; j >= 0; j--) {
						tempWord += puzzle [i, j];
						//Console.WriteLine (tempWord);
						retVal = Puzzle.IsWord (tempWord);
						if (retVal == true) {
							if (foundWords.GetLength (0) > 0) {
								foreach (string x in foundWords) {
									if ((x != null) && (x.CompareTo (tempWord) == 0)) {
										wordAlreadyFound = true;
									}
								}
							}
							if (wordAlreadyFound == false) {
								foundWords [wordCount] = tempWord;
								wordCount += 1;
							}
							wordAlreadyFound = false;
						}
					}	
				}
			}
			Console.WriteLine ("Wordcount: " + wordCount);
			Console.Write ("Found: ");
			foreach (string x in foundWords) {
				if (x != null) {
					Console.Write (x.ToString () + ", ");
				}
			}
			Console.WriteLine (""); // Formatting

			// Columns
			foundWords = new string[rowLen * colLen];
			Console.WriteLine ("Columns: ");
			for (i = 0; i < colLen; i++) {
				tempWord = "";
				for (startIdx = 0; startIdx < rowLen; startIdx++) {
					tempWord = "";
					for (j = startIdx; j < rowLen; j++) {
						tempWord += puzzle [j, i];
						//Console.WriteLine (tempWord);
						retVal = Puzzle.IsWord (tempWord);
						if (retVal == true) {
							if (foundWords.GetLength (0) > 0) {
								foreach (string x in foundWords) {
									if ((x != null) && (x.CompareTo (tempWord) == 0)) {
										wordAlreadyFound = true;
									}
								}
							}
							if (wordAlreadyFound == false) {
								foundWords [wordCount] = tempWord;
								wordCount += 1;
							}
							wordAlreadyFound = false;
						}
					}
				}
			}
			Console.WriteLine ("Wordcount: " + wordCount);

			// Columns Reverse
			Console.WriteLine ("Columns Reversed: ");
			for (i = colLen - 1; i >= 0; i--) {
				tempWord = "";
				for (startIdx = rowLen - 1; startIdx >= 0; startIdx--) {
					tempWord = "";
					for (j = startIdx; j >= 0; j--) {
						tempWord += puzzle [j, i];
						//Console.WriteLine (tempWord);
						retVal = Puzzle.IsWord (tempWord);
						if (retVal == true) {
							if (foundWords.GetLength (0) > 0) {
								foreach (string x in foundWords) {
									if ((x != null) && (x.CompareTo (tempWord) == 0)) {
										wordAlreadyFound = true;
									}
								}
							}
							if (wordAlreadyFound == false) {
								foundWords [wordCount] = tempWord;
								wordCount += 1;
							}
							wordAlreadyFound = false;
						}
					}
				}
			}
			Console.WriteLine ("Wordcount: " + wordCount);
			Console.Write ("Found: ");
			foreach (string x in foundWords) {
				if (x != null) {
					Console.Write (x.ToString () + ", ");
				}
			}
			Console.WriteLine (""); // Formatting

			/*
			// Diagonally
			foundWords = new string[rowLen * colLen];
			Console.WriteLine ("Diagonally: ");
			for (i = 0; i < rowLen; i++) {
				tempWord = "";
				tempWord2 = "";
				for (j = 0; j < colLen; j++) {
					for (k = 0; k < colLen; k++) {
						if ((j < rowLen) && (k < colLen)) {
							if (j <= k) {
								if (j + i == k) {
									tempWord += puzzle [j, k];
									//Console.WriteLine (tempWord);
									retVal = Puzzle.IsWord (tempWord);
									if (retVal == true) {
										if (foundWords.GetLength (0) > 0) {
											foreach (string x in foundWords) {
												if ((x != null) && (x.CompareTo (tempWord) == 0))
													wordAlreadyFound = true;
											}
										}
										if (wordAlreadyFound == false) {
											foundWords [wordCount] = tempWord;
											wordCount += 1;
										}
										wordAlreadyFound = false;
									}
								}
							} else if (j > k) {
								if (j - i == k) {
									tempWord2 += puzzle [j, k];
									//Console.WriteLine (tempWord2);
									retVal = Puzzle.IsWord (tempWord2);
									if (retVal == true) {
										if (foundWords.GetLength (0) > 0) {
											foreach (string x in foundWords) {
												if ((x != null) && (x.CompareTo (tempWord2) == 0))
													wordAlreadyFound = true;
											}
										}
										if (wordAlreadyFound == false) {
											foundWords [wordCount] = tempWord2;
											wordCount += 1;
										}
										wordAlreadyFound = false;
									}
								}
							}
						}
					}
				}
			}
			Console.WriteLine ("Wordcount: " + wordCount);
			Console.Write ("Found: ");
			foreach (string x in foundWords) {
				if (x != null) {
					Console.Write (x.ToString () + ", ");
				}
			}
			Console.WriteLine (""); // Formatting

			// Diagonally Reverse
			Console.WriteLine ("Diagonally Reversed: ");
			for (i = rowLen - 1; i >= 0; i--) {
				tempWord = "";
				tempWord2 = "";
				for (j = colLen - 1; j >= 0; j--) {
					for (k = colLen - 1; k >= 0; k--) {
						if ((j < rowLen) && (k < colLen)) {
							if (j <= k) {
								if (j + i == k) {
									tempWord += puzzle [j, k];
									//Console.WriteLine (tempWord);
									retVal = Puzzle.IsWord (tempWord);
									if (retVal == true) {
										if (foundWords.GetLength (0) > 0) {
											foreach (string x in foundWords) {
												if ((x != null) && (x.CompareTo (tempWord) == 0))
													wordAlreadyFound = true;
											}
										}
										if (wordAlreadyFound == false) {
											foundWords [wordCount] = tempWord;
											foundWords2 [wordCount] = tempWord;
											wordCount += 1;
										}
										wordAlreadyFound = false;
									}
								}
							} else if (j > k) {
								if (j - i == k) {
									tempWord2 += puzzle [j, k];
									//Console.WriteLine (tempWord2);
									retVal = Puzzle.IsWord (tempWord2);
									if (retVal == true) {
										if (foundWords.GetLength (0) > 0) {
											foreach (string x in foundWords) {
												if ((x != null) && (x.CompareTo (tempWord2) == 0))
													wordAlreadyFound = true;
											}
										}
										if (wordAlreadyFound == false) {
											foundWords [wordCount] = tempWord2;
											foundWords2 [wordCount] = tempWord2;
											wordCount += 1;
										}
										wordAlreadyFound = false;
									}
								}
							}
						}
					}
				}
			}
			Console.WriteLine ("Wordcount: " + wordCount);
			Console.Write ("Found: ");
			foreach (string x in foundWords2) {
				if (x != null) {
					Console.Write (x.ToString () + ", ");
				}
			}
			Console.WriteLine (""); // Formatting
			*/

/*
			string tmpS = "";
			startIdx = 0;
			int tempi = 0;
			int tempj = 0;
			for (i = 0; i < rowLen; i++) {
				tmpS = "";
				for (j = 0; j < colLen; j++) {
					//tmpS += puzzle [i, j];
					//Console.WriteLine (tmpS);
					startIdx = 0;
					tmpS = "";
					while (startIdx < rowLen) {
						tempi = startIdx + i;
						tempj = startIdx + j;
						if ((tempi < rowLen) && (tempj < colLen)) {
							tmpS += puzzle [i + startIdx, j + startIdx];
							Console.WriteLine (tmpS);
						}
						startIdx++;
					}
				}
			}
			*/

////////////
// Diagonally
/*string tmpS = "";

			for (i = 0; i < rowLen; i++) {
				tmpS = "";
				startIdx = 0;
				while (startIdx < rowLen) {
					if ((0 + startIdx < colLen) && (i + startIdx < rowLen)) {
						tmpS += puzzle [i + startIdx, 0 + startIdx];
						Console.WriteLine (tmpS);
					}
					startIdx++;
				}
			}

			for (i = 1; i < colLen; i++) { // 1 because we already got diagonal starting at 0,0
				tmpS = "";
				startIdx = 0;
				while (startIdx < colLen) {
					if ((0 + startIdx < rowLen) && (i + startIdx < colLen)) {
						tmpS += puzzle [0 + startIdx, i + startIdx];
						Console.WriteLine (tmpS);
					}
					startIdx++;
				}
			}

			// Diagonally Reverse
			string tmpS = "";
			for (i = rowLen - 1; i >= 0; i--) {
				tmpS = "";
				startIdx = rowLen - 1;
				while (startIdx >= 0) {
					if ((0 + startIdx < colLen) && (i + startIdx < rowLen)) {
						tmpS += puzzle [i + startIdx, 0 + startIdx];
						Console.WriteLine (tmpS);
					}
					startIdx--;
				}
			}

			for (i = colLen - 1; i >= 1; i--) { // 1 because we already got diagonal starting at 0,0
				tmpS = "";
				startIdx = colLen - 1;
				while (startIdx >= 0) {
					if ((0 + startIdx < rowLen) && (i + startIdx < colLen)) {
						tmpS += puzzle [0 + startIdx, i + startIdx];
						Console.WriteLine (tmpS);
					}
					startIdx--;
				}
			}

			*/
////////
/*
			// Diagonally Other Way
			// Top
			string tmpS = "";
			for (i = colLen - 1; i >= 0; i--) {
				tmpS = "";
				startIdx = 0;
				while (startIdx < rowLen) {
					if ((0 + startIdx < rowLen) && (i - startIdx >= 0)) {
						tmpS += puzzle [0 + startIdx, i - startIdx];
						Console.WriteLine (tmpS);
					}
					startIdx++;

				}
			}
			// Bottom
			//string tmpS = "";
			for (i = 1; i < rowLen; i++) { // 1 because we already got diagonal at 0,colLen
				tmpS = "";
				startIdx = 0;
				while (startIdx < rowLen - 1) {
					if ((i + startIdx < rowLen) && (colLen - 1 - startIdx >= 0)) {
						tmpS += puzzle [i + startIdx, colLen - 1 - startIdx];
						Console.WriteLine (tmpS);
					}
					startIdx++;
				}
			}

			// Diagonally Reverse Other Way
			// Top
			//string tmpS = "";
			for (i = rowLen - 1; i >= 0; i--) {
				tmpS = "";
				startIdx = 0;
				while (startIdx < rowLen) {
					if ((0 + startIdx < colLen) && (i - startIdx >= 0)) {
						tmpS += puzzle [i - startIdx, 0 + startIdx];
						Console.WriteLine (tmpS);
					}
					startIdx++;

				}
			}
			// Bottom
			//string tmpS = "";
			for (i = 1; i < colLen; i++) { // 1 because we already got diagonal at 0,colLen
				tmpS = "";
				startIdx = 0;
				while (startIdx < colLen - 1) {
					if ((rowLen - 1 - startIdx >= 0) && (i + startIdx < colLen)) {
						tmpS += puzzle [rowLen - 1 - startIdx, i + startIdx];
						Console.WriteLine (tmpS);
					}
					startIdx++;
				}
			}

			/*
			// ADD OTHER REVERSED DIAGONALLY...
			//...

			// THEN ADD REVERSED, REVERSED DIAGONALLY
			//...
			*/
/*
			return 0;
		}
	}

	class Solve
	{
		public static void Main (string[] args)
		{
			/*char[,] puzzle = new char[,] {
				{ 'C', 'A', 'T' },
				{ 'X', 'Z', 'T' },
				{ 'Y', 'O', 'T' },
			};*/
/*			char[,] puzzle = new char[,] {
				{ 'C', 'A', 'T', 'A', 'P', 'U', 'L', 'T' },
				{ 'X', 'Z', 'T', 'T', 'O', 'Y', 'O', 'O' },
				{ 'Y', 'O', 'T', 'O', 'X', 'T', 'X', 'X' },
			};
			Puzzle.FindWords (puzzle);
		}
	}
}
*/