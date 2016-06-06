using RestSharp;
using Sdk.Trello.ViewModels.Entitys;

namespace Sdk.Trello.Services
{
    /// <summary>
    /// 在list中新增card
    /// </summary>
    public class CardsService
    {
        public CardEntity Execute(string listId, string cardName)
        {
            var client = new RestClient(
                string.Format("{0}1/cards?key={1}&token={2}",
                Config.ApiUri,
                Config.Key,
                Config.Token));
            var request = new RestRequest(Method.POST);
            request.AddHeader("content-type", "application/json");
            request.AddParameter("application/json", "{\n    \"name\": \""+cardName+"\",\n    \"idList\": \""+listId+"\"\n}", ParameterType.RequestBody);
            return client.Execute<CardEntity>(request).Data;
        }
    }
}
