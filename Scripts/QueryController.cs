using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts
{
    /// <summary>
    /// This is where objects build queries in game
    /// </summary>
    public class QueryController : MonoBehaviour
    {
        public Dictionary<FactObject[], string> RuleList;

        private FactController fc;

        public QueryController()
        {
            Dictionary<FactObject[], string> RuleList = new Dictionary<FactObject[], string>();
            fc = new FactController();

        }


        public void CreateRule(string varient)
        {
            RuleList.Add(fc.FactList.ToArray(), varient);
        }
        

        public void AddFact(string key, string value)
        {
            fc.FactList.Add(new FactObject(key, value));
        }

        public void GetQueryResult()
        {
            /*
             used to run query after being built.
             */
        }

        
    }
}
