using Invest.Domain.Entities;
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

        public int[] GetHistoryPrice(Guid id)
        {
            var temp = context.HistoryPrices.Where(x => x.StateId == id).OrderBy(x => x.Date);
            return temp.Select(x => x.Price).ToArray();
        }

        public string[] GetHistoryDate(Guid id)
        {
            var temp = context.HistoryPrices.Where(x => x.StateId == id).OrderBy(x => x.Date);
            return temp.Select(x => x.Date.ToString()).ToArray();
        }

        public void AddHistory(Guid id, int price, DateTime date)
        {
            context.Add(new HistoryPrice { Date = date, Price = price, StateId = id});
            context.SaveChanges();
        }
    }
}
