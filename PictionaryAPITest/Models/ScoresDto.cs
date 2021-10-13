using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PictionaryAPITest.Models
{
    public class ScoresDto
    {
        public int Id { get; set; }
        public string Group { get; set; }
        public int Score { get; set; }
        public bool Overall { get; set; }
    }
}
