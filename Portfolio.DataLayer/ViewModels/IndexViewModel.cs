using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Portfolio.DataLayer.Models;

namespace Portfolio.DataLayer.ViewModels
{
    class IndexViewModel
    {
        public Personal Personal { get; set; }
        public Service Service { get; set; }
        public List<Models.Portfolio> Portfolios { get; set; }
        public List<Skill> Skills { get; set; }
        public Contact Contact { get; set; }
        public List<Blog> Blogs { get; set; }
        public List<SkillDisplay> SkillsDisplay { get; set; }
    }
}
