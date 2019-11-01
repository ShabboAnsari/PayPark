﻿using System.ComponentModel.DataAnnotations;

namespace PayNPark.Models
{
    public class UserMaster
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; } 

    }
}