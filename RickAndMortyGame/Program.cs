﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RickAndMortyGame
{
    public class Program
    {
        static void Main(string[] args)
        {
            //we can do things like load saved game data here later...
            ProgramUI game = new ProgramUI();
            game.Run();
        }
    }
}
