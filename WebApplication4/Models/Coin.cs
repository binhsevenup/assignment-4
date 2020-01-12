using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication4.Models
{
    public class Coin
    {
        [Key]
        [Required(ErrorMessage = "Vui lòng nhập mã coin.")]
        [Display(Name = "Id")]
        [StringLength(10, MinimumLength = 2, ErrorMessage = "Mã coin phải lớn hơn 2 và nhỏ hơn 10 ký tự. ")]
        public string CoinId { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập tên coin.")]
        [Display(Name = "Name")]
        [StringLength(10, MinimumLength = 2, ErrorMessage = "Tên coin phải lớn hơn 2 và nhỏ hơn 10 ký tự. ")]
        public string name { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập Base Asset.")]
        [Display(Name = "Base Asset")]
        [StringLength(10, MinimumLength = 2, ErrorMessage = "Base Asset phải lớn hơn 2 và nhỏ hơn 10 ký tự. ")]
        public string baseAsset { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập Qoute Asset.")]
        [Display(Name = "Qoute Asset")]
        [StringLength(10, MinimumLength = 2, ErrorMessage = "Qoute Asset phải lớn hơn 2 và nhỏ hơn 10 ký tự. ")]
        public string quoteAsset { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập số tiền.")]
        [Display(Name = "Last Price")]
        [Range(10, maximum: Double.MaxValue, ErrorMessage = "Số tiền không hợp lệ")]
        public double lastPrice { get; set; }
        public double volumn24h { get; set; }
        public string marketId { get; set; }
        public virtual Market Market { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime deletedAt { get; set; }
        public CoinStatus Status { get; set; }

    }

    public enum CoinStatus
    {
        ActiActive = 1,
        Deactive = 0,
        Delete = -1
    }
}