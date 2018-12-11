using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts
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
        public int FactCount
        {
            get
            {
                return FactCount;
            }
            private set
            {
                FactCount = value;
            }
        }

        public string Response;
        public List<FactObject> Facts = new List<FactObject>();

        public RuleObject(List<FactObject> facts, System.Object value )
        {
            this.Facts = facts;
            FactCount = facts.Count;
        }

        public override string ToString()
        {

            return Response + " Size " + FactCount;
        }


    }
}
/*
 http://va.lent.in/unity-make-your-lists-functional-with-reorderablelist/
 */
