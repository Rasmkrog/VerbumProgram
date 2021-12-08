using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.IO;

namespace Conjugation_of_Verbs
{
    class Program
    {
        
        //Main program
        
        private string OutputVerb;
        private string Input;
        private int time = 1;
        Regular_verbs Regular = new Regular_verbs();
        Irregular_verbs Irregular = new Irregular_verbs();
        private TextInfo myTI = new CultureInfo("en-us", false).TextInfo;
        String path1 = @"ErrorLog.txt";

        public void Time(int Time)
        {
            this.time = Time;
        }
        
        public string Verb(string input, string mode)
        {
            this.Input = input.ToLower(); //konverter inputet til små bogstaver
            OutputVerb = Irregular.isIrrgular(Input, mode, time);
            if (OutputVerb == "Error")
            {
                OutputVerb = Regular.isRegular(Input, mode, time);
                if (OutputVerb == "Error")
                {
                    //write input til error fill
                    using (StreamWriter sw = new StreamWriter(path1, append: true, System.Text.Encoding.GetEncoding("iso-8859-1")))
                    {
                        sw.WriteLine(Input);
                    }
                }
            }

            
            return $"{myTI.ToTitleCase(OutputVerb)}";

        }
    }
}
