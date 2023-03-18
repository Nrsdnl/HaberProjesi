using HaberFinder.Business.Abstract;
using HaberFinder.DataAccess.Abstract;
using HaberFinder.DataAccess.Concrete;
using HaberFinder.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HaberFinder.Business.Concrete
{
    public class HaberManager : IHaberService
    {
        private IHaberRepository _haberRepository;

        public HaberManager()
        {
            _haberRepository = new HaberRepository();
        }
        public Haber CreateHaber(Haber haber)
        {
            return _haberRepository.CreateHaber(haber);
        }

        public void DeleteHaber(int id)
        {
            _haberRepository.DeleteHaber(id);
        }

        public List<Haber> GetAllHabers()
        {
            return _haberRepository.GetAllHabers();
        }

        public Haber GetHaberById(int id)
        {
            if (id > 0)
            {
                return _haberRepository.GetHaberById(id);
            }

            throw new Exception("id can not be less than 1");
           
        }

        public Haber UpdateHaber(Haber haber)
        {
            return _haberRepository.UpdateHaber(haber);
        }
    }
}
