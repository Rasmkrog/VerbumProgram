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
        private string txt = "";

        public string isRegular(string input, string mode, int time)
        {
            this.Mode = mode;
            this.Input = input;
            this.Time = time;

            //if time == present (dativ)  - converter til dativ - ellers bøj som infinitiv verbum

            String path = @"RegularVerbs.txt";

            /*using (StreamWriter sw =
                new StreamWriter(path, append: true, System.Text.Encoding.GetEncoding("iso-8859-1")))
                {
                sw.WriteLine("Hej");
                }*/
            
            for (int i = 0; i <= 50; i++)
            {
                using (StreamReader sr = new StreamReader(path, System.Text.Encoding.GetEncoding("iso-8859-1")))
                {
                    txt = sr.ReadLine();
                    
                    if (Verb == txt)
                    {
                        switch (Mode)
                        {
                            case "I":
                            {
                                Verb = $"{Input}";
                                break;
                            }
                            case "You":
                            {
                                Verb = $"{Input}";
                                break;
                            }
                            case "He/She/It":
                            {
                                Verb = $"{Input}s";
                                break;
                            }
                            case "We":
                            {
                                Verb = $"{Input}";
                                break;
                            }
                            case "They":
                            {
                                Verb = $"{Input}";
                                break;
                            }
                        }
                        Console.Write("Verbwasfound");
                        break;
                    }

                    txt = "";
                }
            }

            Verb = "Test";
            return Verb;
        }
    }
}
