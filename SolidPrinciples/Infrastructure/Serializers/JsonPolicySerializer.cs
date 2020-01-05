using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples
{

    public class JsonPolicySerializer : IPolicySerializer
    {
        public Policy GetPolicyFromString(string policyString)
        {
            return JsonConvert.DeserializeObject<Policy>(policyString,
                new StringEnumConverter());
        }
    }
}
