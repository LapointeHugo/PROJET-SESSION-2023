using ProjetSessionHL.Data;
using ProjetSessionHL.Models;

namespace ProjetSessionHL.Services
{
    public class ParentService : ServiceBaseAsync<Parent>, IParentService
    {
        public ParentService(ProjetSessionDbContext dbContext) : base(dbContext) { }
    }
}
