using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FootballMarkets.Models
{
    [Table("Winner")]
    public class Winner
    {
        public int Id { get; set; }
        public decimal HomeWin { get; set; }
        public decimal Draw { get; set; }
        public decimal AwayWin { get; set; }
        
        public int GameId { get; set; }

        [ForeignKey(nameof(GameId))]
        public Game Game { get; set; }
    }
}
