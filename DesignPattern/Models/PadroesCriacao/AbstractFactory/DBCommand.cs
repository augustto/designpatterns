﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    public abstract class DBCommand
    {
        public abstract bool Execute();
    }
}
