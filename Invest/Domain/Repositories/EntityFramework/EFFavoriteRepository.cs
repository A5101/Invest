using Invest.Domain.Repositories.Abstract;

namespace Invest.Domain.Repositories.EntityFramework
{
    public class EFFavoriteRepository :IFavoriteRepository
    {
        private readonly AppDbContext context;

        public EFFavoriteRepository(AppDbContext context)
        {
            this.context = context;
        }
    }
}
