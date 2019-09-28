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
{   //This class creates and stores player objects with attribute name, getter for name, and two constructors, one default and one parameterized
    public class Player
    {   //Attribute for player class
        String name = "";
        //Default constructor
        public Player()
        {

        }//End default player constructor

        //Parameterized constructor
        public Player(String input)
        {
            name = input;
        }//End parameterized player constructor

        //Getter for name attribute
        public string getName()
        {
            return name;
        }//End get name method

        //Getter and setter for name attribute/Alternative method (Not preferred)
        /*public String Name
        {
            get
            {
                return this.name;
            }
            set
            {
                name = value;
            }
        }//End get and set name method*/

        //Getter and setter for name attribute/Alternative method (Not preferred)
        /*public String Name 
        { 
           get; 
           set; 
        }//End get and set name method*/
    }

}
