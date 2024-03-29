﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3_Chess
{
    class Player
    {
        private string name;
        private int score;
        private float gamesWon;
        //Color de las piezas {true} = White || {false} = Black
        private bool color;

        public string Name { get => name; set => name = value; }
        public int Score { get => score; set => score = value; }
        public float GamesWon { get => gamesWon; set => gamesWon = value; }
        public bool Color { get => color; set => color = value; }

        public Player(string name)
        {
            this.Name = name;
            Score = 0;
            GamesWon = 0;
        }

        public void Show()
        {
            Console.WriteLine("\tPlayer name:\t" + Name);
            Console.WriteLine("\tScore:\t\t" + Score);
            Console.WriteLine("\tGames Won:\t" + GamesWon);
            Console.WriteLine();
        }

        public void SaveScore()
        {
            Score = Score + 100;
            GamesWon = GamesWon + 1;
            Console.WriteLine("\n\tUpdate\n\tPlayer name:\t" + Name);
            Console.WriteLine("\tNew Score:\t" + Score);
            Console.WriteLine("\tGames Won:\t" + GamesWon);
        }

    }
}
