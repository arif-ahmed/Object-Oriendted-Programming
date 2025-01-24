using AssetSync.CLI.Models;
using AssetSync.CLI.Repositories.Contracts;
using System.Linq;
using System.Linq.Expressions;

namespace AssetSync.CLI.Repositories
{
    public class LocalFolderRepository : IRepository<LocalFolder>
    {
        private readonly List<LocalFolder> collection = new List<LocalFolder> 
        {
            new LocalFolder { Path = "A" },
            new LocalFolder { Path = "A" },
            new LocalFolder { Path = "B" },
            new LocalFolder { Path = "C" }
        };  
        public async Task Insert(LocalFolder entity)
        {

        }

        public async Task<IQueryable<LocalFolder>> Search(Expression<Func<LocalFolder, bool>> expression)
        {
            var compiledExpression = expression.Compile();           
            return await Task.FromResult(collection.Where(compiledExpression).AsQueryable());
        }
    }
}
