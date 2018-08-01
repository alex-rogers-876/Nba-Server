using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Nba.Core.CustomWebClient;
using Newtonsoft.Json.Linq;
using Nba.Core.Models;

namespace NbaRest.Controllers
{
    [Produces("application/json")]
    [Route("api/Players")]
    public class PlayersController : Controller
    {
        private readonly ICustomWebClient _customWebClient;
        public PlayersController(ICustomWebClient customWebClient)
        {
            _customWebClient = customWebClient;

        }
        // GET: api/Players/5
        [HttpGet("{id}", Name = "GetId")]
        public IActionResult Get(int id)
        {

            string url = "http://stats.nba.com/stats/commonteamroster?LeagueID=00&Season=2017-18&TeamID=" + id;
            try
            {
                var players = new List<Player>();
            //Add your user agent of choice. This is mine, just as an example.

                var response = _customWebClient.GetResponse(url);
                var releases = JObject.Parse(response);
                var test = releases["resultSets"][0]["rowSet"].Children();
                foreach(var playerLinq in test)
                {
                    players.Add(new Player {
                        TeamID = (int)playerLinq[0],
                        SEASON = playerLinq[1].ToString(),
                        LeagueID = playerLinq[2].ToString(),
                        PLAYER = playerLinq[3].ToString(),
                        NUM = playerLinq[4].ToString(),
                        POSITION = playerLinq[5].ToString(),
                        HEIGHT = playerLinq[6].ToString(),
                        WEIGHT = playerLinq[7].ToString(),
                        birth_date = playerLinq[8].ToString(),
                        AGE = (decimal) playerLinq[9],
                        EXP = playerLinq[10].ToString(),
                        SCHOOL = playerLinq[11].ToString(),
                        player_id = (int)playerLinq[12],
                        photoUrl = ""


                    });
                }
                return Ok(players.ToArray());
            }
            catch (Exception e)
            {

                throw;
            }
            
        }
        
    
    }
}
