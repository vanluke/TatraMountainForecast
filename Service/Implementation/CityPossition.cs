﻿using System.ComponentModel.DataAnnotations;

namespace Service.Implementation
{
    public class CityPossition 
    {
        public CityPossition(string location, string lat, string log)
        {
            Location = location;
            Latitude = lat;
            Longitude = log;
        }

        public CityPossition()
        {
                
        }

        [Key]
        public string Location { get; set; }

        [Required]
        public string Latitude { get; set; }

        [Required]
        public string Longitude { get; set; }
    }
}
