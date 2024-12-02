using API.DTO;

namespace API.Repo.DetailsR
{
    public interface IDetailsRepo
    {
        public List<DetailsDTO> GetAll();
    }
}
