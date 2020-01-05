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
        private readonly ILogger _logger;
        private readonly IPolicySource _policySource;
        private readonly IPolicySerializer _policySerializer;
        private readonly RaterFactory _raterFactory;

        public decimal Rating { get; set; }

        public RatingEngine(ILogger logger,
            IPolicySource policySource,
            IPolicySerializer policySerializer,
            RaterFactory raterFactory)
        {
            _logger = logger;
            _policySource = policySource;
            _policySerializer = policySerializer;
            _raterFactory = raterFactory;
        }

        public void Rate()
        {
            _logger.Log("Starting rate.");

            _logger.Log("Loading policy.");

            string policyJson = _policySource.GetPolicyFromSource();

            var policy = _policySerializer.GetPolicyFromString(policyJson);

            var rater = _raterFactory.Create(policy);

            Rating = rater.Rate(policy);

            _logger.Log("Rating completed.");
        }
    }
}
