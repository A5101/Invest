using Invest.Domain.Repositories.Abstract;
namespace Invest.Domain
{
    public class DataManager
    {
        public IImageRepository Images { get; set; }
        public IFavoriteRepository Favorites { get; set; }
        public IHistoryPriceRepository HistoryPrices { get; set; }
        public IRealAstateRepository RealAstates { get; set; }

        public DataManager(IRealAstateRepository realAstateRepository, IFavoriteRepository favoriteRepository, IImageRepository imageRepository, IHistoryPriceRepository historyPriceRepository)
        {
            Images = imageRepository;
            Favorites = favoriteRepository;
            HistoryPrices = historyPriceRepository;
            RealAstates = realAstateRepository;
        }
    }
}
