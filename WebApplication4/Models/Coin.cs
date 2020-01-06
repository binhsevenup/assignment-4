using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication4.Models
{
    public class Coin
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string baseAsset { get; set; }
        public string quoteAsset { get; set; }
        public double lastPrice { get; set; }
        public double volumn24h { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
        public int marketId { get; set; }
        public CoinStatus Status { get; set; }
        public enum CoinStatus
        {
            Active = 1,
            Deactive = 0,
            Delete = -1
        }
    }
}