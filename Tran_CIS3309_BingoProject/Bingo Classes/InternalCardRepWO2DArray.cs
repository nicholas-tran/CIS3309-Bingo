/*
Nicholas Tran
1/30/2018
tug26951@temple
Bingo Game Project
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tran_CIS3309_BingoProject
{   //Tracks bingo progress for the current game
    public class internalCardRepWO2DArray
    {
        //Initialize main attributes of the internal card class
        int forwardDiagonalCounter = 1;
        int backwardDiagonalCounter = 1;
        int[] internalBoardRows = new int[5] { 0, 0, 1, 0, 0 };
        int[] internalBoardCols = new int[5] { 0, 0, 1, 0, 0 };

        //Checks winner based the parameterized row and col and checks the corresponding arrays
        public int isWinner(int rowID, int colID)
        {   //Checks specific index of the row array
            if (internalBoardRows[rowID] == 5)
            {
                return 1;
            }
            //checks specific index of the col array 
            if (internalBoardCols[colID] == 5)
            {
                return 1;
            }
            //checks the forward diagonal counter
            if (forwardDiagonalCounter == 5)
            {
                return 1;
            }
            //checks the backward diagonal counter
            if (backwardDiagonalCounter == 5)
            {
                return 1;
            }
            //else no bingos
                return 0;
        }//End is winner method

        //After validation the row and col are used to increment the counter of the corresponding arrays
        public void recordCalledNumber(int rowID, int colID)
        {
            //increments the value at the index in the rows array 
            internalBoardRows[rowID]++;
            //increments the value at the index in the cols array
            internalBoardCols[colID]++;
            //if the row and col correspond to a backward diagonal
            if (rowID == colID)
            {
                backwardDiagonalCounter++;
            }
            //Checks for forward diagonal
            if (rowID == 4 && colID == 0)
            {
                forwardDiagonalCounter++;
            }
            if (rowID == 3 && rowID == 1)
            {
                forwardDiagonalCounter++;
            }
            if (rowID == 1 && rowID == 3)
            {
                forwardDiagonalCounter++;
            }
            if (rowID == 0 && rowID == 4)
            {
                forwardDiagonalCounter++;
            }
        }//End record called number method
    }
}

