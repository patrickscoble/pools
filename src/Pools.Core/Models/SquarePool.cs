using System;
using System.Collections.Generic;

namespace Pools.Core.Models
{
    public class SquarePool : Pool
    {
        private const float HEIGHT = 1.5f;

        public float Length { get; set; }

        public SquarePool(string referenceNumber, string suburb, DateTime installationDate, float length, IEnumerable<Worker> assignedWorkers)
            : base(referenceNumber, suburb, installationDate, assignedWorkers)
        {
            Length = length;
        }
    }
}
