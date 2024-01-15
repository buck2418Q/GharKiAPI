using GharKiAPI.Models;

namespace GharKiAPI.Repository.IRepository
{
    public interface INationalParkRepository
    {
        ICollection<NationalPark> GetNationalParks();
        NationalPark GetNationalPark(int nationalParkId);
        bool NationalParkExist(int nationalParkId);
        bool NationalParkExist(string nationalParkName);
        bool CreateNationalPark (NationalPark nationalPark);
        bool UpdateNationalPark (NationalPark nationalPark);
        bool DeleteNationalPark (NationalPark nationalPark);
        bool save();


    }
}
