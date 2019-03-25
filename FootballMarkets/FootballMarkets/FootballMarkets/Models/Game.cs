using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FootballMarkets.Models
{
    [Table("Games")]
    public class Game
    {
        public int Id { get; set; }
        public string HomeTeam { get; set; }
        public string AwayTeam { get; set; }
        public DateTime Date { get; set; }
        public string League { get; set; }
        
    }
}
