/*
Nicholas Tran
1/30/2018
tug26951@temple
Bingo Game Project
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tran_CIS3309_BingoProject
{
    public partial class FrmBingo : Form
    {   
        //Initialize what is required to function
        internalCardRepWO2DArray internalCard = new internalCardRepWO2DArray();
        RNGType RNGObj = new RNGType();
        int countOfCalledNumber = 1;
        int nextCalledNumber = 0;
        char nextCalledLetter;
        char[] bingoLetters = new char[5] { 'B', 'I', 'N', 'G', 'O' };
        Player newPlayer;
        public FrmBingo()
        {
            InitializeComponent();
        }

        private const int BINGOCARDSIZE = 5;
        private const int NUMBERSPERCOLUMN = 15;
        private const int MAXBINGONUMBER = 75;

        private Button[,] newButton = new Button[BINGOCARDSIZE, BINGOCARDSIZE];

        // Total width and height of a card cell
        int cardCellWidth = 75;
        int cardCellHeight = 75;
        int barWidth = 6;  // Width or thickness of horizontal and vertical bars
        int xcardUpperLeft = /*45*/100;
        int ycardUpperLeft = 45;
        int padding = 20;


        // Creates the Bingo Card for Play
        private void createCard()
        {
            // Dynamically Creates 25 buttons on a Bingo Board 
            // Written by Bill Hall with Joe Jupin and FLF
            // This should be enough help for all of you to adapt this to your own needs
            // Create and  Add the buttons to the form

            Size size = new Size(75, 75);
            // if (gameCount > 0) size = new Size(40,40);
            Point loc = new Point(0, 0);
            int topMargin = 60;

            int x;
            int y;

            // Draw Column indexes
            y = 0;
            DrawColumnLabels();

            x = xcardUpperLeft;
            y = ycardUpperLeft;

            // Draw top line for card
            drawHorizBar(x, y, BINGOCARDSIZE);
            y = y + barWidth;

            // The board is treated like a 5x5 array
            drawVertBar(x, y);
            for (int row = 0; row < BINGOCARDSIZE; row++)
            {
                loc.Y = topMargin + row * (size.Height + padding);
                int extraLeftPadding = 50;
                for (int col = 0; col < BINGOCARDSIZE; col++)
                {
                    newButton[row, col] = new Button();
                    newButton[row, col].Location = new Point(extraLeftPadding + col * (size.Width + padding) + barWidth + 53, loc.Y - 4);
                    newButton[row, col].Size = size;
                    newButton[row, col].Font = new Font("Arial", 24, FontStyle.Bold);

                    if (row == BINGOCARDSIZE / 2 && col == BINGOCARDSIZE / 2)
                    {
                        newButton[row, col].Font = new Font("Arial", 10, FontStyle.Bold);
                        newButton[row, col].Text = "Free \n Space";
                        newButton[row, col].BackColor = System.Drawing.Color.Orange;
                        newButton[row, col].Enabled = false;

                    }
                    else
                    {
                        newButton[row, col].Enabled = true;
                        newButton[row, col].Font = new Font("Arial", 24, FontStyle.Bold);
                        newButton[row, col].Text = RNGObj.getRandomValue(bingoLetters[col]).ToString();
                    }  // end if    
                    //newButton[row, col].Enabled = true;
                    newButton[row, col].Name = "btn" + row.ToString() + col.ToString();

                    // Associates the same event handler with each of the buttons generated
                    newButton[row, col].Click += new EventHandler(Button_Click);

                    // Add button to the form
                    pnlCard.Controls.Add(newButton[row, col]);

                    // Draw vertical delimiter                 
                    x += cardCellWidth + padding;
                    if (row == 0) drawVertBar(x - 5, y);
                } // end for col
                // One row now complete

                // Draw bottom square delimiter if square complete
                x = xcardUpperLeft - 20;
                y = y + cardCellHeight + padding;
                drawHorizBar(x + 25, y - 10, BINGOCARDSIZE - 10);
            } // end for row

            // Draw column indices at bottom of card
            y += barWidth - 1;
            DrawColumnLabels();
            Globals.selectedNumbersListObj.reset();
        } // end createBoard



        // Draws column indexes at top and bottom of card
        private void DrawColumnLabels()
        {
            Label lblColID = new Label();
            lblColID.Font = new System.Drawing.Font("Microsoft Sans Serif", (float)24.0, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblColID.ForeColor = System.Drawing.Color.Orange;
            lblColID.Location = new System.Drawing.Point(cardCellWidth + 60, 0);
            lblColID.Name = "lblColIDBINGO";
            lblColID.Size = new System.Drawing.Size(488, 32);
            lblColID.TabIndex = 0;
            lblColID.Text = "B       I        N       G       O";
            pnlCard.Controls.Add(lblColID);
            lblColID.Visible = true;
            lblColID.CreateControl();
            lblColID.Show();


        } // end drawColumnLabels



        // Draw the dark horizontal bar
        private void drawHorizBar(int x, int y, int cardSize)
        {
            int currentx;
            currentx = x;

            Label lblHorizBar = new Label();
            lblHorizBar.BackColor = System.Drawing.SystemColors.ControlText;
            lblHorizBar.Location = new System.Drawing.Point(currentx, y);
            lblHorizBar.Name = "lblHorizBar";
            lblHorizBar.Size = new System.Drawing.Size((cardCellWidth + padding - 1) * BINGOCARDSIZE, barWidth);
            lblHorizBar.TabIndex = 20;
            pnlCard.Controls.Add(lblHorizBar);
            lblHorizBar.Visible = true;
            lblHorizBar.CreateControl();
            lblHorizBar.Show();
            currentx = currentx + cardCellWidth;
        } // end drawHorizBar



        // Draw dark vertical bar
        private void drawVertBar(int x, int y)
        {
            Label lblVertBar = new Label();
            lblVertBar.BackColor = System.Drawing.SystemColors.ControlText;
            lblVertBar.Location = new System.Drawing.Point(x, y);
            lblVertBar.Name = "lblVertBar" + x.ToString();
            lblVertBar.Size = new System.Drawing.Size(barWidth, (cardCellHeight + padding - 1) * BINGOCARDSIZE);
            lblVertBar.TabIndex = 19;
            pnlCard.Controls.Add(lblVertBar);
            lblVertBar.Visible = true;
            lblVertBar.CreateControl();
            lblVertBar.Show();
        }  // end drawVertBar



        // This is the handler for all Bingo Card Buttons
        // It uses sender argument to determine which Bingo Card button was selected
        // The argument is of type object and must be converted to type button in
        //    order to change its properties
        private void Button_Click(object sender, EventArgs e)
        {
            btnDontHave.Focus();
            //int bingoCount2D;
            int bingoCountWO2D; int selectedNumber;  // number randomly selected

            int rowID = convertCharToInt(((Button)sender).Name[3]);
            int colID = convertCharToInt(((Button)sender).Name[4]);
            MessageBox.Show("Cell[" + rowID + "," + colID + "] has been selected!");
            int cellID = rowID * 3 + colID;

            // Double check that clicked on button value matches called value
            selectedNumber = Convert.ToInt32(newButton[rowID, colID].Text);
            if (selectedNumber == nextCalledNumber)
            {
                newButton[rowID, colID].BackColor = System.Drawing.Color.Orange;
                //internalCardRep2DArray.recordCalledNumber(rowID, colID);
                internalCard.recordCalledNumber(rowID, colID);
                Globals.selectedNumbersListObj.setUsedNumber(selectedNumber);

                // Check for winner
                // Go here if player found the number called in his or her card
                // Check for winner for either internal representation
                //bingoCount2D = internalCardRep2DArray.isWinner(rowID, colID);
                bingoCountWO2D = internalCard.isWinner(rowID, colID);
                if ((/*bingoCount2D > 0) && (*/bingoCountWO2D > 0))
                {
                    MessageBox.Show("Congratulations " + newPlayer.getName() + ". " + "You are a Winner!!", "Winner Found! \n"
                        + "Bingos count = " + (/*bingoCount2D*/ +bingoCountWO2D) + ". Game over!");
                    Close();
                }  // end inner if

                playTheGame();
            }
            else
            {
                btnDontHave.Focus();
                MessageBox.Show("Called number does not match the one in the box you selected."
                          + "Try again!", "Numbers Do Not Match");
            } // end outer if
        } // end button clickhandler 

        //Method that handles converting char type to int type
        private int convertCharToInt(char c)
        {
            return ((int)(c) - (int)('0'));
        }//End convert to char method

        //This method generates the next number and outputs into the txt box for next called number, also checks for game over if all numbers are called
        void playTheGame()
        {   //Checks if numbers still to call and generates the next number, outputs to txt box for called number
            if (countOfCalledNumber < MAXBINGONUMBER)
            {
                countOfCalledNumber++;
                nextCalledNumber = RNGObj.getNextUniqueRandomValue(1, MAXBINGONUMBER);
                nextCalledLetter = bingoLetters[(nextCalledNumber - 1) / NUMBERSPERCOLUMN];
                txtNumbersCalled.Text = nextCalledLetter + " " + nextCalledNumber.ToString();
            }
            else
            {   //Used all numbers, game over
                MessageBox.Show("All bingo numbers called. \nYou must have missed one or more. \nGame over.");
                Close();
            }
        }//End play the game method

        //btnGo event handler will create the external board for the user to see and call the playTheGame method
        private void btnGo_Click(object sender, EventArgs e)
        {
            createCard();
            playTheGame();
            btnGo.Enabled = false;
            btnDontHave.Visible = true;
            txtNumbersCalled.Visible = true;
            pnlCard.Visible = true;
            lblYourBingoCard.Enabled = true;
            lblYourBingoCard.Visible = true;
            btnDontHave.Focus();
        }//End go button event handler

        //btnDontHave event handler will call the playTheGame method
        private void btnDontHave_Click(object sender, EventArgs e)
        {
            playTheGame();
            btnDontHave.Focus();

        }//End dont have button event handler

        //btnName event handler will validate the users name before instantiating the object initialized earlier in the form with a parameterized constructor that takes a string for name
        private void btnName_Click(object sender, EventArgs e)
        {   //Validation for null or whitespace/blank
            if (!string.IsNullOrWhiteSpace(txtName.Text))
            {   //instantiate the player object to reference variable newPlayer with parameters for name in parameterized constructor
                newPlayer = new Player(txtName.Text);
                //Enables the controls, labels, textbox, and panel as well making them visible via attribute change
                lblReady.Enabled = true;
                lblReady.Visible = true;
                btnGo.Enabled = true;
                btnGo.Visible = true;
                btnDontHave.Enabled = true;
                pnlCard.Enabled = true;
                lblRules.Enabled = true;
                lblRules.Visible = true;
                //Disable name input
                txtName.Enabled = false;
                btnName.Enabled = false;
                MessageBox.Show("Welcome " + newPlayer.getName() + "!\nRefer to the rules if you are not sure how to play bingo.\nPress Lets Go to begin.");
            }
            else
            {   //Validation failure on name input
                MessageBox.Show("Invalid Name. Try Again.");
                return;
            }
        }//End Name button event handler

        //btnExit event handler will close the game if the button is pressed or esc is hit
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }//End exit button event handler
    }
}
