using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedInPostJob.Shared
{
   public class Job
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Location { get; set; }

        public string Company { get; set; }

        public string JobType { get; set; }

        public string PostedBy { get; set; }

        public string Description { get; set; }

        public string Compensation { get; set; }

        public string Department { get; set; }

    }
}
