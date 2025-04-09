using BackEnd.DTO;

namespace BackEnd.Services.Interfaces
{
    public interface ICultureService
    {
        CultureDTO Get(string id);
        List<CultureDTO> GetAll();
        CultureDTO Add(CultureDTO cultureDTO);
        CultureDTO Update(CultureDTO cultureDTO);
        CultureDTO Delete(string id);
    }
}
