using System;
using System.Collections.Generic;

namespace Pools.Core.Models
{
    public class Pool
    {
        private const float HEIGHT = 1.5f;

        public string ReferenceNumber { get; set; }

        public string Suburb { get; set; }

        public DateTime InstallationDate { get; set; }

        public IEnumerable<Worker> AssignedWorkers { get; set; }

        public Pool(string referenceNumber, string suburb, DateTime installationDate, IEnumerable<Worker> assignedWorkers)
        {
            ReferenceNumber = referenceNumber;
            Suburb = suburb;
            InstallationDate = installationDate;
            AssignedWorkers = assignedWorkers;
        }
    }
}
