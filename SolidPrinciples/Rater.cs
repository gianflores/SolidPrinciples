using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples
{
    public abstract class Rater
    {
        protected readonly IRatingUpdater _ratingUpdater;
        public ILogger Logger { get; set; } = new ConsoleLogger();

        public Rater(IRatingUpdater ratingUpdater)
        {
            _ratingUpdater = ratingUpdater;
        }

        public abstract void Rate(Policy policy);
    }
}
