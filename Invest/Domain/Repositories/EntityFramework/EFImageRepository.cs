using Invest.Domain.Repositories.Abstract;

namespace Invest.Domain.Repositories.EntityFramework
{
    public class EFImageRepository:IImageRepository
    {
        private readonly AppDbContext context;

        public EFImageRepository(AppDbContext context)
        {
            this.context = context;
        }
    }
}
