using GharKiAPI.Data;
using GharKiAPI.Models;
using GharKiAPI.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace GharKiAPI.Repository
{
    public class TrailRepository : ITrailRepository
    {
        private readonly ApplicationDbContext _context;
        public TrailRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public bool CreateTrail(Trail Trail)
        {
            _context.trails.Add(Trail);
            return save();
        }

        public bool DeleteTrail(Trail Trail)
        {
            _context.trails.Remove(Trail);
            return save();
        }

        public Trail GetTrail(int TrailId)
        {
            return _context.trails.Include(t => t.NationalPark).FirstOrDefault(t => t.Id == TrailId);
        }

        public ICollection<Trail> GetTrailNationalPark(int nationalParkId)
        {
            return _context.trails.Include(t => t.NationalPark).ToList();
        }

        public ICollection<Trail> GetTrailsNationalPark(int nationalParkId)
        {
            return _context.trails.Include(t => t.NationalPark).Where(t => t.NationalParkID == nationalParkId).ToList();
        }

        public bool save()
        {
            return _context.SaveChanges() == 1 ? true : false;
        }

        public bool TrailExiest(int TrailId)
        {
            return _context.trails.Any(t => t.Id == TrailId);
        }

        public bool Trailexist(string TrailName)
        {
            return _context.trails.Any(t => t.Name == TrailName);
        }

        public bool UpdateTrail(Trail Trail)
        {
            _context.trails.Update(Trail);
            return save();
        }

        ICollection<Trail> ITrailRepository.GetTrails()
        {
            return _context.trails.Include(t => t.NationalPark).ToList();

        }



    }
}
