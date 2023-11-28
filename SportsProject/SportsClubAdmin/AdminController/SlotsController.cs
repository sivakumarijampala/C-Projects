
using Microsoft.AspNetCore.Mvc;
using Models;
using SportClubProject.AdminRepository;

namespace SportClubProject.AdminController
{
    [Route("api/[controller]")]
    [ApiController]
    public class SlotsController : ControllerBase
    {

        private readonly ISlotsRepository slotsRepository;
        public SlotsController(ISlotsRepository slotsRepository)
        {
            this.slotsRepository = slotsRepository;
        }



        //get all slots
        [HttpGet("getallslots")]
        public IEnumerable<Slots> GetAllSlots()
        {
            IEnumerable<Slots> slots =slotsRepository.GetAllSlots().ToList();
            return slots;
        }


        //save slot
        [HttpPost("saveslot")]
        public Slots SaveSlot(Slots slot)
        {
            Slots slots= slotsRepository.SaveSlot(slot);
            return slots;
        }

        //delete slot
        [HttpDelete("deleteslot")]
        public Slots DeleteSlot(int id)
        {
            Slots slots = slotsRepository.DeleteSlot(id);
            return slots;
        }


        //update slot
        [HttpPut("updateslot")]
        public Slots UpdateSport(Slots slot,int id)
        {
            Slots slots = slotsRepository.UpdateSlot(slot,id);
            return slots;

        }

    }
}
