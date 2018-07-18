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
    public class RuleObject : ScriptableObject
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
        public FactObject[] Facts;
        public string Response;

        public RuleObject(FactObject[] facts, System.Object value)
        {
            this.Facts = facts;
            FactCount = facts.Length;
        }

        public override string ToString()
        {
            return base.ToString();
        }


    }
}
