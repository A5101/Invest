using Invest.Domain.Entities;

namespace Invest.Domain.Repositories.Abstract
{
    public interface IImageRepository
    {
        public byte[] GetPlanImageByAstateId(Guid id);
        public List<byte[]> GetPlanImagesByAstateId(Guid id);
        public void AddImage(Image image);
    }
}
