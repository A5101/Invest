namespace Invest.Domain.Repositories.Abstract
{
    public interface IHistoryPriceRepository
    {
        public int[] GetHistoryPrice(Guid id);
        public string[] GetHistoryDate(Guid id);
    }
}
