using BackEnd.DTO;
using BackEnd.Services.Interfaces;
using DAL.Interfaces;
using Entities.Entities;
using System.Threading;

namespace BackEnd.Services.Implementations
{
    public class CultureService : ICultureService
    {
        IUnidadDeTrabajo _unidadDeTrabajo;

        public CultureService(IUnidadDeTrabajo unidadDeTrabajo)
        {
            _unidadDeTrabajo = unidadDeTrabajo;
        }

        CultureDTO Convertir(Culture culture)
        {
            return new CultureDTO
            {
                CultureId = culture.CultureId,
                Name = culture.Name
            };
        }
        Culture Convertir(CultureDTO cultureDTO)
        {
            return new Culture
            {
                CultureId = cultureDTO.CultureId,
                Name = cultureDTO.Name,
                ModifiedDate = DateTime.Now
            };
        }

        public CultureDTO Add(CultureDTO cultureDTO)
        {
            _unidadDeTrabajo.cultureDAL.Add(Convertir(cultureDTO));
            _unidadDeTrabajo.Complete();
            return cultureDTO;
        }

        public CultureDTO Delete(string id)
        {
            Culture tarea = new Culture { CultureId = id };
            _unidadDeTrabajo.cultureDAL.Remove(tarea);
            _unidadDeTrabajo.Complete();
            return Convertir(tarea);
        }

        public CultureDTO Get(string id)
        {
            var tarea = _unidadDeTrabajo.cultureDAL.Get(id);
            return Convertir(tarea);
        }

        public List<CultureDTO> GetAll()
        {
            var cultures = _unidadDeTrabajo.cultureDAL.GetAll();
            List<CultureDTO> culturesDTO = new List<CultureDTO>();
            foreach (var culture in cultures)
            {
                culturesDTO.Add(Convertir(culture));
            }
            return culturesDTO;
        }

        public CultureDTO Update(CultureDTO cultureDTO)
        {
            _unidadDeTrabajo.cultureDAL.Update(Convertir(cultureDTO));
            _unidadDeTrabajo.Complete();
            return cultureDTO;
        }
    }
}
