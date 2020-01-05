﻿using SolidPrinciples;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests
{
    public class FakeRatingUpdater : IRatingUpdater
    {
        public decimal? NewRating { get; private set; }
        public void UpdateRating(decimal rating)
        {
            NewRating = rating;
        }
    }
}
