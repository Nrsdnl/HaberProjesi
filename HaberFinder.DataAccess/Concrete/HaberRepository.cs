using HaberFinder.DataAccess.Abstract;
using HaberFinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HaberFinder.DataAccess.Concrete
{
    public class HaberRepository : IHaberRepository
    {
        public Haber CreateHaber(Haber haber)
        {
            using (var haberDbContext = new HaberDbContext())
            {
                haberDbContext.Habers.Add(haber);
                haberDbContext.SaveChanges();
                return haber;
            }
        }

        public void DeleteHaber(int id)
        {
            using (var haberDbContext = new HaberDbContext())
            {
                var deleteHaber = GetHaberById(id);
                haberDbContext.Habers.Remove(deleteHaber);
                haberDbContext.SaveChanges();
            }
        }

        public List<Haber> GetAllHabers()
        {
            using (var haberDbContext=new HaberDbContext())
            {
                return haberDbContext.Habers.ToList();
            }
        }

        public Haber GetHaberById(int id)
        {
            using (var haberDbContext = new HaberDbContext())
            {
                return haberDbContext.Habers.Find(id);
            }
        }

        public Haber UpdateHaber(Haber haber)
        {
            using (var haberDbContext = new HaberDbContext())
            {
                haberDbContext.Habers.Update(haber);
                haberDbContext.SaveChanges();
                return haber;

            }
        }
    }
}
