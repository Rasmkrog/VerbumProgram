using System;
using System.Collections.Generic;
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

        string Input;
        string Mode; 
        private string Verb;
        public string isRegular(string input, string mode)
        {
            this.Mode = mode;
            this.Input = input;
            switch (Mode)
            {
                case "I":
                {
                    Verb = $"{input}";
                    break;
                }
                case "You":
                {
                    Verb = $"{input}";
                    break;
                }
                case "He/She/It":
                {
                    Verb = $"{input}s";
                    break;
                }
                case "We":
                {
                    Verb = $"{input}";
                    break;
                }
                case "They":
                {
                    Verb = $"{input}";
                    break;
                }
            }
            return Verb;
        }
    }
}
