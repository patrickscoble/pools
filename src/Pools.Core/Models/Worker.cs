namespace Pools.Core.Models
{
    public class Worker
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public decimal HourlyRate { get; set; }

        public Worker(string firstName, string lastName, decimal hourlyRate)
        {
            FirstName = firstName;
            LastName = lastName;
            HourlyRate = hourlyRate;
        }
    }
}
