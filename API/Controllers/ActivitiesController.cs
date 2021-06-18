using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers
{
    public class ActivitiesController : BaseApiController
    {
        private readonly ReactivitiesContext _context;
        public ActivitiesController(ReactivitiesContext context)
        {
            _context = context;

        }

        [HttpGet]
        public async Task<ActionResult<List<Activity>>> GetActivities() {
            
            return await _context.Activities.ToListAsync();
        }

        [HttpGet("id")]
        public async Task<ActionResult<Activity>> GetActivity(Guid id) {
            
            return await _context.Activities.FindAsync(id);
            
        }

        [HttpPost]
        public async Task<ActionResult> AddActivity(Activity activity) {

            if(!ModelState.IsValid) {
                return BadRequest("error");
            }

            _context.Activities.Add(activity);

            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetActivity), new { Id = activity.Id}, activity);

        }
        
    }
}