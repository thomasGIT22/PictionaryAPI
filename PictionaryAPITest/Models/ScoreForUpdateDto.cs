using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PictionaryAPITest.Models
{
    public class ScoreForUpdateDto
    {
        [Required(ErrorMessage = "You should provide a score.")]
        public int Score { get; set; }
    }
}
