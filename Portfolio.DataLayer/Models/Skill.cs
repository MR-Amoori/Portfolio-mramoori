using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.DataLayer.Models
{
   public class Skill
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int PersonalId { get; set; }
        public Personal Personal { get; set; }
    }
}
