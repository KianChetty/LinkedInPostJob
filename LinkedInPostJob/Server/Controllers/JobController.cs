using LinkedInPostJob.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Server.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinkedInPostJob.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public JobController(ApplicationDbContext context) 
        {
            this.context = context;
        }


        [HttpGet]
        public async Task<IList<Job>> GetJobs()
        {
            var results = context.Jobs.ToList();

            return results; 
        }


        [HttpPost]
        public async Task CreateJob([FromBody] Job job)
        {
            context.Jobs.Add(job);
            context.SaveChanges(); 
        }


    }
}
