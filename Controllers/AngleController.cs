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
        string timeSeparator = ":";

        // POST: api/Angle
        [HttpPost]
        public IActionResult Post([FromBody] string time)
        {
            if (String.IsNullOrWhiteSpace(time) || !time.Contains(timeSeparator))
            {
                return BadRequest();
            }
            try
            {
                var splittedValues = time.Split(timeSeparator);
                var timeModel = new ClockModel
                {
                    Hour = Convert.ToInt32(splittedValues[0]),
                    Min = Convert.ToInt32(splittedValues[1])
                };
                var angle = Util.ConvertToAngle(timeModel);

                //Todo Save
                return Ok(new
                {
                    Message = $"Angle between {timeModel.Hour} h and {timeModel.Min} m is {angle} degree.",
                    Angel = angle
                });

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }



        }


    }
}
