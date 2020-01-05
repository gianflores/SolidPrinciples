using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples
{
    public class RaterFactory
    {
        public Rater Create(Policy policy, RatingEngine engine)
        {
            //switch (policy.Type)
            //{
            //    case PolicyType.Life:
            //        return new LifePolicyRater(engine, engine.Logger);
            //    case PolicyType.Flood:
            //        return new FloodPolicyRater(engine, engine.Logger);
            //    case PolicyType.Land:
            //        return new LandPolicyRater(engine, engine.Logger);
            //    case PolicyType.Auto:
            //        return new AutoPolicyRater(engine, engine.Logger);
            //    default:
            //        return new UnknownPolicyRater(engine, engine.Logger);
            //}

            try
            {
                //Get the class based on the name provided
                //Create an instance of the class and pass the constructor parameters
                //Cast it to the abstract class Rater to match the method signature
                return (Rater)Activator.CreateInstance(Type.GetType($"SolidPrinciples.{policy.Type}PolicyRater"), new object[] { engine, engine.Logger });
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
