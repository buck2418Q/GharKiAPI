using GharKiAPI.Data;
using GharKiAPI.Models;
using GharKiAPI.Repository.IRepository;

namespace GharKiAPI.Repository
{
    public class NationalParkRepository : INationalParkRepository
    {
        private readonly ApplicationDbContext _context;
        public NationalParkRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public bool CreateNationalPark(NationalPark nationalPark)
        {
            _context.nationalParks.Add(nationalPark);
            return save();
        }

        public bool DeleteNationalPark(NationalPark nationalPark)
        {
            _context.nationalParks.Remove(nationalPark);
            return save();
        }

        public NationalPark GetNationalPark(int nationalParkId)
        {
            return _context.nationalParks.Find(nationalParkId);
            //same in 42
        }

        public ICollection<NationalPark> GetNationalParks()
        {
            return _context.nationalParks.ToList();
        }

        public bool NationalParkExist(int nationalParkId)
        {
            return _context.nationalParks.Find(nationalParkId) != null ? true : false;
        }

        public bool NationalParkExist(string nationalParkName)
        {
            return _context.nationalParks.Find(nationalParkName) != null ? true : false;
        }

        public bool save()
        {
            return _context.SaveChanges() == 1 ? true : false;
        }

        public bool UpdateNationalPark(NationalPark nationalPark)
        {
            _context.nationalParks.Update(nationalPark);
            return save();
        }
    }
}
