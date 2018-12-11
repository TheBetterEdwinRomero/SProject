using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.PME
{

    public interface IFact
    {
        string Context { get; }
        string VarientValue { get; }
        int TimesRepeated { get; set; }
        bool Repeatable { get; set; }
    }
}





