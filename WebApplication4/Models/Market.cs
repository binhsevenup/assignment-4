using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication4.Models
{
    public class Market
    {
        [Key]
        [Required(ErrorMessage = "Vui lòng nhập mã sàn")]
        [StringLength(10, MinimumLength = 4, ErrorMessage = "Mã sàn phải khoảng từ 4 đến 10 ký tự")]
        [Display(Name = "Id")]
        public string marketId { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập tên sàn")]
        [StringLength(100, MinimumLength = 4, ErrorMessage = "Tên sàn phải khoảng từ 4 đến 10 ký tự")]
        [Display(Name = "Name")]
        public string name { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập mô tả")]
        [StringLength(100, MinimumLength = 4, ErrorMessage = "Bạn phải mô tả")]
        [Display(Name = "Description")]
        public string description { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updateAt { get; set; }
        public DateTime deletedAt { get; set; }
        public MarketStatus status { get; set; }

        public virtual ICollection<Coin> Coins { get; set; }

    }

    public enum MarketStatus
    {
        Active = 1,
        Deactive = 0,
        Delete = -1
    }


}