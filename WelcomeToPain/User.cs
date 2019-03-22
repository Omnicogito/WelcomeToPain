using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelcomeToPain
{
    public class User
    {
        public string FullName { get; set; }
        public int Introversion { get; set; }
        public int Extraversion { get; set; }
        public int Structure { get; set; }
        public int Impulsive { get; set; }
        public int Dreamer { get; set; }
        public int Realist { get; set; }
        public string Personality { get; set; }

        public User (string fullname, int introversion, int extraversion, int structure, int impulsive, int dreamer, int realist, string personality)
        {
            FullName = fullname;
            Introversion = introversion;
            Extraversion = extraversion;
            Structure = structure;
            Impulsive = impulsive;
            Dreamer = dreamer;
            Realist = realist;
            Personality = personality;
        }
    }
}
