﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conjugation_of_Verbs
{
    class Program
    {
        //Main program


        //skal vi implementere present og dativ?
        //tænker godt det er muligt at få dativ med.
        
        private string OutputVerb;
        private int time = 0;
        Regular_verbs Regular = new Regular_verbs();
        
        public string Verb(string input, string mode)
        {
            
            OutputVerb = Regular.isRegular(input, mode, time);

            return $"{OutputVerb}";

        }
    }
}
