﻿using System.Diagnostics;

namespace Object_Classes
{
    /// <summary>
    /// Models a game board for Space Race consisting of three different types of squares
    /// 
    /// Ordinary squares, Wormhole squares and Blackhole squares.
    /// 
    /// landing on a Wormhole or Blackhole square at the end of a player's move 
    /// results in the player moving to another square
    /// 
    /// </summary>
    public static class Board
    {
        /// <summary>
        /// Models a game board for Space Race consisting of three different types of squares
        /// 
        /// Ordinary squares, Wormhole squares and Blackhole squares.
        /// 
        /// landing on a Wormhole or Blackhole square at the end of a player's move 
        /// results in the player moving to another square
        /// 
        /// 
        /// </summary>

        public const int NUMBER_OF_SQUARES = 56;
        public const int START_SQUARE_NUMBER = 0;
        public const int FINISH_SQUARE_NUMBER = NUMBER_OF_SQUARES - 1;

        private static Square[] squares = new Square[NUMBER_OF_SQUARES];

        public static Square[] Squares
        {
            get
            {
                Debug.Assert(squares != null, "squares != null",
                   "The game board has not been instantiated");
                return squares;
            }
        }

        public static Square StartSquare
        {
            get
            {
                return squares[START_SQUARE_NUMBER];
            }
        }


        /// <summary>
        ///  Eight Wormhole squares.
        ///  
        /// Each row represents a Wormhole square number, the square to jump forward to and the amount of fuel consumed in that jump.
        /// 
        /// For example {2, 22, 10} is a Wormhole on square 2, jumping to square 22 and using 10 units of fuel
        /// 
        /// </summary>
        private static int[,] wormHoles =
        {
            {2, 22, 10},
            {3, 9, 3},
            {5, 17, 6},
            {12, 24, 6},
            {16, 47, 15},
            {29, 38, 4},
            {40, 51, 5},
            {45, 54, 4}
        };

        /// <summary>
        ///  Eight Blackhole squares.
        ///  
        /// Each row represents a Blackhole square number, the square to jump back to and the amount of fuel consumed in that jump.
        /// 
        /// For example {10, 4, 6} is a Blackhole on square 10, jumping to square 4 and using 6 units of fuel
        /// 
        /// </summary>
        private static int[,] blackHoles =
        {
            {10, 4, 6},
            {26, 8, 18},
            {30, 19, 11},
            {35,11, 24},
            {36, 34, 2},
            {49, 13, 36},
            {52, 41, 11},
            {53, 42, 11}
        };


        /// <summary>
        /// Parameterless Constructor
        /// Initialises a board consisting of a mix of Ordinary Squares,
        ///     Wormhole Squares and Blackhole Squares.
        /// 
        /// Pre:  none
        /// Post: board is constructed
        /// </summary>
        public static void SetUpBoard()
        {

            // Create the 'start' square where all players will start.
            //squares[START_SQUARE_NUMBER] = new Square("Start", START_SQUARE_NUMBER);

            // Create the main part of the board, squares 1 .. 54
            //  CODE NEEDS TO BE ADDED HERE

            // Creates Black hole Squares list
            for (int tempVar = 0; tempVar < ((blackHoles.Length) / 3); tempVar++)
            {
                squares[blackHoles[tempVar, 0]] = new BlackholeSquare(blackHoles[tempVar, 0].ToString(), blackHoles[tempVar, 0], blackHoles[tempVar, 1], blackHoles[tempVar, 2]);
            }

            // Creates Wormhole Squares from list
            for (int tempVar = 0; tempVar < ((wormHoles.Length) / 3); tempVar++)
            {
                squares[wormHoles[tempVar, 0]] = new WormholeSquare(wormHoles[tempVar, 0].ToString(), wormHoles[tempVar, 0], wormHoles[tempVar, 1], wormHoles[tempVar, 2]);
            }

            // Creates normal squares where there are no wormhole or black hole squares
            for (int tempVar = 0; tempVar < NUMBER_OF_SQUARES; tempVar++)
            {
                if (squares[tempVar] == null)
                {
                    squares[tempVar] = new Square(tempVar.ToString(), tempVar);
                }
            }
            //   Need to call the appropriate constructor for each square
            //       either new Square(...),  new WormholeSquare(...) or new BlackholeSquare(...)
            //

            // Create the 'finish' square.
            squares[FINISH_SQUARE_NUMBER] = new Square("Finish", FINISH_SQUARE_NUMBER);
            squares[START_SQUARE_NUMBER] = new Square("Start", START_SQUARE_NUMBER);
        } // end SetUpBoard


        public static int whatTypeOfSquare(int squareNum)
        {
            int[] playerupdate = new int[2];
            int type = -1;
            for (int i = 0; i < NUMBER_OF_SQUARES; i++)
            {
                if (squareNum == wormHoles[i, 0])
                {
                    type = 0;
                    return type;
                }
                else if (squareNum == blackHoles[i, 0])
                {
                    type = 1;
                    return type;
                }
                else
                {
                    type = 2;
                    return type;
                }
            }
            if (type == 0)
            {
                return type;
            }
            return type;
        }
    } //end class Board
}