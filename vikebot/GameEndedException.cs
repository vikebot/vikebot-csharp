﻿using System;
using System.Diagnostics;

namespace vikebot
{
#if !DEBUG
    [DebuggerStepThrough]
#endif
    public sealed class GameEndedException : Exception
    {
        public GameEndedException(string message) : base(message)
        {
        }
    }
}