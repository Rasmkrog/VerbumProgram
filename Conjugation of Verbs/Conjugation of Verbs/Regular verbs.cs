using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conjugation_of_Verbs
{
    class Regular_verbs
    {
        //Hvis Input ikke findes i "Irregular_verbs" skal koden her køres for at få det bøjet.
        //kan indtil vidre bøje i present/infinitiv form.
        //Skal den også kunne bøje i dativ?

        private string Input;
        private string Mode;
        private string Verb;
        private int Time;
        private string txt;
        private string[] VerbsArryInfinitiv;
        private string[] VerbsArryDativ;


        public string isRegular(string input, string mode, int time)
        {
            this.Mode = mode;
            this.Input = input;
            this.Time = time;
            

            String path1 = @"RegularVerbsInfinitiv.txt"; //infinitiv form
            String path2 = @"RegularVerbsDativ.txt"; //Dativ form

            using (StreamReader sr = new StreamReader(path1, System.Text.Encoding.GetEncoding("iso-8859-1")))
            {
                txt = sr.ReadLine();
                VerbsArryInfinitiv = txt.Split(',');
            }

            using (StreamReader sr = new StreamReader(path2, System.Text.Encoding.GetEncoding("iso-8859-1")))
            {
                txt = sr.ReadLine();
                VerbsArryDativ = txt.Split(',');
            }
            
            
            for (int i = 0; i < VerbsArryInfinitiv.Length; i++)
            {
                if (Input == VerbsArryInfinitiv[i].ToLower())
                {
                    if (Time == 0)
                    {
                        if (Mode == "He/She/It")
                        {
                            Verb = $"{Input}s";
                            
                        }
                        else
                        {
                            Verb = Input;
                            
                        }
                        break;
                    }
                    else
                    {
                        Verb = VerbsArryDativ[i];
                        
                    }
                    break;
                }
                else
                {
                    Verb = "Error";
                }
            }
            return Verb;
        }
    }
}

//For at skrive i filen:
/*using (StreamWriter sw =
new StreamWriter(path, append: true, System.Text.Encoding.GetEncoding("iso-8859-1")))
{
sw.WriteLine("Hej");
}*/
