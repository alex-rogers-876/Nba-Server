using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NbaRest.Models
{
    public class Stats
    {
        public int Player_id { get; set; }
        public string Season_id { get; set; }
        public string League_id { get; set; }
        public int Team_id { get; set; }
        public string Team_abbreviation { get; set; }
        public int Player_age { get; set; }
        public int Gp { get; set; }
        public int Gs { get; set; }

        public decimal Min { get; set; }
        public decimal Fgm { get; set; }
        public decimal Fga { get; set; }
        public decimal Fg_pct { get; set; }
        public decimal Fg3m { get; set; }
        public decimal Fg3a { get; set; }
        public decimal Fg3_pct { get; set; }
        public decimal Ftm { get; set; }
        public decimal Fta { get; set; }

        public decimal Ft_pct { get; set; }
        public decimal Oreb { get; set; }
        public decimal Dreb { get; set; }
        public decimal Reb { get; set; }
        public decimal Ast { get; set; }
        public decimal Stl { get; set; }
        public decimal Blk { get; set; }
        public decimal Tov { get; set; }
        public decimal Pf { get; set; }
        public decimal Pts { get; set; }
    }
}
