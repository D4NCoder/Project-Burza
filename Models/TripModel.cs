using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Burza.Models
{
    public class TripModel
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(200)]
        public string AuthorName { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }

        public string Price { get; set; }

        public int Nights { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        [MaxLength(200)]
        public string WebsiteLink { get; set; }

        public DateTime From { get; set; }

        public DateTime To { get; set; }

        [MaxLength(200)]
        public string Location { get; set; }

        [MaxLength(500)]
        public string ProfilePicturePath { get; set; }
    }
}
