using HaberFinder.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HaberFinder.Business.Abstract
{
    public interface IHaberService
    {
        List<Haber> GetAllHabers();

        Haber GetHaberById(int id);

        Haber CreateHaber(Haber haber);
        Haber UpdateHaber(Haber haber);

        void DeleteHaber(int id);
    }
}
