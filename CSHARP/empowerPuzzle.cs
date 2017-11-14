using System;

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
			int i, j, minLen, startIdx, wordCount = 0;
			bool retVal, wordAlreadyFound = false;
			string tempWord, currentIndexString = "";

			var rowLen = puzzle.GetLength (0); // Stores puzzle row length
			var colLen = puzzle.GetLength (1); // Stores puzzle column length

			if (rowLen < colLen)
				minLen = rowLen;
			else
				minLen = colLen;

			string[] wordList = new String[rowLen * colLen * 3];
			string[] indexList = new String[rowLen * colLen * 3];

			// Rows
			for (i = 0; i < rowLen; i++) {
				for (startIdx = 0; startIdx < colLen; startIdx++) {
					tempWord = "";
					currentIndexString = "";
					for (j = startIdx; j < colLen; j++) {
						tempWord += puzzle [i, j];
						currentIndexString += "" + i + j;
						retVal = Puzzle.IsWord (tempWord);
						if (retVal == true) {
							foreach (string y in indexList) {
								if ((y != null) && (y.CompareTo (currentIndexString) == 0)) // if it matches index hash
									wordAlreadyFound = true;
							}
							if (wordAlreadyFound == false) {
								wordList [wordCount] = tempWord;
								indexList [wordCount] = currentIndexString;
								wordCount += 1;
							}
							wordAlreadyFound = false;
						}
					}	
				}
			}

			// Rows Reverse
			for (i = rowLen - 1; i >= 0; i--) {
				for (startIdx = colLen - 1; startIdx >= 0; startIdx--) {
					tempWord = "";
					currentIndexString = "";
					for (j = startIdx; j >= 0; j--) {
						tempWord += puzzle [i, j];
						currentIndexString += "" + i + j;
						retVal = Puzzle.IsWord (tempWord);
						if (retVal == true) {
							foreach (string y in indexList) {
								if ((y != null) && (y.CompareTo (currentIndexString) == 0))
									wordAlreadyFound = true;
							}
							if (wordAlreadyFound == false) {
								wordList [wordCount] = tempWord;
								indexList [wordCount] = currentIndexString;
								wordCount += 1;
							}
							wordAlreadyFound = false;
						}
					}	
				}
			}

			// Columns
			for (i = 0; i < colLen; i++) {
				for (startIdx = 0; startIdx < rowLen; startIdx++) {
					tempWord = "";
					currentIndexString = "";
					for (j = startIdx; j < rowLen; j++) {
						tempWord += puzzle [j, i];
						currentIndexString += "" + j + i;
						retVal = Puzzle.IsWord (tempWord);
						if (retVal == true) {
							foreach (string y in indexList) {
								if ((y != null) && (y.CompareTo (currentIndexString) == 0))
									wordAlreadyFound = true;
							}
							if (wordAlreadyFound == false) {
								wordList [wordCount] = tempWord;
								indexList [wordCount] = currentIndexString;
								wordCount += 1;
							}
							wordAlreadyFound = false;
						}
					}
				}
			}

			// Columns Reverse
			for (i = colLen - 1; i >= 0; i--) {
				for (startIdx = rowLen - 1; startIdx >= 0; startIdx--) {
					tempWord = "";
					currentIndexString = "";
					for (j = startIdx; j >= 0; j--) {
						tempWord += puzzle [j, i];
						currentIndexString += "" + j + i;
						retVal = Puzzle.IsWord (tempWord);
						if (retVal == true) {
							foreach (string y in indexList) {
								if ((y != null) && (y.CompareTo (currentIndexString) == 0))
									wordAlreadyFound = true;
							}
							if (wordAlreadyFound == false) {
								wordList [wordCount] = tempWord;
								indexList [wordCount] = currentIndexString;
								wordCount += 1;
							}
							wordAlreadyFound = false;
						}
					}
				}
			}

			// Diagonally
			// Top
			for (i = 0; i < rowLen; i++) {
				for (j = 0; j < minLen; j++) {
					tempWord = "";
					currentIndexString = "";
					startIdx = 0;
					while (startIdx < rowLen) {
						if ((0 + startIdx + j < colLen) && (i + startIdx + j < rowLen)) {
							tempWord += puzzle [i + startIdx + j, 0 + startIdx + j];
							currentIndexString += "" + (i + startIdx + j) + (0 + startIdx + j);
							retVal = Puzzle.IsWord (tempWord);
							if (retVal == true) {
								foreach (string y in indexList) {
									if ((y != null) && (y.CompareTo (currentIndexString) == 0))
										wordAlreadyFound = true;
								}
								if (wordAlreadyFound == false) {
									wordList [wordCount] = tempWord;
									indexList [wordCount] = currentIndexString;
									wordCount += 1;
								}
								wordAlreadyFound = false;
							}
						}
						startIdx++;
					}
				}
			}
			// Bottom
			for (i = 1; i < colLen; i++) { // Start diagonal at 1 to skip center diag - already added
				for (j = 0; j < minLen; j++) {
					tempWord = "";
					currentIndexString = "";
					startIdx = 0;
					while (startIdx < colLen) {
						if ((0 + startIdx + j < rowLen) && (i + startIdx + j < colLen)) {
							tempWord += puzzle [0 + startIdx + j, i + startIdx + j];
							currentIndexString += "" + (0 + startIdx + j) + (i + startIdx + j);
							retVal = Puzzle.IsWord (tempWord);
							if (retVal == true) {
								foreach (string y in indexList) {
									if ((y != null) && (y.CompareTo (currentIndexString) == 0))
										wordAlreadyFound = true;
								}
								if (wordAlreadyFound == false) {
									wordList [wordCount] = tempWord;
									indexList [wordCount] = currentIndexString;
									wordCount += 1;
								}
								wordAlreadyFound = false;
							}
						}
						startIdx++;
					}
				}
			}

			// Diagonally Reverse
			// Top
			for (i = rowLen - 1; i >= 0; i--) {
				for (j = 0; j < minLen; j++) {
					tempWord = "";
					currentIndexString = "";
					startIdx = rowLen - 1;
					while (startIdx >= 0) {
						if ((0 + startIdx + j < colLen) && (i + startIdx + j < rowLen)) {
							tempWord += puzzle [i + startIdx, 0 + startIdx];
							currentIndexString += "" + (i + startIdx) + (0 + startIdx);
							retVal = Puzzle.IsWord (tempWord);
							if (retVal == true) {
								foreach (string y in indexList) {
									if ((y != null) && (y.CompareTo (currentIndexString) == 0))
										wordAlreadyFound = true;
								}
								if (wordAlreadyFound == false) {
									wordList [wordCount] = tempWord;
									indexList [wordCount] = currentIndexString;
									wordCount += 1;
								}
								wordAlreadyFound = false;
							}
						}
						startIdx--;
					}
				}
			}
			// Bottom
			for (i = colLen - 1; i >= 1; i--) { // Start diagonal at 1 to skip center diag - already added
				for (j = 0; j < minLen; j++) {
					tempWord = "";
					currentIndexString = "";
					startIdx = colLen - 1;
					while (startIdx >= 0) {
						if ((0 + startIdx + j < rowLen) && (i + startIdx + j < colLen)) {
							tempWord += puzzle [0 + startIdx, i + startIdx];
							currentIndexString = "" + (0 + startIdx) + (i + startIdx);
							retVal = Puzzle.IsWord (tempWord);
							if (retVal == true) {
								foreach (string y in indexList) {
									if ((y != null) && (y.CompareTo (currentIndexString) == 0))
										wordAlreadyFound = true;
								}
								if (wordAlreadyFound == false) {
									wordList [wordCount] = tempWord;
									indexList [wordCount] = currentIndexString;
									wordCount += 1;
								}
								wordAlreadyFound = false;
							}
						}
						startIdx--;
					}
				}
			}

			// Diagonally Pt. 2: The other diagonal
			// Top
			for (i = colLen - 1; i >= 0; i--) {
				for (j = 0; j < minLen; j++) {
					tempWord = "";
					currentIndexString = "";
					startIdx = 0;
					while (startIdx < rowLen) {
						if ((0 + startIdx + j < rowLen) && (i - startIdx - j >= 0)) {
							tempWord += puzzle [0 + startIdx + j, i - startIdx - j];
							currentIndexString += "" + (0 + startIdx + j) + (i - startIdx - j);
							retVal = Puzzle.IsWord (tempWord);
							if (retVal == true) {
								foreach (string y in indexList) {
									if ((y != null) && (y.CompareTo (currentIndexString) == 0))
										wordAlreadyFound = true;
								}
								if (wordAlreadyFound == false) {
									wordList [wordCount] = tempWord;
									indexList [wordCount] = currentIndexString;
									wordCount += 1;
								}
								wordAlreadyFound = false;
							}
						}
						startIdx++;
					}
				}
			}
			// Bottom
			for (i = 1; i < rowLen; i++) { // Start diagonal at 1 to skip center diag - already added
				for (j = 0; j < minLen; j++) {
					tempWord = "";
					currentIndexString = "";
					startIdx = 0;
					while (startIdx < rowLen - 1) {
						if ((i + startIdx + j < rowLen) && (colLen - 1 - startIdx - j >= 0)) {
							tempWord += puzzle [i + startIdx + j, colLen - 1 - startIdx - j];
							currentIndexString += "" + (i + startIdx + j) + (colLen - 1 - startIdx - j);
							retVal = Puzzle.IsWord (tempWord);
							if (retVal == true) {
								foreach (string y in indexList) {
									if ((y != null) && (y.CompareTo (currentIndexString) == 0))
										wordAlreadyFound = true;
								}
								if (wordAlreadyFound == false) {
									wordList [wordCount] = tempWord;
									indexList [wordCount] = currentIndexString;
									wordCount += 1;
								}
								wordAlreadyFound = false;
							}
						}
						startIdx++;
					}
				}
			}

			// Diagonally Pt. 2: The other diagonal - reversed
			// Top
			for (i = rowLen - 1; i >= 0; i--) {
				for (j = 0; j < minLen; j++) {
					tempWord = "";
					currentIndexString = "";
					startIdx = 0;
					while (startIdx < rowLen) {
						if ((0 + startIdx + j < colLen) && (i - startIdx - j >= 0)) {
							tempWord += puzzle [i - startIdx - j, 0 + startIdx + j];
							currentIndexString += "" + (i - startIdx - j) + (0 + startIdx + j);
							retVal = Puzzle.IsWord (tempWord);
							if (retVal == true) {
								foreach (string y in indexList) {
									if ((y != null) && (y.CompareTo (currentIndexString) == 0))
										wordAlreadyFound = true;
								}
								if (wordAlreadyFound == false) {
									wordList [wordCount] = tempWord;
									indexList [wordCount] = currentIndexString;
									wordCount += 1;
								}
								wordAlreadyFound = false;
							}
						}
						startIdx++;
					}
				}
			}
			// Bottom
			for (i = 1; i < colLen; i++) { // Start diagonal at 1 to skip center diag - already added
				for (j = 0; j < minLen; j++) {
					tempWord = "";
					currentIndexString = "";
					startIdx = 0;
					while (startIdx < colLen - 1) {
						if ((rowLen - 1 - startIdx - j >= 0) && (i + startIdx + j < colLen)) {
							tempWord += puzzle [rowLen - 1 - startIdx - j, i + startIdx + j];
							currentIndexString += "" + (rowLen - 1 - startIdx - j) + (i + startIdx + j);
							retVal = Puzzle.IsWord (tempWord);
							if (retVal == true) {
								foreach (string y in indexList) {
									if ((y != null) && (y.CompareTo (currentIndexString) == 0))
										wordAlreadyFound = true;
								}
								if (wordAlreadyFound == false) {
									wordList [wordCount] = tempWord;
									indexList [wordCount] = currentIndexString;
									wordCount += 1;
								}
								wordAlreadyFound = false;
							}
						}
						startIdx++;
					}
				}
			}

			string outString = "Found: ";
			foreach (string x in wordList) {
				if (x != null)
					outString += x.ToString () + ", ";
			}
			outString = outString.Substring (0, outString.LastIndexOf (","));
			Console.WriteLine (outString);

			return wordCount;
		}
	}

	class Solve
	{
		public static void Main (string[] args)
		{
			/*char[,] puzzle = new char[,] {
				{ 'C', 'T' },
				{ 'A', 'T' },
			};*/
			/*char[,] puzzle = new char[,] {
			{ 'C', 'A', 'T' },
			{ 'X', 'Z', 'T' },
			{ 'Y', 'O', 'T' },
			};*/
			char[,] puzzle = new char[,] {
				{ 'C', 'A', 'T', 'A', 'P', 'U', 'L', 'T' },
				{ 'X', 'Z', 'T', 'T', 'O', 'Y', 'O', 'O' },
				{ 'Y', 'O', 'T', 'O', 'X', 'T', 'X', 'X' },
			};
			int numPermutations = Puzzle.FindWords (puzzle);
			Console.WriteLine ("Total: " + numPermutations);
		}
	}
}
