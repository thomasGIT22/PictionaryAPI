using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PictionaryAPITest.Models;

namespace PictionaryAPITest
{
    public class ScoresDataStore
    {
        public static ScoresDataStore Current { get; } = new ScoresDataStore();
        public List<ScoresDto> Scores { get; set; }
        public ScoresDataStore()
        {
            Scores = new List<ScoresDto>()
            {
                new ScoresDto()
                {
                    Id = 0,
                    Group = "IT",
                    Score = 21,
                    Overall = true
                },
                new ScoresDto()
                {
                    Id = 1,
                    Group = "FM",
                    Score = 16,
                    Overall = true
                },
                new ScoresDto()
                {
                    Id = 2,
                    Group = "CSS",
                    Score = 6,
                    Overall = true
                },
                new ScoresDto()
                {
                    Id = 3,
                    Group = "CS",
                    Score = 7,
                    Overall = true
                },
                new ScoresDto()
                {
                    Id = 4,
                    Group = "LOG",
                    Score = 8,
                    Overall = true
                },
                new ScoresDto()
                {
                    Id = 5,
                    Group = "IT",
                    Score = 21,
                    Overall = false
                },
                new ScoresDto()
                {
                    Id = 6,
                    Group = "FM",
                    Score = 16,
                    Overall = false
                },
                new ScoresDto()
                {
                    Id = 7,
                    Group = "CSS",
                    Score = 6,
                    Overall = false
                },
                new ScoresDto()
                {
                    Id = 8,
                    Group = "CS",
                    Score = 7,
                    Overall = false
                },
                new ScoresDto()
                {
                    Id = 9,
                    Group = "LOG",
                    Score = 8,
                    Overall = false
                }
            };
        }
    }
}
