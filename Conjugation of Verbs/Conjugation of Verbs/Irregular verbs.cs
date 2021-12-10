using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Printing;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Conjugation_of_Verbs
{
    class Irregular_verbs
    {
        private string Verb;
        private string txt;
        private string[] IregularVerbsArryInfinitiv;
        private string[] IregularVerbsArryPast;
        String path1 = @"IregularVerbsInfinitiv.txt"; //infinitiv form
        String path2 = @"IregularVerbsImperfektum.txt"; //Dativ form
        public string isIrrgular(string input, string mode, int Time)
        {
            using (StreamReader sr = new StreamReader(path1, System.Text.Encoding.GetEncoding("iso-8859-1")))
            {
                txt = sr.ReadLine();
                IregularVerbsArryInfinitiv = txt.Split(',');
            }

            using (StreamReader sr = new StreamReader(path2, System.Text.Encoding.GetEncoding("iso-8859-1")))
            {
                txt = sr.ReadLine();
                IregularVerbsArryPast = txt.Split(',');
            }

            
            for (int i = 0; i < IregularVerbsArryInfinitiv.Length; i++)
            {
                if (input == IregularVerbsArryInfinitiv[i].ToLower())
                {
                    if (Time == 0)
                    {
                        Verb = IregularVerbsArryInfinitiv[i];
                    }
                    else
                    {
                        Verb = IregularVerbsArryPast[i];
                        
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
