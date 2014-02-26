﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystallBallGame.UI
{
    public class ExitLogo : Logo
    {
    private const int matrixRows = 3;
        private const int matrixCols = 9;
        public ExitLogo()
            : base(matrixRows, matrixCols)
        {
            this.matrix = CreateLogo();
        }

        private static char[,] CreateLogo()
        {
            return new char[matrixRows, matrixCols] {{'+','-','+','-','+','-','+','-','+'},
                                                     {'|','E','|','x','|','i','|','t','|'},
                                                     {'+','-','+','-','+','-','+','-','+'}};
        }

    }
}