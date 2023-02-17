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

        public byte[] GetPlanImageByAstateId(Guid id)
        {
            return context.Images.Where(x => x.StateId == id).FirstOrDefault()._Image;
        }

        public List<byte[]> GetPlanImagesByAstateId(Guid id)
        {
            return context.Images.Where(x => x.StateId == id).Skip(1).Select(x => x._Image).ToList();
        }
    }
}
