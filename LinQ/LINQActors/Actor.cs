using System;
using System.Collections.Generic;
using System.Text;

namespace LINQActors
{
    class Actor
    {
        public string Name { get; set; }
        public decimal TotalGross { get; set; }
        public int MovieCount { get; set; }
        public decimal AveragePerMovie { get; set; }
        public string TopMovie { get; set; }
        public decimal TopMovieGross { get; set; }

        public override string ToString()
        {
            return "Name:" + Name +
                (TotalGross != 0 ? " Total Gross: " + TotalGross : null) +
                (MovieCount != 0 ? " MovieCount: " + MovieCount : null) +
                (AveragePerMovie != 0 ? " AveragePerMovie: " + AveragePerMovie : null) +
                (TopMovie != null ? " TopMovie: " + TopMovie : null) +
                (TopMovieGross != 0 ? " TopMovieGross: " + TopMovieGross : null) +
                "\n";

        }
    }
}
