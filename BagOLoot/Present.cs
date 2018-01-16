using System;
using System.Collections.Generic;

namespace BagOLoot
{
    public class Present
    {
        public string Name { get; set; }
        public Child Child { get; set; }
        public bool Delivered {get; set;} = false;
    }
}