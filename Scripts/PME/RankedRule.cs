using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.PME
{
    class RankedRule
    {
        private RuleObject Rule;
        private int RuleRank;

        public int GetRank()
        {
            return RuleRank;
        }

        public RankedRule(RuleObject rule)
        {
            Rule = rule;
            IEnumerable<FactObject> result = rule.Facts.OrderBy(FactList => FactList.Context);
            Rule.Facts = result.ToList();
            Rule.SetDictionary();
            RuleRank = 0;
        }

        public void RankUp()
        {
            RuleRank++;
        }

        public RuleObject GetRule()
        {
            return Rule;
        }

        public void ResetRank()
        {
            RuleRank = 0;
        }
    }
}
