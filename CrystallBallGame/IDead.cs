﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CrystallBallGame
{
    public interface IDead
    {
        bool IsDead { get; }

        int HitPoints
        {
            get;
            set;
        }

    }
}
