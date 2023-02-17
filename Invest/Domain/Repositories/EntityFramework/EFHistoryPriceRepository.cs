using Invest.Domain.Repositories.Abstract;

namespace Invest.Domain.Repositories.EntityFramework
{
    public class EFHistoryPriceRepository : IHistoryPriceRepository
    {
        private readonly AppDbContext context;

        public EFHistoryPriceRepository(AppDbContext context)
        {
            this.context = context;
        }
    }
}
