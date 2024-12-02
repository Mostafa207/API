using API.Date;
using API.DTO;

namespace API.Repo.DetailsR
{
    public class DetailsRepo :IDetailsRepo
    {
        private readonly Appdbcontext context;

        public DetailsRepo(Appdbcontext context)
        {
            this.context = context;
        }

        public List<DetailsDTO> GetAll()
        {
            return context.Prodects
            .Select(detail => new DetailsDTO
            {
                Name = detail.Name,
                Description = detail.Description,
                Price = detail.Price,
                ImageUrl = detail.ImageUrl,
                Stock=detail.Stock,
            })
            .ToList();
        }
    }
}
