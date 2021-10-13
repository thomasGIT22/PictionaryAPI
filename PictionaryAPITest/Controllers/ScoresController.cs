using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PictionaryAPITest.Models;
using System.IO;
using Newtonsoft.Json;

namespace PictionaryAPITest.Controllers
{
    [ApiController]
    [Route("api/scores")]
    public class ScoresController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetScores() 
        {
            var vals = LoadJson();
            return Ok(vals);
        }
        [HttpGet("{id}")]
        public IActionResult GetScore(int id)
        {
            var scoreToReturn = LoadJson()
                .FirstOrDefault(s => s.Id == id);

            if (scoreToReturn == null)
            {
                return NotFound();
            }

            return Ok(scoreToReturn);
        }
        [HttpPut("{id}")]
        public IActionResult UpdateScore(int id, int score)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            List<ScoresDto> _scores = LoadJson();

            foreach (var item in _scores)
            {
                if (item.Id == id) 
                {
                    item.Score = score;
                }
            }

            if (_scores == null)
            {
                return NotFound();
            }

            string output = Newtonsoft.Json.JsonConvert.SerializeObject(_scores, Newtonsoft.Json.Formatting.Indented);
            System.IO.File.WriteAllText("./data/scores.json", output);

            return Ok(LoadJson());
        }

        public static ScoresDto getScore(int id) 
        {
            return ScoresDataStore.Current.Scores
                .FirstOrDefault(s => s.Id == id);
        }

        public List<ScoresDto> LoadJson()
        {
            using (StreamReader r = new StreamReader("./data/scores.json"))
            {
                string json = r.ReadToEnd();
                List<ScoresDto> scores = JsonConvert.DeserializeObject<List<ScoresDto>>(json);
                return scores;
            }
        }
    }
}
