using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Owner.API.Modal;
using Owner.API.Modal.Data;
using System.Collections.Generic;
using System.Linq;

namespace Owner.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OwnerController : ControllerBase
    {
        //Listing process was performed with "HttpGet".
        [Route("AllParticipant")]
        [HttpGet]
        public List<Participant> GetAllParticipant()
        {
            return new List<Participant>
            {
                new Participant
                {
                    Id = 54,
                    Name= "Elisabeth",
                    Surname="Star",
                    Date="24.10.2022",
                    Description="CEO of Starlink Ins.",
                    Type="VIP member"

                },

                 new Participant
                {
                    Id = 78,
                    Name= "Tim",
                    Surname="Iron",
                    Date="25.10.2022",
                    Description="IK of Moon Ins.",
                    Type="GOLD member"
                    
                },

                 new Participant
                {
                    Id = 98,
                    Name= "Klaus",
                    Surname="Mikealson",
                    Date="28.10.2022",
                    Description="Head of IT Department",
                    Type="SILVER member"

                }

            };
        }

        //The process of checking the description was performed with "HttpPost".
        [HttpPost("Add")]
        public IActionResult AddParticipant(Participant modal)
        {
            var participants = new List<Participant>();

            var or = modal.Description.Contains("Hack");
            if (or == true)
            {
                return StatusCode(StatusCodes.Status204NoContent);
            }
            
            participants.Add(modal);
            return StatusCode(StatusCodes.Status200OK);          



        }

        //The deletion process with id was performed with "HttpDelete".
        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {

            var participants = new ParticipantData().GetAllParticipant();
            
            var participant = participants.FirstOrDefault(x => x.Id == id);
            if (participant == null)
                return NotFound($"Participant with Id = {id} is not found.");
            participants.Remove(participant);
            
            return Ok($"The participant with Id = {id} is successfully deleted.");          
              

            
            
        }

        //The process of updating the incoming model was done with "HttpPut".
        [HttpPut("{id:int}")]
        public IActionResult Update(int id, Participant participant)
        {
            if (id != participant.Id)
                return BadRequest("No match was found. Check the id numbers!");

            return Ok(participant);
          
        }



           
    
    }        

    
}
