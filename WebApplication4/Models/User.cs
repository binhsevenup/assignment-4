using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNet.Identity.EntityFramework;

namespace WebApplication4.Models
{
    public class User : IdentityUser
    {
        [Key]
        public string Name { get; set; } 
        public DateTime CreatedAt { get; set; }
    }
}