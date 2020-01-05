using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples
{
    public class RatingEngine
    {
        public IRatingContext Context { get; set; } = new DefaultRatingContext();
        public decimal Rating { get; set; }

        public RatingEngine()
        {
            Context.Engine = this;
        }

        public void Rate()
        {
            Context.Log("Starting rate.");

            Context.Log("Loading policy.");

            // load policy - open file policy.json
            string policyJson = Context.LoadPolicyFromFile();

            var policy = Context.GetPolicyFromJsonString(policyJson);
            
            var rater = Context.CreateRaterForPolicy(policy, Context);

            rater.Rate(policy);
            
            Context.Log("Rating completed.");
        }
    }
}
