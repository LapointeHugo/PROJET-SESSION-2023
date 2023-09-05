using Microsoft.EntityFrameworkCore;
using ProjetSessionHL.Data;
using ProjetSessionHL.Services;
using ProjetSessionHL.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetSession_Tests
{
    public class BaseService_Tests
    {
        private DbContextOptions<ProjetSessionDbContext> SetUpInMemory(string uniqueName)
        {
            //var options = new DbContextOptionsBuilder<ProjetSessionDbContext>().UseInMemoryDatabase(uniqueName).Options;
            //SeedInMemoryStore(options);
            //return options;
        }
    }
}
