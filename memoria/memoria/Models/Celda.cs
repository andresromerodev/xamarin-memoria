﻿using System;
using System.Collections.Generic;
using System.Text;

namespace memoria.Models
{
    class Celda
    {
        string caracter { get; set; }
        int estado { get; set; } // oculta, visible o fijada

        public readonly static int OCULTA = 0;
        public readonly static int VISIBLE = 1;
        public readonly static int TEMPORAL = 2;
        public readonly static int FIJA = 3;
    }
}