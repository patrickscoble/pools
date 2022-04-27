using System;
using System.Collections.Generic;
using Pools.Core.Models;
using Pools.Core.Repositories;

namespace Pools.Data
{
    public class PoolRepository : IPoolRepository
    {
        public IEnumerable<Pool> GetAll()
        {
            List<Pool> pools = new List<Pool>()
            {
                new CirclePool(GenerateReferenceNumber(), "Ringwood", GenerateDate(), 3.25f, new List<Worker>()
                {
                    new Worker("Rama", "Fierro", 45m),
                }),
                new CirclePool(GenerateReferenceNumber(), "Cranbourne", GenerateDate(), 2.5f, new List<Worker>()
                {
                    new Worker("Celia", "Kilpatrick", 17.25m),
                }),
                new CirclePool(GenerateReferenceNumber(), "Carlton", GenerateDate(), 4.5f, new List<Worker>()
                {
                    new Worker("Nessa", "Pokorni", 34.50m),
                    new Worker("Lara", "Sokolsky", 31m),
                }),
                new CirclePool(GenerateReferenceNumber(), "Toorak", GenerateDate(), 9f, new List<Worker>()
                {
                    new Worker("Neno", "Kohut", 24m),
                    new Worker("Božo", "Plank", 19m),
                    new Worker("Ovidia", "Hadzhiev", 16m),
                }),
                new RectanglePool(GenerateReferenceNumber(), "Werribee", GenerateDate(), 3f, 3.5f, new List<Worker>()
                {
                    new Worker("August", "Utkin", 29.50m),
                }),
                new RectanglePool(GenerateReferenceNumber(), "Eltham", GenerateDate(), 6f, 4f, new List<Worker>()
                {
                    new Worker("Antonina", "Wolff", 28.75m),
                    new Worker("Antónia", "De Angelis", 23.50m),
                }),
                new RectanglePool(GenerateReferenceNumber(), "Balwyn", GenerateDate(), 2f, 8f, new List<Worker>()
                {
                    new Worker("Joachim", "Krebs", 28m),
                    new Worker("Zayden", "Paz", 50m),
                }),
                new RectanglePool(GenerateReferenceNumber(), "Footscray", GenerateDate(), 5.5f, 3.1f, new List<Worker>()
                {
                    new Worker("Carlos", "Donoghue", 41.25m),
                    new Worker("Ximun", "Lindsay", 19.75m),
                }),
                new RectanglePool(GenerateReferenceNumber(), "Ringwood", GenerateDate(), 4.2f, 4.6f, new List<Worker>()
                {
                    new Worker("Marceau", "Nixon", 31.50m),
                    new Worker("Kore", "Sierra", 36.50m),
                }),
                new SquarePool(GenerateReferenceNumber(), "Northcote", GenerateDate(), 3f, new List<Worker>()
                {
                    new Worker("Wahid", "Germain", 18m),
                }),
                new SquarePool(GenerateReferenceNumber(), "Glen Waverley", GenerateDate(), 1.5f, new List<Worker>()
                {
                    new Worker("Carmelo", "Franklyn", 24.25m),
                }),
                new SquarePool(GenerateReferenceNumber(), "Mornington", GenerateDate(), 12f, new List<Worker>()
                {
                    new Worker("Nebile", "Lovell", 15.50m),
                    new Worker("Eldar", "Ferro", 27m),
                    new Worker("Photina", "Jiménez", 27m),
                    new Worker("Nilima", "Foerstner", 40m),
                }),
                new SquarePool(GenerateReferenceNumber(), "Deer Park", GenerateDate(), 7.2f, new List<Worker>()
                {
                    new Worker("Julian", "Sowards", 21m),
                    new Worker("Merilyn", "Gajos", 18m),
                }),
                new SquarePool(GenerateReferenceNumber(), "Seaford", GenerateDate(), 4f, new List<Worker>()
                {
                    new Worker("Vegard", "Wild", 35m),
                }),
                new SquarePool(GenerateReferenceNumber(), "Malvern", GenerateDate(), 5.8f, new List<Worker>()
                {
                    new Worker("Shivani", "Vescovi", 32m),
                    new Worker("Yosef", "Finley", 14m),
                }),
            };

            return pools;
        }

        private string GenerateReferenceNumber()
        {
            // Implement the logic to return a string that starts with a random capital letter,
            // followed by a random number between 1 and 1,000,000 (eg. R100043).
        }

        private DateTime GenerateDate()
        {
            Random random = new Random();
            DateTime start = new DateTime(2022, 1, 1);
            int range = (DateTime.Today - start).Days;
            return start.AddDays(random.Next(range));
        }
    }
}
