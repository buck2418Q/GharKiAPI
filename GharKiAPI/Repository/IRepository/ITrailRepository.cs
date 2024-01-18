using GharKiAPI.Models;

namespace GharKiAPI.Repository.IRepository
{
    public interface ITrailRepository
    {
        ICollection<Trail> GetTrails();
        Trail GetTrail(int TrailId);
        ICollection<Trail> GetTrailNationalPark(int nationalParkId);
        bool TrailExiest(int TrailId);
        bool Trailexist(string TrailName);
        bool CreateTrail(Trail Trail);
        bool UpdateTrail(Trail Trail);
        bool DeleteTrail(Trail Trail);
        bool save();
    }
}
