using System;
using System.Collections.Generic;
using System.Text;

namespace Nba.Core.Models
{
    public class Player
    {
        public int TeamID { get; set; }

        public string SEASON { get; set; }
        public string LeagueID { get; set; }
        public string PLAYER { get; set; }
        public string NUM { get; set; }
        public string POSITION { get; set; }
        public string HEIGHT { get; set; }
        public string WEIGHT { get; set; }
        public string birth_date { get; set; }
        public decimal AGE { get; set; }
        public string EXP { get; set; }
        public string SCHOOL { get; set; }
        public int player_id { get; set; }
        public string photoUrl { get; set; }
    }
}
