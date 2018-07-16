using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NbaRest.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using Nba.Core.CustomWebClient;
namespace NbaRest.Controllers
{
    [Produces("application/json")]
    [Route("api/NbaStats")]

    public class NbaStatsController : Controller
    {
        private readonly ICustomWebClient _customWebClient;
        public NbaStatsController(ICustomWebClient customWebClient)
        {
            _customWebClient = customWebClient;

        }
        // GET: api/NbaStats
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/NbaStats/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            try
            {
                var stats = new List<Stats>();
                //Add your user agent of choice. This is mine, just as an example.
                var response = _customWebClient.GetResponse("https://stats.nba.com/stats/playerprofilev2?LeagueID=00&PerMode=PerGame&PlayerID=" + id);
                var releases = JObject.Parse(response);
                var test = releases["resultSets"][0]["rowSet"].Children();
                foreach (var playerLinq in test)
                {
                    stats.Add(new Stats
                    {
                        Player_id = (int)playerLinq[0],
                        Season_id = playerLinq[1].ToString(),
                        League_id = playerLinq[2].ToString(),
                        Team_id = (int)playerLinq[3],
                        Team_abbreviation = playerLinq[4].ToString(),
                        Player_age = (int)playerLinq[5],
                        Gp = (int)playerLinq[6],
                        Gs = (int)playerLinq[7],
                        Min = (int)playerLinq[8],
                        Fgm = (decimal)playerLinq[9],
                        Fga = (decimal)playerLinq[10],
                        Fg_pct = (decimal)playerLinq[11],
                        Fg3m = (decimal)playerLinq[12],
                        Fg3a = (int)playerLinq[13],
                        Fg3_pct = (decimal) playerLinq[14],
                        Ftm = (decimal) playerLinq[15],
                        Fta = (decimal) playerLinq[16],
                        Ft_pct = (decimal) playerLinq[17],
                        Oreb = (decimal) playerLinq[18],
                        Dreb = (decimal) playerLinq[19],
                        Reb = (decimal) playerLinq[20],
                        Ast = (decimal) playerLinq[21],
                        Stl = (decimal) playerLinq[22],
                        Blk = (decimal) playerLinq[23],
                        Tov = (decimal)playerLinq[24],
                        Pf = (decimal)playerLinq[25],
                        Pts = (decimal) playerLinq[26]
                    });
                }
                return Ok(stats.ToArray());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return Ok("value");
        }

        // POST: api/NbaStats
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/NbaStats/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
