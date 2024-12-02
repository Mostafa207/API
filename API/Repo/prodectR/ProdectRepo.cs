using API.Date;
using API.DTO;
using API.Models;

namespace API.Repo.prodectR
{
    public class ProdectRepo : IProdectRepo
    {
        private readonly Appdbcontext context;

        public List<ProdectDTO> GetAll()
        {
            return context.Prodects
                .Select(prodect => new ProdectDTO
                {
                    ImageUrl = prodect.ImageUrl,
                    Name = prodect.Name,
                    Price = prodect.Price,
                   
                })
                .ToList();
        }


    }
}
