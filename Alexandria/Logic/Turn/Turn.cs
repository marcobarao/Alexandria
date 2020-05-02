﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alexandria.Logic.Player;

namespace Alexandria.Logic.Turn
{
    public interface ITurn
    {
        IPlayer player { get; set; }
    }

    public class Turn : ITurn
    {
        public IPlayer player { get; set; }
    }
}
