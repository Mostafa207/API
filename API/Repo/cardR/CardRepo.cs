using API.Date;
using API.DTO;
using API.Models;

namespace API.Repo.cardR
{
    public class CardRepo:ICardRepo
    {
        private readonly Appdbcontext context;

        public CardRepo(Appdbcontext context)
        {
            this.context = context;
        }

        public void Add(CardDTO cardDTO)
        {
            var card = new Card
            {
                CardHolderName = cardDTO.CardHolderName,
                CardNumber = cardDTO.CardNumber,
                ExpiryMonth = cardDTO.ExpiryMonth,
                ExpiryYear = cardDTO.ExpiryYear,
                CVV= cardDTO.CVV,
                
            };

            context.Cards.Add(card);
            context.SaveChanges();
        }

        
        public CardDTO Get(CardDTO cardDTO)
        {
            var card = context.Cards.FirstOrDefault(c => c.Id == cardDTO.);
            if (card == null)
            {
                throw new KeyNotFoundException("Card not found.");
            }

            return new CardDTO
            {
                CardNumber = card.CardNumber,
                CardHolderName = card.CardHolderName, 
                ExpiryMonth = card.ExpiryMonth,
                ExpiryYear=card.ExpiryYear,
                CVV = card.CVV
            };
        }
    }
}
