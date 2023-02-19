namespace Invest.Domain.Repositories.Abstract
{
    public interface IHistoryPriceRepository
    {
        public double[] GetHistoryPrice(Guid id);
        public string[] GetHistoryDate(Guid id);
        public void AddHistory(Guid id, double price, DateTime date);
        public void Clear();
    }
}
