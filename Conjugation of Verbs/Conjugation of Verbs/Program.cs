using System;
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
        private int time = 1;
        Regular_verbs Regular = new Regular_verbs();
        Irregular_verbs Irregular = new Irregular_verbs();
        public void Time(int Time)
        {
            this.time = Time;
        }
        
        public string Verb(string input, string mode)
        {
            if ((OutputVerb = Irregular.isIrrgular(input, mode, time)) == "Error")
            {
                if ((OutputVerb = Regular.isRegular(input, mode, time)) == "Error")
                {
                    //call methode wronge verb
                }
            }

            return $"{OutputVerb}";

        }
    }
}
