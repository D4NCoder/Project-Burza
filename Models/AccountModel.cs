using Project_Burza.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Burza.Models
{
    public class AccountModel
    {
        public ApplicationUser User { get; set; }

        public IEnumerable<TripModel> TripPosts { get; set; }
    }
}
