﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoLFA.Classes
{
    public class Follow
    {
        public string character { get; set; }
        public bool isAcceptanceStatus { get; set; }
        public List<int> follows { get; set; }

        public Follow(string character)
        {
            this.character = character;
            isAcceptanceStatus = character == CharSET.EndCharacter;
            follows = new List<int>();
        }
    }
}
