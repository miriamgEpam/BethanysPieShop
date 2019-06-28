using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Models
{
    public class ExoticBeberageRepository :IExoticBeberageRepository
    {
        private readonly AppDbContext _appDbContext;  

        public ExoticBeberageRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext; 
        }

       public  void AddExoticBeberage(ExoticBeberage exoticBeberage)
        {
            _appDbContext.ExoticBeberages.Add(exoticBeberage);
            _appDbContext.SaveChanges();
        }

       public  IEnumerable<ExoticBeberage> GetAllExoticBeberages()
        {
            return _appDbContext.ExoticBeberages; 
        }

      public  ExoticBeberage GetExoticBeberage(int ExoticBeberageId)
        {
            return _appDbContext.ExoticBeberages.FirstOrDefault(e => e.ExoticBeberageId == ExoticBeberageId); 
        }
    }
}
