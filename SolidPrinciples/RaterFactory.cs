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
            try
            {
                //Get the class based on the name provided
                //Create an instance of the class and pass the constructor parameters
                //Cast it to the abstract class Rater to match the method signature
                return (Rater)Activator.CreateInstance(Type.GetType($"SolidPrinciples.{policy.Type}PolicyRater"), new object[] { engine, engine.Logger });
            }
            catch (Exception)
            {
                return new UnknownPolicyRater(engine, engine.Logger);
            }
        }
    }
}
