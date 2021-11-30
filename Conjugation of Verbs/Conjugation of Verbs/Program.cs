using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conjugation_of_Verbs
{
    class Program
    {
        private string Input;
        private string Mode;
        //Main program
        public string Verb(string input, string mode)
        {

            this.Input = input;
            this.Mode = mode;


            return $"{input}";

        }
    }
}
