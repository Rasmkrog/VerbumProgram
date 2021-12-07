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
        private string output;
        private string txt;
        private string[] VerbsArryInfinitiv;
        private string[] VerbsArryPast;
        String path1 = @"IregularVerbsInfinitiv.txt"; //infinitiv form
        String path2 = @"IregularVerbsImperfektum.txt"; //Dativ form
        public string isIrrgular(string input, string mode, int Time)
        {
            using (StreamReader sr = new StreamReader(path1, System.Text.Encoding.GetEncoding("iso-8859-1")))
            {
                txt = sr.ReadLine();
                VerbsArryInfinitiv = txt.Split(',');
            }

            using (StreamReader sr = new StreamReader(path2, System.Text.Encoding.GetEncoding("iso-8859-1")))
            {
                txt = sr.ReadLine();
                VerbsArryPast = txt.Split(',');
            }

            
            for (int i = 0; i < VerbsArryInfinitiv.Length; i++)
            {
                if (input == VerbsArryInfinitiv[i])
                {
                    if (Time == 0)
                    {
                        output = VerbsArryInfinitiv[i];
                        break;
                    }
                    else
                    {
                        output = VerbsArryPast[i];
                        break;
                    }
                }
                else
                {
                    output = "Error";
                }
            }
            
            return output;
        }



    }
}
