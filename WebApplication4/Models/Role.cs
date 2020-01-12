using System;
using Microsoft.AspNet.Identity.EntityFramework;

namespace WebApplication4.Models
{
    public class Role : IdentityRole
    {
        public string Description { get; set; }
        public DateTime createdAt { get; set; }
    }
}