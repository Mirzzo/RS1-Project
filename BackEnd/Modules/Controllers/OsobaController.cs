using Microsoft.AspNetCore.Mvc;
using StayHard.Data;
using StayHard.Data.Models;
using StayHard.Modules.ViewModels;

namespace StayHard.Modules.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class OsobaController : ControllerBase
    {
        private readonly ApplicationDBContext _dbContext;
        public OsobaController(ApplicationDBContext dBContext)
        {
            _dbContext = dBContext;
        }
        [HttpPost]
        public Osoba OsobaRegistracija([FromBody] OsobaRegistracijaVM osoba)
        {
            Osoba? objekat;
            if(osoba.OsobaID == 0)
            {
                objekat = new Osoba();
                _dbContext.Add(objekat);
            }
            else
            {
                objekat = _dbContext.Osoba.Find(osoba.OsobaID);
            }
            objekat.Ime = osoba.Ime;
            objekat.Prezime = osoba.Prezime;
            objekat.GradId = osoba.GradID;
            objekat.KarticaID = osoba.KarticaID;
            objekat.BrojTelefona = osoba.BrojTelefona;
            objekat.DatumRodjenja = osoba.DatumRodjenja;
            //objekat.Slika = osoba.Slika;

            _dbContext.SaveChanges();
            return objekat;
        }
    }
}
