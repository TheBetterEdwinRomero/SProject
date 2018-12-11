using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.PME
{
    public class ResponseQuery
    {
       
        //private List< FactObject> FactList;
        private Dictionary<string, string> FactDict;
        public ResponseQuery()
        {
            //FactList = new List<FactObject>();
            FactDict = new Dictionary<string, string>();
        }

        public Dictionary<string, string> GetFacts()
        {
            return FactDict;
        }
        
        public void Add(string first, string second)
        {
            FactDict.Add(first, second);
        }
    }
}
