using BasicITSchool_Stage_4.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BasicITSchool_Stage_4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        //[HttpGet("GetPlayerInfo")]
        [HttpGet("GetPlayerInfo/{id}")]
        public IActionResult Get(int id)
        {
            if (id == 6)
            {
                ResponsePlayerModel playerModel = new ResponsePlayerModel();
                playerModel.Age = 8;
                playerModel.Name = "Sepuh";
                playerModel.Surname = "Gafestjian";

                return Ok(playerModel);                
            }
            return BadRequest();
        }

        [HttpPost("PostExample")]
        public IActionResult Post(RequestPlayerModel model)
        {
            
                ResponsePlayerModel playerModel = new ResponsePlayerModel();
                playerModel.Age = model.Id;
                playerModel.Name = model.Name;
                playerModel.Surname = "Gafestjian";
                return Ok(playerModel);            
           
        }

        [HttpDelete("DeleteExample")]
        public IActionResult Delete(RequestPlayerModel model)
        {

            ResponsePlayerModel playerModel = new ResponsePlayerModel();
            playerModel.Age = model.Id;
            playerModel.Name = model.Name;
            playerModel.Surname = "Gafestjian";
            return Ok(playerModel);

        }

        [HttpPut("PutExample")]
        public IActionResult Put(RequestPlayerModel model)
        {

            ResponsePlayerModel playerModel = new ResponsePlayerModel();
            playerModel.Age = model.Id;
            playerModel.Name = model.Name;
            playerModel.Surname = "Gafestjian";
            return Ok(playerModel);

        }


    }
}
