using System;
using System.Collections.Generic;
using System.Text;

namespace Tomagtachi
{
    public class pet
    {
        public string name { get; set; }
        public string type { get; set; }
        public int health { get; set; }
        public int happiness { get; set; }
        public int boredom { get; set; }
        public int hunger { get; set; }
        public int sleep { get; set; }
    }

    public class activity
    {
        public string name { get; set; }
        public int healthvaluechange { get; set; }
        public int happinessvaluechange { get; set; }
        public int boredomvaluechange { get; set; }
        public int hungervaluechange { get; set; }
        public int sleepvaluechange { get; set; }
     
    }
}
