using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples
{
    public class RatingUpdater : IRatingUpdater
    {
        private readonly RatingEngine _engine;

        public RatingUpdater(RatingEngine engine)
        {
            _engine = engine;
        }

        public void UpdateRating(decimal rating)
        {
            _engine.Rating = rating;
        }
    }
}
