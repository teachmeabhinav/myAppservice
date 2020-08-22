using Microsoft.AspNetCore.Mvc;
using SLB_Clock.Models.DomainModel;
using SLB_Clock.Utility;
using System;

namespace SLB_Clock.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
   
    public class AngleController : ControllerBase
    {
 
        // POST: api/Angle
        [HttpPost]
        public IActionResult Post([FromBody] ClockModel model)
        {
            if (model == null)
            {
                return BadRequest();
            }
            try
            {
               var angle = Util.ConvertToAngle(model);
               //Todo Save
               return Ok(angle);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }



        }

       
    }
}
