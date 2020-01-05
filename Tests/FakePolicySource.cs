using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolidPrinciples;

namespace Tests
{
    public class FakePolicySource : IPolicySource
    {
        public string PolicyString { get; set; }
        public string GetPolicyFromSource()
        {
            return PolicyString;
        }
    }
}
