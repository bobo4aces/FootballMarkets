using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FootballMarkets.Models
{
    [Table("ExactScore")]
    public class ExactScore
    {
        public int Id { get; set; }

        public string Score { get; set; }
        public decimal Odds { get; set; }

        public int GameId { get; set; }

        [ForeignKey(nameof(GameId))]
        public Game Game { get; set; }
    }
}
