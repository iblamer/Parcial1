﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parcial1
{
    class Utilidades
    {
        public static int StringToInt(string s)
        {
            int n = 0;

            int.TryParse(s, out n);

            return n;
        }
    }
}
