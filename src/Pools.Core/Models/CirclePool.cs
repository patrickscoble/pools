using System;
using System.Collections.Generic;

namespace Pools.Core.Models
{
    public class CirclePool : Pool
    {
        private const float HEIGHT = 1.5f;

        public float Diameter { get; set; }

        public CirclePool(string referenceNumber, string suburb, DateTime installationDate, float diameter, IEnumerable<Worker> assignedWorkers)
            : base(referenceNumber, suburb, installationDate, assignedWorkers)
        {
            Diameter = diameter;
        }
    }
}
