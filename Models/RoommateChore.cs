using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roommates.Models
{
    public class RoommateChore
    {
        public int Id { get; set; }
        public Roommate RoommateId { get; set; }
        public Chore ChoreId { get; set; }
    }
}
