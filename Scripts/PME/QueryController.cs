using System;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System.Text.RegularExpressions;
//Rule data interaction
namespace Assets.Scripts.PME
{
    /// <summary>
    /// This is where objects build queries in-game using existing Rules
    /// </summary>

    public class QueryController
    {

      
        //A gameobject that collects scene data can be initialized
        //Assigns a list of gameobjects that can speak
        private List<RankedRule> Rules;
        private string pattern = @"\s*(([<>=])\s*(\d+)\s*)+(&*)\s*";

        public QueryController(RuleList list)
        {
            Rules = new List<RankedRule>();
            for (int i = 0; i < list.Rules.Count; i++)
            {
                Rules.Add(new RankedRule(list.Rules[i]));
            }

        }

        public string Speak(ResponseQuery response)
        {
            /*
            used to run query after being built.
            Gather all relevent info on current gameobject
            create queryobj
            add facts to query
            compare facts of query object to list of facts from every rule object
            return ruleobject with closest match to given fact list
            access  ruleobject response string
            */
            RankedRule closestmatch = Rules[0];
            bool Worked = false;
            for (int i = 0; i < Rules.Count(); i++)
            {
                foreach (var fact in response.GetFacts().Keys)
                {
                    IFact rulelis = Rules[i].GetRule().GetFacts()[fact];
                    var obersvation = response.GetFacts()[fact];
                    Worked = ParseRangeString(obersvation, rulelis);
                    if (Worked || rulelis.VarientValue == obersvation)
                    {
                        Rules[i].RankUp();

                    }

                }                
            }

            for (int i = 0; i < Rules.Count; i++)
            {
                if (Rules[i].GetRank() > closestmatch.GetRank())
                {
                    closestmatch = Rules[i];
                }

            }

            for (int i = 0; i < Rules.Count; i++)
            {
                Rules[i].ResetRank();
            }



            string dialogue = closestmatch.GetRule().Response;

            return dialogue;
        }

        
        /*
         * Takes in a string,
         * parses
         * performs a value comparison         
        */
        private bool ParseRangeString(string varient, IFact fobj)
        {
            string rangestring = fobj.VarientValue;
            bool isvalid = false;
            float value;
            float firstargument = 0;
            float secondargument = 0;
            float.TryParse(varient, out value);

            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(rangestring);
            if (matches.Count > 1)
            {                
                float.TryParse(matches[0].Groups[3].Value, out firstargument);
                float.TryParse(matches[1].Groups[3].Value, out secondargument);
                    string firstop = matches[0].Groups[2].Value;
                    string secondop = matches[1].Groups[2].Value;
                    isvalid = ParseCompare(firstop, value, firstargument) && ParseCompare(secondop,value,secondargument);
                

            } else if (matches.Count == 1)
            {
                float.TryParse(matches[0].Groups[3].Value, out firstargument);
                string op = matches[0].Groups[2].Value;
                    isvalid = ParseCompare(op, value, firstargument);
            }                        
                return isvalid;
        }

        private bool ParseCompare(string oparation, float left, float right)
        {
            bool isvalid = false;

            switch (oparation)
            {
                case "<":
                    isvalid = left < right;
                    break;
                case ">":
                    isvalid = left > right;
                    break;
                case "=":
                    isvalid = left == right;
                    break;
                default:
                    break;
            }

            return isvalid;
        }
    }
    
}

/*
Add a variable to create memory
Allow the user to define their own keywords for comparisons
     
*/