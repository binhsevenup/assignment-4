using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication4.Models
{
    public class Market
    {
       
            [Key]
            public int Id { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public DateTime createdAt { get; set; }
            public DateTime deleteddAt { get; set; }
            public MarketStatus status { get; set; }

            public virtual ICollection<Coin> Coins { get; set; }
            public enum MarketStatus
            {
                Active = 1,
                Deactive = 0,
                Delete = -1
            }
    }

       
}