using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Models
{
    public interface IExoticBeberageRepository
    {
         void AddExoticBeberage(ExoticBeberage exoticBeberage);
         IEnumerable<ExoticBeberage> GetAllExoticBeberages();
         ExoticBeberage GetExoticBeberage(int ExoticBeberageId); 

    }
}
