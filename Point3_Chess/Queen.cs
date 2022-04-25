﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3_Chess
{
    class Queen : Piece
    {
        public Queen(string color, int colunm, int line) : base(color, colunm, line)
        {
            tag = "QUEEN ";
        }

        public override void Movement()
        {
            Console.WriteLine("The queen can move in all directions, any number of squares, without jumping over other pieces");
        }
    }    
}
