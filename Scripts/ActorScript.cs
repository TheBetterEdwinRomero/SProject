using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
namespace Assets.Scripts
{
    /// <summary>
    /// A script that will demonstrate the pattern matching engine
    /// </summary>
    class ActorScript : MonoBehaviour
    {
        QueryController qc = new QueryController();

        public RuleObject rule;

        /*
        Need the rules to appear in inspector
        make scriptable object
        have it be accessable via inspector
        inspector shows list of fact objects
        can modify
        hardcode for demonstration
        */
     
        public void Start()
        {
            
        }

        public void Update()
        {
            
        }
    }
}
