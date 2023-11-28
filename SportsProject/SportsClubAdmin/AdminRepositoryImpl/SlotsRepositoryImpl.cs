
using Models;
using SportClubProject.Repository;

namespace SportClubProject.AdminRepository
{
    public class SlotsRepositoryImpl : ISlotsRepository

    {

        private readonly SportsDbContext sportsDbContext;
        public SlotsRepositoryImpl(SportsDbContext sportsDbContext)
        {
            this.sportsDbContext = sportsDbContext;
        }

        
        //get all slots
        public IEnumerable<Slots> GetAllSlots()
        {
            return sportsDbContext.Slots.ToList();
        }


        //get slot by id
        public Slots GetSlot(int id)
        {
            return sportsDbContext.Slots.Find(id);
        }


        //save slot
        public Slots SaveSlot(Slots slot)
        {
            sportsDbContext.Slots.Add(slot);
            sportsDbContext.SaveChanges();
            return slot;

        }


        //delete slot
        public Slots DeleteSlot(int id)
        {
            Slots slot = sportsDbContext.Slots.Find(id);
            if (slot != null)
            {
                sportsDbContext.Slots.Remove(slot);
                sportsDbContext.SaveChanges();
            }
            return slot;
        }


        //update slot
        public Slots UpdateSlot(Slots slot,int id)
        {

            var existingSlot = sportsDbContext.Slots.FirstOrDefault(s => s.SlotId == id);
            if (existingSlot != null)
            {
                existingSlot.SlotTime = slot.SlotTime;
                existingSlot.Day = slot.Day;
              
                sportsDbContext.SaveChanges();
            }
            return existingSlot;
        }

    }

       
      
    }

