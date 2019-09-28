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
{
    //Tracks numbers used and marks used numbers 
    public class SelectedNumbersListType
    {   //boolean array is instantiated to size 75
        bool[] usedNumberArray = new bool[75];

        //Checks if number already is marked true in the usedNumberArray at that index
        public bool isNumberUsed(int selectedNumber)
        {   //If true then return true else return false
            if(usedNumberArray[selectedNumber] == true)
            {
                return true;
            }//End if statement
            else
            {
                return false;
            }//end else
        }//End is number used method

        //Resets the array of booleans
        public void reset()
        {
            for(int i = 0; i< usedNumberArray.Length; i++)
            {
                usedNumberArray[i] = false;
            }
        }//End reset method

        //After validation this method will set the number called to true
        public void setUsedNumber(int num)
        {
            usedNumberArray[num] = true;
        }//End set used number method
    }
}
