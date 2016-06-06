using Sdk.Trello.Services;
using Sdk.Trello.ViewModels.Entitys;

namespace Sdk.Trello
{
    public class CardInstance : BaseInstance
    {
        private CardsService CardsService { get; set; }

        public CardInstance(string key, string token) 
            : base(key, token)
        {
            CardsService = new CardsService();
        }

        public CardEntity Cards(string listId, string cardName)
        {
            return CardsService.Execute(listId, cardName);
        }
    }
}
