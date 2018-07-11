using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts
{

    /// <summary>
    /// This is used for creating and providing collections of Facts
    /// </summary>
    class FactController
    {
        public List<FactObject> FactList;

        public FactController()
        {
            FactList = new List<FactObject>();  
        }
         
        public void CreateFactList()
        {
            FactList = new List<FactObject>();
        }
        
    }
}
