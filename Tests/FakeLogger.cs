using SolidPrinciples;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests
{
    public class FakeLogger : ILogger
    {
        public List<string> LoggedMessages { get; } = new List<string>();
        public void Log(string message)
        {
            LoggedMessages.Add(message);
        }
    }
}
