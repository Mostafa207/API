using API.DTO;

namespace API.Repo.cardR
{
    public interface ICardRepo
    {
        public void Add(CardDTO cardDTO);
        public CardDTO Get(CardDTO cardDTO);
    }
}
