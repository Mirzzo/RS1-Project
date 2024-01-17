using Microsoft.AspNetCore.Mvc;
using StayHard.Data;
using StayHard.Data.Models;
using StayHard.Modules.ViewModels;

namespace StayHard.Modules.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class KreditnaKarticaController : ControllerBase
    {
      private readonly ApplicationDBContext _dbContext;
        public KreditnaKarticaController(ApplicationDBContext dBContext)
        {
            _dbContext = dBContext;
        }
        [HttpPost]
        public KreditnaKartica Dodaj([FromBody] KarticaDodajVM x)
        {
            KreditnaKartica? objekat;

            if(x.KarticaID == 0)
            {
                objekat = new KreditnaKartica();
                _dbContext.Add(objekat);
            }
            else
            {
                objekat = _dbContext.KreditnaKartica.Find(x.KarticaID);
            }

            objekat.BrojKartice = x.BrojKartice;
            objekat.SigurnosniBroj = x.SigurnosniBroj;
            objekat.DatumIsteka = x.DatumIsteka;

            _dbContext.SaveChanges();
            return objekat;
        }
    }
}
