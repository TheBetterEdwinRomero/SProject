using System;
using System.Collections.Generic;


namespace Assets.Scripts.PME
{
    /// <summary>
    /// Used to build a rule based query
    /// Takes in facts
    /// This object uses collections of facts as a key and a user made
    /// string as the value.
    /// </summary>
    /// 
    [Serializable]
    public class RuleObject
    {
        
        public string Response;
        public List<FactObject> Facts;
        private Dictionary<string, IFact> FactDict;

        public RuleObject(List<FactObject> facts, System.Object value )
        {
            for (int i = 0; i < facts.Count; i++)
            {
                Facts.Add(facts[i]);
            }
            
        }

        unsafe public void SetDictionary()
        {
            FactDict = new Dictionary<string, IFact>();
            for (int i = 0; i < Facts.Count; i++)
            {
                
                FactDict.Add(Facts[i].Context, Facts[i]);
            }
        }

        public Dictionary<string,IFact>GetFacts()
        {
            return FactDict;
        }
    }
}
