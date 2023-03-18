using HaberFinder.Business.Abstract;
using HaberFinder.Business.Concrete;
using HaberFinder.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HaberFinder.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HabersController : ControllerBase
    {
        private IHaberService _haberService;

        public HabersController()
        {
            _haberService = new HaberManager();
        }

       [HttpGet]
       public List<Haber> Get()
        {
            return _haberService.GetAllHabers();
        }
        [HttpGet("{id}")]
        public Haber Get(int id)
        {
            return _haberService.GetHaberById(id);
        }

        [HttpPost]
        public Haber Post([FromBody]Haber haber)
        {
            return _haberService.CreateHaber(haber);
        }
        [HttpPut]
        public Haber Put([FromBody] Haber haber)
        {
            return _haberService.UpdateHaber(haber);
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _haberService.DeleteHaber(id);
        }
    }
}
