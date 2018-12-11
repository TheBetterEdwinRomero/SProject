using System.Collections.Generic;

namespace Assets.Scripts.PME
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
