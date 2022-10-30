﻿using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication2.model
{
    public class Hotel
    {
        public int Id { get; set; } 
        public string Name { get; set; }    
        public string Address { get; set; }

        public double rating { get; set; }
        [ForeignKey (nameof(CountryId))]
        public int  CountryId { get; set; }
        public Country Country { get; set; }
    }
}
