using Microsoft.AspNetCore.Mvc;
using StayHard.Data;
using StayHard.Data.Models;
using StayHard.Modules.ViewModels;

namespace StayHard.Modules.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class GradController : ControllerBase
    {
        private readonly ApplicationDBContext _dbContext;
        public GradController(ApplicationDBContext dBContext)
        {
            _dbContext = dBContext;
        }
        [HttpPost]

        public Grad Dodaj([FromBody] GradDodajVM x)
        {
            Grad? objekat;
            if(x.GradID == 0)
            {
                objekat = new Grad();
                _dbContext.Add(objekat);
            }
            else
            {
                objekat = _dbContext.Grad.Find(x.GradID);
            }
            objekat.NazivGrada = x.NazivGrada;
            objekat.Drzava = x.Drzava;

            _dbContext.SaveChanges();
            return objekat;
        }
        [HttpGet]

        public ActionResult GetAll()
        {
            var data = _dbContext.Grad.OrderBy(s => s.NazivGrada).Select(s => new Grad()
            {
                GradID = s.GradID,
                NazivGrada = s.NazivGrada,
                Drzava = s.Drzava
            });
            return Ok(data.ToList());
        }
    }
}
