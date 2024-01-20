using Microsoft.AspNetCore.Mvc;
using StayHard.Data;
using StayHard.Data.Models;
using StayHard.Modules.ViewModels;

namespace StayHard.Modules.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class KorisnikController: ControllerBase
    {
        private readonly ApplicationDBContext _dbContext;
        public KorisnikController(ApplicationDBContext dBContext)
        {
            this._dbContext = dBContext;
        }

        public Korisnik Registracija([FromBody] KorisnikRegistracijaVM x)
        {
            Korisnik? objekat;
            if (x.KorisnikID == 0)
            {
                objekat = new Korisnik();
                _dbContext.Add(objekat);
            }
            else
            {
                objekat = _dbContext.Korisnik.Find(x.KorisnikID);
            }
            objekat.KorisnickoIme = x.KorisnickoIme;
            objekat.Email = x.Email;
            objekat.Password = x.Password;

            _dbContext.SaveChanges();
            return objekat;
        }
    }
}
